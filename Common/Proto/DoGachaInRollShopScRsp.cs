// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DoGachaInRollShopScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from DoGachaInRollShopScRsp.proto</summary>
  public static partial class DoGachaInRollShopScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for DoGachaInRollShopScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DoGachaInRollShopScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxEb0dhY2hhSW5Sb2xsU2hvcFNjUnNwLnByb3RvGg5JdGVtTGlzdC5wcm90",
            "byKEAQoWRG9HYWNoYUluUm9sbFNob3BTY1JzcBIPCgdyZXRjb2RlGAcgASgN",
            "EhkKBnJld2FyZBgJIAEoCzIJLkl0ZW1MaXN0EhMKC0xFSkpPSkdOSUhLGAQg",
            "ASgNEhQKDHJvbGxfc2hvcF9pZBgIIAEoDRITCgtBRk1QREJCSENITRgCIAEo",
            "DUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.DoGachaInRollShopScRsp), global::EggLink.DanhengServer.Proto.DoGachaInRollShopScRsp.Parser, new[]{ "Retcode", "Reward", "LEJJOJGNIHK", "RollShopId", "AFMPDBBHCHM" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DoGachaInRollShopScRsp : pb::IMessage<DoGachaInRollShopScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DoGachaInRollShopScRsp> _parser = new pb::MessageParser<DoGachaInRollShopScRsp>(() => new DoGachaInRollShopScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DoGachaInRollShopScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.DoGachaInRollShopScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DoGachaInRollShopScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DoGachaInRollShopScRsp(DoGachaInRollShopScRsp other) : this() {
      retcode_ = other.retcode_;
      reward_ = other.reward_ != null ? other.reward_.Clone() : null;
      lEJJOJGNIHK_ = other.lEJJOJGNIHK_;
      rollShopId_ = other.rollShopId_;
      aFMPDBBHCHM_ = other.aFMPDBBHCHM_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DoGachaInRollShopScRsp Clone() {
      return new DoGachaInRollShopScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 7;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "reward" field.</summary>
    public const int RewardFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.ItemList reward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList Reward {
      get { return reward_; }
      set {
        reward_ = value;
      }
    }

    /// <summary>Field number for the "LEJJOJGNIHK" field.</summary>
    public const int LEJJOJGNIHKFieldNumber = 4;
    private uint lEJJOJGNIHK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LEJJOJGNIHK {
      get { return lEJJOJGNIHK_; }
      set {
        lEJJOJGNIHK_ = value;
      }
    }

    /// <summary>Field number for the "roll_shop_id" field.</summary>
    public const int RollShopIdFieldNumber = 8;
    private uint rollShopId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RollShopId {
      get { return rollShopId_; }
      set {
        rollShopId_ = value;
      }
    }

    /// <summary>Field number for the "AFMPDBBHCHM" field.</summary>
    public const int AFMPDBBHCHMFieldNumber = 2;
    private uint aFMPDBBHCHM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AFMPDBBHCHM {
      get { return aFMPDBBHCHM_; }
      set {
        aFMPDBBHCHM_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DoGachaInRollShopScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DoGachaInRollShopScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(Reward, other.Reward)) return false;
      if (LEJJOJGNIHK != other.LEJJOJGNIHK) return false;
      if (RollShopId != other.RollShopId) return false;
      if (AFMPDBBHCHM != other.AFMPDBBHCHM) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (reward_ != null) hash ^= Reward.GetHashCode();
      if (LEJJOJGNIHK != 0) hash ^= LEJJOJGNIHK.GetHashCode();
      if (RollShopId != 0) hash ^= RollShopId.GetHashCode();
      if (AFMPDBBHCHM != 0) hash ^= AFMPDBBHCHM.GetHashCode();
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
      if (AFMPDBBHCHM != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(AFMPDBBHCHM);
      }
      if (LEJJOJGNIHK != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(LEJJOJGNIHK);
      }
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Retcode);
      }
      if (RollShopId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(RollShopId);
      }
      if (reward_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(Reward);
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
      if (AFMPDBBHCHM != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(AFMPDBBHCHM);
      }
      if (LEJJOJGNIHK != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(LEJJOJGNIHK);
      }
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Retcode);
      }
      if (RollShopId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(RollShopId);
      }
      if (reward_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(Reward);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (reward_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reward);
      }
      if (LEJJOJGNIHK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LEJJOJGNIHK);
      }
      if (RollShopId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RollShopId);
      }
      if (AFMPDBBHCHM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AFMPDBBHCHM);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DoGachaInRollShopScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.reward_ != null) {
        if (reward_ == null) {
          Reward = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        Reward.MergeFrom(other.Reward);
      }
      if (other.LEJJOJGNIHK != 0) {
        LEJJOJGNIHK = other.LEJJOJGNIHK;
      }
      if (other.RollShopId != 0) {
        RollShopId = other.RollShopId;
      }
      if (other.AFMPDBBHCHM != 0) {
        AFMPDBBHCHM = other.AFMPDBBHCHM;
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
          case 16: {
            AFMPDBBHCHM = input.ReadUInt32();
            break;
          }
          case 32: {
            LEJJOJGNIHK = input.ReadUInt32();
            break;
          }
          case 56: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 64: {
            RollShopId = input.ReadUInt32();
            break;
          }
          case 74: {
            if (reward_ == null) {
              Reward = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Reward);
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
          case 16: {
            AFMPDBBHCHM = input.ReadUInt32();
            break;
          }
          case 32: {
            LEJJOJGNIHK = input.ReadUInt32();
            break;
          }
          case 56: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 64: {
            RollShopId = input.ReadUInt32();
            break;
          }
          case 74: {
            if (reward_ == null) {
              Reward = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Reward);
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