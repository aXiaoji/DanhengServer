// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EnterMapRotationRegionScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from EnterMapRotationRegionScRsp.proto</summary>
  public static partial class EnterMapRotationRegionScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for EnterMapRotationRegionScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EnterMapRotationRegionScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFFbnRlck1hcFJvdGF0aW9uUmVnaW9uU2NSc3AucHJvdG8aEE1vdGlvbklu",
            "Zm8ucHJvdG8aEU9ESUZQR0RES0hMLnByb3RvIrQBChtFbnRlck1hcFJvdGF0",
            "aW9uUmVnaW9uU2NSc3ASIQoLSkhGREJJTklQRkUYBiABKAsyDC5PRElGUEdE",
            "REtITBIbCgZtb3Rpb24YBCABKAsyCy5Nb3Rpb25JbmZvEhMKC0tISUhEUEhP",
            "R0FMGAEgASgNEg8KB3JldGNvZGUYDSABKA0SEwoLSFBBQUdMSkFFREQYBSAB",
            "KA0SGgoSY2xpZW50X3Bvc192ZXJzaW9uGAggASgNQh6qAhtFZ2dMaW5rLkRh",
            "bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MotionInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ODIFPGDDKHLReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.EnterMapRotationRegionScRsp), global::EggLink.DanhengServer.Proto.EnterMapRotationRegionScRsp.Parser, new[]{ "JHFDBINIPFE", "Motion", "KHIHDPHOGAL", "Retcode", "HPAAGLJAEDD", "ClientPosVersion" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class EnterMapRotationRegionScRsp : pb::IMessage<EnterMapRotationRegionScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EnterMapRotationRegionScRsp> _parser = new pb::MessageParser<EnterMapRotationRegionScRsp>(() => new EnterMapRotationRegionScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EnterMapRotationRegionScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.EnterMapRotationRegionScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterMapRotationRegionScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterMapRotationRegionScRsp(EnterMapRotationRegionScRsp other) : this() {
      jHFDBINIPFE_ = other.jHFDBINIPFE_ != null ? other.jHFDBINIPFE_.Clone() : null;
      motion_ = other.motion_ != null ? other.motion_.Clone() : null;
      kHIHDPHOGAL_ = other.kHIHDPHOGAL_;
      retcode_ = other.retcode_;
      hPAAGLJAEDD_ = other.hPAAGLJAEDD_;
      clientPosVersion_ = other.clientPosVersion_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterMapRotationRegionScRsp Clone() {
      return new EnterMapRotationRegionScRsp(this);
    }

    /// <summary>Field number for the "JHFDBINIPFE" field.</summary>
    public const int JHFDBINIPFEFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.ODIFPGDDKHL jHFDBINIPFE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ODIFPGDDKHL JHFDBINIPFE {
      get { return jHFDBINIPFE_; }
      set {
        jHFDBINIPFE_ = value;
      }
    }

    /// <summary>Field number for the "motion" field.</summary>
    public const int MotionFieldNumber = 4;
    private global::EggLink.DanhengServer.Proto.MotionInfo motion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MotionInfo Motion {
      get { return motion_; }
      set {
        motion_ = value;
      }
    }

    /// <summary>Field number for the "KHIHDPHOGAL" field.</summary>
    public const int KHIHDPHOGALFieldNumber = 1;
    private uint kHIHDPHOGAL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KHIHDPHOGAL {
      get { return kHIHDPHOGAL_; }
      set {
        kHIHDPHOGAL_ = value;
      }
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

    /// <summary>Field number for the "HPAAGLJAEDD" field.</summary>
    public const int HPAAGLJAEDDFieldNumber = 5;
    private uint hPAAGLJAEDD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HPAAGLJAEDD {
      get { return hPAAGLJAEDD_; }
      set {
        hPAAGLJAEDD_ = value;
      }
    }

    /// <summary>Field number for the "client_pos_version" field.</summary>
    public const int ClientPosVersionFieldNumber = 8;
    private uint clientPosVersion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ClientPosVersion {
      get { return clientPosVersion_; }
      set {
        clientPosVersion_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EnterMapRotationRegionScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EnterMapRotationRegionScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(JHFDBINIPFE, other.JHFDBINIPFE)) return false;
      if (!object.Equals(Motion, other.Motion)) return false;
      if (KHIHDPHOGAL != other.KHIHDPHOGAL) return false;
      if (Retcode != other.Retcode) return false;
      if (HPAAGLJAEDD != other.HPAAGLJAEDD) return false;
      if (ClientPosVersion != other.ClientPosVersion) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (jHFDBINIPFE_ != null) hash ^= JHFDBINIPFE.GetHashCode();
      if (motion_ != null) hash ^= Motion.GetHashCode();
      if (KHIHDPHOGAL != 0) hash ^= KHIHDPHOGAL.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (HPAAGLJAEDD != 0) hash ^= HPAAGLJAEDD.GetHashCode();
      if (ClientPosVersion != 0) hash ^= ClientPosVersion.GetHashCode();
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
      if (KHIHDPHOGAL != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(KHIHDPHOGAL);
      }
      if (motion_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Motion);
      }
      if (HPAAGLJAEDD != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(HPAAGLJAEDD);
      }
      if (jHFDBINIPFE_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(JHFDBINIPFE);
      }
      if (ClientPosVersion != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(ClientPosVersion);
      }
      if (Retcode != 0) {
        output.WriteRawTag(104);
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
      if (KHIHDPHOGAL != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(KHIHDPHOGAL);
      }
      if (motion_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Motion);
      }
      if (HPAAGLJAEDD != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(HPAAGLJAEDD);
      }
      if (jHFDBINIPFE_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(JHFDBINIPFE);
      }
      if (ClientPosVersion != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(ClientPosVersion);
      }
      if (Retcode != 0) {
        output.WriteRawTag(104);
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
      if (jHFDBINIPFE_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(JHFDBINIPFE);
      }
      if (motion_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Motion);
      }
      if (KHIHDPHOGAL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KHIHDPHOGAL);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (HPAAGLJAEDD != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HPAAGLJAEDD);
      }
      if (ClientPosVersion != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ClientPosVersion);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EnterMapRotationRegionScRsp other) {
      if (other == null) {
        return;
      }
      if (other.jHFDBINIPFE_ != null) {
        if (jHFDBINIPFE_ == null) {
          JHFDBINIPFE = new global::EggLink.DanhengServer.Proto.ODIFPGDDKHL();
        }
        JHFDBINIPFE.MergeFrom(other.JHFDBINIPFE);
      }
      if (other.motion_ != null) {
        if (motion_ == null) {
          Motion = new global::EggLink.DanhengServer.Proto.MotionInfo();
        }
        Motion.MergeFrom(other.Motion);
      }
      if (other.KHIHDPHOGAL != 0) {
        KHIHDPHOGAL = other.KHIHDPHOGAL;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.HPAAGLJAEDD != 0) {
        HPAAGLJAEDD = other.HPAAGLJAEDD;
      }
      if (other.ClientPosVersion != 0) {
        ClientPosVersion = other.ClientPosVersion;
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
            KHIHDPHOGAL = input.ReadUInt32();
            break;
          }
          case 34: {
            if (motion_ == null) {
              Motion = new global::EggLink.DanhengServer.Proto.MotionInfo();
            }
            input.ReadMessage(Motion);
            break;
          }
          case 40: {
            HPAAGLJAEDD = input.ReadUInt32();
            break;
          }
          case 50: {
            if (jHFDBINIPFE_ == null) {
              JHFDBINIPFE = new global::EggLink.DanhengServer.Proto.ODIFPGDDKHL();
            }
            input.ReadMessage(JHFDBINIPFE);
            break;
          }
          case 64: {
            ClientPosVersion = input.ReadUInt32();
            break;
          }
          case 104: {
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
          case 8: {
            KHIHDPHOGAL = input.ReadUInt32();
            break;
          }
          case 34: {
            if (motion_ == null) {
              Motion = new global::EggLink.DanhengServer.Proto.MotionInfo();
            }
            input.ReadMessage(Motion);
            break;
          }
          case 40: {
            HPAAGLJAEDD = input.ReadUInt32();
            break;
          }
          case 50: {
            if (jHFDBINIPFE_ == null) {
              JHFDBINIPFE = new global::EggLink.DanhengServer.Proto.ODIFPGDDKHL();
            }
            input.ReadMessage(JHFDBINIPFE);
            break;
          }
          case 64: {
            ClientPosVersion = input.ReadUInt32();
            break;
          }
          case 104: {
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
