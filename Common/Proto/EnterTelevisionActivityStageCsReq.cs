// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EnterTelevisionActivityStageCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from EnterTelevisionActivityStageCsReq.proto</summary>
  public static partial class EnterTelevisionActivityStageCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for EnterTelevisionActivityStageCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EnterTelevisionActivityStageCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidFbnRlclRlbGV2aXNpb25BY3Rpdml0eVN0YWdlQ3NSZXEucHJvdG8aFlRl",
            "bGV2aXNpb25BdmF0YXIucHJvdG8icwohRW50ZXJUZWxldmlzaW9uQWN0aXZp",
            "dHlTdGFnZUNzUmVxEhMKC0dHTUlNREpIRkxJGAYgASgNEhEKCWJ1ZmZfbGlz",
            "dBgKIAMoDRImCgthdmF0YXJfbGlzdBgOIAMoCzIRLlRlbGV2aXNpb25BdmF0",
            "YXJCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.TelevisionAvatarReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.EnterTelevisionActivityStageCsReq), global::EggLink.DanhengServer.Proto.EnterTelevisionActivityStageCsReq.Parser, new[]{ "GGMIMDJHFLI", "BuffList", "AvatarList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class EnterTelevisionActivityStageCsReq : pb::IMessage<EnterTelevisionActivityStageCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EnterTelevisionActivityStageCsReq> _parser = new pb::MessageParser<EnterTelevisionActivityStageCsReq>(() => new EnterTelevisionActivityStageCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EnterTelevisionActivityStageCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.EnterTelevisionActivityStageCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterTelevisionActivityStageCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterTelevisionActivityStageCsReq(EnterTelevisionActivityStageCsReq other) : this() {
      gGMIMDJHFLI_ = other.gGMIMDJHFLI_;
      buffList_ = other.buffList_.Clone();
      avatarList_ = other.avatarList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterTelevisionActivityStageCsReq Clone() {
      return new EnterTelevisionActivityStageCsReq(this);
    }

    /// <summary>Field number for the "GGMIMDJHFLI" field.</summary>
    public const int GGMIMDJHFLIFieldNumber = 6;
    private uint gGMIMDJHFLI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GGMIMDJHFLI {
      get { return gGMIMDJHFLI_; }
      set {
        gGMIMDJHFLI_ = value;
      }
    }

    /// <summary>Field number for the "buff_list" field.</summary>
    public const int BuffListFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_buffList_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> buffList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> BuffList {
      get { return buffList_; }
    }

    /// <summary>Field number for the "avatar_list" field.</summary>
    public const int AvatarListFieldNumber = 14;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.TelevisionAvatar> _repeated_avatarList_codec
        = pb::FieldCodec.ForMessage(114, global::EggLink.DanhengServer.Proto.TelevisionAvatar.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.TelevisionAvatar> avatarList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.TelevisionAvatar>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.TelevisionAvatar> AvatarList {
      get { return avatarList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EnterTelevisionActivityStageCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EnterTelevisionActivityStageCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GGMIMDJHFLI != other.GGMIMDJHFLI) return false;
      if(!buffList_.Equals(other.buffList_)) return false;
      if(!avatarList_.Equals(other.avatarList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GGMIMDJHFLI != 0) hash ^= GGMIMDJHFLI.GetHashCode();
      hash ^= buffList_.GetHashCode();
      hash ^= avatarList_.GetHashCode();
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
      if (GGMIMDJHFLI != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(GGMIMDJHFLI);
      }
      buffList_.WriteTo(output, _repeated_buffList_codec);
      avatarList_.WriteTo(output, _repeated_avatarList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (GGMIMDJHFLI != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(GGMIMDJHFLI);
      }
      buffList_.WriteTo(ref output, _repeated_buffList_codec);
      avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (GGMIMDJHFLI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GGMIMDJHFLI);
      }
      size += buffList_.CalculateSize(_repeated_buffList_codec);
      size += avatarList_.CalculateSize(_repeated_avatarList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EnterTelevisionActivityStageCsReq other) {
      if (other == null) {
        return;
      }
      if (other.GGMIMDJHFLI != 0) {
        GGMIMDJHFLI = other.GGMIMDJHFLI;
      }
      buffList_.Add(other.buffList_);
      avatarList_.Add(other.avatarList_);
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
          case 48: {
            GGMIMDJHFLI = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            buffList_.AddEntriesFrom(input, _repeated_buffList_codec);
            break;
          }
          case 114: {
            avatarList_.AddEntriesFrom(input, _repeated_avatarList_codec);
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
          case 48: {
            GGMIMDJHFLI = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            buffList_.AddEntriesFrom(ref input, _repeated_buffList_codec);
            break;
          }
          case 114: {
            avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
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
