// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueQueryScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueQueryScRsp.proto</summary>
  public static partial class ChessRogueQueryScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueQueryScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueQueryScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpDaGVzc1JvZ3VlUXVlcnlTY1JzcC5wcm90bxoRQU5OTkpPTE5ESEUucHJv",
            "dG8aEUlHREtPTE5BRktQLnByb3RvGhFFRVBHSExGTkRLSi5wcm90bxoRSlBE",
            "SE9OUElDSUQucHJvdG8aEUtPR0pKTUJFRERFLnByb3RvItYBChRDaGVzc1Jv",
            "Z3VlUXVlcnlTY1JzcBIhCgtDR0VCS09GQktKTxgBIAEoCzIMLktPR0pKTUJF",
            "RERFEhoKBGluZm8YDSABKAsyDC5FRVBHSExGTkRLShIPCgdyZXRjb2RlGAwg",
            "ASgNEiEKC0FOTk5CSEpETVBNGAkgASgLMgwuSlBESE9OUElDSUQSJAoOcm9n",
            "dWVfZ2V0X2luZm8YDyABKAsyDC5JR0RLT0xOQUZLUBIlCg9yb2d1ZV9nYW1l",
            "X2luZm8YAyABKAsyDC5BTk5OSk9MTkRIRUIeqgIbRWdnTGluay5EYW5oZW5n",
            "U2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ANNNJOLNDHEReflection.Descriptor, global::EggLink.DanhengServer.Proto.IGDKOLNAFKPReflection.Descriptor, global::EggLink.DanhengServer.Proto.EEPGHLFNDKJReflection.Descriptor, global::EggLink.DanhengServer.Proto.JPDHONPICIDReflection.Descriptor, global::EggLink.DanhengServer.Proto.KOGJJMBEDDEReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueQueryScRsp), global::EggLink.DanhengServer.Proto.ChessRogueQueryScRsp.Parser, new[]{ "CGEBKOFBKJO", "Info", "Retcode", "ANNNBHJDMPM", "RogueGetInfo", "RogueGameInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueQueryScRsp : pb::IMessage<ChessRogueQueryScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueQueryScRsp> _parser = new pb::MessageParser<ChessRogueQueryScRsp>(() => new ChessRogueQueryScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueQueryScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueQueryScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueQueryScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueQueryScRsp(ChessRogueQueryScRsp other) : this() {
      cGEBKOFBKJO_ = other.cGEBKOFBKJO_ != null ? other.cGEBKOFBKJO_.Clone() : null;
      info_ = other.info_ != null ? other.info_.Clone() : null;
      retcode_ = other.retcode_;
      aNNNBHJDMPM_ = other.aNNNBHJDMPM_ != null ? other.aNNNBHJDMPM_.Clone() : null;
      rogueGetInfo_ = other.rogueGetInfo_ != null ? other.rogueGetInfo_.Clone() : null;
      rogueGameInfo_ = other.rogueGameInfo_ != null ? other.rogueGameInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueQueryScRsp Clone() {
      return new ChessRogueQueryScRsp(this);
    }

    /// <summary>Field number for the "CGEBKOFBKJO" field.</summary>
    public const int CGEBKOFBKJOFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.KOGJJMBEDDE cGEBKOFBKJO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.KOGJJMBEDDE CGEBKOFBKJO {
      get { return cGEBKOFBKJO_; }
      set {
        cGEBKOFBKJO_ = value;
      }
    }

    /// <summary>Field number for the "info" field.</summary>
    public const int InfoFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.EEPGHLFNDKJ info_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.EEPGHLFNDKJ Info {
      get { return info_; }
      set {
        info_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 12;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "ANNNBHJDMPM" field.</summary>
    public const int ANNNBHJDMPMFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.JPDHONPICID aNNNBHJDMPM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.JPDHONPICID ANNNBHJDMPM {
      get { return aNNNBHJDMPM_; }
      set {
        aNNNBHJDMPM_ = value;
      }
    }

    /// <summary>Field number for the "rogue_get_info" field.</summary>
    public const int RogueGetInfoFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.IGDKOLNAFKP rogueGetInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.IGDKOLNAFKP RogueGetInfo {
      get { return rogueGetInfo_; }
      set {
        rogueGetInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_game_info" field.</summary>
    public const int RogueGameInfoFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.ANNNJOLNDHE rogueGameInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ANNNJOLNDHE RogueGameInfo {
      get { return rogueGameInfo_; }
      set {
        rogueGameInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueQueryScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueQueryScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(CGEBKOFBKJO, other.CGEBKOFBKJO)) return false;
      if (!object.Equals(Info, other.Info)) return false;
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(ANNNBHJDMPM, other.ANNNBHJDMPM)) return false;
      if (!object.Equals(RogueGetInfo, other.RogueGetInfo)) return false;
      if (!object.Equals(RogueGameInfo, other.RogueGameInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (cGEBKOFBKJO_ != null) hash ^= CGEBKOFBKJO.GetHashCode();
      if (info_ != null) hash ^= Info.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (aNNNBHJDMPM_ != null) hash ^= ANNNBHJDMPM.GetHashCode();
      if (rogueGetInfo_ != null) hash ^= RogueGetInfo.GetHashCode();
      if (rogueGameInfo_ != null) hash ^= RogueGameInfo.GetHashCode();
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
      if (cGEBKOFBKJO_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CGEBKOFBKJO);
      }
      if (rogueGameInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(RogueGameInfo);
      }
      if (aNNNBHJDMPM_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(ANNNBHJDMPM);
      }
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Retcode);
      }
      if (info_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(Info);
      }
      if (rogueGetInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(RogueGetInfo);
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
      if (cGEBKOFBKJO_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CGEBKOFBKJO);
      }
      if (rogueGameInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(RogueGameInfo);
      }
      if (aNNNBHJDMPM_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(ANNNBHJDMPM);
      }
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Retcode);
      }
      if (info_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(Info);
      }
      if (rogueGetInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(RogueGetInfo);
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
      if (cGEBKOFBKJO_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CGEBKOFBKJO);
      }
      if (info_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Info);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (aNNNBHJDMPM_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ANNNBHJDMPM);
      }
      if (rogueGetInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueGetInfo);
      }
      if (rogueGameInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueGameInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueQueryScRsp other) {
      if (other == null) {
        return;
      }
      if (other.cGEBKOFBKJO_ != null) {
        if (cGEBKOFBKJO_ == null) {
          CGEBKOFBKJO = new global::EggLink.DanhengServer.Proto.KOGJJMBEDDE();
        }
        CGEBKOFBKJO.MergeFrom(other.CGEBKOFBKJO);
      }
      if (other.info_ != null) {
        if (info_ == null) {
          Info = new global::EggLink.DanhengServer.Proto.EEPGHLFNDKJ();
        }
        Info.MergeFrom(other.Info);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.aNNNBHJDMPM_ != null) {
        if (aNNNBHJDMPM_ == null) {
          ANNNBHJDMPM = new global::EggLink.DanhengServer.Proto.JPDHONPICID();
        }
        ANNNBHJDMPM.MergeFrom(other.ANNNBHJDMPM);
      }
      if (other.rogueGetInfo_ != null) {
        if (rogueGetInfo_ == null) {
          RogueGetInfo = new global::EggLink.DanhengServer.Proto.IGDKOLNAFKP();
        }
        RogueGetInfo.MergeFrom(other.RogueGetInfo);
      }
      if (other.rogueGameInfo_ != null) {
        if (rogueGameInfo_ == null) {
          RogueGameInfo = new global::EggLink.DanhengServer.Proto.ANNNJOLNDHE();
        }
        RogueGameInfo.MergeFrom(other.RogueGameInfo);
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
            if (cGEBKOFBKJO_ == null) {
              CGEBKOFBKJO = new global::EggLink.DanhengServer.Proto.KOGJJMBEDDE();
            }
            input.ReadMessage(CGEBKOFBKJO);
            break;
          }
          case 26: {
            if (rogueGameInfo_ == null) {
              RogueGameInfo = new global::EggLink.DanhengServer.Proto.ANNNJOLNDHE();
            }
            input.ReadMessage(RogueGameInfo);
            break;
          }
          case 74: {
            if (aNNNBHJDMPM_ == null) {
              ANNNBHJDMPM = new global::EggLink.DanhengServer.Proto.JPDHONPICID();
            }
            input.ReadMessage(ANNNBHJDMPM);
            break;
          }
          case 96: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 106: {
            if (info_ == null) {
              Info = new global::EggLink.DanhengServer.Proto.EEPGHLFNDKJ();
            }
            input.ReadMessage(Info);
            break;
          }
          case 122: {
            if (rogueGetInfo_ == null) {
              RogueGetInfo = new global::EggLink.DanhengServer.Proto.IGDKOLNAFKP();
            }
            input.ReadMessage(RogueGetInfo);
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
            if (cGEBKOFBKJO_ == null) {
              CGEBKOFBKJO = new global::EggLink.DanhengServer.Proto.KOGJJMBEDDE();
            }
            input.ReadMessage(CGEBKOFBKJO);
            break;
          }
          case 26: {
            if (rogueGameInfo_ == null) {
              RogueGameInfo = new global::EggLink.DanhengServer.Proto.ANNNJOLNDHE();
            }
            input.ReadMessage(RogueGameInfo);
            break;
          }
          case 74: {
            if (aNNNBHJDMPM_ == null) {
              ANNNBHJDMPM = new global::EggLink.DanhengServer.Proto.JPDHONPICID();
            }
            input.ReadMessage(ANNNBHJDMPM);
            break;
          }
          case 96: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 106: {
            if (info_ == null) {
              Info = new global::EggLink.DanhengServer.Proto.EEPGHLFNDKJ();
            }
            input.ReadMessage(Info);
            break;
          }
          case 122: {
            if (rogueGetInfo_ == null) {
              RogueGetInfo = new global::EggLink.DanhengServer.Proto.IGDKOLNAFKP();
            }
            input.ReadMessage(RogueGetInfo);
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
