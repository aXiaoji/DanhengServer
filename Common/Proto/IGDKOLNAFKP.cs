// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: IGDKOLNAFKP.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from IGDKOLNAFKP.proto</summary>
  public static partial class IGDKOLNAFKPReflection {

    #region Descriptor
    /// <summary>File descriptor for IGDKOLNAFKP.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IGDKOLNAFKPReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFJR0RLT0xOQUZLUC5wcm90bxoRT01GRkZGS1BKTUcucHJvdG8aEUJDTEtO",
            "QktFUENPLnByb3RvGhFDUEVFTExDSkNNRC5wcm90bxoRUEJIQ0ZISkhHTksu",
            "cHJvdG8iyQEKC0lHREtPTE5BRktQEhMKC05CRkpQT0pER0RPGAMgAygNEiEK",
            "C1BDT0lOR0FNT01MGA4gASgLMgwuQkNMS05CS0VQQ08SIQoLRURMSENPREFC",
            "SVAYCyABKAsyDC5DUEVFTExDSkNNRBIhCgtCREhNQUFCQk1MThgJIAEoCzIM",
            "LlBCSENGSEpIR05LEhMKC0dMQURMS0dBT0hJGA8gAygNEicKEXJvZ3VlX3Rh",
            "bGVudF9pbmZvGAEgASgLMgwuT01GRkZGS1BKTUdCHqoCG0VnZ0xpbmsuRGFu",
            "aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.OMFFFFKPJMGReflection.Descriptor, global::EggLink.DanhengServer.Proto.BCLKNBKEPCOReflection.Descriptor, global::EggLink.DanhengServer.Proto.CPEELLCJCMDReflection.Descriptor, global::EggLink.DanhengServer.Proto.PBHCFHJHGNKReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.IGDKOLNAFKP), global::EggLink.DanhengServer.Proto.IGDKOLNAFKP.Parser, new[]{ "NBFJPOJDGDO", "PCOINGAMOML", "EDLHCODABIP", "BDHMAABBMLN", "GLADLKGAOHI", "RogueTalentInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class IGDKOLNAFKP : pb::IMessage<IGDKOLNAFKP>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<IGDKOLNAFKP> _parser = new pb::MessageParser<IGDKOLNAFKP>(() => new IGDKOLNAFKP());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<IGDKOLNAFKP> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.IGDKOLNAFKPReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IGDKOLNAFKP() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IGDKOLNAFKP(IGDKOLNAFKP other) : this() {
      nBFJPOJDGDO_ = other.nBFJPOJDGDO_.Clone();
      pCOINGAMOML_ = other.pCOINGAMOML_ != null ? other.pCOINGAMOML_.Clone() : null;
      eDLHCODABIP_ = other.eDLHCODABIP_ != null ? other.eDLHCODABIP_.Clone() : null;
      bDHMAABBMLN_ = other.bDHMAABBMLN_ != null ? other.bDHMAABBMLN_.Clone() : null;
      gLADLKGAOHI_ = other.gLADLKGAOHI_.Clone();
      rogueTalentInfo_ = other.rogueTalentInfo_ != null ? other.rogueTalentInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IGDKOLNAFKP Clone() {
      return new IGDKOLNAFKP(this);
    }

    /// <summary>Field number for the "NBFJPOJDGDO" field.</summary>
    public const int NBFJPOJDGDOFieldNumber = 3;
    private static readonly pb::FieldCodec<uint> _repeated_nBFJPOJDGDO_codec
        = pb::FieldCodec.ForUInt32(26);
    private readonly pbc::RepeatedField<uint> nBFJPOJDGDO_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> NBFJPOJDGDO {
      get { return nBFJPOJDGDO_; }
    }

    /// <summary>Field number for the "PCOINGAMOML" field.</summary>
    public const int PCOINGAMOMLFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.BCLKNBKEPCO pCOINGAMOML_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.BCLKNBKEPCO PCOINGAMOML {
      get { return pCOINGAMOML_; }
      set {
        pCOINGAMOML_ = value;
      }
    }

    /// <summary>Field number for the "EDLHCODABIP" field.</summary>
    public const int EDLHCODABIPFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.CPEELLCJCMD eDLHCODABIP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.CPEELLCJCMD EDLHCODABIP {
      get { return eDLHCODABIP_; }
      set {
        eDLHCODABIP_ = value;
      }
    }

    /// <summary>Field number for the "BDHMAABBMLN" field.</summary>
    public const int BDHMAABBMLNFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.PBHCFHJHGNK bDHMAABBMLN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PBHCFHJHGNK BDHMAABBMLN {
      get { return bDHMAABBMLN_; }
      set {
        bDHMAABBMLN_ = value;
      }
    }

    /// <summary>Field number for the "GLADLKGAOHI" field.</summary>
    public const int GLADLKGAOHIFieldNumber = 15;
    private static readonly pb::FieldCodec<uint> _repeated_gLADLKGAOHI_codec
        = pb::FieldCodec.ForUInt32(122);
    private readonly pbc::RepeatedField<uint> gLADLKGAOHI_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> GLADLKGAOHI {
      get { return gLADLKGAOHI_; }
    }

    /// <summary>Field number for the "rogue_talent_info" field.</summary>
    public const int RogueTalentInfoFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.OMFFFFKPJMG rogueTalentInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.OMFFFFKPJMG RogueTalentInfo {
      get { return rogueTalentInfo_; }
      set {
        rogueTalentInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as IGDKOLNAFKP);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(IGDKOLNAFKP other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!nBFJPOJDGDO_.Equals(other.nBFJPOJDGDO_)) return false;
      if (!object.Equals(PCOINGAMOML, other.PCOINGAMOML)) return false;
      if (!object.Equals(EDLHCODABIP, other.EDLHCODABIP)) return false;
      if (!object.Equals(BDHMAABBMLN, other.BDHMAABBMLN)) return false;
      if(!gLADLKGAOHI_.Equals(other.gLADLKGAOHI_)) return false;
      if (!object.Equals(RogueTalentInfo, other.RogueTalentInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= nBFJPOJDGDO_.GetHashCode();
      if (pCOINGAMOML_ != null) hash ^= PCOINGAMOML.GetHashCode();
      if (eDLHCODABIP_ != null) hash ^= EDLHCODABIP.GetHashCode();
      if (bDHMAABBMLN_ != null) hash ^= BDHMAABBMLN.GetHashCode();
      hash ^= gLADLKGAOHI_.GetHashCode();
      if (rogueTalentInfo_ != null) hash ^= RogueTalentInfo.GetHashCode();
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
      if (rogueTalentInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(RogueTalentInfo);
      }
      nBFJPOJDGDO_.WriteTo(output, _repeated_nBFJPOJDGDO_codec);
      if (bDHMAABBMLN_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(BDHMAABBMLN);
      }
      if (eDLHCODABIP_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(EDLHCODABIP);
      }
      if (pCOINGAMOML_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(PCOINGAMOML);
      }
      gLADLKGAOHI_.WriteTo(output, _repeated_gLADLKGAOHI_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (rogueTalentInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(RogueTalentInfo);
      }
      nBFJPOJDGDO_.WriteTo(ref output, _repeated_nBFJPOJDGDO_codec);
      if (bDHMAABBMLN_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(BDHMAABBMLN);
      }
      if (eDLHCODABIP_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(EDLHCODABIP);
      }
      if (pCOINGAMOML_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(PCOINGAMOML);
      }
      gLADLKGAOHI_.WriteTo(ref output, _repeated_gLADLKGAOHI_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += nBFJPOJDGDO_.CalculateSize(_repeated_nBFJPOJDGDO_codec);
      if (pCOINGAMOML_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PCOINGAMOML);
      }
      if (eDLHCODABIP_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EDLHCODABIP);
      }
      if (bDHMAABBMLN_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BDHMAABBMLN);
      }
      size += gLADLKGAOHI_.CalculateSize(_repeated_gLADLKGAOHI_codec);
      if (rogueTalentInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueTalentInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(IGDKOLNAFKP other) {
      if (other == null) {
        return;
      }
      nBFJPOJDGDO_.Add(other.nBFJPOJDGDO_);
      if (other.pCOINGAMOML_ != null) {
        if (pCOINGAMOML_ == null) {
          PCOINGAMOML = new global::EggLink.DanhengServer.Proto.BCLKNBKEPCO();
        }
        PCOINGAMOML.MergeFrom(other.PCOINGAMOML);
      }
      if (other.eDLHCODABIP_ != null) {
        if (eDLHCODABIP_ == null) {
          EDLHCODABIP = new global::EggLink.DanhengServer.Proto.CPEELLCJCMD();
        }
        EDLHCODABIP.MergeFrom(other.EDLHCODABIP);
      }
      if (other.bDHMAABBMLN_ != null) {
        if (bDHMAABBMLN_ == null) {
          BDHMAABBMLN = new global::EggLink.DanhengServer.Proto.PBHCFHJHGNK();
        }
        BDHMAABBMLN.MergeFrom(other.BDHMAABBMLN);
      }
      gLADLKGAOHI_.Add(other.gLADLKGAOHI_);
      if (other.rogueTalentInfo_ != null) {
        if (rogueTalentInfo_ == null) {
          RogueTalentInfo = new global::EggLink.DanhengServer.Proto.OMFFFFKPJMG();
        }
        RogueTalentInfo.MergeFrom(other.RogueTalentInfo);
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
            if (rogueTalentInfo_ == null) {
              RogueTalentInfo = new global::EggLink.DanhengServer.Proto.OMFFFFKPJMG();
            }
            input.ReadMessage(RogueTalentInfo);
            break;
          }
          case 26:
          case 24: {
            nBFJPOJDGDO_.AddEntriesFrom(input, _repeated_nBFJPOJDGDO_codec);
            break;
          }
          case 74: {
            if (bDHMAABBMLN_ == null) {
              BDHMAABBMLN = new global::EggLink.DanhengServer.Proto.PBHCFHJHGNK();
            }
            input.ReadMessage(BDHMAABBMLN);
            break;
          }
          case 90: {
            if (eDLHCODABIP_ == null) {
              EDLHCODABIP = new global::EggLink.DanhengServer.Proto.CPEELLCJCMD();
            }
            input.ReadMessage(EDLHCODABIP);
            break;
          }
          case 114: {
            if (pCOINGAMOML_ == null) {
              PCOINGAMOML = new global::EggLink.DanhengServer.Proto.BCLKNBKEPCO();
            }
            input.ReadMessage(PCOINGAMOML);
            break;
          }
          case 122:
          case 120: {
            gLADLKGAOHI_.AddEntriesFrom(input, _repeated_gLADLKGAOHI_codec);
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
            if (rogueTalentInfo_ == null) {
              RogueTalentInfo = new global::EggLink.DanhengServer.Proto.OMFFFFKPJMG();
            }
            input.ReadMessage(RogueTalentInfo);
            break;
          }
          case 26:
          case 24: {
            nBFJPOJDGDO_.AddEntriesFrom(ref input, _repeated_nBFJPOJDGDO_codec);
            break;
          }
          case 74: {
            if (bDHMAABBMLN_ == null) {
              BDHMAABBMLN = new global::EggLink.DanhengServer.Proto.PBHCFHJHGNK();
            }
            input.ReadMessage(BDHMAABBMLN);
            break;
          }
          case 90: {
            if (eDLHCODABIP_ == null) {
              EDLHCODABIP = new global::EggLink.DanhengServer.Proto.CPEELLCJCMD();
            }
            input.ReadMessage(EDLHCODABIP);
            break;
          }
          case 114: {
            if (pCOINGAMOML_ == null) {
              PCOINGAMOML = new global::EggLink.DanhengServer.Proto.BCLKNBKEPCO();
            }
            input.ReadMessage(PCOINGAMOML);
            break;
          }
          case 122:
          case 120: {
            gLADLKGAOHI_.AddEntriesFrom(ref input, _repeated_gLADLKGAOHI_codec);
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
