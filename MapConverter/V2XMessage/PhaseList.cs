
namespace VehStatus.SPATIntersectionState
{
    /// <summary>
    /// Represents schema type 'PhaseList' (SEQUENCE OF)
    /// </summary>
    [System.Serializable]
    public partial class PhaseList : System.Collections.Generic.List<Phase>
    {
        /// <summary>
        /// Initializes a new instance of the PhaseList class that is empty and has the default initial capacity.
        /// </summary>
        public PhaseList() : base() {}
        /// <summary>
        /// Initializes a new instance of the PhaseList class that contains elements copied from the specified collection
        /// and has sufficient capacity to accommodate the number of elements copied.
        /// <param name="collection">The collection whose elements are copied to the new PhaseList.</param>
        /// </summary>
        public PhaseList(System.Collections.Generic.IEnumerable<Phase> collection) : base(collection) {}
        /// <summary>
        /// Initializes a new instance of the PhaseList class that is empty and has the specified capacity.
        /// <param name="capacity">The number of elements that the new PhaseList can initially store.</param>
        /// </summary>
        public PhaseList(int capacity) : base(capacity) {}


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
            PhaseList that = right as PhaseList;
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
                        Oss.Asn1.Asn1Exception.AppendContext(ex, System.String.Format("[{0}]", i1), "Phase", "#" + i1.ToString(), "Phase", false); throw;
                    }
                }
                if (this.Count < 1)
                    throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                if (this.Count > 16)
                    throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "PhaseList", null, "PhaseList", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public object Copy()
        {
            PhaseList obj0 = new PhaseList();
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
                if (this.Count < 1 || this.Count > 16)
                    throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint, ", length of value = " + this.Count);
                enc.EncodeConstrainedLength(this.Count, 1, 16);
                for (i0 = 0; i0 < this.Count; i0++)
                {
                    try {
                        enc.EncodeType(this[i0]);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, System.String.Format("[{0}]", i0), "Phase", "#" + i0.ToString(), "Phase", false); throw;
                    }
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "PhaseList", null, "PhaseList", false); throw;
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
                    fragcount0 = dec.DecodeConstrainedLength(1, 16, ref fraglast0);
                    for (i0 = 0; i0 < fragcount0; i0++)
                    {
                        try {
                            Phase data1 = new Phase();

                            dec.DecodeType(data1);
                            this.Add(data1);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, System.String.Format("[{0}]", this.Count), "Phase", "#" + this.Count.ToString(), "Phase", false); throw;
                        }
                    }
                    if (fraglast0 < 0)
                        break;
                    fraglast0 = fragcount0;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "PhaseList", null, "PhaseList", false); throw;
            }
        }
    }
}
