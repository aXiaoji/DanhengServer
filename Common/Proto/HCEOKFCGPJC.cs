// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HCEOKFCGPJC.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from HCEOKFCGPJC.proto</summary>
  public static partial class HCEOKFCGPJCReflection {

    #region Descriptor
    /// <summary>File descriptor for HCEOKFCGPJC.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HCEOKFCGPJCReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFIQ0VPS0ZDR1BKQy5wcm90byJMCgtIQ0VPS0ZDR1BKQxITCgtKSURBR0VC",
            "T05GThgDIAMoDRITCgtMUEZNSkxCSURLUBgIIAEoDRITCgtQREFCUENCR0hP",
            "ThgLIAEoCEIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.HCEOKFCGPJC), global::EggLink.DanhengServer.Proto.HCEOKFCGPJC.Parser, new[]{ "JIDAGEBONFN", "LPFMJLBIDKP", "PDABPCBGHON" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class HCEOKFCGPJC : pb::IMessage<HCEOKFCGPJC>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HCEOKFCGPJC> _parser = new pb::MessageParser<HCEOKFCGPJC>(() => new HCEOKFCGPJC());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HCEOKFCGPJC> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.HCEOKFCGPJCReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HCEOKFCGPJC() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HCEOKFCGPJC(HCEOKFCGPJC other) : this() {
      jIDAGEBONFN_ = other.jIDAGEBONFN_.Clone();
      lPFMJLBIDKP_ = other.lPFMJLBIDKP_;
      pDABPCBGHON_ = other.pDABPCBGHON_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HCEOKFCGPJC Clone() {
      return new HCEOKFCGPJC(this);
    }

    /// <summary>Field number for the "JIDAGEBONFN" field.</summary>
    public const int JIDAGEBONFNFieldNumber = 3;
    private static readonly pb::FieldCodec<uint> _repeated_jIDAGEBONFN_codec
        = pb::FieldCodec.ForUInt32(26);
    private readonly pbc::RepeatedField<uint> jIDAGEBONFN_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> JIDAGEBONFN {
      get { return jIDAGEBONFN_; }
    }

    /// <summary>Field number for the "LPFMJLBIDKP" field.</summary>
    public const int LPFMJLBIDKPFieldNumber = 8;
    private uint lPFMJLBIDKP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LPFMJLBIDKP {
      get { return lPFMJLBIDKP_; }
      set {
        lPFMJLBIDKP_ = value;
      }
    }

    /// <summary>Field number for the "PDABPCBGHON" field.</summary>
    public const int PDABPCBGHONFieldNumber = 11;
    private bool pDABPCBGHON_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool PDABPCBGHON {
      get { return pDABPCBGHON_; }
      set {
        pDABPCBGHON_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HCEOKFCGPJC);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HCEOKFCGPJC other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!jIDAGEBONFN_.Equals(other.jIDAGEBONFN_)) return false;
      if (LPFMJLBIDKP != other.LPFMJLBIDKP) return false;
      if (PDABPCBGHON != other.PDABPCBGHON) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= jIDAGEBONFN_.GetHashCode();
      if (LPFMJLBIDKP != 0) hash ^= LPFMJLBIDKP.GetHashCode();
      if (PDABPCBGHON != false) hash ^= PDABPCBGHON.GetHashCode();
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
      jIDAGEBONFN_.WriteTo(output, _repeated_jIDAGEBONFN_codec);
      if (LPFMJLBIDKP != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(LPFMJLBIDKP);
      }
      if (PDABPCBGHON != false) {
        output.WriteRawTag(88);
        output.WriteBool(PDABPCBGHON);
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
      jIDAGEBONFN_.WriteTo(ref output, _repeated_jIDAGEBONFN_codec);
      if (LPFMJLBIDKP != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(LPFMJLBIDKP);
      }
      if (PDABPCBGHON != false) {
        output.WriteRawTag(88);
        output.WriteBool(PDABPCBGHON);
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
      size += jIDAGEBONFN_.CalculateSize(_repeated_jIDAGEBONFN_codec);
      if (LPFMJLBIDKP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LPFMJLBIDKP);
      }
      if (PDABPCBGHON != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HCEOKFCGPJC other) {
      if (other == null) {
        return;
      }
      jIDAGEBONFN_.Add(other.jIDAGEBONFN_);
      if (other.LPFMJLBIDKP != 0) {
        LPFMJLBIDKP = other.LPFMJLBIDKP;
      }
      if (other.PDABPCBGHON != false) {
        PDABPCBGHON = other.PDABPCBGHON;
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
            jIDAGEBONFN_.AddEntriesFrom(input, _repeated_jIDAGEBONFN_codec);
            break;
          }
          case 64: {
            LPFMJLBIDKP = input.ReadUInt32();
            break;
          }
          case 88: {
            PDABPCBGHON = input.ReadBool();
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
            jIDAGEBONFN_.AddEntriesFrom(ref input, _repeated_jIDAGEBONFN_codec);
            break;
          }
          case 64: {
            LPFMJLBIDKP = input.ReadUInt32();
            break;
          }
          case 88: {
            PDABPCBGHON = input.ReadBool();
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