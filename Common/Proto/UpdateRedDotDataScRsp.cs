// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: UpdateRedDotDataScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from UpdateRedDotDataScRsp.proto</summary>
  public static partial class UpdateRedDotDataScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for UpdateRedDotDataScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UpdateRedDotDataScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtVcGRhdGVSZWREb3REYXRhU2NSc3AucHJvdG8iYQoVVXBkYXRlUmVkRG90",
            "RGF0YVNjUnNwEhMKC0lJRkVPTkxJSEdHGAQgASgNEg8KB3JldGNvZGUYDSAB",
            "KA0SEAoIZ3JvdXBfaWQYDiABKA0SEAoIcGFuZWxfaWQYDyABKA1CHqoCG0Vn",
            "Z0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.UpdateRedDotDataScRsp), global::EggLink.DanhengServer.Proto.UpdateRedDotDataScRsp.Parser, new[]{ "IIFEONLIHGG", "Retcode", "GroupId", "PanelId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class UpdateRedDotDataScRsp : pb::IMessage<UpdateRedDotDataScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UpdateRedDotDataScRsp> _parser = new pb::MessageParser<UpdateRedDotDataScRsp>(() => new UpdateRedDotDataScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UpdateRedDotDataScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.UpdateRedDotDataScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpdateRedDotDataScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpdateRedDotDataScRsp(UpdateRedDotDataScRsp other) : this() {
      iIFEONLIHGG_ = other.iIFEONLIHGG_;
      retcode_ = other.retcode_;
      groupId_ = other.groupId_;
      panelId_ = other.panelId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpdateRedDotDataScRsp Clone() {
      return new UpdateRedDotDataScRsp(this);
    }

    /// <summary>Field number for the "IIFEONLIHGG" field.</summary>
    public const int IIFEONLIHGGFieldNumber = 4;
    private uint iIFEONLIHGG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IIFEONLIHGG {
      get { return iIFEONLIHGG_; }
      set {
        iIFEONLIHGG_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 13;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "group_id" field.</summary>
    public const int GroupIdFieldNumber = 14;
    private uint groupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GroupId {
      get { return groupId_; }
      set {
        groupId_ = value;
      }
    }

    /// <summary>Field number for the "panel_id" field.</summary>
    public const int PanelIdFieldNumber = 15;
    private uint panelId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PanelId {
      get { return panelId_; }
      set {
        panelId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UpdateRedDotDataScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UpdateRedDotDataScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IIFEONLIHGG != other.IIFEONLIHGG) return false;
      if (Retcode != other.Retcode) return false;
      if (GroupId != other.GroupId) return false;
      if (PanelId != other.PanelId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IIFEONLIHGG != 0) hash ^= IIFEONLIHGG.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (GroupId != 0) hash ^= GroupId.GetHashCode();
      if (PanelId != 0) hash ^= PanelId.GetHashCode();
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
      if (IIFEONLIHGG != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(IIFEONLIHGG);
      }
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Retcode);
      }
      if (GroupId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(GroupId);
      }
      if (PanelId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(PanelId);
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
      if (IIFEONLIHGG != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(IIFEONLIHGG);
      }
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Retcode);
      }
      if (GroupId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(GroupId);
      }
      if (PanelId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(PanelId);
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
      if (IIFEONLIHGG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IIFEONLIHGG);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (GroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
      }
      if (PanelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PanelId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UpdateRedDotDataScRsp other) {
      if (other == null) {
        return;
      }
      if (other.IIFEONLIHGG != 0) {
        IIFEONLIHGG = other.IIFEONLIHGG;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.GroupId != 0) {
        GroupId = other.GroupId;
      }
      if (other.PanelId != 0) {
        PanelId = other.PanelId;
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
          case 32: {
            IIFEONLIHGG = input.ReadUInt32();
            break;
          }
          case 104: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 112: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 120: {
            PanelId = input.ReadUInt32();
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
            IIFEONLIHGG = input.ReadUInt32();
            break;
          }
          case 104: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 112: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 120: {
            PanelId = input.ReadUInt32();
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
