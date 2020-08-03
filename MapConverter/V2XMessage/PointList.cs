
namespace VehStatus.MapPoint
{
    /// <summary>
    /// Represents schema type 'PointList' (SEQUENCE OF)
    /// </summary>
    [System.Serializable]
    public partial class PointList : System.Collections.Generic.List<RoadPoint>
    {
        /// <summary>
        /// Initializes a new instance of the PointList class that is empty and has the default initial capacity.
        /// </summary>
        public PointList() : base() {}
        /// <summary>
        /// Initializes a new instance of the PointList class that contains elements copied from the specified collection
        /// and has sufficient capacity to accommodate the number of elements copied.
        /// <param name="collection">The collection whose elements are copied to the new PointList.</param>
        /// </summary>
        public PointList(System.Collections.Generic.IEnumerable<RoadPoint> collection) : base(collection) {}
        /// <summary>
        /// Initializes a new instance of the PointList class that is empty and has the specified capacity.
        /// <param name="capacity">The number of elements that the new PointList can initially store.</param>
        /// </summary>
        public PointList(int capacity) : base(capacity) {}


        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="right">The object to compare with this object. </param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false.</returns>
        public override bool Equals(object right)
        {
            if (right == null)
                return false;
            if (object.ReferenceEquals(this, right))
                return true;
            if (this.GetType() != right.GetType())
                return false;
            PointList that = right as PointList;
            return Oss.Asn1.Internal.Comparer.CompareSeqOf(this, that);
        }
        /// <summary>
        /// Serves as a hash function for a particular type.
        /// </summary>
        /// <returns>A hash code for the current object.</returns>
        public override int GetHashCode()
        {
            return GetType().GetHashCode() ^ Oss.Asn1.Internal.Comparer.HashSeqOf(this);
        }

        public override string ToString()
        {
            return Oss.Asn1.BaseType.ToString(PrintAsn1ValueNotation);
        }

        /// <summary>
        /// Asserts the validity of this object`s ASN.1 data.
        /// </summary>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the instance contains invalid data.</exception>
        public void Validate()
        {
            try {
                for (int i1 = 0; i1 < this.Count; i1++)
                {
                    try {
                        this[i1].Validate();
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, System.String.Format("[{0}]", i1), "RoadPoint", "#" + i1.ToString(), "RoadPoint", false); throw;
                    }
                }
                if (this.Count < 2)
                    throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                if (this.Count > 31)
                    throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "PointList", null, "PointList", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public object Copy()
        {
            PointList obj0 = new PointList();
            for (int i0 = 0; i0 < this.Count; i0++) {
                obj0.Add(Oss.Asn1.Internal.CopyUtil.CopyType(this[i0]));
            }
            return obj0;
        }

        public void PrintAsn1ValueNotation(Oss.Asn1.Internal.ValueNotationHelper prt)
        {
            try
            {
                prt.BeginConstructedValue();
                for (int i1 = 0; i1 < this.Count; i1++) {
                    if (i1 != 0)
                        prt.Write(",");
                    if (this[i1] == null)
                        prt.Write("<<<NULL>>>");
                    else {
                        prt.PrintContent(this[i1]);
                    }
                }
                prt.EndConstructedValue();
            }
            catch (System.Exception)
            {
                prt.ResetIndent();
                throw;
            }
        }

        public void EncodePer(Oss.Asn1.Internal.PerEncoder enc)
        {
            try {
                int i0 = 0;
                if (this.Count < 2 || this.Count > 31)
                    throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint, ", length of value = " + this.Count);
                enc.EncodeConstrainedLength(this.Count, 2, 31);
                for (i0 = 0; i0 < this.Count; i0++)
                {
                    try {
                        enc.EncodeType(this[i0]);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, System.String.Format("[{0}]", i0), "RoadPoint", "#" + i0.ToString(), "RoadPoint", false); throw;
                    }
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "PointList", null, "PointList", false); throw;
            }
        }

        public void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                int i0 = 0;
                int fragcount0 = 0;
                int fraglast0 = 65536;
                while (true)
                {
                    fragcount0 = dec.DecodeConstrainedLength(2, 31, ref fraglast0);
                    for (i0 = 0; i0 < fragcount0; i0++)
                    {
                        try {
                            RoadPoint data1 = new RoadPoint();

                            dec.DecodeType(data1);
                            this.Add(data1);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, System.String.Format("[{0}]", this.Count), "RoadPoint", "#" + this.Count.ToString(), "RoadPoint", false); throw;
                        }
                    }
                    if (fraglast0 < 0)
                        break;
                    fraglast0 = fragcount0;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "PointList", null, "PointList", false); throw;
            }
        }
    }
}
