// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetAlleyInfoScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetAlleyInfoScRsp.proto</summary>
  public static partial class GetAlleyInfoScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetAlleyInfoScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetAlleyInfoScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdHZXRBbGxleUluZm9TY1JzcC5wcm90bxoRQ0ZIQUpKRUdCS0kucHJvdG8a",
            "EUdKSktLSUhDRkNLLnByb3RvGhFMQUVFUEpPTEZLTy5wcm90bxoRRU5HS0dB",
            "S0lLRE8ucHJvdG8ilQMKEUdldEFsbGV5SW5mb1NjUnNwEhMKC0JHTEpHR01Q",
            "T09IGAwgASgNEiAKCmV2ZW50X2xpc3QYASADKAsyDC5DRkhBSkpFR0JLSRIh",
            "CgtPQUJCRVBDQ0hPShgHIAEoCzIMLkVOR0tHQUtJS0RPEg0KBWxldmVsGAkg",
            "ASgNEhMKC0VHTkVPRk9LQ0hQGAogAygNEiEKC0lCTUtPRERHQUFQGA4gASgL",
            "MgwuTEFFRVBKT0xGS08SEwoLQkFBT0NCQUJBTkYYBiABKA0SOAoLTE5FSkFJ",
            "TU9NR0YYDyADKAsyIy5HZXRBbGxleUluZm9TY1JzcC5MTkVKQUlNT01HRkVu",
            "dHJ5Eg8KB3JldGNvZGUYCyABKA0SEwoLRlBLQUVQQ0dHSEIYCCADKA0SIQoL",
            "RUxDQ0FGTERQTEcYDSABKAsyDC5HSkpLS0lIQ0ZDSxITCgtLQ0JPSUZGS09B",
            "SRgFIAMoDRoyChBMTkVKQUlNT01HRkVudHJ5EgsKA2tleRgBIAEoDRINCgV2",
            "YWx1ZRgCIAEoDToCOAFCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
            "b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.CFHAJJEGBKIReflection.Descriptor, global::EggLink.DanhengServer.Proto.GJJKKIHCFCKReflection.Descriptor, global::EggLink.DanhengServer.Proto.LAEEPJOLFKOReflection.Descriptor, global::EggLink.DanhengServer.Proto.ENGKGAKIKDOReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetAlleyInfoScRsp), global::EggLink.DanhengServer.Proto.GetAlleyInfoScRsp.Parser, new[]{ "BGLJGGMPOOH", "EventList", "OABBEPCCHOJ", "Level", "EGNEOFOKCHP", "IBMKODDGAAP", "BAAOCBABANF", "LNEJAIMOMGF", "Retcode", "FPKAEPCGGHB", "ELCCAFLDPLG", "KCBOIFFKOAI" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetAlleyInfoScRsp : pb::IMessage<GetAlleyInfoScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetAlleyInfoScRsp> _parser = new pb::MessageParser<GetAlleyInfoScRsp>(() => new GetAlleyInfoScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetAlleyInfoScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetAlleyInfoScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAlleyInfoScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAlleyInfoScRsp(GetAlleyInfoScRsp other) : this() {
      bGLJGGMPOOH_ = other.bGLJGGMPOOH_;
      eventList_ = other.eventList_.Clone();
      oABBEPCCHOJ_ = other.oABBEPCCHOJ_ != null ? other.oABBEPCCHOJ_.Clone() : null;
      level_ = other.level_;
      eGNEOFOKCHP_ = other.eGNEOFOKCHP_.Clone();
      iBMKODDGAAP_ = other.iBMKODDGAAP_ != null ? other.iBMKODDGAAP_.Clone() : null;
      bAAOCBABANF_ = other.bAAOCBABANF_;
      lNEJAIMOMGF_ = other.lNEJAIMOMGF_.Clone();
      retcode_ = other.retcode_;
      fPKAEPCGGHB_ = other.fPKAEPCGGHB_.Clone();
      eLCCAFLDPLG_ = other.eLCCAFLDPLG_ != null ? other.eLCCAFLDPLG_.Clone() : null;
      kCBOIFFKOAI_ = other.kCBOIFFKOAI_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAlleyInfoScRsp Clone() {
      return new GetAlleyInfoScRsp(this);
    }

    /// <summary>Field number for the "BGLJGGMPOOH" field.</summary>
    public const int BGLJGGMPOOHFieldNumber = 12;
    private uint bGLJGGMPOOH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BGLJGGMPOOH {
      get { return bGLJGGMPOOH_; }
      set {
        bGLJGGMPOOH_ = value;
      }
    }

    /// <summary>Field number for the "event_list" field.</summary>
    public const int EventListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.CFHAJJEGBKI> _repeated_eventList_codec
        = pb::FieldCodec.ForMessage(10, global::EggLink.DanhengServer.Proto.CFHAJJEGBKI.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CFHAJJEGBKI> eventList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CFHAJJEGBKI>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CFHAJJEGBKI> EventList {
      get { return eventList_; }
    }

    /// <summary>Field number for the "OABBEPCCHOJ" field.</summary>
    public const int OABBEPCCHOJFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.ENGKGAKIKDO oABBEPCCHOJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ENGKGAKIKDO OABBEPCCHOJ {
      get { return oABBEPCCHOJ_; }
      set {
        oABBEPCCHOJ_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 9;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "EGNEOFOKCHP" field.</summary>
    public const int EGNEOFOKCHPFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_eGNEOFOKCHP_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> eGNEOFOKCHP_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> EGNEOFOKCHP {
      get { return eGNEOFOKCHP_; }
    }

    /// <summary>Field number for the "IBMKODDGAAP" field.</summary>
    public const int IBMKODDGAAPFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.LAEEPJOLFKO iBMKODDGAAP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.LAEEPJOLFKO IBMKODDGAAP {
      get { return iBMKODDGAAP_; }
      set {
        iBMKODDGAAP_ = value;
      }
    }

    /// <summary>Field number for the "BAAOCBABANF" field.</summary>
    public const int BAAOCBABANFFieldNumber = 6;
    private uint bAAOCBABANF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BAAOCBABANF {
      get { return bAAOCBABANF_; }
      set {
        bAAOCBABANF_ = value;
      }
    }

    /// <summary>Field number for the "LNEJAIMOMGF" field.</summary>
    public const int LNEJAIMOMGFFieldNumber = 15;
    private static readonly pbc::MapField<uint, uint>.Codec _map_lNEJAIMOMGF_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 122);
    private readonly pbc::MapField<uint, uint> lNEJAIMOMGF_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> LNEJAIMOMGF {
      get { return lNEJAIMOMGF_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 11;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "FPKAEPCGGHB" field.</summary>
    public const int FPKAEPCGGHBFieldNumber = 8;
    private static readonly pb::FieldCodec<uint> _repeated_fPKAEPCGGHB_codec
        = pb::FieldCodec.ForUInt32(66);
    private readonly pbc::RepeatedField<uint> fPKAEPCGGHB_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> FPKAEPCGGHB {
      get { return fPKAEPCGGHB_; }
    }

    /// <summary>Field number for the "ELCCAFLDPLG" field.</summary>
    public const int ELCCAFLDPLGFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.GJJKKIHCFCK eLCCAFLDPLG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.GJJKKIHCFCK ELCCAFLDPLG {
      get { return eLCCAFLDPLG_; }
      set {
        eLCCAFLDPLG_ = value;
      }
    }

    /// <summary>Field number for the "KCBOIFFKOAI" field.</summary>
    public const int KCBOIFFKOAIFieldNumber = 5;
    private static readonly pb::FieldCodec<uint> _repeated_kCBOIFFKOAI_codec
        = pb::FieldCodec.ForUInt32(42);
    private readonly pbc::RepeatedField<uint> kCBOIFFKOAI_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> KCBOIFFKOAI {
      get { return kCBOIFFKOAI_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetAlleyInfoScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetAlleyInfoScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BGLJGGMPOOH != other.BGLJGGMPOOH) return false;
      if(!eventList_.Equals(other.eventList_)) return false;
      if (!object.Equals(OABBEPCCHOJ, other.OABBEPCCHOJ)) return false;
      if (Level != other.Level) return false;
      if(!eGNEOFOKCHP_.Equals(other.eGNEOFOKCHP_)) return false;
      if (!object.Equals(IBMKODDGAAP, other.IBMKODDGAAP)) return false;
      if (BAAOCBABANF != other.BAAOCBABANF) return false;
      if (!LNEJAIMOMGF.Equals(other.LNEJAIMOMGF)) return false;
      if (Retcode != other.Retcode) return false;
      if(!fPKAEPCGGHB_.Equals(other.fPKAEPCGGHB_)) return false;
      if (!object.Equals(ELCCAFLDPLG, other.ELCCAFLDPLG)) return false;
      if(!kCBOIFFKOAI_.Equals(other.kCBOIFFKOAI_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BGLJGGMPOOH != 0) hash ^= BGLJGGMPOOH.GetHashCode();
      hash ^= eventList_.GetHashCode();
      if (oABBEPCCHOJ_ != null) hash ^= OABBEPCCHOJ.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      hash ^= eGNEOFOKCHP_.GetHashCode();
      if (iBMKODDGAAP_ != null) hash ^= IBMKODDGAAP.GetHashCode();
      if (BAAOCBABANF != 0) hash ^= BAAOCBABANF.GetHashCode();
      hash ^= LNEJAIMOMGF.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= fPKAEPCGGHB_.GetHashCode();
      if (eLCCAFLDPLG_ != null) hash ^= ELCCAFLDPLG.GetHashCode();
      hash ^= kCBOIFFKOAI_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      eventList_.WriteTo(output, _repeated_eventList_codec);
      kCBOIFFKOAI_.WriteTo(output, _repeated_kCBOIFFKOAI_codec);
      if (BAAOCBABANF != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(BAAOCBABANF);
      }
      if (oABBEPCCHOJ_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(OABBEPCCHOJ);
      }
      fPKAEPCGGHB_.WriteTo(output, _repeated_fPKAEPCGGHB_codec);
      if (Level != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Level);
      }
      eGNEOFOKCHP_.WriteTo(output, _repeated_eGNEOFOKCHP_codec);
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Retcode);
      }
      if (BGLJGGMPOOH != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(BGLJGGMPOOH);
      }
      if (eLCCAFLDPLG_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(ELCCAFLDPLG);
      }
      if (iBMKODDGAAP_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(IBMKODDGAAP);
      }
      lNEJAIMOMGF_.WriteTo(output, _map_lNEJAIMOMGF_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      eventList_.WriteTo(ref output, _repeated_eventList_codec);
      kCBOIFFKOAI_.WriteTo(ref output, _repeated_kCBOIFFKOAI_codec);
      if (BAAOCBABANF != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(BAAOCBABANF);
      }
      if (oABBEPCCHOJ_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(OABBEPCCHOJ);
      }
      fPKAEPCGGHB_.WriteTo(ref output, _repeated_fPKAEPCGGHB_codec);
      if (Level != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Level);
      }
      eGNEOFOKCHP_.WriteTo(ref output, _repeated_eGNEOFOKCHP_codec);
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Retcode);
      }
      if (BGLJGGMPOOH != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(BGLJGGMPOOH);
      }
      if (eLCCAFLDPLG_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(ELCCAFLDPLG);
      }
      if (iBMKODDGAAP_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(IBMKODDGAAP);
      }
      lNEJAIMOMGF_.WriteTo(ref output, _map_lNEJAIMOMGF_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (BGLJGGMPOOH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BGLJGGMPOOH);
      }
      size += eventList_.CalculateSize(_repeated_eventList_codec);
      if (oABBEPCCHOJ_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OABBEPCCHOJ);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      size += eGNEOFOKCHP_.CalculateSize(_repeated_eGNEOFOKCHP_codec);
      if (iBMKODDGAAP_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(IBMKODDGAAP);
      }
      if (BAAOCBABANF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BAAOCBABANF);
      }
      size += lNEJAIMOMGF_.CalculateSize(_map_lNEJAIMOMGF_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      size += fPKAEPCGGHB_.CalculateSize(_repeated_fPKAEPCGGHB_codec);
      if (eLCCAFLDPLG_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ELCCAFLDPLG);
      }
      size += kCBOIFFKOAI_.CalculateSize(_repeated_kCBOIFFKOAI_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetAlleyInfoScRsp other) {
      if (other == null) {
        return;
      }
      if (other.BGLJGGMPOOH != 0) {
        BGLJGGMPOOH = other.BGLJGGMPOOH;
      }
      eventList_.Add(other.eventList_);
      if (other.oABBEPCCHOJ_ != null) {
        if (oABBEPCCHOJ_ == null) {
          OABBEPCCHOJ = new global::EggLink.DanhengServer.Proto.ENGKGAKIKDO();
        }
        OABBEPCCHOJ.MergeFrom(other.OABBEPCCHOJ);
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      eGNEOFOKCHP_.Add(other.eGNEOFOKCHP_);
      if (other.iBMKODDGAAP_ != null) {
        if (iBMKODDGAAP_ == null) {
          IBMKODDGAAP = new global::EggLink.DanhengServer.Proto.LAEEPJOLFKO();
        }
        IBMKODDGAAP.MergeFrom(other.IBMKODDGAAP);
      }
      if (other.BAAOCBABANF != 0) {
        BAAOCBABANF = other.BAAOCBABANF;
      }
      lNEJAIMOMGF_.MergeFrom(other.lNEJAIMOMGF_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      fPKAEPCGGHB_.Add(other.fPKAEPCGGHB_);
      if (other.eLCCAFLDPLG_ != null) {
        if (eLCCAFLDPLG_ == null) {
          ELCCAFLDPLG = new global::EggLink.DanhengServer.Proto.GJJKKIHCFCK();
        }
        ELCCAFLDPLG.MergeFrom(other.ELCCAFLDPLG);
      }
      kCBOIFFKOAI_.Add(other.kCBOIFFKOAI_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            eventList_.AddEntriesFrom(input, _repeated_eventList_codec);
            break;
          }
          case 42:
          case 40: {
            kCBOIFFKOAI_.AddEntriesFrom(input, _repeated_kCBOIFFKOAI_codec);
            break;
          }
          case 48: {
            BAAOCBABANF = input.ReadUInt32();
            break;
          }
          case 58: {
            if (oABBEPCCHOJ_ == null) {
              OABBEPCCHOJ = new global::EggLink.DanhengServer.Proto.ENGKGAKIKDO();
            }
            input.ReadMessage(OABBEPCCHOJ);
            break;
          }
          case 66:
          case 64: {
            fPKAEPCGGHB_.AddEntriesFrom(input, _repeated_fPKAEPCGGHB_codec);
            break;
          }
          case 72: {
            Level = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            eGNEOFOKCHP_.AddEntriesFrom(input, _repeated_eGNEOFOKCHP_codec);
            break;
          }
          case 88: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 96: {
            BGLJGGMPOOH = input.ReadUInt32();
            break;
          }
          case 106: {
            if (eLCCAFLDPLG_ == null) {
              ELCCAFLDPLG = new global::EggLink.DanhengServer.Proto.GJJKKIHCFCK();
            }
            input.ReadMessage(ELCCAFLDPLG);
            break;
          }
          case 114: {
            if (iBMKODDGAAP_ == null) {
              IBMKODDGAAP = new global::EggLink.DanhengServer.Proto.LAEEPJOLFKO();
            }
            input.ReadMessage(IBMKODDGAAP);
            break;
          }
          case 122: {
            lNEJAIMOMGF_.AddEntriesFrom(input, _map_lNEJAIMOMGF_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            eventList_.AddEntriesFrom(ref input, _repeated_eventList_codec);
            break;
          }
          case 42:
          case 40: {
            kCBOIFFKOAI_.AddEntriesFrom(ref input, _repeated_kCBOIFFKOAI_codec);
            break;
          }
          case 48: {
            BAAOCBABANF = input.ReadUInt32();
            break;
          }
          case 58: {
            if (oABBEPCCHOJ_ == null) {
              OABBEPCCHOJ = new global::EggLink.DanhengServer.Proto.ENGKGAKIKDO();
            }
            input.ReadMessage(OABBEPCCHOJ);
            break;
          }
          case 66:
          case 64: {
            fPKAEPCGGHB_.AddEntriesFrom(ref input, _repeated_fPKAEPCGGHB_codec);
            break;
          }
          case 72: {
            Level = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            eGNEOFOKCHP_.AddEntriesFrom(ref input, _repeated_eGNEOFOKCHP_codec);
            break;
          }
          case 88: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 96: {
            BGLJGGMPOOH = input.ReadUInt32();
            break;
          }
          case 106: {
            if (eLCCAFLDPLG_ == null) {
              ELCCAFLDPLG = new global::EggLink.DanhengServer.Proto.GJJKKIHCFCK();
            }
            input.ReadMessage(ELCCAFLDPLG);
            break;
          }
          case 114: {
            if (iBMKODDGAAP_ == null) {
              IBMKODDGAAP = new global::EggLink.DanhengServer.Proto.LAEEPJOLFKO();
            }
            input.ReadMessage(IBMKODDGAAP);
            break;
          }
          case 122: {
            lNEJAIMOMGF_.AddEntriesFrom(ref input, _map_lNEJAIMOMGF_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
