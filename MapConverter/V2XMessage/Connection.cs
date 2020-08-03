
namespace VehStatus.MapLane
{
    /// <summary>
    /// Represents schema type 'Connection' (SEQUENCE)
    /// </summary>
    [System.Serializable]
    public partial class Connection : Oss.Asn1.BaseType
    {
        /// <summary>Field 'remoteIntersection'</summary>
        public MapNode.NodeReferenceID RemoteIntersection { get; set; }
        /// <summary>Field 'connectingLane'</summary>
        public MapLane.ConnectingLane ConnectingLane { get; set; }
        /// <summary>Field 'phaseId'</summary>
        public int? PhaseId { get; set; }

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
            Connection that = right as Connection;
            if (RemoteIntersection != null) {
                if (!RemoteIntersection.Equals(that.RemoteIntersection))
                    return false;
            } else if (that.RemoteIntersection != null)
                return false;
            if (ConnectingLane != null) {
                if (!ConnectingLane.Equals(that.ConnectingLane))
                    return false;
            } else if (that.ConnectingLane != null)
                return false;
            if (PhaseId != null) {
                if (PhaseId != that.PhaseId)
                    return false;
            } else if (that.PhaseId != null)
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
            if (RemoteIntersection != null)
                hash ^= RemoteIntersection.GetHashCode();
            if (ConnectingLane != null)
                hash ^= ConnectingLane.GetHashCode();
            if (PhaseId != null)
                hash ^= PhaseId.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Returns the name of the ASN.1 schema type represented by this class.
        /// </summary>
        /// <returns>the string containing the name of the ASN.1 schema type.</returns>
        public override string GetAsn1TypeName()
        {
            return "Connection";
        }

        /// <summary>
        /// Asserts the validity of this object`s ASN.1 data.
        /// </summary>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the instance contains invalid data.</exception>
        public override void Validate()
        {
            try {
                try {
                    if (this.RemoteIntersection == null)
                        throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                    this.RemoteIntersection.Validate();
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "RemoteIntersection", "MapNode.NodeReferenceID", "remoteIntersection", "NodeReferenceID", false); throw;
                }
                try {
                    if (this.ConnectingLane != null) {
                        this.ConnectingLane.Validate();
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "ConnectingLane", "MapLane.ConnectingLane", "connectingLane", "ConnectingLane", false); throw;
                }
                try {
                    if (this.PhaseId != null) {
                        if (this.PhaseId.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                        if (this.PhaseId.Value > 255)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "PhaseId.Value", "int", "phaseId", "PhaseID", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "Connection", null, "Connection", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public override object Copy()
        {
            Connection obj0 = new Connection();
            {
                obj0.RemoteIntersection = Oss.Asn1.Internal.CopyUtil.CopyType(this.RemoteIntersection);
            }
            {
                obj0.ConnectingLane = Oss.Asn1.Internal.CopyUtil.CopyType(this.ConnectingLane);
            }
            {
                obj0.PhaseId = this.PhaseId;
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
                    prt.Write("remoteIntersection ");
                    if (this.RemoteIntersection == null)
                        prt.Write("<<<NULL>>>");
                    else {
                        prt.PrintContent(this.RemoteIntersection);
                    }
                }
                {
                    MapLane.ConnectingLane data1 = this.ConnectingLane;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("connectingLane ");
                        prt.PrintContent(data1);
                    }
                }
                {
                    int? data1 = this.PhaseId;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("phaseId ");
                        prt.Write(data1.Value);
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
                byte[] optMask0 = new byte[1];

                if (this.ConnectingLane != null)
                    optMask0[0] |= (byte)(0x80 >> 0);
                if (this.PhaseId != null)
                    optMask0[0] |= (byte)(0x80 >> 1);
                enc.Output.WriteBits(optMask0, 0, 2);
                try {
                    enc.EncodeType(this.RemoteIntersection);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "RemoteIntersection", "MapNode.NodeReferenceID", "remoteIntersection", "NodeReferenceID", false); throw;
                }
                try {
                    MapLane.ConnectingLane data1 = this.ConnectingLane;

                    if (data1 != null)
                    {
                        enc.EncodeType(data1);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "ConnectingLane", "MapLane.ConnectingLane", "connectingLane", "ConnectingLane", false); throw;
                }
                try {
                    if (this.PhaseId != null)
                    {
                        if (enc.BitCount(this.PhaseId.Value - 0) > 8 || this.PhaseId.Value < 0)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.PhaseId.Value);
                        if (enc.IsAligned)
                            enc.Output.WritePadding();
                        enc.Output.Write8BitInt((this.PhaseId.Value - (0)));
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "PhaseId.Value", "int", "phaseId", "PhaseID", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "Connection", null, "Connection", false); throw;
            }
        }

        protected override void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                byte[] optMask0 = new byte[1];

                dec.Input.ReadBits(optMask0, 2);
                try {
                    MapNode.NodeReferenceID data1 = new MapNode.NodeReferenceID();

                    dec.DecodeType(data1);
                    this.RemoteIntersection = data1;
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "RemoteIntersection", "MapNode.NodeReferenceID", "remoteIntersection", "NodeReferenceID", false); throw;
                }
                if ((optMask0[0] & (0x80 >> 0)) != 0)
                {
                    try {
                        MapLane.ConnectingLane data1 = new MapLane.ConnectingLane();

                        dec.DecodeType(data1);
                        this.ConnectingLane = data1;
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "ConnectingLane", "MapLane.ConnectingLane", "connectingLane", "ConnectingLane", false); throw;
                    }
                }
                else
                {
                    this.ConnectingLane = null;
                }
                if ((optMask0[0] & (0x80 >> 1)) != 0)
                {
                    try {
                        if (dec.IsAligned)
                            dec.Input.SkipPadding();
                        this.PhaseId = 0 + dec.Input.Read8BitInt();
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "PhaseId", "int", "phaseId", "PhaseID", false); throw;
                    }
                }
                else
                {
                    this.PhaseId = null;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "Connection", null, "Connection", false); throw;
            }
        }
    }
}
