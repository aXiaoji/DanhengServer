// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueFinishInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueFinishInfo.proto</summary>
  public static partial class RogueFinishInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueFinishInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueFinishInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVSb2d1ZUZpbmlzaEluZm8ucHJvdG8aG1JvZ3VlRXhwbG9yZVNjb3JlSW5m",
            "by5wcm90bxoaUm9ndWVTY29yZVJld2FyZEluZm8ucHJvdG8aEUpKR0ZHREtH",
            "UEVFLnByb3RvGg5JdGVtTGlzdC5wcm90bxoXUm9ndWVSZWNvcmRBdmF0YXIu",
            "cHJvdG8i+QMKD1JvZ3VlRmluaXNoSW5mbxIqCgtFR05KSkRBSkJOTxgLIAEo",
            "CzIVLlJvZ3VlU2NvcmVSZXdhcmRJbmZvEhAKB2FyZWFfaWQYoAkgASgNEioK",
            "CnNjb3JlX2luZm8YDSABKAsyFi5Sb2d1ZUV4cGxvcmVTY29yZUluZm8SFAoL",
            "Q0FNQk1QQkNBQ1AYqgUgASgNEioKC1BKTE1NUE9EQUxQGAwgASgLMhUuUm9n",
            "dWVTY29yZVJld2FyZEluZm8SHgoLRk9OQ0pQS0ZQSUIYBSABKAsyCS5JdGVt",
            "TGlzdBIhCgtOQUlBSkFGSUdMThgGIAEoCzIMLkpKR0ZHREtHUEVFEh4KC0FL",
            "RkpISE9KTUpEGAIgASgLMgkuSXRlbUxpc3QSEwoLQklMQkVPS1BITEYYAyAB",
            "KA0SEAoIc2NvcmVfaWQYASABKA0SEwoLSE1IQkpMRFBDSUwYCCABKAgSEwoL",
            "RE5IQ0xBQ09GSUwYDyABKAgSEwoLSUVFQ0NBSkdGSUYYDiABKA0SJwoLcmVj",
            "b3JkX2luZm8YCSABKAsyEi5Sb2d1ZVJlY29yZEF2YXRhchITCgtOTE5CRkdD",
            "S1BHSRgKIAEoDRITCgtPS0dPRkRETkpGRRgEIAEoDRIeCgtJRkJOT0FCTU5P",
            "RRgHIAEoCzIJLkl0ZW1MaXN0Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu",
            "UHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueExploreScoreInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueScoreRewardInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.JJGFGDKGPEEReflection.Descriptor, global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueRecordAvatarReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueFinishInfo), global::EggLink.DanhengServer.Proto.RogueFinishInfo.Parser, new[]{ "EGNJJDAJBNO", "AreaId", "ScoreInfo", "CAMBMPBCACP", "PJLMMPODALP", "FONCJPKFPIB", "NAIAJAFIGLN", "AKFJHHOJMJD", "BILBEOKPHLF", "ScoreId", "HMHBJLDPCIL", "DNHCLACOFIL", "IEECCAJGFIF", "RecordInfo", "NLNBFGCKPGI", "OKGOFDDNJFE", "IFBNOABMNOE" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueFinishInfo : pb::IMessage<RogueFinishInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueFinishInfo> _parser = new pb::MessageParser<RogueFinishInfo>(() => new RogueFinishInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueFinishInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueFinishInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueFinishInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueFinishInfo(RogueFinishInfo other) : this() {
      eGNJJDAJBNO_ = other.eGNJJDAJBNO_ != null ? other.eGNJJDAJBNO_.Clone() : null;
      areaId_ = other.areaId_;
      scoreInfo_ = other.scoreInfo_ != null ? other.scoreInfo_.Clone() : null;
      cAMBMPBCACP_ = other.cAMBMPBCACP_;
      pJLMMPODALP_ = other.pJLMMPODALP_ != null ? other.pJLMMPODALP_.Clone() : null;
      fONCJPKFPIB_ = other.fONCJPKFPIB_ != null ? other.fONCJPKFPIB_.Clone() : null;
      nAIAJAFIGLN_ = other.nAIAJAFIGLN_ != null ? other.nAIAJAFIGLN_.Clone() : null;
      aKFJHHOJMJD_ = other.aKFJHHOJMJD_ != null ? other.aKFJHHOJMJD_.Clone() : null;
      bILBEOKPHLF_ = other.bILBEOKPHLF_;
      scoreId_ = other.scoreId_;
      hMHBJLDPCIL_ = other.hMHBJLDPCIL_;
      dNHCLACOFIL_ = other.dNHCLACOFIL_;
      iEECCAJGFIF_ = other.iEECCAJGFIF_;
      recordInfo_ = other.recordInfo_ != null ? other.recordInfo_.Clone() : null;
      nLNBFGCKPGI_ = other.nLNBFGCKPGI_;
      oKGOFDDNJFE_ = other.oKGOFDDNJFE_;
      iFBNOABMNOE_ = other.iFBNOABMNOE_ != null ? other.iFBNOABMNOE_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueFinishInfo Clone() {
      return new RogueFinishInfo(this);
    }

    /// <summary>Field number for the "EGNJJDAJBNO" field.</summary>
    public const int EGNJJDAJBNOFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo eGNJJDAJBNO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo EGNJJDAJBNO {
      get { return eGNJJDAJBNO_; }
      set {
        eGNJJDAJBNO_ = value;
      }
    }

    /// <summary>Field number for the "area_id" field.</summary>
    public const int AreaIdFieldNumber = 1184;
    private uint areaId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AreaId {
      get { return areaId_; }
      set {
        areaId_ = value;
      }
    }

    /// <summary>Field number for the "score_info" field.</summary>
    public const int ScoreInfoFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.RogueExploreScoreInfo scoreInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueExploreScoreInfo ScoreInfo {
      get { return scoreInfo_; }
      set {
        scoreInfo_ = value;
      }
    }

    /// <summary>Field number for the "CAMBMPBCACP" field.</summary>
    public const int CAMBMPBCACPFieldNumber = 682;
    private uint cAMBMPBCACP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CAMBMPBCACP {
      get { return cAMBMPBCACP_; }
      set {
        cAMBMPBCACP_ = value;
      }
    }

    /// <summary>Field number for the "PJLMMPODALP" field.</summary>
    public const int PJLMMPODALPFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo pJLMMPODALP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo PJLMMPODALP {
      get { return pJLMMPODALP_; }
      set {
        pJLMMPODALP_ = value;
      }
    }

    /// <summary>Field number for the "FONCJPKFPIB" field.</summary>
    public const int FONCJPKFPIBFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.ItemList fONCJPKFPIB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList FONCJPKFPIB {
      get { return fONCJPKFPIB_; }
      set {
        fONCJPKFPIB_ = value;
      }
    }

    /// <summary>Field number for the "NAIAJAFIGLN" field.</summary>
    public const int NAIAJAFIGLNFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.JJGFGDKGPEE nAIAJAFIGLN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.JJGFGDKGPEE NAIAJAFIGLN {
      get { return nAIAJAFIGLN_; }
      set {
        nAIAJAFIGLN_ = value;
      }
    }

    /// <summary>Field number for the "AKFJHHOJMJD" field.</summary>
    public const int AKFJHHOJMJDFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.ItemList aKFJHHOJMJD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList AKFJHHOJMJD {
      get { return aKFJHHOJMJD_; }
      set {
        aKFJHHOJMJD_ = value;
      }
    }

    /// <summary>Field number for the "BILBEOKPHLF" field.</summary>
    public const int BILBEOKPHLFFieldNumber = 3;
    private uint bILBEOKPHLF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BILBEOKPHLF {
      get { return bILBEOKPHLF_; }
      set {
        bILBEOKPHLF_ = value;
      }
    }

    /// <summary>Field number for the "score_id" field.</summary>
    public const int ScoreIdFieldNumber = 1;
    private uint scoreId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ScoreId {
      get { return scoreId_; }
      set {
        scoreId_ = value;
      }
    }

    /// <summary>Field number for the "HMHBJLDPCIL" field.</summary>
    public const int HMHBJLDPCILFieldNumber = 8;
    private bool hMHBJLDPCIL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HMHBJLDPCIL {
      get { return hMHBJLDPCIL_; }
      set {
        hMHBJLDPCIL_ = value;
      }
    }

    /// <summary>Field number for the "DNHCLACOFIL" field.</summary>
    public const int DNHCLACOFILFieldNumber = 15;
    private bool dNHCLACOFIL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool DNHCLACOFIL {
      get { return dNHCLACOFIL_; }
      set {
        dNHCLACOFIL_ = value;
      }
    }

    /// <summary>Field number for the "IEECCAJGFIF" field.</summary>
    public const int IEECCAJGFIFFieldNumber = 14;
    private uint iEECCAJGFIF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IEECCAJGFIF {
      get { return iEECCAJGFIF_; }
      set {
        iEECCAJGFIF_ = value;
      }
    }

    /// <summary>Field number for the "record_info" field.</summary>
    public const int RecordInfoFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.RogueRecordAvatar recordInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueRecordAvatar RecordInfo {
      get { return recordInfo_; }
      set {
        recordInfo_ = value;
      }
    }

    /// <summary>Field number for the "NLNBFGCKPGI" field.</summary>
    public const int NLNBFGCKPGIFieldNumber = 10;
    private uint nLNBFGCKPGI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NLNBFGCKPGI {
      get { return nLNBFGCKPGI_; }
      set {
        nLNBFGCKPGI_ = value;
      }
    }

    /// <summary>Field number for the "OKGOFDDNJFE" field.</summary>
    public const int OKGOFDDNJFEFieldNumber = 4;
    private uint oKGOFDDNJFE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OKGOFDDNJFE {
      get { return oKGOFDDNJFE_; }
      set {
        oKGOFDDNJFE_ = value;
      }
    }

    /// <summary>Field number for the "IFBNOABMNOE" field.</summary>
    public const int IFBNOABMNOEFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.ItemList iFBNOABMNOE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList IFBNOABMNOE {
      get { return iFBNOABMNOE_; }
      set {
        iFBNOABMNOE_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueFinishInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueFinishInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(EGNJJDAJBNO, other.EGNJJDAJBNO)) return false;
      if (AreaId != other.AreaId) return false;
      if (!object.Equals(ScoreInfo, other.ScoreInfo)) return false;
      if (CAMBMPBCACP != other.CAMBMPBCACP) return false;
      if (!object.Equals(PJLMMPODALP, other.PJLMMPODALP)) return false;
      if (!object.Equals(FONCJPKFPIB, other.FONCJPKFPIB)) return false;
      if (!object.Equals(NAIAJAFIGLN, other.NAIAJAFIGLN)) return false;
      if (!object.Equals(AKFJHHOJMJD, other.AKFJHHOJMJD)) return false;
      if (BILBEOKPHLF != other.BILBEOKPHLF) return false;
      if (ScoreId != other.ScoreId) return false;
      if (HMHBJLDPCIL != other.HMHBJLDPCIL) return false;
      if (DNHCLACOFIL != other.DNHCLACOFIL) return false;
      if (IEECCAJGFIF != other.IEECCAJGFIF) return false;
      if (!object.Equals(RecordInfo, other.RecordInfo)) return false;
      if (NLNBFGCKPGI != other.NLNBFGCKPGI) return false;
      if (OKGOFDDNJFE != other.OKGOFDDNJFE) return false;
      if (!object.Equals(IFBNOABMNOE, other.IFBNOABMNOE)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (eGNJJDAJBNO_ != null) hash ^= EGNJJDAJBNO.GetHashCode();
      if (AreaId != 0) hash ^= AreaId.GetHashCode();
      if (scoreInfo_ != null) hash ^= ScoreInfo.GetHashCode();
      if (CAMBMPBCACP != 0) hash ^= CAMBMPBCACP.GetHashCode();
      if (pJLMMPODALP_ != null) hash ^= PJLMMPODALP.GetHashCode();
      if (fONCJPKFPIB_ != null) hash ^= FONCJPKFPIB.GetHashCode();
      if (nAIAJAFIGLN_ != null) hash ^= NAIAJAFIGLN.GetHashCode();
      if (aKFJHHOJMJD_ != null) hash ^= AKFJHHOJMJD.GetHashCode();
      if (BILBEOKPHLF != 0) hash ^= BILBEOKPHLF.GetHashCode();
      if (ScoreId != 0) hash ^= ScoreId.GetHashCode();
      if (HMHBJLDPCIL != false) hash ^= HMHBJLDPCIL.GetHashCode();
      if (DNHCLACOFIL != false) hash ^= DNHCLACOFIL.GetHashCode();
      if (IEECCAJGFIF != 0) hash ^= IEECCAJGFIF.GetHashCode();
      if (recordInfo_ != null) hash ^= RecordInfo.GetHashCode();
      if (NLNBFGCKPGI != 0) hash ^= NLNBFGCKPGI.GetHashCode();
      if (OKGOFDDNJFE != 0) hash ^= OKGOFDDNJFE.GetHashCode();
      if (iFBNOABMNOE_ != null) hash ^= IFBNOABMNOE.GetHashCode();
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
      if (ScoreId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ScoreId);
      }
      if (aKFJHHOJMJD_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AKFJHHOJMJD);
      }
      if (BILBEOKPHLF != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(BILBEOKPHLF);
      }
      if (OKGOFDDNJFE != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(OKGOFDDNJFE);
      }
      if (fONCJPKFPIB_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(FONCJPKFPIB);
      }
      if (nAIAJAFIGLN_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(NAIAJAFIGLN);
      }
      if (iFBNOABMNOE_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(IFBNOABMNOE);
      }
      if (HMHBJLDPCIL != false) {
        output.WriteRawTag(64);
        output.WriteBool(HMHBJLDPCIL);
      }
      if (recordInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(RecordInfo);
      }
      if (NLNBFGCKPGI != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(NLNBFGCKPGI);
      }
      if (eGNJJDAJBNO_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(EGNJJDAJBNO);
      }
      if (pJLMMPODALP_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(PJLMMPODALP);
      }
      if (scoreInfo_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(ScoreInfo);
      }
      if (IEECCAJGFIF != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(IEECCAJGFIF);
      }
      if (DNHCLACOFIL != false) {
        output.WriteRawTag(120);
        output.WriteBool(DNHCLACOFIL);
      }
      if (CAMBMPBCACP != 0) {
        output.WriteRawTag(208, 42);
        output.WriteUInt32(CAMBMPBCACP);
      }
      if (AreaId != 0) {
        output.WriteRawTag(128, 74);
        output.WriteUInt32(AreaId);
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
      if (ScoreId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ScoreId);
      }
      if (aKFJHHOJMJD_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AKFJHHOJMJD);
      }
      if (BILBEOKPHLF != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(BILBEOKPHLF);
      }
      if (OKGOFDDNJFE != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(OKGOFDDNJFE);
      }
      if (fONCJPKFPIB_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(FONCJPKFPIB);
      }
      if (nAIAJAFIGLN_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(NAIAJAFIGLN);
      }
      if (iFBNOABMNOE_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(IFBNOABMNOE);
      }
      if (HMHBJLDPCIL != false) {
        output.WriteRawTag(64);
        output.WriteBool(HMHBJLDPCIL);
      }
      if (recordInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(RecordInfo);
      }
      if (NLNBFGCKPGI != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(NLNBFGCKPGI);
      }
      if (eGNJJDAJBNO_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(EGNJJDAJBNO);
      }
      if (pJLMMPODALP_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(PJLMMPODALP);
      }
      if (scoreInfo_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(ScoreInfo);
      }
      if (IEECCAJGFIF != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(IEECCAJGFIF);
      }
      if (DNHCLACOFIL != false) {
        output.WriteRawTag(120);
        output.WriteBool(DNHCLACOFIL);
      }
      if (CAMBMPBCACP != 0) {
        output.WriteRawTag(208, 42);
        output.WriteUInt32(CAMBMPBCACP);
      }
      if (AreaId != 0) {
        output.WriteRawTag(128, 74);
        output.WriteUInt32(AreaId);
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
      if (eGNJJDAJBNO_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EGNJJDAJBNO);
      }
      if (AreaId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(AreaId);
      }
      if (scoreInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ScoreInfo);
      }
      if (CAMBMPBCACP != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(CAMBMPBCACP);
      }
      if (pJLMMPODALP_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PJLMMPODALP);
      }
      if (fONCJPKFPIB_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FONCJPKFPIB);
      }
      if (nAIAJAFIGLN_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(NAIAJAFIGLN);
      }
      if (aKFJHHOJMJD_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AKFJHHOJMJD);
      }
      if (BILBEOKPHLF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BILBEOKPHLF);
      }
      if (ScoreId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ScoreId);
      }
      if (HMHBJLDPCIL != false) {
        size += 1 + 1;
      }
      if (DNHCLACOFIL != false) {
        size += 1 + 1;
      }
      if (IEECCAJGFIF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IEECCAJGFIF);
      }
      if (recordInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RecordInfo);
      }
      if (NLNBFGCKPGI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NLNBFGCKPGI);
      }
      if (OKGOFDDNJFE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OKGOFDDNJFE);
      }
      if (iFBNOABMNOE_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(IFBNOABMNOE);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueFinishInfo other) {
      if (other == null) {
        return;
      }
      if (other.eGNJJDAJBNO_ != null) {
        if (eGNJJDAJBNO_ == null) {
          EGNJJDAJBNO = new global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo();
        }
        EGNJJDAJBNO.MergeFrom(other.EGNJJDAJBNO);
      }
      if (other.AreaId != 0) {
        AreaId = other.AreaId;
      }
      if (other.scoreInfo_ != null) {
        if (scoreInfo_ == null) {
          ScoreInfo = new global::EggLink.DanhengServer.Proto.RogueExploreScoreInfo();
        }
        ScoreInfo.MergeFrom(other.ScoreInfo);
      }
      if (other.CAMBMPBCACP != 0) {
        CAMBMPBCACP = other.CAMBMPBCACP;
      }
      if (other.pJLMMPODALP_ != null) {
        if (pJLMMPODALP_ == null) {
          PJLMMPODALP = new global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo();
        }
        PJLMMPODALP.MergeFrom(other.PJLMMPODALP);
      }
      if (other.fONCJPKFPIB_ != null) {
        if (fONCJPKFPIB_ == null) {
          FONCJPKFPIB = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        FONCJPKFPIB.MergeFrom(other.FONCJPKFPIB);
      }
      if (other.nAIAJAFIGLN_ != null) {
        if (nAIAJAFIGLN_ == null) {
          NAIAJAFIGLN = new global::EggLink.DanhengServer.Proto.JJGFGDKGPEE();
        }
        NAIAJAFIGLN.MergeFrom(other.NAIAJAFIGLN);
      }
      if (other.aKFJHHOJMJD_ != null) {
        if (aKFJHHOJMJD_ == null) {
          AKFJHHOJMJD = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        AKFJHHOJMJD.MergeFrom(other.AKFJHHOJMJD);
      }
      if (other.BILBEOKPHLF != 0) {
        BILBEOKPHLF = other.BILBEOKPHLF;
      }
      if (other.ScoreId != 0) {
        ScoreId = other.ScoreId;
      }
      if (other.HMHBJLDPCIL != false) {
        HMHBJLDPCIL = other.HMHBJLDPCIL;
      }
      if (other.DNHCLACOFIL != false) {
        DNHCLACOFIL = other.DNHCLACOFIL;
      }
      if (other.IEECCAJGFIF != 0) {
        IEECCAJGFIF = other.IEECCAJGFIF;
      }
      if (other.recordInfo_ != null) {
        if (recordInfo_ == null) {
          RecordInfo = new global::EggLink.DanhengServer.Proto.RogueRecordAvatar();
        }
        RecordInfo.MergeFrom(other.RecordInfo);
      }
      if (other.NLNBFGCKPGI != 0) {
        NLNBFGCKPGI = other.NLNBFGCKPGI;
      }
      if (other.OKGOFDDNJFE != 0) {
        OKGOFDDNJFE = other.OKGOFDDNJFE;
      }
      if (other.iFBNOABMNOE_ != null) {
        if (iFBNOABMNOE_ == null) {
          IFBNOABMNOE = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        IFBNOABMNOE.MergeFrom(other.IFBNOABMNOE);
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
            ScoreId = input.ReadUInt32();
            break;
          }
          case 18: {
            if (aKFJHHOJMJD_ == null) {
              AKFJHHOJMJD = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(AKFJHHOJMJD);
            break;
          }
          case 24: {
            BILBEOKPHLF = input.ReadUInt32();
            break;
          }
          case 32: {
            OKGOFDDNJFE = input.ReadUInt32();
            break;
          }
          case 42: {
            if (fONCJPKFPIB_ == null) {
              FONCJPKFPIB = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(FONCJPKFPIB);
            break;
          }
          case 50: {
            if (nAIAJAFIGLN_ == null) {
              NAIAJAFIGLN = new global::EggLink.DanhengServer.Proto.JJGFGDKGPEE();
            }
            input.ReadMessage(NAIAJAFIGLN);
            break;
          }
          case 58: {
            if (iFBNOABMNOE_ == null) {
              IFBNOABMNOE = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(IFBNOABMNOE);
            break;
          }
          case 64: {
            HMHBJLDPCIL = input.ReadBool();
            break;
          }
          case 74: {
            if (recordInfo_ == null) {
              RecordInfo = new global::EggLink.DanhengServer.Proto.RogueRecordAvatar();
            }
            input.ReadMessage(RecordInfo);
            break;
          }
          case 80: {
            NLNBFGCKPGI = input.ReadUInt32();
            break;
          }
          case 90: {
            if (eGNJJDAJBNO_ == null) {
              EGNJJDAJBNO = new global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo();
            }
            input.ReadMessage(EGNJJDAJBNO);
            break;
          }
          case 98: {
            if (pJLMMPODALP_ == null) {
              PJLMMPODALP = new global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo();
            }
            input.ReadMessage(PJLMMPODALP);
            break;
          }
          case 106: {
            if (scoreInfo_ == null) {
              ScoreInfo = new global::EggLink.DanhengServer.Proto.RogueExploreScoreInfo();
            }
            input.ReadMessage(ScoreInfo);
            break;
          }
          case 112: {
            IEECCAJGFIF = input.ReadUInt32();
            break;
          }
          case 120: {
            DNHCLACOFIL = input.ReadBool();
            break;
          }
          case 5456: {
            CAMBMPBCACP = input.ReadUInt32();
            break;
          }
          case 9472: {
            AreaId = input.ReadUInt32();
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
            ScoreId = input.ReadUInt32();
            break;
          }
          case 18: {
            if (aKFJHHOJMJD_ == null) {
              AKFJHHOJMJD = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(AKFJHHOJMJD);
            break;
          }
          case 24: {
            BILBEOKPHLF = input.ReadUInt32();
            break;
          }
          case 32: {
            OKGOFDDNJFE = input.ReadUInt32();
            break;
          }
          case 42: {
            if (fONCJPKFPIB_ == null) {
              FONCJPKFPIB = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(FONCJPKFPIB);
            break;
          }
          case 50: {
            if (nAIAJAFIGLN_ == null) {
              NAIAJAFIGLN = new global::EggLink.DanhengServer.Proto.JJGFGDKGPEE();
            }
            input.ReadMessage(NAIAJAFIGLN);
            break;
          }
          case 58: {
            if (iFBNOABMNOE_ == null) {
              IFBNOABMNOE = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(IFBNOABMNOE);
            break;
          }
          case 64: {
            HMHBJLDPCIL = input.ReadBool();
            break;
          }
          case 74: {
            if (recordInfo_ == null) {
              RecordInfo = new global::EggLink.DanhengServer.Proto.RogueRecordAvatar();
            }
            input.ReadMessage(RecordInfo);
            break;
          }
          case 80: {
            NLNBFGCKPGI = input.ReadUInt32();
            break;
          }
          case 90: {
            if (eGNJJDAJBNO_ == null) {
              EGNJJDAJBNO = new global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo();
            }
            input.ReadMessage(EGNJJDAJBNO);
            break;
          }
          case 98: {
            if (pJLMMPODALP_ == null) {
              PJLMMPODALP = new global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo();
            }
            input.ReadMessage(PJLMMPODALP);
            break;
          }
          case 106: {
            if (scoreInfo_ == null) {
              ScoreInfo = new global::EggLink.DanhengServer.Proto.RogueExploreScoreInfo();
            }
            input.ReadMessage(ScoreInfo);
            break;
          }
          case 112: {
            IEECCAJGFIF = input.ReadUInt32();
            break;
          }
          case 120: {
            DNHCLACOFIL = input.ReadBool();
            break;
          }
          case 5456: {
            CAMBMPBCACP = input.ReadUInt32();
            break;
          }
          case 9472: {
            AreaId = input.ReadUInt32();
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
