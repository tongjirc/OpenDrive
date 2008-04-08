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


namespace VehStatus.MapNode
{
    /// <summary>
    /// Represents schema type 'Node' (SEQUENCE)
    /// </summary>
    [System.Serializable]
    public partial class Node : Oss.Asn1.BaseType
    {
        /// <summary>Field 'name'</summary>
        public string Name { get; set; }
        /// <summary>Field 'id'</summary>
        public NodeReferenceID Id { get; set; }
        /// <summary>Field 'refPos'</summary>
        public DefPosition.Position3D RefPos { get; set; }
        /// <summary>Field 'inLinks'</summary>
        public MapLink.LinkList InLinks { get; set; }

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
            Node that = right as Node;
            if (Name != null) {
                if (!Name.Equals(that.Name))
                    return false;
            } else if (that.Name != null)
                return false;
            if (Id != null) {
                if (!Id.Equals(that.Id))
                    return false;
            } else if (that.Id != null)
                return false;
            if (RefPos != null) {
                if (!RefPos.Equals(that.RefPos))
                    return false;
            } else if (that.RefPos != null)
                return false;
            if (InLinks != null) {
                if (!Oss.Asn1.Internal.Comparer.CompareSeqOf(InLinks, that.InLinks))
                    return false;
            } else if (that.InLinks != null)
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
            if (Name != null)
                hash ^= Name.GetHashCode();
            if (Id != null)
                hash ^= Id.GetHashCode();
            if (RefPos != null)
                hash ^= RefPos.GetHashCode();
            if (InLinks != null)
                hash ^= Oss.Asn1.Internal.Comparer.HashSeqOf(InLinks);
            return hash;
        }

        /// <summary>
        /// Returns the name of the ASN.1 schema type represented by this class.
        /// </summary>
        /// <returns>the string containing the name of the ASN.1 schema type.</returns>
        public override string GetAsn1TypeName()
        {
            return "Node";
        }

