// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DDAAMMMOIDE.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from DDAAMMMOIDE.proto</summary>
  public static partial class DDAAMMMOIDEReflection {

    #region Descriptor
    /// <summary>File descriptor for DDAAMMMOIDE.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DDAAMMMOIDEReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFEREFBTU1NT0lERS5wcm90byKcAQoLRERBQU1NTU9JREUSEwoLREJHR09O",
            "RUNCRkQYBSADKA0SEwoLS01MQUxDUEdJUEcYASADKA0SEwoLTUZOQUhOQ0xO",
            "Sk8YDCABKA0SEwoLT0VIUEhBRUxPTkIYDSADKA0SEwoLTUNFTE9CQkdGREcY",
            "CyABKA0SEwoLSkZQTk5LRkpERkgYCCABKA0SDwoHc2hvcF9pZBgOIAEoDUIe",
            "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.DDAAMMMOIDE), global::EggLink.DanhengServer.Proto.DDAAMMMOIDE.Parser, new[]{ "DBGGONECBFD", "KMLALCPGIPG", "MFNAHNCLNJO", "OEHPHAELONB", "MCELOBBGFDG", "JFPNNKFJDFH", "ShopId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DDAAMMMOIDE : pb::IMessage<DDAAMMMOIDE>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DDAAMMMOIDE> _parser = new pb::MessageParser<DDAAMMMOIDE>(() => new DDAAMMMOIDE());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DDAAMMMOIDE> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.DDAAMMMOIDEReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DDAAMMMOIDE() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DDAAMMMOIDE(DDAAMMMOIDE other) : this() {
      dBGGONECBFD_ = other.dBGGONECBFD_.Clone();
      kMLALCPGIPG_ = other.kMLALCPGIPG_.Clone();
      mFNAHNCLNJO_ = other.mFNAHNCLNJO_;
      oEHPHAELONB_ = other.oEHPHAELONB_.Clone();
      mCELOBBGFDG_ = other.mCELOBBGFDG_;
      jFPNNKFJDFH_ = other.jFPNNKFJDFH_;
      shopId_ = other.shopId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DDAAMMMOIDE Clone() {
      return new DDAAMMMOIDE(this);
    }

    /// <summary>Field number for the "DBGGONECBFD" field.</summary>
    public const int DBGGONECBFDFieldNumber = 5;
    private static readonly pb::FieldCodec<uint> _repeated_dBGGONECBFD_codec
        = pb::FieldCodec.ForUInt32(42);
    private readonly pbc::RepeatedField<uint> dBGGONECBFD_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> DBGGONECBFD {
      get { return dBGGONECBFD_; }
    }

    /// <summary>Field number for the "KMLALCPGIPG" field.</summary>
    public const int KMLALCPGIPGFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_kMLALCPGIPG_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> kMLALCPGIPG_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> KMLALCPGIPG {
      get { return kMLALCPGIPG_; }
    }

    /// <summary>Field number for the "MFNAHNCLNJO" field.</summary>
    public const int MFNAHNCLNJOFieldNumber = 12;
    private uint mFNAHNCLNJO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MFNAHNCLNJO {
      get { return mFNAHNCLNJO_; }
      set {
        mFNAHNCLNJO_ = value;
      }
    }

    /// <summary>Field number for the "OEHPHAELONB" field.</summary>
    public const int OEHPHAELONBFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_oEHPHAELONB_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> oEHPHAELONB_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> OEHPHAELONB {
      get { return oEHPHAELONB_; }
    }

    /// <summary>Field number for the "MCELOBBGFDG" field.</summary>
    public const int MCELOBBGFDGFieldNumber = 11;
    private uint mCELOBBGFDG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MCELOBBGFDG {
      get { return mCELOBBGFDG_; }
      set {
        mCELOBBGFDG_ = value;
      }
    }

    /// <summary>Field number for the "JFPNNKFJDFH" field.</summary>
    public const int JFPNNKFJDFHFieldNumber = 8;
    private uint jFPNNKFJDFH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JFPNNKFJDFH {
      get { return jFPNNKFJDFH_; }
      set {
        jFPNNKFJDFH_ = value;
      }
    }

    /// <summary>Field number for the "shop_id" field.</summary>
    public const int ShopIdFieldNumber = 14;
    private uint shopId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ShopId {
      get { return shopId_; }
      set {
        shopId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DDAAMMMOIDE);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DDAAMMMOIDE other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!dBGGONECBFD_.Equals(other.dBGGONECBFD_)) return false;
      if(!kMLALCPGIPG_.Equals(other.kMLALCPGIPG_)) return false;
      if (MFNAHNCLNJO != other.MFNAHNCLNJO) return false;
      if(!oEHPHAELONB_.Equals(other.oEHPHAELONB_)) return false;
      if (MCELOBBGFDG != other.MCELOBBGFDG) return false;
      if (JFPNNKFJDFH != other.JFPNNKFJDFH) return false;
      if (ShopId != other.ShopId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= dBGGONECBFD_.GetHashCode();
      hash ^= kMLALCPGIPG_.GetHashCode();
      if (MFNAHNCLNJO != 0) hash ^= MFNAHNCLNJO.GetHashCode();
      hash ^= oEHPHAELONB_.GetHashCode();
      if (MCELOBBGFDG != 0) hash ^= MCELOBBGFDG.GetHashCode();
      if (JFPNNKFJDFH != 0) hash ^= JFPNNKFJDFH.GetHashCode();
      if (ShopId != 0) hash ^= ShopId.GetHashCode();
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
      kMLALCPGIPG_.WriteTo(output, _repeated_kMLALCPGIPG_codec);
      dBGGONECBFD_.WriteTo(output, _repeated_dBGGONECBFD_codec);
      if (JFPNNKFJDFH != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(JFPNNKFJDFH);
      }
      if (MCELOBBGFDG != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(MCELOBBGFDG);
      }
      if (MFNAHNCLNJO != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(MFNAHNCLNJO);
      }
      oEHPHAELONB_.WriteTo(output, _repeated_oEHPHAELONB_codec);
      if (ShopId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(ShopId);
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
      kMLALCPGIPG_.WriteTo(ref output, _repeated_kMLALCPGIPG_codec);
      dBGGONECBFD_.WriteTo(ref output, _repeated_dBGGONECBFD_codec);
      if (JFPNNKFJDFH != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(JFPNNKFJDFH);
      }
      if (MCELOBBGFDG != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(MCELOBBGFDG);
      }
      if (MFNAHNCLNJO != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(MFNAHNCLNJO);
      }
      oEHPHAELONB_.WriteTo(ref output, _repeated_oEHPHAELONB_codec);
      if (ShopId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(ShopId);
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
      size += dBGGONECBFD_.CalculateSize(_repeated_dBGGONECBFD_codec);
      size += kMLALCPGIPG_.CalculateSize(_repeated_kMLALCPGIPG_codec);
      if (MFNAHNCLNJO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MFNAHNCLNJO);
      }
      size += oEHPHAELONB_.CalculateSize(_repeated_oEHPHAELONB_codec);
      if (MCELOBBGFDG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MCELOBBGFDG);
      }
      if (JFPNNKFJDFH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JFPNNKFJDFH);
      }
      if (ShopId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ShopId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DDAAMMMOIDE other) {
      if (other == null) {
        return;
      }
      dBGGONECBFD_.Add(other.dBGGONECBFD_);
      kMLALCPGIPG_.Add(other.kMLALCPGIPG_);
      if (other.MFNAHNCLNJO != 0) {
        MFNAHNCLNJO = other.MFNAHNCLNJO;
      }
      oEHPHAELONB_.Add(other.oEHPHAELONB_);
      if (other.MCELOBBGFDG != 0) {
        MCELOBBGFDG = other.MCELOBBGFDG;
      }
      if (other.JFPNNKFJDFH != 0) {
        JFPNNKFJDFH = other.JFPNNKFJDFH;
      }
      if (other.ShopId != 0) {
        ShopId = other.ShopId;
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
          case 10:
          case 8: {
            kMLALCPGIPG_.AddEntriesFrom(input, _repeated_kMLALCPGIPG_codec);
            break;
          }
          case 42:
          case 40: {
            dBGGONECBFD_.AddEntriesFrom(input, _repeated_dBGGONECBFD_codec);
            break;
          }
          case 64: {
            JFPNNKFJDFH = input.ReadUInt32();
            break;
          }
          case 88: {
            MCELOBBGFDG = input.ReadUInt32();
            break;
          }
          case 96: {
            MFNAHNCLNJO = input.ReadUInt32();
            break;
          }
          case 106:
          case 104: {
            oEHPHAELONB_.AddEntriesFrom(input, _repeated_oEHPHAELONB_codec);
            break;
          }
          case 112: {
            ShopId = input.ReadUInt32();
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
          case 10:
          case 8: {
            kMLALCPGIPG_.AddEntriesFrom(ref input, _repeated_kMLALCPGIPG_codec);
            break;
          }
          case 42:
          case 40: {
            dBGGONECBFD_.AddEntriesFrom(ref input, _repeated_dBGGONECBFD_codec);
            break;
          }
          case 64: {
            JFPNNKFJDFH = input.ReadUInt32();
            break;
          }
          case 88: {
            MCELOBBGFDG = input.ReadUInt32();
            break;
          }
          case 96: {
            MFNAHNCLNJO = input.ReadUInt32();
            break;
          }
          case 106:
          case 104: {
            oEHPHAELONB_.AddEntriesFrom(ref input, _repeated_oEHPHAELONB_codec);
            break;
          }
          case 112: {
            ShopId = input.ReadUInt32();
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
