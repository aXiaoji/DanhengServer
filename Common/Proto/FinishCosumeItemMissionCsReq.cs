// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FinishCosumeItemMissionCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from FinishCosumeItemMissionCsReq.proto</summary>
  public static partial class FinishCosumeItemMissionCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for FinishCosumeItemMissionCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FinishCosumeItemMissionCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJGaW5pc2hDb3N1bWVJdGVtTWlzc2lvbkNzUmVxLnByb3RvGg5JdGVtTGlz",
            "dC5wcm90byJUChxGaW5pc2hDb3N1bWVJdGVtTWlzc2lvbkNzUmVxEhwKCWl0",
            "ZW1fbGlzdBgLIAEoCzIJLkl0ZW1MaXN0EhYKDnN1Yl9taXNzaW9uX2lkGAUg",
            "ASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.FinishCosumeItemMissionCsReq), global::EggLink.DanhengServer.Proto.FinishCosumeItemMissionCsReq.Parser, new[]{ "ItemList", "SubMissionId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FinishCosumeItemMissionCsReq : pb::IMessage<FinishCosumeItemMissionCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FinishCosumeItemMissionCsReq> _parser = new pb::MessageParser<FinishCosumeItemMissionCsReq>(() => new FinishCosumeItemMissionCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FinishCosumeItemMissionCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.FinishCosumeItemMissionCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FinishCosumeItemMissionCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FinishCosumeItemMissionCsReq(FinishCosumeItemMissionCsReq other) : this() {
      itemList_ = other.itemList_ != null ? other.itemList_.Clone() : null;
      subMissionId_ = other.subMissionId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FinishCosumeItemMissionCsReq Clone() {
      return new FinishCosumeItemMissionCsReq(this);
    }

    /// <summary>Field number for the "item_list" field.</summary>
    public const int ItemListFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.ItemList itemList_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList ItemList {
      get { return itemList_; }
      set {
        itemList_ = value;
      }
    }

    /// <summary>Field number for the "sub_mission_id" field.</summary>
    public const int SubMissionIdFieldNumber = 5;
    private uint subMissionId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SubMissionId {
      get { return subMissionId_; }
      set {
        subMissionId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FinishCosumeItemMissionCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FinishCosumeItemMissionCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ItemList, other.ItemList)) return false;
      if (SubMissionId != other.SubMissionId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (itemList_ != null) hash ^= ItemList.GetHashCode();
      if (SubMissionId != 0) hash ^= SubMissionId.GetHashCode();
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
      if (SubMissionId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(SubMissionId);
      }
      if (itemList_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(ItemList);
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
      if (SubMissionId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(SubMissionId);
      }
      if (itemList_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(ItemList);
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
      if (itemList_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ItemList);
      }
      if (SubMissionId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SubMissionId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FinishCosumeItemMissionCsReq other) {
      if (other == null) {
        return;
      }
      if (other.itemList_ != null) {
        if (itemList_ == null) {
          ItemList = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        ItemList.MergeFrom(other.ItemList);
      }
      if (other.SubMissionId != 0) {
        SubMissionId = other.SubMissionId;
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
            SubMissionId = input.ReadUInt32();
            break;
          }
          case 90: {
            if (itemList_ == null) {
              ItemList = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(ItemList);
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
            SubMissionId = input.ReadUInt32();
            break;
          }
          case 90: {
            if (itemList_ == null) {
              ItemList = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(ItemList);
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
