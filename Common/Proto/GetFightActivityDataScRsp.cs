// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetFightActivityDataScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetFightActivityDataScRsp.proto</summary>
  public static partial class GetFightActivityDataScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetFightActivityDataScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetFightActivityDataScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9HZXRGaWdodEFjdGl2aXR5RGF0YVNjUnNwLnByb3RvGhhGaWdodEFjdGl2",
            "aXR5R3JvdXAucHJvdG8ihAIKGUdldEZpZ2h0QWN0aXZpdHlEYXRhU2NSc3AS",
            "EwoLT0RPREpPTkROR0YYAyABKAgSEwoLd29ybGRfbGV2ZWwYASABKA0SNgoZ",
            "ZmlnaHRfYWN0aXZpdHlfZ3JvdXBfbGlzdBgLIAMoCzITLkZpZ2h0QWN0aXZp",
            "dHlHcm91cBJACgtERU1GTkhNREFDQhgPIAMoCzIrLkdldEZpZ2h0QWN0aXZp",
            "dHlEYXRhU2NSc3AuREVNRk5ITURBQ0JFbnRyeRIPCgdyZXRjb2RlGA0gASgN",
            "GjIKEERFTUZOSE1EQUNCRW50cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVlGAIg",
            "ASgNOgI4AUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.FightActivityGroupReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetFightActivityDataScRsp), global::EggLink.DanhengServer.Proto.GetFightActivityDataScRsp.Parser, new[]{ "ODODJONDNGF", "WorldLevel", "FightActivityGroupList", "DEMFNHMDACB", "Retcode" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetFightActivityDataScRsp : pb::IMessage<GetFightActivityDataScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetFightActivityDataScRsp> _parser = new pb::MessageParser<GetFightActivityDataScRsp>(() => new GetFightActivityDataScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetFightActivityDataScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetFightActivityDataScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetFightActivityDataScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetFightActivityDataScRsp(GetFightActivityDataScRsp other) : this() {
      oDODJONDNGF_ = other.oDODJONDNGF_;
      worldLevel_ = other.worldLevel_;
      fightActivityGroupList_ = other.fightActivityGroupList_.Clone();
      dEMFNHMDACB_ = other.dEMFNHMDACB_.Clone();
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetFightActivityDataScRsp Clone() {
      return new GetFightActivityDataScRsp(this);
    }

    /// <summary>Field number for the "ODODJONDNGF" field.</summary>
    public const int ODODJONDNGFFieldNumber = 3;
    private bool oDODJONDNGF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool ODODJONDNGF {
      get { return oDODJONDNGF_; }
      set {
        oDODJONDNGF_ = value;
      }
    }

    /// <summary>Field number for the "world_level" field.</summary>
    public const int WorldLevelFieldNumber = 1;
    private uint worldLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WorldLevel {
      get { return worldLevel_; }
      set {
        worldLevel_ = value;
      }
    }

    /// <summary>Field number for the "fight_activity_group_list" field.</summary>
    public const int FightActivityGroupListFieldNumber = 11;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.FightActivityGroup> _repeated_fightActivityGroupList_codec
        = pb::FieldCodec.ForMessage(90, global::EggLink.DanhengServer.Proto.FightActivityGroup.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FightActivityGroup> fightActivityGroupList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FightActivityGroup>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FightActivityGroup> FightActivityGroupList {
      get { return fightActivityGroupList_; }
    }

    /// <summary>Field number for the "DEMFNHMDACB" field.</summary>
    public const int DEMFNHMDACBFieldNumber = 15;
    private static readonly pbc::MapField<uint, uint>.Codec _map_dEMFNHMDACB_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 122);
    private readonly pbc::MapField<uint, uint> dEMFNHMDACB_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> DEMFNHMDACB {
      get { return dEMFNHMDACB_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 13;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetFightActivityDataScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetFightActivityDataScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ODODJONDNGF != other.ODODJONDNGF) return false;
      if (WorldLevel != other.WorldLevel) return false;
      if(!fightActivityGroupList_.Equals(other.fightActivityGroupList_)) return false;
      if (!DEMFNHMDACB.Equals(other.DEMFNHMDACB)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ODODJONDNGF != false) hash ^= ODODJONDNGF.GetHashCode();
      if (WorldLevel != 0) hash ^= WorldLevel.GetHashCode();
      hash ^= fightActivityGroupList_.GetHashCode();
      hash ^= DEMFNHMDACB.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (WorldLevel != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(WorldLevel);
      }
      if (ODODJONDNGF != false) {
        output.WriteRawTag(24);
        output.WriteBool(ODODJONDNGF);
      }
      fightActivityGroupList_.WriteTo(output, _repeated_fightActivityGroupList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Retcode);
      }
      dEMFNHMDACB_.WriteTo(output, _map_dEMFNHMDACB_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (WorldLevel != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(WorldLevel);
      }
      if (ODODJONDNGF != false) {
        output.WriteRawTag(24);
        output.WriteBool(ODODJONDNGF);
      }
      fightActivityGroupList_.WriteTo(ref output, _repeated_fightActivityGroupList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Retcode);
      }
      dEMFNHMDACB_.WriteTo(ref output, _map_dEMFNHMDACB_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ODODJONDNGF != false) {
        size += 1 + 1;
      }
      if (WorldLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WorldLevel);
      }
      size += fightActivityGroupList_.CalculateSize(_repeated_fightActivityGroupList_codec);
      size += dEMFNHMDACB_.CalculateSize(_map_dEMFNHMDACB_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetFightActivityDataScRsp other) {
      if (other == null) {
        return;
      }
      if (other.ODODJONDNGF != false) {
        ODODJONDNGF = other.ODODJONDNGF;
      }
      if (other.WorldLevel != 0) {
        WorldLevel = other.WorldLevel;
      }
      fightActivityGroupList_.Add(other.fightActivityGroupList_);
      dEMFNHMDACB_.MergeFrom(other.dEMFNHMDACB_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 24: {
            ODODJONDNGF = input.ReadBool();
            break;
          }
          case 90: {
            fightActivityGroupList_.AddEntriesFrom(input, _repeated_fightActivityGroupList_codec);
            break;
          }
          case 104: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 122: {
            dEMFNHMDACB_.AddEntriesFrom(input, _map_dEMFNHMDACB_codec);
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
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 24: {
            ODODJONDNGF = input.ReadBool();
            break;
          }
          case 90: {
            fightActivityGroupList_.AddEntriesFrom(ref input, _repeated_fightActivityGroupList_codec);
            break;
          }
          case 104: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 122: {
            dEMFNHMDACB_.AddEntriesFrom(ref input, _map_dEMFNHMDACB_codec);
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
