// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SetPlayerInfoScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SetPlayerInfoScRsp.proto</summary>
  public static partial class SetPlayerInfoScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for SetPlayerInfoScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SetPlayerInfoScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhTZXRQbGF5ZXJJbmZvU2NSc3AucHJvdG8aE0hlcm9CYXNpY1R5cGUucHJv",
            "dG8idQoSU2V0UGxheWVySW5mb1NjUnNwEhMKC0lFTElEQUlHRU9CGAYgASgD",
            "EiYKDmN1cl9iYXNpY190eXBlGAggASgOMg4uSGVyb0Jhc2ljVHlwZRIRCglp",
            "c19tb2RpZnkYDiABKAgSDwoHcmV0Y29kZRgLIAEoDUIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.HeroBasicTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SetPlayerInfoScRsp), global::EggLink.DanhengServer.Proto.SetPlayerInfoScRsp.Parser, new[]{ "IELIDAIGEOB", "CurBasicType", "IsModify", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SetPlayerInfoScRsp : pb::IMessage<SetPlayerInfoScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SetPlayerInfoScRsp> _parser = new pb::MessageParser<SetPlayerInfoScRsp>(() => new SetPlayerInfoScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SetPlayerInfoScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SetPlayerInfoScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetPlayerInfoScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetPlayerInfoScRsp(SetPlayerInfoScRsp other) : this() {
      iELIDAIGEOB_ = other.iELIDAIGEOB_;
      curBasicType_ = other.curBasicType_;
      isModify_ = other.isModify_;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetPlayerInfoScRsp Clone() {
      return new SetPlayerInfoScRsp(this);
    }

    /// <summary>Field number for the "IELIDAIGEOB" field.</summary>
    public const int IELIDAIGEOBFieldNumber = 6;
    private long iELIDAIGEOB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long IELIDAIGEOB {
      get { return iELIDAIGEOB_; }
      set {
        iELIDAIGEOB_ = value;
      }
    }

    /// <summary>Field number for the "cur_basic_type" field.</summary>
    public const int CurBasicTypeFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.HeroBasicType curBasicType_ = global::EggLink.DanhengServer.Proto.HeroBasicType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HeroBasicType CurBasicType {
      get { return curBasicType_; }
      set {
        curBasicType_ = value;
      }
    }

    /// <summary>Field number for the "is_modify" field.</summary>
    public const int IsModifyFieldNumber = 14;
    private bool isModify_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsModify {
      get { return isModify_; }
      set {
        isModify_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 11;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SetPlayerInfoScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SetPlayerInfoScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IELIDAIGEOB != other.IELIDAIGEOB) return false;
      if (CurBasicType != other.CurBasicType) return false;
      if (IsModify != other.IsModify) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IELIDAIGEOB != 0L) hash ^= IELIDAIGEOB.GetHashCode();
      if (CurBasicType != global::EggLink.DanhengServer.Proto.HeroBasicType.None) hash ^= CurBasicType.GetHashCode();
      if (IsModify != false) hash ^= IsModify.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (IELIDAIGEOB != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(IELIDAIGEOB);
      }
      if (CurBasicType != global::EggLink.DanhengServer.Proto.HeroBasicType.None) {
        output.WriteRawTag(64);
        output.WriteEnum((int) CurBasicType);
      }
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Retcode);
      }
      if (IsModify != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsModify);
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
      if (IELIDAIGEOB != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(IELIDAIGEOB);
      }
      if (CurBasicType != global::EggLink.DanhengServer.Proto.HeroBasicType.None) {
        output.WriteRawTag(64);
        output.WriteEnum((int) CurBasicType);
      }
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Retcode);
      }
      if (IsModify != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsModify);
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
      if (IELIDAIGEOB != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(IELIDAIGEOB);
      }
      if (CurBasicType != global::EggLink.DanhengServer.Proto.HeroBasicType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) CurBasicType);
      }
      if (IsModify != false) {
        size += 1 + 1;
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SetPlayerInfoScRsp other) {
      if (other == null) {
        return;
      }
      if (other.IELIDAIGEOB != 0L) {
        IELIDAIGEOB = other.IELIDAIGEOB;
      }
      if (other.CurBasicType != global::EggLink.DanhengServer.Proto.HeroBasicType.None) {
        CurBasicType = other.CurBasicType;
      }
      if (other.IsModify != false) {
        IsModify = other.IsModify;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
          case 48: {
            IELIDAIGEOB = input.ReadInt64();
            break;
          }
          case 64: {
            CurBasicType = (global::EggLink.DanhengServer.Proto.HeroBasicType) input.ReadEnum();
            break;
          }
          case 88: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 112: {
            IsModify = input.ReadBool();
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
            IELIDAIGEOB = input.ReadInt64();
            break;
          }
          case 64: {
            CurBasicType = (global::EggLink.DanhengServer.Proto.HeroBasicType) input.ReadEnum();
            break;
          }
          case 88: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 112: {
            IsModify = input.ReadBool();
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
