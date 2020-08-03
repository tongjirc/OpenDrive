namespace VehStatus.DefPositionOffset
{
    /// <summary>
    /// Represents schema type 'VerticalOffset' (CHOICE)
    /// </summary>
    [System.Serializable]
    public partial class VerticalOffset : Oss.Asn1.BaseType
    {
        /// <summary>CHOICE alternatives</summary>
        public enum Id {
            Unselected = 0,
            Offset1Chosen = 1,
            Offset2Chosen = 2,
            Offset3Chosen = 3,
            Offset4Chosen = 4,
            Offset5Chosen = 5,
            Offset6Chosen = 6,
            ElevationChosen = 7
        }
        private Id _id;
        private object _contained;
        /// <summary>Gets current selection</summary>
        public Id Selected {
            get { return _id; }
        }
        /// <summary>Gets or selects alternative 'offset1'</summary>
        public long? Offset1 {
            get {
                if (_id == Id.Offset1Chosen)
                    return (_contained as long?);
                else
                    return null;
            }
            set {
                _contained = value;
                if (value == null)
                    _id = Id.Unselected;
                else
                    _id = Id.Offset1Chosen;
            }
        }
        /// <summary>Gets or selects alternative 'offset2'</summary>
        public long? Offset2 {
            get {
                if (_id == Id.Offset2Chosen)
                    return (_contained as long?);
                else
                    return null;
            }
            set {
                _contained = value;
                if (value == null)
                    _id = Id.Unselected;
                else
                    _id = Id.Offset2Chosen;
            }
        }
        /// <summary>Gets or selects alternative 'offset3'</summary>
        public long? Offset3 {
            get {
                if (_id == Id.Offset3Chosen)
                    return (_contained as long?);
                else
                    return null;
            }
            set {
                _contained = value;
                if (value == null)
                    _id = Id.Unselected;
                else
                    _id = Id.Offset3Chosen;
            }
        }
        /// <summary>Gets or selects alternative 'offset4'</summary>
        public long? Offset4 {
            get {
                if (_id == Id.Offset4Chosen)
                    return (_contained as long?);
                else
                    return null;
            }
            set {
                _contained = value;
                if (value == null)
                    _id = Id.Unselected;
                else
                    _id = Id.Offset4Chosen;
            }
        }
        /// <summary>Gets or selects alternative 'offset5'</summary>
        public long? Offset5 {
            get {
                if (_id == Id.Offset5Chosen)
                    return (_contained as long?);
                else
                    return null;
            }
            set {
                _contained = value;
                if (value == null)
                    _id = Id.Unselected;
                else
                    _id = Id.Offset5Chosen;
            }
        }
        /// <summary>Gets or selects alternative 'offset6'</summary>
        public long? Offset6 {
            get {
                if (_id == Id.Offset6Chosen)
                    return (_contained as long?);
                else
                    return null;
            }
            set {
                _contained = value;
                if (value == null)
                    _id = Id.Unselected;
                else
                    _id = Id.Offset6Chosen;
            }
        }
        /// <summary>Gets or selects alternative 'elevation'</summary>
        public long? Elevation {
            get {
                if (_id == Id.ElevationChosen)
                    return (_contained as long?);
                else
                    return null;
            }
            set {
                _contained = value;
                if (value == null)
                    _id = Id.Unselected;
                else
                    _id = Id.ElevationChosen;
            }
        }

        public void Clear()
        {
            _id = Id.Unselected;
            _contained = null;
        }

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
            VerticalOffset that = right as VerticalOffset;
            if (_id != that._id)
                return false;
            return _contained.Equals(that._contained);
        }

        /// <summary>
        /// Serves as a hash function for a particular type.
        /// </summary>
        /// <returns>A hash code for the current object.</returns>
        public override int GetHashCode()
        {
            return GetType().GetHashCode() ^ _id.GetHashCode() ^ _contained.GetHashCode();
        }

        /// <summary>
        /// Returns the name of the ASN.1 schema type represented by this class.
        /// </summary>
        /// <returns>the string containing the name of the ASN.1 schema type.</returns>
        public override string GetAsn1TypeName()
        {
            return "VerticalOffset";
        }

        /// <summary>
        /// Asserts the validity of this object`s ASN.1 data.
        /// </summary>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the instance contains invalid data.</exception>
        public override void Validate()
        {
            try {
                switch (this.Selected) {
                case VerticalOffset.Id.Offset1Chosen:
                    try {
                        if (this.Offset1 == null)
                            throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                        else {
                            if (this.Offset1.Value < -64)
                                throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                            if (this.Offset1.Value > 63)
                                throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                        }
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Offset1", "long", "offset1", "VertOffset-B07", false); throw;
                    }
                    break;
                case VerticalOffset.Id.Offset2Chosen:
                    try {
                        if (this.Offset2 == null)
                            throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                        else {
                            if (this.Offset2.Value < -128)
                                throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                            if (this.Offset2.Value > 127)
                                throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                        }
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Offset2", "long", "offset2", "VertOffset-B08", false); throw;
                    }
                    break;
                case VerticalOffset.Id.Offset3Chosen:
                    try {
                        if (this.Offset3 == null)
                            throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                        else {
                            if (this.Offset3.Value < -256)
                                throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                            if (this.Offset3.Value > 255)
                                throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                        }
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Offset3", "long", "offset3", "VertOffset-B09", false); throw;
                    }
                    break;
                case VerticalOffset.Id.Offset4Chosen:
                    try {
                        if (this.Offset4 == null)
                            throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                        else {
                            if (this.Offset4.Value < -512)
                                throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                            if (this.Offset4.Value > 511)
                                throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                        }
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Offset4", "long", "offset4", "VertOffset-B10", false); throw;
                    }
                    break;
                case VerticalOffset.Id.Offset5Chosen:
                    try {
                        if (this.Offset5 == null)
                            throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                        else {
                            if (this.Offset5.Value < -1024)
                                throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                            if (this.Offset5.Value > 1023)
                                throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                        }
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Offset5", "long", "offset5", "VertOffset-B11", false); throw;
                    }
                    break;
                case VerticalOffset.Id.Offset6Chosen:
                    try {
                        if (this.Offset6 == null)
                            throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                        else {
                            if (this.Offset6.Value < -2048)
                                throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                            if (this.Offset6.Value > 2047)
                                throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                        }
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Offset6", "long", "offset6", "VertOffset-B12", false); throw;
                    }
                    break;
                case VerticalOffset.Id.ElevationChosen:
                    try {
                        if (this.Elevation == null)
                            throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                        else {
                            if (this.Elevation.Value < -4096)
                                throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                            if (this.Elevation.Value > 61439)
                                throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange);
                        }
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Elevation", "long", "elevation", "Elevation", false); throw;
                    }
                    break;
                default:
                    throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._bad_choice);
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "VerticalOffset", null, "VerticalOffset", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public override object Copy()
        {
            VerticalOffset obj0 = new VerticalOffset();
            switch (this.Selected) {
                case VerticalOffset.Id.Offset1Chosen:
                {
                    obj0.Offset1 = this.Offset1;
                    break;
                }
                case VerticalOffset.Id.Offset2Chosen:
                {
                    obj0.Offset2 = this.Offset2;
                    break;
                }
                case VerticalOffset.Id.Offset3Chosen:
                {
                    obj0.Offset3 = this.Offset3;
                    break;
                }
                case VerticalOffset.Id.Offset4Chosen:
                {
                    obj0.Offset4 = this.Offset4;
                    break;
                }
                case VerticalOffset.Id.Offset5Chosen:
                {
                    obj0.Offset5 = this.Offset5;
                    break;
                }
                case VerticalOffset.Id.Offset6Chosen:
                {
                    obj0.Offset6 = this.Offset6;
                    break;
                }
                case VerticalOffset.Id.ElevationChosen:
                {
                    obj0.Elevation = this.Elevation;
                    break;
                }
                default:
                    throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._bad_choice);
            }
            return obj0;
        }

        protected override void PrintAsn1ValueNotation(Oss.Asn1.Internal.ValueNotationHelper prt)
        {
            try
            {
                switch (this.Selected) {
                case VerticalOffset.Id.ElevationChosen:
                    {
                        prt.Write("elevation : ");
                        prt.Write(this.Elevation.Value);
                    }
                    break;
                case VerticalOffset.Id.Offset6Chosen:
                    {
                        prt.Write("offset6 : ");
                        prt.Write(this.Offset6.Value);
                    }
                    break;
                case VerticalOffset.Id.Offset5Chosen:
                    {
                        prt.Write("offset5 : ");
                        prt.Write(this.Offset5.Value);
                    }
                    break;
                case VerticalOffset.Id.Offset4Chosen:
                    {
                        prt.Write("offset4 : ");
                        prt.Write(this.Offset4.Value);
                    }
                    break;
                case VerticalOffset.Id.Offset3Chosen:
                    {
                        prt.Write("offset3 : ");
                        prt.Write(this.Offset3.Value);
                    }
                    break;
                case VerticalOffset.Id.Offset2Chosen:
                    {
                        prt.Write("offset2 : ");
                        prt.Write(this.Offset2.Value);
                    }
                    break;
                case VerticalOffset.Id.Offset1Chosen:
                    {
                        prt.Write("offset1 : ");
                        prt.Write(this.Offset1.Value);
                    }
                    break;
                default:
                    prt.Write("<unknown choice>");
                    break;
                }
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
                enc.Output.Write3BitInt((int)this.Selected - 1);
                switch (this.Selected)
                {
                    case VerticalOffset.Id.Offset1Chosen:
                        try {
                            if (enc.BitCount(this.Offset1.Value - -64) > 7 || this.Offset1.Value < -64)
                                throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Offset1.Value);
                            enc.Output.Write7BitInt((int)(this.Offset1.Value - (-64)));
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "Offset1", "long", "offset1", "VertOffset-B07", false); throw;
                        }
                        break;
                    case VerticalOffset.Id.Offset2Chosen:
                        try {
                            if (enc.BitCount(this.Offset2.Value - -128) > 8 || this.Offset2.Value < -128)
                                throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Offset2.Value);
                            if (enc.IsAligned)
                                enc.Output.WritePadding();
                            enc.Output.Write8BitInt((int)(this.Offset2.Value - (-128)));
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "Offset2", "long", "offset2", "VertOffset-B08", false); throw;
                        }
                        break;
                    case VerticalOffset.Id.Offset3Chosen:
                        try {
                            if (enc.BitCount(this.Offset3.Value - -256) > 9 || this.Offset3.Value < -256)
                                throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Offset3.Value);
                            enc.EncodeConstrainedLongInteger((long)(this.Offset3.Value - (-256)), 9);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "Offset3", "long", "offset3", "VertOffset-B09", false); throw;
                        }
                        break;
                    case VerticalOffset.Id.Offset4Chosen:
                        try {
                            if (enc.BitCount(this.Offset4.Value - -512) > 10 || this.Offset4.Value < -512)
                                throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Offset4.Value);
                            enc.EncodeConstrainedLongInteger((long)(this.Offset4.Value - (-512)), 10);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "Offset4", "long", "offset4", "VertOffset-B10", false); throw;
                        }
                        break;
                    case VerticalOffset.Id.Offset5Chosen:
                        try {
                            if (enc.BitCount(this.Offset5.Value - -1024) > 11 || this.Offset5.Value < -1024)
                                throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Offset5.Value);
                            enc.EncodeConstrainedLongInteger((long)(this.Offset5.Value - (-1024)), 11);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "Offset5", "long", "offset5", "VertOffset-B11", false); throw;
                        }
                        break;
                    case VerticalOffset.Id.Offset6Chosen:
                        try {
                            if (enc.BitCount(this.Offset6.Value - -2048) > 12 || this.Offset6.Value < -2048)
                                throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Offset6.Value);
                            enc.EncodeConstrainedLongInteger((long)(this.Offset6.Value - (-2048)), 12);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "Offset6", "long", "offset6", "VertOffset-B12", false); throw;
                        }
                        break;
                    case VerticalOffset.Id.ElevationChosen:
                        try {
                            if (enc.BitCount(this.Elevation.Value - -4096) > 16 || this.Elevation.Value < -4096)
                                throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._valueRange, ", value = " + this.Elevation.Value);
                            enc.EncodeConstrainedLongInteger((long)(this.Elevation.Value - (-4096)), 16);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "Elevation", "long", "elevation", "Elevation", false); throw;
                        }
                        break;
                    default:
                        throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._bad_choice);
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "VerticalOffset", null, "VerticalOffset", false); throw;
            }
        }

        protected override void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                int choice_alt0 = 0;

                choice_alt0 = 1 + dec.Input.Read3BitInt();
                switch ((VerticalOffset.Id)choice_alt0)
                {
                    case VerticalOffset.Id.Offset1Chosen:
                        try {
                            this.Offset1 = -64 + dec.Input.Read7BitInt();
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "Offset1", "long", "offset1", "VertOffset-B07", false); throw;
                        }
                        break;
                    case VerticalOffset.Id.Offset2Chosen:
                        try {
                            if (dec.IsAligned)
                                dec.Input.SkipPadding();
                            this.Offset2 = -128 + dec.Input.Read8BitInt();
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "Offset2", "long", "offset2", "VertOffset-B08", false); throw;
                        }
                        break;
                    case VerticalOffset.Id.Offset3Chosen:
                        try {
                            this.Offset3 = dec.DecodeConstrainedLongInteger(9, -256);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "Offset3", "long", "offset3", "VertOffset-B09", false); throw;
                        }
                        break;
                    case VerticalOffset.Id.Offset4Chosen:
                        try {
                            this.Offset4 = dec.DecodeConstrainedLongInteger(10, -512);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "Offset4", "long", "offset4", "VertOffset-B10", false); throw;
                        }
                        break;
                    case VerticalOffset.Id.Offset5Chosen:
                        try {
                            this.Offset5 = dec.DecodeConstrainedLongInteger(11, -1024);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "Offset5", "long", "offset5", "VertOffset-B11", false); throw;
                        }
                        break;
                    case VerticalOffset.Id.Offset6Chosen:
                        try {
                            this.Offset6 = dec.DecodeConstrainedLongInteger(12, -2048);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "Offset6", "long", "offset6", "VertOffset-B12", false); throw;
                        }
                        break;
                    case VerticalOffset.Id.ElevationChosen:
                        try {
                            this.Elevation = dec.DecodeConstrainedLongInteger(16, -4096);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "Elevation", "long", "elevation", "Elevation", false); throw;
                        }
                        break;
                    default:
                        throw new Oss.Asn1.Asn1InvalidEncodingException(Oss.Asn1.Internal.ExceptionDescriptor._bad_choice);
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "VerticalOffset", null, "VerticalOffset", false); throw;
            }
        }
    }
}
