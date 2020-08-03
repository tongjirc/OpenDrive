
namespace VehStatus.SPATIntersectionState
{
    /// <summary>
    /// Represents schema type 'Phase' (SEQUENCE)
    /// </summary>
    [System.Serializable]
    public partial class Phase : Oss.Asn1.BaseType
    {
        /// <summary>Field 'id'</summary>
        public int Id { get; set; }
        /// <summary>Field 'phaseStates'</summary>
        public PhaseStateList PhaseStates { get; set; }

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
            Phase that = right as Phase;
            if (Id != that.Id)
                return false;
            if (PhaseStates != null) {
                if (!Oss.Asn1.Internal.Comparer.CompareSeqOf(PhaseStates, that.PhaseStates))
                    return false;
            } else if (that.PhaseStates != null)
                return false;
            return true;
        }

        /// <summary>
        /// Serves as a hash function for a particular type.
        /// </summary>
        /// <returns>A hash code for the current object.</returns>
        public override int GetHashCode()
        {
            int hash = GetType().GetHashCode();
            hash ^= Id.GetHashCode();
            if (PhaseStates != null)
                hash ^= Oss.Asn1.Internal.Comparer.HashSeqOf(PhaseStates);
            return hash;
        }

        /// <summary>
        /// Returns the name of the ASN.1 schema type represented by this class.
        /// </summary>
        /// <returns>the string containing the name of the ASN.1 schema type.</returns>
        public override string GetAsn1TypeName()
        {
            return "Phase";
        }

        /// <summary>
        /// Asserts the validity of this object`s ASN.1 data.
        /// </summary>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the instance contains invalid data.</exception>
        public override void Validate()
        {
            try {
                try {
                    if (this.Id < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    if (this.Id > 255)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Id", "int", "id", "PhaseID", false); throw;
                }
                try {
                    if (this.PhaseStates == null)
                        throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                    this.PhaseStates.Validate();
                    if (this.PhaseStates.Count < 1)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                    if (this.PhaseStates.Count > 16)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "PhaseStates", "PhaseStateList", "phaseStates", "PhaseStateList", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "Phase", null, "Phase", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public override object Copy()
        {
            Phase obj0 = new Phase();
            {
                obj0.Id = this.Id;
            }
            {
                obj0.PhaseStates = this.PhaseStates == null ? null : (PhaseStateList)this.PhaseStates.Copy();
            }
            return obj0;
        }

        protected override void PrintAsn1ValueNotation(Oss.Asn1.Internal.ValueNotationHelper prt)
        {
            try
            {
                prt.BeginConstructedValue();
                {
                    prt.WriteLine();
                    prt.Write("id ");
                    prt.Write(this.Id);
                }
                {
                    PhaseStateList data1 = this.PhaseStates;

                    prt.WriteLine(",");
                    prt.Write("phaseStates ");
                    if (data1 == null)
                        prt.Write("<<<NULL>>>");
                    else {
                        data1.PrintAsn1ValueNotation(prt);
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

        protected override void EncodePer(Oss.Asn1.Internal.PerEncoder enc)
        {
            try {
                try {
                    if (enc.BitCount(this.Id - 0) > 8 || this.Id < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Id);
                    if (enc.IsAligned)
                        enc.Output.WritePadding();
                    enc.Output.Write8BitInt((this.Id - (0)));
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Id", "int", "id", "PhaseID", false); throw;
                }
                try {
                    this.PhaseStates.EncodePer(enc);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "PhaseStates", "PhaseStateList", "phaseStates", "PhaseStateList", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "Phase", null, "Phase", false); throw;
            }
        }

        protected override void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                try {
                    if (dec.IsAligned)
                        dec.Input.SkipPadding();
                    this.Id = 0 + dec.Input.Read8BitInt();
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Id", "int", "id", "PhaseID", false); throw;
                }
                try {
                    PhaseStateList data1 = new PhaseStateList();

                    data1.DecodePer(dec);
                    this.PhaseStates = data1;
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "PhaseStates", "PhaseStateList", "phaseStates", "PhaseStateList", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "Phase", null, "Phase", false); throw;
            }
        }
    }
}
