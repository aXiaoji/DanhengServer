// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueUpdateAllowedSelectCellScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueUpdateAllowedSelectCellScNotify.proto</summary>
  public static partial class ChessRogueUpdateAllowedSelectCellScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueUpdateAllowedSelectCellScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueUpdateAllowedSelectCellScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9DaGVzc1JvZ3VlVXBkYXRlQWxsb3dlZFNlbGVjdENlbGxTY05vdGlmeS5w",
            "cm90byJlCilDaGVzc1JvZ3VlVXBkYXRlQWxsb3dlZFNlbGVjdENlbGxTY05v",
            "dGlmeRITCgtLREVHS0lBS0VKQRgJIAEoDRIjChthbGxvd2VkX3NlbGVjdF9j",
            "ZWxsX2lkX2xpc3QYCiADKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Q",
            "cm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueUpdateAllowedSelectCellScNotify), global::EggLink.DanhengServer.Proto.ChessRogueUpdateAllowedSelectCellScNotify.Parser, new[]{ "KDEGKIAKEJA", "AllowedSelectCellIdList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueUpdateAllowedSelectCellScNotify : pb::IMessage<ChessRogueUpdateAllowedSelectCellScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueUpdateAllowedSelectCellScNotify> _parser = new pb::MessageParser<ChessRogueUpdateAllowedSelectCellScNotify>(() => new ChessRogueUpdateAllowedSelectCellScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueUpdateAllowedSelectCellScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueUpdateAllowedSelectCellScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueUpdateAllowedSelectCellScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueUpdateAllowedSelectCellScNotify(ChessRogueUpdateAllowedSelectCellScNotify other) : this() {
      kDEGKIAKEJA_ = other.kDEGKIAKEJA_;
      allowedSelectCellIdList_ = other.allowedSelectCellIdList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueUpdateAllowedSelectCellScNotify Clone() {
      return new ChessRogueUpdateAllowedSelectCellScNotify(this);
    }

    /// <summary>Field number for the "KDEGKIAKEJA" field.</summary>
    public const int KDEGKIAKEJAFieldNumber = 9;
    private uint kDEGKIAKEJA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KDEGKIAKEJA {
      get { return kDEGKIAKEJA_; }
      set {
        kDEGKIAKEJA_ = value;
      }
    }

    /// <summary>Field number for the "allowed_select_cell_id_list" field.</summary>
    public const int AllowedSelectCellIdListFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_allowedSelectCellIdList_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> allowedSelectCellIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> AllowedSelectCellIdList {
      get { return allowedSelectCellIdList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueUpdateAllowedSelectCellScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueUpdateAllowedSelectCellScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (KDEGKIAKEJA != other.KDEGKIAKEJA) return false;
      if(!allowedSelectCellIdList_.Equals(other.allowedSelectCellIdList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (KDEGKIAKEJA != 0) hash ^= KDEGKIAKEJA.GetHashCode();
      hash ^= allowedSelectCellIdList_.GetHashCode();
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
      if (KDEGKIAKEJA != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(KDEGKIAKEJA);
      }
      allowedSelectCellIdList_.WriteTo(output, _repeated_allowedSelectCellIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (KDEGKIAKEJA != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(KDEGKIAKEJA);
      }
      allowedSelectCellIdList_.WriteTo(ref output, _repeated_allowedSelectCellIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (KDEGKIAKEJA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KDEGKIAKEJA);
      }
      size += allowedSelectCellIdList_.CalculateSize(_repeated_allowedSelectCellIdList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueUpdateAllowedSelectCellScNotify other) {
      if (other == null) {
        return;
      }
      if (other.KDEGKIAKEJA != 0) {
        KDEGKIAKEJA = other.KDEGKIAKEJA;
      }
      allowedSelectCellIdList_.Add(other.allowedSelectCellIdList_);
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
          case 72: {
            KDEGKIAKEJA = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            allowedSelectCellIdList_.AddEntriesFrom(input, _repeated_allowedSelectCellIdList_codec);
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
          case 72: {
            KDEGKIAKEJA = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            allowedSelectCellIdList_.AddEntriesFrom(ref input, _repeated_allowedSelectCellIdList_codec);
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
