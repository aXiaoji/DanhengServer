// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueMoveCellNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueMoveCellNotify.proto</summary>
  public static partial class ChessRogueMoveCellNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueMoveCellNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueMoveCellNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5DaGVzc1JvZ3VlTW92ZUNlbGxOb3RpZnkucHJvdG8aGENoZXNzUm9ndWVD",
            "ZWxsSW5mby5wcm90byJnChhDaGVzc1JvZ3VlTW92ZUNlbGxOb3RpZnkSEwoL",
            "S0RCRENNTEhJTk4YByABKA0SEwoLUEhJSUdDS0NJS0gYBSABKA0SIQoEY2Vs",
            "bBgCIAEoCzITLkNoZXNzUm9ndWVDZWxsSW5mb0IeqgIbRWdnTGluay5EYW5o",
            "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChessRogueCellInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueMoveCellNotify), global::EggLink.DanhengServer.Proto.ChessRogueMoveCellNotify.Parser, new[]{ "KDBDCMLHINN", "PHIIGCKCIKH", "Cell" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueMoveCellNotify : pb::IMessage<ChessRogueMoveCellNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueMoveCellNotify> _parser = new pb::MessageParser<ChessRogueMoveCellNotify>(() => new ChessRogueMoveCellNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueMoveCellNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueMoveCellNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueMoveCellNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueMoveCellNotify(ChessRogueMoveCellNotify other) : this() {
      kDBDCMLHINN_ = other.kDBDCMLHINN_;
      pHIIGCKCIKH_ = other.pHIIGCKCIKH_;
      cell_ = other.cell_ != null ? other.cell_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueMoveCellNotify Clone() {
      return new ChessRogueMoveCellNotify(this);
    }

    /// <summary>Field number for the "KDBDCMLHINN" field.</summary>
    public const int KDBDCMLHINNFieldNumber = 7;
    private uint kDBDCMLHINN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KDBDCMLHINN {
      get { return kDBDCMLHINN_; }
      set {
        kDBDCMLHINN_ = value;
      }
    }

    /// <summary>Field number for the "PHIIGCKCIKH" field.</summary>
    public const int PHIIGCKCIKHFieldNumber = 5;
    private uint pHIIGCKCIKH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PHIIGCKCIKH {
      get { return pHIIGCKCIKH_; }
      set {
        pHIIGCKCIKH_ = value;
      }
    }

    /// <summary>Field number for the "cell" field.</summary>
    public const int CellFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.ChessRogueCellInfo cell_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueCellInfo Cell {
      get { return cell_; }
      set {
        cell_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueMoveCellNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueMoveCellNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (KDBDCMLHINN != other.KDBDCMLHINN) return false;
      if (PHIIGCKCIKH != other.PHIIGCKCIKH) return false;
      if (!object.Equals(Cell, other.Cell)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (KDBDCMLHINN != 0) hash ^= KDBDCMLHINN.GetHashCode();
      if (PHIIGCKCIKH != 0) hash ^= PHIIGCKCIKH.GetHashCode();
      if (cell_ != null) hash ^= Cell.GetHashCode();
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
      if (cell_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Cell);
      }
      if (PHIIGCKCIKH != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(PHIIGCKCIKH);
      }
      if (KDBDCMLHINN != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(KDBDCMLHINN);
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
      if (cell_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Cell);
      }
      if (PHIIGCKCIKH != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(PHIIGCKCIKH);
      }
      if (KDBDCMLHINN != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(KDBDCMLHINN);
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
      if (KDBDCMLHINN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KDBDCMLHINN);
      }
      if (PHIIGCKCIKH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PHIIGCKCIKH);
      }
      if (cell_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Cell);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueMoveCellNotify other) {
      if (other == null) {
        return;
      }
      if (other.KDBDCMLHINN != 0) {
        KDBDCMLHINN = other.KDBDCMLHINN;
      }
      if (other.PHIIGCKCIKH != 0) {
        PHIIGCKCIKH = other.PHIIGCKCIKH;
      }
      if (other.cell_ != null) {
        if (cell_ == null) {
          Cell = new global::EggLink.DanhengServer.Proto.ChessRogueCellInfo();
        }
        Cell.MergeFrom(other.Cell);
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
          case 18: {
            if (cell_ == null) {
              Cell = new global::EggLink.DanhengServer.Proto.ChessRogueCellInfo();
            }
            input.ReadMessage(Cell);
            break;
          }
          case 40: {
            PHIIGCKCIKH = input.ReadUInt32();
            break;
          }
          case 56: {
            KDBDCMLHINN = input.ReadUInt32();
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
          case 18: {
            if (cell_ == null) {
              Cell = new global::EggLink.DanhengServer.Proto.ChessRogueCellInfo();
            }
            input.ReadMessage(Cell);
            break;
          }
          case 40: {
            PHIIGCKCIKH = input.ReadUInt32();
            break;
          }
          case 56: {
            KDBDCMLHINN = input.ReadUInt32();
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
