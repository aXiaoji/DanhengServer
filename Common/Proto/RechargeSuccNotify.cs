// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RechargeSuccNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RechargeSuccNotify.proto</summary>
  public static partial class RechargeSuccNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for RechargeSuccNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RechargeSuccNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhSZWNoYXJnZVN1Y2NOb3RpZnkucHJvdG8aDkl0ZW1MaXN0LnByb3RvIoEB",
            "ChJSZWNoYXJnZVN1Y2NOb3RpZnkSHwoXbW9udGhfY2FyZF9vdXRkYXRlX3Rp",
            "bWUYCCABKAQSGAoQY2hhbm5lbF9vcmRlcl9ubxgHIAEoCRISCgpwcm9kdWN0",
            "X2lkGAsgASgJEhwKCWl0ZW1fbGlzdBgKIAEoCzIJLkl0ZW1MaXN0Qh6qAhtF",
            "Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RechargeSuccNotify), global::EggLink.DanhengServer.Proto.RechargeSuccNotify.Parser, new[]{ "MonthCardOutdateTime", "ChannelOrderNo", "ProductId", "ItemList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RechargeSuccNotify : pb::IMessage<RechargeSuccNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RechargeSuccNotify> _parser = new pb::MessageParser<RechargeSuccNotify>(() => new RechargeSuccNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RechargeSuccNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RechargeSuccNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RechargeSuccNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RechargeSuccNotify(RechargeSuccNotify other) : this() {
      monthCardOutdateTime_ = other.monthCardOutdateTime_;
      channelOrderNo_ = other.channelOrderNo_;
      productId_ = other.productId_;
      itemList_ = other.itemList_ != null ? other.itemList_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RechargeSuccNotify Clone() {
      return new RechargeSuccNotify(this);
    }

    /// <summary>Field number for the "month_card_outdate_time" field.</summary>
    public const int MonthCardOutdateTimeFieldNumber = 8;
    private ulong monthCardOutdateTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong MonthCardOutdateTime {
      get { return monthCardOutdateTime_; }
      set {
        monthCardOutdateTime_ = value;
      }
    }

    /// <summary>Field number for the "channel_order_no" field.</summary>
    public const int ChannelOrderNoFieldNumber = 7;
    private string channelOrderNo_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ChannelOrderNo {
      get { return channelOrderNo_; }
      set {
        channelOrderNo_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "product_id" field.</summary>
    public const int ProductIdFieldNumber = 11;
    private string productId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ProductId {
      get { return productId_; }
      set {
        productId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "item_list" field.</summary>
    public const int ItemListFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.ItemList itemList_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList ItemList {
      get { return itemList_; }
      set {
        itemList_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RechargeSuccNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RechargeSuccNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MonthCardOutdateTime != other.MonthCardOutdateTime) return false;
      if (ChannelOrderNo != other.ChannelOrderNo) return false;
      if (ProductId != other.ProductId) return false;
      if (!object.Equals(ItemList, other.ItemList)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MonthCardOutdateTime != 0UL) hash ^= MonthCardOutdateTime.GetHashCode();
      if (ChannelOrderNo.Length != 0) hash ^= ChannelOrderNo.GetHashCode();
      if (ProductId.Length != 0) hash ^= ProductId.GetHashCode();
      if (itemList_ != null) hash ^= ItemList.GetHashCode();
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
      if (ChannelOrderNo.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(ChannelOrderNo);
      }
      if (MonthCardOutdateTime != 0UL) {
        output.WriteRawTag(64);
        output.WriteUInt64(MonthCardOutdateTime);
      }
      if (itemList_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(ItemList);
      }
      if (ProductId.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(ProductId);
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
      if (ChannelOrderNo.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(ChannelOrderNo);
      }
      if (MonthCardOutdateTime != 0UL) {
        output.WriteRawTag(64);
        output.WriteUInt64(MonthCardOutdateTime);
      }
      if (itemList_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(ItemList);
      }
      if (ProductId.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(ProductId);
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
      if (MonthCardOutdateTime != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(MonthCardOutdateTime);
      }
      if (ChannelOrderNo.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ChannelOrderNo);
      }
      if (ProductId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProductId);
      }
      if (itemList_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ItemList);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RechargeSuccNotify other) {
      if (other == null) {
        return;
      }
      if (other.MonthCardOutdateTime != 0UL) {
        MonthCardOutdateTime = other.MonthCardOutdateTime;
      }
      if (other.ChannelOrderNo.Length != 0) {
        ChannelOrderNo = other.ChannelOrderNo;
      }
      if (other.ProductId.Length != 0) {
        ProductId = other.ProductId;
      }
      if (other.itemList_ != null) {
        if (itemList_ == null) {
          ItemList = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        ItemList.MergeFrom(other.ItemList);
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
            ChannelOrderNo = input.ReadString();
            break;
          }
          case 64: {
            MonthCardOutdateTime = input.ReadUInt64();
            break;
          }
          case 82: {
            if (itemList_ == null) {
              ItemList = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(ItemList);
            break;
          }
          case 90: {
            ProductId = input.ReadString();
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
            ChannelOrderNo = input.ReadString();
            break;
          }
          case 64: {
            MonthCardOutdateTime = input.ReadUInt64();
            break;
          }
          case 82: {
            if (itemList_ == null) {
              ItemList = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(ItemList);
            break;
          }
          case 90: {
            ProductId = input.ReadString();
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
