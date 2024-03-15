// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ClientMail.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ClientMail.proto</summary>
  public static partial class ClientMailReflection {

    #region Descriptor
    /// <summary>File descriptor for ClientMail.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientMailReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBDbGllbnRNYWlsLnByb3RvGg5JdGVtTGlzdC5wcm90bxoOTWFpbFR5cGUu",
            "cHJvdG8i4QEKCkNsaWVudE1haWwSDwoHaXNfcmVhZBgCIAEoCBIRCglwYXJh",
            "X2xpc3QYBCADKAkSEwoLZXhwaXJlX3RpbWUYDiABKAMSDQoFdGl0bGUYByAB",
            "KAkSDAoEdGltZRgPIAEoAxIKCgJpZBgBIAEoDRITCgt0ZW1wbGF0ZV9pZBgJ",
            "IAEoDRIcCgltYWlsX3R5cGUYDSABKA4yCS5NYWlsVHlwZRIPCgdjb250ZW50",
            "GAYgASgJEg4KBnNlbmRlchgFIAEoCRIdCgphdHRhY2htZW50GAsgASgLMgku",
            "SXRlbUxpc3RCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, global::EggLink.DanhengServer.Proto.MailTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ClientMail), global::EggLink.DanhengServer.Proto.ClientMail.Parser, new[]{ "IsRead", "ParaList", "ExpireTime", "Title", "Time", "Id", "TemplateId", "MailType", "Content", "Sender", "Attachment" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ClientMail : pb::IMessage<ClientMail>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ClientMail> _parser = new pb::MessageParser<ClientMail>(() => new ClientMail());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ClientMail> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ClientMailReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientMail() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientMail(ClientMail other) : this() {
      isRead_ = other.isRead_;
      paraList_ = other.paraList_.Clone();
      expireTime_ = other.expireTime_;
      title_ = other.title_;
      time_ = other.time_;
      id_ = other.id_;
      templateId_ = other.templateId_;
      mailType_ = other.mailType_;
      content_ = other.content_;
      sender_ = other.sender_;
      attachment_ = other.attachment_ != null ? other.attachment_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientMail Clone() {
      return new ClientMail(this);
    }

    /// <summary>Field number for the "is_read" field.</summary>
    public const int IsReadFieldNumber = 2;
    private bool isRead_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsRead {
      get { return isRead_; }
      set {
        isRead_ = value;
      }
    }

    /// <summary>Field number for the "para_list" field.</summary>
    public const int ParaListFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _repeated_paraList_codec
        = pb::FieldCodec.ForString(34);
    private readonly pbc::RepeatedField<string> paraList_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> ParaList {
      get { return paraList_; }
    }

    /// <summary>Field number for the "expire_time" field.</summary>
    public const int ExpireTimeFieldNumber = 14;
    private long expireTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long ExpireTime {
      get { return expireTime_; }
      set {
        expireTime_ = value;
      }
    }

    /// <summary>Field number for the "title" field.</summary>
    public const int TitleFieldNumber = 7;
    private string title_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Title {
      get { return title_; }
      set {
        title_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "time" field.</summary>
    public const int TimeFieldNumber = 15;
    private long time_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Time {
      get { return time_; }
      set {
        time_ = value;
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "template_id" field.</summary>
    public const int TemplateIdFieldNumber = 9;
    private uint templateId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TemplateId {
      get { return templateId_; }
      set {
        templateId_ = value;
      }
    }

    /// <summary>Field number for the "mail_type" field.</summary>
    public const int MailTypeFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.MailType mailType_ = global::EggLink.DanhengServer.Proto.MailType.Normal;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MailType MailType {
      get { return mailType_; }
      set {
        mailType_ = value;
      }
    }

    /// <summary>Field number for the "content" field.</summary>
    public const int ContentFieldNumber = 6;
    private string content_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Content {
      get { return content_; }
      set {
        content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "sender" field.</summary>
    public const int SenderFieldNumber = 5;
    private string sender_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Sender {
      get { return sender_; }
      set {
        sender_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "attachment" field.</summary>
    public const int AttachmentFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.ItemList attachment_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList Attachment {
      get { return attachment_; }
      set {
        attachment_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ClientMail);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ClientMail other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsRead != other.IsRead) return false;
      if(!paraList_.Equals(other.paraList_)) return false;
      if (ExpireTime != other.ExpireTime) return false;
      if (Title != other.Title) return false;
      if (Time != other.Time) return false;
      if (Id != other.Id) return false;
      if (TemplateId != other.TemplateId) return false;
      if (MailType != other.MailType) return false;
      if (Content != other.Content) return false;
      if (Sender != other.Sender) return false;
      if (!object.Equals(Attachment, other.Attachment)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsRead != false) hash ^= IsRead.GetHashCode();
      hash ^= paraList_.GetHashCode();
      if (ExpireTime != 0L) hash ^= ExpireTime.GetHashCode();
      if (Title.Length != 0) hash ^= Title.GetHashCode();
      if (Time != 0L) hash ^= Time.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      if (TemplateId != 0) hash ^= TemplateId.GetHashCode();
      if (MailType != global::EggLink.DanhengServer.Proto.MailType.Normal) hash ^= MailType.GetHashCode();
      if (Content.Length != 0) hash ^= Content.GetHashCode();
      if (Sender.Length != 0) hash ^= Sender.GetHashCode();
      if (attachment_ != null) hash ^= Attachment.GetHashCode();
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
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Id);
      }
      if (IsRead != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsRead);
      }
      paraList_.WriteTo(output, _repeated_paraList_codec);
      if (Sender.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Sender);
      }
      if (Content.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Content);
      }
      if (Title.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Title);
      }
      if (TemplateId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(TemplateId);
      }
      if (attachment_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(Attachment);
      }
      if (MailType != global::EggLink.DanhengServer.Proto.MailType.Normal) {
        output.WriteRawTag(104);
        output.WriteEnum((int) MailType);
      }
      if (ExpireTime != 0L) {
        output.WriteRawTag(112);
        output.WriteInt64(ExpireTime);
      }
      if (Time != 0L) {
        output.WriteRawTag(120);
        output.WriteInt64(Time);
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
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Id);
      }
      if (IsRead != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsRead);
      }
      paraList_.WriteTo(ref output, _repeated_paraList_codec);
      if (Sender.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Sender);
      }
      if (Content.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Content);
      }
      if (Title.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Title);
      }
      if (TemplateId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(TemplateId);
      }
      if (attachment_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(Attachment);
      }
      if (MailType != global::EggLink.DanhengServer.Proto.MailType.Normal) {
        output.WriteRawTag(104);
        output.WriteEnum((int) MailType);
      }
      if (ExpireTime != 0L) {
        output.WriteRawTag(112);
        output.WriteInt64(ExpireTime);
      }
      if (Time != 0L) {
        output.WriteRawTag(120);
        output.WriteInt64(Time);
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
      if (IsRead != false) {
        size += 1 + 1;
      }
      size += paraList_.CalculateSize(_repeated_paraList_codec);
      if (ExpireTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ExpireTime);
      }
      if (Title.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Title);
      }
      if (Time != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Time);
      }
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      if (TemplateId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TemplateId);
      }
      if (MailType != global::EggLink.DanhengServer.Proto.MailType.Normal) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MailType);
      }
      if (Content.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Content);
      }
      if (Sender.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Sender);
      }
      if (attachment_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Attachment);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ClientMail other) {
      if (other == null) {
        return;
      }
      if (other.IsRead != false) {
        IsRead = other.IsRead;
      }
      paraList_.Add(other.paraList_);
      if (other.ExpireTime != 0L) {
        ExpireTime = other.ExpireTime;
      }
      if (other.Title.Length != 0) {
        Title = other.Title;
      }
      if (other.Time != 0L) {
        Time = other.Time;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.TemplateId != 0) {
        TemplateId = other.TemplateId;
      }
      if (other.MailType != global::EggLink.DanhengServer.Proto.MailType.Normal) {
        MailType = other.MailType;
      }
      if (other.Content.Length != 0) {
        Content = other.Content;
      }
      if (other.Sender.Length != 0) {
        Sender = other.Sender;
      }
      if (other.attachment_ != null) {
        if (attachment_ == null) {
          Attachment = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        Attachment.MergeFrom(other.Attachment);
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
            Id = input.ReadUInt32();
            break;
          }
          case 16: {
            IsRead = input.ReadBool();
            break;
          }
          case 34: {
            paraList_.AddEntriesFrom(input, _repeated_paraList_codec);
            break;
          }
          case 42: {
            Sender = input.ReadString();
            break;
          }
          case 50: {
            Content = input.ReadString();
            break;
          }
          case 58: {
            Title = input.ReadString();
            break;
          }
          case 72: {
            TemplateId = input.ReadUInt32();
            break;
          }
          case 90: {
            if (attachment_ == null) {
              Attachment = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Attachment);
            break;
          }
          case 104: {
            MailType = (global::EggLink.DanhengServer.Proto.MailType) input.ReadEnum();
            break;
          }
          case 112: {
            ExpireTime = input.ReadInt64();
            break;
          }
          case 120: {
            Time = input.ReadInt64();
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
            Id = input.ReadUInt32();
            break;
          }
          case 16: {
            IsRead = input.ReadBool();
            break;
          }
          case 34: {
            paraList_.AddEntriesFrom(ref input, _repeated_paraList_codec);
            break;
          }
          case 42: {
            Sender = input.ReadString();
            break;
          }
          case 50: {
            Content = input.ReadString();
            break;
          }
          case 58: {
            Title = input.ReadString();
            break;
          }
          case 72: {
            TemplateId = input.ReadUInt32();
            break;
          }
          case 90: {
            if (attachment_ == null) {
              Attachment = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Attachment);
            break;
          }
          case 104: {
            MailType = (global::EggLink.DanhengServer.Proto.MailType) input.ReadEnum();
            break;
          }
          case 112: {
            ExpireTime = input.ReadInt64();
            break;
          }
          case 120: {
            Time = input.ReadInt64();
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
