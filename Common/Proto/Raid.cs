// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Raid.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from Raid.proto</summary>
  public static partial class RaidReflection {

    #region Descriptor
    /// <summary>File descriptor for Raid.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RaidReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgpSYWlkLnByb3RvGhZSYWlkVGFyZ2V0U3RhdHVzLnByb3RvIl8KBFJhaWQS",
            "EwoLRElLRU9KUEJDS1AYDCABKA0SEwoLRkVDTFBPUElOTkQYDSABKA0SLQoS",
            "cmFpZF90YXJnZXRfc3RhdHVzGAUgASgOMhEuUmFpZFRhcmdldFN0YXR1c0Ie",
            "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RaidTargetStatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.Raid), global::EggLink.DanhengServer.Proto.Raid.Parser, new[]{ "DIKEOJPBCKP", "FECLPOPINND", "RaidTargetStatus" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Raid : pb::IMessage<Raid>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Raid> _parser = new pb::MessageParser<Raid>(() => new Raid());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Raid> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RaidReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Raid() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Raid(Raid other) : this() {
      dIKEOJPBCKP_ = other.dIKEOJPBCKP_;
      fECLPOPINND_ = other.fECLPOPINND_;
      raidTargetStatus_ = other.raidTargetStatus_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Raid Clone() {
      return new Raid(this);
    }

    /// <summary>Field number for the "DIKEOJPBCKP" field.</summary>
    public const int DIKEOJPBCKPFieldNumber = 12;
    private uint dIKEOJPBCKP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DIKEOJPBCKP {
      get { return dIKEOJPBCKP_; }
      set {
        dIKEOJPBCKP_ = value;
      }
    }

    /// <summary>Field number for the "FECLPOPINND" field.</summary>
    public const int FECLPOPINNDFieldNumber = 13;
    private uint fECLPOPINND_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FECLPOPINND {
      get { return fECLPOPINND_; }
      set {
        fECLPOPINND_ = value;
      }
    }

    /// <summary>Field number for the "raid_target_status" field.</summary>
    public const int RaidTargetStatusFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.RaidTargetStatus raidTargetStatus_ = global::EggLink.DanhengServer.Proto.RaidTargetStatus.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RaidTargetStatus RaidTargetStatus {
      get { return raidTargetStatus_; }
      set {
        raidTargetStatus_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Raid);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Raid other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DIKEOJPBCKP != other.DIKEOJPBCKP) return false;
      if (FECLPOPINND != other.FECLPOPINND) return false;
      if (RaidTargetStatus != other.RaidTargetStatus) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DIKEOJPBCKP != 0) hash ^= DIKEOJPBCKP.GetHashCode();
      if (FECLPOPINND != 0) hash ^= FECLPOPINND.GetHashCode();
      if (RaidTargetStatus != global::EggLink.DanhengServer.Proto.RaidTargetStatus.None) hash ^= RaidTargetStatus.GetHashCode();
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
      if (RaidTargetStatus != global::EggLink.DanhengServer.Proto.RaidTargetStatus.None) {
        output.WriteRawTag(40);
        output.WriteEnum((int) RaidTargetStatus);
      }
      if (DIKEOJPBCKP != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(DIKEOJPBCKP);
      }
      if (FECLPOPINND != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(FECLPOPINND);
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
      if (RaidTargetStatus != global::EggLink.DanhengServer.Proto.RaidTargetStatus.None) {
        output.WriteRawTag(40);
        output.WriteEnum((int) RaidTargetStatus);
      }
      if (DIKEOJPBCKP != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(DIKEOJPBCKP);
      }
      if (FECLPOPINND != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(FECLPOPINND);
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
      if (DIKEOJPBCKP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DIKEOJPBCKP);
      }
      if (FECLPOPINND != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FECLPOPINND);
      }
      if (RaidTargetStatus != global::EggLink.DanhengServer.Proto.RaidTargetStatus.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) RaidTargetStatus);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Raid other) {
      if (other == null) {
        return;
      }
      if (other.DIKEOJPBCKP != 0) {
        DIKEOJPBCKP = other.DIKEOJPBCKP;
      }
      if (other.FECLPOPINND != 0) {
        FECLPOPINND = other.FECLPOPINND;
      }
      if (other.RaidTargetStatus != global::EggLink.DanhengServer.Proto.RaidTargetStatus.None) {
        RaidTargetStatus = other.RaidTargetStatus;
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
          case 40: {
            RaidTargetStatus = (global::EggLink.DanhengServer.Proto.RaidTargetStatus) input.ReadEnum();
            break;
          }
          case 96: {
            DIKEOJPBCKP = input.ReadUInt32();
            break;
          }
          case 104: {
            FECLPOPINND = input.ReadUInt32();
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
          case 40: {
            RaidTargetStatus = (global::EggLink.DanhengServer.Proto.RaidTargetStatus) input.ReadEnum();
            break;
          }
          case 96: {
            DIKEOJPBCKP = input.ReadUInt32();
            break;
          }
          case 104: {
            FECLPOPINND = input.ReadUInt32();
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
