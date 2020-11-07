namespace MapConvertor
{
    partial class MapConvertor
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapConvertor));
            this.btnInitial = new System.Windows.Forms.Button();
            this.btnRdMap = new System.Windows.Forms.Button();
            this.btnBuild = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tbSimFilePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMapRd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnInitial
            // 
            this.btnInitial.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInitial.Location = new System.Drawing.Point(11, 196);
            this.btnInitial.Margin = new System.Windows.Forms.Padding(2);
            this.btnInitial.Name = "btnInitial";
            this.btnInitial.Size = new System.Drawing.Size(68, 30);
            this.btnInitial.TabIndex = 5;
            this.btnInitial.Text = "Initial";
            this.btnInitial.UseVisualStyleBackColor = true;
            this.btnInitial.Click += new System.EventHandler(this.btnInitial_Click);
            // 
            // btnRdMap
            // 
            this.btnRdMap.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRdMap.Location = new System.Drawing.Point(197, 72);
            this.btnRdMap.Name = "btnRdMap";
            this.btnRdMap.Size = new System.Drawing.Size(100, 30);
            this.btnRdMap.TabIndex = 6;
            this.btnRdMap.Text = "Open OpenDrive";
            this.btnRdMap.UseVisualStyleBackColor = true;
            this.btnRdMap.Click += new System.EventHandler(this.btnRdMap_Click);
            // 
            // btnBuild
            // 
            this.btnBuild.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuild.Location = new System.Drawing.Point(114, 196);
            this.btnBuild.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(68, 30);
            this.btnBuild.TabIndex = 8;
            this.btnBuild.Text = "BuildMap";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(217, 196);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(68, 30);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "SendMap";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.textBox5.Location = new System.Drawing.Point(198, 18);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(87, 21);
            this.textBox5.TabIndex = 11;
            this.textBox5.Text = "1";
            // 
            // tbSimFilePath
            // 
            this.tbSimFilePath.BackColor = System.Drawing.Color.White;
            this.tbSimFilePath.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.tbSimFilePath.Location = new System.Drawing.Point(14, 81);
            this.tbSimFilePath.Name = "tbSimFilePath";
            this.tbSimFilePath.ReadOnly = true;
            this.tbSimFilePath.Size = new System.Drawing.Size(153, 20);
            this.tbSimFilePath.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "OpenDrive Map Path:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.label4.Location = new System.Drawing.Point(12, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Process OpenDrive Resolusion:";
            // 
            // tbMapRd
            // 
            this.tbMapRd.BackColor = System.Drawing.Color.White;
            this.tbMapRd.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.tbMapRd.Location = new System.Drawing.Point(11, 117);
            this.tbMapRd.Multiline = true;
            this.tbMapRd.Name = "tbMapRd";
            this.tbMapRd.ReadOnly = true;
            this.tbMapRd.Size = new System.Drawing.Size(280, 60);
            this.tbMapRd.TabIndex = 12;
            // 
            // MapConvertor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 266);
            this.Controls.Add(this.tbMapRd);
            this.Controls.Add(this.tbSimFilePath);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.btnRdMap);
            this.Controls.Add(this.btnInitial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MapConvertor";
            this.Text = "MapConvertor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInitial;
        private System.Windows.Forms.Button btnRdMap;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox tbSimFilePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMapRd;
    }
}

