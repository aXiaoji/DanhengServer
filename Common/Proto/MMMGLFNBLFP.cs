// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MMMGLFNBLFP.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MMMGLFNBLFP.proto</summary>
  public static partial class MMMGLFNBLFPReflection {

    #region Descriptor
    /// <summary>File descriptor for MMMGLFNBLFP.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MMMGLFNBLFPReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFNTU1HTEZOQkxGUC5wcm90byJhCgtNTU1HTEZOQkxGUBITCgtEQUxERktI",
            "S0NBRhgBIAEoCBITCgtFR0FKR0lNT0dMSxgCIAMoDRITCgtCUE5DTFBKREdM",
            "SBgDIAEoDRITCgtGSUZJQkxPRENNQRgEIAEoDUIeqgIbRWdnTGluay5EYW5o",
            "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MMMGLFNBLFP), global::EggLink.DanhengServer.Proto.MMMGLFNBLFP.Parser, new[]{ "DALDFKHKCAF", "EGAJGIMOGLK", "BPNCLPJDGLH", "FIFIBLODCMA" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MMMGLFNBLFP : pb::IMessage<MMMGLFNBLFP>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MMMGLFNBLFP> _parser = new pb::MessageParser<MMMGLFNBLFP>(() => new MMMGLFNBLFP());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MMMGLFNBLFP> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MMMGLFNBLFPReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MMMGLFNBLFP() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MMMGLFNBLFP(MMMGLFNBLFP other) : this() {
      dALDFKHKCAF_ = other.dALDFKHKCAF_;
      eGAJGIMOGLK_ = other.eGAJGIMOGLK_.Clone();
      bPNCLPJDGLH_ = other.bPNCLPJDGLH_;
      fIFIBLODCMA_ = other.fIFIBLODCMA_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MMMGLFNBLFP Clone() {
      return new MMMGLFNBLFP(this);
    }

    /// <summary>Field number for the "DALDFKHKCAF" field.</summary>
    public const int DALDFKHKCAFFieldNumber = 1;
    private bool dALDFKHKCAF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool DALDFKHKCAF {
      get { return dALDFKHKCAF_; }
      set {
        dALDFKHKCAF_ = value;
      }
    }

    /// <summary>Field number for the "EGAJGIMOGLK" field.</summary>
    public const int EGAJGIMOGLKFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_eGAJGIMOGLK_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> eGAJGIMOGLK_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> EGAJGIMOGLK {
      get { return eGAJGIMOGLK_; }
    }

    /// <summary>Field number for the "BPNCLPJDGLH" field.</summary>
    public const int BPNCLPJDGLHFieldNumber = 3;
    private uint bPNCLPJDGLH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BPNCLPJDGLH {
      get { return bPNCLPJDGLH_; }
      set {
        bPNCLPJDGLH_ = value;
      }
    }

    /// <summary>Field number for the "FIFIBLODCMA" field.</summary>
    public const int FIFIBLODCMAFieldNumber = 4;
    private uint fIFIBLODCMA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FIFIBLODCMA {
      get { return fIFIBLODCMA_; }
      set {
        fIFIBLODCMA_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MMMGLFNBLFP);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MMMGLFNBLFP other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DALDFKHKCAF != other.DALDFKHKCAF) return false;
      if(!eGAJGIMOGLK_.Equals(other.eGAJGIMOGLK_)) return false;
      if (BPNCLPJDGLH != other.BPNCLPJDGLH) return false;
      if (FIFIBLODCMA != other.FIFIBLODCMA) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DALDFKHKCAF != false) hash ^= DALDFKHKCAF.GetHashCode();
      hash ^= eGAJGIMOGLK_.GetHashCode();
      if (BPNCLPJDGLH != 0) hash ^= BPNCLPJDGLH.GetHashCode();
      if (FIFIBLODCMA != 0) hash ^= FIFIBLODCMA.GetHashCode();
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
      if (DALDFKHKCAF != false) {
        output.WriteRawTag(8);
        output.WriteBool(DALDFKHKCAF);
      }
      eGAJGIMOGLK_.WriteTo(output, _repeated_eGAJGIMOGLK_codec);
      if (BPNCLPJDGLH != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(BPNCLPJDGLH);
      }
      if (FIFIBLODCMA != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(FIFIBLODCMA);
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
      if (DALDFKHKCAF != false) {
        output.WriteRawTag(8);
        output.WriteBool(DALDFKHKCAF);
      }
      eGAJGIMOGLK_.WriteTo(ref output, _repeated_eGAJGIMOGLK_codec);
      if (BPNCLPJDGLH != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(BPNCLPJDGLH);
      }
      if (FIFIBLODCMA != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(FIFIBLODCMA);
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
      if (DALDFKHKCAF != false) {
        size += 1 + 1;
      }
      size += eGAJGIMOGLK_.CalculateSize(_repeated_eGAJGIMOGLK_codec);
      if (BPNCLPJDGLH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BPNCLPJDGLH);
      }
      if (FIFIBLODCMA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FIFIBLODCMA);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MMMGLFNBLFP other) {
      if (other == null) {
        return;
      }
      if (other.DALDFKHKCAF != false) {
        DALDFKHKCAF = other.DALDFKHKCAF;
      }
      eGAJGIMOGLK_.Add(other.eGAJGIMOGLK_);
      if (other.BPNCLPJDGLH != 0) {
        BPNCLPJDGLH = other.BPNCLPJDGLH;
      }
      if (other.FIFIBLODCMA != 0) {
        FIFIBLODCMA = other.FIFIBLODCMA;
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
            DALDFKHKCAF = input.ReadBool();
            break;
          }
          case 18:
          case 16: {
            eGAJGIMOGLK_.AddEntriesFrom(input, _repeated_eGAJGIMOGLK_codec);
            break;
          }
          case 24: {
            BPNCLPJDGLH = input.ReadUInt32();
            break;
          }
          case 32: {
            FIFIBLODCMA = input.ReadUInt32();
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
            DALDFKHKCAF = input.ReadBool();
            break;
          }
          case 18:
          case 16: {
            eGAJGIMOGLK_.AddEntriesFrom(ref input, _repeated_eGAJGIMOGLK_codec);
            break;
          }
          case 24: {
            BPNCLPJDGLH = input.ReadUInt32();
            break;
          }
          case 32: {
            FIFIBLODCMA = input.ReadUInt32();
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