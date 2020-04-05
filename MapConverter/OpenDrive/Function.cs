using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace OpenDrive
{
    static class Function
    {
        static public XmlNodeList GetNodeChilds(XmlNode node, string name)
        {
            string text = "<" + node.Name + "> " + node.InnerXml + "</" + node.Name + ">";
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(text);
            XmlNodeList nl = doc.DocumentElement.SelectNodes("//" + name + "");
            return nl;
        }

        /// <summary>
        /// curve regression
        /// </summary>
        /// <param name="arrX">X point array</param>
        /// <param name="arrY">Y point array</param>
        /// <param name="length">point number</param>
        /// <param name="dimension">the dimension of the function</param>
        /// <returns>a0,a1,...</returns>
        public static double[] MultiLine(double[] arrX, double[] arrY, int length, int dimension)//二元多次线性方程拟合曲线
        {
            int n = dimension + 1;                  //dimension次方程需要求 dimension+1个 系数
            double[,] Guass = new double[n, n + 1];      //高斯矩阵 例如：y=a0+a1*x+a2*x*x
            for (int i = 0; i < n; i++)
            {
                int j;
                for (j = 0; j < n; j++)
                {
                    Guass[i, j] = SumArr(arrX, j + i, length);
                }
                Guass[i, j] = SumArr(arrX, i, arrY, 1, length);
            }

            return ComputGauss(Guass, n);

        }

        public static double SumArr(double[] arr, int n, int length) //求数组的元素的n次方的和
        {
            double s = 0;
            for (int i = 0; i < length; i++)
            {
                if (arr[i] != 0 || n != 0)
                    s = s + Math.Pow(arr[i], n);
                else
                    s = s + 1;
            }
            return s;
        }
        public static double SumArr(double[] arr1, int n1, double[] arr2, int n2, int length)
        {
            double s = 0;
            for (int i = 0; i < length; i++)
            {
                if ((arr1[i] != 0 || n1 != 0) && (arr2[i] != 0 || n2 != 0))
                    s = s + Math.Pow(arr1[i], n1) * Math.Pow(arr2[i], n2);
                else
                    s = s + 1;
            }
            return s;

        }

        public static double[] ComputGauss(double[,] Guass, int n)
        {
            int i, j;
            int k, m;
            double temp;
            double max;
            double s;
            double[] x = new double[n];
            for (i = 0; i < n; i++) x[i] = 0.0;//初始化
            for (j = 0; j < n; j++)
            {
                max = 0;
                k = j;
                for (i = j; i < n; i++)
                {
                    if (Math.Abs(Guass[i, j]) > max)
                    {
                        max = Guass[i, j];
                        k = i;
                    }
                }

                if (k != j)
                {
                    for (m = j; m < n + 1; m++)
                    {
                        temp = Guass[j, m];
                        Guass[j, m] = Guass[k, m];
                        Guass[k, m] = temp;
                    }
                }

                if (0 == max)
                {
                    // "此线性方程为奇异线性方程" 
                    return x;
                }

                for (i = j + 1; i < n; i++)
                {
                    s = Guass[i, j];
                    for (m = j; m < n + 1; m++)
                    {
                        Guass[i, m] = Guass[i, m] - Guass[j, m] * s / (Guass[j, j]);
                    }
                }


            }//结束for (j=0;j<n;j++)


            for (i = n - 1; i >= 0; i--)
            {
                s = 0;
                for (j = i + 1; j < n; j++)
                {
                    s = s + Guass[i, j] * x[j];
                }
                x[i] = (Guass[i, n] - s) / Guass[i, i];
            }

            return x;
        }//返回值是函数的系数


        /// <summary>
        /// Calculate the slop and interp
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void LinearFit(double[] x, double[] y, out double a, out double b)
        {
            double xsum = 0;
            double ysum = 0;
            double xysum = 0;
            double x2sum = 0;
            int m = x.Length;
            for (int i = 0; i < m; i++)
            {
                xsum = xsum + x[i];
                ysum = ysum + y[i];
                xysum = xysum + x[i] * y[i];
                x2sum = x2sum + x[i] * x[i];
            }
            a = (m * xysum - xsum * ysum) / (m * x2sum - xsum * xsum + 1e-10);
            b = (ysum - a * xsum) / m;
            return;
        }

        /// <summary>
        /// Calculate the yfit
        /// </summary>
        /// <param name="x"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="y"></param>
        public static void LinearVal(double[] x, double a, double b, double[] y)
        {
            for (int i = 0; i < x.Length; i++)
            {
                y[i] = a * x[i] + b;
            }
        }

        /// <summary>
        /// Calculate the R2
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        public static double Corrcoef(double[] d1, double[] d2)
        {
            double xy = 0, x = 0, y = 0, xsum = 0, ysum = 0;
            double corrc;
            int m = d1.Length;
            for (int i = 0; i < m; i++)
            {
                xsum += d1[i];
                ysum += d2[i];
            }
            for (int i = 0; i < m; i++)
            {
                x = x + (m * d1[i] - xsum) * (m * d1[i] - xsum);
                y = y + (m * d2[i] - ysum) * (m * d2[i] - ysum);
                xy = xy + (m * d1[i] - xsum) * (m * d2[i] - ysum);
            }
            corrc = Math.Abs(xy) / (Math.Sqrt(x) * Math.Sqrt(y));
            return corrc;

        }
    }
}
