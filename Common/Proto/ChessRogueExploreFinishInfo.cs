// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueExploreFinishInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueExploreFinishInfo.proto</summary>
  public static partial class ChessRogueExploreFinishInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueExploreFinishInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueExploreFinishInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFDaGVzc1JvZ3VlRXhwbG9yZUZpbmlzaEluZm8ucHJvdG8aE1JvZ3VlQnVm",
            "ZkluZm8ucHJvdG8aH0NoZXNzUm9ndWVBY2NvdW50QnlTdGF0dXMucHJvdG8a",
            "Dkl0ZW1MaXN0LnByb3RvGhlDaGVzc1JvZ3VlU3RvcnlJbmZvLnByb3RvGhBM",
            "aW5ldXBJbmZvLnByb3RvGhhSb2d1ZU1pcmFjbGVFZmZlY3QucHJvdG8iqQQK",
            "G0NoZXNzUm9ndWVFeHBsb3JlRmluaXNoSW5mbxIRCglpc19maW5pc2gYCSAB",
            "KAgSKQoKc3RvcnlfaW5mbxjaBSABKAsyFC5DaGVzc1JvZ3VlU3RvcnlJbmZv",
            "Ei8KC0RGRkhPTkNEQUdCGAUgASgOMhouQ2hlc3NSb2d1ZUFjY291bnRCeVN0",
            "YXR1cxITCgtNUEFNTENBREhGTRgCIAMoDRITCgtJT0ZFSk9FQ1BLUBgOIAEo",
            "DRIRCghzY29yZV9pZBixCSABKA0SJgoOZ2FtZV9idWZmX2luZm8YCCABKAsy",
            "Di5Sb2d1ZUJ1ZmZJbmZvEhkKEHJvZ3VlX3ZlcnNpb25faWQYtwMgASgNEhMK",
            "C0dHS0VLRUFGT1BLGAEgASgNEh4KC0xLSk1JRUFLREdCGA0gASgLMgkuSXRl",
            "bUxpc3QSIAoLTUlESEhMS0hDSEYYDCABKAsyCy5MaW5ldXBJbmZvEhMKC0JB",
            "QURJSUdHTk1GGA8gASgNEhMKC0VBS0hCRUlNSFBGGAsgASgNEhMKC0VHTkRO",
            "SUtOSUlQGAQgASgNEhQKC0pNQUZCTEhGR1BJGLYEIAEoDRIUCgtITkRQSEJD",
            "SVBIUBj1CiABKA0SEwoLRExPR0xOREJJR04YBiABKA0SLgoRZ2FtZV9taXJh",
            "Y2xlX2luZm8YCiABKAsyEy5Sb2d1ZU1pcmFjbGVFZmZlY3QSFAoLQkZNUE9Q",
            "TE9QTEYYpwIgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueBuffInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueAccountByStatusReflection.Descriptor, global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueStoryInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.LineupInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueMiracleEffectReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueExploreFinishInfo), global::EggLink.DanhengServer.Proto.ChessRogueExploreFinishInfo.Parser, new[]{ "IsFinish", "StoryInfo", "DFFHONCDAGB", "MPAMLCADHFM", "IOFEJOECPKP", "ScoreId", "GameBuffInfo", "RogueVersionId", "GGKEKEAFOPK", "LKJMIEAKDGB", "MIDHHLKHCHF", "BAADIIGGNMF", "EAKHBEIMHPF", "EGNDNIKNIIP", "JMAFBLHFGPI", "HNDPHBCIPHP", "DLOGLNDBIGN", "GameMiracleInfo", "BFMPOPLOPLF" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueExploreFinishInfo : pb::IMessage<ChessRogueExploreFinishInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueExploreFinishInfo> _parser = new pb::MessageParser<ChessRogueExploreFinishInfo>(() => new ChessRogueExploreFinishInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueExploreFinishInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueExploreFinishInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueExploreFinishInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueExploreFinishInfo(ChessRogueExploreFinishInfo other) : this() {
      isFinish_ = other.isFinish_;
      storyInfo_ = other.storyInfo_ != null ? other.storyInfo_.Clone() : null;
      dFFHONCDAGB_ = other.dFFHONCDAGB_;
      mPAMLCADHFM_ = other.mPAMLCADHFM_.Clone();
      iOFEJOECPKP_ = other.iOFEJOECPKP_;
      scoreId_ = other.scoreId_;
      gameBuffInfo_ = other.gameBuffInfo_ != null ? other.gameBuffInfo_.Clone() : null;
      rogueVersionId_ = other.rogueVersionId_;
      gGKEKEAFOPK_ = other.gGKEKEAFOPK_;
      lKJMIEAKDGB_ = other.lKJMIEAKDGB_ != null ? other.lKJMIEAKDGB_.Clone() : null;
      mIDHHLKHCHF_ = other.mIDHHLKHCHF_ != null ? other.mIDHHLKHCHF_.Clone() : null;
      bAADIIGGNMF_ = other.bAADIIGGNMF_;
      eAKHBEIMHPF_ = other.eAKHBEIMHPF_;
      eGNDNIKNIIP_ = other.eGNDNIKNIIP_;
      jMAFBLHFGPI_ = other.jMAFBLHFGPI_;
      hNDPHBCIPHP_ = other.hNDPHBCIPHP_;
      dLOGLNDBIGN_ = other.dLOGLNDBIGN_;
      gameMiracleInfo_ = other.gameMiracleInfo_ != null ? other.gameMiracleInfo_.Clone() : null;
      bFMPOPLOPLF_ = other.bFMPOPLOPLF_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueExploreFinishInfo Clone() {
      return new ChessRogueExploreFinishInfo(this);
    }

    /// <summary>Field number for the "is_finish" field.</summary>
    public const int IsFinishFieldNumber = 9;
    private bool isFinish_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFinish {
      get { return isFinish_; }
      set {
        isFinish_ = value;
      }
    }

    /// <summary>Field number for the "story_info" field.</summary>
    public const int StoryInfoFieldNumber = 730;
    private global::EggLink.DanhengServer.Proto.ChessRogueStoryInfo storyInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueStoryInfo StoryInfo {
      get { return storyInfo_; }
      set {
        storyInfo_ = value;
      }
    }

    /// <summary>Field number for the "DFFHONCDAGB" field.</summary>
    public const int DFFHONCDAGBFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.ChessRogueAccountByStatus dFFHONCDAGB_ = global::EggLink.DanhengServer.Proto.ChessRogueAccountByStatus.ChessRogueAccountByNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueAccountByStatus DFFHONCDAGB {
      get { return dFFHONCDAGB_; }
      set {
        dFFHONCDAGB_ = value;
      }
    }

    /// <summary>Field number for the "MPAMLCADHFM" field.</summary>
    public const int MPAMLCADHFMFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_mPAMLCADHFM_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> mPAMLCADHFM_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> MPAMLCADHFM {
      get { return mPAMLCADHFM_; }
    }

    /// <summary>Field number for the "IOFEJOECPKP" field.</summary>
    public const int IOFEJOECPKPFieldNumber = 14;
    private uint iOFEJOECPKP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IOFEJOECPKP {
      get { return iOFEJOECPKP_; }
      set {
        iOFEJOECPKP_ = value;
      }
    }

    /// <summary>Field number for the "score_id" field.</summary>
    public const int ScoreIdFieldNumber = 1201;
    private uint scoreId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ScoreId {
      get { return scoreId_; }
      set {
        scoreId_ = value;
      }
    }

    /// <summary>Field number for the "game_buff_info" field.</summary>
    public const int GameBuffInfoFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.RogueBuffInfo gameBuffInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueBuffInfo GameBuffInfo {
      get { return gameBuffInfo_; }
      set {
        gameBuffInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_version_id" field.</summary>
    public const int RogueVersionIdFieldNumber = 439;
    private uint rogueVersionId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RogueVersionId {
      get { return rogueVersionId_; }
      set {
        rogueVersionId_ = value;
      }
    }

    /// <summary>Field number for the "GGKEKEAFOPK" field.</summary>
    public const int GGKEKEAFOPKFieldNumber = 1;
    private uint gGKEKEAFOPK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GGKEKEAFOPK {
      get { return gGKEKEAFOPK_; }
      set {
        gGKEKEAFOPK_ = value;
      }
    }

    /// <summary>Field number for the "LKJMIEAKDGB" field.</summary>
    public const int LKJMIEAKDGBFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.ItemList lKJMIEAKDGB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList LKJMIEAKDGB {
      get { return lKJMIEAKDGB_; }
      set {
        lKJMIEAKDGB_ = value;
      }
    }

    /// <summary>Field number for the "MIDHHLKHCHF" field.</summary>
    public const int MIDHHLKHCHFFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.LineupInfo mIDHHLKHCHF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.LineupInfo MIDHHLKHCHF {
      get { return mIDHHLKHCHF_; }
      set {
        mIDHHLKHCHF_ = value;
      }
    }

    /// <summary>Field number for the "BAADIIGGNMF" field.</summary>
    public const int BAADIIGGNMFFieldNumber = 15;
    private uint bAADIIGGNMF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BAADIIGGNMF {
      get { return bAADIIGGNMF_; }
      set {
        bAADIIGGNMF_ = value;
      }
    }

    /// <summary>Field number for the "EAKHBEIMHPF" field.</summary>
    public const int EAKHBEIMHPFFieldNumber = 11;
    private uint eAKHBEIMHPF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EAKHBEIMHPF {
      get { return eAKHBEIMHPF_; }
      set {
        eAKHBEIMHPF_ = value;
      }
    }

    /// <summary>Field number for the "EGNDNIKNIIP" field.</summary>
    public const int EGNDNIKNIIPFieldNumber = 4;
    private uint eGNDNIKNIIP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EGNDNIKNIIP {
      get { return eGNDNIKNIIP_; }
      set {
        eGNDNIKNIIP_ = value;
      }
    }

    /// <summary>Field number for the "JMAFBLHFGPI" field.</summary>
    public const int JMAFBLHFGPIFieldNumber = 566;
    private uint jMAFBLHFGPI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JMAFBLHFGPI {
      get { return jMAFBLHFGPI_; }
      set {
        jMAFBLHFGPI_ = value;
      }
    }

    /// <summary>Field number for the "HNDPHBCIPHP" field.</summary>
    public const int HNDPHBCIPHPFieldNumber = 1397;
    private uint hNDPHBCIPHP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HNDPHBCIPHP {
      get { return hNDPHBCIPHP_; }
      set {
        hNDPHBCIPHP_ = value;
      }
    }

    /// <summary>Field number for the "DLOGLNDBIGN" field.</summary>
    public const int DLOGLNDBIGNFieldNumber = 6;
    private uint dLOGLNDBIGN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DLOGLNDBIGN {
      get { return dLOGLNDBIGN_; }
      set {
        dLOGLNDBIGN_ = value;
      }
    }

    /// <summary>Field number for the "game_miracle_info" field.</summary>
    public const int GameMiracleInfoFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.RogueMiracleEffect gameMiracleInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueMiracleEffect GameMiracleInfo {
      get { return gameMiracleInfo_; }
      set {
        gameMiracleInfo_ = value;
      }
    }

    /// <summary>Field number for the "BFMPOPLOPLF" field.</summary>
    public const int BFMPOPLOPLFFieldNumber = 295;
    private uint bFMPOPLOPLF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BFMPOPLOPLF {
      get { return bFMPOPLOPLF_; }
      set {
        bFMPOPLOPLF_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueExploreFinishInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueExploreFinishInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsFinish != other.IsFinish) return false;
      if (!object.Equals(StoryInfo, other.StoryInfo)) return false;
      if (DFFHONCDAGB != other.DFFHONCDAGB) return false;
      if(!mPAMLCADHFM_.Equals(other.mPAMLCADHFM_)) return false;
      if (IOFEJOECPKP != other.IOFEJOECPKP) return false;
      if (ScoreId != other.ScoreId) return false;
      if (!object.Equals(GameBuffInfo, other.GameBuffInfo)) return false;
      if (RogueVersionId != other.RogueVersionId) return false;
      if (GGKEKEAFOPK != other.GGKEKEAFOPK) return false;
      if (!object.Equals(LKJMIEAKDGB, other.LKJMIEAKDGB)) return false;
      if (!object.Equals(MIDHHLKHCHF, other.MIDHHLKHCHF)) return false;
      if (BAADIIGGNMF != other.BAADIIGGNMF) return false;
      if (EAKHBEIMHPF != other.EAKHBEIMHPF) return false;
      if (EGNDNIKNIIP != other.EGNDNIKNIIP) return false;
      if (JMAFBLHFGPI != other.JMAFBLHFGPI) return false;
      if (HNDPHBCIPHP != other.HNDPHBCIPHP) return false;
      if (DLOGLNDBIGN != other.DLOGLNDBIGN) return false;
      if (!object.Equals(GameMiracleInfo, other.GameMiracleInfo)) return false;
      if (BFMPOPLOPLF != other.BFMPOPLOPLF) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsFinish != false) hash ^= IsFinish.GetHashCode();
      if (storyInfo_ != null) hash ^= StoryInfo.GetHashCode();
      if (DFFHONCDAGB != global::EggLink.DanhengServer.Proto.ChessRogueAccountByStatus.ChessRogueAccountByNone) hash ^= DFFHONCDAGB.GetHashCode();
      hash ^= mPAMLCADHFM_.GetHashCode();
      if (IOFEJOECPKP != 0) hash ^= IOFEJOECPKP.GetHashCode();
      if (ScoreId != 0) hash ^= ScoreId.GetHashCode();
      if (gameBuffInfo_ != null) hash ^= GameBuffInfo.GetHashCode();
      if (RogueVersionId != 0) hash ^= RogueVersionId.GetHashCode();
      if (GGKEKEAFOPK != 0) hash ^= GGKEKEAFOPK.GetHashCode();
      if (lKJMIEAKDGB_ != null) hash ^= LKJMIEAKDGB.GetHashCode();
      if (mIDHHLKHCHF_ != null) hash ^= MIDHHLKHCHF.GetHashCode();
      if (BAADIIGGNMF != 0) hash ^= BAADIIGGNMF.GetHashCode();
      if (EAKHBEIMHPF != 0) hash ^= EAKHBEIMHPF.GetHashCode();
      if (EGNDNIKNIIP != 0) hash ^= EGNDNIKNIIP.GetHashCode();
      if (JMAFBLHFGPI != 0) hash ^= JMAFBLHFGPI.GetHashCode();
      if (HNDPHBCIPHP != 0) hash ^= HNDPHBCIPHP.GetHashCode();
      if (DLOGLNDBIGN != 0) hash ^= DLOGLNDBIGN.GetHashCode();
      if (gameMiracleInfo_ != null) hash ^= GameMiracleInfo.GetHashCode();
      if (BFMPOPLOPLF != 0) hash ^= BFMPOPLOPLF.GetHashCode();
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
      if (GGKEKEAFOPK != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GGKEKEAFOPK);
      }
      mPAMLCADHFM_.WriteTo(output, _repeated_mPAMLCADHFM_codec);
      if (EGNDNIKNIIP != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(EGNDNIKNIIP);
      }
      if (DFFHONCDAGB != global::EggLink.DanhengServer.Proto.ChessRogueAccountByStatus.ChessRogueAccountByNone) {
        output.WriteRawTag(40);
        output.WriteEnum((int) DFFHONCDAGB);
      }
      if (DLOGLNDBIGN != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(DLOGLNDBIGN);
      }
      if (gameBuffInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(GameBuffInfo);
      }
      if (IsFinish != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsFinish);
      }
      if (gameMiracleInfo_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(GameMiracleInfo);
      }
      if (EAKHBEIMHPF != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(EAKHBEIMHPF);
      }
      if (mIDHHLKHCHF_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(MIDHHLKHCHF);
      }
      if (lKJMIEAKDGB_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(LKJMIEAKDGB);
      }
      if (IOFEJOECPKP != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(IOFEJOECPKP);
      }
      if (BAADIIGGNMF != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(BAADIIGGNMF);
      }
      if (BFMPOPLOPLF != 0) {
        output.WriteRawTag(184, 18);
        output.WriteUInt32(BFMPOPLOPLF);
      }
      if (RogueVersionId != 0) {
        output.WriteRawTag(184, 27);
        output.WriteUInt32(RogueVersionId);
      }
      if (JMAFBLHFGPI != 0) {
        output.WriteRawTag(176, 35);
        output.WriteUInt32(JMAFBLHFGPI);
      }
      if (storyInfo_ != null) {
        output.WriteRawTag(210, 45);
        output.WriteMessage(StoryInfo);
      }
      if (ScoreId != 0) {
        output.WriteRawTag(136, 75);
        output.WriteUInt32(ScoreId);
      }
      if (HNDPHBCIPHP != 0) {
        output.WriteRawTag(168, 87);
        output.WriteUInt32(HNDPHBCIPHP);
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
      if (GGKEKEAFOPK != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GGKEKEAFOPK);
      }
      mPAMLCADHFM_.WriteTo(ref output, _repeated_mPAMLCADHFM_codec);
      if (EGNDNIKNIIP != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(EGNDNIKNIIP);
      }
      if (DFFHONCDAGB != global::EggLink.DanhengServer.Proto.ChessRogueAccountByStatus.ChessRogueAccountByNone) {
        output.WriteRawTag(40);
        output.WriteEnum((int) DFFHONCDAGB);
      }
      if (DLOGLNDBIGN != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(DLOGLNDBIGN);
      }
      if (gameBuffInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(GameBuffInfo);
      }
      if (IsFinish != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsFinish);
      }
      if (gameMiracleInfo_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(GameMiracleInfo);
      }
      if (EAKHBEIMHPF != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(EAKHBEIMHPF);
      }
      if (mIDHHLKHCHF_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(MIDHHLKHCHF);
      }
      if (lKJMIEAKDGB_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(LKJMIEAKDGB);
      }
      if (IOFEJOECPKP != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(IOFEJOECPKP);
      }
      if (BAADIIGGNMF != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(BAADIIGGNMF);
      }
      if (BFMPOPLOPLF != 0) {
        output.WriteRawTag(184, 18);
        output.WriteUInt32(BFMPOPLOPLF);
      }
      if (RogueVersionId != 0) {
        output.WriteRawTag(184, 27);
        output.WriteUInt32(RogueVersionId);
      }
      if (JMAFBLHFGPI != 0) {
        output.WriteRawTag(176, 35);
        output.WriteUInt32(JMAFBLHFGPI);
      }
      if (storyInfo_ != null) {
        output.WriteRawTag(210, 45);
        output.WriteMessage(StoryInfo);
      }
      if (ScoreId != 0) {
        output.WriteRawTag(136, 75);
        output.WriteUInt32(ScoreId);
      }
      if (HNDPHBCIPHP != 0) {
        output.WriteRawTag(168, 87);
        output.WriteUInt32(HNDPHBCIPHP);
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
      if (IsFinish != false) {
        size += 1 + 1;
      }
      if (storyInfo_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(StoryInfo);
      }
      if (DFFHONCDAGB != global::EggLink.DanhengServer.Proto.ChessRogueAccountByStatus.ChessRogueAccountByNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DFFHONCDAGB);
      }
      size += mPAMLCADHFM_.CalculateSize(_repeated_mPAMLCADHFM_codec);
      if (IOFEJOECPKP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IOFEJOECPKP);
      }
      if (ScoreId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(ScoreId);
      }
      if (gameBuffInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GameBuffInfo);
      }
      if (RogueVersionId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(RogueVersionId);
      }
      if (GGKEKEAFOPK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GGKEKEAFOPK);
      }
      if (lKJMIEAKDGB_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LKJMIEAKDGB);
      }
      if (mIDHHLKHCHF_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MIDHHLKHCHF);
      }
      if (BAADIIGGNMF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BAADIIGGNMF);
      }
      if (EAKHBEIMHPF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EAKHBEIMHPF);
      }
      if (EGNDNIKNIIP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EGNDNIKNIIP);
      }
      if (JMAFBLHFGPI != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(JMAFBLHFGPI);
      }
      if (HNDPHBCIPHP != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(HNDPHBCIPHP);
      }
      if (DLOGLNDBIGN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DLOGLNDBIGN);
      }
      if (gameMiracleInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GameMiracleInfo);
      }
      if (BFMPOPLOPLF != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(BFMPOPLOPLF);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueExploreFinishInfo other) {
      if (other == null) {
        return;
      }
      if (other.IsFinish != false) {
        IsFinish = other.IsFinish;
      }
      if (other.storyInfo_ != null) {
        if (storyInfo_ == null) {
          StoryInfo = new global::EggLink.DanhengServer.Proto.ChessRogueStoryInfo();
        }
        StoryInfo.MergeFrom(other.StoryInfo);
      }
      if (other.DFFHONCDAGB != global::EggLink.DanhengServer.Proto.ChessRogueAccountByStatus.ChessRogueAccountByNone) {
        DFFHONCDAGB = other.DFFHONCDAGB;
      }
      mPAMLCADHFM_.Add(other.mPAMLCADHFM_);
      if (other.IOFEJOECPKP != 0) {
        IOFEJOECPKP = other.IOFEJOECPKP;
      }
      if (other.ScoreId != 0) {
        ScoreId = other.ScoreId;
      }
      if (other.gameBuffInfo_ != null) {
        if (gameBuffInfo_ == null) {
          GameBuffInfo = new global::EggLink.DanhengServer.Proto.RogueBuffInfo();
        }
        GameBuffInfo.MergeFrom(other.GameBuffInfo);
      }
      if (other.RogueVersionId != 0) {
        RogueVersionId = other.RogueVersionId;
      }
      if (other.GGKEKEAFOPK != 0) {
        GGKEKEAFOPK = other.GGKEKEAFOPK;
      }
      if (other.lKJMIEAKDGB_ != null) {
        if (lKJMIEAKDGB_ == null) {
          LKJMIEAKDGB = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        LKJMIEAKDGB.MergeFrom(other.LKJMIEAKDGB);
      }
      if (other.mIDHHLKHCHF_ != null) {
        if (mIDHHLKHCHF_ == null) {
          MIDHHLKHCHF = new global::EggLink.DanhengServer.Proto.LineupInfo();
        }
        MIDHHLKHCHF.MergeFrom(other.MIDHHLKHCHF);
      }
      if (other.BAADIIGGNMF != 0) {
        BAADIIGGNMF = other.BAADIIGGNMF;
      }
      if (other.EAKHBEIMHPF != 0) {
        EAKHBEIMHPF = other.EAKHBEIMHPF;
      }
      if (other.EGNDNIKNIIP != 0) {
        EGNDNIKNIIP = other.EGNDNIKNIIP;
      }
      if (other.JMAFBLHFGPI != 0) {
        JMAFBLHFGPI = other.JMAFBLHFGPI;
      }
      if (other.HNDPHBCIPHP != 0) {
        HNDPHBCIPHP = other.HNDPHBCIPHP;
      }
      if (other.DLOGLNDBIGN != 0) {
        DLOGLNDBIGN = other.DLOGLNDBIGN;
      }
      if (other.gameMiracleInfo_ != null) {
        if (gameMiracleInfo_ == null) {
          GameMiracleInfo = new global::EggLink.DanhengServer.Proto.RogueMiracleEffect();
        }
        GameMiracleInfo.MergeFrom(other.GameMiracleInfo);
      }
      if (other.BFMPOPLOPLF != 0) {
        BFMPOPLOPLF = other.BFMPOPLOPLF;
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
            GGKEKEAFOPK = input.ReadUInt32();
            break;
          }
          case 18:
          case 16: {
            mPAMLCADHFM_.AddEntriesFrom(input, _repeated_mPAMLCADHFM_codec);
            break;
          }
          case 32: {
            EGNDNIKNIIP = input.ReadUInt32();
            break;
          }
          case 40: {
            DFFHONCDAGB = (global::EggLink.DanhengServer.Proto.ChessRogueAccountByStatus) input.ReadEnum();
            break;
          }
          case 48: {
            DLOGLNDBIGN = input.ReadUInt32();
            break;
          }
          case 66: {
            if (gameBuffInfo_ == null) {
              GameBuffInfo = new global::EggLink.DanhengServer.Proto.RogueBuffInfo();
            }
            input.ReadMessage(GameBuffInfo);
            break;
          }
          case 72: {
            IsFinish = input.ReadBool();
            break;
          }
          case 82: {
            if (gameMiracleInfo_ == null) {
              GameMiracleInfo = new global::EggLink.DanhengServer.Proto.RogueMiracleEffect();
            }
            input.ReadMessage(GameMiracleInfo);
            break;
          }
          case 88: {
            EAKHBEIMHPF = input.ReadUInt32();
            break;
          }
          case 98: {
            if (mIDHHLKHCHF_ == null) {
              MIDHHLKHCHF = new global::EggLink.DanhengServer.Proto.LineupInfo();
            }
            input.ReadMessage(MIDHHLKHCHF);
            break;
          }
          case 106: {
            if (lKJMIEAKDGB_ == null) {
              LKJMIEAKDGB = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(LKJMIEAKDGB);
            break;
          }
          case 112: {
            IOFEJOECPKP = input.ReadUInt32();
            break;
          }
          case 120: {
            BAADIIGGNMF = input.ReadUInt32();
            break;
          }
          case 2360: {
            BFMPOPLOPLF = input.ReadUInt32();
            break;
          }
          case 3512: {
            RogueVersionId = input.ReadUInt32();
            break;
          }
          case 4528: {
            JMAFBLHFGPI = input.ReadUInt32();
            break;
          }
          case 5842: {
            if (storyInfo_ == null) {
              StoryInfo = new global::EggLink.DanhengServer.Proto.ChessRogueStoryInfo();
            }
            input.ReadMessage(StoryInfo);
            break;
          }
          case 9608: {
            ScoreId = input.ReadUInt32();
            break;
          }
          case 11176: {
            HNDPHBCIPHP = input.ReadUInt32();
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
            GGKEKEAFOPK = input.ReadUInt32();
            break;
          }
          case 18:
          case 16: {
            mPAMLCADHFM_.AddEntriesFrom(ref input, _repeated_mPAMLCADHFM_codec);
            break;
          }
          case 32: {
            EGNDNIKNIIP = input.ReadUInt32();
            break;
          }
          case 40: {
            DFFHONCDAGB = (global::EggLink.DanhengServer.Proto.ChessRogueAccountByStatus) input.ReadEnum();
            break;
          }
          case 48: {
            DLOGLNDBIGN = input.ReadUInt32();
            break;
          }
          case 66: {
            if (gameBuffInfo_ == null) {
              GameBuffInfo = new global::EggLink.DanhengServer.Proto.RogueBuffInfo();
            }
            input.ReadMessage(GameBuffInfo);
            break;
          }
          case 72: {
            IsFinish = input.ReadBool();
            break;
          }
          case 82: {
            if (gameMiracleInfo_ == null) {
              GameMiracleInfo = new global::EggLink.DanhengServer.Proto.RogueMiracleEffect();
            }
            input.ReadMessage(GameMiracleInfo);
            break;
          }
          case 88: {
            EAKHBEIMHPF = input.ReadUInt32();
            break;
          }
          case 98: {
            if (mIDHHLKHCHF_ == null) {
              MIDHHLKHCHF = new global::EggLink.DanhengServer.Proto.LineupInfo();
            }
            input.ReadMessage(MIDHHLKHCHF);
            break;
          }
          case 106: {
            if (lKJMIEAKDGB_ == null) {
              LKJMIEAKDGB = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(LKJMIEAKDGB);
            break;
          }
          case 112: {
            IOFEJOECPKP = input.ReadUInt32();
            break;
          }
          case 120: {
            BAADIIGGNMF = input.ReadUInt32();
            break;
          }
          case 2360: {
            BFMPOPLOPLF = input.ReadUInt32();
            break;
          }
          case 3512: {
            RogueVersionId = input.ReadUInt32();
            break;
          }
          case 4528: {
            JMAFBLHFGPI = input.ReadUInt32();
            break;
          }
          case 5842: {
            if (storyInfo_ == null) {
              StoryInfo = new global::EggLink.DanhengServer.Proto.ChessRogueStoryInfo();
            }
            input.ReadMessage(StoryInfo);
            break;
          }
          case 9608: {
            ScoreId = input.ReadUInt32();
            break;
          }
          case 11176: {
            HNDPHBCIPHP = input.ReadUInt32();
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
