// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MHNOEGMOGLJ.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MHNOEGMOGLJ.proto</summary>
  public static partial class MHNOEGMOGLJReflection {

    #region Descriptor
    /// <summary>File descriptor for MHNOEGMOGLJ.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MHNOEGMOGLJReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFNSE5PRUdNT0dMSi5wcm90bxoQUmVsaWNBZmZpeC5wcm90byJyCgtNSE5P",
            "RUdNT0dMShILCgN0aWQYDyABKA0SFQoNbWFpbl9hZmZpeF9pZBgOIAEoDRIL",
            "CgNleHAYBiABKA0SIwoOc3ViX2FmZml4X2xpc3QYBSADKAsyCy5SZWxpY0Fm",
            "Zml4Eg0KBWxldmVsGAggASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu",
            "UHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RelicAffixReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MHNOEGMOGLJ), global::EggLink.DanhengServer.Proto.MHNOEGMOGLJ.Parser, new[]{ "Tid", "MainAffixId", "Exp", "SubAffixList", "Level" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MHNOEGMOGLJ : pb::IMessage<MHNOEGMOGLJ>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MHNOEGMOGLJ> _parser = new pb::MessageParser<MHNOEGMOGLJ>(() => new MHNOEGMOGLJ());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MHNOEGMOGLJ> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MHNOEGMOGLJReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MHNOEGMOGLJ() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MHNOEGMOGLJ(MHNOEGMOGLJ other) : this() {
      tid_ = other.tid_;
      mainAffixId_ = other.mainAffixId_;
      exp_ = other.exp_;
      subAffixList_ = other.subAffixList_.Clone();
      level_ = other.level_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MHNOEGMOGLJ Clone() {
      return new MHNOEGMOGLJ(this);
    }

    /// <summary>Field number for the "tid" field.</summary>
    public const int TidFieldNumber = 15;
    private uint tid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Tid {
      get { return tid_; }
      set {
        tid_ = value;
      }
    }

    /// <summary>Field number for the "main_affix_id" field.</summary>
    public const int MainAffixIdFieldNumber = 14;
    private uint mainAffixId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MainAffixId {
      get { return mainAffixId_; }
      set {
        mainAffixId_ = value;
      }
    }

    /// <summary>Field number for the "exp" field.</summary>
    public const int ExpFieldNumber = 6;
    private uint exp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Exp {
      get { return exp_; }
      set {
        exp_ = value;
      }
    }

    /// <summary>Field number for the "sub_affix_list" field.</summary>
    public const int SubAffixListFieldNumber = 5;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.RelicAffix> _repeated_subAffixList_codec
        = pb::FieldCodec.ForMessage(42, global::EggLink.DanhengServer.Proto.RelicAffix.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RelicAffix> subAffixList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RelicAffix>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RelicAffix> SubAffixList {
      get { return subAffixList_; }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 8;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MHNOEGMOGLJ);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MHNOEGMOGLJ other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Tid != other.Tid) return false;
      if (MainAffixId != other.MainAffixId) return false;
      if (Exp != other.Exp) return false;
      if(!subAffixList_.Equals(other.subAffixList_)) return false;
      if (Level != other.Level) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Tid != 0) hash ^= Tid.GetHashCode();
      if (MainAffixId != 0) hash ^= MainAffixId.GetHashCode();
      if (Exp != 0) hash ^= Exp.GetHashCode();
      hash ^= subAffixList_.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
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
      subAffixList_.WriteTo(output, _repeated_subAffixList_codec);
      if (Exp != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Exp);
      }
      if (Level != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Level);
      }
      if (MainAffixId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(MainAffixId);
      }
      if (Tid != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Tid);
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
      subAffixList_.WriteTo(ref output, _repeated_subAffixList_codec);
      if (Exp != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Exp);
      }
      if (Level != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Level);
      }
      if (MainAffixId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(MainAffixId);
      }
      if (Tid != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Tid);
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
      if (Tid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Tid);
      }
      if (MainAffixId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MainAffixId);
      }
      if (Exp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Exp);
      }
      size += subAffixList_.CalculateSize(_repeated_subAffixList_codec);
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MHNOEGMOGLJ other) {
      if (other == null) {
        return;
      }
      if (other.Tid != 0) {
        Tid = other.Tid;
      }
      if (other.MainAffixId != 0) {
        MainAffixId = other.MainAffixId;
      }
      if (other.Exp != 0) {
        Exp = other.Exp;
      }
      subAffixList_.Add(other.subAffixList_);
      if (other.Level != 0) {
        Level = other.Level;
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
          case 42: {
            subAffixList_.AddEntriesFrom(input, _repeated_subAffixList_codec);
            break;
          }
          case 48: {
            Exp = input.ReadUInt32();
            break;
          }
          case 64: {
            Level = input.ReadUInt32();
            break;
          }
          case 112: {
            MainAffixId = input.ReadUInt32();
            break;
          }
          case 120: {
            Tid = input.ReadUInt32();
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
          case 42: {
            subAffixList_.AddEntriesFrom(ref input, _repeated_subAffixList_codec);
            break;
          }
          case 48: {
            Exp = input.ReadUInt32();
            break;
          }
          case 64: {
            Level = input.ReadUInt32();
            break;
          }
          case 112: {
            MainAffixId = input.ReadUInt32();
            break;
          }
          case 120: {
            Tid = input.ReadUInt32();
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