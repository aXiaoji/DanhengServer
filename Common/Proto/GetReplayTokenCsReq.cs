// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetReplayTokenCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetReplayTokenCsReq.proto</summary>
  public static partial class GetReplayTokenCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for GetReplayTokenCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetReplayTokenCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlHZXRSZXBsYXlUb2tlbkNzUmVxLnByb3RvGhBSZXBsYXlUeXBlLnByb3Rv",
            "Ip0BChNHZXRSZXBsYXlUb2tlbkNzUmVxEiAKC3JlcGxheV90eXBlGAcgASgO",
            "MgsuUmVwbGF5VHlwZRITCgtISlBKUE1KS0dIThgEIAEoCRITCgtLQU9JRklG",
            "QklKRxgBIAEoDRITCgtDQ0dLRlBES0ZOQhgLIAEoCRIQCghzdGFnZV9pZBgN",
            "IAEoDRITCgtLQUtHR05ISk9LThgKIAEoDUIeqgIbRWdnTGluay5EYW5oZW5n",
            "U2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ReplayTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetReplayTokenCsReq), global::EggLink.DanhengServer.Proto.GetReplayTokenCsReq.Parser, new[]{ "ReplayType", "HJPJPMJKGHN", "KAOIFIFBIJG", "CCGKFPDKFNB", "StageId", "KAKGGNHJOKN" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetReplayTokenCsReq : pb::IMessage<GetReplayTokenCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetReplayTokenCsReq> _parser = new pb::MessageParser<GetReplayTokenCsReq>(() => new GetReplayTokenCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetReplayTokenCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetReplayTokenCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetReplayTokenCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetReplayTokenCsReq(GetReplayTokenCsReq other) : this() {
      replayType_ = other.replayType_;
      hJPJPMJKGHN_ = other.hJPJPMJKGHN_;
      kAOIFIFBIJG_ = other.kAOIFIFBIJG_;
      cCGKFPDKFNB_ = other.cCGKFPDKFNB_;
      stageId_ = other.stageId_;
      kAKGGNHJOKN_ = other.kAKGGNHJOKN_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetReplayTokenCsReq Clone() {
      return new GetReplayTokenCsReq(this);
    }

    /// <summary>Field number for the "replay_type" field.</summary>
    public const int ReplayTypeFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.ReplayType replayType_ = global::EggLink.DanhengServer.Proto.ReplayType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ReplayType ReplayType {
      get { return replayType_; }
      set {
        replayType_ = value;
      }
    }

    /// <summary>Field number for the "HJPJPMJKGHN" field.</summary>
    public const int HJPJPMJKGHNFieldNumber = 4;
    private string hJPJPMJKGHN_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string HJPJPMJKGHN {
      get { return hJPJPMJKGHN_; }
      set {
        hJPJPMJKGHN_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "KAOIFIFBIJG" field.</summary>
    public const int KAOIFIFBIJGFieldNumber = 1;
    private uint kAOIFIFBIJG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KAOIFIFBIJG {
      get { return kAOIFIFBIJG_; }
      set {
        kAOIFIFBIJG_ = value;
      }
    }

    /// <summary>Field number for the "CCGKFPDKFNB" field.</summary>
    public const int CCGKFPDKFNBFieldNumber = 11;
    private string cCGKFPDKFNB_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CCGKFPDKFNB {
      get { return cCGKFPDKFNB_; }
      set {
        cCGKFPDKFNB_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 13;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    /// <summary>Field number for the "KAKGGNHJOKN" field.</summary>
    public const int KAKGGNHJOKNFieldNumber = 10;
    private uint kAKGGNHJOKN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KAKGGNHJOKN {
      get { return kAKGGNHJOKN_; }
      set {
        kAKGGNHJOKN_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetReplayTokenCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetReplayTokenCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ReplayType != other.ReplayType) return false;
      if (HJPJPMJKGHN != other.HJPJPMJKGHN) return false;
      if (KAOIFIFBIJG != other.KAOIFIFBIJG) return false;
      if (CCGKFPDKFNB != other.CCGKFPDKFNB) return false;
      if (StageId != other.StageId) return false;
      if (KAKGGNHJOKN != other.KAKGGNHJOKN) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ReplayType != global::EggLink.DanhengServer.Proto.ReplayType.None) hash ^= ReplayType.GetHashCode();
      if (HJPJPMJKGHN.Length != 0) hash ^= HJPJPMJKGHN.GetHashCode();
      if (KAOIFIFBIJG != 0) hash ^= KAOIFIFBIJG.GetHashCode();
      if (CCGKFPDKFNB.Length != 0) hash ^= CCGKFPDKFNB.GetHashCode();
      if (StageId != 0) hash ^= StageId.GetHashCode();
      if (KAKGGNHJOKN != 0) hash ^= KAKGGNHJOKN.GetHashCode();
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
      if (KAOIFIFBIJG != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(KAOIFIFBIJG);
      }
      if (HJPJPMJKGHN.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(HJPJPMJKGHN);
      }
      if (ReplayType != global::EggLink.DanhengServer.Proto.ReplayType.None) {
        output.WriteRawTag(56);
        output.WriteEnum((int) ReplayType);
      }
      if (KAKGGNHJOKN != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(KAKGGNHJOKN);
      }
      if (CCGKFPDKFNB.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(CCGKFPDKFNB);
      }
      if (StageId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(StageId);
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
      if (KAOIFIFBIJG != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(KAOIFIFBIJG);
      }
      if (HJPJPMJKGHN.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(HJPJPMJKGHN);
      }
      if (ReplayType != global::EggLink.DanhengServer.Proto.ReplayType.None) {
        output.WriteRawTag(56);
        output.WriteEnum((int) ReplayType);
      }
      if (KAKGGNHJOKN != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(KAKGGNHJOKN);
      }
      if (CCGKFPDKFNB.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(CCGKFPDKFNB);
      }
      if (StageId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(StageId);
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
      if (ReplayType != global::EggLink.DanhengServer.Proto.ReplayType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ReplayType);
      }
      if (HJPJPMJKGHN.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(HJPJPMJKGHN);
      }
      if (KAOIFIFBIJG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KAOIFIFBIJG);
      }
      if (CCGKFPDKFNB.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CCGKFPDKFNB);
      }
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      if (KAKGGNHJOKN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KAKGGNHJOKN);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetReplayTokenCsReq other) {
      if (other == null) {
        return;
      }
      if (other.ReplayType != global::EggLink.DanhengServer.Proto.ReplayType.None) {
        ReplayType = other.ReplayType;
      }
      if (other.HJPJPMJKGHN.Length != 0) {
        HJPJPMJKGHN = other.HJPJPMJKGHN;
      }
      if (other.KAOIFIFBIJG != 0) {
        KAOIFIFBIJG = other.KAOIFIFBIJG;
      }
      if (other.CCGKFPDKFNB.Length != 0) {
        CCGKFPDKFNB = other.CCGKFPDKFNB;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
      }
      if (other.KAKGGNHJOKN != 0) {
        KAKGGNHJOKN = other.KAKGGNHJOKN;
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
            KAOIFIFBIJG = input.ReadUInt32();
            break;
          }
          case 34: {
            HJPJPMJKGHN = input.ReadString();
            break;
          }
          case 56: {
            ReplayType = (global::EggLink.DanhengServer.Proto.ReplayType) input.ReadEnum();
            break;
          }
          case 80: {
            KAKGGNHJOKN = input.ReadUInt32();
            break;
          }
          case 90: {
            CCGKFPDKFNB = input.ReadString();
            break;
          }
          case 104: {
            StageId = input.ReadUInt32();
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
            KAOIFIFBIJG = input.ReadUInt32();
            break;
          }
          case 34: {
            HJPJPMJKGHN = input.ReadString();
            break;
          }
          case 56: {
            ReplayType = (global::EggLink.DanhengServer.Proto.ReplayType) input.ReadEnum();
            break;
          }
          case 80: {
            KAKGGNHJOKN = input.ReadUInt32();
            break;
          }
          case 90: {
            CCGKFPDKFNB = input.ReadString();
            break;
          }
          case 104: {
            StageId = input.ReadUInt32();
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