        /// <summary>
        /// Asserts the validity of this object`s ASN.1 data.
        /// </summary>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the instance contains invalid data.</exception>
        public override void Validate()
        {
            try {
                try {
                    if (this.Name != null) {
                        Oss.Asn1.Internal.Validator.ValidateKMCString(this.Name, _InternalMetadata.CommonMetaData.S0);
                        if (this.Name.Length < 1)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                        if (this.Name.Length > 63)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Name", "string", "name", "DescriptiveName", false); throw;
                }
                try {
                    if (this.Id == null)
                        throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                    this.Id.Validate();
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Id", "NodeReferenceID", "id", "NodeReferenceID", false); throw;
                }
                try {
                    if (this.RefPos == null)
                        throw new Oss.Asn1.Asn1InvalidDataException(Oss.Asn1.Internal.ExceptionDescriptor._null_component_element);
                    this.RefPos.Validate();
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "RefPos", "DefPosition.Position3D", "refPos", "Position3D", false); throw;
                }
                try {
                    if (this.InLinks != null) {
                        this.InLinks.Validate();
                        if (this.InLinks.Count < 1)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                        if (this.InLinks.Count > 32)
                            throw new Oss.Asn1.Asn1ConstraintException(Oss.Asn1.Internal.ExceptionDescriptor._sizeConstraint);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "InLinks", "MapLink.LinkList", "inLinks", "LinkList", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "Node", null, "Node", false); throw;
            }
        }

        /// <summary>
        /// Creates the deep copy of this object.
        /// </summary>
        /// <returns>A new object that is a deep copy of this instance.</returns>
        public override object Copy()
        {
            Node obj0 = new Node();
            {
                obj0.Name = this.Name;
            }
            {
                obj0.Id = Oss.Asn1.Internal.CopyUtil.CopyType(this.Id);
            }
            {
                obj0.RefPos = Oss.Asn1.Internal.CopyUtil.CopyType(this.RefPos);
            }
            {
                obj0.InLinks = this.InLinks == null ? null : (MapLink.LinkList)this.InLinks.Copy();
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
                    string data1 = this.Name;

                    if (data1 != null) {
                        prt.WriteLine();
                        first0 = false;
                        prt.Write("name ");
                        prt.PrintString(data1);
                    }
                }
                {
                    prt.WriteLine(first0 ? "" : ",");
                    prt.Write("id ");
                    if (this.Id == null)
                        prt.Write("<<<NULL>>>");
                    else {
                        prt.PrintContent(this.Id);
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
                    MapLink.LinkList data1 = this.InLinks;

                    if (data1 != null) {
                        prt.WriteLine(",");
                        prt.Write("inLinks ");
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
                byte[] optMask0 = new byte[1];

                enc.Output.WriteBool(extPresent0);
                if (this.Name != null)
                    optMask0[0] |= (byte)(0x80 >> 0);
                if (this.InLinks != null)
                    optMask0[0] |= (byte)(0x80 >> 1);
                enc.Output.WriteBits(optMask0, 0, 2);
                try {
                    if (this.Name != null)
                    {
                        enc.EncodeKMCString(this.Name, 1, 63, _InternalMetadata.CommonMetaData.S0);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Name", "string", "name", "DescriptiveName", false); throw;
                }
                try {
                    enc.EncodeType(this.Id);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Id", "NodeReferenceID", "id", "NodeReferenceID", false); throw;
                }
                try {
                    enc.EncodeType(this.RefPos);
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "RefPos", "DefPosition.Position3D", "refPos", "Position3D", false); throw;
                }
                try {
                    MapLink.LinkList data1 = this.InLinks;

                    if (data1 != null)
                    {
                        data1.EncodePer(enc);
                    }
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "InLinks", "MapLink.LinkList", "inLinks", "LinkList", false); throw;
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "Node", null, "Node", false); throw;
            }
        }

        protected override void DecodePer(Oss.Asn1.Internal.PerDecoder dec)
        {
            try {
                bool extPresent0 = dec.Input.ReadBool();
                byte[] optMask0 = new byte[1];

                dec.Input.ReadBits(optMask0, 2);
                if ((optMask0[0] & (0x80 >> 0)) != 0)
                {
                    try {
                        this.Name = dec.DecodeKMCString(1, 63, _InternalMetadata.CommonMetaData.S0);
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "Name", "string", "name", "DescriptiveName", false); throw;
                    }
                }
                else
                {
                    this.Name = null;
                }
                try {
                    NodeReferenceID data1 = new NodeReferenceID();

                    dec.DecodeType(data1);
                    this.Id = data1;
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "Id", "NodeReferenceID", "id", "NodeReferenceID", false); throw;
                }
                try {
                    DefPosition.Position3D data1 = new DefPosition.Position3D();

                    dec.DecodeType(data1);
                    this.RefPos = data1;
                } catch (System.Exception ex) {
                    Oss.Asn1.Asn1Exception.AppendContext(ex, "RefPos", "DefPosition.Position3D", "refPos", "Position3D", false); throw;
                }
                if ((optMask0[0] & (0x80 >> 1)) != 0)
                {
                    try {
                        MapLink.LinkList data1 = new MapLink.LinkList();

                        data1.DecodePer(dec);
                        this.InLinks = data1;
                    } catch (System.Exception ex) {
                        Oss.Asn1.Asn1Exception.AppendContext(ex, "InLinks", "MapLink.LinkList", "inLinks", "LinkList", false); throw;
                    }
                }
                else
                {
                    this.InLinks = null;
                }
                if (extPresent0)
                {
                    int extMaskLen0 = 0;
                    byte[] extMask0 = dec.DecodeExtPreamble(out extMaskLen0);

                    dec.SkipUnknownExtensions(extMask0, extMaskLen0, 0);
                }
            } catch (System.Exception ex) {
                Oss.Asn1.Asn1Exception.AppendContext(ex, "", "Node", null, "Node", false); throw;
            }
        }
    }
}
