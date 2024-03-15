// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MessageSection.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MessageSection.proto</summary>
  public static partial class MessageSectionReflection {

    #region Descriptor
    /// <summary>File descriptor for MessageSection.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MessageSectionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRNZXNzYWdlU2VjdGlvbi5wcm90bxoaTWVzc2FnZVNlY3Rpb25TdGF0dXMu",
            "cHJvdG8aEU1lc3NhZ2VJdGVtLnByb3RvIpIBCg5NZXNzYWdlU2VjdGlvbhIl",
            "CgZzdGF0dXMYCCABKA4yFS5NZXNzYWdlU2VjdGlvblN0YXR1cxITCgtFQ0VH",
            "QkNQSk5ITxgDIAMoDRIKCgJpZBgGIAEoDRIfCglpdGVtX2xpc3QYBCADKAsy",
            "DC5NZXNzYWdlSXRlbRIXCg9tZXNzYWdlX2l0ZW1faWQYDCABKA1CHqoCG0Vn",
            "Z0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MessageSectionStatusReflection.Descriptor, global::EggLink.DanhengServer.Proto.MessageItemReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MessageSection), global::EggLink.DanhengServer.Proto.MessageSection.Parser, new[]{ "Status", "ECEGBCPJNHO", "Id", "ItemList", "MessageItemId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MessageSection : pb::IMessage<MessageSection>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MessageSection> _parser = new pb::MessageParser<MessageSection>(() => new MessageSection());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MessageSection> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MessageSectionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MessageSection() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MessageSection(MessageSection other) : this() {
      status_ = other.status_;
      eCEGBCPJNHO_ = other.eCEGBCPJNHO_.Clone();
      id_ = other.id_;
      itemList_ = other.itemList_.Clone();
      messageItemId_ = other.messageItemId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MessageSection Clone() {
      return new MessageSection(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.MessageSectionStatus status_ = global::EggLink.DanhengServer.Proto.MessageSectionStatus.MessageSectionNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MessageSectionStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "ECEGBCPJNHO" field.</summary>
    public const int ECEGBCPJNHOFieldNumber = 3;
    private static readonly pb::FieldCodec<uint> _repeated_eCEGBCPJNHO_codec
        = pb::FieldCodec.ForUInt32(26);
    private readonly pbc::RepeatedField<uint> eCEGBCPJNHO_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ECEGBCPJNHO {
      get { return eCEGBCPJNHO_; }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 6;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "item_list" field.</summary>
    public const int ItemListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.MessageItem> _repeated_itemList_codec
        = pb::FieldCodec.ForMessage(34, global::EggLink.DanhengServer.Proto.MessageItem.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MessageItem> itemList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MessageItem>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MessageItem> ItemList {
      get { return itemList_; }
    }

    /// <summary>Field number for the "message_item_id" field.</summary>
    public const int MessageItemIdFieldNumber = 12;
    private uint messageItemId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MessageItemId {
      get { return messageItemId_; }
      set {
        messageItemId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MessageSection);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MessageSection other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      if(!eCEGBCPJNHO_.Equals(other.eCEGBCPJNHO_)) return false;
      if (Id != other.Id) return false;
      if(!itemList_.Equals(other.itemList_)) return false;
      if (MessageItemId != other.MessageItemId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != global::EggLink.DanhengServer.Proto.MessageSectionStatus.MessageSectionNone) hash ^= Status.GetHashCode();
      hash ^= eCEGBCPJNHO_.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      hash ^= itemList_.GetHashCode();
      if (MessageItemId != 0) hash ^= MessageItemId.GetHashCode();
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
      eCEGBCPJNHO_.WriteTo(output, _repeated_eCEGBCPJNHO_codec);
      itemList_.WriteTo(output, _repeated_itemList_codec);
      if (Id != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Id);
      }
      if (Status != global::EggLink.DanhengServer.Proto.MessageSectionStatus.MessageSectionNone) {
        output.WriteRawTag(64);
        output.WriteEnum((int) Status);
      }
      if (MessageItemId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(MessageItemId);
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
      eCEGBCPJNHO_.WriteTo(ref output, _repeated_eCEGBCPJNHO_codec);
      itemList_.WriteTo(ref output, _repeated_itemList_codec);
      if (Id != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Id);
      }
      if (Status != global::EggLink.DanhengServer.Proto.MessageSectionStatus.MessageSectionNone) {
        output.WriteRawTag(64);
        output.WriteEnum((int) Status);
      }
      if (MessageItemId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(MessageItemId);
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
      if (Status != global::EggLink.DanhengServer.Proto.MessageSectionStatus.MessageSectionNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      size += eCEGBCPJNHO_.CalculateSize(_repeated_eCEGBCPJNHO_codec);
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      size += itemList_.CalculateSize(_repeated_itemList_codec);
      if (MessageItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MessageItemId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MessageSection other) {
      if (other == null) {
        return;
      }
      if (other.Status != global::EggLink.DanhengServer.Proto.MessageSectionStatus.MessageSectionNone) {
        Status = other.Status;
      }
      eCEGBCPJNHO_.Add(other.eCEGBCPJNHO_);
      if (other.Id != 0) {
        Id = other.Id;
      }
      itemList_.Add(other.itemList_);
      if (other.MessageItemId != 0) {
        MessageItemId = other.MessageItemId;
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
          case 26:
          case 24: {
            eCEGBCPJNHO_.AddEntriesFrom(input, _repeated_eCEGBCPJNHO_codec);
            break;
          }
          case 34: {
            itemList_.AddEntriesFrom(input, _repeated_itemList_codec);
            break;
          }
          case 48: {
            Id = input.ReadUInt32();
            break;
          }
          case 64: {
            Status = (global::EggLink.DanhengServer.Proto.MessageSectionStatus) input.ReadEnum();
            break;
          }
          case 96: {
            MessageItemId = input.ReadUInt32();
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
          case 26:
          case 24: {
            eCEGBCPJNHO_.AddEntriesFrom(ref input, _repeated_eCEGBCPJNHO_codec);
            break;
          }
          case 34: {
            itemList_.AddEntriesFrom(ref input, _repeated_itemList_codec);
            break;
          }
          case 48: {
            Id = input.ReadUInt32();
            break;
          }
          case 64: {
            Status = (global::EggLink.DanhengServer.Proto.MessageSectionStatus) input.ReadEnum();
            break;
          }
          case 96: {
            MessageItemId = input.ReadUInt32();
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
