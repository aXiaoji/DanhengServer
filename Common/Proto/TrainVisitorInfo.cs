// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TrainVisitorInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TrainVisitorInfo.proto</summary>
  public static partial class TrainVisitorInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for TrainVisitorInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TrainVisitorInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZUcmFpblZpc2l0b3JJbmZvLnByb3RvGhhUcmFpblZpc2l0b3JTdGF0dXMu",
            "cHJvdG8iiwEKEFRyYWluVmlzaXRvckluZm8SEwoLTUxKQUhOTUpCTU4YCSAD",
            "KA0SIwoGc3RhdHVzGAwgASgOMhMuVHJhaW5WaXNpdG9yU3RhdHVzEhMKC0JQ",
            "R0tOTkZETENPGAEgASgIEhMKC0dHSUZDSUtFSE9PGAogASgNEhMKC1BMT0hB",
            "Qk5NQ0xJGAggASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.TrainVisitorStatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TrainVisitorInfo), global::EggLink.DanhengServer.Proto.TrainVisitorInfo.Parser, new[]{ "MLJAHNMJBMN", "Status", "BPGKNNFDLCO", "GGIFCIKEHOO", "PLOHABNMCLI" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TrainVisitorInfo : pb::IMessage<TrainVisitorInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TrainVisitorInfo> _parser = new pb::MessageParser<TrainVisitorInfo>(() => new TrainVisitorInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TrainVisitorInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.TrainVisitorInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrainVisitorInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrainVisitorInfo(TrainVisitorInfo other) : this() {
      mLJAHNMJBMN_ = other.mLJAHNMJBMN_.Clone();
      status_ = other.status_;
      bPGKNNFDLCO_ = other.bPGKNNFDLCO_;
      gGIFCIKEHOO_ = other.gGIFCIKEHOO_;
      pLOHABNMCLI_ = other.pLOHABNMCLI_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrainVisitorInfo Clone() {
      return new TrainVisitorInfo(this);
    }

    /// <summary>Field number for the "MLJAHNMJBMN" field.</summary>
    public const int MLJAHNMJBMNFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_mLJAHNMJBMN_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> mLJAHNMJBMN_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> MLJAHNMJBMN {
      get { return mLJAHNMJBMN_; }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.TrainVisitorStatus status_ = global::EggLink.DanhengServer.Proto.TrainVisitorStatus.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.TrainVisitorStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "BPGKNNFDLCO" field.</summary>
    public const int BPGKNNFDLCOFieldNumber = 1;
    private bool bPGKNNFDLCO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool BPGKNNFDLCO {
      get { return bPGKNNFDLCO_; }
      set {
        bPGKNNFDLCO_ = value;
      }
    }

    /// <summary>Field number for the "GGIFCIKEHOO" field.</summary>
    public const int GGIFCIKEHOOFieldNumber = 10;
    private uint gGIFCIKEHOO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GGIFCIKEHOO {
      get { return gGIFCIKEHOO_; }
      set {
        gGIFCIKEHOO_ = value;
      }
    }

    /// <summary>Field number for the "PLOHABNMCLI" field.</summary>
    public const int PLOHABNMCLIFieldNumber = 8;
    private uint pLOHABNMCLI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PLOHABNMCLI {
      get { return pLOHABNMCLI_; }
      set {
        pLOHABNMCLI_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TrainVisitorInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TrainVisitorInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!mLJAHNMJBMN_.Equals(other.mLJAHNMJBMN_)) return false;
      if (Status != other.Status) return false;
      if (BPGKNNFDLCO != other.BPGKNNFDLCO) return false;
      if (GGIFCIKEHOO != other.GGIFCIKEHOO) return false;
      if (PLOHABNMCLI != other.PLOHABNMCLI) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= mLJAHNMJBMN_.GetHashCode();
      if (Status != global::EggLink.DanhengServer.Proto.TrainVisitorStatus.None) hash ^= Status.GetHashCode();
      if (BPGKNNFDLCO != false) hash ^= BPGKNNFDLCO.GetHashCode();
      if (GGIFCIKEHOO != 0) hash ^= GGIFCIKEHOO.GetHashCode();
      if (PLOHABNMCLI != 0) hash ^= PLOHABNMCLI.GetHashCode();
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
      if (BPGKNNFDLCO != false) {
        output.WriteRawTag(8);
        output.WriteBool(BPGKNNFDLCO);
      }
      if (PLOHABNMCLI != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(PLOHABNMCLI);
      }
      mLJAHNMJBMN_.WriteTo(output, _repeated_mLJAHNMJBMN_codec);
      if (GGIFCIKEHOO != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(GGIFCIKEHOO);
      }
      if (Status != global::EggLink.DanhengServer.Proto.TrainVisitorStatus.None) {
        output.WriteRawTag(96);
        output.WriteEnum((int) Status);
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
      if (BPGKNNFDLCO != false) {
        output.WriteRawTag(8);
        output.WriteBool(BPGKNNFDLCO);
      }
      if (PLOHABNMCLI != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(PLOHABNMCLI);
      }
      mLJAHNMJBMN_.WriteTo(ref output, _repeated_mLJAHNMJBMN_codec);
      if (GGIFCIKEHOO != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(GGIFCIKEHOO);
      }
      if (Status != global::EggLink.DanhengServer.Proto.TrainVisitorStatus.None) {
        output.WriteRawTag(96);
        output.WriteEnum((int) Status);
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
      size += mLJAHNMJBMN_.CalculateSize(_repeated_mLJAHNMJBMN_codec);
      if (Status != global::EggLink.DanhengServer.Proto.TrainVisitorStatus.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (BPGKNNFDLCO != false) {
        size += 1 + 1;
      }
      if (GGIFCIKEHOO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GGIFCIKEHOO);
      }
      if (PLOHABNMCLI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PLOHABNMCLI);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TrainVisitorInfo other) {
      if (other == null) {
        return;
      }
      mLJAHNMJBMN_.Add(other.mLJAHNMJBMN_);
      if (other.Status != global::EggLink.DanhengServer.Proto.TrainVisitorStatus.None) {
        Status = other.Status;
      }
      if (other.BPGKNNFDLCO != false) {
        BPGKNNFDLCO = other.BPGKNNFDLCO;
      }
      if (other.GGIFCIKEHOO != 0) {
        GGIFCIKEHOO = other.GGIFCIKEHOO;
      }
      if (other.PLOHABNMCLI != 0) {
        PLOHABNMCLI = other.PLOHABNMCLI;
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
            BPGKNNFDLCO = input.ReadBool();
            break;
          }
          case 64: {
            PLOHABNMCLI = input.ReadUInt32();
            break;
          }
          case 74:
          case 72: {
            mLJAHNMJBMN_.AddEntriesFrom(input, _repeated_mLJAHNMJBMN_codec);
            break;
          }
          case 80: {
            GGIFCIKEHOO = input.ReadUInt32();
            break;
          }
          case 96: {
            Status = (global::EggLink.DanhengServer.Proto.TrainVisitorStatus) input.ReadEnum();
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
            BPGKNNFDLCO = input.ReadBool();
            break;
          }
          case 64: {
            PLOHABNMCLI = input.ReadUInt32();
            break;
          }
          case 74:
          case 72: {
            mLJAHNMJBMN_.AddEntriesFrom(ref input, _repeated_mLJAHNMJBMN_codec);
            break;
          }
          case 80: {
            GGIFCIKEHOO = input.ReadUInt32();
            break;
          }
          case 96: {
            Status = (global::EggLink.DanhengServer.Proto.TrainVisitorStatus) input.ReadEnum();
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
