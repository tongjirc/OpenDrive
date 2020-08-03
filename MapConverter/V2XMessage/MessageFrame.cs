

namespace VehStatus.MsgFrame
{
    /// <summary>
    /// Represents schema type 'MessageFrame' (CHOICE)
    /// </summary>
    [System.Serializable]
    public partial class MessageFrame : Oss.Asn1.BasePdu
    {
        /// <summary>CHOICE alternatives</summary>
        public enum Id {
            Unselected = 0,
            BsmFrameChosen = 1,
            MapFrameChosen = 2,
            RsmFrameChosen = 3,
            SpatFrameChosen = 4,
            RsiFrameChosen = 5
        }
        private Id _id;
        private object _contained;
        /// <summary>Gets current selection</summary>
        public Id Selected {
            get { return _id; }
        }
        /// <summary>Gets or selects alternative 'bsmFrame'</summary>
        public BSM.BasicSafetyMessage BsmFrame {
            get {
                if (_id == Id.BsmFrameChosen)
                    return (_contained as BSM.BasicSafetyMessage);
                else
                    return null;
            }
            set {
                _contained = value;
                _id = Id.BsmFrameChosen;
            }
        }
        /// <summary>Gets or selects alternative 'mapFrame'</summary>
        public Map.MapData MapFrame {
            get {
                if (_id == Id.MapFrameChosen)
                    return (_contained as Map.MapData);
                else
                    return null;
            }
            set {
                _contained = value;
                _id = Id.MapFrameChosen;
            }
        }
        /// <summary>Gets or selects alternative 'rsmFrame'</summary>
        public RSM.RoadsideSafetyMessage RsmFrame {
            get {
                if (_id == Id.RsmFrameChosen)
                    return (_contained as RSM.RoadsideSafetyMessage);
                else
                    return null;
            }
            set {
                _contained = value;
                _id = Id.RsmFrameChosen;
            }
        }
        /// <summary>Gets or selects alternative 'spatFrame'</summary>
        public SignalPhaseAndTiming.SPAT SpatFrame {
            get {
                if (_id == Id.SpatFrameChosen)
                    return (_contained as SignalPhaseAndTiming.SPAT);
                else
                    return null;
            }
            set {
                _contained = value;
                _id = Id.SpatFrameChosen;
            }
        }
        /// <summary>Gets or selects alternative 'rsiFrame'</summary>
        public RSI.RoadSideInformation RsiFrame {
            get {
                if (_id == Id.RsiFrameChosen)
                    return (_contained as RSI.RoadSideInformation);
                else
                    return null;
            }
            set {
                _contained = value;
                _id = Id.RsiFrameChosen;
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
            MessageFrame that = right as MessageFrame;
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
            return "MessageFrame";
        }

        /// <summary>
        /// Asserts the validity of this object`s ASN.1 data.
        /// </summary>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the instance contains invalid data.</exception>
        public override void Validate()
        {
            try {
                switch (this.Selected) {
                case MessageFrame.Id.BsmFrameChosen:
                    try {
                        if (this.BsmFrame == null)
                            throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                        else {
                            this.BsmFrame.Validate();
                        }
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "BsmFrame", "BSM.BasicSafetyMessage", "bsmFrame", "BasicSafetyMessage", false); throw;
                    }
                    break;
                case MessageFrame.Id.MapFrameChosen:
                    try {
                        if (this.MapFrame == null)
                            throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                        else {
                            this.MapFrame.Validate();
                        }
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "MapFrame", "Map.MapData", "mapFrame", "MapData", false); throw;
                    }
                    break;
                case MessageFrame.Id.RsmFrameChosen:
                    try {
                        if (this.RsmFrame == null)
                            throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                        else {
                            this.RsmFrame.Validate();
                        }
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "RsmFrame", "RSM.RoadsideSafetyMessage", "rsmFrame", "RoadsideSafetyMessage", false); throw;
                    }
                    break;
                case MessageFrame.Id.SpatFrameChosen:
                    try {
                        if (this.SpatFrame == null)
                            throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                        else {
                            this.SpatFrame.Validate();
                        }
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "SpatFrame", "SignalPhaseAndTiming.SPAT", "spatFrame", "SPAT", false); throw;
                    }
                    break;
                case MessageFrame.Id.RsiFrameChosen:
                    try {
                        if (this.RsiFrame == null)
                            throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                        else {
                            this.RsiFrame.Validate();
                        }
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "RsiFrame", "RSI.RoadSideInformation", "rsiFrame", "RoadSideInformation", false); throw;
                    }
                    break;
                default:
                    throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._bad_choice);
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "MessageFrame", null, "MessageFrame", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public override object Copy()
        {
            MessageFrame obj0 = new MessageFrame();
            switch (this.Selected) {
                case MessageFrame.Id.BsmFrameChosen:
                {
                    obj0.BsmFrame = Oss.Asn1.Internal.CopyUtil.CopyType(this.BsmFrame);
                    break;
                }
                case MessageFrame.Id.MapFrameChosen:
                {
                    obj0.MapFrame = Oss.Asn1.Internal.CopyUtil.CopyType(this.MapFrame);
                    break;
                }
                case MessageFrame.Id.RsmFrameChosen:
                {
                    obj0.RsmFrame = Oss.Asn1.Internal.CopyUtil.CopyType(this.RsmFrame);
                    break;
                }
                case MessageFrame.Id.SpatFrameChosen:
                {
                    obj0.SpatFrame = Oss.Asn1.Internal.CopyUtil.CopyType(this.SpatFrame);
                    break;
                }
                case MessageFrame.Id.RsiFrameChosen:
                {
                    obj0.RsiFrame = Oss.Asn1.Internal.CopyUtil.CopyType(this.RsiFrame);
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
                case MessageFrame.Id.RsiFrameChosen:
                    {
                        RSI.RoadSideInformation data1 = this.RsiFrame;

                        prt.Write("rsiFrame : ");
                        if (data1 == null)
                            prt.Write("<<<NULL>>>");
                        else {
                            prt.PrintContent(data1);
                        }
                    }
                    break;
                case MessageFrame.Id.SpatFrameChosen:
                    {
                        SignalPhaseAndTiming.SPAT data1 = this.SpatFrame;

                        prt.Write("spatFrame : ");
                        if (data1 == null)
                            prt.Write("<<<NULL>>>");
                        else {
                            prt.PrintContent(data1);
                        }
                    }
                    break;
                case MessageFrame.Id.RsmFrameChosen:
                    {
                        RSM.RoadsideSafetyMessage data1 = this.RsmFrame;

                        prt.Write("rsmFrame : ");
                        if (data1 == null)
                            prt.Write("<<<NULL>>>");
                        else {
                            prt.PrintContent(data1);
                        }
                    }
                    break;
                case MessageFrame.Id.MapFrameChosen:
                    {
                        Map.MapData data1 = this.MapFrame;

                        prt.Write("mapFrame : ");
                        if (data1 == null)
                            prt.Write("<<<NULL>>>");
                        else {
                            prt.PrintContent(data1);
                        }
                    }
                    break;
                case MessageFrame.Id.BsmFrameChosen:
                    {
                        BSM.BasicSafetyMessage data1 = this.BsmFrame;

                        prt.Write("bsmFrame : ");
                        if (data1 == null)
                            prt.Write("<<<NULL>>>");
                        else {
                            prt.PrintContent(data1);
                        }
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
                bool extPresent0;
                Oss.Asn1.Internal.ArrayBitOutput tempOut0 = new Oss.Asn1.Internal.ArrayBitOutput();
                Oss.Asn1.Internal.IBitOutput savedOut0 = (Oss.Asn1.Internal.IBitOutput)enc.Output;

                if ((int)this.Selected - 1 < 5)
                    extPresent0 = false;
                else
                    extPresent0 = true;
                enc.EncodeBool(extPresent0);
                if (extPresent0)
                    enc.EncodeNormSmallNonNegativeInteger((int)this.Selected - 6);
                else
                {
                    enc.Output.Write3BitInt((int)this.Selected - 1);
                }
                if (extPresent0)
                    enc.Output = tempOut0;
                switch (this.Selected)
                {
                    case MessageFrame.Id.BsmFrameChosen:
                        try {
                            BSM.BasicSafetyMessage data1 = this.BsmFrame;

                            enc.EncodeType(data1);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "BsmFrame", "BSM.BasicSafetyMessage", "bsmFrame", "BasicSafetyMessage", false); throw;
                        }
                        break;
                    case MessageFrame.Id.MapFrameChosen:
                        try {
                            Map.MapData data1 = this.MapFrame;

                            enc.EncodeType(data1);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "MapFrame", "Map.MapData", "mapFrame", "MapData", false); throw;
                        }
                        break;
                    case MessageFrame.Id.RsmFrameChosen:
                        try {
                            RSM.RoadsideSafetyMessage data1 = this.RsmFrame;

                            enc.EncodeType(data1);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "RsmFrame", "RSM.RoadsideSafetyMessage", "rsmFrame", "RoadsideSafetyMessage", false); throw;
                        }
                        break;
                    case MessageFrame.Id.SpatFrameChosen:
                        try {
                            SignalPhaseAndTiming.SPAT data1 = this.SpatFrame;

                            enc.EncodeType(data1);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "SpatFrame", "SignalPhaseAndTiming.SPAT", "spatFrame", "SPAT", false); throw;
                        }
                        break;
                    case MessageFrame.Id.RsiFrameChosen:
                        try {
                            RSI.RoadSideInformation data1 = this.RsiFrame;

                            enc.EncodeType(data1);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "RsiFrame", "RSI.RoadSideInformation", "rsiFrame", "RoadSideInformation", false); throw;
                        }
                        break;
                    default:
                        throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._bad_choice);
                }
                if (extPresent0)
                {
                    enc.CompleteEncoding();
                    enc.Output = savedOut0;
                    enc.EncodeOctetString(tempOut0.Consolidate());
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "MessageFrame", null, "MessageFrame", false); throw;
            }
        }

        protected override void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                int choice_alt0 = 0;
                bool extPresent0 = dec.DecodeBool();
                int fraglast0 = 65536;
                Oss.Asn1.Internal.IBitInput savedInput0 = dec.Input;
                int extLen0 = 0;
                int bitPos0 = 0;

                if (extPresent0)
                {
                    choice_alt0 = dec.DecodeNormSmallNonNegativeInteger() + 6;
                    extLen0 = dec.DecodeExtAdditonLength(ref fraglast0);
                    if (fraglast0 >= 0)
                        extLen0 = dec.PrepareExtInputFrag(extLen0);
                    bitPos0 = dec.Input.BitsRead();
                }
                else
                {
                    choice_alt0 = dec.Input.Read3BitInt() + 1;
                    if (choice_alt0 > 5)
                        throw new Oss.Asn1.Asn1InvalidEncodingException(Oss.Asn1.Internal.ExceptionDescriptor._bad_choice);
                }
                switch ((MessageFrame.Id)choice_alt0)
                {
                    case MessageFrame.Id.BsmFrameChosen:
                        try {
                            BSM.BasicSafetyMessage data1 = new BSM.BasicSafetyMessage();

                            dec.DecodeType(data1);
                            this.BsmFrame = data1;
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "BsmFrame", "BSM.BasicSafetyMessage", "bsmFrame", "BasicSafetyMessage", false); throw;
                        }
                        break;
                    case MessageFrame.Id.MapFrameChosen:
                        try {
                            Map.MapData data1 = new Map.MapData();

                            dec.DecodeType(data1);
                            this.MapFrame = data1;
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "MapFrame", "Map.MapData", "mapFrame", "MapData", false); throw;
                        }
                        break;
                    case MessageFrame.Id.RsmFrameChosen:
                        try {
                            RSM.RoadsideSafetyMessage data1 = new RSM.RoadsideSafetyMessage();

                            dec.DecodeType(data1);
                            this.RsmFrame = data1;
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "RsmFrame", "RSM.RoadsideSafetyMessage", "rsmFrame", "RoadsideSafetyMessage", false); throw;
                        }
                        break;
                    case MessageFrame.Id.SpatFrameChosen:
                        try {
                            SignalPhaseAndTiming.SPAT data1 = new SignalPhaseAndTiming.SPAT();

                            dec.DecodeType(data1);
                            this.SpatFrame = data1;
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "SpatFrame", "SignalPhaseAndTiming.SPAT", "spatFrame", "SPAT", false); throw;
                        }
                        break;
                    case MessageFrame.Id.RsiFrameChosen:
                        try {
                            RSI.RoadSideInformation data1 = new RSI.RoadSideInformation();

                            dec.DecodeType(data1);
                            this.RsiFrame = data1;
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "RsiFrame", "RSI.RoadSideInformation", "rsiFrame", "RoadSideInformation", false); throw;
                        }
                        break;
                    default:
                        if (!extPresent0)
                            throw new Oss.Asn1.Asn1InvalidEncodingException(Oss.Asn1.Internal.ExceptionDescriptor._bad_choice);
                        this.Clear();
                        break;
                }
                if (extPresent0)
                {
                    if (dec.Options.StrictDecoding)
                        dec.CheckExtEncodingCompletion(bitPos0, extLen0);
                    if (fraglast0 < 0)
                        dec.Input.SkipBits(extLen0 * 8 - (dec.Input.BitsRead() - bitPos0));
                }
                dec.Input = savedInput0;
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "MessageFrame", null, "MessageFrame", false); throw;
            }
        }
    }
}
