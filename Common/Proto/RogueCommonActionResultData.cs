// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueCommonActionResultData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueCommonActionResultData.proto</summary>
  public static partial class RogueCommonActionResultDataReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueCommonActionResultData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueCommonActionResultDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFSb2d1ZUNvbW1vbkFjdGlvblJlc3VsdERhdGEucHJvdG8aFlJvZ3VlRHJv",
            "cE1pcmFjbGUucHJvdG8aEURCRUJNUERKQkRJLnByb3RvGhFGSE9QSkJEQ0pQ",
            "Ti5wcm90bxoRSlBIQ0VBQ01FS0sucHJvdG8aEUhIS0tJR0lGS0FFLnByb3Rv",
            "GhNSb2d1ZURyb3BCdWZmLnByb3RvGhFMR0tQQkRNR0JQRS5wcm90bxoRR0JB",
            "SEdMSUdCQ0YucHJvdG8aEVBJSUlJSktGRkdKLnByb3RvIroDChtSb2d1ZUNv",
            "bW1vbkFjdGlvblJlc3VsdERhdGESIQoLQUhOTExJR0dQS0YYDCABKAsyDC5K",
            "UEhDRUFDTUVLSxIhCgtQT05DR09CTEhQQRgLIAEoCzIMLkpQSENFQUNNRUtL",
            "EiYKDWdldF9idWZmX2xpc3QY+AQgASgLMg4uUm9ndWVEcm9wQnVmZhInCg5s",
            "b3N0X2J1ZmZfbGlzdBiCBSABKAsyDi5Sb2d1ZURyb3BCdWZmEiwKEGdldF9t",
            "aXJhY2xlX2luZm8YxAMgASgLMhEuUm9ndWVEcm9wTWlyYWNsZRIiCgtDS0RB",
            "QkpESU1CThiFCCABKAsyDC5QSUlJSUpLRkZHShIiCgtMSUFGQ0JJUEVIRhia",
            "BSABKAsyDC5HQkFIR0xJR0JDRhIiCgtCSUVOS1BCSkdPRhjPDSABKAsyDC5M",
            "R0tQQkRNR0JQRRIiCgtPQVBMTkJORUJFShiGCCABKAsyDC5ISEtLSUdJRktB",
            "RRIiCgtHR0JBSUtERk9JSxjJBSABKAsyDC5EQkVCTVBESkJESRIiCgtNSkxD",
            "SUVQR01HRBiABSABKAsyDC5GSE9QSkJEQ0pQTkIeqgIbRWdnTGluay5EYW5o",
            "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueDropMiracleReflection.Descriptor, global::EggLink.DanhengServer.Proto.DBEBMPDJBDIReflection.Descriptor, global::EggLink.DanhengServer.Proto.FHOPJBDCJPNReflection.Descriptor, global::EggLink.DanhengServer.Proto.JPHCEACMEKKReflection.Descriptor, global::EggLink.DanhengServer.Proto.HHKKIGIFKAEReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueDropBuffReflection.Descriptor, global::EggLink.DanhengServer.Proto.LGKPBDMGBPEReflection.Descriptor, global::EggLink.DanhengServer.Proto.GBAHGLIGBCFReflection.Descriptor, global::EggLink.DanhengServer.Proto.PIIIIJKFFGJReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueCommonActionResultData), global::EggLink.DanhengServer.Proto.RogueCommonActionResultData.Parser, new[]{ "AHNLLIGGPKF", "PONCGOBLHPA", "GetBuffList", "LostBuffList", "GetMiracleInfo", "CKDABJDIMBN", "LIAFCBIPEHF", "BIENKPBJGOF", "OAPLNBNEBEJ", "GGBAIKDFOIK", "MJLCIEPGMGD" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueCommonActionResultData : pb::IMessage<RogueCommonActionResultData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueCommonActionResultData> _parser = new pb::MessageParser<RogueCommonActionResultData>(() => new RogueCommonActionResultData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueCommonActionResultData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueCommonActionResultDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueCommonActionResultData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueCommonActionResultData(RogueCommonActionResultData other) : this() {
      aHNLLIGGPKF_ = other.aHNLLIGGPKF_ != null ? other.aHNLLIGGPKF_.Clone() : null;
      pONCGOBLHPA_ = other.pONCGOBLHPA_ != null ? other.pONCGOBLHPA_.Clone() : null;
      getBuffList_ = other.getBuffList_ != null ? other.getBuffList_.Clone() : null;
      lostBuffList_ = other.lostBuffList_ != null ? other.lostBuffList_.Clone() : null;
      getMiracleInfo_ = other.getMiracleInfo_ != null ? other.getMiracleInfo_.Clone() : null;
      cKDABJDIMBN_ = other.cKDABJDIMBN_ != null ? other.cKDABJDIMBN_.Clone() : null;
      lIAFCBIPEHF_ = other.lIAFCBIPEHF_ != null ? other.lIAFCBIPEHF_.Clone() : null;
      bIENKPBJGOF_ = other.bIENKPBJGOF_ != null ? other.bIENKPBJGOF_.Clone() : null;
      oAPLNBNEBEJ_ = other.oAPLNBNEBEJ_ != null ? other.oAPLNBNEBEJ_.Clone() : null;
      gGBAIKDFOIK_ = other.gGBAIKDFOIK_ != null ? other.gGBAIKDFOIK_.Clone() : null;
      mJLCIEPGMGD_ = other.mJLCIEPGMGD_ != null ? other.mJLCIEPGMGD_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueCommonActionResultData Clone() {
      return new RogueCommonActionResultData(this);
    }

    /// <summary>Field number for the "AHNLLIGGPKF" field.</summary>
    public const int AHNLLIGGPKFFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.JPHCEACMEKK aHNLLIGGPKF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.JPHCEACMEKK AHNLLIGGPKF {
      get { return aHNLLIGGPKF_; }
      set {
        aHNLLIGGPKF_ = value;
      }
    }

    /// <summary>Field number for the "PONCGOBLHPA" field.</summary>
    public const int PONCGOBLHPAFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.JPHCEACMEKK pONCGOBLHPA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.JPHCEACMEKK PONCGOBLHPA {
      get { return pONCGOBLHPA_; }
      set {
        pONCGOBLHPA_ = value;
      }
    }

    /// <summary>Field number for the "get_buff_list" field.</summary>
    public const int GetBuffListFieldNumber = 632;
    private global::EggLink.DanhengServer.Proto.RogueDropBuff getBuffList_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueDropBuff GetBuffList {
      get { return getBuffList_; }
      set {
        getBuffList_ = value;
      }
    }

    /// <summary>Field number for the "lost_buff_list" field.</summary>
    public const int LostBuffListFieldNumber = 642;
    private global::EggLink.DanhengServer.Proto.RogueDropBuff lostBuffList_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueDropBuff LostBuffList {
      get { return lostBuffList_; }
      set {
        lostBuffList_ = value;
      }
    }

    /// <summary>Field number for the "get_miracle_info" field.</summary>
    public const int GetMiracleInfoFieldNumber = 452;
    private global::EggLink.DanhengServer.Proto.RogueDropMiracle getMiracleInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueDropMiracle GetMiracleInfo {
      get { return getMiracleInfo_; }
      set {
        getMiracleInfo_ = value;
      }
    }

    /// <summary>Field number for the "CKDABJDIMBN" field.</summary>
    public const int CKDABJDIMBNFieldNumber = 1029;
    private global::EggLink.DanhengServer.Proto.PIIIIJKFFGJ cKDABJDIMBN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PIIIIJKFFGJ CKDABJDIMBN {
      get { return cKDABJDIMBN_; }
      set {
        cKDABJDIMBN_ = value;
      }
    }

    /// <summary>Field number for the "LIAFCBIPEHF" field.</summary>
    public const int LIAFCBIPEHFFieldNumber = 666;
    private global::EggLink.DanhengServer.Proto.GBAHGLIGBCF lIAFCBIPEHF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.GBAHGLIGBCF LIAFCBIPEHF {
      get { return lIAFCBIPEHF_; }
      set {
        lIAFCBIPEHF_ = value;
      }
    }

    /// <summary>Field number for the "BIENKPBJGOF" field.</summary>
    public const int BIENKPBJGOFFieldNumber = 1743;
    private global::EggLink.DanhengServer.Proto.LGKPBDMGBPE bIENKPBJGOF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.LGKPBDMGBPE BIENKPBJGOF {
      get { return bIENKPBJGOF_; }
      set {
        bIENKPBJGOF_ = value;
      }
    }

    /// <summary>Field number for the "OAPLNBNEBEJ" field.</summary>
    public const int OAPLNBNEBEJFieldNumber = 1030;
    private global::EggLink.DanhengServer.Proto.HHKKIGIFKAE oAPLNBNEBEJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HHKKIGIFKAE OAPLNBNEBEJ {
      get { return oAPLNBNEBEJ_; }
      set {
        oAPLNBNEBEJ_ = value;
      }
    }

    /// <summary>Field number for the "GGBAIKDFOIK" field.</summary>
    public const int GGBAIKDFOIKFieldNumber = 713;
    private global::EggLink.DanhengServer.Proto.DBEBMPDJBDI gGBAIKDFOIK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.DBEBMPDJBDI GGBAIKDFOIK {
      get { return gGBAIKDFOIK_; }
      set {
        gGBAIKDFOIK_ = value;
      }
    }

    /// <summary>Field number for the "MJLCIEPGMGD" field.</summary>
    public const int MJLCIEPGMGDFieldNumber = 640;
    private global::EggLink.DanhengServer.Proto.FHOPJBDCJPN mJLCIEPGMGD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.FHOPJBDCJPN MJLCIEPGMGD {
      get { return mJLCIEPGMGD_; }
      set {
        mJLCIEPGMGD_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueCommonActionResultData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueCommonActionResultData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(AHNLLIGGPKF, other.AHNLLIGGPKF)) return false;
      if (!object.Equals(PONCGOBLHPA, other.PONCGOBLHPA)) return false;
      if (!object.Equals(GetBuffList, other.GetBuffList)) return false;
      if (!object.Equals(LostBuffList, other.LostBuffList)) return false;
      if (!object.Equals(GetMiracleInfo, other.GetMiracleInfo)) return false;
      if (!object.Equals(CKDABJDIMBN, other.CKDABJDIMBN)) return false;
      if (!object.Equals(LIAFCBIPEHF, other.LIAFCBIPEHF)) return false;
      if (!object.Equals(BIENKPBJGOF, other.BIENKPBJGOF)) return false;
      if (!object.Equals(OAPLNBNEBEJ, other.OAPLNBNEBEJ)) return false;
      if (!object.Equals(GGBAIKDFOIK, other.GGBAIKDFOIK)) return false;
      if (!object.Equals(MJLCIEPGMGD, other.MJLCIEPGMGD)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (aHNLLIGGPKF_ != null) hash ^= AHNLLIGGPKF.GetHashCode();
      if (pONCGOBLHPA_ != null) hash ^= PONCGOBLHPA.GetHashCode();
      if (getBuffList_ != null) hash ^= GetBuffList.GetHashCode();
      if (lostBuffList_ != null) hash ^= LostBuffList.GetHashCode();
      if (getMiracleInfo_ != null) hash ^= GetMiracleInfo.GetHashCode();
      if (cKDABJDIMBN_ != null) hash ^= CKDABJDIMBN.GetHashCode();
      if (lIAFCBIPEHF_ != null) hash ^= LIAFCBIPEHF.GetHashCode();
      if (bIENKPBJGOF_ != null) hash ^= BIENKPBJGOF.GetHashCode();
      if (oAPLNBNEBEJ_ != null) hash ^= OAPLNBNEBEJ.GetHashCode();
      if (gGBAIKDFOIK_ != null) hash ^= GGBAIKDFOIK.GetHashCode();
      if (mJLCIEPGMGD_ != null) hash ^= MJLCIEPGMGD.GetHashCode();
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
      if (pONCGOBLHPA_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(PONCGOBLHPA);
      }
      if (aHNLLIGGPKF_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(AHNLLIGGPKF);
      }
      if (getMiracleInfo_ != null) {
        output.WriteRawTag(162, 28);
        output.WriteMessage(GetMiracleInfo);
      }
      if (getBuffList_ != null) {
        output.WriteRawTag(194, 39);
        output.WriteMessage(GetBuffList);
      }
      if (mJLCIEPGMGD_ != null) {
        output.WriteRawTag(130, 40);
        output.WriteMessage(MJLCIEPGMGD);
      }
      if (lostBuffList_ != null) {
        output.WriteRawTag(146, 40);
        output.WriteMessage(LostBuffList);
      }
      if (lIAFCBIPEHF_ != null) {
        output.WriteRawTag(210, 41);
        output.WriteMessage(LIAFCBIPEHF);
      }
      if (gGBAIKDFOIK_ != null) {
        output.WriteRawTag(202, 44);
        output.WriteMessage(GGBAIKDFOIK);
      }
      if (cKDABJDIMBN_ != null) {
        output.WriteRawTag(170, 64);
        output.WriteMessage(CKDABJDIMBN);
      }
      if (oAPLNBNEBEJ_ != null) {
        output.WriteRawTag(178, 64);
        output.WriteMessage(OAPLNBNEBEJ);
      }
      if (bIENKPBJGOF_ != null) {
        output.WriteRawTag(250, 108);
        output.WriteMessage(BIENKPBJGOF);
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
      if (pONCGOBLHPA_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(PONCGOBLHPA);
      }
      if (aHNLLIGGPKF_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(AHNLLIGGPKF);
      }
      if (getMiracleInfo_ != null) {
        output.WriteRawTag(162, 28);
        output.WriteMessage(GetMiracleInfo);
      }
      if (getBuffList_ != null) {
        output.WriteRawTag(194, 39);
        output.WriteMessage(GetBuffList);
      }
      if (mJLCIEPGMGD_ != null) {
        output.WriteRawTag(130, 40);
        output.WriteMessage(MJLCIEPGMGD);
      }
      if (lostBuffList_ != null) {
        output.WriteRawTag(146, 40);
        output.WriteMessage(LostBuffList);
      }
      if (lIAFCBIPEHF_ != null) {
        output.WriteRawTag(210, 41);
        output.WriteMessage(LIAFCBIPEHF);
      }
      if (gGBAIKDFOIK_ != null) {
        output.WriteRawTag(202, 44);
        output.WriteMessage(GGBAIKDFOIK);
      }
      if (cKDABJDIMBN_ != null) {
        output.WriteRawTag(170, 64);
        output.WriteMessage(CKDABJDIMBN);
      }
      if (oAPLNBNEBEJ_ != null) {
        output.WriteRawTag(178, 64);
        output.WriteMessage(OAPLNBNEBEJ);
      }
      if (bIENKPBJGOF_ != null) {
        output.WriteRawTag(250, 108);
        output.WriteMessage(BIENKPBJGOF);
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
      if (aHNLLIGGPKF_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AHNLLIGGPKF);
      }
      if (pONCGOBLHPA_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PONCGOBLHPA);
      }
      if (getBuffList_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(GetBuffList);
      }
      if (lostBuffList_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(LostBuffList);
      }
      if (getMiracleInfo_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(GetMiracleInfo);
      }
      if (cKDABJDIMBN_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(CKDABJDIMBN);
      }
      if (lIAFCBIPEHF_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(LIAFCBIPEHF);
      }
      if (bIENKPBJGOF_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(BIENKPBJGOF);
      }
      if (oAPLNBNEBEJ_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(OAPLNBNEBEJ);
      }
      if (gGBAIKDFOIK_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(GGBAIKDFOIK);
      }
      if (mJLCIEPGMGD_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(MJLCIEPGMGD);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueCommonActionResultData other) {
      if (other == null) {
        return;
      }
      if (other.aHNLLIGGPKF_ != null) {
        if (aHNLLIGGPKF_ == null) {
          AHNLLIGGPKF = new global::EggLink.DanhengServer.Proto.JPHCEACMEKK();
        }
        AHNLLIGGPKF.MergeFrom(other.AHNLLIGGPKF);
      }
      if (other.pONCGOBLHPA_ != null) {
        if (pONCGOBLHPA_ == null) {
          PONCGOBLHPA = new global::EggLink.DanhengServer.Proto.JPHCEACMEKK();
        }
        PONCGOBLHPA.MergeFrom(other.PONCGOBLHPA);
      }
      if (other.getBuffList_ != null) {
        if (getBuffList_ == null) {
          GetBuffList = new global::EggLink.DanhengServer.Proto.RogueDropBuff();
        }
        GetBuffList.MergeFrom(other.GetBuffList);
      }
      if (other.lostBuffList_ != null) {
        if (lostBuffList_ == null) {
          LostBuffList = new global::EggLink.DanhengServer.Proto.RogueDropBuff();
        }
        LostBuffList.MergeFrom(other.LostBuffList);
      }
      if (other.getMiracleInfo_ != null) {
        if (getMiracleInfo_ == null) {
          GetMiracleInfo = new global::EggLink.DanhengServer.Proto.RogueDropMiracle();
        }
        GetMiracleInfo.MergeFrom(other.GetMiracleInfo);
      }
      if (other.cKDABJDIMBN_ != null) {
        if (cKDABJDIMBN_ == null) {
          CKDABJDIMBN = new global::EggLink.DanhengServer.Proto.PIIIIJKFFGJ();
        }
        CKDABJDIMBN.MergeFrom(other.CKDABJDIMBN);
      }
      if (other.lIAFCBIPEHF_ != null) {
        if (lIAFCBIPEHF_ == null) {
          LIAFCBIPEHF = new global::EggLink.DanhengServer.Proto.GBAHGLIGBCF();
        }
        LIAFCBIPEHF.MergeFrom(other.LIAFCBIPEHF);
      }
      if (other.bIENKPBJGOF_ != null) {
        if (bIENKPBJGOF_ == null) {
          BIENKPBJGOF = new global::EggLink.DanhengServer.Proto.LGKPBDMGBPE();
        }
        BIENKPBJGOF.MergeFrom(other.BIENKPBJGOF);
      }
      if (other.oAPLNBNEBEJ_ != null) {
        if (oAPLNBNEBEJ_ == null) {
          OAPLNBNEBEJ = new global::EggLink.DanhengServer.Proto.HHKKIGIFKAE();
        }
        OAPLNBNEBEJ.MergeFrom(other.OAPLNBNEBEJ);
      }
      if (other.gGBAIKDFOIK_ != null) {
        if (gGBAIKDFOIK_ == null) {
          GGBAIKDFOIK = new global::EggLink.DanhengServer.Proto.DBEBMPDJBDI();
        }
        GGBAIKDFOIK.MergeFrom(other.GGBAIKDFOIK);
      }
      if (other.mJLCIEPGMGD_ != null) {
        if (mJLCIEPGMGD_ == null) {
          MJLCIEPGMGD = new global::EggLink.DanhengServer.Proto.FHOPJBDCJPN();
        }
        MJLCIEPGMGD.MergeFrom(other.MJLCIEPGMGD);
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
          case 90: {
            if (pONCGOBLHPA_ == null) {
              PONCGOBLHPA = new global::EggLink.DanhengServer.Proto.JPHCEACMEKK();
            }
            input.ReadMessage(PONCGOBLHPA);
            break;
          }
          case 98: {
            if (aHNLLIGGPKF_ == null) {
              AHNLLIGGPKF = new global::EggLink.DanhengServer.Proto.JPHCEACMEKK();
            }
            input.ReadMessage(AHNLLIGGPKF);
            break;
          }
          case 3618: {
            if (getMiracleInfo_ == null) {
              GetMiracleInfo = new global::EggLink.DanhengServer.Proto.RogueDropMiracle();
            }
            input.ReadMessage(GetMiracleInfo);
            break;
          }
          case 5058: {
            if (getBuffList_ == null) {
              GetBuffList = new global::EggLink.DanhengServer.Proto.RogueDropBuff();
            }
            input.ReadMessage(GetBuffList);
            break;
          }
          case 5122: {
            if (mJLCIEPGMGD_ == null) {
              MJLCIEPGMGD = new global::EggLink.DanhengServer.Proto.FHOPJBDCJPN();
            }
            input.ReadMessage(MJLCIEPGMGD);
            break;
          }
          case 5138: {
            if (lostBuffList_ == null) {
              LostBuffList = new global::EggLink.DanhengServer.Proto.RogueDropBuff();
            }
            input.ReadMessage(LostBuffList);
            break;
          }
          case 5330: {
            if (lIAFCBIPEHF_ == null) {
              LIAFCBIPEHF = new global::EggLink.DanhengServer.Proto.GBAHGLIGBCF();
            }
            input.ReadMessage(LIAFCBIPEHF);
            break;
          }
          case 5706: {
            if (gGBAIKDFOIK_ == null) {
              GGBAIKDFOIK = new global::EggLink.DanhengServer.Proto.DBEBMPDJBDI();
            }
            input.ReadMessage(GGBAIKDFOIK);
            break;
          }
          case 8234: {
            if (cKDABJDIMBN_ == null) {
              CKDABJDIMBN = new global::EggLink.DanhengServer.Proto.PIIIIJKFFGJ();
            }
            input.ReadMessage(CKDABJDIMBN);
            break;
          }
          case 8242: {
            if (oAPLNBNEBEJ_ == null) {
              OAPLNBNEBEJ = new global::EggLink.DanhengServer.Proto.HHKKIGIFKAE();
            }
            input.ReadMessage(OAPLNBNEBEJ);
            break;
          }
          case 13946: {
            if (bIENKPBJGOF_ == null) {
              BIENKPBJGOF = new global::EggLink.DanhengServer.Proto.LGKPBDMGBPE();
            }
            input.ReadMessage(BIENKPBJGOF);
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
          case 90: {
            if (pONCGOBLHPA_ == null) {
              PONCGOBLHPA = new global::EggLink.DanhengServer.Proto.JPHCEACMEKK();
            }
            input.ReadMessage(PONCGOBLHPA);
            break;
          }
          case 98: {
            if (aHNLLIGGPKF_ == null) {
              AHNLLIGGPKF = new global::EggLink.DanhengServer.Proto.JPHCEACMEKK();
            }
            input.ReadMessage(AHNLLIGGPKF);
            break;
          }
          case 3618: {
            if (getMiracleInfo_ == null) {
              GetMiracleInfo = new global::EggLink.DanhengServer.Proto.RogueDropMiracle();
            }
            input.ReadMessage(GetMiracleInfo);
            break;
          }
          case 5058: {
            if (getBuffList_ == null) {
              GetBuffList = new global::EggLink.DanhengServer.Proto.RogueDropBuff();
            }
            input.ReadMessage(GetBuffList);
            break;
          }
          case 5122: {
            if (mJLCIEPGMGD_ == null) {
              MJLCIEPGMGD = new global::EggLink.DanhengServer.Proto.FHOPJBDCJPN();
            }
            input.ReadMessage(MJLCIEPGMGD);
            break;
          }
          case 5138: {
            if (lostBuffList_ == null) {
              LostBuffList = new global::EggLink.DanhengServer.Proto.RogueDropBuff();
            }
            input.ReadMessage(LostBuffList);
            break;
          }
          case 5330: {
            if (lIAFCBIPEHF_ == null) {
              LIAFCBIPEHF = new global::EggLink.DanhengServer.Proto.GBAHGLIGBCF();
            }
            input.ReadMessage(LIAFCBIPEHF);
            break;
          }
          case 5706: {
            if (gGBAIKDFOIK_ == null) {
              GGBAIKDFOIK = new global::EggLink.DanhengServer.Proto.DBEBMPDJBDI();
            }
            input.ReadMessage(GGBAIKDFOIK);
            break;
          }
          case 8234: {
            if (cKDABJDIMBN_ == null) {
              CKDABJDIMBN = new global::EggLink.DanhengServer.Proto.PIIIIJKFFGJ();
            }
            input.ReadMessage(CKDABJDIMBN);
            break;
          }
          case 8242: {
            if (oAPLNBNEBEJ_ == null) {
              OAPLNBNEBEJ = new global::EggLink.DanhengServer.Proto.HHKKIGIFKAE();
            }
            input.ReadMessage(OAPLNBNEBEJ);
            break;
          }
          case 13946: {
            if (bIENKPBJGOF_ == null) {
              BIENKPBJGOF = new global::EggLink.DanhengServer.Proto.LGKPBDMGBPE();
            }
            input.ReadMessage(BIENKPBJGOF);
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
