// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ENGKGAKIKDO.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ENGKGAKIKDO.proto</summary>
  public static partial class ENGKGAKIKDOReflection {

    #region Descriptor
    /// <summary>File descriptor for ENGKGAKIKDO.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ENGKGAKIKDOReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFFTkdLR0FLSUtETy5wcm90bxoRTEpFQUdCUEtJUE0ucHJvdG8aFExvZ2lz",
            "dGljc1Njb3JlLnByb3RvGhFBSkVDTUhPR0RQRC5wcm90byKOAQoLRU5HS0dB",
            "S0lLRE8SEwoLQUVMREpETUpNRksYBCADKA0SIQoLRUxMTURIRkFDSUwYCiAD",
            "KAsyDC5BSkVDTUhPR0RQRBIkCgtBSkNOQU5CQURJQRgIIAMoCzIPLkxvZ2lz",
            "dGljc1Njb3JlEiEKC0hQUEFIR0hLQ05PGA0gAygLMgwuTEpFQUdCUEtJUE1C",
            "HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.LJEAGBPKIPMReflection.Descriptor, global::EggLink.DanhengServer.Proto.LogisticsScoreReflection.Descriptor, global::EggLink.DanhengServer.Proto.AJECMHOGDPDReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ENGKGAKIKDO), global::EggLink.DanhengServer.Proto.ENGKGAKIKDO.Parser, new[]{ "AELDJDMJMFK", "ELLMDHFACIL", "AJCNANBADIA", "HPPAHGHKCNO" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ENGKGAKIKDO : pb::IMessage<ENGKGAKIKDO>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ENGKGAKIKDO> _parser = new pb::MessageParser<ENGKGAKIKDO>(() => new ENGKGAKIKDO());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ENGKGAKIKDO> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ENGKGAKIKDOReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ENGKGAKIKDO() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ENGKGAKIKDO(ENGKGAKIKDO other) : this() {
      aELDJDMJMFK_ = other.aELDJDMJMFK_.Clone();
      eLLMDHFACIL_ = other.eLLMDHFACIL_.Clone();
      aJCNANBADIA_ = other.aJCNANBADIA_.Clone();
      hPPAHGHKCNO_ = other.hPPAHGHKCNO_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ENGKGAKIKDO Clone() {
      return new ENGKGAKIKDO(this);
    }

    /// <summary>Field number for the "AELDJDMJMFK" field.</summary>
    public const int AELDJDMJMFKFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_aELDJDMJMFK_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> aELDJDMJMFK_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> AELDJDMJMFK {
      get { return aELDJDMJMFK_; }
    }

    /// <summary>Field number for the "ELLMDHFACIL" field.</summary>
    public const int ELLMDHFACILFieldNumber = 10;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.AJECMHOGDPD> _repeated_eLLMDHFACIL_codec
        = pb::FieldCodec.ForMessage(82, global::EggLink.DanhengServer.Proto.AJECMHOGDPD.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AJECMHOGDPD> eLLMDHFACIL_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AJECMHOGDPD>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AJECMHOGDPD> ELLMDHFACIL {
      get { return eLLMDHFACIL_; }
    }

    /// <summary>Field number for the "AJCNANBADIA" field.</summary>
    public const int AJCNANBADIAFieldNumber = 8;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.LogisticsScore> _repeated_aJCNANBADIA_codec
        = pb::FieldCodec.ForMessage(66, global::EggLink.DanhengServer.Proto.LogisticsScore.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LogisticsScore> aJCNANBADIA_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LogisticsScore>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LogisticsScore> AJCNANBADIA {
      get { return aJCNANBADIA_; }
    }

    /// <summary>Field number for the "HPPAHGHKCNO" field.</summary>
    public const int HPPAHGHKCNOFieldNumber = 13;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.LJEAGBPKIPM> _repeated_hPPAHGHKCNO_codec
        = pb::FieldCodec.ForMessage(106, global::EggLink.DanhengServer.Proto.LJEAGBPKIPM.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LJEAGBPKIPM> hPPAHGHKCNO_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LJEAGBPKIPM>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LJEAGBPKIPM> HPPAHGHKCNO {
      get { return hPPAHGHKCNO_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ENGKGAKIKDO);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ENGKGAKIKDO other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!aELDJDMJMFK_.Equals(other.aELDJDMJMFK_)) return false;
      if(!eLLMDHFACIL_.Equals(other.eLLMDHFACIL_)) return false;
      if(!aJCNANBADIA_.Equals(other.aJCNANBADIA_)) return false;
      if(!hPPAHGHKCNO_.Equals(other.hPPAHGHKCNO_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= aELDJDMJMFK_.GetHashCode();
      hash ^= eLLMDHFACIL_.GetHashCode();
      hash ^= aJCNANBADIA_.GetHashCode();
      hash ^= hPPAHGHKCNO_.GetHashCode();
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
      aELDJDMJMFK_.WriteTo(output, _repeated_aELDJDMJMFK_codec);
      aJCNANBADIA_.WriteTo(output, _repeated_aJCNANBADIA_codec);
      eLLMDHFACIL_.WriteTo(output, _repeated_eLLMDHFACIL_codec);
      hPPAHGHKCNO_.WriteTo(output, _repeated_hPPAHGHKCNO_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      aELDJDMJMFK_.WriteTo(ref output, _repeated_aELDJDMJMFK_codec);
      aJCNANBADIA_.WriteTo(ref output, _repeated_aJCNANBADIA_codec);
      eLLMDHFACIL_.WriteTo(ref output, _repeated_eLLMDHFACIL_codec);
      hPPAHGHKCNO_.WriteTo(ref output, _repeated_hPPAHGHKCNO_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += aELDJDMJMFK_.CalculateSize(_repeated_aELDJDMJMFK_codec);
      size += eLLMDHFACIL_.CalculateSize(_repeated_eLLMDHFACIL_codec);
      size += aJCNANBADIA_.CalculateSize(_repeated_aJCNANBADIA_codec);
      size += hPPAHGHKCNO_.CalculateSize(_repeated_hPPAHGHKCNO_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ENGKGAKIKDO other) {
      if (other == null) {
        return;
      }
      aELDJDMJMFK_.Add(other.aELDJDMJMFK_);
      eLLMDHFACIL_.Add(other.eLLMDHFACIL_);
      aJCNANBADIA_.Add(other.aJCNANBADIA_);
      hPPAHGHKCNO_.Add(other.hPPAHGHKCNO_);
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
          case 34:
          case 32: {
            aELDJDMJMFK_.AddEntriesFrom(input, _repeated_aELDJDMJMFK_codec);
            break;
          }
          case 66: {
            aJCNANBADIA_.AddEntriesFrom(input, _repeated_aJCNANBADIA_codec);
            break;
          }
          case 82: {
            eLLMDHFACIL_.AddEntriesFrom(input, _repeated_eLLMDHFACIL_codec);
            break;
          }
          case 106: {
            hPPAHGHKCNO_.AddEntriesFrom(input, _repeated_hPPAHGHKCNO_codec);
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
          case 34:
          case 32: {
            aELDJDMJMFK_.AddEntriesFrom(ref input, _repeated_aELDJDMJMFK_codec);
            break;
          }
          case 66: {
            aJCNANBADIA_.AddEntriesFrom(ref input, _repeated_aJCNANBADIA_codec);
            break;
          }
          case 82: {
            eLLMDHFACIL_.AddEntriesFrom(ref input, _repeated_eLLMDHFACIL_codec);
            break;
          }
          case 106: {
            hPPAHGHKCNO_.AddEntriesFrom(ref input, _repeated_hPPAHGHKCNO_codec);
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
