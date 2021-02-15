// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: io/common/transaction.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PKIo {

  /// <summary>Holder for reflection information generated from io/common/transaction.proto</summary>
  public static partial class TransactionReflection {

    #region Descriptor
    /// <summary>File descriptor for io/common/transaction.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TransactionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chtpby9jb21tb24vdHJhbnNhY3Rpb24ucHJvdG8SAmlvGixwcm90b2MtZ2Vu",
            "LXN3YWdnZXIvb3B0aW9ucy9hbm5vdGF0aW9ucy5wcm90bxoeaW8vY29tbW9u",
            "L2NvbW1vbl9vYmplY3RzLnByb3RvGhlpby9jb21tb24vcHJveGltaXR5LnBy",
            "b3RvIpQECgtUcmFuc2FjdGlvbhITCgtyZWZlcmVuY2VJZBgBIAEoCRISCgp0",
            "b3RhbFByaWNlGAIgASgCEiEKCm9yZGVySXRlbXMYAyADKAsyDS5pby5PcmRl",
            "ckl0ZW0SEAoIZGlzY291bnQYBCABKAISJwoNZGlzY291bnRJdGVtcxgFIAMo",
            "CzIQLmlvLkRpc2NvdW50SXRlbRIVCg1zZXJ2aWNlQ2hhcmdlGAYgASgCEhAK",
            "CHRvdGFsVGF4GAcgASgCEhIKCmZpbmFsUHJpY2UYCCABKAISGgoScm91bmRp",
            "bmdEaWZmZXJlbmNlGAkgASgCEhIKCmlzUmVmdW5kZWQYCiABKAgSGwoJdGlt",
            "ZXN0YW1wGAsgASgLMgguaW8uRGF0ZRIQCghjdXJyZW5jeRgMIAEoCRIhCghs",
            "b2NhdGlvbhgNIAEoCzIPLmlvLkdQU0xvY2F0aW9uEhkKEXRyYW5zYWN0aW9u",
            "U291cmNlGA4gASgJOqMBkkGfAQqcASoLVHJhbnNhY3Rpb24ybVRyYW5zYWN0",
            "aW9uIGluZm9ybWF0aW9uIGZvciBtZW1iZXIgcHJvZ3JhbXMgdGhhdCB3YW50",
            "IHRvIHNob3cgbGF0ZXN0IHRyYW5zYWN0aW9ucyBvbiBiYWNrIG9mIHRoZSBt",
            "ZW1iZXIgY2FyZC7SAQl0aW1lc3RhbXDSAQZhbW91bnTSAQhjdXJyZW5jeSJh",
            "CgxEaXNjb3VudEl0ZW0SFAoMZGlzY291bnRDb2RlGAEgASgJEhMKC3ZvdWNo",
            "ZXJDb2RlGAIgASgJEg4KBmFtb3VudBgEIAEoAhIQCghpdGVtTmFtZRgFIAEo",
            "CUoECAMQBCJZCglPcmRlckl0ZW0SDgoGYW1vdW50GAEgASgCEgsKA3RheBgC",
            "IAEoAhIQCghpdGVtTmFtZRgDIAEoCRIQCghxdWFudGl0eRgEIAEoBRILCgNz",
            "a3UYBSABKAlCPgoPaW8ucGFzc2tpdC5QS2lvWiRzdGFzaC5wYXNza2l0LmNv",
            "bS9pby9tb2RlbC9zZGsvZ28vaW+qAgRQS0lvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Grpc.Gateway.ProtocGenSwagger.Options.AnnotationsReflection.Descriptor, global::PKIo.CommonObjectsReflection.Descriptor, global::PKIo.ProximityReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PKIo.Transaction), global::PKIo.Transaction.Parser, new[]{ "ReferenceId", "TotalPrice", "OrderItems", "Discount", "DiscountItems", "ServiceCharge", "TotalTax", "FinalPrice", "RoundingDifference", "IsRefunded", "Timestamp", "Currency", "Location", "TransactionSource" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::PKIo.DiscountItem), global::PKIo.DiscountItem.Parser, new[]{ "DiscountCode", "VoucherCode", "Amount", "ItemName" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::PKIo.OrderItem), global::PKIo.OrderItem.Parser, new[]{ "Amount", "Tax", "ItemName", "Quantity", "Sku" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Some point based loyalty programs will pass on transaction information (can be used for segmenting, additional reporting, and/or showing transactions on back of the pass).
  /// </summary>
  public sealed partial class Transaction : pb::IMessage<Transaction> {
    private static readonly pb::MessageParser<Transaction> _parser = new pb::MessageParser<Transaction>(() => new Transaction());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Transaction> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::PKIo.TransactionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Transaction() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Transaction(Transaction other) : this() {
      referenceId_ = other.referenceId_;
      totalPrice_ = other.totalPrice_;
      orderItems_ = other.orderItems_.Clone();
      discount_ = other.discount_;
      discountItems_ = other.discountItems_.Clone();
      serviceCharge_ = other.serviceCharge_;
      totalTax_ = other.totalTax_;
      finalPrice_ = other.finalPrice_;
      roundingDifference_ = other.roundingDifference_;
      isRefunded_ = other.isRefunded_;
      timestamp_ = other.timestamp_ != null ? other.timestamp_.Clone() : null;
      currency_ = other.currency_;
      location_ = other.location_ != null ? other.location_.Clone() : null;
      transactionSource_ = other.transactionSource_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Transaction Clone() {
      return new Transaction(this);
    }

    /// <summary>Field number for the "referenceId" field.</summary>
    public const int ReferenceIdFieldNumber = 1;
    private string referenceId_ = "";
    /// <summary>
    /// Reference ID is the ID used in the system where the transaction is coming from. Needs to be unique within the program.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ReferenceId {
      get { return referenceId_; }
      set {
        referenceId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "totalPrice" field.</summary>
    public const int TotalPriceFieldNumber = 2;
    private float totalPrice_;
    /// <summary>
    /// The total amount of all order items. Based on POS setting, the totalPrice can already include the tax amount
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float TotalPrice {
      get { return totalPrice_; }
      set {
        totalPrice_ = value;
      }
    }

    /// <summary>Field number for the "orderItems" field.</summary>
    public const int OrderItemsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::PKIo.OrderItem> _repeated_orderItems_codec
        = pb::FieldCodec.ForMessage(26, global::PKIo.OrderItem.Parser);
    private readonly pbc::RepeatedField<global::PKIo.OrderItem> orderItems_ = new pbc::RepeatedField<global::PKIo.OrderItem>();
    /// <summary>
    /// List of order items in the  transaction
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::PKIo.OrderItem> OrderItems {
      get { return orderItems_; }
    }

    /// <summary>Field number for the "discount" field.</summary>
    public const int DiscountFieldNumber = 4;
    private float discount_;
    /// <summary>
    /// The total discount amount
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Discount {
      get { return discount_; }
      set {
        discount_ = value;
      }
    }

    /// <summary>Field number for the "discountItems" field.</summary>
    public const int DiscountItemsFieldNumber = 5;
    private static readonly pb::FieldCodec<global::PKIo.DiscountItem> _repeated_discountItems_codec
        = pb::FieldCodec.ForMessage(42, global::PKIo.DiscountItem.Parser);
    private readonly pbc::RepeatedField<global::PKIo.DiscountItem> discountItems_ = new pbc::RepeatedField<global::PKIo.DiscountItem>();
    /// <summary>
    /// List of discount items
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::PKIo.DiscountItem> DiscountItems {
      get { return discountItems_; }
    }

    /// <summary>Field number for the "serviceCharge" field.</summary>
    public const int ServiceChargeFieldNumber = 6;
    private float serviceCharge_;
    /// <summary>
    /// The service charge amount
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float ServiceCharge {
      get { return serviceCharge_; }
      set {
        serviceCharge_ = value;
      }
    }

    /// <summary>Field number for the "totalTax" field.</summary>
    public const int TotalTaxFieldNumber = 7;
    private float totalTax_;
    /// <summary>
    /// The tax amount.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float TotalTax {
      get { return totalTax_; }
      set {
        totalTax_ = value;
      }
    }

    /// <summary>Field number for the "finalPrice" field.</summary>
    public const int FinalPriceFieldNumber = 8;
    private float finalPrice_;
    /// <summary>
    /// The final price of the transaction: (total price + service charge + (totalTax: if POS settings set to tax exclusive)) - discount
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float FinalPrice {
      get { return finalPrice_; }
      set {
        finalPrice_ = value;
      }
    }

    /// <summary>Field number for the "roundingDifference" field.</summary>
    public const int RoundingDifferenceFieldNumber = 9;
    private float roundingDifference_;
    /// <summary>
    /// Rounding difference
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float RoundingDifference {
      get { return roundingDifference_; }
      set {
        roundingDifference_ = value;
      }
    }

    /// <summary>Field number for the "isRefunded" field.</summary>
    public const int IsRefundedFieldNumber = 10;
    private bool isRefunded_;
    /// <summary>
    /// Indicates if this transaction is a refund
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsRefunded {
      get { return isRefunded_; }
      set {
        isRefunded_ = value;
      }
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 11;
    private global::PKIo.Date timestamp_;
    /// <summary>
    /// The transaction timestamp
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::PKIo.Date Timestamp {
      get { return timestamp_; }
      set {
        timestamp_ = value;
      }
    }

    /// <summary>Field number for the "currency" field.</summary>
    public const int CurrencyFieldNumber = 12;
    private string currency_ = "";
    /// <summary>
    /// The transaction currency
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Currency {
      get { return currency_; }
      set {
        currency_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "location" field.</summary>
    public const int LocationFieldNumber = 13;
    private global::PKIo.GPSLocation location_;
    /// <summary>
    /// GPS details of check in
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::PKIo.GPSLocation Location {
      get { return location_; }
      set {
        location_ = value;
      }
    }

    /// <summary>Field number for the "transactionSource" field.</summary>
    public const int TransactionSourceFieldNumber = 14;
    private string transactionSource_ = "";
    /// <summary>
    /// 17 is reserved for transaction source (online, or restaurant code)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TransactionSource {
      get { return transactionSource_; }
      set {
        transactionSource_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Transaction);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Transaction other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ReferenceId != other.ReferenceId) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TotalPrice, other.TotalPrice)) return false;
      if(!orderItems_.Equals(other.orderItems_)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Discount, other.Discount)) return false;
      if(!discountItems_.Equals(other.discountItems_)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ServiceCharge, other.ServiceCharge)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TotalTax, other.TotalTax)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FinalPrice, other.FinalPrice)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(RoundingDifference, other.RoundingDifference)) return false;
      if (IsRefunded != other.IsRefunded) return false;
      if (!object.Equals(Timestamp, other.Timestamp)) return false;
      if (Currency != other.Currency) return false;
      if (!object.Equals(Location, other.Location)) return false;
      if (TransactionSource != other.TransactionSource) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ReferenceId.Length != 0) hash ^= ReferenceId.GetHashCode();
      if (TotalPrice != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TotalPrice);
      hash ^= orderItems_.GetHashCode();
      if (Discount != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Discount);
      hash ^= discountItems_.GetHashCode();
      if (ServiceCharge != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ServiceCharge);
      if (TotalTax != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TotalTax);
      if (FinalPrice != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FinalPrice);
      if (RoundingDifference != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(RoundingDifference);
      if (IsRefunded != false) hash ^= IsRefunded.GetHashCode();
      if (timestamp_ != null) hash ^= Timestamp.GetHashCode();
      if (Currency.Length != 0) hash ^= Currency.GetHashCode();
      if (location_ != null) hash ^= Location.GetHashCode();
      if (TransactionSource.Length != 0) hash ^= TransactionSource.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ReferenceId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ReferenceId);
      }
      if (TotalPrice != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(TotalPrice);
      }
      orderItems_.WriteTo(output, _repeated_orderItems_codec);
      if (Discount != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(Discount);
      }
      discountItems_.WriteTo(output, _repeated_discountItems_codec);
      if (ServiceCharge != 0F) {
        output.WriteRawTag(53);
        output.WriteFloat(ServiceCharge);
      }
      if (TotalTax != 0F) {
        output.WriteRawTag(61);
        output.WriteFloat(TotalTax);
      }
      if (FinalPrice != 0F) {
        output.WriteRawTag(69);
        output.WriteFloat(FinalPrice);
      }
      if (RoundingDifference != 0F) {
        output.WriteRawTag(77);
        output.WriteFloat(RoundingDifference);
      }
      if (IsRefunded != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsRefunded);
      }
      if (timestamp_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(Timestamp);
      }
      if (Currency.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(Currency);
      }
      if (location_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(Location);
      }
      if (TransactionSource.Length != 0) {
        output.WriteRawTag(114);
        output.WriteString(TransactionSource);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ReferenceId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ReferenceId);
      }
      if (TotalPrice != 0F) {
        size += 1 + 4;
      }
      size += orderItems_.CalculateSize(_repeated_orderItems_codec);
      if (Discount != 0F) {
        size += 1 + 4;
      }
      size += discountItems_.CalculateSize(_repeated_discountItems_codec);
      if (ServiceCharge != 0F) {
        size += 1 + 4;
      }
      if (TotalTax != 0F) {
        size += 1 + 4;
      }
      if (FinalPrice != 0F) {
        size += 1 + 4;
      }
      if (RoundingDifference != 0F) {
        size += 1 + 4;
      }
      if (IsRefunded != false) {
        size += 1 + 1;
      }
      if (timestamp_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Timestamp);
      }
      if (Currency.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Currency);
      }
      if (location_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Location);
      }
      if (TransactionSource.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TransactionSource);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Transaction other) {
      if (other == null) {
        return;
      }
      if (other.ReferenceId.Length != 0) {
        ReferenceId = other.ReferenceId;
      }
      if (other.TotalPrice != 0F) {
        TotalPrice = other.TotalPrice;
      }
      orderItems_.Add(other.orderItems_);
      if (other.Discount != 0F) {
        Discount = other.Discount;
      }
      discountItems_.Add(other.discountItems_);
      if (other.ServiceCharge != 0F) {
        ServiceCharge = other.ServiceCharge;
      }
      if (other.TotalTax != 0F) {
        TotalTax = other.TotalTax;
      }
      if (other.FinalPrice != 0F) {
        FinalPrice = other.FinalPrice;
      }
      if (other.RoundingDifference != 0F) {
        RoundingDifference = other.RoundingDifference;
      }
      if (other.IsRefunded != false) {
        IsRefunded = other.IsRefunded;
      }
      if (other.timestamp_ != null) {
        if (timestamp_ == null) {
          Timestamp = new global::PKIo.Date();
        }
        Timestamp.MergeFrom(other.Timestamp);
      }
      if (other.Currency.Length != 0) {
        Currency = other.Currency;
      }
      if (other.location_ != null) {
        if (location_ == null) {
          Location = new global::PKIo.GPSLocation();
        }
        Location.MergeFrom(other.Location);
      }
      if (other.TransactionSource.Length != 0) {
        TransactionSource = other.TransactionSource;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ReferenceId = input.ReadString();
            break;
          }
          case 21: {
            TotalPrice = input.ReadFloat();
            break;
          }
          case 26: {
            orderItems_.AddEntriesFrom(input, _repeated_orderItems_codec);
            break;
          }
          case 37: {
            Discount = input.ReadFloat();
            break;
          }
          case 42: {
            discountItems_.AddEntriesFrom(input, _repeated_discountItems_codec);
            break;
          }
          case 53: {
            ServiceCharge = input.ReadFloat();
            break;
          }
          case 61: {
            TotalTax = input.ReadFloat();
            break;
          }
          case 69: {
            FinalPrice = input.ReadFloat();
            break;
          }
          case 77: {
            RoundingDifference = input.ReadFloat();
            break;
          }
          case 80: {
            IsRefunded = input.ReadBool();
            break;
          }
          case 90: {
            if (timestamp_ == null) {
              Timestamp = new global::PKIo.Date();
            }
            input.ReadMessage(Timestamp);
            break;
          }
          case 98: {
            Currency = input.ReadString();
            break;
          }
          case 106: {
            if (location_ == null) {
              Location = new global::PKIo.GPSLocation();
            }
            input.ReadMessage(Location);
            break;
          }
          case 114: {
            TransactionSource = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class DiscountItem : pb::IMessage<DiscountItem> {
    private static readonly pb::MessageParser<DiscountItem> _parser = new pb::MessageParser<DiscountItem>(() => new DiscountItem());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DiscountItem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::PKIo.TransactionReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DiscountItem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DiscountItem(DiscountItem other) : this() {
      discountCode_ = other.discountCode_;
      voucherCode_ = other.voucherCode_;
      amount_ = other.amount_;
      itemName_ = other.itemName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DiscountItem Clone() {
      return new DiscountItem(this);
    }

    /// <summary>Field number for the "discountCode" field.</summary>
    public const int DiscountCodeFieldNumber = 1;
    private string discountCode_ = "";
    /// <summary>
    /// Discount code
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DiscountCode {
      get { return discountCode_; }
      set {
        discountCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "voucherCode" field.</summary>
    public const int VoucherCodeFieldNumber = 2;
    private string voucherCode_ = "";
    /// <summary>
    /// Specific voucher code
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string VoucherCode {
      get { return voucherCode_; }
      set {
        voucherCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "amount" field.</summary>
    public const int AmountFieldNumber = 4;
    private float amount_;
    /// <summary>
    /// The discount amount
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Amount {
      get { return amount_; }
      set {
        amount_ = value;
      }
    }

    /// <summary>Field number for the "itemName" field.</summary>
    public const int ItemNameFieldNumber = 5;
    private string itemName_ = "";
    /// <summary>
    /// The discount item name
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ItemName {
      get { return itemName_; }
      set {
        itemName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DiscountItem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DiscountItem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DiscountCode != other.DiscountCode) return false;
      if (VoucherCode != other.VoucherCode) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Amount, other.Amount)) return false;
      if (ItemName != other.ItemName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (DiscountCode.Length != 0) hash ^= DiscountCode.GetHashCode();
      if (VoucherCode.Length != 0) hash ^= VoucherCode.GetHashCode();
      if (Amount != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Amount);
      if (ItemName.Length != 0) hash ^= ItemName.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (DiscountCode.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(DiscountCode);
      }
      if (VoucherCode.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(VoucherCode);
      }
      if (Amount != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(Amount);
      }
      if (ItemName.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(ItemName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (DiscountCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DiscountCode);
      }
      if (VoucherCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(VoucherCode);
      }
      if (Amount != 0F) {
        size += 1 + 4;
      }
      if (ItemName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ItemName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DiscountItem other) {
      if (other == null) {
        return;
      }
      if (other.DiscountCode.Length != 0) {
        DiscountCode = other.DiscountCode;
      }
      if (other.VoucherCode.Length != 0) {
        VoucherCode = other.VoucherCode;
      }
      if (other.Amount != 0F) {
        Amount = other.Amount;
      }
      if (other.ItemName.Length != 0) {
        ItemName = other.ItemName;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            DiscountCode = input.ReadString();
            break;
          }
          case 18: {
            VoucherCode = input.ReadString();
            break;
          }
          case 37: {
            Amount = input.ReadFloat();
            break;
          }
          case 42: {
            ItemName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class OrderItem : pb::IMessage<OrderItem> {
    private static readonly pb::MessageParser<OrderItem> _parser = new pb::MessageParser<OrderItem>(() => new OrderItem());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OrderItem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::PKIo.TransactionReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OrderItem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OrderItem(OrderItem other) : this() {
      amount_ = other.amount_;
      tax_ = other.tax_;
      itemName_ = other.itemName_;
      quantity_ = other.quantity_;
      sku_ = other.sku_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OrderItem Clone() {
      return new OrderItem(this);
    }

    /// <summary>Field number for the "amount" field.</summary>
    public const int AmountFieldNumber = 1;
    private float amount_;
    /// <summary>
    /// The item price
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Amount {
      get { return amount_; }
      set {
        amount_ = value;
      }
    }

    /// <summary>Field number for the "tax" field.</summary>
    public const int TaxFieldNumber = 2;
    private float tax_;
    /// <summary>
    /// Tax on the item
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Tax {
      get { return tax_; }
      set {
        tax_ = value;
      }
    }

    /// <summary>Field number for the "itemName" field.</summary>
    public const int ItemNameFieldNumber = 3;
    private string itemName_ = "";
    /// <summary>
    /// The item name
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ItemName {
      get { return itemName_; }
      set {
        itemName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "quantity" field.</summary>
    public const int QuantityFieldNumber = 4;
    private int quantity_;
    /// <summary>
    /// The quantity of items ordered
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Quantity {
      get { return quantity_; }
      set {
        quantity_ = value;
      }
    }

    /// <summary>Field number for the "sku" field.</summary>
    public const int SkuFieldNumber = 5;
    private string sku_ = "";
    /// <summary>
    /// The SKU as used in the system generating the transaction
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Sku {
      get { return sku_; }
      set {
        sku_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OrderItem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OrderItem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Amount, other.Amount)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Tax, other.Tax)) return false;
      if (ItemName != other.ItemName) return false;
      if (Quantity != other.Quantity) return false;
      if (Sku != other.Sku) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Amount != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Amount);
      if (Tax != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Tax);
      if (ItemName.Length != 0) hash ^= ItemName.GetHashCode();
      if (Quantity != 0) hash ^= Quantity.GetHashCode();
      if (Sku.Length != 0) hash ^= Sku.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Amount != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(Amount);
      }
      if (Tax != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(Tax);
      }
      if (ItemName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ItemName);
      }
      if (Quantity != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Quantity);
      }
      if (Sku.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Sku);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Amount != 0F) {
        size += 1 + 4;
      }
      if (Tax != 0F) {
        size += 1 + 4;
      }
      if (ItemName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ItemName);
      }
      if (Quantity != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Quantity);
      }
      if (Sku.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Sku);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(OrderItem other) {
      if (other == null) {
        return;
      }
      if (other.Amount != 0F) {
        Amount = other.Amount;
      }
      if (other.Tax != 0F) {
        Tax = other.Tax;
      }
      if (other.ItemName.Length != 0) {
        ItemName = other.ItemName;
      }
      if (other.Quantity != 0) {
        Quantity = other.Quantity;
      }
      if (other.Sku.Length != 0) {
        Sku = other.Sku;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 13: {
            Amount = input.ReadFloat();
            break;
          }
          case 21: {
            Tax = input.ReadFloat();
            break;
          }
          case 26: {
            ItemName = input.ReadString();
            break;
          }
          case 32: {
            Quantity = input.ReadInt32();
            break;
          }
          case 42: {
            Sku = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code