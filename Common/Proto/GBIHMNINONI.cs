// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GBIHMNINONI.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GBIHMNINONI.proto</summary>
  public static partial class GBIHMNINONIReflection {

    #region Descriptor
    /// <summary>File descriptor for GBIHMNINONI.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GBIHMNINONIReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFHQklITU5JTk9OSS5wcm90byI3CgtHQklITU5JTk9OSRITCgtMRkVQREJK",
            "SE1GThgIIAEoDRITCgtPS0dPRkRETkpGRRgJIAEoDUIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GBIHMNINONI), global::EggLink.DanhengServer.Proto.GBIHMNINONI.Parser, new[]{ "LFEPDBJHMFN", "OKGOFDDNJFE" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GBIHMNINONI : pb::IMessage<GBIHMNINONI>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GBIHMNINONI> _parser = new pb::MessageParser<GBIHMNINONI>(() => new GBIHMNINONI());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GBIHMNINONI> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GBIHMNINONIReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GBIHMNINONI() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GBIHMNINONI(GBIHMNINONI other) : this() {
      lFEPDBJHMFN_ = other.lFEPDBJHMFN_;
      oKGOFDDNJFE_ = other.oKGOFDDNJFE_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GBIHMNINONI Clone() {
      return new GBIHMNINONI(this);
    }

    /// <summary>Field number for the "LFEPDBJHMFN" field.</summary>
    public const int LFEPDBJHMFNFieldNumber = 8;
    private uint lFEPDBJHMFN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LFEPDBJHMFN {
      get { return lFEPDBJHMFN_; }
      set {
        lFEPDBJHMFN_ = value;
      }
    }

    /// <summary>Field number for the "OKGOFDDNJFE" field.</summary>
    public const int OKGOFDDNJFEFieldNumber = 9;
    private uint oKGOFDDNJFE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OKGOFDDNJFE {
      get { return oKGOFDDNJFE_; }
      set {
        oKGOFDDNJFE_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GBIHMNINONI);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GBIHMNINONI other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LFEPDBJHMFN != other.LFEPDBJHMFN) return false;
      if (OKGOFDDNJFE != other.OKGOFDDNJFE) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (LFEPDBJHMFN != 0) hash ^= LFEPDBJHMFN.GetHashCode();
      if (OKGOFDDNJFE != 0) hash ^= OKGOFDDNJFE.GetHashCode();
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
      if (LFEPDBJHMFN != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(LFEPDBJHMFN);
      }
      if (OKGOFDDNJFE != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(OKGOFDDNJFE);
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
      if (LFEPDBJHMFN != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(LFEPDBJHMFN);
      }
      if (OKGOFDDNJFE != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(OKGOFDDNJFE);
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
      if (LFEPDBJHMFN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LFEPDBJHMFN);
      }
      if (OKGOFDDNJFE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OKGOFDDNJFE);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GBIHMNINONI other) {
      if (other == null) {
        return;
      }
      if (other.LFEPDBJHMFN != 0) {
        LFEPDBJHMFN = other.LFEPDBJHMFN;
      }
      if (other.OKGOFDDNJFE != 0) {
        OKGOFDDNJFE = other.OKGOFDDNJFE;
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
          case 64: {
            LFEPDBJHMFN = input.ReadUInt32();
            break;
          }
          case 72: {
            OKGOFDDNJFE = input.ReadUInt32();
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
          case 64: {
            LFEPDBJHMFN = input.ReadUInt32();
            break;
          }
          case 72: {
            OKGOFDDNJFE = input.ReadUInt32();
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