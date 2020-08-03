

namespace VehStatus.RSM
{
    /// <summary>
    /// Represents schema type 'RoadsideSafetyMessage' (SEQUENCE)
    /// </summary>
    [System.Serializable]
    public partial class RoadsideSafetyMessage : Oss.Asn1.BaseType
    {
        /// <summary>Field 'msgCnt'</summary>
        public int MsgCnt { get; set; }
        /// <summary>Field 'id'</summary>
        public byte[] Id { get; set; }
        /// <summary>Field 'refPos'</summary>
        public DefPosition.Position3D RefPos { get; set; }
        /// <summary>Field 'participants'</summary>
        public ParticipantList Participants { get; set; }

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
            RoadsideSafetyMessage that = right as RoadsideSafetyMessage;
            if (MsgCnt != that.MsgCnt)
                return false;
            if (Id != null) {
                if (!Oss.Asn1.Internal.Comparer.CompareArrays(Id, that.Id))
                    return false;
            } else if (that.Id != null)
                return false;
            if (RefPos != null) {
                if (!RefPos.Equals(that.RefPos))
                    return false;
            } else if (that.RefPos != null)
                return false;
            if (Participants != null) {
                if (!Oss.Asn1.Internal.Comparer.CompareSeqOf(Participants, that.Participants))
                    return false;
            } else if (that.Participants != null)
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
            hash ^= MsgCnt.GetHashCode();
            if (Id != null)
                hash ^= Oss.Asn1.Internal.Comparer.HashArray(Id);
            if (RefPos != null)
                hash ^= RefPos.GetHashCode();
            if (Participants != null)
                hash ^= Oss.Asn1.Internal.Comparer.HashSeqOf(Participants);
            return hash;
        }

        /// <summary>
        /// Returns the name of the ASN.1 schema type represented by this class.
        /// </summary>
        /// <returns>the string containing the name of the ASN.1 schema type.</returns>
        public override string GetAsn1TypeName()
        {
            return "RoadsideSafetyMessage";
        }

        /// <summary>
        /// Asserts the validity of this object`s ASN.1 data.
        /// </summary>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the instance contains invalid data.</exception>
        public override void Validate()
        {
            try {
                try {
                    if (this.MsgCnt < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    if (this.MsgCnt > 127)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "MsgCnt", "int", "msgCnt", "MsgCount", false); throw;
                }
                try {
                    if (this.Id == null)
                        throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                    if (this.Id.Length != 8)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Id", "byte[]", "id", "OCTET STRING", false); throw;
                }
                try {
                    if (this.RefPos == null)
                        throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                    this.RefPos.Validate();
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "RefPos", "DefPosition.Position3D", "refPos", "Position3D", false); throw;
                }
                try {
                    if (this.Participants == null)
                        throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                    this.Participants.Validate();
                    if (this.Participants.Count < 1)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                    if (this.Participants.Count > 16)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Participants", "ParticipantList", "participants", "ParticipantList", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "RoadsideSafetyMessage", null, "RoadsideSafetyMessage", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public override object Copy()
        {
            RoadsideSafetyMessage obj0 = new RoadsideSafetyMessage();
            {
                obj0.MsgCnt = this.MsgCnt;
            }
            {
                obj0.Id = Oss.Asn1.Internal.CopyUtil.CopyByteArray(this.Id);
            }
            {
                obj0.RefPos = Oss.Asn1.Internal.CopyUtil.CopyType(this.RefPos);
            }
            {
                obj0.Participants = this.Participants == null ? null : (ParticipantList)this.Participants.Copy();
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
                    prt.Write("msgCnt ");
                    prt.Write(this.MsgCnt);
                }
                {
                    prt.WriteLine(",");
                    prt.Write("id ");
                    if (this.Id == null)
                        prt.Write("<<<NULL>>>");
                    else {
                        prt.PrintOctetString(this.Id);
                    }
                }
                {
                    prt.WriteLine(",");
                    prt.Write("refPos ");
                    if (this.RefPos == null)
                        prt.Write("<<<NULL>>>");
                    else {
                        prt.PrintContent(this.RefPos);
                    }
                }
                {
                    ParticipantList data1 = this.Participants;

                    prt.WriteLine(",");
                    prt.Write("participants ");
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
                bool extPresent0 = false;

                enc.Output.WriteBool(extPresent0);
                try {
                    if (enc.BitCount(this.MsgCnt - 0) > 7 || this.MsgCnt < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.MsgCnt);
                    enc.Output.Write7BitInt((this.MsgCnt - (0)));
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "MsgCnt", "int", "msgCnt", "MsgCount", false); throw;
                }
                try {
                    enc.EncodeOctetString(this.Id, 8);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Id", "byte[]", "id", "OCTET STRING", false); throw;
                }
                try {
                    enc.EncodeType(this.RefPos);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "RefPos", "DefPosition.Position3D", "refPos", "Position3D", false); throw;
                }
                try {
                    this.Participants.EncodePer(enc);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Participants", "ParticipantList", "participants", "ParticipantList", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "RoadsideSafetyMessage", null, "RoadsideSafetyMessage", false); throw;
            }
        }

        protected override void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                bool extPresent0 = dec.Input.ReadBool();

                try {
                    this.MsgCnt = 0 + dec.Input.Read7BitInt();
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "MsgCnt", "int", "msgCnt", "MsgCount", false); throw;
                }
                try {
                    this.Id = dec.DecodeOctetString(8);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Id", "byte[]", "id", "OCTET STRING", false); throw;
                }
                try {
                    DefPosition.Position3D data1 = new DefPosition.Position3D();

                    dec.DecodeType(data1);
                    this.RefPos = data1;
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "RefPos", "DefPosition.Position3D", "refPos", "Position3D", false); throw;
                }
                try {
                    ParticipantList data1 = new ParticipantList();

                    data1.DecodePer(dec);
                    this.Participants = data1;
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Participants", "ParticipantList", "participants", "ParticipantList", false); throw;
                }
                if (extPresent0)
                {
                    int extMaskLen0 = 0;
                    byte[] extMask0 = dec.DecodeExtPreamble(out extMaskLen0);

                    dec.SkipUnknownExtensions(extMask0, extMaskLen0, 0);
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "RoadsideSafetyMessage", null, "RoadsideSafetyMessage", false); throw;
            }
        }
    }
}
