// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueCurrentInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueCurrentInfo.proto</summary>
  public static partial class RogueCurrentInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueCurrentInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueCurrentInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZSb2d1ZUN1cnJlbnRJbmZvLnByb3RvGhVSb2d1ZUxpbmV1cEluZm8ucHJv",
            "dG8aElJvZ3VlTWFwSW5mby5wcm90bxoWUm9ndWVWaXJ0dWFsSXRlbS5wcm90",
            "bxoRUm9ndWVTdGF0dXMucHJvdG8aEkdhbWVBZW9uSW5mby5wcm90bxoeUm9n",
            "dWVDb21tb25QZW5kaW5nQWN0aW9uLnByb3RvGhVSb2d1ZU1vZHVsZUluZm8u",
            "cHJvdG8aFUdhbWVNaXJhY2xlSW5mby5wcm90bxoTUm9ndWVCdWZmSW5mby5w",
            "cm90byKVAwoQUm9ndWVDdXJyZW50SW5mbxInCg9yb2d1ZV9idWZmX2luZm8Y",
            "ASABKAsyDi5Sb2d1ZUJ1ZmZJbmZvEg4KBmlzX3dpbhgHIAEoCBItChJyb2d1",
            "ZV92aXJ0dWFsX2l0ZW0YCSABKAsyES5Sb2d1ZVZpcnR1YWxJdGVtEh8KCG1h",
            "cF9pbmZvGAogASgLMg0uUm9ndWVNYXBJbmZvEiUKC21vZHVsZV9pbmZvGAsg",
            "ASgLMhAuUm9ndWVNb2R1bGVJbmZvEjEKDnBlbmRpbmdfYWN0aW9uGA8gASgL",
            "MhkuUm9ndWVDb21tb25QZW5kaW5nQWN0aW9uEiYKD3JvZ3VlX2Flb25faW5m",
            "bxgDIAEoCzINLkdhbWVBZW9uSW5mbxIrChFnYW1lX21pcmFjbGVfaW5mbxgO",
            "IAEoCzIQLkdhbWVNaXJhY2xlSW5mbxIrChFyb2d1ZV9saW5ldXBfaW5mbxgG",
            "IAEoCzIQLlJvZ3VlTGluZXVwSW5mbxIcCgZzdGF0dXMYBCABKA4yDC5Sb2d1",
            "ZVN0YXR1c0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueLineupInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueMapInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueVirtualItemReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueStatusReflection.Descriptor, global::EggLink.DanhengServer.Proto.GameAeonInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueCommonPendingActionReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueModuleInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.GameMiracleInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueBuffInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueCurrentInfo), global::EggLink.DanhengServer.Proto.RogueCurrentInfo.Parser, new[]{ "RogueBuffInfo", "IsWin", "RogueVirtualItem", "MapInfo", "ModuleInfo", "PendingAction", "RogueAeonInfo", "GameMiracleInfo", "RogueLineupInfo", "Status" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueCurrentInfo : pb::IMessage<RogueCurrentInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueCurrentInfo> _parser = new pb::MessageParser<RogueCurrentInfo>(() => new RogueCurrentInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueCurrentInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueCurrentInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueCurrentInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueCurrentInfo(RogueCurrentInfo other) : this() {
      rogueBuffInfo_ = other.rogueBuffInfo_ != null ? other.rogueBuffInfo_.Clone() : null;
      isWin_ = other.isWin_;
      rogueVirtualItem_ = other.rogueVirtualItem_ != null ? other.rogueVirtualItem_.Clone() : null;
      mapInfo_ = other.mapInfo_ != null ? other.mapInfo_.Clone() : null;
      moduleInfo_ = other.moduleInfo_ != null ? other.moduleInfo_.Clone() : null;
      pendingAction_ = other.pendingAction_ != null ? other.pendingAction_.Clone() : null;
      rogueAeonInfo_ = other.rogueAeonInfo_ != null ? other.rogueAeonInfo_.Clone() : null;
      gameMiracleInfo_ = other.gameMiracleInfo_ != null ? other.gameMiracleInfo_.Clone() : null;
      rogueLineupInfo_ = other.rogueLineupInfo_ != null ? other.rogueLineupInfo_.Clone() : null;
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueCurrentInfo Clone() {
      return new RogueCurrentInfo(this);
    }

    /// <summary>Field number for the "rogue_buff_info" field.</summary>
    public const int RogueBuffInfoFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.RogueBuffInfo rogueBuffInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueBuffInfo RogueBuffInfo {
      get { return rogueBuffInfo_; }
      set {
        rogueBuffInfo_ = value;
      }
    }

    /// <summary>Field number for the "is_win" field.</summary>
    public const int IsWinFieldNumber = 7;
    private bool isWin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsWin {
      get { return isWin_; }
      set {
        isWin_ = value;
      }
    }

    /// <summary>Field number for the "rogue_virtual_item" field.</summary>
    public const int RogueVirtualItemFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.RogueVirtualItem rogueVirtualItem_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueVirtualItem RogueVirtualItem {
      get { return rogueVirtualItem_; }
      set {
        rogueVirtualItem_ = value;
      }
    }

    /// <summary>Field number for the "map_info" field.</summary>
    public const int MapInfoFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.RogueMapInfo mapInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueMapInfo MapInfo {
      get { return mapInfo_; }
      set {
        mapInfo_ = value;
      }
    }

    /// <summary>Field number for the "module_info" field.</summary>
    public const int ModuleInfoFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.RogueModuleInfo moduleInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueModuleInfo ModuleInfo {
      get { return moduleInfo_; }
      set {
        moduleInfo_ = value;
      }
    }

    /// <summary>Field number for the "pending_action" field.</summary>
    public const int PendingActionFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.RogueCommonPendingAction pendingAction_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueCommonPendingAction PendingAction {
      get { return pendingAction_; }
      set {
        pendingAction_ = value;
      }
    }

    /// <summary>Field number for the "rogue_aeon_info" field.</summary>
    public const int RogueAeonInfoFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.GameAeonInfo rogueAeonInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.GameAeonInfo RogueAeonInfo {
      get { return rogueAeonInfo_; }
      set {
        rogueAeonInfo_ = value;
      }
    }

    /// <summary>Field number for the "game_miracle_info" field.</summary>
    public const int GameMiracleInfoFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.GameMiracleInfo gameMiracleInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.GameMiracleInfo GameMiracleInfo {
      get { return gameMiracleInfo_; }
      set {
        gameMiracleInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_lineup_info" field.</summary>
    public const int RogueLineupInfoFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.RogueLineupInfo rogueLineupInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueLineupInfo RogueLineupInfo {
      get { return rogueLineupInfo_; }
      set {
        rogueLineupInfo_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 4;
    private global::EggLink.DanhengServer.Proto.RogueStatus status_ = global::EggLink.DanhengServer.Proto.RogueStatus.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueCurrentInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueCurrentInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RogueBuffInfo, other.RogueBuffInfo)) return false;
      if (IsWin != other.IsWin) return false;
      if (!object.Equals(RogueVirtualItem, other.RogueVirtualItem)) return false;
      if (!object.Equals(MapInfo, other.MapInfo)) return false;
      if (!object.Equals(ModuleInfo, other.ModuleInfo)) return false;
      if (!object.Equals(PendingAction, other.PendingAction)) return false;
      if (!object.Equals(RogueAeonInfo, other.RogueAeonInfo)) return false;
      if (!object.Equals(GameMiracleInfo, other.GameMiracleInfo)) return false;
      if (!object.Equals(RogueLineupInfo, other.RogueLineupInfo)) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (rogueBuffInfo_ != null) hash ^= RogueBuffInfo.GetHashCode();
      if (IsWin != false) hash ^= IsWin.GetHashCode();
      if (rogueVirtualItem_ != null) hash ^= RogueVirtualItem.GetHashCode();
      if (mapInfo_ != null) hash ^= MapInfo.GetHashCode();
      if (moduleInfo_ != null) hash ^= ModuleInfo.GetHashCode();
      if (pendingAction_ != null) hash ^= PendingAction.GetHashCode();
      if (rogueAeonInfo_ != null) hash ^= RogueAeonInfo.GetHashCode();
      if (gameMiracleInfo_ != null) hash ^= GameMiracleInfo.GetHashCode();
      if (rogueLineupInfo_ != null) hash ^= RogueLineupInfo.GetHashCode();
      if (Status != global::EggLink.DanhengServer.Proto.RogueStatus.None) hash ^= Status.GetHashCode();
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
      if (rogueBuffInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(RogueBuffInfo);
      }
      if (rogueAeonInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(RogueAeonInfo);
      }
      if (Status != global::EggLink.DanhengServer.Proto.RogueStatus.None) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Status);
      }
      if (rogueLineupInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(RogueLineupInfo);
      }
      if (IsWin != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsWin);
      }
      if (rogueVirtualItem_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(RogueVirtualItem);
      }
      if (mapInfo_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(MapInfo);
      }
      if (moduleInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(ModuleInfo);
      }
      if (gameMiracleInfo_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(GameMiracleInfo);
      }
      if (pendingAction_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(PendingAction);
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
      if (rogueBuffInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(RogueBuffInfo);
      }
      if (rogueAeonInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(RogueAeonInfo);
      }
      if (Status != global::EggLink.DanhengServer.Proto.RogueStatus.None) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Status);
      }
      if (rogueLineupInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(RogueLineupInfo);
      }
      if (IsWin != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsWin);
      }
      if (rogueVirtualItem_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(RogueVirtualItem);
      }
      if (mapInfo_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(MapInfo);
      }
      if (moduleInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(ModuleInfo);
      }
      if (gameMiracleInfo_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(GameMiracleInfo);
      }
      if (pendingAction_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(PendingAction);
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
      if (rogueBuffInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueBuffInfo);
      }
      if (IsWin != false) {
        size += 1 + 1;
      }
      if (rogueVirtualItem_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueVirtualItem);
      }
      if (mapInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MapInfo);
      }
      if (moduleInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ModuleInfo);
      }
      if (pendingAction_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PendingAction);
      }
      if (rogueAeonInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueAeonInfo);
      }
      if (gameMiracleInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GameMiracleInfo);
      }
      if (rogueLineupInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueLineupInfo);
      }
      if (Status != global::EggLink.DanhengServer.Proto.RogueStatus.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueCurrentInfo other) {
      if (other == null) {
        return;
      }
      if (other.rogueBuffInfo_ != null) {
        if (rogueBuffInfo_ == null) {
          RogueBuffInfo = new global::EggLink.DanhengServer.Proto.RogueBuffInfo();
        }
        RogueBuffInfo.MergeFrom(other.RogueBuffInfo);
      }
      if (other.IsWin != false) {
        IsWin = other.IsWin;
      }
      if (other.rogueVirtualItem_ != null) {
        if (rogueVirtualItem_ == null) {
          RogueVirtualItem = new global::EggLink.DanhengServer.Proto.RogueVirtualItem();
        }
        RogueVirtualItem.MergeFrom(other.RogueVirtualItem);
      }
      if (other.mapInfo_ != null) {
        if (mapInfo_ == null) {
          MapInfo = new global::EggLink.DanhengServer.Proto.RogueMapInfo();
        }
        MapInfo.MergeFrom(other.MapInfo);
      }
      if (other.moduleInfo_ != null) {
        if (moduleInfo_ == null) {
          ModuleInfo = new global::EggLink.DanhengServer.Proto.RogueModuleInfo();
        }
        ModuleInfo.MergeFrom(other.ModuleInfo);
      }
      if (other.pendingAction_ != null) {
        if (pendingAction_ == null) {
          PendingAction = new global::EggLink.DanhengServer.Proto.RogueCommonPendingAction();
        }
        PendingAction.MergeFrom(other.PendingAction);
      }
      if (other.rogueAeonInfo_ != null) {
        if (rogueAeonInfo_ == null) {
          RogueAeonInfo = new global::EggLink.DanhengServer.Proto.GameAeonInfo();
        }
        RogueAeonInfo.MergeFrom(other.RogueAeonInfo);
      }
      if (other.gameMiracleInfo_ != null) {
        if (gameMiracleInfo_ == null) {
          GameMiracleInfo = new global::EggLink.DanhengServer.Proto.GameMiracleInfo();
        }
        GameMiracleInfo.MergeFrom(other.GameMiracleInfo);
      }
      if (other.rogueLineupInfo_ != null) {
        if (rogueLineupInfo_ == null) {
          RogueLineupInfo = new global::EggLink.DanhengServer.Proto.RogueLineupInfo();
        }
        RogueLineupInfo.MergeFrom(other.RogueLineupInfo);
      }
      if (other.Status != global::EggLink.DanhengServer.Proto.RogueStatus.None) {
        Status = other.Status;
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
            if (rogueBuffInfo_ == null) {
              RogueBuffInfo = new global::EggLink.DanhengServer.Proto.RogueBuffInfo();
            }
            input.ReadMessage(RogueBuffInfo);
            break;
          }
          case 26: {
            if (rogueAeonInfo_ == null) {
              RogueAeonInfo = new global::EggLink.DanhengServer.Proto.GameAeonInfo();
            }
            input.ReadMessage(RogueAeonInfo);
            break;
          }
          case 32: {
            Status = (global::EggLink.DanhengServer.Proto.RogueStatus) input.ReadEnum();
            break;
          }
          case 50: {
            if (rogueLineupInfo_ == null) {
              RogueLineupInfo = new global::EggLink.DanhengServer.Proto.RogueLineupInfo();
            }
            input.ReadMessage(RogueLineupInfo);
            break;
          }
          case 56: {
            IsWin = input.ReadBool();
            break;
          }
          case 74: {
            if (rogueVirtualItem_ == null) {
              RogueVirtualItem = new global::EggLink.DanhengServer.Proto.RogueVirtualItem();
            }
            input.ReadMessage(RogueVirtualItem);
            break;
          }
          case 82: {
            if (mapInfo_ == null) {
              MapInfo = new global::EggLink.DanhengServer.Proto.RogueMapInfo();
            }
            input.ReadMessage(MapInfo);
            break;
          }
          case 90: {
            if (moduleInfo_ == null) {
              ModuleInfo = new global::EggLink.DanhengServer.Proto.RogueModuleInfo();
            }
            input.ReadMessage(ModuleInfo);
            break;
          }
          case 114: {
            if (gameMiracleInfo_ == null) {
              GameMiracleInfo = new global::EggLink.DanhengServer.Proto.GameMiracleInfo();
            }
            input.ReadMessage(GameMiracleInfo);
            break;
          }
          case 122: {
            if (pendingAction_ == null) {
              PendingAction = new global::EggLink.DanhengServer.Proto.RogueCommonPendingAction();
            }
            input.ReadMessage(PendingAction);
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
            if (rogueBuffInfo_ == null) {
              RogueBuffInfo = new global::EggLink.DanhengServer.Proto.RogueBuffInfo();
            }
            input.ReadMessage(RogueBuffInfo);
            break;
          }
          case 26: {
            if (rogueAeonInfo_ == null) {
              RogueAeonInfo = new global::EggLink.DanhengServer.Proto.GameAeonInfo();
            }
            input.ReadMessage(RogueAeonInfo);
            break;
          }
          case 32: {
            Status = (global::EggLink.DanhengServer.Proto.RogueStatus) input.ReadEnum();
            break;
          }
          case 50: {
            if (rogueLineupInfo_ == null) {
              RogueLineupInfo = new global::EggLink.DanhengServer.Proto.RogueLineupInfo();
            }
            input.ReadMessage(RogueLineupInfo);
            break;
          }
          case 56: {
            IsWin = input.ReadBool();
            break;
          }
          case 74: {
            if (rogueVirtualItem_ == null) {
              RogueVirtualItem = new global::EggLink.DanhengServer.Proto.RogueVirtualItem();
            }
            input.ReadMessage(RogueVirtualItem);
            break;
          }
          case 82: {
            if (mapInfo_ == null) {
              MapInfo = new global::EggLink.DanhengServer.Proto.RogueMapInfo();
            }
            input.ReadMessage(MapInfo);
            break;
          }
          case 90: {
            if (moduleInfo_ == null) {
              ModuleInfo = new global::EggLink.DanhengServer.Proto.RogueModuleInfo();
            }
            input.ReadMessage(ModuleInfo);
            break;
          }
          case 114: {
            if (gameMiracleInfo_ == null) {
              GameMiracleInfo = new global::EggLink.DanhengServer.Proto.GameMiracleInfo();
            }
            input.ReadMessage(GameMiracleInfo);
            break;
          }
          case 122: {
            if (pendingAction_ == null) {
              PendingAction = new global::EggLink.DanhengServer.Proto.RogueCommonPendingAction();
            }
            input.ReadMessage(PendingAction);
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
