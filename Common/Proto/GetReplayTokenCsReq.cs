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
            "Ip0BChNHZXRSZXBsYXlUb2tlbkNzUmVxEhMKC09KSUtLS0dOR0xGGAUgASgJ",
            "EiAKC3JlcGxheV90eXBlGAcgASgOMgsuUmVwbGF5VHlwZRIQCghzdGFnZV9p",
            "ZBgDIAEoDRITCgtFSkVPTEZDT0ZBSBgNIAEoDRITCgtFQ0VORE5KQ0dGTRgG",
            "IAEoCRITCgtOQkdIRktNRElBQRgLIAEoDUIeqgIbRWdnTGluay5EYW5oZW5n",
            "U2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ReplayTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetReplayTokenCsReq), global::EggLink.DanhengServer.Proto.GetReplayTokenCsReq.Parser, new[]{ "OJIKKKGNGLF", "ReplayType", "StageId", "EJEOLFCOFAH", "ECENDNJCGFM", "NBGHFKMDIAA" }, null, null, null, null)
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
      oJIKKKGNGLF_ = other.oJIKKKGNGLF_;
      replayType_ = other.replayType_;
      stageId_ = other.stageId_;
      eJEOLFCOFAH_ = other.eJEOLFCOFAH_;
      eCENDNJCGFM_ = other.eCENDNJCGFM_;
      nBGHFKMDIAA_ = other.nBGHFKMDIAA_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetReplayTokenCsReq Clone() {
      return new GetReplayTokenCsReq(this);
    }

    /// <summary>Field number for the "OJIKKKGNGLF" field.</summary>
    public const int OJIKKKGNGLFFieldNumber = 5;
    private string oJIKKKGNGLF_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string OJIKKKGNGLF {
      get { return oJIKKKGNGLF_; }
      set {
        oJIKKKGNGLF_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
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

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 3;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    /// <summary>Field number for the "EJEOLFCOFAH" field.</summary>
    public const int EJEOLFCOFAHFieldNumber = 13;
    private uint eJEOLFCOFAH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EJEOLFCOFAH {
      get { return eJEOLFCOFAH_; }
      set {
        eJEOLFCOFAH_ = value;
      }
    }

    /// <summary>Field number for the "ECENDNJCGFM" field.</summary>
    public const int ECENDNJCGFMFieldNumber = 6;
    private string eCENDNJCGFM_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ECENDNJCGFM {
      get { return eCENDNJCGFM_; }
      set {
        eCENDNJCGFM_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "NBGHFKMDIAA" field.</summary>
    public const int NBGHFKMDIAAFieldNumber = 11;
    private uint nBGHFKMDIAA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NBGHFKMDIAA {
      get { return nBGHFKMDIAA_; }
      set {
        nBGHFKMDIAA_ = value;
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
      if (OJIKKKGNGLF != other.OJIKKKGNGLF) return false;
      if (ReplayType != other.ReplayType) return false;
      if (StageId != other.StageId) return false;
      if (EJEOLFCOFAH != other.EJEOLFCOFAH) return false;
      if (ECENDNJCGFM != other.ECENDNJCGFM) return false;
      if (NBGHFKMDIAA != other.NBGHFKMDIAA) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (OJIKKKGNGLF.Length != 0) hash ^= OJIKKKGNGLF.GetHashCode();
      if (ReplayType != global::EggLink.DanhengServer.Proto.ReplayType.None) hash ^= ReplayType.GetHashCode();
      if (StageId != 0) hash ^= StageId.GetHashCode();
      if (EJEOLFCOFAH != 0) hash ^= EJEOLFCOFAH.GetHashCode();
      if (ECENDNJCGFM.Length != 0) hash ^= ECENDNJCGFM.GetHashCode();
      if (NBGHFKMDIAA != 0) hash ^= NBGHFKMDIAA.GetHashCode();
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
      if (StageId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(StageId);
      }
      if (OJIKKKGNGLF.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(OJIKKKGNGLF);
      }
      if (ECENDNJCGFM.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(ECENDNJCGFM);
      }
      if (ReplayType != global::EggLink.DanhengServer.Proto.ReplayType.None) {
        output.WriteRawTag(56);
        output.WriteEnum((int) ReplayType);
      }
      if (NBGHFKMDIAA != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(NBGHFKMDIAA);
      }
      if (EJEOLFCOFAH != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(EJEOLFCOFAH);
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
      if (StageId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(StageId);
      }
      if (OJIKKKGNGLF.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(OJIKKKGNGLF);
      }
      if (ECENDNJCGFM.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(ECENDNJCGFM);
      }
      if (ReplayType != global::EggLink.DanhengServer.Proto.ReplayType.None) {
        output.WriteRawTag(56);
        output.WriteEnum((int) ReplayType);
      }
      if (NBGHFKMDIAA != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(NBGHFKMDIAA);
      }
      if (EJEOLFCOFAH != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(EJEOLFCOFAH);
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
      if (OJIKKKGNGLF.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OJIKKKGNGLF);
      }
      if (ReplayType != global::EggLink.DanhengServer.Proto.ReplayType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ReplayType);
      }
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      if (EJEOLFCOFAH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EJEOLFCOFAH);
      }
      if (ECENDNJCGFM.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ECENDNJCGFM);
      }
      if (NBGHFKMDIAA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NBGHFKMDIAA);
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
      if (other.OJIKKKGNGLF.Length != 0) {
        OJIKKKGNGLF = other.OJIKKKGNGLF;
      }
      if (other.ReplayType != global::EggLink.DanhengServer.Proto.ReplayType.None) {
        ReplayType = other.ReplayType;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
      }
      if (other.EJEOLFCOFAH != 0) {
        EJEOLFCOFAH = other.EJEOLFCOFAH;
      }
      if (other.ECENDNJCGFM.Length != 0) {
        ECENDNJCGFM = other.ECENDNJCGFM;
      }
      if (other.NBGHFKMDIAA != 0) {
        NBGHFKMDIAA = other.NBGHFKMDIAA;
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
          case 24: {
            StageId = input.ReadUInt32();
            break;
          }
          case 42: {
            OJIKKKGNGLF = input.ReadString();
            break;
          }
          case 50: {
            ECENDNJCGFM = input.ReadString();
            break;
          }
          case 56: {
            ReplayType = (global::EggLink.DanhengServer.Proto.ReplayType) input.ReadEnum();
            break;
          }
          case 88: {
            NBGHFKMDIAA = input.ReadUInt32();
            break;
          }
          case 104: {
            EJEOLFCOFAH = input.ReadUInt32();
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
          case 24: {
            StageId = input.ReadUInt32();
            break;
          }
          case 42: {
            OJIKKKGNGLF = input.ReadString();
            break;
          }
          case 50: {
            ECENDNJCGFM = input.ReadString();
            break;
          }
          case 56: {
            ReplayType = (global::EggLink.DanhengServer.Proto.ReplayType) input.ReadEnum();
            break;
          }
          case 88: {
            NBGHFKMDIAA = input.ReadUInt32();
            break;
          }
          case 104: {
            EJEOLFCOFAH = input.ReadUInt32();
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
