// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetCurBattleInfoScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetCurBattleInfoScRsp.proto</summary>
  public static partial class GetCurBattleInfoScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetCurBattleInfoScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetCurBattleInfoScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtHZXRDdXJCYXR0bGVJbmZvU2NSc3AucHJvdG8aFUJhdHRsZUVuZFN0YXR1",
            "cy5wcm90bxocQWV0aGVyRGl2aWRlQmF0dGxlSW5mby5wcm90bxoVU2NlbmVC",
            "YXR0bGVJbmZvLnByb3RvIsEBChVHZXRDdXJCYXR0bGVJbmZvU2NSc3ASMwoS",
            "YWV0aGVyX2JhdHRsZV9pbmZvGAggASgLMhcuQWV0aGVyRGl2aWRlQmF0dGxl",
            "SW5mbxIlCgtiYXR0bGVfaW5mbxgPIAEoCzIQLlNjZW5lQmF0dGxlSW5mbxIP",
            "CgdyZXRjb2RlGAMgASgNEikKD2xhc3RfZW5kX3N0YXR1cxgNIAEoDjIQLkJh",
            "dHRsZUVuZFN0YXR1cxIQCghzdGFnZV9pZBgMIAEoDUIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.BattleEndStatusReflection.Descriptor, global::EggLink.DanhengServer.Proto.AetherDivideBattleInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.SceneBattleInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetCurBattleInfoScRsp), global::EggLink.DanhengServer.Proto.GetCurBattleInfoScRsp.Parser, new[]{ "AetherBattleInfo", "BattleInfo", "Retcode", "LastEndStatus", "StageId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetCurBattleInfoScRsp : pb::IMessage<GetCurBattleInfoScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetCurBattleInfoScRsp> _parser = new pb::MessageParser<GetCurBattleInfoScRsp>(() => new GetCurBattleInfoScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetCurBattleInfoScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetCurBattleInfoScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetCurBattleInfoScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetCurBattleInfoScRsp(GetCurBattleInfoScRsp other) : this() {
      aetherBattleInfo_ = other.aetherBattleInfo_ != null ? other.aetherBattleInfo_.Clone() : null;
      battleInfo_ = other.battleInfo_ != null ? other.battleInfo_.Clone() : null;
      retcode_ = other.retcode_;
      lastEndStatus_ = other.lastEndStatus_;
      stageId_ = other.stageId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetCurBattleInfoScRsp Clone() {
      return new GetCurBattleInfoScRsp(this);
    }

    /// <summary>Field number for the "aether_battle_info" field.</summary>
    public const int AetherBattleInfoFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.AetherDivideBattleInfo aetherBattleInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.AetherDivideBattleInfo AetherBattleInfo {
      get { return aetherBattleInfo_; }
      set {
        aetherBattleInfo_ = value;
      }
    }

    /// <summary>Field number for the "battle_info" field.</summary>
    public const int BattleInfoFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.SceneBattleInfo battleInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.SceneBattleInfo BattleInfo {
      get { return battleInfo_; }
      set {
        battleInfo_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 3;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "last_end_status" field.</summary>
    public const int LastEndStatusFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.BattleEndStatus lastEndStatus_ = global::EggLink.DanhengServer.Proto.BattleEndStatus.BattleEndNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.BattleEndStatus LastEndStatus {
      get { return lastEndStatus_; }
      set {
        lastEndStatus_ = value;
      }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 12;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetCurBattleInfoScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetCurBattleInfoScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(AetherBattleInfo, other.AetherBattleInfo)) return false;
      if (!object.Equals(BattleInfo, other.BattleInfo)) return false;
      if (Retcode != other.Retcode) return false;
      if (LastEndStatus != other.LastEndStatus) return false;
      if (StageId != other.StageId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (aetherBattleInfo_ != null) hash ^= AetherBattleInfo.GetHashCode();
      if (battleInfo_ != null) hash ^= BattleInfo.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (LastEndStatus != global::EggLink.DanhengServer.Proto.BattleEndStatus.BattleEndNone) hash ^= LastEndStatus.GetHashCode();
      if (StageId != 0) hash ^= StageId.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Retcode);
      }
      if (aetherBattleInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(AetherBattleInfo);
      }
      if (StageId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(StageId);
      }
      if (LastEndStatus != global::EggLink.DanhengServer.Proto.BattleEndStatus.BattleEndNone) {
        output.WriteRawTag(104);
        output.WriteEnum((int) LastEndStatus);
      }
      if (battleInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(BattleInfo);
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
      if (Retcode != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Retcode);
      }
      if (aetherBattleInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(AetherBattleInfo);
      }
      if (StageId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(StageId);
      }
      if (LastEndStatus != global::EggLink.DanhengServer.Proto.BattleEndStatus.BattleEndNone) {
        output.WriteRawTag(104);
        output.WriteEnum((int) LastEndStatus);
      }
      if (battleInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(BattleInfo);
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
      if (aetherBattleInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AetherBattleInfo);
      }
      if (battleInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BattleInfo);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (LastEndStatus != global::EggLink.DanhengServer.Proto.BattleEndStatus.BattleEndNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) LastEndStatus);
      }
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetCurBattleInfoScRsp other) {
      if (other == null) {
        return;
      }
      if (other.aetherBattleInfo_ != null) {
        if (aetherBattleInfo_ == null) {
          AetherBattleInfo = new global::EggLink.DanhengServer.Proto.AetherDivideBattleInfo();
        }
        AetherBattleInfo.MergeFrom(other.AetherBattleInfo);
      }
      if (other.battleInfo_ != null) {
        if (battleInfo_ == null) {
          BattleInfo = new global::EggLink.DanhengServer.Proto.SceneBattleInfo();
        }
        BattleInfo.MergeFrom(other.BattleInfo);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.LastEndStatus != global::EggLink.DanhengServer.Proto.BattleEndStatus.BattleEndNone) {
        LastEndStatus = other.LastEndStatus;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
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
          case 24: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 66: {
            if (aetherBattleInfo_ == null) {
              AetherBattleInfo = new global::EggLink.DanhengServer.Proto.AetherDivideBattleInfo();
            }
            input.ReadMessage(AetherBattleInfo);
            break;
          }
          case 96: {
            StageId = input.ReadUInt32();
            break;
          }
          case 104: {
            LastEndStatus = (global::EggLink.DanhengServer.Proto.BattleEndStatus) input.ReadEnum();
            break;
          }
          case 122: {
            if (battleInfo_ == null) {
              BattleInfo = new global::EggLink.DanhengServer.Proto.SceneBattleInfo();
            }
            input.ReadMessage(BattleInfo);
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
          case 24: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 66: {
            if (aetherBattleInfo_ == null) {
              AetherBattleInfo = new global::EggLink.DanhengServer.Proto.AetherDivideBattleInfo();
            }
            input.ReadMessage(AetherBattleInfo);
            break;
          }
          case 96: {
            StageId = input.ReadUInt32();
            break;
          }
          case 104: {
            LastEndStatus = (global::EggLink.DanhengServer.Proto.BattleEndStatus) input.ReadEnum();
            break;
          }
          case 122: {
            if (battleInfo_ == null) {
              BattleInfo = new global::EggLink.DanhengServer.Proto.SceneBattleInfo();
            }
            input.ReadMessage(BattleInfo);
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
