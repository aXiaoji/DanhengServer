// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SyncRogueCommonPendingActionScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SyncRogueCommonPendingActionScNotify.proto</summary>
  public static partial class SyncRogueCommonPendingActionScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for SyncRogueCommonPendingActionScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SyncRogueCommonPendingActionScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CipTeW5jUm9ndWVDb21tb25QZW5kaW5nQWN0aW9uU2NOb3RpZnkucHJvdG8a",
            "HlJvZ3VlQ29tbW9uUGVuZGluZ0FjdGlvbi5wcm90byKAAQokU3luY1JvZ3Vl",
            "Q29tbW9uUGVuZGluZ0FjdGlvblNjTm90aWZ5Ej4KG3JvZ3VlX2NvbW1vbl9w",
            "ZW5kaW5nX2FjdGlvbhgPIAEoCzIZLlJvZ3VlQ29tbW9uUGVuZGluZ0FjdGlv",
            "bhIYChByb2d1ZV92ZXJzaW9uX2lkGAIgASgNQh6qAhtFZ2dMaW5rLkRhbmhl",
            "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueCommonPendingActionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SyncRogueCommonPendingActionScNotify), global::EggLink.DanhengServer.Proto.SyncRogueCommonPendingActionScNotify.Parser, new[]{ "RogueCommonPendingAction", "RogueVersionId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SyncRogueCommonPendingActionScNotify : pb::IMessage<SyncRogueCommonPendingActionScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SyncRogueCommonPendingActionScNotify> _parser = new pb::MessageParser<SyncRogueCommonPendingActionScNotify>(() => new SyncRogueCommonPendingActionScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SyncRogueCommonPendingActionScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SyncRogueCommonPendingActionScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SyncRogueCommonPendingActionScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SyncRogueCommonPendingActionScNotify(SyncRogueCommonPendingActionScNotify other) : this() {
      rogueCommonPendingAction_ = other.rogueCommonPendingAction_ != null ? other.rogueCommonPendingAction_.Clone() : null;
      rogueVersionId_ = other.rogueVersionId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SyncRogueCommonPendingActionScNotify Clone() {
      return new SyncRogueCommonPendingActionScNotify(this);
    }

    /// <summary>Field number for the "rogue_common_pending_action" field.</summary>
    public const int RogueCommonPendingActionFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.RogueCommonPendingAction rogueCommonPendingAction_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueCommonPendingAction RogueCommonPendingAction {
      get { return rogueCommonPendingAction_; }
      set {
        rogueCommonPendingAction_ = value;
      }
    }

    /// <summary>Field number for the "rogue_version_id" field.</summary>
    public const int RogueVersionIdFieldNumber = 2;
    private uint rogueVersionId_;
    /// <summary>
    /// JDBCNGPFDHF
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RogueVersionId {
      get { return rogueVersionId_; }
      set {
        rogueVersionId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SyncRogueCommonPendingActionScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SyncRogueCommonPendingActionScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RogueCommonPendingAction, other.RogueCommonPendingAction)) return false;
      if (RogueVersionId != other.RogueVersionId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (rogueCommonPendingAction_ != null) hash ^= RogueCommonPendingAction.GetHashCode();
      if (RogueVersionId != 0) hash ^= RogueVersionId.GetHashCode();
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
      if (RogueVersionId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(RogueVersionId);
      }
      if (rogueCommonPendingAction_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(RogueCommonPendingAction);
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
      if (RogueVersionId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(RogueVersionId);
      }
      if (rogueCommonPendingAction_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(RogueCommonPendingAction);
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
      if (rogueCommonPendingAction_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueCommonPendingAction);
      }
      if (RogueVersionId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RogueVersionId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SyncRogueCommonPendingActionScNotify other) {
      if (other == null) {
        return;
      }
      if (other.rogueCommonPendingAction_ != null) {
        if (rogueCommonPendingAction_ == null) {
          RogueCommonPendingAction = new global::EggLink.DanhengServer.Proto.RogueCommonPendingAction();
        }
        RogueCommonPendingAction.MergeFrom(other.RogueCommonPendingAction);
      }
      if (other.RogueVersionId != 0) {
        RogueVersionId = other.RogueVersionId;
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
            RogueVersionId = input.ReadUInt32();
            break;
          }
          case 122: {
            if (rogueCommonPendingAction_ == null) {
              RogueCommonPendingAction = new global::EggLink.DanhengServer.Proto.RogueCommonPendingAction();
            }
            input.ReadMessage(RogueCommonPendingAction);
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
            RogueVersionId = input.ReadUInt32();
            break;
          }
          case 122: {
            if (rogueCommonPendingAction_ == null) {
              RogueCommonPendingAction = new global::EggLink.DanhengServer.Proto.RogueCommonPendingAction();
            }
            input.ReadMessage(RogueCommonPendingAction);
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