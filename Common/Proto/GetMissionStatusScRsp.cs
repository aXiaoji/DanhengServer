// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetMissionStatusScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetMissionStatusScRsp.proto</summary>
  public static partial class GetMissionStatusScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetMissionStatusScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetMissionStatusScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtHZXRNaXNzaW9uU3RhdHVzU2NSc3AucHJvdG8aDU1pc3Npb24ucHJvdG8i",
            "9wEKFUdldE1pc3Npb25TdGF0dXNTY1JzcBIrChltaXNzaW9uX2V2ZW50X3N0",
            "YXR1c19saXN0GAkgAygLMgguTWlzc2lvbhInCh91bmZpbmlzaGVkX21haW5f",
            "bWlzc2lvbl9pZF9saXN0GAogAygNEiUKHWZpbmlzaGVkX21haW5fbWlzc2lv",
            "bl9pZF9saXN0GA0gAygNEiUKHWRpc2FibGVkX21haW5fbWlzc2lvbl9pZF9s",
            "aXN0GAsgAygNEg8KB3JldGNvZGUYBCABKA0SKQoXc3ViX21pc3Npb25fc3Rh",
            "dHVzX2xpc3QYDiADKAsyCC5NaXNzaW9uQh6qAhtFZ2dMaW5rLkRhbmhlbmdT",
            "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MissionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetMissionStatusScRsp), global::EggLink.DanhengServer.Proto.GetMissionStatusScRsp.Parser, new[]{ "MissionEventStatusList", "UnfinishedMainMissionIdList", "FinishedMainMissionIdList", "DisabledMainMissionIdList", "Retcode", "SubMissionStatusList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetMissionStatusScRsp : pb::IMessage<GetMissionStatusScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetMissionStatusScRsp> _parser = new pb::MessageParser<GetMissionStatusScRsp>(() => new GetMissionStatusScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetMissionStatusScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetMissionStatusScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMissionStatusScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMissionStatusScRsp(GetMissionStatusScRsp other) : this() {
      missionEventStatusList_ = other.missionEventStatusList_.Clone();
      unfinishedMainMissionIdList_ = other.unfinishedMainMissionIdList_.Clone();
      finishedMainMissionIdList_ = other.finishedMainMissionIdList_.Clone();
      disabledMainMissionIdList_ = other.disabledMainMissionIdList_.Clone();
      retcode_ = other.retcode_;
      subMissionStatusList_ = other.subMissionStatusList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMissionStatusScRsp Clone() {
      return new GetMissionStatusScRsp(this);
    }

    /// <summary>Field number for the "mission_event_status_list" field.</summary>
    public const int MissionEventStatusListFieldNumber = 9;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.Mission> _repeated_missionEventStatusList_codec
        = pb::FieldCodec.ForMessage(74, global::EggLink.DanhengServer.Proto.Mission.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Mission> missionEventStatusList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Mission>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Mission> MissionEventStatusList {
      get { return missionEventStatusList_; }
    }

    /// <summary>Field number for the "unfinished_main_mission_id_list" field.</summary>
    public const int UnfinishedMainMissionIdListFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_unfinishedMainMissionIdList_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> unfinishedMainMissionIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> UnfinishedMainMissionIdList {
      get { return unfinishedMainMissionIdList_; }
    }

    /// <summary>Field number for the "finished_main_mission_id_list" field.</summary>
    public const int FinishedMainMissionIdListFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_finishedMainMissionIdList_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> finishedMainMissionIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> FinishedMainMissionIdList {
      get { return finishedMainMissionIdList_; }
    }

    /// <summary>Field number for the "disabled_main_mission_id_list" field.</summary>
    public const int DisabledMainMissionIdListFieldNumber = 11;
    private static readonly pb::FieldCodec<uint> _repeated_disabledMainMissionIdList_codec
        = pb::FieldCodec.ForUInt32(90);
    private readonly pbc::RepeatedField<uint> disabledMainMissionIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> DisabledMainMissionIdList {
      get { return disabledMainMissionIdList_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 4;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "sub_mission_status_list" field.</summary>
    public const int SubMissionStatusListFieldNumber = 14;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.Mission> _repeated_subMissionStatusList_codec
        = pb::FieldCodec.ForMessage(114, global::EggLink.DanhengServer.Proto.Mission.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Mission> subMissionStatusList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Mission>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Mission> SubMissionStatusList {
      get { return subMissionStatusList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetMissionStatusScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetMissionStatusScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!missionEventStatusList_.Equals(other.missionEventStatusList_)) return false;
      if(!unfinishedMainMissionIdList_.Equals(other.unfinishedMainMissionIdList_)) return false;
      if(!finishedMainMissionIdList_.Equals(other.finishedMainMissionIdList_)) return false;
      if(!disabledMainMissionIdList_.Equals(other.disabledMainMissionIdList_)) return false;
      if (Retcode != other.Retcode) return false;
      if(!subMissionStatusList_.Equals(other.subMissionStatusList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= missionEventStatusList_.GetHashCode();
      hash ^= unfinishedMainMissionIdList_.GetHashCode();
      hash ^= finishedMainMissionIdList_.GetHashCode();
      hash ^= disabledMainMissionIdList_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= subMissionStatusList_.GetHashCode();
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
        output.WriteRawTag(32);
        output.WriteUInt32(Retcode);
      }
      missionEventStatusList_.WriteTo(output, _repeated_missionEventStatusList_codec);
      unfinishedMainMissionIdList_.WriteTo(output, _repeated_unfinishedMainMissionIdList_codec);
      disabledMainMissionIdList_.WriteTo(output, _repeated_disabledMainMissionIdList_codec);
      finishedMainMissionIdList_.WriteTo(output, _repeated_finishedMainMissionIdList_codec);
      subMissionStatusList_.WriteTo(output, _repeated_subMissionStatusList_codec);
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
        output.WriteRawTag(32);
        output.WriteUInt32(Retcode);
      }
      missionEventStatusList_.WriteTo(ref output, _repeated_missionEventStatusList_codec);
      unfinishedMainMissionIdList_.WriteTo(ref output, _repeated_unfinishedMainMissionIdList_codec);
      disabledMainMissionIdList_.WriteTo(ref output, _repeated_disabledMainMissionIdList_codec);
      finishedMainMissionIdList_.WriteTo(ref output, _repeated_finishedMainMissionIdList_codec);
      subMissionStatusList_.WriteTo(ref output, _repeated_subMissionStatusList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += missionEventStatusList_.CalculateSize(_repeated_missionEventStatusList_codec);
      size += unfinishedMainMissionIdList_.CalculateSize(_repeated_unfinishedMainMissionIdList_codec);
      size += finishedMainMissionIdList_.CalculateSize(_repeated_finishedMainMissionIdList_codec);
      size += disabledMainMissionIdList_.CalculateSize(_repeated_disabledMainMissionIdList_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      size += subMissionStatusList_.CalculateSize(_repeated_subMissionStatusList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetMissionStatusScRsp other) {
      if (other == null) {
        return;
      }
      missionEventStatusList_.Add(other.missionEventStatusList_);
      unfinishedMainMissionIdList_.Add(other.unfinishedMainMissionIdList_);
      finishedMainMissionIdList_.Add(other.finishedMainMissionIdList_);
      disabledMainMissionIdList_.Add(other.disabledMainMissionIdList_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      subMissionStatusList_.Add(other.subMissionStatusList_);
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
          case 32: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 74: {
            missionEventStatusList_.AddEntriesFrom(input, _repeated_missionEventStatusList_codec);
            break;
          }
          case 82:
          case 80: {
            unfinishedMainMissionIdList_.AddEntriesFrom(input, _repeated_unfinishedMainMissionIdList_codec);
            break;
          }
          case 90:
          case 88: {
            disabledMainMissionIdList_.AddEntriesFrom(input, _repeated_disabledMainMissionIdList_codec);
            break;
          }
          case 106:
          case 104: {
            finishedMainMissionIdList_.AddEntriesFrom(input, _repeated_finishedMainMissionIdList_codec);
            break;
          }
          case 114: {
            subMissionStatusList_.AddEntriesFrom(input, _repeated_subMissionStatusList_codec);
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
          case 32: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 74: {
            missionEventStatusList_.AddEntriesFrom(ref input, _repeated_missionEventStatusList_codec);
            break;
          }
          case 82:
          case 80: {
            unfinishedMainMissionIdList_.AddEntriesFrom(ref input, _repeated_unfinishedMainMissionIdList_codec);
            break;
          }
          case 90:
          case 88: {
            disabledMainMissionIdList_.AddEntriesFrom(ref input, _repeated_disabledMainMissionIdList_codec);
            break;
          }
          case 106:
          case 104: {
            finishedMainMissionIdList_.AddEntriesFrom(ref input, _repeated_finishedMainMissionIdList_codec);
            break;
          }
          case 114: {
            subMissionStatusList_.AddEntriesFrom(ref input, _repeated_subMissionStatusList_codec);
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
