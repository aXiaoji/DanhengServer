// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetChessRogueNousStoryInfoScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetChessRogueNousStoryInfoScRsp.proto</summary>
  public static partial class GetChessRogueNousStoryInfoScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetChessRogueNousStoryInfoScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetChessRogueNousStoryInfoScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVHZXRDaGVzc1JvZ3VlTm91c1N0b3J5SW5mb1NjUnNwLnByb3RvGhFDTUhF",
            "S0JJQkhLSi5wcm90bxoRS0VMS0JDQkVKTUEucHJvdG8ieAofR2V0Q2hlc3NS",
            "b2d1ZU5vdXNTdG9yeUluZm9TY1JzcBIhCgtHR0hDT0hIT0pKSBgGIAMoCzIM",
            "LkNNSEVLQklCSEtKEiEKC0xHUEJQQ0NGQkdMGAwgAygLMgwuS0VMS0JDQkVK",
            "TUESDwoHcmV0Y29kZRgFIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
            "LlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.CMHEKBIBHKJReflection.Descriptor, global::EggLink.DanhengServer.Proto.KELKBCBEJMAReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetChessRogueNousStoryInfoScRsp), global::EggLink.DanhengServer.Proto.GetChessRogueNousStoryInfoScRsp.Parser, new[]{ "GGHCOHHOJJH", "LGPBPCCFBGL", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetChessRogueNousStoryInfoScRsp : pb::IMessage<GetChessRogueNousStoryInfoScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetChessRogueNousStoryInfoScRsp> _parser = new pb::MessageParser<GetChessRogueNousStoryInfoScRsp>(() => new GetChessRogueNousStoryInfoScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetChessRogueNousStoryInfoScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetChessRogueNousStoryInfoScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetChessRogueNousStoryInfoScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetChessRogueNousStoryInfoScRsp(GetChessRogueNousStoryInfoScRsp other) : this() {
      gGHCOHHOJJH_ = other.gGHCOHHOJJH_.Clone();
      lGPBPCCFBGL_ = other.lGPBPCCFBGL_.Clone();
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetChessRogueNousStoryInfoScRsp Clone() {
      return new GetChessRogueNousStoryInfoScRsp(this);
    }

    /// <summary>Field number for the "GGHCOHHOJJH" field.</summary>
    public const int GGHCOHHOJJHFieldNumber = 6;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.CMHEKBIBHKJ> _repeated_gGHCOHHOJJH_codec
        = pb::FieldCodec.ForMessage(50, global::EggLink.DanhengServer.Proto.CMHEKBIBHKJ.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CMHEKBIBHKJ> gGHCOHHOJJH_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CMHEKBIBHKJ>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CMHEKBIBHKJ> GGHCOHHOJJH {
      get { return gGHCOHHOJJH_; }
    }

    /// <summary>Field number for the "LGPBPCCFBGL" field.</summary>
    public const int LGPBPCCFBGLFieldNumber = 12;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.KELKBCBEJMA> _repeated_lGPBPCCFBGL_codec
        = pb::FieldCodec.ForMessage(98, global::EggLink.DanhengServer.Proto.KELKBCBEJMA.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.KELKBCBEJMA> lGPBPCCFBGL_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.KELKBCBEJMA>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.KELKBCBEJMA> LGPBPCCFBGL {
      get { return lGPBPCCFBGL_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 5;
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
      return Equals(other as GetChessRogueNousStoryInfoScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetChessRogueNousStoryInfoScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!gGHCOHHOJJH_.Equals(other.gGHCOHHOJJH_)) return false;
      if(!lGPBPCCFBGL_.Equals(other.lGPBPCCFBGL_)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= gGHCOHHOJJH_.GetHashCode();
      hash ^= lGPBPCCFBGL_.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Retcode);
      }
      gGHCOHHOJJH_.WriteTo(output, _repeated_gGHCOHHOJJH_codec);
      lGPBPCCFBGL_.WriteTo(output, _repeated_lGPBPCCFBGL_codec);
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
        output.WriteRawTag(40);
        output.WriteUInt32(Retcode);
      }
      gGHCOHHOJJH_.WriteTo(ref output, _repeated_gGHCOHHOJJH_codec);
      lGPBPCCFBGL_.WriteTo(ref output, _repeated_lGPBPCCFBGL_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += gGHCOHHOJJH_.CalculateSize(_repeated_gGHCOHHOJJH_codec);
      size += lGPBPCCFBGL_.CalculateSize(_repeated_lGPBPCCFBGL_codec);
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
    public void MergeFrom(GetChessRogueNousStoryInfoScRsp other) {
      if (other == null) {
        return;
      }
      gGHCOHHOJJH_.Add(other.gGHCOHHOJJH_);
      lGPBPCCFBGL_.Add(other.lGPBPCCFBGL_);
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
          case 40: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 50: {
            gGHCOHHOJJH_.AddEntriesFrom(input, _repeated_gGHCOHHOJJH_codec);
            break;
          }
          case 98: {
            lGPBPCCFBGL_.AddEntriesFrom(input, _repeated_lGPBPCCFBGL_codec);
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
            Retcode = input.ReadUInt32();
            break;
          }
          case 50: {
            gGHCOHHOJJH_.AddEntriesFrom(ref input, _repeated_gGHCOHHOJJH_codec);
            break;
          }
          case 98: {
            lGPBPCCFBGL_.AddEntriesFrom(ref input, _repeated_lGPBPCCFBGL_codec);
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
