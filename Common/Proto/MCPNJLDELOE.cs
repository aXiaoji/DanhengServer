// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MCPNJLDELOE.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MCPNJLDELOE.proto</summary>
  public static partial class MCPNJLDELOEReflection {

    #region Descriptor
    /// <summary>File descriptor for MCPNJLDELOE.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MCPNJLDELOEReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFNQ1BOSkxERUxPRS5wcm90bxoRSU1QS0ZGREpBQ0EucHJvdG8i7gEKC01D",
            "UE5KTERFTE9FEhMKC2F2YXRhcl9saXN0GAYgAygNEiEKC0RQS01GRE9QQUZD",
            "GAUgAygLMgwuSU1QS0ZGREpBQ0ESEwoLSkRNT0NNSkZPSEMYAiABKA0SEwoL",
            "RkdPRU1GRkhFS0gYBCABKA0SEwoLR0NGREVFSENCQU8YByABKA0SEwoLS0ND",
            "UEdDR0xFTEUYASABKA0SEwoLS0hOQkVMUEpJUEMYCSABKAgSEwoLQU9OTURF",
            "UE9JRksYDSADKA0SFAoMY2hhbGxlbmdlX2lkGAwgASgNEhMKC0VMS01CRUhC",
            "QU9OGA8gASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.IMPKFFDJACAReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MCPNJLDELOE), global::EggLink.DanhengServer.Proto.MCPNJLDELOE.Parser, new[]{ "AvatarList", "DPKMFDOPAFC", "JDMOCMJFOHC", "FGOEMFFHEKH", "GCFDEEHCBAO", "KCCPGCGLELE", "KHNBELPJIPC", "AONMDEPOIFK", "ChallengeId", "ELKMBEHBAON" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MCPNJLDELOE : pb::IMessage<MCPNJLDELOE>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MCPNJLDELOE> _parser = new pb::MessageParser<MCPNJLDELOE>(() => new MCPNJLDELOE());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MCPNJLDELOE> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MCPNJLDELOEReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MCPNJLDELOE() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MCPNJLDELOE(MCPNJLDELOE other) : this() {
      avatarList_ = other.avatarList_.Clone();
      dPKMFDOPAFC_ = other.dPKMFDOPAFC_.Clone();
      jDMOCMJFOHC_ = other.jDMOCMJFOHC_;
      fGOEMFFHEKH_ = other.fGOEMFFHEKH_;
      gCFDEEHCBAO_ = other.gCFDEEHCBAO_;
      kCCPGCGLELE_ = other.kCCPGCGLELE_;
      kHNBELPJIPC_ = other.kHNBELPJIPC_;
      aONMDEPOIFK_ = other.aONMDEPOIFK_.Clone();
      challengeId_ = other.challengeId_;
      eLKMBEHBAON_ = other.eLKMBEHBAON_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MCPNJLDELOE Clone() {
      return new MCPNJLDELOE(this);
    }

    /// <summary>Field number for the "avatar_list" field.</summary>
    public const int AvatarListFieldNumber = 6;
    private static readonly pb::FieldCodec<uint> _repeated_avatarList_codec
        = pb::FieldCodec.ForUInt32(50);
    private readonly pbc::RepeatedField<uint> avatarList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> AvatarList {
      get { return avatarList_; }
    }

    /// <summary>Field number for the "DPKMFDOPAFC" field.</summary>
    public const int DPKMFDOPAFCFieldNumber = 5;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.IMPKFFDJACA> _repeated_dPKMFDOPAFC_codec
        = pb::FieldCodec.ForMessage(42, global::EggLink.DanhengServer.Proto.IMPKFFDJACA.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.IMPKFFDJACA> dPKMFDOPAFC_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.IMPKFFDJACA>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.IMPKFFDJACA> DPKMFDOPAFC {
      get { return dPKMFDOPAFC_; }
    }

    /// <summary>Field number for the "JDMOCMJFOHC" field.</summary>
    public const int JDMOCMJFOHCFieldNumber = 2;
    private uint jDMOCMJFOHC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JDMOCMJFOHC {
      get { return jDMOCMJFOHC_; }
      set {
        jDMOCMJFOHC_ = value;
      }
    }

    /// <summary>Field number for the "FGOEMFFHEKH" field.</summary>
    public const int FGOEMFFHEKHFieldNumber = 4;
    private uint fGOEMFFHEKH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FGOEMFFHEKH {
      get { return fGOEMFFHEKH_; }
      set {
        fGOEMFFHEKH_ = value;
      }
    }

    /// <summary>Field number for the "GCFDEEHCBAO" field.</summary>
    public const int GCFDEEHCBAOFieldNumber = 7;
    private uint gCFDEEHCBAO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GCFDEEHCBAO {
      get { return gCFDEEHCBAO_; }
      set {
        gCFDEEHCBAO_ = value;
      }
    }

    /// <summary>Field number for the "KCCPGCGLELE" field.</summary>
    public const int KCCPGCGLELEFieldNumber = 1;
    private uint kCCPGCGLELE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KCCPGCGLELE {
      get { return kCCPGCGLELE_; }
      set {
        kCCPGCGLELE_ = value;
      }
    }

    /// <summary>Field number for the "KHNBELPJIPC" field.</summary>
    public const int KHNBELPJIPCFieldNumber = 9;
    private bool kHNBELPJIPC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool KHNBELPJIPC {
      get { return kHNBELPJIPC_; }
      set {
        kHNBELPJIPC_ = value;
      }
    }

    /// <summary>Field number for the "AONMDEPOIFK" field.</summary>
    public const int AONMDEPOIFKFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_aONMDEPOIFK_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> aONMDEPOIFK_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> AONMDEPOIFK {
      get { return aONMDEPOIFK_; }
    }

    /// <summary>Field number for the "challenge_id" field.</summary>
    public const int ChallengeIdFieldNumber = 12;
    private uint challengeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeId {
      get { return challengeId_; }
      set {
        challengeId_ = value;
      }
    }

    /// <summary>Field number for the "ELKMBEHBAON" field.</summary>
    public const int ELKMBEHBAONFieldNumber = 15;
    private uint eLKMBEHBAON_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ELKMBEHBAON {
      get { return eLKMBEHBAON_; }
      set {
        eLKMBEHBAON_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MCPNJLDELOE);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MCPNJLDELOE other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!avatarList_.Equals(other.avatarList_)) return false;
      if(!dPKMFDOPAFC_.Equals(other.dPKMFDOPAFC_)) return false;
      if (JDMOCMJFOHC != other.JDMOCMJFOHC) return false;
      if (FGOEMFFHEKH != other.FGOEMFFHEKH) return false;
      if (GCFDEEHCBAO != other.GCFDEEHCBAO) return false;
      if (KCCPGCGLELE != other.KCCPGCGLELE) return false;
      if (KHNBELPJIPC != other.KHNBELPJIPC) return false;
      if(!aONMDEPOIFK_.Equals(other.aONMDEPOIFK_)) return false;
      if (ChallengeId != other.ChallengeId) return false;
      if (ELKMBEHBAON != other.ELKMBEHBAON) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= avatarList_.GetHashCode();
      hash ^= dPKMFDOPAFC_.GetHashCode();
      if (JDMOCMJFOHC != 0) hash ^= JDMOCMJFOHC.GetHashCode();
      if (FGOEMFFHEKH != 0) hash ^= FGOEMFFHEKH.GetHashCode();
      if (GCFDEEHCBAO != 0) hash ^= GCFDEEHCBAO.GetHashCode();
      if (KCCPGCGLELE != 0) hash ^= KCCPGCGLELE.GetHashCode();
      if (KHNBELPJIPC != false) hash ^= KHNBELPJIPC.GetHashCode();
      hash ^= aONMDEPOIFK_.GetHashCode();
      if (ChallengeId != 0) hash ^= ChallengeId.GetHashCode();
      if (ELKMBEHBAON != 0) hash ^= ELKMBEHBAON.GetHashCode();
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
      if (KCCPGCGLELE != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(KCCPGCGLELE);
      }
      if (JDMOCMJFOHC != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(JDMOCMJFOHC);
      }
      if (FGOEMFFHEKH != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(FGOEMFFHEKH);
      }
      dPKMFDOPAFC_.WriteTo(output, _repeated_dPKMFDOPAFC_codec);
      avatarList_.WriteTo(output, _repeated_avatarList_codec);
      if (GCFDEEHCBAO != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(GCFDEEHCBAO);
      }
      if (KHNBELPJIPC != false) {
        output.WriteRawTag(72);
        output.WriteBool(KHNBELPJIPC);
      }
      if (ChallengeId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ChallengeId);
      }
      aONMDEPOIFK_.WriteTo(output, _repeated_aONMDEPOIFK_codec);
      if (ELKMBEHBAON != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(ELKMBEHBAON);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (KCCPGCGLELE != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(KCCPGCGLELE);
      }
      if (JDMOCMJFOHC != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(JDMOCMJFOHC);
      }
      if (FGOEMFFHEKH != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(FGOEMFFHEKH);
      }
      dPKMFDOPAFC_.WriteTo(ref output, _repeated_dPKMFDOPAFC_codec);
      avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
      if (GCFDEEHCBAO != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(GCFDEEHCBAO);
      }
      if (KHNBELPJIPC != false) {
        output.WriteRawTag(72);
        output.WriteBool(KHNBELPJIPC);
      }
      if (ChallengeId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ChallengeId);
      }
      aONMDEPOIFK_.WriteTo(ref output, _repeated_aONMDEPOIFK_codec);
      if (ELKMBEHBAON != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(ELKMBEHBAON);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += avatarList_.CalculateSize(_repeated_avatarList_codec);
      size += dPKMFDOPAFC_.CalculateSize(_repeated_dPKMFDOPAFC_codec);
      if (JDMOCMJFOHC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JDMOCMJFOHC);
      }
      if (FGOEMFFHEKH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FGOEMFFHEKH);
      }
      if (GCFDEEHCBAO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GCFDEEHCBAO);
      }
      if (KCCPGCGLELE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KCCPGCGLELE);
      }
      if (KHNBELPJIPC != false) {
        size += 1 + 1;
      }
      size += aONMDEPOIFK_.CalculateSize(_repeated_aONMDEPOIFK_codec);
      if (ChallengeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeId);
      }
      if (ELKMBEHBAON != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ELKMBEHBAON);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MCPNJLDELOE other) {
      if (other == null) {
        return;
      }
      avatarList_.Add(other.avatarList_);
      dPKMFDOPAFC_.Add(other.dPKMFDOPAFC_);
      if (other.JDMOCMJFOHC != 0) {
        JDMOCMJFOHC = other.JDMOCMJFOHC;
      }
      if (other.FGOEMFFHEKH != 0) {
        FGOEMFFHEKH = other.FGOEMFFHEKH;
      }
      if (other.GCFDEEHCBAO != 0) {
        GCFDEEHCBAO = other.GCFDEEHCBAO;
      }
      if (other.KCCPGCGLELE != 0) {
        KCCPGCGLELE = other.KCCPGCGLELE;
      }
      if (other.KHNBELPJIPC != false) {
        KHNBELPJIPC = other.KHNBELPJIPC;
      }
      aONMDEPOIFK_.Add(other.aONMDEPOIFK_);
      if (other.ChallengeId != 0) {
        ChallengeId = other.ChallengeId;
      }
      if (other.ELKMBEHBAON != 0) {
        ELKMBEHBAON = other.ELKMBEHBAON;
      }
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
          case 8: {
            KCCPGCGLELE = input.ReadUInt32();
            break;
          }
          case 16: {
            JDMOCMJFOHC = input.ReadUInt32();
            break;
          }
          case 32: {
            FGOEMFFHEKH = input.ReadUInt32();
            break;
          }
          case 42: {
            dPKMFDOPAFC_.AddEntriesFrom(input, _repeated_dPKMFDOPAFC_codec);
            break;
          }
          case 50:
          case 48: {
            avatarList_.AddEntriesFrom(input, _repeated_avatarList_codec);
            break;
          }
          case 56: {
            GCFDEEHCBAO = input.ReadUInt32();
            break;
          }
          case 72: {
            KHNBELPJIPC = input.ReadBool();
            break;
          }
          case 96: {
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 106:
          case 104: {
            aONMDEPOIFK_.AddEntriesFrom(input, _repeated_aONMDEPOIFK_codec);
            break;
          }
          case 120: {
            ELKMBEHBAON = input.ReadUInt32();
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
          case 8: {
            KCCPGCGLELE = input.ReadUInt32();
            break;
          }
          case 16: {
            JDMOCMJFOHC = input.ReadUInt32();
            break;
          }
          case 32: {
            FGOEMFFHEKH = input.ReadUInt32();
            break;
          }
          case 42: {
            dPKMFDOPAFC_.AddEntriesFrom(ref input, _repeated_dPKMFDOPAFC_codec);
            break;
          }
          case 50:
          case 48: {
            avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
            break;
          }
          case 56: {
            GCFDEEHCBAO = input.ReadUInt32();
            break;
          }
          case 72: {
            KHNBELPJIPC = input.ReadBool();
            break;
          }
          case 96: {
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 106:
          case 104: {
            aONMDEPOIFK_.AddEntriesFrom(ref input, _repeated_aONMDEPOIFK_codec);
            break;
          }
          case 120: {
            ELKMBEHBAON = input.ReadUInt32();
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
