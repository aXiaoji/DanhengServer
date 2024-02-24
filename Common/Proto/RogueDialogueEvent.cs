// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueDialogueEvent.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueDialogueEvent.proto</summary>
  public static partial class RogueDialogueEventReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueDialogueEvent.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueDialogueEventReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhSb2d1ZURpYWxvZ3VlRXZlbnQucHJvdG8aHVJvZ3VlRGlhbG9ndWVFdmVu",
            "dFBhcmFtLnByb3RvIr0BChJSb2d1ZURpYWxvZ3VlRXZlbnQSEwoLSU5KUEZB",
            "TE1ESEoYByABKA0SFgoOZ2FtZV9tb2RlX3R5cGUYDSABKA0SEwoLR0JNREJC",
            "Qk1CRUoYBiABKA0SDgoGbnBjX2lkGAEgASgNEjwKGnJvZ3VlX2RpYWxvZ3Vl",
            "X2V2ZW50X3BhcmFtGA8gAygLMhguUm9ndWVEaWFsb2d1ZUV2ZW50UGFyYW0S",
            "FwoPc2VsZWN0X2V2ZW50X2lkGAggAygNQh6qAhtFZ2dMaW5rLkRhbmhlbmdT",
            "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueDialogueEventParamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueDialogueEvent), global::EggLink.DanhengServer.Proto.RogueDialogueEvent.Parser, new[]{ "INJPFALMDHJ", "GameModeType", "GBMDBBBMBEJ", "NpcId", "RogueDialogueEventParam", "SelectEventId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueDialogueEvent : pb::IMessage<RogueDialogueEvent>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueDialogueEvent> _parser = new pb::MessageParser<RogueDialogueEvent>(() => new RogueDialogueEvent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueDialogueEvent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueDialogueEventReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDialogueEvent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDialogueEvent(RogueDialogueEvent other) : this() {
      iNJPFALMDHJ_ = other.iNJPFALMDHJ_;
      gameModeType_ = other.gameModeType_;
      gBMDBBBMBEJ_ = other.gBMDBBBMBEJ_;
      npcId_ = other.npcId_;
      rogueDialogueEventParam_ = other.rogueDialogueEventParam_.Clone();
      selectEventId_ = other.selectEventId_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDialogueEvent Clone() {
      return new RogueDialogueEvent(this);
    }

    /// <summary>Field number for the "INJPFALMDHJ" field.</summary>
    public const int INJPFALMDHJFieldNumber = 7;
    private uint iNJPFALMDHJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint INJPFALMDHJ {
      get { return iNJPFALMDHJ_; }
      set {
        iNJPFALMDHJ_ = value;
      }
    }

    /// <summary>Field number for the "game_mode_type" field.</summary>
    public const int GameModeTypeFieldNumber = 13;
    private uint gameModeType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GameModeType {
      get { return gameModeType_; }
      set {
        gameModeType_ = value;
      }
    }

    /// <summary>Field number for the "GBMDBBBMBEJ" field.</summary>
    public const int GBMDBBBMBEJFieldNumber = 6;
    private uint gBMDBBBMBEJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GBMDBBBMBEJ {
      get { return gBMDBBBMBEJ_; }
      set {
        gBMDBBBMBEJ_ = value;
      }
    }

    /// <summary>Field number for the "npc_id" field.</summary>
    public const int NpcIdFieldNumber = 1;
    private uint npcId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NpcId {
      get { return npcId_; }
      set {
        npcId_ = value;
      }
    }

    /// <summary>Field number for the "rogue_dialogue_event_param" field.</summary>
    public const int RogueDialogueEventParamFieldNumber = 15;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.RogueDialogueEventParam> _repeated_rogueDialogueEventParam_codec
        = pb::FieldCodec.ForMessage(122, global::EggLink.DanhengServer.Proto.RogueDialogueEventParam.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueDialogueEventParam> rogueDialogueEventParam_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueDialogueEventParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueDialogueEventParam> RogueDialogueEventParam {
      get { return rogueDialogueEventParam_; }
    }

    /// <summary>Field number for the "select_event_id" field.</summary>
    public const int SelectEventIdFieldNumber = 8;
    private static readonly pb::FieldCodec<uint> _repeated_selectEventId_codec
        = pb::FieldCodec.ForUInt32(66);
    private readonly pbc::RepeatedField<uint> selectEventId_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> SelectEventId {
      get { return selectEventId_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueDialogueEvent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueDialogueEvent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (INJPFALMDHJ != other.INJPFALMDHJ) return false;
      if (GameModeType != other.GameModeType) return false;
      if (GBMDBBBMBEJ != other.GBMDBBBMBEJ) return false;
      if (NpcId != other.NpcId) return false;
      if(!rogueDialogueEventParam_.Equals(other.rogueDialogueEventParam_)) return false;
      if(!selectEventId_.Equals(other.selectEventId_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (INJPFALMDHJ != 0) hash ^= INJPFALMDHJ.GetHashCode();
      if (GameModeType != 0) hash ^= GameModeType.GetHashCode();
      if (GBMDBBBMBEJ != 0) hash ^= GBMDBBBMBEJ.GetHashCode();
      if (NpcId != 0) hash ^= NpcId.GetHashCode();
      hash ^= rogueDialogueEventParam_.GetHashCode();
      hash ^= selectEventId_.GetHashCode();
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
      if (NpcId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(NpcId);
      }
      if (GBMDBBBMBEJ != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(GBMDBBBMBEJ);
      }
      if (INJPFALMDHJ != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(INJPFALMDHJ);
      }
      selectEventId_.WriteTo(output, _repeated_selectEventId_codec);
      if (GameModeType != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(GameModeType);
      }
      rogueDialogueEventParam_.WriteTo(output, _repeated_rogueDialogueEventParam_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (NpcId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(NpcId);
      }
      if (GBMDBBBMBEJ != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(GBMDBBBMBEJ);
      }
      if (INJPFALMDHJ != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(INJPFALMDHJ);
      }
      selectEventId_.WriteTo(ref output, _repeated_selectEventId_codec);
      if (GameModeType != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(GameModeType);
      }
      rogueDialogueEventParam_.WriteTo(ref output, _repeated_rogueDialogueEventParam_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (INJPFALMDHJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(INJPFALMDHJ);
      }
      if (GameModeType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GameModeType);
      }
      if (GBMDBBBMBEJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GBMDBBBMBEJ);
      }
      if (NpcId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NpcId);
      }
      size += rogueDialogueEventParam_.CalculateSize(_repeated_rogueDialogueEventParam_codec);
      size += selectEventId_.CalculateSize(_repeated_selectEventId_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueDialogueEvent other) {
      if (other == null) {
        return;
      }
      if (other.INJPFALMDHJ != 0) {
        INJPFALMDHJ = other.INJPFALMDHJ;
      }
      if (other.GameModeType != 0) {
        GameModeType = other.GameModeType;
      }
      if (other.GBMDBBBMBEJ != 0) {
        GBMDBBBMBEJ = other.GBMDBBBMBEJ;
      }
      if (other.NpcId != 0) {
        NpcId = other.NpcId;
      }
      rogueDialogueEventParam_.Add(other.rogueDialogueEventParam_);
      selectEventId_.Add(other.selectEventId_);
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
            NpcId = input.ReadUInt32();
            break;
          }
          case 48: {
            GBMDBBBMBEJ = input.ReadUInt32();
            break;
          }
          case 56: {
            INJPFALMDHJ = input.ReadUInt32();
            break;
          }
          case 66:
          case 64: {
            selectEventId_.AddEntriesFrom(input, _repeated_selectEventId_codec);
            break;
          }
          case 104: {
            GameModeType = input.ReadUInt32();
            break;
          }
          case 122: {
            rogueDialogueEventParam_.AddEntriesFrom(input, _repeated_rogueDialogueEventParam_codec);
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
            NpcId = input.ReadUInt32();
            break;
          }
          case 48: {
            GBMDBBBMBEJ = input.ReadUInt32();
            break;
          }
          case 56: {
            INJPFALMDHJ = input.ReadUInt32();
            break;
          }
          case 66:
          case 64: {
            selectEventId_.AddEntriesFrom(ref input, _repeated_selectEventId_codec);
            break;
          }
          case 104: {
            GameModeType = input.ReadUInt32();
            break;
          }
          case 122: {
            rogueDialogueEventParam_.AddEntriesFrom(ref input, _repeated_rogueDialogueEventParam_codec);
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