// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DisplayRecordInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from DisplayRecordInfo.proto</summary>
  public static partial class DisplayRecordInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for DisplayRecordInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DisplayRecordInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdEaXNwbGF5UmVjb3JkSW5mby5wcm90bxoaRGlzcGxheUNoYWxsZW5nZUlu",
            "Zm8ucHJvdG8ilgEKEURpc3BsYXlSZWNvcmRJbmZvEhMKC0pMTkRNSktFTkRE",
            "GA0gASgNEhMKC0pES0ZJSEVLRkRGGAEgASgNEi0KDmNoYWxsZW5nZV9pbmZv",
            "GAwgASgLMhUuRGlzcGxheUNoYWxsZW5nZUluZm8SEwoLRU9NS0NDQUJKUEwY",
            "CCABKA0SEwoLRE9CRUNGRUpFTUEYCiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVu",
            "Z1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.DisplayChallengeInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.DisplayRecordInfo), global::EggLink.DanhengServer.Proto.DisplayRecordInfo.Parser, new[]{ "JLNDMJKENDD", "JDKFIHEKFDF", "ChallengeInfo", "EOMKCCABJPL", "DOBECFEJEMA" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DisplayRecordInfo : pb::IMessage<DisplayRecordInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DisplayRecordInfo> _parser = new pb::MessageParser<DisplayRecordInfo>(() => new DisplayRecordInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DisplayRecordInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.DisplayRecordInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DisplayRecordInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DisplayRecordInfo(DisplayRecordInfo other) : this() {
      jLNDMJKENDD_ = other.jLNDMJKENDD_;
      jDKFIHEKFDF_ = other.jDKFIHEKFDF_;
      challengeInfo_ = other.challengeInfo_ != null ? other.challengeInfo_.Clone() : null;
      eOMKCCABJPL_ = other.eOMKCCABJPL_;
      dOBECFEJEMA_ = other.dOBECFEJEMA_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DisplayRecordInfo Clone() {
      return new DisplayRecordInfo(this);
    }

    /// <summary>Field number for the "JLNDMJKENDD" field.</summary>
    public const int JLNDMJKENDDFieldNumber = 13;
    private uint jLNDMJKENDD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JLNDMJKENDD {
      get { return jLNDMJKENDD_; }
      set {
        jLNDMJKENDD_ = value;
      }
    }

    /// <summary>Field number for the "JDKFIHEKFDF" field.</summary>
    public const int JDKFIHEKFDFFieldNumber = 1;
    private uint jDKFIHEKFDF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JDKFIHEKFDF {
      get { return jDKFIHEKFDF_; }
      set {
        jDKFIHEKFDF_ = value;
      }
    }

    /// <summary>Field number for the "challenge_info" field.</summary>
    public const int ChallengeInfoFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.DisplayChallengeInfo challengeInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.DisplayChallengeInfo ChallengeInfo {
      get { return challengeInfo_; }
      set {
        challengeInfo_ = value;
      }
    }

    /// <summary>Field number for the "EOMKCCABJPL" field.</summary>
    public const int EOMKCCABJPLFieldNumber = 8;
    private uint eOMKCCABJPL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EOMKCCABJPL {
      get { return eOMKCCABJPL_; }
      set {
        eOMKCCABJPL_ = value;
      }
    }

    /// <summary>Field number for the "DOBECFEJEMA" field.</summary>
    public const int DOBECFEJEMAFieldNumber = 10;
    private uint dOBECFEJEMA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DOBECFEJEMA {
      get { return dOBECFEJEMA_; }
      set {
        dOBECFEJEMA_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DisplayRecordInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DisplayRecordInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (JLNDMJKENDD != other.JLNDMJKENDD) return false;
      if (JDKFIHEKFDF != other.JDKFIHEKFDF) return false;
      if (!object.Equals(ChallengeInfo, other.ChallengeInfo)) return false;
      if (EOMKCCABJPL != other.EOMKCCABJPL) return false;
      if (DOBECFEJEMA != other.DOBECFEJEMA) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (JLNDMJKENDD != 0) hash ^= JLNDMJKENDD.GetHashCode();
      if (JDKFIHEKFDF != 0) hash ^= JDKFIHEKFDF.GetHashCode();
      if (challengeInfo_ != null) hash ^= ChallengeInfo.GetHashCode();
      if (EOMKCCABJPL != 0) hash ^= EOMKCCABJPL.GetHashCode();
      if (DOBECFEJEMA != 0) hash ^= DOBECFEJEMA.GetHashCode();
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
      if (JDKFIHEKFDF != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(JDKFIHEKFDF);
      }
      if (EOMKCCABJPL != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(EOMKCCABJPL);
      }
      if (DOBECFEJEMA != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(DOBECFEJEMA);
      }
      if (challengeInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(ChallengeInfo);
      }
      if (JLNDMJKENDD != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(JLNDMJKENDD);
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
      if (JDKFIHEKFDF != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(JDKFIHEKFDF);
      }
      if (EOMKCCABJPL != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(EOMKCCABJPL);
      }
      if (DOBECFEJEMA != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(DOBECFEJEMA);
      }
      if (challengeInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(ChallengeInfo);
      }
      if (JLNDMJKENDD != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(JLNDMJKENDD);
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
      if (JLNDMJKENDD != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JLNDMJKENDD);
      }
      if (JDKFIHEKFDF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JDKFIHEKFDF);
      }
      if (challengeInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ChallengeInfo);
      }
      if (EOMKCCABJPL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EOMKCCABJPL);
      }
      if (DOBECFEJEMA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DOBECFEJEMA);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DisplayRecordInfo other) {
      if (other == null) {
        return;
      }
      if (other.JLNDMJKENDD != 0) {
        JLNDMJKENDD = other.JLNDMJKENDD;
      }
      if (other.JDKFIHEKFDF != 0) {
        JDKFIHEKFDF = other.JDKFIHEKFDF;
      }
      if (other.challengeInfo_ != null) {
        if (challengeInfo_ == null) {
          ChallengeInfo = new global::EggLink.DanhengServer.Proto.DisplayChallengeInfo();
        }
        ChallengeInfo.MergeFrom(other.ChallengeInfo);
      }
      if (other.EOMKCCABJPL != 0) {
        EOMKCCABJPL = other.EOMKCCABJPL;
      }
      if (other.DOBECFEJEMA != 0) {
        DOBECFEJEMA = other.DOBECFEJEMA;
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
            JDKFIHEKFDF = input.ReadUInt32();
            break;
          }
          case 64: {
            EOMKCCABJPL = input.ReadUInt32();
            break;
          }
          case 80: {
            DOBECFEJEMA = input.ReadUInt32();
            break;
          }
          case 98: {
            if (challengeInfo_ == null) {
              ChallengeInfo = new global::EggLink.DanhengServer.Proto.DisplayChallengeInfo();
            }
            input.ReadMessage(ChallengeInfo);
            break;
          }
          case 104: {
            JLNDMJKENDD = input.ReadUInt32();
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
            JDKFIHEKFDF = input.ReadUInt32();
            break;
          }
          case 64: {
            EOMKCCABJPL = input.ReadUInt32();
            break;
          }
          case 80: {
            DOBECFEJEMA = input.ReadUInt32();
            break;
          }
          case 98: {
            if (challengeInfo_ == null) {
              ChallengeInfo = new global::EggLink.DanhengServer.Proto.DisplayChallengeInfo();
            }
            input.ReadMessage(ChallengeInfo);
            break;
          }
          case 104: {
            JLNDMJKENDD = input.ReadUInt32();
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
