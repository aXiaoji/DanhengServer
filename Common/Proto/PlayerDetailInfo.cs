// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PlayerDetailInfo.proto</summary>
  public static partial class PlayerDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZQbGF5ZXJEZXRhaWxJbmZvLnByb3RvGhJQbGF0Zm9ybVR5cGUucHJvdG8a",
            "HURpc3BsYXlBdmF0YXJEZXRhaWxJbmZvLnByb3RvGhdEaXNwbGF5UmVjb3Jk",
            "SW5mby5wcm90byKgAwoQUGxheWVyRGV0YWlsSW5mbxIQCghuaWNrbmFtZRgD",
            "IAEoCRINCgVsZXZlbBgJIAEoDRInCgtyZWNvcmRfaW5mbxgCIAEoCzISLkRp",
            "c3BsYXlSZWNvcmRJbmZvEhMKC0VKQVBFT09QQUlEGA0gASgNEhEKCWlzX2Jh",
            "bm5lZBgLIAEoCBITCgtETUFQSkdFRk9CThgOIAEoCRIuCgtDREFQREJQTEdO",
            "ThjWCCADKAsyGC5EaXNwbGF5QXZhdGFyRGV0YWlsSW5mbxItCgtIQkNGRkNP",
            "REhOSBgKIAMoCzIYLkRpc3BsYXlBdmF0YXJEZXRhaWxJbmZvEhEKCXNpZ25h",
            "dHVyZRgFIAEoCRITCgtKRU9ERklMSUZCSxgHIAEoCBITCgtPRlBJT0FDT1BJ",
            "SBgEIAEoDRILCgN1aWQYDCABKA0SEQoJaGVhZF9pY29uGAggASgNEh8KCHBs",
            "YXRmb3JtGAEgASgOMg0uUGxhdGZvcm1UeXBlEhMKC0ZGTE9KTVBHSUpEGAYg",
            "ASgJEhMKC3dvcmxkX2xldmVsGA8gASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdT",
            "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.PlatformTypeReflection.Descriptor, global::EggLink.DanhengServer.Proto.DisplayAvatarDetailInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.DisplayRecordInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PlayerDetailInfo), global::EggLink.DanhengServer.Proto.PlayerDetailInfo.Parser, new[]{ "Nickname", "Level", "RecordInfo", "EJAPEOOPAID", "IsBanned", "DMAPJGEFOBN", "CDAPDBPLGNN", "HBCFFCODHNH", "Signature", "JEODFILIFBK", "OFPIOACOPIH", "Uid", "HeadIcon", "Platform", "FFLOJMPGIJD", "WorldLevel" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PlayerDetailInfo : pb::IMessage<PlayerDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerDetailInfo> _parser = new pb::MessageParser<PlayerDetailInfo>(() => new PlayerDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PlayerDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerDetailInfo(PlayerDetailInfo other) : this() {
      nickname_ = other.nickname_;
      level_ = other.level_;
      recordInfo_ = other.recordInfo_ != null ? other.recordInfo_.Clone() : null;
      eJAPEOOPAID_ = other.eJAPEOOPAID_;
      isBanned_ = other.isBanned_;
      dMAPJGEFOBN_ = other.dMAPJGEFOBN_;
      cDAPDBPLGNN_ = other.cDAPDBPLGNN_.Clone();
      hBCFFCODHNH_ = other.hBCFFCODHNH_.Clone();
      signature_ = other.signature_;
      jEODFILIFBK_ = other.jEODFILIFBK_;
      oFPIOACOPIH_ = other.oFPIOACOPIH_;
      uid_ = other.uid_;
      headIcon_ = other.headIcon_;
      platform_ = other.platform_;
      fFLOJMPGIJD_ = other.fFLOJMPGIJD_;
      worldLevel_ = other.worldLevel_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerDetailInfo Clone() {
      return new PlayerDetailInfo(this);
    }

    /// <summary>Field number for the "nickname" field.</summary>
    public const int NicknameFieldNumber = 3;
    private string nickname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Nickname {
      get { return nickname_; }
      set {
        nickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 9;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "record_info" field.</summary>
    public const int RecordInfoFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.DisplayRecordInfo recordInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.DisplayRecordInfo RecordInfo {
      get { return recordInfo_; }
      set {
        recordInfo_ = value;
      }
    }

    /// <summary>Field number for the "EJAPEOOPAID" field.</summary>
    public const int EJAPEOOPAIDFieldNumber = 13;
    private uint eJAPEOOPAID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EJAPEOOPAID {
      get { return eJAPEOOPAID_; }
      set {
        eJAPEOOPAID_ = value;
      }
    }

    /// <summary>Field number for the "is_banned" field.</summary>
    public const int IsBannedFieldNumber = 11;
    private bool isBanned_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsBanned {
      get { return isBanned_; }
      set {
        isBanned_ = value;
      }
    }

    /// <summary>Field number for the "DMAPJGEFOBN" field.</summary>
    public const int DMAPJGEFOBNFieldNumber = 14;
    private string dMAPJGEFOBN_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DMAPJGEFOBN {
      get { return dMAPJGEFOBN_; }
      set {
        dMAPJGEFOBN_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "CDAPDBPLGNN" field.</summary>
    public const int CDAPDBPLGNNFieldNumber = 1110;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.DisplayAvatarDetailInfo> _repeated_cDAPDBPLGNN_codec
        = pb::FieldCodec.ForMessage(8882, global::EggLink.DanhengServer.Proto.DisplayAvatarDetailInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DisplayAvatarDetailInfo> cDAPDBPLGNN_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DisplayAvatarDetailInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DisplayAvatarDetailInfo> CDAPDBPLGNN {
      get { return cDAPDBPLGNN_; }
    }

    /// <summary>Field number for the "HBCFFCODHNH" field.</summary>
    public const int HBCFFCODHNHFieldNumber = 10;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.DisplayAvatarDetailInfo> _repeated_hBCFFCODHNH_codec
        = pb::FieldCodec.ForMessage(82, global::EggLink.DanhengServer.Proto.DisplayAvatarDetailInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DisplayAvatarDetailInfo> hBCFFCODHNH_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DisplayAvatarDetailInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DisplayAvatarDetailInfo> HBCFFCODHNH {
      get { return hBCFFCODHNH_; }
    }

    /// <summary>Field number for the "signature" field.</summary>
    public const int SignatureFieldNumber = 5;
    private string signature_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Signature {
      get { return signature_; }
      set {
        signature_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "JEODFILIFBK" field.</summary>
    public const int JEODFILIFBKFieldNumber = 7;
    private bool jEODFILIFBK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool JEODFILIFBK {
      get { return jEODFILIFBK_; }
      set {
        jEODFILIFBK_ = value;
      }
    }

    /// <summary>Field number for the "OFPIOACOPIH" field.</summary>
    public const int OFPIOACOPIHFieldNumber = 4;
    private uint oFPIOACOPIH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OFPIOACOPIH {
      get { return oFPIOACOPIH_; }
      set {
        oFPIOACOPIH_ = value;
      }
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 12;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "head_icon" field.</summary>
    public const int HeadIconFieldNumber = 8;
    private uint headIcon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HeadIcon {
      get { return headIcon_; }
      set {
        headIcon_ = value;
      }
    }

    /// <summary>Field number for the "platform" field.</summary>
    public const int PlatformFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.PlatformType platform_ = global::EggLink.DanhengServer.Proto.PlatformType.Editor;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PlatformType Platform {
      get { return platform_; }
      set {
        platform_ = value;
      }
    }

    /// <summary>Field number for the "FFLOJMPGIJD" field.</summary>
    public const int FFLOJMPGIJDFieldNumber = 6;
    private string fFLOJMPGIJD_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string FFLOJMPGIJD {
      get { return fFLOJMPGIJD_; }
      set {
        fFLOJMPGIJD_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "world_level" field.</summary>
    public const int WorldLevelFieldNumber = 15;
    private uint worldLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WorldLevel {
      get { return worldLevel_; }
      set {
        worldLevel_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Nickname != other.Nickname) return false;
      if (Level != other.Level) return false;
      if (!object.Equals(RecordInfo, other.RecordInfo)) return false;
      if (EJAPEOOPAID != other.EJAPEOOPAID) return false;
      if (IsBanned != other.IsBanned) return false;
      if (DMAPJGEFOBN != other.DMAPJGEFOBN) return false;
      if(!cDAPDBPLGNN_.Equals(other.cDAPDBPLGNN_)) return false;
      if(!hBCFFCODHNH_.Equals(other.hBCFFCODHNH_)) return false;
      if (Signature != other.Signature) return false;
      if (JEODFILIFBK != other.JEODFILIFBK) return false;
      if (OFPIOACOPIH != other.OFPIOACOPIH) return false;
      if (Uid != other.Uid) return false;
      if (HeadIcon != other.HeadIcon) return false;
      if (Platform != other.Platform) return false;
      if (FFLOJMPGIJD != other.FFLOJMPGIJD) return false;
      if (WorldLevel != other.WorldLevel) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Nickname.Length != 0) hash ^= Nickname.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (recordInfo_ != null) hash ^= RecordInfo.GetHashCode();
      if (EJAPEOOPAID != 0) hash ^= EJAPEOOPAID.GetHashCode();
      if (IsBanned != false) hash ^= IsBanned.GetHashCode();
      if (DMAPJGEFOBN.Length != 0) hash ^= DMAPJGEFOBN.GetHashCode();
      hash ^= cDAPDBPLGNN_.GetHashCode();
      hash ^= hBCFFCODHNH_.GetHashCode();
      if (Signature.Length != 0) hash ^= Signature.GetHashCode();
      if (JEODFILIFBK != false) hash ^= JEODFILIFBK.GetHashCode();
      if (OFPIOACOPIH != 0) hash ^= OFPIOACOPIH.GetHashCode();
      if (Uid != 0) hash ^= Uid.GetHashCode();
      if (HeadIcon != 0) hash ^= HeadIcon.GetHashCode();
      if (Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) hash ^= Platform.GetHashCode();
      if (FFLOJMPGIJD.Length != 0) hash ^= FFLOJMPGIJD.GetHashCode();
      if (WorldLevel != 0) hash ^= WorldLevel.GetHashCode();
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
      if (Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Platform);
      }
      if (recordInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(RecordInfo);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Nickname);
      }
      if (OFPIOACOPIH != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(OFPIOACOPIH);
      }
      if (Signature.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Signature);
      }
      if (FFLOJMPGIJD.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(FFLOJMPGIJD);
      }
      if (JEODFILIFBK != false) {
        output.WriteRawTag(56);
        output.WriteBool(JEODFILIFBK);
      }
      if (HeadIcon != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(HeadIcon);
      }
      if (Level != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Level);
      }
      hBCFFCODHNH_.WriteTo(output, _repeated_hBCFFCODHNH_codec);
      if (IsBanned != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsBanned);
      }
      if (Uid != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Uid);
      }
      if (EJAPEOOPAID != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(EJAPEOOPAID);
      }
      if (DMAPJGEFOBN.Length != 0) {
        output.WriteRawTag(114);
        output.WriteString(DMAPJGEFOBN);
      }
      if (WorldLevel != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(WorldLevel);
      }
      cDAPDBPLGNN_.WriteTo(output, _repeated_cDAPDBPLGNN_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Platform);
      }
      if (recordInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(RecordInfo);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Nickname);
      }
      if (OFPIOACOPIH != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(OFPIOACOPIH);
      }
      if (Signature.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Signature);
      }
      if (FFLOJMPGIJD.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(FFLOJMPGIJD);
      }
      if (JEODFILIFBK != false) {
        output.WriteRawTag(56);
        output.WriteBool(JEODFILIFBK);
      }
      if (HeadIcon != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(HeadIcon);
      }
      if (Level != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Level);
      }
      hBCFFCODHNH_.WriteTo(ref output, _repeated_hBCFFCODHNH_codec);
      if (IsBanned != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsBanned);
      }
      if (Uid != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Uid);
      }
      if (EJAPEOOPAID != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(EJAPEOOPAID);
      }
      if (DMAPJGEFOBN.Length != 0) {
        output.WriteRawTag(114);
        output.WriteString(DMAPJGEFOBN);
      }
      if (WorldLevel != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(WorldLevel);
      }
      cDAPDBPLGNN_.WriteTo(ref output, _repeated_cDAPDBPLGNN_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Nickname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nickname);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (recordInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RecordInfo);
      }
      if (EJAPEOOPAID != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EJAPEOOPAID);
      }
      if (IsBanned != false) {
        size += 1 + 1;
      }
      if (DMAPJGEFOBN.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DMAPJGEFOBN);
      }
      size += cDAPDBPLGNN_.CalculateSize(_repeated_cDAPDBPLGNN_codec);
      size += hBCFFCODHNH_.CalculateSize(_repeated_hBCFFCODHNH_codec);
      if (Signature.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Signature);
      }
      if (JEODFILIFBK != false) {
        size += 1 + 1;
      }
      if (OFPIOACOPIH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OFPIOACOPIH);
      }
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (HeadIcon != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HeadIcon);
      }
      if (Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Platform);
      }
      if (FFLOJMPGIJD.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FFLOJMPGIJD);
      }
      if (WorldLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WorldLevel);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerDetailInfo other) {
      if (other == null) {
        return;
      }
      if (other.Nickname.Length != 0) {
        Nickname = other.Nickname;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.recordInfo_ != null) {
        if (recordInfo_ == null) {
          RecordInfo = new global::EggLink.DanhengServer.Proto.DisplayRecordInfo();
        }
        RecordInfo.MergeFrom(other.RecordInfo);
      }
      if (other.EJAPEOOPAID != 0) {
        EJAPEOOPAID = other.EJAPEOOPAID;
      }
      if (other.IsBanned != false) {
        IsBanned = other.IsBanned;
      }
      if (other.DMAPJGEFOBN.Length != 0) {
        DMAPJGEFOBN = other.DMAPJGEFOBN;
      }
      cDAPDBPLGNN_.Add(other.cDAPDBPLGNN_);
      hBCFFCODHNH_.Add(other.hBCFFCODHNH_);
      if (other.Signature.Length != 0) {
        Signature = other.Signature;
      }
      if (other.JEODFILIFBK != false) {
        JEODFILIFBK = other.JEODFILIFBK;
      }
      if (other.OFPIOACOPIH != 0) {
        OFPIOACOPIH = other.OFPIOACOPIH;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      if (other.HeadIcon != 0) {
        HeadIcon = other.HeadIcon;
      }
      if (other.Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) {
        Platform = other.Platform;
      }
      if (other.FFLOJMPGIJD.Length != 0) {
        FFLOJMPGIJD = other.FFLOJMPGIJD;
      }
      if (other.WorldLevel != 0) {
        WorldLevel = other.WorldLevel;
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
            Platform = (global::EggLink.DanhengServer.Proto.PlatformType) input.ReadEnum();
            break;
          }
          case 18: {
            if (recordInfo_ == null) {
              RecordInfo = new global::EggLink.DanhengServer.Proto.DisplayRecordInfo();
            }
            input.ReadMessage(RecordInfo);
            break;
          }
          case 26: {
            Nickname = input.ReadString();
            break;
          }
          case 32: {
            OFPIOACOPIH = input.ReadUInt32();
            break;
          }
          case 42: {
            Signature = input.ReadString();
            break;
          }
          case 50: {
            FFLOJMPGIJD = input.ReadString();
            break;
          }
          case 56: {
            JEODFILIFBK = input.ReadBool();
            break;
          }
          case 64: {
            HeadIcon = input.ReadUInt32();
            break;
          }
          case 72: {
            Level = input.ReadUInt32();
            break;
          }
          case 82: {
            hBCFFCODHNH_.AddEntriesFrom(input, _repeated_hBCFFCODHNH_codec);
            break;
          }
          case 88: {
            IsBanned = input.ReadBool();
            break;
          }
          case 96: {
            Uid = input.ReadUInt32();
            break;
          }
          case 104: {
            EJAPEOOPAID = input.ReadUInt32();
            break;
          }
          case 114: {
            DMAPJGEFOBN = input.ReadString();
            break;
          }
          case 120: {
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 8882: {
            cDAPDBPLGNN_.AddEntriesFrom(input, _repeated_cDAPDBPLGNN_codec);
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
            Platform = (global::EggLink.DanhengServer.Proto.PlatformType) input.ReadEnum();
            break;
          }
          case 18: {
            if (recordInfo_ == null) {
              RecordInfo = new global::EggLink.DanhengServer.Proto.DisplayRecordInfo();
            }
            input.ReadMessage(RecordInfo);
            break;
          }
          case 26: {
            Nickname = input.ReadString();
            break;
          }
          case 32: {
            OFPIOACOPIH = input.ReadUInt32();
            break;
          }
          case 42: {
            Signature = input.ReadString();
            break;
          }
          case 50: {
            FFLOJMPGIJD = input.ReadString();
            break;
          }
          case 56: {
            JEODFILIFBK = input.ReadBool();
            break;
          }
          case 64: {
            HeadIcon = input.ReadUInt32();
            break;
          }
          case 72: {
            Level = input.ReadUInt32();
            break;
          }
          case 82: {
            hBCFFCODHNH_.AddEntriesFrom(ref input, _repeated_hBCFFCODHNH_codec);
            break;
          }
          case 88: {
            IsBanned = input.ReadBool();
            break;
          }
          case 96: {
            Uid = input.ReadUInt32();
            break;
          }
          case 104: {
            EJAPEOOPAID = input.ReadUInt32();
            break;
          }
          case 114: {
            DMAPJGEFOBN = input.ReadString();
            break;
          }
          case 120: {
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 8882: {
            cDAPDBPLGNN_.AddEntriesFrom(ref input, _repeated_cDAPDBPLGNN_codec);
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
