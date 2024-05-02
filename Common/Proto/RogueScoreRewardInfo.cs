// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueScoreRewardInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueScoreRewardInfo.proto</summary>
  public static partial class RogueScoreRewardInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueScoreRewardInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueScoreRewardInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpSb2d1ZVNjb3JlUmV3YXJkSW5mby5wcm90byLBAQoUUm9ndWVTY29yZVJl",
            "d2FyZEluZm8SHwoXaGFzX3Rha2VuX2luaXRpYWxfc2NvcmUYDiABKAgSEgoK",
            "YmVnaW5fdGltZRgCIAEoAxIQCghlbmRfdGltZRgFIAEoAxIiChp0YWtlbl9u",
            "b3JtYWxfZnJlZV9yb3dfbGlzdBgDIAMoDRIVCg1leHBsb3JlX3Njb3JlGAYg",
            "ASgNEg8KB3Bvb2xfaWQYCSABKA0SFgoOcG9vbF9yZWZyZXNoZWQYByABKAhC",
            "HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo), global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo.Parser, new[]{ "HasTakenInitialScore", "BeginTime", "EndTime", "TakenNormalFreeRowList", "ExploreScore", "PoolId", "PoolRefreshed" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueScoreRewardInfo : pb::IMessage<RogueScoreRewardInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueScoreRewardInfo> _parser = new pb::MessageParser<RogueScoreRewardInfo>(() => new RogueScoreRewardInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueScoreRewardInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueScoreRewardInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueScoreRewardInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueScoreRewardInfo(RogueScoreRewardInfo other) : this() {
      hasTakenInitialScore_ = other.hasTakenInitialScore_;
      beginTime_ = other.beginTime_;
      endTime_ = other.endTime_;
      takenNormalFreeRowList_ = other.takenNormalFreeRowList_.Clone();
      exploreScore_ = other.exploreScore_;
      poolId_ = other.poolId_;
      poolRefreshed_ = other.poolRefreshed_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueScoreRewardInfo Clone() {
      return new RogueScoreRewardInfo(this);
    }

    /// <summary>Field number for the "has_taken_initial_score" field.</summary>
    public const int HasTakenInitialScoreFieldNumber = 14;
    private bool hasTakenInitialScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasTakenInitialScore {
      get { return hasTakenInitialScore_; }
      set {
        hasTakenInitialScore_ = value;
      }
    }

    /// <summary>Field number for the "begin_time" field.</summary>
    public const int BeginTimeFieldNumber = 2;
    private long beginTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long BeginTime {
      get { return beginTime_; }
      set {
        beginTime_ = value;
      }
    }

    /// <summary>Field number for the "end_time" field.</summary>
    public const int EndTimeFieldNumber = 5;
    private long endTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long EndTime {
      get { return endTime_; }
      set {
        endTime_ = value;
      }
    }

    /// <summary>Field number for the "taken_normal_free_row_list" field.</summary>
    public const int TakenNormalFreeRowListFieldNumber = 3;
    private static readonly pb::FieldCodec<uint> _repeated_takenNormalFreeRowList_codec
        = pb::FieldCodec.ForUInt32(26);
    private readonly pbc::RepeatedField<uint> takenNormalFreeRowList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> TakenNormalFreeRowList {
      get { return takenNormalFreeRowList_; }
    }

    /// <summary>Field number for the "explore_score" field.</summary>
    public const int ExploreScoreFieldNumber = 6;
    private uint exploreScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ExploreScore {
      get { return exploreScore_; }
      set {
        exploreScore_ = value;
      }
    }

    /// <summary>Field number for the "pool_id" field.</summary>
    public const int PoolIdFieldNumber = 9;
    private uint poolId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PoolId {
      get { return poolId_; }
      set {
        poolId_ = value;
      }
    }

    /// <summary>Field number for the "pool_refreshed" field.</summary>
    public const int PoolRefreshedFieldNumber = 7;
    private bool poolRefreshed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool PoolRefreshed {
      get { return poolRefreshed_; }
      set {
        poolRefreshed_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueScoreRewardInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueScoreRewardInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HasTakenInitialScore != other.HasTakenInitialScore) return false;
      if (BeginTime != other.BeginTime) return false;
      if (EndTime != other.EndTime) return false;
      if(!takenNormalFreeRowList_.Equals(other.takenNormalFreeRowList_)) return false;
      if (ExploreScore != other.ExploreScore) return false;
      if (PoolId != other.PoolId) return false;
      if (PoolRefreshed != other.PoolRefreshed) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasTakenInitialScore != false) hash ^= HasTakenInitialScore.GetHashCode();
      if (BeginTime != 0L) hash ^= BeginTime.GetHashCode();
      if (EndTime != 0L) hash ^= EndTime.GetHashCode();
      hash ^= takenNormalFreeRowList_.GetHashCode();
      if (ExploreScore != 0) hash ^= ExploreScore.GetHashCode();
      if (PoolId != 0) hash ^= PoolId.GetHashCode();
      if (PoolRefreshed != false) hash ^= PoolRefreshed.GetHashCode();
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
      if (BeginTime != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(BeginTime);
      }
      takenNormalFreeRowList_.WriteTo(output, _repeated_takenNormalFreeRowList_codec);
      if (EndTime != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(EndTime);
      }
      if (ExploreScore != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ExploreScore);
      }
      if (PoolRefreshed != false) {
        output.WriteRawTag(56);
        output.WriteBool(PoolRefreshed);
      }
      if (PoolId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(PoolId);
      }
      if (HasTakenInitialScore != false) {
        output.WriteRawTag(112);
        output.WriteBool(HasTakenInitialScore);
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
      if (BeginTime != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(BeginTime);
      }
      takenNormalFreeRowList_.WriteTo(ref output, _repeated_takenNormalFreeRowList_codec);
      if (EndTime != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(EndTime);
      }
      if (ExploreScore != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ExploreScore);
      }
      if (PoolRefreshed != false) {
        output.WriteRawTag(56);
        output.WriteBool(PoolRefreshed);
      }
      if (PoolId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(PoolId);
      }
      if (HasTakenInitialScore != false) {
        output.WriteRawTag(112);
        output.WriteBool(HasTakenInitialScore);
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
      if (HasTakenInitialScore != false) {
        size += 1 + 1;
      }
      if (BeginTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(BeginTime);
      }
      if (EndTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(EndTime);
      }
      size += takenNormalFreeRowList_.CalculateSize(_repeated_takenNormalFreeRowList_codec);
      if (ExploreScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ExploreScore);
      }
      if (PoolId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PoolId);
      }
      if (PoolRefreshed != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueScoreRewardInfo other) {
      if (other == null) {
        return;
      }
      if (other.HasTakenInitialScore != false) {
        HasTakenInitialScore = other.HasTakenInitialScore;
      }
      if (other.BeginTime != 0L) {
        BeginTime = other.BeginTime;
      }
      if (other.EndTime != 0L) {
        EndTime = other.EndTime;
      }
      takenNormalFreeRowList_.Add(other.takenNormalFreeRowList_);
      if (other.ExploreScore != 0) {
        ExploreScore = other.ExploreScore;
      }
      if (other.PoolId != 0) {
        PoolId = other.PoolId;
      }
      if (other.PoolRefreshed != false) {
        PoolRefreshed = other.PoolRefreshed;
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
          case 16: {
            BeginTime = input.ReadInt64();
            break;
          }
          case 26:
          case 24: {
            takenNormalFreeRowList_.AddEntriesFrom(input, _repeated_takenNormalFreeRowList_codec);
            break;
          }
          case 40: {
            EndTime = input.ReadInt64();
            break;
          }
          case 48: {
            ExploreScore = input.ReadUInt32();
            break;
          }
          case 56: {
            PoolRefreshed = input.ReadBool();
            break;
          }
          case 72: {
            PoolId = input.ReadUInt32();
            break;
          }
          case 112: {
            HasTakenInitialScore = input.ReadBool();
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
          case 16: {
            BeginTime = input.ReadInt64();
            break;
          }
          case 26:
          case 24: {
            takenNormalFreeRowList_.AddEntriesFrom(ref input, _repeated_takenNormalFreeRowList_codec);
            break;
          }
          case 40: {
            EndTime = input.ReadInt64();
            break;
          }
          case 48: {
            ExploreScore = input.ReadUInt32();
            break;
          }
          case 56: {
            PoolRefreshed = input.ReadBool();
            break;
          }
          case 72: {
            PoolId = input.ReadUInt32();
            break;
          }
          case 112: {
            HasTakenInitialScore = input.ReadBool();
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
