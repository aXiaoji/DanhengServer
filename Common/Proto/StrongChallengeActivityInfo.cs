// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StrongChallengeActivityInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from StrongChallengeActivityInfo.proto</summary>
  public static partial class StrongChallengeActivityInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for StrongChallengeActivityInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StrongChallengeActivityInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFTdHJvbmdDaGFsbGVuZ2VBY3Rpdml0eUluZm8ucHJvdG8aIVN0cm9uZ0No",
            "YWxsZW5nZUFjdGl2aXR5RGF0YS5wcm90byLmAQobU3Ryb25nQ2hhbGxlbmdl",
            "QWN0aXZpdHlJbmZvEmUKHnN0cm9uZ19jaGFsbGVuZ2VfYWN0aXZpdHlfbGlz",
            "dBgHIAMoCzI9LlN0cm9uZ0NoYWxsZW5nZUFjdGl2aXR5SW5mby5TdHJvbmdD",
            "aGFsbGVuZ2VBY3Rpdml0eUxpc3RFbnRyeRpgCiBTdHJvbmdDaGFsbGVuZ2VB",
            "Y3Rpdml0eUxpc3RFbnRyeRILCgNrZXkYASABKA0SKwoFdmFsdWUYAiABKAsy",
            "HC5TdHJvbmdDaGFsbGVuZ2VBY3Rpdml0eURhdGE6AjgBQh6qAhtFZ2dMaW5r",
            "LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.StrongChallengeActivityDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.StrongChallengeActivityInfo), global::EggLink.DanhengServer.Proto.StrongChallengeActivityInfo.Parser, new[]{ "StrongChallengeActivityList" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class StrongChallengeActivityInfo : pb::IMessage<StrongChallengeActivityInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StrongChallengeActivityInfo> _parser = new pb::MessageParser<StrongChallengeActivityInfo>(() => new StrongChallengeActivityInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StrongChallengeActivityInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.StrongChallengeActivityInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StrongChallengeActivityInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StrongChallengeActivityInfo(StrongChallengeActivityInfo other) : this() {
      strongChallengeActivityList_ = other.strongChallengeActivityList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StrongChallengeActivityInfo Clone() {
      return new StrongChallengeActivityInfo(this);
    }

    /// <summary>Field number for the "strong_challenge_activity_list" field.</summary>
    public const int StrongChallengeActivityListFieldNumber = 7;
    private static readonly pbc::MapField<uint, global::EggLink.DanhengServer.Proto.StrongChallengeActivityData>.Codec _map_strongChallengeActivityList_codec
        = new pbc::MapField<uint, global::EggLink.DanhengServer.Proto.StrongChallengeActivityData>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::EggLink.DanhengServer.Proto.StrongChallengeActivityData.Parser), 58);
    private readonly pbc::MapField<uint, global::EggLink.DanhengServer.Proto.StrongChallengeActivityData> strongChallengeActivityList_ = new pbc::MapField<uint, global::EggLink.DanhengServer.Proto.StrongChallengeActivityData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::EggLink.DanhengServer.Proto.StrongChallengeActivityData> StrongChallengeActivityList {
      get { return strongChallengeActivityList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StrongChallengeActivityInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StrongChallengeActivityInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!StrongChallengeActivityList.Equals(other.StrongChallengeActivityList)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= StrongChallengeActivityList.GetHashCode();
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
      strongChallengeActivityList_.WriteTo(output, _map_strongChallengeActivityList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      strongChallengeActivityList_.WriteTo(ref output, _map_strongChallengeActivityList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += strongChallengeActivityList_.CalculateSize(_map_strongChallengeActivityList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StrongChallengeActivityInfo other) {
      if (other == null) {
        return;
      }
      strongChallengeActivityList_.MergeFrom(other.strongChallengeActivityList_);
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
          case 58: {
            strongChallengeActivityList_.AddEntriesFrom(input, _map_strongChallengeActivityList_codec);
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
          case 58: {
            strongChallengeActivityList_.AddEntriesFrom(ref input, _map_strongChallengeActivityList_codec);
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
