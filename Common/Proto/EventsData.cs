// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EventsData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from EventsData.proto</summary>
  public static partial class EventsDataReflection {

    #region Descriptor
    /// <summary>File descriptor for EventsData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EventsDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBFdmVudHNEYXRhLnByb3RvGhJOZXdBbGxleUluZm8ucHJvdG8iWQoKRXZl",
            "bnRzRGF0YRITCgtLSEFNT0NBQkpHTRgDIAEoDRITCgtHRkZIQU1LTUpKTRgH",
            "IAMoDRIhCgpldmVudF9saXN0GAkgAygLMg0uTmV3QWxsZXlJbmZvQh6qAhtF",
            "Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.NewAlleyInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.EventsData), global::EggLink.DanhengServer.Proto.EventsData.Parser, new[]{ "KHAMOCABJGM", "GFFHAMKMJJM", "EventList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class EventsData : pb::IMessage<EventsData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EventsData> _parser = new pb::MessageParser<EventsData>(() => new EventsData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EventsData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.EventsDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EventsData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EventsData(EventsData other) : this() {
      kHAMOCABJGM_ = other.kHAMOCABJGM_;
      gFFHAMKMJJM_ = other.gFFHAMKMJJM_.Clone();
      eventList_ = other.eventList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EventsData Clone() {
      return new EventsData(this);
    }

    /// <summary>Field number for the "KHAMOCABJGM" field.</summary>
    public const int KHAMOCABJGMFieldNumber = 3;
    private uint kHAMOCABJGM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KHAMOCABJGM {
      get { return kHAMOCABJGM_; }
      set {
        kHAMOCABJGM_ = value;
      }
    }

    /// <summary>Field number for the "GFFHAMKMJJM" field.</summary>
    public const int GFFHAMKMJJMFieldNumber = 7;
    private static readonly pb::FieldCodec<uint> _repeated_gFFHAMKMJJM_codec
        = pb::FieldCodec.ForUInt32(58);
    private readonly pbc::RepeatedField<uint> gFFHAMKMJJM_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> GFFHAMKMJJM {
      get { return gFFHAMKMJJM_; }
    }

    /// <summary>Field number for the "event_list" field.</summary>
    public const int EventListFieldNumber = 9;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.NewAlleyInfo> _repeated_eventList_codec
        = pb::FieldCodec.ForMessage(74, global::EggLink.DanhengServer.Proto.NewAlleyInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.NewAlleyInfo> eventList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.NewAlleyInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.NewAlleyInfo> EventList {
      get { return eventList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EventsData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EventsData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (KHAMOCABJGM != other.KHAMOCABJGM) return false;
      if(!gFFHAMKMJJM_.Equals(other.gFFHAMKMJJM_)) return false;
      if(!eventList_.Equals(other.eventList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (KHAMOCABJGM != 0) hash ^= KHAMOCABJGM.GetHashCode();
      hash ^= gFFHAMKMJJM_.GetHashCode();
      hash ^= eventList_.GetHashCode();
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
      if (KHAMOCABJGM != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(KHAMOCABJGM);
      }
      gFFHAMKMJJM_.WriteTo(output, _repeated_gFFHAMKMJJM_codec);
      eventList_.WriteTo(output, _repeated_eventList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (KHAMOCABJGM != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(KHAMOCABJGM);
      }
      gFFHAMKMJJM_.WriteTo(ref output, _repeated_gFFHAMKMJJM_codec);
      eventList_.WriteTo(ref output, _repeated_eventList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (KHAMOCABJGM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KHAMOCABJGM);
      }
      size += gFFHAMKMJJM_.CalculateSize(_repeated_gFFHAMKMJJM_codec);
      size += eventList_.CalculateSize(_repeated_eventList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EventsData other) {
      if (other == null) {
        return;
      }
      if (other.KHAMOCABJGM != 0) {
        KHAMOCABJGM = other.KHAMOCABJGM;
      }
      gFFHAMKMJJM_.Add(other.gFFHAMKMJJM_);
      eventList_.Add(other.eventList_);
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
            KHAMOCABJGM = input.ReadUInt32();
            break;
          }
          case 58:
          case 56: {
            gFFHAMKMJJM_.AddEntriesFrom(input, _repeated_gFFHAMKMJJM_codec);
            break;
          }
          case 74: {
            eventList_.AddEntriesFrom(input, _repeated_eventList_codec);
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
            KHAMOCABJGM = input.ReadUInt32();
            break;
          }
          case 58:
          case 56: {
            gFFHAMKMJJM_.AddEntriesFrom(ref input, _repeated_gFFHAMKMJJM_codec);
            break;
          }
          case 74: {
            eventList_.AddEntriesFrom(ref input, _repeated_eventList_codec);
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
