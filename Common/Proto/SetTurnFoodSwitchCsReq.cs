// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SetTurnFoodSwitchCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SetTurnFoodSwitchCsReq.proto</summary>
  public static partial class SetTurnFoodSwitchCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for SetTurnFoodSwitchCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SetTurnFoodSwitchCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxTZXRUdXJuRm9vZFN3aXRjaENzUmVxLnByb3RvGhRUdXJuRm9vZFN3aXRj",
            "aC5wcm90byJTChZTZXRUdXJuRm9vZFN3aXRjaENzUmVxEiQKC0xKTkVMQlBD",
            "TENJGAMgASgOMg8uVHVybkZvb2RTd2l0Y2gSEwoLUEJOSE9BSUFER0UYByAB",
            "KAhCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.TurnFoodSwitchReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SetTurnFoodSwitchCsReq), global::EggLink.DanhengServer.Proto.SetTurnFoodSwitchCsReq.Parser, new[]{ "LJNELBPCLCI", "PBNHOAIADGE" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SetTurnFoodSwitchCsReq : pb::IMessage<SetTurnFoodSwitchCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SetTurnFoodSwitchCsReq> _parser = new pb::MessageParser<SetTurnFoodSwitchCsReq>(() => new SetTurnFoodSwitchCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SetTurnFoodSwitchCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SetTurnFoodSwitchCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetTurnFoodSwitchCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetTurnFoodSwitchCsReq(SetTurnFoodSwitchCsReq other) : this() {
      lJNELBPCLCI_ = other.lJNELBPCLCI_;
      pBNHOAIADGE_ = other.pBNHOAIADGE_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetTurnFoodSwitchCsReq Clone() {
      return new SetTurnFoodSwitchCsReq(this);
    }

    /// <summary>Field number for the "LJNELBPCLCI" field.</summary>
    public const int LJNELBPCLCIFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.TurnFoodSwitch lJNELBPCLCI_ = global::EggLink.DanhengServer.Proto.TurnFoodSwitch.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.TurnFoodSwitch LJNELBPCLCI {
      get { return lJNELBPCLCI_; }
      set {
        lJNELBPCLCI_ = value;
      }
    }

    /// <summary>Field number for the "PBNHOAIADGE" field.</summary>
    public const int PBNHOAIADGEFieldNumber = 7;
    private bool pBNHOAIADGE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool PBNHOAIADGE {
      get { return pBNHOAIADGE_; }
      set {
        pBNHOAIADGE_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SetTurnFoodSwitchCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SetTurnFoodSwitchCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LJNELBPCLCI != other.LJNELBPCLCI) return false;
      if (PBNHOAIADGE != other.PBNHOAIADGE) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (LJNELBPCLCI != global::EggLink.DanhengServer.Proto.TurnFoodSwitch.None) hash ^= LJNELBPCLCI.GetHashCode();
      if (PBNHOAIADGE != false) hash ^= PBNHOAIADGE.GetHashCode();
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
      if (LJNELBPCLCI != global::EggLink.DanhengServer.Proto.TurnFoodSwitch.None) {
        output.WriteRawTag(24);
        output.WriteEnum((int) LJNELBPCLCI);
      }
      if (PBNHOAIADGE != false) {
        output.WriteRawTag(56);
        output.WriteBool(PBNHOAIADGE);
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
      if (LJNELBPCLCI != global::EggLink.DanhengServer.Proto.TurnFoodSwitch.None) {
        output.WriteRawTag(24);
        output.WriteEnum((int) LJNELBPCLCI);
      }
      if (PBNHOAIADGE != false) {
        output.WriteRawTag(56);
        output.WriteBool(PBNHOAIADGE);
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
      if (LJNELBPCLCI != global::EggLink.DanhengServer.Proto.TurnFoodSwitch.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) LJNELBPCLCI);
      }
      if (PBNHOAIADGE != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SetTurnFoodSwitchCsReq other) {
      if (other == null) {
        return;
      }
      if (other.LJNELBPCLCI != global::EggLink.DanhengServer.Proto.TurnFoodSwitch.None) {
        LJNELBPCLCI = other.LJNELBPCLCI;
      }
      if (other.PBNHOAIADGE != false) {
        PBNHOAIADGE = other.PBNHOAIADGE;
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
          case 24: {
            LJNELBPCLCI = (global::EggLink.DanhengServer.Proto.TurnFoodSwitch) input.ReadEnum();
            break;
          }
          case 56: {
            PBNHOAIADGE = input.ReadBool();
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
          case 24: {
            LJNELBPCLCI = (global::EggLink.DanhengServer.Proto.TurnFoodSwitch) input.ReadEnum();
            break;
          }
          case 56: {
            PBNHOAIADGE = input.ReadBool();
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