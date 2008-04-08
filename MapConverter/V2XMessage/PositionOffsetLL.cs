/*************************************************************/
/* Copyright (C) 2020 OSS Nokalva, Inc.  All rights reserved.*/
/*************************************************************/

/* THIS FILE IS PROPRIETARY MATERIAL OF OSS NOKALVA, INC.
 * AND MAY BE USED ONLY BY DIRECT LICENSEES OF OSS NOKALVA, INC.
 * THIS FILE MAY NOT BE DISTRIBUTED.
 * THIS COPYRIGHT STATEMENT MAY NOT BE REMOVED. */

/* Generated for: tongji (Trial), License 80149Z 80149Z. */
/* Abstract syntax: VehStatus */
/* Created: Thu Jan 16 15:47:39 2020 */
/* ASN.1/C# Compiler version: 4.7 */
/* ASN.1 compiler options and file names specified:
 * -uper -root -noSampleCode -messageFormat msvc -allow universaltags
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/BSM.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/DefAcceleration.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/DefMotion.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/DefPosition.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/DefPositionOffset.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/DefTime.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/Map.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/MapLane.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/MapLink.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/MapNode.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/MapPoint.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/MapSpeedLimit.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/MsgFrame.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/RSI.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/RSM.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/SignalPhaseAndTiming.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/SPATIntersectionState.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/VehBrake.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/VehClass.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/VehSafetyExt.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/VehSize.asn
 * F:/OneDrive - 同济大学/MAGIC/车路协同/人车在环/re-re-code/ASN/ASN1 Source Code for TCSAE 53 2017/VehStatus.asn
 */


