// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueMiracleDestoryAction.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueMiracleDestoryAction.proto</summary>
  public static partial class RogueMiracleDestoryActionReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueMiracleDestoryAction.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueMiracleDestoryActionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9Sb2d1ZU1pcmFjbGVEZXN0b3J5QWN0aW9uLnByb3RvIkUKGVJvZ3VlTWly",
            "YWNsZURlc3RvcnlBY3Rpb24SEwoLQ09LTUdQQkNKSkkYByADKA0SEwoLTElG",
            "T0VESUlFRUwYDSABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
            "b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueMiracleDestoryAction), global::EggLink.DanhengServer.Proto.RogueMiracleDestoryAction.Parser, new[]{ "COKMGPBCJJI", "LIFOEDIIEEL" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueMiracleDestoryAction : pb::IMessage<RogueMiracleDestoryAction>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueMiracleDestoryAction> _parser = new pb::MessageParser<RogueMiracleDestoryAction>(() => new RogueMiracleDestoryAction());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueMiracleDestoryAction> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueMiracleDestoryActionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueMiracleDestoryAction() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueMiracleDestoryAction(RogueMiracleDestoryAction other) : this() {
      cOKMGPBCJJI_ = other.cOKMGPBCJJI_.Clone();
      lIFOEDIIEEL_ = other.lIFOEDIIEEL_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueMiracleDestoryAction Clone() {
      return new RogueMiracleDestoryAction(this);
    }

    /// <summary>Field number for the "COKMGPBCJJI" field.</summary>
    public const int COKMGPBCJJIFieldNumber = 7;
    private static readonly pb::FieldCodec<uint> _repeated_cOKMGPBCJJI_codec
        = pb::FieldCodec.ForUInt32(58);
    private readonly pbc::RepeatedField<uint> cOKMGPBCJJI_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> COKMGPBCJJI {
      get { return cOKMGPBCJJI_; }
    }

    /// <summary>Field number for the "LIFOEDIIEEL" field.</summary>
    public const int LIFOEDIIEELFieldNumber = 13;
    private uint lIFOEDIIEEL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LIFOEDIIEEL {
      get { return lIFOEDIIEEL_; }
      set {
        lIFOEDIIEEL_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueMiracleDestoryAction);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueMiracleDestoryAction other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!cOKMGPBCJJI_.Equals(other.cOKMGPBCJJI_)) return false;
      if (LIFOEDIIEEL != other.LIFOEDIIEEL) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= cOKMGPBCJJI_.GetHashCode();
      if (LIFOEDIIEEL != 0) hash ^= LIFOEDIIEEL.GetHashCode();
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
      cOKMGPBCJJI_.WriteTo(output, _repeated_cOKMGPBCJJI_codec);
      if (LIFOEDIIEEL != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(LIFOEDIIEEL);
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
      cOKMGPBCJJI_.WriteTo(ref output, _repeated_cOKMGPBCJJI_codec);
      if (LIFOEDIIEEL != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(LIFOEDIIEEL);
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
      size += cOKMGPBCJJI_.CalculateSize(_repeated_cOKMGPBCJJI_codec);
      if (LIFOEDIIEEL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LIFOEDIIEEL);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueMiracleDestoryAction other) {
      if (other == null) {
        return;
      }
      cOKMGPBCJJI_.Add(other.cOKMGPBCJJI_);
      if (other.LIFOEDIIEEL != 0) {
        LIFOEDIIEEL = other.LIFOEDIIEEL;
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
          case 58:
          case 56: {
            cOKMGPBCJJI_.AddEntriesFrom(input, _repeated_cOKMGPBCJJI_codec);
            break;
          }
          case 104: {
            LIFOEDIIEEL = input.ReadUInt32();
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
          case 58:
          case 56: {
            cOKMGPBCJJI_.AddEntriesFrom(ref input, _repeated_cOKMGPBCJJI_codec);
            break;
          }
          case 104: {
            LIFOEDIIEEL = input.ReadUInt32();
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
