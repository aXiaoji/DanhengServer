// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: KDNDJFKCFAC.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from KDNDJFKCFAC.proto</summary>
  public static partial class KDNDJFKCFACReflection {

    #region Descriptor
    /// <summary>File descriptor for KDNDJFKCFAC.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KDNDJFKCFACReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFLRE5ESkZLQ0ZBQy5wcm90bxoRTEZKR0FDTEJLRUgucHJvdG8iqgEKC0tE",
            "TkRKRktDRkFDEhMKC0xGQUtIQkxJTUxJGAUgASgNEjIKC0lKSUxDT05OS09J",
            "GAsgAygLMh0uS0ROREpGS0NGQUMuSUpJTENPTk5LT0lFbnRyeRIQCghwYW5l",
            "bF9pZBgKIAEoDRpAChBJSklMQ09OTktPSUVudHJ5EgsKA2tleRgBIAEoDRIb",
            "CgV2YWx1ZRgCIAEoCzIMLkxGSkdBQ0xCS0VIOgI4AUIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.LFJGACLBKEHReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.KDNDJFKCFAC), global::EggLink.DanhengServer.Proto.KDNDJFKCFAC.Parser, new[]{ "LFAKHBLIMLI", "IJILCONNKOI", "PanelId" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class KDNDJFKCFAC : pb::IMessage<KDNDJFKCFAC>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<KDNDJFKCFAC> _parser = new pb::MessageParser<KDNDJFKCFAC>(() => new KDNDJFKCFAC());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<KDNDJFKCFAC> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.KDNDJFKCFACReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KDNDJFKCFAC() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KDNDJFKCFAC(KDNDJFKCFAC other) : this() {
      lFAKHBLIMLI_ = other.lFAKHBLIMLI_;
      iJILCONNKOI_ = other.iJILCONNKOI_.Clone();
      panelId_ = other.panelId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KDNDJFKCFAC Clone() {
      return new KDNDJFKCFAC(this);
    }

    /// <summary>Field number for the "LFAKHBLIMLI" field.</summary>
    public const int LFAKHBLIMLIFieldNumber = 5;
    private uint lFAKHBLIMLI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LFAKHBLIMLI {
      get { return lFAKHBLIMLI_; }
      set {
        lFAKHBLIMLI_ = value;
      }
    }

    /// <summary>Field number for the "IJILCONNKOI" field.</summary>
    public const int IJILCONNKOIFieldNumber = 11;
    private static readonly pbc::MapField<uint, global::EggLink.DanhengServer.Proto.LFJGACLBKEH>.Codec _map_iJILCONNKOI_codec
        = new pbc::MapField<uint, global::EggLink.DanhengServer.Proto.LFJGACLBKEH>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::EggLink.DanhengServer.Proto.LFJGACLBKEH.Parser), 90);
    private readonly pbc::MapField<uint, global::EggLink.DanhengServer.Proto.LFJGACLBKEH> iJILCONNKOI_ = new pbc::MapField<uint, global::EggLink.DanhengServer.Proto.LFJGACLBKEH>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::EggLink.DanhengServer.Proto.LFJGACLBKEH> IJILCONNKOI {
      get { return iJILCONNKOI_; }
    }

    /// <summary>Field number for the "panel_id" field.</summary>
    public const int PanelIdFieldNumber = 10;
    private uint panelId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PanelId {
      get { return panelId_; }
      set {
        panelId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as KDNDJFKCFAC);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(KDNDJFKCFAC other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LFAKHBLIMLI != other.LFAKHBLIMLI) return false;
      if (!IJILCONNKOI.Equals(other.IJILCONNKOI)) return false;
      if (PanelId != other.PanelId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (LFAKHBLIMLI != 0) hash ^= LFAKHBLIMLI.GetHashCode();
      hash ^= IJILCONNKOI.GetHashCode();
      if (PanelId != 0) hash ^= PanelId.GetHashCode();
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
      if (LFAKHBLIMLI != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(LFAKHBLIMLI);
      }
      if (PanelId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(PanelId);
      }
      iJILCONNKOI_.WriteTo(output, _map_iJILCONNKOI_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (LFAKHBLIMLI != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(LFAKHBLIMLI);
      }
      if (PanelId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(PanelId);
      }
      iJILCONNKOI_.WriteTo(ref output, _map_iJILCONNKOI_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (LFAKHBLIMLI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LFAKHBLIMLI);
      }
      size += iJILCONNKOI_.CalculateSize(_map_iJILCONNKOI_codec);
      if (PanelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PanelId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(KDNDJFKCFAC other) {
      if (other == null) {
        return;
      }
      if (other.LFAKHBLIMLI != 0) {
        LFAKHBLIMLI = other.LFAKHBLIMLI;
      }
      iJILCONNKOI_.MergeFrom(other.iJILCONNKOI_);
      if (other.PanelId != 0) {
        PanelId = other.PanelId;
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
          case 40: {
            LFAKHBLIMLI = input.ReadUInt32();
            break;
          }
          case 80: {
            PanelId = input.ReadUInt32();
            break;
          }
          case 90: {
            iJILCONNKOI_.AddEntriesFrom(input, _map_iJILCONNKOI_codec);
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
          case 40: {
            LFAKHBLIMLI = input.ReadUInt32();
            break;
          }
          case 80: {
            PanelId = input.ReadUInt32();
            break;
          }
          case 90: {
            iJILCONNKOI_.AddEntriesFrom(ref input, _map_iJILCONNKOI_codec);
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
