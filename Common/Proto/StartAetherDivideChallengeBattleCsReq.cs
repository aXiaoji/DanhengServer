// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StartAetherDivideChallengeBattleCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from StartAetherDivideChallengeBattleCsReq.proto</summary>
  public static partial class StartAetherDivideChallengeBattleCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for StartAetherDivideChallengeBattleCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StartAetherDivideChallengeBattleCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitTdGFydEFldGhlckRpdmlkZUNoYWxsZW5nZUJhdHRsZUNzUmVxLnByb3Rv",
            "IlIKJVN0YXJ0QWV0aGVyRGl2aWRlQ2hhbGxlbmdlQmF0dGxlQ3NSZXESEwoL",
            "RUZHTUlIRUNIRkEYCCABKA0SFAoMY2hhbGxlbmdlX2lkGAkgASgNQh6qAhtF",
            "Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.StartAetherDivideChallengeBattleCsReq), global::EggLink.DanhengServer.Proto.StartAetherDivideChallengeBattleCsReq.Parser, new[]{ "EFGMIHECHFA", "ChallengeId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class StartAetherDivideChallengeBattleCsReq : pb::IMessage<StartAetherDivideChallengeBattleCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StartAetherDivideChallengeBattleCsReq> _parser = new pb::MessageParser<StartAetherDivideChallengeBattleCsReq>(() => new StartAetherDivideChallengeBattleCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StartAetherDivideChallengeBattleCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.StartAetherDivideChallengeBattleCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartAetherDivideChallengeBattleCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartAetherDivideChallengeBattleCsReq(StartAetherDivideChallengeBattleCsReq other) : this() {
      eFGMIHECHFA_ = other.eFGMIHECHFA_;
      challengeId_ = other.challengeId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartAetherDivideChallengeBattleCsReq Clone() {
      return new StartAetherDivideChallengeBattleCsReq(this);
    }

    /// <summary>Field number for the "EFGMIHECHFA" field.</summary>
    public const int EFGMIHECHFAFieldNumber = 8;
    private uint eFGMIHECHFA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EFGMIHECHFA {
      get { return eFGMIHECHFA_; }
      set {
        eFGMIHECHFA_ = value;
      }
    }

    /// <summary>Field number for the "challenge_id" field.</summary>
    public const int ChallengeIdFieldNumber = 9;
    private uint challengeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeId {
      get { return challengeId_; }
      set {
        challengeId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StartAetherDivideChallengeBattleCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StartAetherDivideChallengeBattleCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EFGMIHECHFA != other.EFGMIHECHFA) return false;
      if (ChallengeId != other.ChallengeId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EFGMIHECHFA != 0) hash ^= EFGMIHECHFA.GetHashCode();
      if (ChallengeId != 0) hash ^= ChallengeId.GetHashCode();
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
      if (EFGMIHECHFA != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(EFGMIHECHFA);
      }
      if (ChallengeId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ChallengeId);
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
      if (EFGMIHECHFA != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(EFGMIHECHFA);
      }
      if (ChallengeId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ChallengeId);
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
      if (EFGMIHECHFA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EFGMIHECHFA);
      }
      if (ChallengeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StartAetherDivideChallengeBattleCsReq other) {
      if (other == null) {
        return;
      }
      if (other.EFGMIHECHFA != 0) {
        EFGMIHECHFA = other.EFGMIHECHFA;
      }
      if (other.ChallengeId != 0) {
        ChallengeId = other.ChallengeId;
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
          case 64: {
            EFGMIHECHFA = input.ReadUInt32();
            break;
          }
          case 72: {
            ChallengeId = input.ReadUInt32();
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
          case 64: {
            EFGMIHECHFA = input.ReadUInt32();
            break;
          }
          case 72: {
            ChallengeId = input.ReadUInt32();
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
