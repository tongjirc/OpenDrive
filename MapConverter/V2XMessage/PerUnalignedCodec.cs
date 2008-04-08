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


namespace VehStatus
{
    /// <summary>
    /// Represents an ASN.1 codec capable of encoding and decoding data according to Unaligned Packed Encoding Rules (UPER)
    /// </summary>
    public class PerUnalignedCodec : Oss.Asn1.BinaryCodec
    {
        /// <summary>
        /// Initializes a new instance of VehStatus.PerUnalignedCodec
        /// </summary>
        public PerUnalignedCodec() : base(_InternalMetadata.Instance)
        {
            base.EncoderOptions = new Oss.Asn1.PerEncoderOptions();
            base.DecoderOptions = new Oss.Asn1.BaseDecoderOptions();
            Encoder = new Oss.Asn1.Internal.PerEncoder(false, this.EncoderOptions);
            Decoder = new Oss.Asn1.Internal.PerDecoder(false, false, this.DecoderOptions);
        }

        /// <summary>
        /// Returns an object which can be used to modify the encoding options.
        /// </summary>
        public new Oss.Asn1.PerEncoderOptions EncoderOptions
        {
            get { return base.EncoderOptions as Oss.Asn1.PerEncoderOptions; }
        }

        /// <summary>
        /// Returns the encoding rules implemented by this codec instance.
        /// </summary>
        public override Oss.Asn1.EncodingRules EncodingRules
        {
            get { return Oss.Asn1.EncodingRules.PerUnaligned; }
        }

        /// <summary>
        /// Encodes a PDU object using UPER and writes the encoded data to a Stream.
        /// </summary>
        /// <param name="pdu">The PDU object to be encoded.</param>
        /// <param name="stream">The output stream in which the encoded data is written.</param>
        /// <returns>The size of the encoded data written to the stream, in bytes.</returns>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the PDU cannot be encoded.</exception>
        public override int Encode(Oss.Asn1.BasePdu pdu, System.IO.Stream stream)
        {
            return Encoder.EncodePdu(pdu, stream);
        }

        /// <summary>
        /// Encodes a PDU object using UPER and stores the encoded data into a BitString object.
        /// </summary>
        /// <param name="pdu">The PDU object to be encoded.</param>
        /// <param name="bstr">The output BitString object in which the encoded data is written.</param>
        /// <returns>The size of the encoded data written to the BitString object, in bits.</returns>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the PDU cannot be encoded.</exception>
        public int Encode(Oss.Asn1.BasePdu pdu, Oss.Asn1.BitString bstr)
        {
            return Encoder.EncodePdu(pdu, bstr);
        }

        /// <summary>
        /// Encodes a PDU object into a buffer.
        /// </summary>
        /// <param name="pdu">The PDU object to be encoded.</param>
        /// <param name="buffer">The buffer in which the encoded data is written.</param>
        /// <returns>The size of the encoded data written to the buffer, in bytes.</returns>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the PDU cannot be encoded.</exception>
        /// <exception cref="Oss.Asn1.Asn1OutputFullException">Thrown if buffer is too small.</exception>
        public override int Encode(Oss.Asn1.BasePdu pdu, byte[] buffer)
        {
            return Encoder.EncodePdu(pdu, buffer, 0);
        }

        /// <summary>
        /// Encodes a PDU object into a buffer, at the specified starting position.
        /// </summary>
        /// <param name="pdu">The PDU object to be encoded.</param>
        /// <param name="buffer">The buffer in which the encoded data is written.</param>
        /// <param name="index">The buffer position at which to begin writing the encoded data.</param>
        /// <returns>The size of the encoded data written to the buffer, in bytes.</returns>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the PDU cannot be encoded.</exception>
        /// <exception cref="Oss.Asn1.Asn1OutputFullException">Thrown if buffer is too small.</exception>
        public override int Encode(Oss.Asn1.BasePdu pdu, byte[] buffer, int index)
        {
            return Encoder.EncodePdu(pdu, buffer, index);
        }

        /// <summary>
        /// Encodes a PDU into a new buffer.
        /// </summary>
        /// <param name="pdu">The PDU object to be encoded.</param>
        /// <returns>The new buffer containing the encoded data.</returns>
        /// <exception cref="Oss.Asn1.Asn1InvalidDataException">Thrown if the PDU cannot be encoded.</exception>
        public override byte[] Encode(Oss.Asn1.BasePdu pdu)
        {
            return Encoder.EncodePdu(pdu);
        }

        /// <summary>
        /// Decodes a PDU object from a Stream, using UPER.
        /// </summary>
        /// <param name="stream">The input stream from which the encoded data is read.</param>
        /// <param name="pdu">The PDU object in which the decoded data is stored.</param>
        /// <returns>The number of bytes read from the stream.</returns>
        /// <exception cref="Oss.Asn1.Asn1InvalidEncodingException">Thrown if the PDU cannot be decoded.</exception>
        public override int Decode(System.IO.Stream stream, Oss.Asn1.BasePdu pdu)
        {
            return Decoder.DecodePdu(stream, pdu);
        }

        /// <summary>
        /// Decodes a PDU object from a BitString object, using UPER.
        /// An exception is thrown if trailing bits are left in the input BitString object after decoding.
        /// </summary>
        /// <param name="bstr">The input BitString object containing the encoded data.</param>
        /// <param name="pdu">The PDU object in which the decoded data is stored.</param>
        /// <returns>The number of bits read from the input BitString object.</returns>
        /// <exception cref="Oss.Asn1.Asn1InvalidEncodingException">Thrown if the PDU cannot be decoded.</exception>
        public int Decode(Oss.Asn1.BitString bstr, Oss.Asn1.BasePdu pdu)
        {
            return Decoder.DecodePdu(bstr, pdu);
        }

        /// <summary>
        /// Decodes a PDU object from a buffer, using UPER.
        /// </summary>
        /// <param name="buffer">The input buffer containing the encoded data.</param>
        /// <param name="pdu">The PDU object in which the decoded data is stored.</param>
        /// <returns>The number of bytes read from the buffer.</returns>
        /// <exception cref="Oss.Asn1.Asn1InvalidEncodingException">Thrown if the PDU cannot be decoded.</exception>
        public override int Decode(byte[] buffer, Oss.Asn1.BasePdu pdu)
        {
            return Decoder.DecodePdu(buffer, 0, pdu);
        }

        /// <summary>
        /// Decodes a PDU object from a buffer, using UPER.
        /// </summary>
        /// <param name="buffer">The input buffer containing the encoded data.</param>
        /// <param name="index">The buffer position at which to begin reading the encoded data.</param>
        /// <param name="pdu">The PDU object in which the decoded data is stored.</param>
        /// <returns>The number of bytes read from the buffer.</returns>
        /// <exception cref="Oss.Asn1.Asn1InvalidEncodingException">Thrown if the PDU cannot be decoded.</exception>
        public override int Decode(byte[] buffer, int index, Oss.Asn1.BasePdu pdu)
        {
            return Decoder.DecodePdu(buffer, index, pdu);
        }

        protected readonly Oss.Asn1.Internal.PerEncoder Encoder;
        protected readonly Oss.Asn1.Internal.PerDecoder Decoder;
    }
}
