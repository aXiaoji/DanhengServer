// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TreasureDungeonLevel.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TreasureDungeonLevel.proto</summary>
  public static partial class TreasureDungeonLevelReflection {

    #region Descriptor
    /// <summary>File descriptor for TreasureDungeonLevel.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TreasureDungeonLevelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpUcmVhc3VyZUR1bmdlb25MZXZlbC5wcm90bxoRRE5EQk5NTElJRUIucHJv",
            "dG8aEU5PTEdFSUlERU9JLnByb3RvGhFCR0pDUEtFQUhERS5wcm90bxofVHJl",
            "YXN1cmVEdW5nZW9uUmVjb3JkRGF0YS5wcm90bxoRUFBGQUNNS0RBREoucHJv",
            "dG8aEUVHT0dNR0hDSUJKLnByb3RvIv8DChRUcmVhc3VyZUR1bmdlb25MZXZl",
            "bBITCgtNQkZPTEhHTURBQxgPIAEoDRIiCgtPR05GT0FBS0VLTxibBCADKAsy",
            "DC5QUEZBQ01LREFEShIiCgtJR09GQUdDSExDTxiZCCADKAsyDC5FR09HTUdI",
            "Q0lCShIOCgZtYXBfaWQYDCABKA0SEwoLR1BPTk1HREFCREQYBCABKA0SFAoL",
            "S0hES09OS0JMQUkY1AsgASgIEhMKC0hMRktJSVBOTkhBGAIgASgNEh8KCWJ1",
            "ZmZfbGlzdBhjIAMoCzIMLk5PTEdFSUlERU9JEiAKCWl0ZW1fbGlzdBjDCyAD",
            "KAsyDC5ETkRCTk1MSUlFQhIUCgtKT0JNREJJTUVCRhjRCyABKA0SIQoLTEtG",
            "TERFSUVNT08YBiADKAsyDC5CR0pDUEtFQUhERRITCgtNQ0ZIUElGSURQTRgB",
            "IAEoDRITCgtEREVQQkpFQVBBShgJIAEoDRIvCgtHSUpET0VHTExNTBgKIAMo",
            "CzIaLlRyZWFzdXJlRHVuZ2VvblJlY29yZERhdGESFAoLR0pJRUZJREpJTUUY",
            "+wkgASgIEiIKC2F2YXRhcl9saXN0GOYLIAMoCzIMLlBQRkFDTUtEQURKEhQK",
            "C0tKR05DS0ZET0ZLGJ8PIAEoCBITCgtGRUlQS0RQRElCShgIIAEoDUIeqgIb",
            "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.DNDBNMLIIEBReflection.Descriptor, global::EggLink.DanhengServer.Proto.NOLGEIIDEOIReflection.Descriptor, global::EggLink.DanhengServer.Proto.BGJCPKEAHDEReflection.Descriptor, global::EggLink.DanhengServer.Proto.TreasureDungeonRecordDataReflection.Descriptor, global::EggLink.DanhengServer.Proto.PPFACMKDADJReflection.Descriptor, global::EggLink.DanhengServer.Proto.EGOGMGHCIBJReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TreasureDungeonLevel), global::EggLink.DanhengServer.Proto.TreasureDungeonLevel.Parser, new[]{ "MBFOLHGMDAC", "OGNFOAAKEKO", "IGOFAGCHLCO", "MapId", "GPONMGDABDD", "KHDKONKBLAI", "HLFKIIPNNHA", "BuffList", "ItemList", "JOBMDBIMEBF", "LKFLDEIEMOO", "MCFHPIFIDPM", "DDEPBJEAPAJ", "GIJDOEGLLML", "GJIEFIDJIME", "AvatarList", "KJGNCKFDOFK", "FEIPKDPDIBJ" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TreasureDungeonLevel : pb::IMessage<TreasureDungeonLevel>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TreasureDungeonLevel> _parser = new pb::MessageParser<TreasureDungeonLevel>(() => new TreasureDungeonLevel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TreasureDungeonLevel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.TreasureDungeonLevelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TreasureDungeonLevel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TreasureDungeonLevel(TreasureDungeonLevel other) : this() {
      mBFOLHGMDAC_ = other.mBFOLHGMDAC_;
      oGNFOAAKEKO_ = other.oGNFOAAKEKO_.Clone();
      iGOFAGCHLCO_ = other.iGOFAGCHLCO_.Clone();
      mapId_ = other.mapId_;
      gPONMGDABDD_ = other.gPONMGDABDD_;
      kHDKONKBLAI_ = other.kHDKONKBLAI_;
      hLFKIIPNNHA_ = other.hLFKIIPNNHA_;
      buffList_ = other.buffList_.Clone();
      itemList_ = other.itemList_.Clone();
      jOBMDBIMEBF_ = other.jOBMDBIMEBF_;
      lKFLDEIEMOO_ = other.lKFLDEIEMOO_.Clone();
      mCFHPIFIDPM_ = other.mCFHPIFIDPM_;
      dDEPBJEAPAJ_ = other.dDEPBJEAPAJ_;
      gIJDOEGLLML_ = other.gIJDOEGLLML_.Clone();
      gJIEFIDJIME_ = other.gJIEFIDJIME_;
      avatarList_ = other.avatarList_.Clone();
      kJGNCKFDOFK_ = other.kJGNCKFDOFK_;
      fEIPKDPDIBJ_ = other.fEIPKDPDIBJ_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TreasureDungeonLevel Clone() {
      return new TreasureDungeonLevel(this);
    }

    /// <summary>Field number for the "MBFOLHGMDAC" field.</summary>
    public const int MBFOLHGMDACFieldNumber = 15;
    private uint mBFOLHGMDAC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MBFOLHGMDAC {
      get { return mBFOLHGMDAC_; }
      set {
        mBFOLHGMDAC_ = value;
      }
    }

    /// <summary>Field number for the "OGNFOAAKEKO" field.</summary>
    public const int OGNFOAAKEKOFieldNumber = 539;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.PPFACMKDADJ> _repeated_oGNFOAAKEKO_codec
        = pb::FieldCodec.ForMessage(4314, global::EggLink.DanhengServer.Proto.PPFACMKDADJ.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PPFACMKDADJ> oGNFOAAKEKO_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PPFACMKDADJ>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PPFACMKDADJ> OGNFOAAKEKO {
      get { return oGNFOAAKEKO_; }
    }

    /// <summary>Field number for the "IGOFAGCHLCO" field.</summary>
    public const int IGOFAGCHLCOFieldNumber = 1049;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.EGOGMGHCIBJ> _repeated_iGOFAGCHLCO_codec
        = pb::FieldCodec.ForMessage(8394, global::EggLink.DanhengServer.Proto.EGOGMGHCIBJ.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EGOGMGHCIBJ> iGOFAGCHLCO_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EGOGMGHCIBJ>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EGOGMGHCIBJ> IGOFAGCHLCO {
      get { return iGOFAGCHLCO_; }
    }

    /// <summary>Field number for the "map_id" field.</summary>
    public const int MapIdFieldNumber = 12;
    private uint mapId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MapId {
      get { return mapId_; }
      set {
        mapId_ = value;
      }
    }

    /// <summary>Field number for the "GPONMGDABDD" field.</summary>
    public const int GPONMGDABDDFieldNumber = 4;
    private uint gPONMGDABDD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GPONMGDABDD {
      get { return gPONMGDABDD_; }
      set {
        gPONMGDABDD_ = value;
      }
    }

    /// <summary>Field number for the "KHDKONKBLAI" field.</summary>
    public const int KHDKONKBLAIFieldNumber = 1492;
    private bool kHDKONKBLAI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool KHDKONKBLAI {
      get { return kHDKONKBLAI_; }
      set {
        kHDKONKBLAI_ = value;
      }
    }

    /// <summary>Field number for the "HLFKIIPNNHA" field.</summary>
    public const int HLFKIIPNNHAFieldNumber = 2;
    private uint hLFKIIPNNHA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HLFKIIPNNHA {
      get { return hLFKIIPNNHA_; }
      set {
        hLFKIIPNNHA_ = value;
      }
    }

    /// <summary>Field number for the "buff_list" field.</summary>
    public const int BuffListFieldNumber = 99;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.NOLGEIIDEOI> _repeated_buffList_codec
        = pb::FieldCodec.ForMessage(794, global::EggLink.DanhengServer.Proto.NOLGEIIDEOI.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.NOLGEIIDEOI> buffList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.NOLGEIIDEOI>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.NOLGEIIDEOI> BuffList {
      get { return buffList_; }
    }

    /// <summary>Field number for the "item_list" field.</summary>
    public const int ItemListFieldNumber = 1475;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.DNDBNMLIIEB> _repeated_itemList_codec
        = pb::FieldCodec.ForMessage(11802, global::EggLink.DanhengServer.Proto.DNDBNMLIIEB.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DNDBNMLIIEB> itemList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DNDBNMLIIEB>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DNDBNMLIIEB> ItemList {
      get { return itemList_; }
    }

    /// <summary>Field number for the "JOBMDBIMEBF" field.</summary>
    public const int JOBMDBIMEBFFieldNumber = 1489;
    private uint jOBMDBIMEBF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JOBMDBIMEBF {
      get { return jOBMDBIMEBF_; }
      set {
        jOBMDBIMEBF_ = value;
      }
    }

    /// <summary>Field number for the "LKFLDEIEMOO" field.</summary>
    public const int LKFLDEIEMOOFieldNumber = 6;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.BGJCPKEAHDE> _repeated_lKFLDEIEMOO_codec
        = pb::FieldCodec.ForMessage(50, global::EggLink.DanhengServer.Proto.BGJCPKEAHDE.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BGJCPKEAHDE> lKFLDEIEMOO_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BGJCPKEAHDE>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BGJCPKEAHDE> LKFLDEIEMOO {
      get { return lKFLDEIEMOO_; }
    }

    /// <summary>Field number for the "MCFHPIFIDPM" field.</summary>
    public const int MCFHPIFIDPMFieldNumber = 1;
    private uint mCFHPIFIDPM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MCFHPIFIDPM {
      get { return mCFHPIFIDPM_; }
      set {
        mCFHPIFIDPM_ = value;
      }
    }

    /// <summary>Field number for the "DDEPBJEAPAJ" field.</summary>
    public const int DDEPBJEAPAJFieldNumber = 9;
    private uint dDEPBJEAPAJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DDEPBJEAPAJ {
      get { return dDEPBJEAPAJ_; }
      set {
        dDEPBJEAPAJ_ = value;
      }
    }

    /// <summary>Field number for the "GIJDOEGLLML" field.</summary>
    public const int GIJDOEGLLMLFieldNumber = 10;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.TreasureDungeonRecordData> _repeated_gIJDOEGLLML_codec
        = pb::FieldCodec.ForMessage(82, global::EggLink.DanhengServer.Proto.TreasureDungeonRecordData.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.TreasureDungeonRecordData> gIJDOEGLLML_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.TreasureDungeonRecordData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.TreasureDungeonRecordData> GIJDOEGLLML {
      get { return gIJDOEGLLML_; }
    }

    /// <summary>Field number for the "GJIEFIDJIME" field.</summary>
    public const int GJIEFIDJIMEFieldNumber = 1275;
    private bool gJIEFIDJIME_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool GJIEFIDJIME {
      get { return gJIEFIDJIME_; }
      set {
        gJIEFIDJIME_ = value;
      }
    }

    /// <summary>Field number for the "avatar_list" field.</summary>
    public const int AvatarListFieldNumber = 1510;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.PPFACMKDADJ> _repeated_avatarList_codec
        = pb::FieldCodec.ForMessage(12082, global::EggLink.DanhengServer.Proto.PPFACMKDADJ.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PPFACMKDADJ> avatarList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PPFACMKDADJ>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PPFACMKDADJ> AvatarList {
      get { return avatarList_; }
    }

    /// <summary>Field number for the "KJGNCKFDOFK" field.</summary>
    public const int KJGNCKFDOFKFieldNumber = 1951;
    private bool kJGNCKFDOFK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool KJGNCKFDOFK {
      get { return kJGNCKFDOFK_; }
      set {
        kJGNCKFDOFK_ = value;
      }
    }

    /// <summary>Field number for the "FEIPKDPDIBJ" field.</summary>
    public const int FEIPKDPDIBJFieldNumber = 8;
    private uint fEIPKDPDIBJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FEIPKDPDIBJ {
      get { return fEIPKDPDIBJ_; }
      set {
        fEIPKDPDIBJ_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TreasureDungeonLevel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TreasureDungeonLevel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MBFOLHGMDAC != other.MBFOLHGMDAC) return false;
      if(!oGNFOAAKEKO_.Equals(other.oGNFOAAKEKO_)) return false;
      if(!iGOFAGCHLCO_.Equals(other.iGOFAGCHLCO_)) return false;
      if (MapId != other.MapId) return false;
      if (GPONMGDABDD != other.GPONMGDABDD) return false;
      if (KHDKONKBLAI != other.KHDKONKBLAI) return false;
      if (HLFKIIPNNHA != other.HLFKIIPNNHA) return false;
      if(!buffList_.Equals(other.buffList_)) return false;
      if(!itemList_.Equals(other.itemList_)) return false;
      if (JOBMDBIMEBF != other.JOBMDBIMEBF) return false;
      if(!lKFLDEIEMOO_.Equals(other.lKFLDEIEMOO_)) return false;
      if (MCFHPIFIDPM != other.MCFHPIFIDPM) return false;
      if (DDEPBJEAPAJ != other.DDEPBJEAPAJ) return false;
      if(!gIJDOEGLLML_.Equals(other.gIJDOEGLLML_)) return false;
      if (GJIEFIDJIME != other.GJIEFIDJIME) return false;
      if(!avatarList_.Equals(other.avatarList_)) return false;
      if (KJGNCKFDOFK != other.KJGNCKFDOFK) return false;
      if (FEIPKDPDIBJ != other.FEIPKDPDIBJ) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MBFOLHGMDAC != 0) hash ^= MBFOLHGMDAC.GetHashCode();
      hash ^= oGNFOAAKEKO_.GetHashCode();
      hash ^= iGOFAGCHLCO_.GetHashCode();
      if (MapId != 0) hash ^= MapId.GetHashCode();
      if (GPONMGDABDD != 0) hash ^= GPONMGDABDD.GetHashCode();
      if (KHDKONKBLAI != false) hash ^= KHDKONKBLAI.GetHashCode();
      if (HLFKIIPNNHA != 0) hash ^= HLFKIIPNNHA.GetHashCode();
      hash ^= buffList_.GetHashCode();
      hash ^= itemList_.GetHashCode();
      if (JOBMDBIMEBF != 0) hash ^= JOBMDBIMEBF.GetHashCode();
      hash ^= lKFLDEIEMOO_.GetHashCode();
      if (MCFHPIFIDPM != 0) hash ^= MCFHPIFIDPM.GetHashCode();
      if (DDEPBJEAPAJ != 0) hash ^= DDEPBJEAPAJ.GetHashCode();
      hash ^= gIJDOEGLLML_.GetHashCode();
      if (GJIEFIDJIME != false) hash ^= GJIEFIDJIME.GetHashCode();
      hash ^= avatarList_.GetHashCode();
      if (KJGNCKFDOFK != false) hash ^= KJGNCKFDOFK.GetHashCode();
      if (FEIPKDPDIBJ != 0) hash ^= FEIPKDPDIBJ.GetHashCode();
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
      if (MCFHPIFIDPM != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(MCFHPIFIDPM);
      }
      if (HLFKIIPNNHA != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(HLFKIIPNNHA);
      }
      if (GPONMGDABDD != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(GPONMGDABDD);
      }
      lKFLDEIEMOO_.WriteTo(output, _repeated_lKFLDEIEMOO_codec);
      if (FEIPKDPDIBJ != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(FEIPKDPDIBJ);
      }
      if (DDEPBJEAPAJ != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(DDEPBJEAPAJ);
      }
      gIJDOEGLLML_.WriteTo(output, _repeated_gIJDOEGLLML_codec);
      if (MapId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(MapId);
      }
      if (MBFOLHGMDAC != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(MBFOLHGMDAC);
      }
      buffList_.WriteTo(output, _repeated_buffList_codec);
      oGNFOAAKEKO_.WriteTo(output, _repeated_oGNFOAAKEKO_codec);
      iGOFAGCHLCO_.WriteTo(output, _repeated_iGOFAGCHLCO_codec);
      if (GJIEFIDJIME != false) {
        output.WriteRawTag(216, 79);
        output.WriteBool(GJIEFIDJIME);
      }
      itemList_.WriteTo(output, _repeated_itemList_codec);
      if (JOBMDBIMEBF != 0) {
        output.WriteRawTag(136, 93);
        output.WriteUInt32(JOBMDBIMEBF);
      }
      if (KHDKONKBLAI != false) {
        output.WriteRawTag(160, 93);
        output.WriteBool(KHDKONKBLAI);
      }
      avatarList_.WriteTo(output, _repeated_avatarList_codec);
      if (KJGNCKFDOFK != false) {
        output.WriteRawTag(248, 121);
        output.WriteBool(KJGNCKFDOFK);
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
      if (MCFHPIFIDPM != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(MCFHPIFIDPM);
      }
      if (HLFKIIPNNHA != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(HLFKIIPNNHA);
      }
      if (GPONMGDABDD != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(GPONMGDABDD);
      }
      lKFLDEIEMOO_.WriteTo(ref output, _repeated_lKFLDEIEMOO_codec);
      if (FEIPKDPDIBJ != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(FEIPKDPDIBJ);
      }
      if (DDEPBJEAPAJ != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(DDEPBJEAPAJ);
      }
      gIJDOEGLLML_.WriteTo(ref output, _repeated_gIJDOEGLLML_codec);
      if (MapId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(MapId);
      }
      if (MBFOLHGMDAC != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(MBFOLHGMDAC);
      }
      buffList_.WriteTo(ref output, _repeated_buffList_codec);
      oGNFOAAKEKO_.WriteTo(ref output, _repeated_oGNFOAAKEKO_codec);
      iGOFAGCHLCO_.WriteTo(ref output, _repeated_iGOFAGCHLCO_codec);
      if (GJIEFIDJIME != false) {
        output.WriteRawTag(216, 79);
        output.WriteBool(GJIEFIDJIME);
      }
      itemList_.WriteTo(ref output, _repeated_itemList_codec);
      if (JOBMDBIMEBF != 0) {
        output.WriteRawTag(136, 93);
        output.WriteUInt32(JOBMDBIMEBF);
      }
      if (KHDKONKBLAI != false) {
        output.WriteRawTag(160, 93);
        output.WriteBool(KHDKONKBLAI);
      }
      avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
      if (KJGNCKFDOFK != false) {
        output.WriteRawTag(248, 121);
        output.WriteBool(KJGNCKFDOFK);
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
      if (MBFOLHGMDAC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MBFOLHGMDAC);
      }
      size += oGNFOAAKEKO_.CalculateSize(_repeated_oGNFOAAKEKO_codec);
      size += iGOFAGCHLCO_.CalculateSize(_repeated_iGOFAGCHLCO_codec);
      if (MapId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MapId);
      }
      if (GPONMGDABDD != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GPONMGDABDD);
      }
      if (KHDKONKBLAI != false) {
        size += 2 + 1;
      }
      if (HLFKIIPNNHA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HLFKIIPNNHA);
      }
      size += buffList_.CalculateSize(_repeated_buffList_codec);
      size += itemList_.CalculateSize(_repeated_itemList_codec);
      if (JOBMDBIMEBF != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(JOBMDBIMEBF);
      }
      size += lKFLDEIEMOO_.CalculateSize(_repeated_lKFLDEIEMOO_codec);
      if (MCFHPIFIDPM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MCFHPIFIDPM);
      }
      if (DDEPBJEAPAJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DDEPBJEAPAJ);
      }
      size += gIJDOEGLLML_.CalculateSize(_repeated_gIJDOEGLLML_codec);
      if (GJIEFIDJIME != false) {
        size += 2 + 1;
      }
      size += avatarList_.CalculateSize(_repeated_avatarList_codec);
      if (KJGNCKFDOFK != false) {
        size += 2 + 1;
      }
      if (FEIPKDPDIBJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FEIPKDPDIBJ);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TreasureDungeonLevel other) {
      if (other == null) {
        return;
      }
      if (other.MBFOLHGMDAC != 0) {
        MBFOLHGMDAC = other.MBFOLHGMDAC;
      }
      oGNFOAAKEKO_.Add(other.oGNFOAAKEKO_);
      iGOFAGCHLCO_.Add(other.iGOFAGCHLCO_);
      if (other.MapId != 0) {
        MapId = other.MapId;
      }
      if (other.GPONMGDABDD != 0) {
        GPONMGDABDD = other.GPONMGDABDD;
      }
      if (other.KHDKONKBLAI != false) {
        KHDKONKBLAI = other.KHDKONKBLAI;
      }
      if (other.HLFKIIPNNHA != 0) {
        HLFKIIPNNHA = other.HLFKIIPNNHA;
      }
      buffList_.Add(other.buffList_);
      itemList_.Add(other.itemList_);
      if (other.JOBMDBIMEBF != 0) {
        JOBMDBIMEBF = other.JOBMDBIMEBF;
      }
      lKFLDEIEMOO_.Add(other.lKFLDEIEMOO_);
      if (other.MCFHPIFIDPM != 0) {
        MCFHPIFIDPM = other.MCFHPIFIDPM;
      }
      if (other.DDEPBJEAPAJ != 0) {
        DDEPBJEAPAJ = other.DDEPBJEAPAJ;
      }
      gIJDOEGLLML_.Add(other.gIJDOEGLLML_);
      if (other.GJIEFIDJIME != false) {
        GJIEFIDJIME = other.GJIEFIDJIME;
      }
      avatarList_.Add(other.avatarList_);
      if (other.KJGNCKFDOFK != false) {
        KJGNCKFDOFK = other.KJGNCKFDOFK;
      }
      if (other.FEIPKDPDIBJ != 0) {
        FEIPKDPDIBJ = other.FEIPKDPDIBJ;
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
            MCFHPIFIDPM = input.ReadUInt32();
            break;
          }
          case 16: {
            HLFKIIPNNHA = input.ReadUInt32();
            break;
          }
          case 32: {
            GPONMGDABDD = input.ReadUInt32();
            break;
          }
          case 50: {
            lKFLDEIEMOO_.AddEntriesFrom(input, _repeated_lKFLDEIEMOO_codec);
            break;
          }
          case 64: {
            FEIPKDPDIBJ = input.ReadUInt32();
            break;
          }
          case 72: {
            DDEPBJEAPAJ = input.ReadUInt32();
            break;
          }
          case 82: {
            gIJDOEGLLML_.AddEntriesFrom(input, _repeated_gIJDOEGLLML_codec);
            break;
          }
          case 96: {
            MapId = input.ReadUInt32();
            break;
          }
          case 120: {
            MBFOLHGMDAC = input.ReadUInt32();
            break;
          }
          case 794: {
            buffList_.AddEntriesFrom(input, _repeated_buffList_codec);
            break;
          }
          case 4314: {
            oGNFOAAKEKO_.AddEntriesFrom(input, _repeated_oGNFOAAKEKO_codec);
            break;
          }
          case 8394: {
            iGOFAGCHLCO_.AddEntriesFrom(input, _repeated_iGOFAGCHLCO_codec);
            break;
          }
          case 10200: {
            GJIEFIDJIME = input.ReadBool();
            break;
          }
          case 11802: {
            itemList_.AddEntriesFrom(input, _repeated_itemList_codec);
            break;
          }
          case 11912: {
            JOBMDBIMEBF = input.ReadUInt32();
            break;
          }
          case 11936: {
            KHDKONKBLAI = input.ReadBool();
            break;
          }
          case 12082: {
            avatarList_.AddEntriesFrom(input, _repeated_avatarList_codec);
            break;
          }
          case 15608: {
            KJGNCKFDOFK = input.ReadBool();
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
            MCFHPIFIDPM = input.ReadUInt32();
            break;
          }
          case 16: {
            HLFKIIPNNHA = input.ReadUInt32();
            break;
          }
          case 32: {
            GPONMGDABDD = input.ReadUInt32();
            break;
          }
          case 50: {
            lKFLDEIEMOO_.AddEntriesFrom(ref input, _repeated_lKFLDEIEMOO_codec);
            break;
          }
          case 64: {
            FEIPKDPDIBJ = input.ReadUInt32();
            break;
          }
          case 72: {
            DDEPBJEAPAJ = input.ReadUInt32();
            break;
          }
          case 82: {
            gIJDOEGLLML_.AddEntriesFrom(ref input, _repeated_gIJDOEGLLML_codec);
            break;
          }
          case 96: {
            MapId = input.ReadUInt32();
            break;
          }
          case 120: {
            MBFOLHGMDAC = input.ReadUInt32();
            break;
          }
          case 794: {
            buffList_.AddEntriesFrom(ref input, _repeated_buffList_codec);
            break;
          }
          case 4314: {
            oGNFOAAKEKO_.AddEntriesFrom(ref input, _repeated_oGNFOAAKEKO_codec);
            break;
          }
          case 8394: {
            iGOFAGCHLCO_.AddEntriesFrom(ref input, _repeated_iGOFAGCHLCO_codec);
            break;
          }
          case 10200: {
            GJIEFIDJIME = input.ReadBool();
            break;
          }
          case 11802: {
            itemList_.AddEntriesFrom(ref input, _repeated_itemList_codec);
            break;
          }
          case 11912: {
            JOBMDBIMEBF = input.ReadUInt32();
            break;
          }
          case 11936: {
            KHDKONKBLAI = input.ReadBool();
            break;
          }
          case 12082: {
            avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
            break;
          }
          case 15608: {
            KJGNCKFDOFK = input.ReadBool();
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
