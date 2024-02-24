// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueUpdate.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueUpdate.proto</summary>
  public static partial class RogueUpdateReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueUpdate.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueUpdateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFSb2d1ZVVwZGF0ZS5wcm90byJdCgtSb2d1ZVVwZGF0ZRIVCg1yb2d1ZV90",
            "eXBlX2lkGAwgASgNEhoKEmxhc3Rfcm9ndWVfdHlwZV9pZBgIIAEoDRIbChNs",
            "YXN0X2NvbW1vbl9hcmVhX2lkGAcgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdT",
            "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueUpdate), global::EggLink.DanhengServer.Proto.RogueUpdate.Parser, new[]{ "RogueTypeId", "LastRogueTypeId", "LastCommonAreaId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueUpdate : pb::IMessage<RogueUpdate>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueUpdate> _parser = new pb::MessageParser<RogueUpdate>(() => new RogueUpdate());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueUpdate> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueUpdateReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueUpdate() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueUpdate(RogueUpdate other) : this() {
      rogueTypeId_ = other.rogueTypeId_;
      lastRogueTypeId_ = other.lastRogueTypeId_;
      lastCommonAreaId_ = other.lastCommonAreaId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueUpdate Clone() {
      return new RogueUpdate(this);
    }

    /// <summary>Field number for the "rogue_type_id" field.</summary>
    public const int RogueTypeIdFieldNumber = 12;
    private uint rogueTypeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RogueTypeId {
      get { return rogueTypeId_; }
      set {
        rogueTypeId_ = value;
      }
    }

    /// <summary>Field number for the "last_rogue_type_id" field.</summary>
    public const int LastRogueTypeIdFieldNumber = 8;
    private uint lastRogueTypeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LastRogueTypeId {
      get { return lastRogueTypeId_; }
      set {
        lastRogueTypeId_ = value;
      }
    }

    /// <summary>Field number for the "last_common_area_id" field.</summary>
    public const int LastCommonAreaIdFieldNumber = 7;
    private uint lastCommonAreaId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LastCommonAreaId {
      get { return lastCommonAreaId_; }
      set {
        lastCommonAreaId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueUpdate);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueUpdate other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RogueTypeId != other.RogueTypeId) return false;
      if (LastRogueTypeId != other.LastRogueTypeId) return false;
      if (LastCommonAreaId != other.LastCommonAreaId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (RogueTypeId != 0) hash ^= RogueTypeId.GetHashCode();
      if (LastRogueTypeId != 0) hash ^= LastRogueTypeId.GetHashCode();
      if (LastCommonAreaId != 0) hash ^= LastCommonAreaId.GetHashCode();
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
      if (LastCommonAreaId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(LastCommonAreaId);
      }
      if (LastRogueTypeId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(LastRogueTypeId);
      }
      if (RogueTypeId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(RogueTypeId);
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
      if (LastCommonAreaId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(LastCommonAreaId);
      }
      if (LastRogueTypeId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(LastRogueTypeId);
      }
      if (RogueTypeId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(RogueTypeId);
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
      if (RogueTypeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RogueTypeId);
      }
      if (LastRogueTypeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LastRogueTypeId);
      }
      if (LastCommonAreaId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LastCommonAreaId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueUpdate other) {
      if (other == null) {
        return;
      }
      if (other.RogueTypeId != 0) {
        RogueTypeId = other.RogueTypeId;
      }
      if (other.LastRogueTypeId != 0) {
        LastRogueTypeId = other.LastRogueTypeId;
      }
      if (other.LastCommonAreaId != 0) {
        LastCommonAreaId = other.LastCommonAreaId;
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
          case 56: {
            LastCommonAreaId = input.ReadUInt32();
            break;
          }
          case 64: {
            LastRogueTypeId = input.ReadUInt32();
            break;
          }
          case 96: {
            RogueTypeId = input.ReadUInt32();
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
          case 56: {
            LastCommonAreaId = input.ReadUInt32();
            break;
          }
          case 64: {
            LastRogueTypeId = input.ReadUInt32();
            break;
          }
          case 96: {
            RogueTypeId = input.ReadUInt32();
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