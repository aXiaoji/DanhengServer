// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueBuffDropAction.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueBuffDropAction.proto</summary>
  public static partial class RogueBuffDropActionReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueBuffDropAction.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueBuffDropActionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlSb2d1ZUJ1ZmZEcm9wQWN0aW9uLnByb3RvGhNSb2d1ZURyb3BCdWZmLnBy",
            "b3RvIk8KE1JvZ3VlQnVmZkRyb3BBY3Rpb24SIwoLTEhDQ0tEREpFSkwYASAD",
            "KAsyDi5Sb2d1ZURyb3BCdWZmEhMKC0xJRk9FRElJRUVMGA4gASgNQh6qAhtF",
            "Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueDropBuffReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueBuffDropAction), global::EggLink.DanhengServer.Proto.RogueBuffDropAction.Parser, new[]{ "LHCCKDDJEJL", "LIFOEDIIEEL" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueBuffDropAction : pb::IMessage<RogueBuffDropAction>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueBuffDropAction> _parser = new pb::MessageParser<RogueBuffDropAction>(() => new RogueBuffDropAction());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueBuffDropAction> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueBuffDropActionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueBuffDropAction() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueBuffDropAction(RogueBuffDropAction other) : this() {
      lHCCKDDJEJL_ = other.lHCCKDDJEJL_.Clone();
      lIFOEDIIEEL_ = other.lIFOEDIIEEL_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueBuffDropAction Clone() {
      return new RogueBuffDropAction(this);
    }

    /// <summary>Field number for the "LHCCKDDJEJL" field.</summary>
    public const int LHCCKDDJEJLFieldNumber = 1;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.RogueDropBuff> _repeated_lHCCKDDJEJL_codec
        = pb::FieldCodec.ForMessage(10, global::EggLink.DanhengServer.Proto.RogueDropBuff.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueDropBuff> lHCCKDDJEJL_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueDropBuff>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueDropBuff> LHCCKDDJEJL {
      get { return lHCCKDDJEJL_; }
    }

    /// <summary>Field number for the "LIFOEDIIEEL" field.</summary>
    public const int LIFOEDIIEELFieldNumber = 14;
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
      return Equals(other as RogueBuffDropAction);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueBuffDropAction other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!lHCCKDDJEJL_.Equals(other.lHCCKDDJEJL_)) return false;
      if (LIFOEDIIEEL != other.LIFOEDIIEEL) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= lHCCKDDJEJL_.GetHashCode();
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
      lHCCKDDJEJL_.WriteTo(output, _repeated_lHCCKDDJEJL_codec);
      if (LIFOEDIIEEL != 0) {
        output.WriteRawTag(112);
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
      lHCCKDDJEJL_.WriteTo(ref output, _repeated_lHCCKDDJEJL_codec);
      if (LIFOEDIIEEL != 0) {
        output.WriteRawTag(112);
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
      size += lHCCKDDJEJL_.CalculateSize(_repeated_lHCCKDDJEJL_codec);
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
    public void MergeFrom(RogueBuffDropAction other) {
      if (other == null) {
        return;
      }
      lHCCKDDJEJL_.Add(other.lHCCKDDJEJL_);
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
          case 10: {
            lHCCKDDJEJL_.AddEntriesFrom(input, _repeated_lHCCKDDJEJL_codec);
            break;
          }
          case 112: {
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
          case 10: {
            lHCCKDDJEJL_.AddEntriesFrom(ref input, _repeated_lHCCKDDJEJL_codec);
            break;
          }
          case 112: {
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
