// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ClearAetherDividePassiveSkillScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ClearAetherDividePassiveSkillScRsp.proto</summary>
  public static partial class ClearAetherDividePassiveSkillScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for ClearAetherDividePassiveSkillScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClearAetherDividePassiveSkillScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihDbGVhckFldGhlckRpdmlkZVBhc3NpdmVTa2lsbFNjUnNwLnByb3RvGhVB",
            "ZXRoZXJTa2lsbEluZm8ucHJvdG8aHEFldGhlckRpdmlkZVNwaXJpdEluZm8u",
            "cHJvdG8iigEKIkNsZWFyQWV0aGVyRGl2aWRlUGFzc2l2ZVNraWxsU2NSc3AS",
            "JQoLQkxBQkRNSEdGRkUYDCABKAsyEC5BZXRoZXJTa2lsbEluZm8SLAoLc3Bp",
            "cml0X2luZm8YByABKAsyFy5BZXRoZXJEaXZpZGVTcGlyaXRJbmZvEg8KB3Jl",
            "dGNvZGUYDyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.AetherSkillInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ClearAetherDividePassiveSkillScRsp), global::EggLink.DanhengServer.Proto.ClearAetherDividePassiveSkillScRsp.Parser, new[]{ "BLABDMHGFFE", "SpiritInfo", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ClearAetherDividePassiveSkillScRsp : pb::IMessage<ClearAetherDividePassiveSkillScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ClearAetherDividePassiveSkillScRsp> _parser = new pb::MessageParser<ClearAetherDividePassiveSkillScRsp>(() => new ClearAetherDividePassiveSkillScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ClearAetherDividePassiveSkillScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ClearAetherDividePassiveSkillScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClearAetherDividePassiveSkillScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClearAetherDividePassiveSkillScRsp(ClearAetherDividePassiveSkillScRsp other) : this() {
      bLABDMHGFFE_ = other.bLABDMHGFFE_ != null ? other.bLABDMHGFFE_.Clone() : null;
      spiritInfo_ = other.spiritInfo_ != null ? other.spiritInfo_.Clone() : null;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClearAetherDividePassiveSkillScRsp Clone() {
      return new ClearAetherDividePassiveSkillScRsp(this);
    }

    /// <summary>Field number for the "BLABDMHGFFE" field.</summary>
    public const int BLABDMHGFFEFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.AetherSkillInfo bLABDMHGFFE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.AetherSkillInfo BLABDMHGFFE {
      get { return bLABDMHGFFE_; }
      set {
        bLABDMHGFFE_ = value;
      }
    }

    /// <summary>Field number for the "spirit_info" field.</summary>
    public const int SpiritInfoFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo spiritInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo SpiritInfo {
      get { return spiritInfo_; }
      set {
        spiritInfo_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 15;
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
      return Equals(other as ClearAetherDividePassiveSkillScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ClearAetherDividePassiveSkillScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(BLABDMHGFFE, other.BLABDMHGFFE)) return false;
      if (!object.Equals(SpiritInfo, other.SpiritInfo)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (bLABDMHGFFE_ != null) hash ^= BLABDMHGFFE.GetHashCode();
      if (spiritInfo_ != null) hash ^= SpiritInfo.GetHashCode();
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
      if (spiritInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(SpiritInfo);
      }
      if (bLABDMHGFFE_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(BLABDMHGFFE);
      }
      if (Retcode != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Retcode);
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
      if (spiritInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(SpiritInfo);
      }
      if (bLABDMHGFFE_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(BLABDMHGFFE);
      }
      if (Retcode != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Retcode);
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
      if (bLABDMHGFFE_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BLABDMHGFFE);
      }
      if (spiritInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SpiritInfo);
      }
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
    public void MergeFrom(ClearAetherDividePassiveSkillScRsp other) {
      if (other == null) {
        return;
      }
      if (other.bLABDMHGFFE_ != null) {
        if (bLABDMHGFFE_ == null) {
          BLABDMHGFFE = new global::EggLink.DanhengServer.Proto.AetherSkillInfo();
        }
        BLABDMHGFFE.MergeFrom(other.BLABDMHGFFE);
      }
      if (other.spiritInfo_ != null) {
        if (spiritInfo_ == null) {
          SpiritInfo = new global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo();
        }
        SpiritInfo.MergeFrom(other.SpiritInfo);
      }
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
          case 58: {
            if (spiritInfo_ == null) {
              SpiritInfo = new global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo();
            }
            input.ReadMessage(SpiritInfo);
            break;
          }
          case 98: {
            if (bLABDMHGFFE_ == null) {
              BLABDMHGFFE = new global::EggLink.DanhengServer.Proto.AetherSkillInfo();
            }
            input.ReadMessage(BLABDMHGFFE);
            break;
          }
          case 120: {
            Retcode = input.ReadUInt32();
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
          case 58: {
            if (spiritInfo_ == null) {
              SpiritInfo = new global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo();
            }
            input.ReadMessage(SpiritInfo);
            break;
          }
          case 98: {
            if (bLABDMHGFFE_ == null) {
              BLABDMHGFFE = new global::EggLink.DanhengServer.Proto.AetherSkillInfo();
            }
            input.ReadMessage(BLABDMHGFFE);
            break;
          }
          case 120: {
            Retcode = input.ReadUInt32();
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
