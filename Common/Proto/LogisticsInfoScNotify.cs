// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LogisticsInfoScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from LogisticsInfoScNotify.proto</summary>
  public static partial class LogisticsInfoScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for LogisticsInfoScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LogisticsInfoScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtMb2dpc3RpY3NJbmZvU2NOb3RpZnkucHJvdG8aEUZOQUJESUxKRUhKLnBy",
            "b3RvIjoKFUxvZ2lzdGljc0luZm9TY05vdGlmeRIhCgtERkdOR0ZGS0JFShgJ",
            "IAEoCzIMLkZOQUJESUxKRUhKQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu",
            "UHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.FNABDILJEHJReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.LogisticsInfoScNotify), global::EggLink.DanhengServer.Proto.LogisticsInfoScNotify.Parser, new[]{ "DFGNGFFKBEJ" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class LogisticsInfoScNotify : pb::IMessage<LogisticsInfoScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LogisticsInfoScNotify> _parser = new pb::MessageParser<LogisticsInfoScNotify>(() => new LogisticsInfoScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LogisticsInfoScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.LogisticsInfoScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LogisticsInfoScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LogisticsInfoScNotify(LogisticsInfoScNotify other) : this() {
      dFGNGFFKBEJ_ = other.dFGNGFFKBEJ_ != null ? other.dFGNGFFKBEJ_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LogisticsInfoScNotify Clone() {
      return new LogisticsInfoScNotify(this);
    }

    /// <summary>Field number for the "DFGNGFFKBEJ" field.</summary>
    public const int DFGNGFFKBEJFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.FNABDILJEHJ dFGNGFFKBEJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.FNABDILJEHJ DFGNGFFKBEJ {
      get { return dFGNGFFKBEJ_; }
      set {
        dFGNGFFKBEJ_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LogisticsInfoScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LogisticsInfoScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(DFGNGFFKBEJ, other.DFGNGFFKBEJ)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (dFGNGFFKBEJ_ != null) hash ^= DFGNGFFKBEJ.GetHashCode();
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
      if (dFGNGFFKBEJ_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(DFGNGFFKBEJ);
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
      if (dFGNGFFKBEJ_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(DFGNGFFKBEJ);
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
      if (dFGNGFFKBEJ_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DFGNGFFKBEJ);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LogisticsInfoScNotify other) {
      if (other == null) {
        return;
      }
      if (other.dFGNGFFKBEJ_ != null) {
        if (dFGNGFFKBEJ_ == null) {
          DFGNGFFKBEJ = new global::EggLink.DanhengServer.Proto.FNABDILJEHJ();
        }
        DFGNGFFKBEJ.MergeFrom(other.DFGNGFFKBEJ);
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
          case 74: {
            if (dFGNGFFKBEJ_ == null) {
              DFGNGFFKBEJ = new global::EggLink.DanhengServer.Proto.FNABDILJEHJ();
            }
            input.ReadMessage(DFGNGFFKBEJ);
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
          case 74: {
            if (dFGNGFFKBEJ_ == null) {
              DFGNGFFKBEJ = new global::EggLink.DanhengServer.Proto.FNABDILJEHJ();
            }
            input.ReadMessage(DFGNGFFKBEJ);
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
