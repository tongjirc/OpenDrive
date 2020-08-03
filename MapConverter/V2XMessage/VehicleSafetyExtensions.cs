namespace VehStatus.VehSafetyExt
{
    /// <summary>
    /// Represents schema type 'VehicleSafetyExtensions' (SEQUENCE)
    /// </summary>
    [System.Serializable]
    public partial class VehicleSafetyExtensions : Oss.Asn1.BaseType
    {
        /// <summary>Field 'events'</summary>
        public Oss.Asn1.BitStringWithNamedBits Events { get; set; }
        /// <summary>Field 'pathHistory'</summary>
        public VehSafetyExt.PathHistory PathHistory { get; set; }
        /// <summary>Field 'pathPrediction'</summary>
        public VehSafetyExt.PathPrediction PathPrediction { get; set; }
        /// <summary>Field 'lights'</summary>
        public Oss.Asn1.BitStringWithNamedBits Lights { get; set; }

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
            VehicleSafetyExtensions that = right as VehicleSafetyExtensions;
            if (Events != null) {
                if (!Events.Equals(that.Events))
                    return false;
            } else if (that.Events != null)
                return false;
            if (PathHistory != null) {
                if (!PathHistory.Equals(that.PathHistory))
                    return false;
            } else if (that.PathHistory != null)
                return false;
            if (PathPrediction != null) {
                if (!PathPrediction.Equals(that.PathPrediction))
                    return false;
            } else if (that.PathPrediction != null)
                return false;
            if (Lights != null) {
                if (!Lights.Equals(that.Lights))
                    return false;
            } else if (that.Lights != null)
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
            if (Events != null)
                hash ^= Events.GetHashCode();
            if (PathHistory != null)
                hash ^= PathHistory.GetHashCode();
            if (PathPrediction != null)
                hash ^= PathPrediction.GetHashCode();
            if (Lights != null)
                hash ^= Lights.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Returns the name of the ASN.1 schema type represented by this class.
        /// </summary>
        /// <returns>the string containing the name of the ASN.1 schema type.</returns>
        public override string GetAsn1TypeName()
        {
            return "VehicleSafetyExtensions";
        }

        /// <summary>
        /// Asserts the validity of this object`s ASN.1 data.
        /// </summary>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the instance contains invalid data.</exception>
        public override void Validate()
        {
            try {
                try {
                    if (this.Events != null) {
                        try {
                            if (this.Events.Count != 13)
                                throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                        } catch (System.Exception) {
                        }
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Events", "Oss.Asn1.BitStringWithNamedBits", "events", "VehicleEventFlags", false); throw;
                }
                try {
                    if (this.PathHistory != null) {
                        this.PathHistory.Validate();
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "PathHistory", "VehSafetyExt.PathHistory", "pathHistory", "PathHistory", false); throw;
                }
                try {
                    if (this.PathPrediction != null) {
                        this.PathPrediction.Validate();
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "PathPrediction", "VehSafetyExt.PathPrediction", "pathPrediction", "PathPrediction", false); throw;
                }
                try {
                    if (this.Lights != null) {
                        try {
                            if (this.Lights.Count != 9)
                                throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                        } catch (System.Exception) {
                        }
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Lights", "Oss.Asn1.BitStringWithNamedBits", "lights", "ExteriorLights", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "VehicleSafetyExtensions", null, "VehicleSafetyExtensions", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public override object Copy()
        {
            VehicleSafetyExtensions obj0 = new VehicleSafetyExtensions();
            {
                obj0.Events = Oss.Asn1.Internal.CopyUtil.CopyBitString(this.Events);
            }
            {
                obj0.PathHistory = Oss.Asn1.Internal.CopyUtil.CopyType(this.PathHistory);
            }
            {
                obj0.PathPrediction = Oss.Asn1.Internal.CopyUtil.CopyType(this.PathPrediction);
            }
            {
                obj0.Lights = Oss.Asn1.Internal.CopyUtil.CopyBitString(this.Lights);
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
                    Oss.Asn1.BitStringWithNamedBits data1 = this.Events;

                    if (data1 != null) {
                        prt.WriteLine();
                        first0 = false;
                        prt.Write("events ");
                        prt.PrintBitString(data1, 
                            delegate(int index)
                            {
                                switch (index)
                                {
                                    case (int)0: return "eventHazardLights";
                                    case (int)1: return "eventStopLineViolation";
                                    case (int)2: return "eventABSactivated";
                                    case (int)3: return "eventTractionControlLoss";
                                    case (int)4: return "eventStabilityControlactivated";
                                    case (int)5: return "eventHazardousMaterials";
                                    case (int)6: return "eventReserved1";
                                    case (int)7: return "eventHardBraking";
                                    case (int)8: return "eventLightsChanged";
                                    case (int)9: return "eventWipersChanged";
                                    case (int)10: return "eventFlatTire";
                                    case (int)11: return "eventDisabledVehicle";
                                    case (int)12: return "eventAirBagDeployment";
                                }
                                return null;
                            }
                        );
                    }
                }
                {
                    VehSafetyExt.PathHistory data1 = this.PathHistory;

                    if (data1 != null) {
                        prt.WriteLine(first0 ? "" : ",");
                        first0 = false;
                        prt.Write("pathHistory ");
                        prt.PrintContent(data1);
                    }
                }
                {
                    VehSafetyExt.PathPrediction data1 = this.PathPrediction;

                    if (data1 != null) {
                        prt.WriteLine(first0 ? "" : ",");
                        first0 = false;
                        prt.Write("pathPrediction ");
                        prt.PrintContent(data1);
                    }
                }
                {
                    Oss.Asn1.BitStringWithNamedBits data1 = this.Lights;

                    if (data1 != null) {
                        prt.WriteLine(first0 ? "" : ",");
                        first0 = false;
                        prt.Write("lights ");
                        prt.PrintBitString(data1, 
                            delegate(int index)
                            {
                                switch (index)
                                {
                                    case (int)0: return "lowBeamHeadlightsOn";
                                    case (int)1: return "highBeamHeadlightsOn";
                                    case (int)2: return "leftTurnSignalOn";
                                    case (int)3: return "rightTurnSignalOn";
                                    case (int)4: return "hazardSignalOn";
                                    case (int)5: return "automaticLightControlOn";
                                    case (int)6: return "daytimeRunningLightsOn";
                                    case (int)7: return "fogLightOn";
                                    case (int)8: return "parkingLightsOn";
                                }
                                return null;
                            }
                        );
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
                byte[] optMask0 = new byte[1];

                enc.Output.WriteBool(extPresent0);
                if (this.Events != null)
                    optMask0[0] |= (byte)(0x80 >> 0);
                if (this.PathHistory != null)
                    optMask0[0] |= (byte)(0x80 >> 1);
                if (this.PathPrediction != null)
                    optMask0[0] |= (byte)(0x80 >> 2);
                if (this.Lights != null)
                    optMask0[0] |= (byte)(0x80 >> 3);
                enc.Output.WriteBits(optMask0, 0, 4);
                try {
                    if (this.Events != null)
                    {
                        int length1 = Oss.Asn1.Internal.MiscUtil.SearchGreaterOrEqual(_InternalMetadata.BerCodecMetaData.Ranges2, this.Events.LastOneBitPos() + 1);
                        bool extPresent1 = !(length1 == 13);
                        enc.EncodeBool(extPresent1);
                        if (extPresent1)
                            enc.EncodeBitStringWithNamedBits(this.Events, length1);
                        else {
                            enc.EncodeBitStringWithNamedBits(this.Events, length1, 13);
                        }
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Events", "Oss.Asn1.BitStringWithNamedBits", "events", "VehicleEventFlags", false); throw;
                }
                try {
                    VehSafetyExt.PathHistory data1 = this.PathHistory;

                    if (data1 != null)
                    {
                        enc.EncodeType(data1);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "PathHistory", "VehSafetyExt.PathHistory", "pathHistory", "PathHistory", false); throw;
                }
                try {
                    VehSafetyExt.PathPrediction data1 = this.PathPrediction;

                    if (data1 != null)
                    {
                        enc.EncodeType(data1);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "PathPrediction", "VehSafetyExt.PathPrediction", "pathPrediction", "PathPrediction", false); throw;
                }
                try {
                    if (this.Lights != null)
                    {
                        int length1 = Oss.Asn1.Internal.MiscUtil.SearchGreaterOrEqual(_InternalMetadata.BerCodecMetaData.Ranges3, this.Lights.LastOneBitPos() + 1);
                        bool extPresent1 = !(length1 == 9);
                        enc.EncodeBool(extPresent1);
                        if (extPresent1)
                            enc.EncodeBitStringWithNamedBits(this.Lights, length1);
                        else {
                            enc.EncodeBitStringWithNamedBits(this.Lights, length1, 9);
                        }
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Lights", "Oss.Asn1.BitStringWithNamedBits", "lights", "ExteriorLights", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "VehicleSafetyExtensions", null, "VehicleSafetyExtensions", false); throw;
            }
        }

        protected override void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                bool extPresent0 = dec.Input.ReadBool();
                byte[] optMask0 = new byte[1];

                dec.Input.ReadBits(optMask0, 4);
                if ((optMask0[0] & (0x80 >> 0)) != 0)
                {
                    try {
                        Oss.Asn1.BitStringWithNamedBits data1;
                        bool extPresent1 = dec.Input.ReadBool();
                        if (extPresent1)
                            data1 = dec.DecodeExtBitStringWithNamedBits(_InternalMetadata.BerCodecMetaData.Ranges2);
                        else
                            data1 = dec.DecodeBitStringWithNamedBits(13, _InternalMetadata.BerCodecMetaData.Ranges2);
                        if (dec.Options.StrictDecoding && extPresent1 == (data1.Length == 13))
                            dec.RaiseExtLengthError(extPresent1);
                        this.Events = data1;
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Events", "Oss.Asn1.BitStringWithNamedBits", "events", "VehicleEventFlags", false); throw;
                    }
                }
                else
                {
                    this.Events = null;
                }
                if ((optMask0[0] & (0x80 >> 1)) != 0)
                {
                    try {
                        VehSafetyExt.PathHistory data1 = new VehSafetyExt.PathHistory();

                        dec.DecodeType(data1);
                        this.PathHistory = data1;
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "PathHistory", "VehSafetyExt.PathHistory", "pathHistory", "PathHistory", false); throw;
                    }
                }
                else
                {
                    this.PathHistory = null;
                }
                if ((optMask0[0] & (0x80 >> 2)) != 0)
                {
                    try {
                        VehSafetyExt.PathPrediction data1 = new VehSafetyExt.PathPrediction();

                        dec.DecodeType(data1);
                        this.PathPrediction = data1;
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "PathPrediction", "VehSafetyExt.PathPrediction", "pathPrediction", "PathPrediction", false); throw;
                    }
                }
                else
                {
                    this.PathPrediction = null;
                }
                if ((optMask0[0] & (0x80 >> 3)) != 0)
                {
                    try {
                        Oss.Asn1.BitStringWithNamedBits data1;
                        bool extPresent1 = dec.Input.ReadBool();
                        if (extPresent1)
                            data1 = dec.DecodeExtBitStringWithNamedBits(_InternalMetadata.BerCodecMetaData.Ranges3);
                        else
                            data1 = dec.DecodeBitStringWithNamedBits(9, _InternalMetadata.BerCodecMetaData.Ranges3);
                        if (dec.Options.StrictDecoding && extPresent1 == (data1.Length == 9))
                            dec.RaiseExtLengthError(extPresent1);
                        this.Lights = data1;
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Lights", "Oss.Asn1.BitStringWithNamedBits", "lights", "ExteriorLights", false); throw;
                    }
                }
                else
                {
                    this.Lights = null;
                }
                if (extPresent0)
                {
                    int extMaskLen0 = 0;
                    byte[] extMask0 = dec.DecodeExtPreamble(out extMaskLen0);

                    dec.SkipUnknownExtensions(extMask0, extMaskLen0, 0);
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "VehicleSafetyExtensions", null, "VehicleSafetyExtensions", false); throw;
            }
        }
    }
}
