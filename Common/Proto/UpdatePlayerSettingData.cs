// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: UpdatePlayerSettingData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from UpdatePlayerSettingData.proto</summary>
  public static partial class UpdatePlayerSettingDataReflection {

    #region Descriptor
    /// <summary>File descriptor for UpdatePlayerSettingData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UpdatePlayerSettingDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1VcGRhdGVQbGF5ZXJTZXR0aW5nRGF0YS5wcm90byJYChdVcGRhdGVQbGF5",
            "ZXJTZXR0aW5nRGF0YRITCgtQTUJCRUlFSEJNTBgDIAEoCBITCgtOT0RITEtD",
            "RkxQQRgJIAEoCBITCgtITUFNR0ZKQU5HTxgKIAEoCEIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.UpdatePlayerSettingData), global::EggLink.DanhengServer.Proto.UpdatePlayerSettingData.Parser, new[]{ "PMBBEIEHBML", "NODHLKCFLPA", "HMAMGFJANGO" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class UpdatePlayerSettingData : pb::IMessage<UpdatePlayerSettingData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UpdatePlayerSettingData> _parser = new pb::MessageParser<UpdatePlayerSettingData>(() => new UpdatePlayerSettingData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UpdatePlayerSettingData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.UpdatePlayerSettingDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpdatePlayerSettingData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpdatePlayerSettingData(UpdatePlayerSettingData other) : this() {
      pMBBEIEHBML_ = other.pMBBEIEHBML_;
      nODHLKCFLPA_ = other.nODHLKCFLPA_;
      hMAMGFJANGO_ = other.hMAMGFJANGO_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpdatePlayerSettingData Clone() {
      return new UpdatePlayerSettingData(this);
    }

    /// <summary>Field number for the "PMBBEIEHBML" field.</summary>
    public const int PMBBEIEHBMLFieldNumber = 3;
    private bool pMBBEIEHBML_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool PMBBEIEHBML {
      get { return pMBBEIEHBML_; }
      set {
        pMBBEIEHBML_ = value;
      }
    }

    /// <summary>Field number for the "NODHLKCFLPA" field.</summary>
    public const int NODHLKCFLPAFieldNumber = 9;
    private bool nODHLKCFLPA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool NODHLKCFLPA {
      get { return nODHLKCFLPA_; }
      set {
        nODHLKCFLPA_ = value;
      }
    }

    /// <summary>Field number for the "HMAMGFJANGO" field.</summary>
    public const int HMAMGFJANGOFieldNumber = 10;
    private bool hMAMGFJANGO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HMAMGFJANGO {
      get { return hMAMGFJANGO_; }
      set {
        hMAMGFJANGO_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UpdatePlayerSettingData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UpdatePlayerSettingData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PMBBEIEHBML != other.PMBBEIEHBML) return false;
      if (NODHLKCFLPA != other.NODHLKCFLPA) return false;
      if (HMAMGFJANGO != other.HMAMGFJANGO) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PMBBEIEHBML != false) hash ^= PMBBEIEHBML.GetHashCode();
      if (NODHLKCFLPA != false) hash ^= NODHLKCFLPA.GetHashCode();
      if (HMAMGFJANGO != false) hash ^= HMAMGFJANGO.GetHashCode();
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
      if (PMBBEIEHBML != false) {
        output.WriteRawTag(24);
        output.WriteBool(PMBBEIEHBML);
      }
      if (NODHLKCFLPA != false) {
        output.WriteRawTag(72);
        output.WriteBool(NODHLKCFLPA);
      }
      if (HMAMGFJANGO != false) {
        output.WriteRawTag(80);
        output.WriteBool(HMAMGFJANGO);
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
      if (PMBBEIEHBML != false) {
        output.WriteRawTag(24);
        output.WriteBool(PMBBEIEHBML);
      }
      if (NODHLKCFLPA != false) {
        output.WriteRawTag(72);
        output.WriteBool(NODHLKCFLPA);
      }
      if (HMAMGFJANGO != false) {
        output.WriteRawTag(80);
        output.WriteBool(HMAMGFJANGO);
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
      if (PMBBEIEHBML != false) {
        size += 1 + 1;
      }
      if (NODHLKCFLPA != false) {
        size += 1 + 1;
      }
      if (HMAMGFJANGO != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UpdatePlayerSettingData other) {
      if (other == null) {
        return;
      }
      if (other.PMBBEIEHBML != false) {
        PMBBEIEHBML = other.PMBBEIEHBML;
      }
      if (other.NODHLKCFLPA != false) {
        NODHLKCFLPA = other.NODHLKCFLPA;
      }
      if (other.HMAMGFJANGO != false) {
        HMAMGFJANGO = other.HMAMGFJANGO;
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
            PMBBEIEHBML = input.ReadBool();
            break;
          }
          case 72: {
            NODHLKCFLPA = input.ReadBool();
            break;
          }
          case 80: {
            HMAMGFJANGO = input.ReadBool();
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
            PMBBEIEHBML = input.ReadBool();
            break;
          }
          case 72: {
            NODHLKCFLPA = input.ReadBool();
            break;
          }
          case 80: {
            HMAMGFJANGO = input.ReadBool();
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
