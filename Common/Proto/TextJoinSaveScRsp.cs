// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TextJoinSaveScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TextJoinSaveScRsp.proto</summary>
  public static partial class TextJoinSaveScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for TextJoinSaveScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TextJoinSaveScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdUZXh0Sm9pblNhdmVTY1JzcC5wcm90byJjChFUZXh0Sm9pblNhdmVTY1Jz",
            "cBIPCgdyZXRjb2RlGAQgASgNEhMKC0xFT0JPUERBREZJGA8gASgJEhMKC0tL",
            "QUJDQ0VJRENCGAkgASgNEhMKC0lCSUtJQkpLREVJGAUgASgNQh6qAhtFZ2dM",
            "aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TextJoinSaveScRsp), global::EggLink.DanhengServer.Proto.TextJoinSaveScRsp.Parser, new[]{ "Retcode", "LEOBOPDADFI", "KKABCCEIDCB", "IBIKIBJKDEI" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TextJoinSaveScRsp : pb::IMessage<TextJoinSaveScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TextJoinSaveScRsp> _parser = new pb::MessageParser<TextJoinSaveScRsp>(() => new TextJoinSaveScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TextJoinSaveScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.TextJoinSaveScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TextJoinSaveScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TextJoinSaveScRsp(TextJoinSaveScRsp other) : this() {
      retcode_ = other.retcode_;
      lEOBOPDADFI_ = other.lEOBOPDADFI_;
      kKABCCEIDCB_ = other.kKABCCEIDCB_;
      iBIKIBJKDEI_ = other.iBIKIBJKDEI_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TextJoinSaveScRsp Clone() {
      return new TextJoinSaveScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 4;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "LEOBOPDADFI" field.</summary>
    public const int LEOBOPDADFIFieldNumber = 15;
    private string lEOBOPDADFI_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string LEOBOPDADFI {
      get { return lEOBOPDADFI_; }
      set {
        lEOBOPDADFI_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "KKABCCEIDCB" field.</summary>
    public const int KKABCCEIDCBFieldNumber = 9;
    private uint kKABCCEIDCB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KKABCCEIDCB {
      get { return kKABCCEIDCB_; }
      set {
        kKABCCEIDCB_ = value;
      }
    }

    /// <summary>Field number for the "IBIKIBJKDEI" field.</summary>
    public const int IBIKIBJKDEIFieldNumber = 5;
    private uint iBIKIBJKDEI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IBIKIBJKDEI {
      get { return iBIKIBJKDEI_; }
      set {
        iBIKIBJKDEI_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TextJoinSaveScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TextJoinSaveScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (LEOBOPDADFI != other.LEOBOPDADFI) return false;
      if (KKABCCEIDCB != other.KKABCCEIDCB) return false;
      if (IBIKIBJKDEI != other.IBIKIBJKDEI) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (LEOBOPDADFI.Length != 0) hash ^= LEOBOPDADFI.GetHashCode();
      if (KKABCCEIDCB != 0) hash ^= KKABCCEIDCB.GetHashCode();
      if (IBIKIBJKDEI != 0) hash ^= IBIKIBJKDEI.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Retcode);
      }
      if (IBIKIBJKDEI != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(IBIKIBJKDEI);
      }
      if (KKABCCEIDCB != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(KKABCCEIDCB);
      }
      if (LEOBOPDADFI.Length != 0) {
        output.WriteRawTag(122);
        output.WriteString(LEOBOPDADFI);
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
      if (Retcode != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Retcode);
      }
      if (IBIKIBJKDEI != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(IBIKIBJKDEI);
      }
      if (KKABCCEIDCB != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(KKABCCEIDCB);
      }
      if (LEOBOPDADFI.Length != 0) {
        output.WriteRawTag(122);
        output.WriteString(LEOBOPDADFI);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (LEOBOPDADFI.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LEOBOPDADFI);
      }
      if (KKABCCEIDCB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KKABCCEIDCB);
      }
      if (IBIKIBJKDEI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IBIKIBJKDEI);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TextJoinSaveScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.LEOBOPDADFI.Length != 0) {
        LEOBOPDADFI = other.LEOBOPDADFI;
      }
      if (other.KKABCCEIDCB != 0) {
        KKABCCEIDCB = other.KKABCCEIDCB;
      }
      if (other.IBIKIBJKDEI != 0) {
        IBIKIBJKDEI = other.IBIKIBJKDEI;
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
            Retcode = input.ReadUInt32();
            break;
          }
          case 40: {
            IBIKIBJKDEI = input.ReadUInt32();
            break;
          }
          case 72: {
            KKABCCEIDCB = input.ReadUInt32();
            break;
          }
          case 122: {
            LEOBOPDADFI = input.ReadString();
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
            Retcode = input.ReadUInt32();
            break;
          }
          case 40: {
            IBIKIBJKDEI = input.ReadUInt32();
            break;
          }
          case 72: {
            KKABCCEIDCB = input.ReadUInt32();
            break;
          }
          case 122: {
            LEOBOPDADFI = input.ReadString();
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
