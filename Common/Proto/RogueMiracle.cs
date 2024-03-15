// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueMiracle.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueMiracle.proto</summary>
  public static partial class RogueMiracleReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueMiracle.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueMiracleReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJSb2d1ZU1pcmFjbGUucHJvdG8izAEKDFJvZ3VlTWlyYWNsZRIWCg5keW5h",
            "bWljX251bWJlchgEIAEoDRIzCgtFQkpMUEdGTUNLTxgKIAMoCzIeLlJvZ3Vl",
            "TWlyYWNsZS5FQkpMUEdGTUNLT0VudHJ5EhIKCmR1cmFiaWxpdHkYDCABKA0S",
            "EwoLSklNSUVNRkdLQk0YDyABKA0SEgoKbWlyYWNsZV9pZBgNIAEoDRoyChBF",
            "QkpMUEdGTUNLT0VudHJ5EgsKA2tleRgBIAEoDRINCgV2YWx1ZRgCIAEoDToC",
            "OAFCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueMiracle), global::EggLink.DanhengServer.Proto.RogueMiracle.Parser, new[]{ "DynamicNumber", "EBJLPGFMCKO", "Durability", "JIMIEMFGKBM", "MiracleId" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueMiracle : pb::IMessage<RogueMiracle>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueMiracle> _parser = new pb::MessageParser<RogueMiracle>(() => new RogueMiracle());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueMiracle> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueMiracleReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueMiracle() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueMiracle(RogueMiracle other) : this() {
      dynamicNumber_ = other.dynamicNumber_;
      eBJLPGFMCKO_ = other.eBJLPGFMCKO_.Clone();
      durability_ = other.durability_;
      jIMIEMFGKBM_ = other.jIMIEMFGKBM_;
      miracleId_ = other.miracleId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueMiracle Clone() {
      return new RogueMiracle(this);
    }

    /// <summary>Field number for the "dynamic_number" field.</summary>
    public const int DynamicNumberFieldNumber = 4;
    private uint dynamicNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DynamicNumber {
      get { return dynamicNumber_; }
      set {
        dynamicNumber_ = value;
      }
    }

    /// <summary>Field number for the "EBJLPGFMCKO" field.</summary>
    public const int EBJLPGFMCKOFieldNumber = 10;
    private static readonly pbc::MapField<uint, uint>.Codec _map_eBJLPGFMCKO_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 82);
    private readonly pbc::MapField<uint, uint> eBJLPGFMCKO_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> EBJLPGFMCKO {
      get { return eBJLPGFMCKO_; }
    }

    /// <summary>Field number for the "durability" field.</summary>
    public const int DurabilityFieldNumber = 12;
    private uint durability_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Durability {
      get { return durability_; }
      set {
        durability_ = value;
      }
    }

    /// <summary>Field number for the "JIMIEMFGKBM" field.</summary>
    public const int JIMIEMFGKBMFieldNumber = 15;
    private uint jIMIEMFGKBM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JIMIEMFGKBM {
      get { return jIMIEMFGKBM_; }
      set {
        jIMIEMFGKBM_ = value;
      }
    }

    /// <summary>Field number for the "miracle_id" field.</summary>
    public const int MiracleIdFieldNumber = 13;
    private uint miracleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MiracleId {
      get { return miracleId_; }
      set {
        miracleId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueMiracle);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueMiracle other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DynamicNumber != other.DynamicNumber) return false;
      if (!EBJLPGFMCKO.Equals(other.EBJLPGFMCKO)) return false;
      if (Durability != other.Durability) return false;
      if (JIMIEMFGKBM != other.JIMIEMFGKBM) return false;
      if (MiracleId != other.MiracleId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DynamicNumber != 0) hash ^= DynamicNumber.GetHashCode();
      hash ^= EBJLPGFMCKO.GetHashCode();
      if (Durability != 0) hash ^= Durability.GetHashCode();
      if (JIMIEMFGKBM != 0) hash ^= JIMIEMFGKBM.GetHashCode();
      if (MiracleId != 0) hash ^= MiracleId.GetHashCode();
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
      if (DynamicNumber != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(DynamicNumber);
      }
      eBJLPGFMCKO_.WriteTo(output, _map_eBJLPGFMCKO_codec);
      if (Durability != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Durability);
      }
      if (MiracleId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(MiracleId);
      }
      if (JIMIEMFGKBM != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(JIMIEMFGKBM);
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
      if (DynamicNumber != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(DynamicNumber);
      }
      eBJLPGFMCKO_.WriteTo(ref output, _map_eBJLPGFMCKO_codec);
      if (Durability != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Durability);
      }
      if (MiracleId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(MiracleId);
      }
      if (JIMIEMFGKBM != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(JIMIEMFGKBM);
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
      if (DynamicNumber != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DynamicNumber);
      }
      size += eBJLPGFMCKO_.CalculateSize(_map_eBJLPGFMCKO_codec);
      if (Durability != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Durability);
      }
      if (JIMIEMFGKBM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JIMIEMFGKBM);
      }
      if (MiracleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MiracleId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueMiracle other) {
      if (other == null) {
        return;
      }
      if (other.DynamicNumber != 0) {
        DynamicNumber = other.DynamicNumber;
      }
      eBJLPGFMCKO_.MergeFrom(other.eBJLPGFMCKO_);
      if (other.Durability != 0) {
        Durability = other.Durability;
      }
      if (other.JIMIEMFGKBM != 0) {
        JIMIEMFGKBM = other.JIMIEMFGKBM;
      }
      if (other.MiracleId != 0) {
        MiracleId = other.MiracleId;
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
          case 32: {
            DynamicNumber = input.ReadUInt32();
            break;
          }
          case 82: {
            eBJLPGFMCKO_.AddEntriesFrom(input, _map_eBJLPGFMCKO_codec);
            break;
          }
          case 96: {
            Durability = input.ReadUInt32();
            break;
          }
          case 104: {
            MiracleId = input.ReadUInt32();
            break;
          }
          case 120: {
            JIMIEMFGKBM = input.ReadUInt32();
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
          case 32: {
            DynamicNumber = input.ReadUInt32();
            break;
          }
          case 82: {
            eBJLPGFMCKO_.AddEntriesFrom(ref input, _map_eBJLPGFMCKO_codec);
            break;
          }
          case 96: {
            Durability = input.ReadUInt32();
            break;
          }
          case 104: {
            MiracleId = input.ReadUInt32();
            break;
          }
          case 120: {
            JIMIEMFGKBM = input.ReadUInt32();
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
