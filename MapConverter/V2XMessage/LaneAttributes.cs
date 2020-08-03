

namespace VehStatus.MapLane
{
    /// <summary>
    /// Represents schema type 'LaneAttributes' (SEQUENCE)
    /// </summary>
    [System.Serializable]
    public partial class LaneAttributes : Oss.Asn1.BaseType
    {
        /// <summary>Field 'shareWith'</summary>
        public Oss.Asn1.BitStringWithNamedBits ShareWith { get; set; }
        /// <summary>Field 'laneType'</summary>
        public LaneTypeAttributes LaneType { get; set; }

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
            LaneAttributes that = right as LaneAttributes;
            if (ShareWith != null) {
                if (!ShareWith.Equals(that.ShareWith))
                    return false;
            } else if (that.ShareWith != null)
                return false;
            if (LaneType != null) {
                if (!LaneType.Equals(that.LaneType))
                    return false;
            } else if (that.LaneType != null)
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
            if (ShareWith != null)
                hash ^= ShareWith.GetHashCode();
            if (LaneType != null)
                hash ^= LaneType.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Returns the name of the ASN.1 schema type represented by this class.
        /// </summary>
        /// <returns>the string containing the name of the ASN.1 schema type.</returns>
        public override string GetAsn1TypeName()
        {
            return "LaneAttributes";
        }

        /// <summary>
        /// Asserts the validity of this object`s ASN.1 data.
        /// </summary>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the instance contains invalid data.</exception>
        public override void Validate()
        {
            try {
                try {
                    if (this.ShareWith != null) {
                        if (this.ShareWith.Count != 10)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "ShareWith", "Oss.Asn1.BitStringWithNamedBits", "shareWith", "LaneSharing", false); throw;
                }
                try {
                    if (this.LaneType == null)
                        throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                    this.LaneType.Validate();
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "LaneType", "LaneTypeAttributes", "laneType", "LaneTypeAttributes", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "LaneAttributes", null, "LaneAttributes", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public override object Copy()
        {
            LaneAttributes obj0 = new LaneAttributes();
            {
                obj0.ShareWith = Oss.Asn1.Internal.CopyUtil.CopyBitString(this.ShareWith);
            }
            {
                obj0.LaneType = Oss.Asn1.Internal.CopyUtil.CopyType(this.LaneType);
            }
            return obj0;
        }

        protected override void PrintAsn1ValueNotation(Oss.Asn1.Internal.ValueNotationHelper prt)
        {
            try
            {
                bool first0 = true;

                prt.BeginConstructedValue();
                {
                    Oss.Asn1.BitStringWithNamedBits data1 = this.ShareWith;

                    if (data1 != null) {
                        prt.WriteLine();
                        first0 = false;
                        prt.Write("shareWith ");
                        prt.PrintBitString(data1, 
                            delegate(int index)
                            {
                                switch (index)
                                {
                                    case (int)0: return "overlappingLaneDescriptionProvided";
                                    case (int)1: return "multipleLanesTreatedAsOneLane";
                                    case (int)2: return "otherNonMotorizedTrafficTypes";
                                    case (int)3: return "individualMotorizedVehicleTraffic";
                                    case (int)4: return "busVehicleTraffic";
                                    case (int)5: return "taxiVehicleTraffic";
                                    case (int)6: return "pedestriansTraffic";
                                    case (int)7: return "cyclistVehicleTraffic";
                                    case (int)8: return "trackedVehicleTraffic";
                                    case (int)9: return "pedestrianTraffic";
                                }
                                return null;
                            }
                        );
                    }
                }
                {
                    LaneTypeAttributes data1 = this.LaneType;

                    prt.WriteLine(first0 ? "" : ",");
                    prt.Write("laneType ");
                    if (data1 == null)
                        prt.Write("<<<NULL>>>");
                    else {
                        prt.PrintContent(data1);
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

                if (this.ShareWith != null)
                    optMask0[0] |= (byte)(0x80 >> 0);
                enc.Output.WriteBits(optMask0, 0, 1);
                try {
                    if (this.ShareWith != null)
                    {
                        int length1 = Oss.Asn1.Internal.MiscUtil.SearchGreaterOrEqual(_InternalMetadata.BerCodecMetaData.Ranges6, this.ShareWith.LastOneBitPos() + 1);
                        enc.EncodeBitStringWithNamedBits(this.ShareWith, length1, 10);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "ShareWith", "Oss.Asn1.BitStringWithNamedBits", "shareWith", "LaneSharing", false); throw;
                }
                try {
                    enc.EncodeType(this.LaneType);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "LaneType", "LaneTypeAttributes", "laneType", "LaneTypeAttributes", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "LaneAttributes", null, "LaneAttributes", false); throw;
            }
        }

        protected override void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                byte[] optMask0 = new byte[1];

                dec.Input.ReadBits(optMask0, 1);
                if ((optMask0[0] & (0x80 >> 0)) != 0)
                {
                    try {
                        this.ShareWith = dec.DecodeBitStringWithNamedBits(10, _InternalMetadata.BerCodecMetaData.Ranges6);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "ShareWith", "Oss.Asn1.BitStringWithNamedBits", "shareWith", "LaneSharing", false); throw;
                    }
                }
                else
                {
                    this.ShareWith = null;
                }
                try {
                    LaneTypeAttributes data1 = new LaneTypeAttributes();

                    dec.DecodeType(data1);
                    this.LaneType = data1;
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "LaneType", "LaneTypeAttributes", "laneType", "LaneTypeAttributes", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "LaneAttributes", null, "LaneAttributes", false); throw;
            }
        }
    }
}
