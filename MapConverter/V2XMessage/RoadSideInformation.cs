
namespace VehStatus.RSI
{
    /// <summary>
    /// Represents schema type 'RoadSideInformation' (SEQUENCE)
    /// </summary>
    [System.Serializable]
    public partial class RoadSideInformation : Oss.Asn1.BaseType
    {
        /// <summary>Field 'msgCnt'</summary>
        public int MsgCnt { get; set; }
        /// <summary>Field 'timeStamp'</summary>
        public int? TimeStamp { get; set; }
        /// <summary>Field 'id'</summary>
        public byte[] Id { get; set; }
        /// <summary>Field 'rsiId'</summary>
        public int RsiId { get; set; }
        /// <summary>Field 'alertType'</summary>
        public int AlertType { get; set; }
        /// <summary>Field 'description'</summary>
        public string Description { get; set; }
        /// <summary>Field 'priority'</summary>
        public byte[] Priority { get; set; }
        /// <summary>Field 'refPos'</summary>
        public DefPosition.Position3D RefPos { get; set; }
        /// <summary>Field 'alertPath'</summary>
        public PathPointList AlertPath { get; set; }
        /// <summary>Field 'alertRadius'</summary>
        public int AlertRadius { get; set; }

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
            RoadSideInformation that = right as RoadSideInformation;
            if (MsgCnt != that.MsgCnt)
                return false;
            if (TimeStamp != null) {
                if (TimeStamp != that.TimeStamp)
                    return false;
            } else if (that.TimeStamp != null)
                return false;
            if (Id != null) {
                if (!Oss.Asn1.Internal.Comparer.CompareArrays(Id, that.Id))
                    return false;
            } else if (that.Id != null)
                return false;
            if (RsiId != that.RsiId)
                return false;
            if (AlertType != that.AlertType)
                return false;
            if (Description != null) {
                if (!Description.Equals(that.Description))
                    return false;
            } else if (that.Description != null)
                return false;
            if (Priority != null) {
                if (!Oss.Asn1.Internal.Comparer.CompareArrays(Priority, that.Priority))
                    return false;
            } else if (that.Priority != null)
                return false;
            if (RefPos != null) {
                if (!RefPos.Equals(that.RefPos))
                    return false;
            } else if (that.RefPos != null)
                return false;
            if (AlertPath != null) {
                if (!Oss.Asn1.Internal.Comparer.CompareSeqOf(AlertPath, that.AlertPath))
                    return false;
            } else if (that.AlertPath != null)
                return false;
            if (AlertRadius != that.AlertRadius)
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
            if (TimeStamp != null)
                hash ^= TimeStamp.GetHashCode();
            if (Id != null)
                hash ^= Oss.Asn1.Internal.Comparer.HashArray(Id);
            hash ^= RsiId.GetHashCode();
            hash ^= AlertType.GetHashCode();
            if (Description != null)
                hash ^= Description.GetHashCode();
            if (Priority != null)
                hash ^= Oss.Asn1.Internal.Comparer.HashArray(Priority);
            if (RefPos != null)
                hash ^= RefPos.GetHashCode();
            if (AlertPath != null)
                hash ^= Oss.Asn1.Internal.Comparer.HashSeqOf(AlertPath);
            hash ^= AlertRadius.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Returns the name of the ASN.1 schema type represented by this class.
        /// </summary>
        /// <returns>the string containing the name of the ASN.1 schema type.</returns>
        public override string GetAsn1TypeName()
        {
            return "RoadSideInformation";
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
                    if (this.TimeStamp != null) {
                        if (this.TimeStamp.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                        if (this.TimeStamp.Value > 527040)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "TimeStamp.Value", "int", "timeStamp", "MinuteOfTheYear", false); throw;
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
                    if (this.RsiId < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    if (this.RsiId > 255)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "RsiId", "int", "rsiId", "INTEGER", false); throw;
                }
                try {
                    if (this.AlertType < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    if (this.AlertType > 65535)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "AlertType", "int", "alertType", "AlertType", false); throw;
                }
                try {
                    if (this.Description != null) {
                        Oss.Asn1.Internal.Validator.ValidateKMCString(this.Description, _InternalMetadata.CommonMetaData.S0);
                        if (this.Description.Length < 1)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                        if (this.Description.Length > 256)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Description", "string", "description", "IA5String", false); throw;
                }
                try {
                    if (this.Priority != null) {
                        if (this.Priority.Length != 1)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Priority", "byte[]", "priority", "Priority", false); throw;
                }
                try {
                    if (this.RefPos == null)
                        throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                    this.RefPos.Validate();
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "RefPos", "DefPosition.Position3D", "refPos", "Position3D", false); throw;
                }
                try {
                    if (this.AlertPath == null)
                        throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                    this.AlertPath.Validate();
                    if (this.AlertPath.Count < 2)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                    if (this.AlertPath.Count > 32)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "AlertPath", "PathPointList", "alertPath", "PathPointList", false); throw;
                }
                try {
                    if (this.AlertRadius < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    if (this.AlertRadius > 1024)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "AlertRadius", "int", "alertRadius", "Radius", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "RoadSideInformation", null, "RoadSideInformation", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public override object Copy()
        {
            RoadSideInformation obj0 = new RoadSideInformation();
            {
                obj0.MsgCnt = this.MsgCnt;
            }
            {
                obj0.TimeStamp = this.TimeStamp;
            }
            {
                obj0.Id = Oss.Asn1.Internal.CopyUtil.CopyByteArray(this.Id);
            }
            {
                obj0.RsiId = this.RsiId;
            }
            {
                obj0.AlertType = this.AlertType;
            }
            {
                obj0.Description = this.Description;
            }
            {
                obj0.Priority = Oss.Asn1.Internal.CopyUtil.CopyByteArray(this.Priority);
            }
            {
                obj0.RefPos = Oss.Asn1.Internal.CopyUtil.CopyType(this.RefPos);
            }
            {
                obj0.AlertPath = this.AlertPath == null ? null : (PathPointList)this.AlertPath.Copy();
            }
            {
                obj0.AlertRadius = this.AlertRadius;
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
                    int? data1 = this.TimeStamp;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("timeStamp ");
                        prt.Write(data1.Value);
                    }
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
                    prt.Write("rsiId ");
                    prt.Write(this.RsiId);
                }
                {
                    prt.WriteLine(",");
                    prt.Write("alertType ");
                    prt.Write(this.AlertType);
                }
                {
                    string data1 = this.Description;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("description ");
                        prt.PrintString(data1);
                    }
                }
                {
                    byte[] data1 = this.Priority;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("priority ");
                        prt.PrintOctetString(data1);
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
                    PathPointList data1 = this.AlertPath;

                    prt.WriteLine(",");
                    prt.Write("alertPath ");
                    if (data1 == null)
                        prt.Write("<<<NULL>>>");
                    else {
                        data1.PrintAsn1ValueNotation(prt);
                    }
                }
                {
                    prt.WriteLine(",");
                    prt.Write("alertRadius ");
                    prt.Write(this.AlertRadius);
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
                byte[] optMask0 = new byte[1];

                enc.Output.WriteBool(extPresent0);
                if (this.TimeStamp != null)
                    optMask0[0] |= (byte)(0x80 >> 0);
                if (this.Description != null)
                    optMask0[0] |= (byte)(0x80 >> 1);
                if (this.Priority != null)
                    optMask0[0] |= (byte)(0x80 >> 2);
                enc.Output.WriteBits(optMask0, 0, 3);
                try {
                    if (enc.BitCount(this.MsgCnt - 0) > 7 || this.MsgCnt < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.MsgCnt);
                    enc.Output.Write7BitInt((this.MsgCnt - (0)));
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "MsgCnt", "int", "msgCnt", "MsgCount", false); throw;
                }
                try {
                    if (this.TimeStamp != null)
                    {
                        if (enc.BitCount(this.TimeStamp.Value - 0) > 20 || this.TimeStamp.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.TimeStamp.Value);
                        enc.EncodeConstrainedInteger((this.TimeStamp.Value - (0)), 20);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "TimeStamp.Value", "int", "timeStamp", "MinuteOfTheYear", false); throw;
                }
                try {
                    enc.EncodeOctetString(this.Id, 8);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Id", "byte[]", "id", "OCTET STRING", false); throw;
                }
                try {
                    if (enc.BitCount(this.RsiId - 0) > 8 || this.RsiId < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.RsiId);
                    if (enc.IsAligned)
                        enc.Output.WritePadding();
                    enc.Output.Write8BitInt((this.RsiId - (0)));
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "RsiId", "int", "rsiId", "INTEGER", false); throw;
                }
                try {
                    if (enc.BitCount(this.AlertType - 0) > 16 || this.AlertType < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.AlertType);
                    enc.EncodeConstrainedInteger((this.AlertType - (0)), 16);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "AlertType", "int", "alertType", "AlertType", false); throw;
                }
                try {
                    if (this.Description != null)
                    {
                        enc.EncodeKMCString(this.Description, 1, 256, _InternalMetadata.CommonMetaData.S0);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Description", "string", "description", "IA5String", false); throw;
                }
                try {
                    if (this.Priority != null)
                    {
                        enc.EncodeOctetString(this.Priority, 1);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Priority", "byte[]", "priority", "Priority", false); throw;
                }
                try {
                    enc.EncodeType(this.RefPos);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "RefPos", "DefPosition.Position3D", "refPos", "Position3D", false); throw;
                }
                try {
                    this.AlertPath.EncodePer(enc);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "AlertPath", "PathPointList", "alertPath", "PathPointList", false); throw;
                }
                try {
                    if (enc.BitCount(this.AlertRadius - 0) > 11 || this.AlertRadius < 0)
                        throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.AlertRadius);
                    enc.EncodeConstrainedInteger((this.AlertRadius - (0)), 11);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "AlertRadius", "int", "alertRadius", "Radius", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "RoadSideInformation", null, "RoadSideInformation", false); throw;
            }
        }

        protected override void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                bool extPresent0 = dec.Input.ReadBool();
                byte[] optMask0 = new byte[1];

                dec.Input.ReadBits(optMask0, 3);
                try {
                    this.MsgCnt = 0 + dec.Input.Read7BitInt();
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "MsgCnt", "int", "msgCnt", "MsgCount", false); throw;
                }
                if ((optMask0[0] & (0x80 >> 0)) != 0)
                {
                    try {
                        this.TimeStamp = dec.DecodeConstrainedInteger(20, 0);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "TimeStamp", "int", "timeStamp", "MinuteOfTheYear", false); throw;
                    }
                }
                else
                {
                    this.TimeStamp = null;
                }
                try {
                    this.Id = dec.DecodeOctetString(8);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Id", "byte[]", "id", "OCTET STRING", false); throw;
                }
                try {
                    if (dec.IsAligned)
                        dec.Input.SkipPadding();
                    this.RsiId = 0 + dec.Input.Read8BitInt();
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "RsiId", "int", "rsiId", "INTEGER", false); throw;
                }
                try {
                    this.AlertType = dec.DecodeConstrainedInteger(16, 0);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "AlertType", "int", "alertType", "AlertType", false); throw;
                }
                if ((optMask0[0] & (0x80 >> 1)) != 0)
                {
                    try {
                        this.Description = dec.DecodeKMCString(1, 256, _InternalMetadata.CommonMetaData.S0);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Description", "string", "description", "IA5String", false); throw;
                    }
                }
                else
                {
                    this.Description = null;
                }
                if ((optMask0[0] & (0x80 >> 2)) != 0)
                {
                    try {
                        this.Priority = dec.DecodeOctetString(1);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Priority", "byte[]", "priority", "Priority", false); throw;
                    }
                }
                else
                {
                    this.Priority = null;
                }
                try {
                    DefPosition.Position3D data1 = new DefPosition.Position3D();

                    dec.DecodeType(data1);
                    this.RefPos = data1;
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "RefPos", "DefPosition.Position3D", "refPos", "Position3D", false); throw;
                }
                try {
                    PathPointList data1 = new PathPointList();

                    data1.DecodePer(dec);
                    this.AlertPath = data1;
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "AlertPath", "PathPointList", "alertPath", "PathPointList", false); throw;
                }
                try {
                    this.AlertRadius = dec.DecodeConstrainedInteger(11, 0);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "AlertRadius", "int", "alertRadius", "Radius", false); throw;
                }
                if (extPresent0)
                {
                    int extMaskLen0 = 0;
                    byte[] extMask0 = dec.DecodeExtPreamble(out extMaskLen0);

                    dec.SkipUnknownExtensions(extMask0, extMaskLen0, 0);
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "RoadSideInformation", null, "RoadSideInformation", false); throw;
            }
        }
    }
}