namespace VehStatus.DefPositionOffset
{
    /// <summary>
    /// Represents schema type 'PositionOffsetLL' (CHOICE)
    /// </summary>
    [System.Serializable]
    public partial class PositionOffsetLL : Oss.Asn1.BaseType
    {
        /// <summary>CHOICE alternatives</summary>
        public enum Id {
            Unselected = 0,
            PositionLL1Chosen = 1,
            PositionLL2Chosen = 2,
            PositionLL3Chosen = 3,
            PositionLL4Chosen = 4,
            PositionLL5Chosen = 5,
            PositionLL6Chosen = 6,
            PositionLatLonChosen = 7
        }
        private Id _id;
        private object _contained;
        /// <summary>Gets current selection</summary>
        public Id Selected {
            get { return _id; }
        }
        /// <summary>Gets or selects alternative 'position-LL1'</summary>
        public PositionLL24B PositionLL1 {
            get {
                if (_id == Id.PositionLL1Chosen)
                    return (_contained as PositionLL24B);
                else
                    return null;
            }
            set {
                _contained = value;
                _id = Id.PositionLL1Chosen;
            }
        }
        /// <summary>Gets or selects alternative 'position-LL2'</summary>
        public PositionLL28B PositionLL2 {
            get {
                if (_id == Id.PositionLL2Chosen)
                    return (_contained as PositionLL28B);
                else
                    return null;
            }
            set {
                _contained = value;
                _id = Id.PositionLL2Chosen;
            }
        }
        /// <summary>Gets or selects alternative 'position-LL3'</summary>
        public PositionLL32B PositionLL3 {
            get {
                if (_id == Id.PositionLL3Chosen)
                    return (_contained as PositionLL32B);
                else
                    return null;
            }
            set {
                _contained = value;
                _id = Id.PositionLL3Chosen;
            }
        }
        /// <summary>Gets or selects alternative 'position-LL4'</summary>
        public PositionLL36B PositionLL4 {
            get {
                if (_id == Id.PositionLL4Chosen)
                    return (_contained as PositionLL36B);
                else
                    return null;
            }
            set {
                _contained = value;
                _id = Id.PositionLL4Chosen;
            }
        }
        /// <summary>Gets or selects alternative 'position-LL5'</summary>
        public PositionLL44B PositionLL5 {
            get {
                if (_id == Id.PositionLL5Chosen)
                    return (_contained as PositionLL44B);
                else
                    return null;
            }
            set {
                _contained = value;
                _id = Id.PositionLL5Chosen;
            }
        }
        /// <summary>Gets or selects alternative 'position-LL6'</summary>
        public PositionLL48B PositionLL6 {
            get {
                if (_id == Id.PositionLL6Chosen)
                    return (_contained as PositionLL48B);
                else
                    return null;
            }
            set {
                _contained = value;
                _id = Id.PositionLL6Chosen;
            }
        }
        /// <summary>Gets or selects alternative 'position-LatLon'</summary>
        public PositionLLmD64b PositionLatLon {
            get {
                if (_id == Id.PositionLatLonChosen)
                    return (_contained as PositionLLmD64b);
                else
                    return null;
            }
            set {
                _contained = value;
                _id = Id.PositionLatLonChosen;
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
            PositionOffsetLL that = right as PositionOffsetLL;
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
            return "PositionOffsetLL";
        }

        /// <summary>
        /// Asserts the validity of this object`s ASN.1 data.
        /// </summary>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the instance contains invalid data.</exception>
        public override void Validate()
        {
            try {
                switch (this.Selected) {
                case PositionOffsetLL.Id.PositionLL1Chosen:
                    try {
                        if (this.PositionLL1 == null)
                            throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                        else {
                            this.PositionLL1.Validate();
                        }
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "PositionLL1", "PositionLL24B", "position-LL1", "Position-LL-24B", false); throw;
                    }
                    break;
                case PositionOffsetLL.Id.PositionLL2Chosen:
                    try {
                        if (this.PositionLL2 == null)
                            throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                        else {
                            this.PositionLL2.Validate();
                        }
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "PositionLL2", "PositionLL28B", "position-LL2", "Position-LL-28B", false); throw;
                    }
                    break;
                case PositionOffsetLL.Id.PositionLL3Chosen:
                    try {
                        if (this.PositionLL3 == null)
                            throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                        else {
                            this.PositionLL3.Validate();
                        }
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "PositionLL3", "PositionLL32B", "position-LL3", "Position-LL-32B", false); throw;
                    }
                    break;
                case PositionOffsetLL.Id.PositionLL4Chosen:
                    try {
                        if (this.PositionLL4 == null)
                            throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                        else {
                            this.PositionLL4.Validate();
                        }
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "PositionLL4", "PositionLL36B", "position-LL4", "Position-LL-36B", false); throw;
                    }
                    break;
                case PositionOffsetLL.Id.PositionLL5Chosen:
                    try {
                        if (this.PositionLL5 == null)
                            throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                        else {
                            this.PositionLL5.Validate();
                        }
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "PositionLL5", "PositionLL44B", "position-LL5", "Position-LL-44B", false); throw;
                    }
                    break;
                case PositionOffsetLL.Id.PositionLL6Chosen:
                    try {
                        if (this.PositionLL6 == null)
                            throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                        else {
                            this.PositionLL6.Validate();
                        }
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "PositionLL6", "PositionLL48B", "position-LL6", "Position-LL-48B", false); throw;
                    }
                    break;
                case PositionOffsetLL.Id.PositionLatLonChosen:
                    try {
                        if (this.PositionLatLon == null)
                            throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                        else {
                            this.PositionLatLon.Validate();
                        }
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "PositionLatLon", "PositionLLmD64b", "position-LatLon", "Position-LLmD-64b", false); throw;
                    }
                    break;
                default:
                    throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._bad_choice);
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "PositionOffsetLL", null, "PositionOffsetLL", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public override object Copy()
        {
            PositionOffsetLL obj0 = new PositionOffsetLL();
            switch (this.Selected) {
                case PositionOffsetLL.Id.PositionLL1Chosen:
                {
                    obj0.PositionLL1 = Oss.Asn1.Internal.CopyUtil.CopyType(this.PositionLL1);
                    break;
                }
                case PositionOffsetLL.Id.PositionLL2Chosen:
                {
                    obj0.PositionLL2 = Oss.Asn1.Internal.CopyUtil.CopyType(this.PositionLL2);
                    break;
                }
                case PositionOffsetLL.Id.PositionLL3Chosen:
                {
                    obj0.PositionLL3 = Oss.Asn1.Internal.CopyUtil.CopyType(this.PositionLL3);
                    break;
                }
                case PositionOffsetLL.Id.PositionLL4Chosen:
                {
                    obj0.PositionLL4 = Oss.Asn1.Internal.CopyUtil.CopyType(this.PositionLL4);
                    break;
                }
                case PositionOffsetLL.Id.PositionLL5Chosen:
                {
                    obj0.PositionLL5 = Oss.Asn1.Internal.CopyUtil.CopyType(this.PositionLL5);
                    break;
                }
                case PositionOffsetLL.Id.PositionLL6Chosen:
                {
                    obj0.PositionLL6 = Oss.Asn1.Internal.CopyUtil.CopyType(this.PositionLL6);
                    break;
                }
                case PositionOffsetLL.Id.PositionLatLonChosen:
                {
                    obj0.PositionLatLon = Oss.Asn1.Internal.CopyUtil.CopyType(this.PositionLatLon);
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
                case PositionOffsetLL.Id.PositionLatLonChosen:
                    {
                        PositionLLmD64b data1 = this.PositionLatLon;

                        prt.Write("position-LatLon : ");
                        if (data1 == null)
                            prt.Write("<<<NULL>>>");
                        else {
                            prt.PrintContent(data1);
                        }
                    }
                    break;
                case PositionOffsetLL.Id.PositionLL6Chosen:
                    {
                        PositionLL48B data1 = this.PositionLL6;

                        prt.Write("position-LL6 : ");
                        if (data1 == null)
                            prt.Write("<<<NULL>>>");
                        else {
                            prt.PrintContent(data1);
                        }
                    }
                    break;
                case PositionOffsetLL.Id.PositionLL5Chosen:
                    {
                        PositionLL44B data1 = this.PositionLL5;

                        prt.Write("position-LL5 : ");
                        if (data1 == null)
                            prt.Write("<<<NULL>>>");
                        else {
                            prt.PrintContent(data1);
                        }
                    }
                    break;
                case PositionOffsetLL.Id.PositionLL4Chosen:
                    {
                        PositionLL36B data1 = this.PositionLL4;

                        prt.Write("position-LL4 : ");
                        if (data1 == null)
                            prt.Write("<<<NULL>>>");
                        else {
                            prt.PrintContent(data1);
                        }
                    }
                    break;
                case PositionOffsetLL.Id.PositionLL3Chosen:
                    {
                        PositionLL32B data1 = this.PositionLL3;

                        prt.Write("position-LL3 : ");
                        if (data1 == null)
                            prt.Write("<<<NULL>>>");
                        else {
                            prt.PrintContent(data1);
                        }
                    }
                    break;
                case PositionOffsetLL.Id.PositionLL2Chosen:
                    {
                        PositionLL28B data1 = this.PositionLL2;

                        prt.Write("position-LL2 : ");
                        if (data1 == null)
                            prt.Write("<<<NULL>>>");
                        else {
                            prt.PrintContent(data1);
                        }
                    }
                    break;
                case PositionOffsetLL.Id.PositionLL1Chosen:
                    {
                        PositionLL24B data1 = this.PositionLL1;

                        prt.Write("position-LL1 : ");
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
                enc.Output.Write3BitInt((int)this.Selected - 1);
                switch (this.Selected)
                {
                    case PositionOffsetLL.Id.PositionLL1Chosen:
                        try {
                            PositionLL24B data1 = this.PositionLL1;

                            enc.EncodeType(data1);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "PositionLL1", "PositionLL24B", "position-LL1", "Position-LL-24B", false); throw;
                        }
                        break;
                    case PositionOffsetLL.Id.PositionLL2Chosen:
                        try {
                            PositionLL28B data1 = this.PositionLL2;

                            enc.EncodeType(data1);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "PositionLL2", "PositionLL28B", "position-LL2", "Position-LL-28B", false); throw;
                        }
                        break;
                    case PositionOffsetLL.Id.PositionLL3Chosen:
                        try {
                            PositionLL32B data1 = this.PositionLL3;

                            enc.EncodeType(data1);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "PositionLL3", "PositionLL32B", "position-LL3", "Position-LL-32B", false); throw;
                        }
                        break;
                    case PositionOffsetLL.Id.PositionLL4Chosen:
                        try {
                            PositionLL36B data1 = this.PositionLL4;

                            enc.EncodeType(data1);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "PositionLL4", "PositionLL36B", "position-LL4", "Position-LL-36B", false); throw;
                        }
                        break;
                    case PositionOffsetLL.Id.PositionLL5Chosen:
                        try {
                            PositionLL44B data1 = this.PositionLL5;

                            enc.EncodeType(data1);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "PositionLL5", "PositionLL44B", "position-LL5", "Position-LL-44B", false); throw;
                        }
                        break;
                    case PositionOffsetLL.Id.PositionLL6Chosen:
                        try {
                            PositionLL48B data1 = this.PositionLL6;

                            enc.EncodeType(data1);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "PositionLL6", "PositionLL48B", "position-LL6", "Position-LL-48B", false); throw;
                        }
                        break;
                    case PositionOffsetLL.Id.PositionLatLonChosen:
                        try {
                            PositionLLmD64b data1 = this.PositionLatLon;

                            enc.EncodeType(data1);
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "PositionLatLon", "PositionLLmD64b", "position-LatLon", "Position-LLmD-64b", false); throw;
                        }
                        break;
                    default:
                        throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._bad_choice);
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "PositionOffsetLL", null, "PositionOffsetLL", false); throw;
            }
        }

        protected override void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                int choice_alt0 = 0;

                choice_alt0 = 1 + dec.Input.Read3BitInt();
                switch ((PositionOffsetLL.Id)choice_alt0)
                {
                    case PositionOffsetLL.Id.PositionLL1Chosen:
                        try {
                            PositionLL24B data1 = new PositionLL24B();

                            dec.DecodeType(data1);
                            this.PositionLL1 = data1;
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "PositionLL1", "PositionLL24B", "position-LL1", "Position-LL-24B", false); throw;
                        }
                        break;
                    case PositionOffsetLL.Id.PositionLL2Chosen:
                        try {
                            PositionLL28B data1 = new PositionLL28B();

                            dec.DecodeType(data1);
                            this.PositionLL2 = data1;
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "PositionLL2", "PositionLL28B", "position-LL2", "Position-LL-28B", false); throw;
                        }
                        break;
                    case PositionOffsetLL.Id.PositionLL3Chosen:
                        try {
                            PositionLL32B data1 = new PositionLL32B();

                            dec.DecodeType(data1);
                            this.PositionLL3 = data1;
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "PositionLL3", "PositionLL32B", "position-LL3", "Position-LL-32B", false); throw;
                        }
                        break;
                    case PositionOffsetLL.Id.PositionLL4Chosen:
                        try {
                            PositionLL36B data1 = new PositionLL36B();

                            dec.DecodeType(data1);
                            this.PositionLL4 = data1;
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "PositionLL4", "PositionLL36B", "position-LL4", "Position-LL-36B", false); throw;
                        }
                        break;
                    case PositionOffsetLL.Id.PositionLL5Chosen:
                        try {
                            PositionLL44B data1 = new PositionLL44B();

                            dec.DecodeType(data1);
                            this.PositionLL5 = data1;
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "PositionLL5", "PositionLL44B", "position-LL5", "Position-LL-44B", false); throw;
                        }
                        break;
                    case PositionOffsetLL.Id.PositionLL6Chosen:
                        try {
                            PositionLL48B data1 = new PositionLL48B();

                            dec.DecodeType(data1);
                            this.PositionLL6 = data1;
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "PositionLL6", "PositionLL48B", "position-LL6", "Position-LL-48B", false); throw;
                        }
                        break;
                    case PositionOffsetLL.Id.PositionLatLonChosen:
                        try {
                            PositionLLmD64b data1 = new PositionLLmD64b();

                            dec.DecodeType(data1);
                            this.PositionLatLon = data1;
                        } catch (System.Exception ex) {
                            Oss.Asn1.Asn1Exception.AppendContext(ex, "PositionLatLon", "PositionLLmD64b", "position-LatLon", "Position-LLmD-64b", false); throw;
                        }
                        break;
                    default:
                        throw new Oss.Asn1.Asn1InvalidEncodingException(Oss.Asn1.Internal.ExceptionDescriptor._bad_choice);
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "PositionOffsetLL", null, "PositionOffsetLL", false); throw;
            }
        }
    }
}
