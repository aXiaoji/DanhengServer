// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetChallengeScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetChallengeScRsp.proto</summary>
  public static partial class GetChallengeScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetChallengeScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetChallengeScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdHZXRDaGFsbGVuZ2VTY1JzcC5wcm90bxoPQ2hhbGxlbmdlLnByb3RvGhRD",
            "aGFsbGVuZ2VHcm91cC5wcm90bxoRR0VNRFBNR0hIT0YucHJvdG8irwEKEUdl",
            "dENoYWxsZW5nZVNjUnNwEhMKC0dKRkJKRURJSUtIGAYgASgNEiIKDmNoYWxs",
            "ZW5nZV9saXN0GA0gAygLMgouQ2hhbGxlbmdlEiEKC0pORE9FT09FQ09MGAMg",
            "AygLMgwuR0VNRFBNR0hIT0YSDwoHcmV0Y29kZRgFIAEoDRItChRjaGFsbGVu",
            "Z2VfZ3JvdXBfbGlzdBgBIAMoCzIPLkNoYWxsZW5nZUdyb3VwQh6qAhtFZ2dM",
            "aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChallengeReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChallengeGroupReflection.Descriptor, global::EggLink.DanhengServer.Proto.GEMDPMGHHOFReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetChallengeScRsp), global::EggLink.DanhengServer.Proto.GetChallengeScRsp.Parser, new[]{ "GJFBJEDIIKH", "ChallengeList", "JNDOEOOECOL", "Retcode", "ChallengeGroupList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetChallengeScRsp : pb::IMessage<GetChallengeScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetChallengeScRsp> _parser = new pb::MessageParser<GetChallengeScRsp>(() => new GetChallengeScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetChallengeScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetChallengeScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetChallengeScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetChallengeScRsp(GetChallengeScRsp other) : this() {
      gJFBJEDIIKH_ = other.gJFBJEDIIKH_;
      challengeList_ = other.challengeList_.Clone();
      jNDOEOOECOL_ = other.jNDOEOOECOL_.Clone();
      retcode_ = other.retcode_;
      challengeGroupList_ = other.challengeGroupList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetChallengeScRsp Clone() {
      return new GetChallengeScRsp(this);
    }

    /// <summary>Field number for the "GJFBJEDIIKH" field.</summary>
    public const int GJFBJEDIIKHFieldNumber = 6;
    private uint gJFBJEDIIKH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GJFBJEDIIKH {
      get { return gJFBJEDIIKH_; }
      set {
        gJFBJEDIIKH_ = value;
      }
    }

    /// <summary>Field number for the "challenge_list" field.</summary>
    public const int ChallengeListFieldNumber = 13;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.Challenge> _repeated_challengeList_codec
        = pb::FieldCodec.ForMessage(106, global::EggLink.DanhengServer.Proto.Challenge.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Challenge> challengeList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Challenge>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Challenge> ChallengeList {
      get { return challengeList_; }
    }

    /// <summary>Field number for the "JNDOEOOECOL" field.</summary>
    public const int JNDOEOOECOLFieldNumber = 3;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.GEMDPMGHHOF> _repeated_jNDOEOOECOL_codec
        = pb::FieldCodec.ForMessage(26, global::EggLink.DanhengServer.Proto.GEMDPMGHHOF.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.GEMDPMGHHOF> jNDOEOOECOL_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.GEMDPMGHHOF>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.GEMDPMGHHOF> JNDOEOOECOL {
      get { return jNDOEOOECOL_; }
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

    /// <summary>Field number for the "challenge_group_list" field.</summary>
    public const int ChallengeGroupListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ChallengeGroup> _repeated_challengeGroupList_codec
        = pb::FieldCodec.ForMessage(10, global::EggLink.DanhengServer.Proto.ChallengeGroup.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChallengeGroup> challengeGroupList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChallengeGroup>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChallengeGroup> ChallengeGroupList {
      get { return challengeGroupList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetChallengeScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetChallengeScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GJFBJEDIIKH != other.GJFBJEDIIKH) return false;
      if(!challengeList_.Equals(other.challengeList_)) return false;
      if(!jNDOEOOECOL_.Equals(other.jNDOEOOECOL_)) return false;
      if (Retcode != other.Retcode) return false;
      if(!challengeGroupList_.Equals(other.challengeGroupList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GJFBJEDIIKH != 0) hash ^= GJFBJEDIIKH.GetHashCode();
      hash ^= challengeList_.GetHashCode();
      hash ^= jNDOEOOECOL_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= challengeGroupList_.GetHashCode();
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
      challengeGroupList_.WriteTo(output, _repeated_challengeGroupList_codec);
      jNDOEOOECOL_.WriteTo(output, _repeated_jNDOEOOECOL_codec);
      if (Retcode != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Retcode);
      }
      if (GJFBJEDIIKH != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(GJFBJEDIIKH);
      }
      challengeList_.WriteTo(output, _repeated_challengeList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      challengeGroupList_.WriteTo(ref output, _repeated_challengeGroupList_codec);
      jNDOEOOECOL_.WriteTo(ref output, _repeated_jNDOEOOECOL_codec);
      if (Retcode != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Retcode);
      }
      if (GJFBJEDIIKH != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(GJFBJEDIIKH);
      }
      challengeList_.WriteTo(ref output, _repeated_challengeList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (GJFBJEDIIKH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GJFBJEDIIKH);
      }
      size += challengeList_.CalculateSize(_repeated_challengeList_codec);
      size += jNDOEOOECOL_.CalculateSize(_repeated_jNDOEOOECOL_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      size += challengeGroupList_.CalculateSize(_repeated_challengeGroupList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetChallengeScRsp other) {
      if (other == null) {
        return;
      }
      if (other.GJFBJEDIIKH != 0) {
        GJFBJEDIIKH = other.GJFBJEDIIKH;
      }
      challengeList_.Add(other.challengeList_);
      jNDOEOOECOL_.Add(other.jNDOEOOECOL_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      challengeGroupList_.Add(other.challengeGroupList_);
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
          case 10: {
            challengeGroupList_.AddEntriesFrom(input, _repeated_challengeGroupList_codec);
            break;
          }
          case 26: {
            jNDOEOOECOL_.AddEntriesFrom(input, _repeated_jNDOEOOECOL_codec);
            break;
          }
          case 40: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 48: {
            GJFBJEDIIKH = input.ReadUInt32();
            break;
          }
          case 106: {
            challengeList_.AddEntriesFrom(input, _repeated_challengeList_codec);
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
          case 10: {
            challengeGroupList_.AddEntriesFrom(ref input, _repeated_challengeGroupList_codec);
            break;
          }
          case 26: {
            jNDOEOOECOL_.AddEntriesFrom(ref input, _repeated_jNDOEOOECOL_codec);
            break;
          }
          case 40: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 48: {
            GJFBJEDIIKH = input.ReadUInt32();
            break;
          }
          case 106: {
            challengeList_.AddEntriesFrom(ref input, _repeated_challengeList_codec);
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
