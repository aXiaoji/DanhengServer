// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DNOEKLBAFPH.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from DNOEKLBAFPH.proto</summary>
  public static partial class DNOEKLBAFPHReflection {

    #region Descriptor
    /// <summary>File descriptor for DNOEKLBAFPH.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DNOEKLBAFPHReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFETk9FS0xCQUZQSC5wcm90byK3AQoLRE5PRUtMQkFGUEgSEQoJYXZhdGFy",
            "X2lkGAEgASgNEhMKC0dQR09QT05PQ0ZNGAIgAygNEg4KBnNvdXJjZRgDIAEo",
            "DRIOCgZkYW1hZ2UYBCABKAESEwoLTU5PR01KSElFQ0oYBSADKA0SEwoLS0FC",
            "QkVQRkJMSU0YBiABKAUSEwoLTUZQSUtDRk5LS0UYByABKAESEwoLRU5HQ0JC",
            "S05HQ0QYCCABKA0SDAoEd2F2ZRgJIAEoDUIeqgIbRWdnTGluay5EYW5oZW5n",
            "U2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.DNOEKLBAFPH), global::EggLink.DanhengServer.Proto.DNOEKLBAFPH.Parser, new[]{ "AvatarId", "GPGOPONOCFM", "Source", "Damage", "MNOGMJHIECJ", "KABBEPFBLIM", "MFPIKCFNKKE", "ENGCBBKNGCD", "Wave" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DNOEKLBAFPH : pb::IMessage<DNOEKLBAFPH>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DNOEKLBAFPH> _parser = new pb::MessageParser<DNOEKLBAFPH>(() => new DNOEKLBAFPH());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DNOEKLBAFPH> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.DNOEKLBAFPHReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DNOEKLBAFPH() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DNOEKLBAFPH(DNOEKLBAFPH other) : this() {
      avatarId_ = other.avatarId_;
      gPGOPONOCFM_ = other.gPGOPONOCFM_.Clone();
      source_ = other.source_;
      damage_ = other.damage_;
      mNOGMJHIECJ_ = other.mNOGMJHIECJ_.Clone();
      kABBEPFBLIM_ = other.kABBEPFBLIM_;
      mFPIKCFNKKE_ = other.mFPIKCFNKKE_;
      eNGCBBKNGCD_ = other.eNGCBBKNGCD_;
      wave_ = other.wave_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DNOEKLBAFPH Clone() {
      return new DNOEKLBAFPH(this);
    }

    /// <summary>Field number for the "avatar_id" field.</summary>
    public const int AvatarIdFieldNumber = 1;
    private uint avatarId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AvatarId {
      get { return avatarId_; }
      set {
        avatarId_ = value;
      }
    }

    /// <summary>Field number for the "GPGOPONOCFM" field.</summary>
    public const int GPGOPONOCFMFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_gPGOPONOCFM_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> gPGOPONOCFM_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> GPGOPONOCFM {
      get { return gPGOPONOCFM_; }
    }

    /// <summary>Field number for the "source" field.</summary>
    public const int SourceFieldNumber = 3;
    private uint source_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Source {
      get { return source_; }
      set {
        source_ = value;
      }
    }

    /// <summary>Field number for the "damage" field.</summary>
    public const int DamageFieldNumber = 4;
    private double damage_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Damage {
      get { return damage_; }
      set {
        damage_ = value;
      }
    }

    /// <summary>Field number for the "MNOGMJHIECJ" field.</summary>
    public const int MNOGMJHIECJFieldNumber = 5;
    private static readonly pb::FieldCodec<uint> _repeated_mNOGMJHIECJ_codec
        = pb::FieldCodec.ForUInt32(42);
    private readonly pbc::RepeatedField<uint> mNOGMJHIECJ_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> MNOGMJHIECJ {
      get { return mNOGMJHIECJ_; }
    }

    /// <summary>Field number for the "KABBEPFBLIM" field.</summary>
    public const int KABBEPFBLIMFieldNumber = 6;
    private int kABBEPFBLIM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int KABBEPFBLIM {
      get { return kABBEPFBLIM_; }
      set {
        kABBEPFBLIM_ = value;
      }
    }

    /// <summary>Field number for the "MFPIKCFNKKE" field.</summary>
    public const int MFPIKCFNKKEFieldNumber = 7;
    private double mFPIKCFNKKE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double MFPIKCFNKKE {
      get { return mFPIKCFNKKE_; }
      set {
        mFPIKCFNKKE_ = value;
      }
    }

    /// <summary>Field number for the "ENGCBBKNGCD" field.</summary>
    public const int ENGCBBKNGCDFieldNumber = 8;
    private uint eNGCBBKNGCD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ENGCBBKNGCD {
      get { return eNGCBBKNGCD_; }
      set {
        eNGCBBKNGCD_ = value;
      }
    }

    /// <summary>Field number for the "wave" field.</summary>
    public const int WaveFieldNumber = 9;
    private uint wave_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Wave {
      get { return wave_; }
      set {
        wave_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DNOEKLBAFPH);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DNOEKLBAFPH other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AvatarId != other.AvatarId) return false;
      if(!gPGOPONOCFM_.Equals(other.gPGOPONOCFM_)) return false;
      if (Source != other.Source) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Damage, other.Damage)) return false;
      if(!mNOGMJHIECJ_.Equals(other.mNOGMJHIECJ_)) return false;
      if (KABBEPFBLIM != other.KABBEPFBLIM) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(MFPIKCFNKKE, other.MFPIKCFNKKE)) return false;
      if (ENGCBBKNGCD != other.ENGCBBKNGCD) return false;
      if (Wave != other.Wave) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AvatarId != 0) hash ^= AvatarId.GetHashCode();
      hash ^= gPGOPONOCFM_.GetHashCode();
      if (Source != 0) hash ^= Source.GetHashCode();
      if (Damage != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Damage);
      hash ^= mNOGMJHIECJ_.GetHashCode();
      if (KABBEPFBLIM != 0) hash ^= KABBEPFBLIM.GetHashCode();
      if (MFPIKCFNKKE != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(MFPIKCFNKKE);
      if (ENGCBBKNGCD != 0) hash ^= ENGCBBKNGCD.GetHashCode();
      if (Wave != 0) hash ^= Wave.GetHashCode();
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
      if (AvatarId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(AvatarId);
      }
      gPGOPONOCFM_.WriteTo(output, _repeated_gPGOPONOCFM_codec);
      if (Source != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Source);
      }
      if (Damage != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(Damage);
      }
      mNOGMJHIECJ_.WriteTo(output, _repeated_mNOGMJHIECJ_codec);
      if (KABBEPFBLIM != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(KABBEPFBLIM);
      }
      if (MFPIKCFNKKE != 0D) {
        output.WriteRawTag(57);
        output.WriteDouble(MFPIKCFNKKE);
      }
      if (ENGCBBKNGCD != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(ENGCBBKNGCD);
      }
      if (Wave != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Wave);
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
      if (AvatarId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(AvatarId);
      }
      gPGOPONOCFM_.WriteTo(ref output, _repeated_gPGOPONOCFM_codec);
      if (Source != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Source);
      }
      if (Damage != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(Damage);
      }
      mNOGMJHIECJ_.WriteTo(ref output, _repeated_mNOGMJHIECJ_codec);
      if (KABBEPFBLIM != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(KABBEPFBLIM);
      }
      if (MFPIKCFNKKE != 0D) {
        output.WriteRawTag(57);
        output.WriteDouble(MFPIKCFNKKE);
      }
      if (ENGCBBKNGCD != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(ENGCBBKNGCD);
      }
      if (Wave != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Wave);
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
      if (AvatarId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AvatarId);
      }
      size += gPGOPONOCFM_.CalculateSize(_repeated_gPGOPONOCFM_codec);
      if (Source != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Source);
      }
      if (Damage != 0D) {
        size += 1 + 8;
      }
      size += mNOGMJHIECJ_.CalculateSize(_repeated_mNOGMJHIECJ_codec);
      if (KABBEPFBLIM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(KABBEPFBLIM);
      }
      if (MFPIKCFNKKE != 0D) {
        size += 1 + 8;
      }
      if (ENGCBBKNGCD != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ENGCBBKNGCD);
      }
      if (Wave != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Wave);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DNOEKLBAFPH other) {
      if (other == null) {
        return;
      }
      if (other.AvatarId != 0) {
        AvatarId = other.AvatarId;
      }
      gPGOPONOCFM_.Add(other.gPGOPONOCFM_);
      if (other.Source != 0) {
        Source = other.Source;
      }
      if (other.Damage != 0D) {
        Damage = other.Damage;
      }
      mNOGMJHIECJ_.Add(other.mNOGMJHIECJ_);
      if (other.KABBEPFBLIM != 0) {
        KABBEPFBLIM = other.KABBEPFBLIM;
      }
      if (other.MFPIKCFNKKE != 0D) {
        MFPIKCFNKKE = other.MFPIKCFNKKE;
      }
      if (other.ENGCBBKNGCD != 0) {
        ENGCBBKNGCD = other.ENGCBBKNGCD;
      }
      if (other.Wave != 0) {
        Wave = other.Wave;
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
            AvatarId = input.ReadUInt32();
            break;
          }
          case 18:
          case 16: {
            gPGOPONOCFM_.AddEntriesFrom(input, _repeated_gPGOPONOCFM_codec);
            break;
          }
          case 24: {
            Source = input.ReadUInt32();
            break;
          }
          case 33: {
            Damage = input.ReadDouble();
            break;
          }
          case 42:
          case 40: {
            mNOGMJHIECJ_.AddEntriesFrom(input, _repeated_mNOGMJHIECJ_codec);
            break;
          }
          case 48: {
            KABBEPFBLIM = input.ReadInt32();
            break;
          }
          case 57: {
            MFPIKCFNKKE = input.ReadDouble();
            break;
          }
          case 64: {
            ENGCBBKNGCD = input.ReadUInt32();
            break;
          }
          case 72: {
            Wave = input.ReadUInt32();
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
            AvatarId = input.ReadUInt32();
            break;
          }
          case 18:
          case 16: {
            gPGOPONOCFM_.AddEntriesFrom(ref input, _repeated_gPGOPONOCFM_codec);
            break;
          }
          case 24: {
            Source = input.ReadUInt32();
            break;
          }
          case 33: {
            Damage = input.ReadDouble();
            break;
          }
          case 42:
          case 40: {
            mNOGMJHIECJ_.AddEntriesFrom(ref input, _repeated_mNOGMJHIECJ_codec);
            break;
          }
          case 48: {
            KABBEPFBLIM = input.ReadInt32();
            break;
          }
          case 57: {
            MFPIKCFNKKE = input.ReadDouble();
            break;
          }
          case 64: {
            ENGCBBKNGCD = input.ReadUInt32();
            break;
          }
          case 72: {
            Wave = input.ReadUInt32();
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