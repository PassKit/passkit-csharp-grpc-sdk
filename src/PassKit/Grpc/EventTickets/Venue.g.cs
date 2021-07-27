// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: io/event_tickets/venue.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PassKit.Grpc.EventTickets {

  /// <summary>Holder for reflection information generated from io/event_tickets/venue.proto</summary>
  public static partial class VenueReflection {

    #region Descriptor
    /// <summary>File descriptor for io/event_tickets/venue.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VenueReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chxpby9ldmVudF90aWNrZXRzL3ZlbnVlLnByb3RvEg1ldmVudF90aWNrZXRz",
            "Gh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvGhxpby9jb21tb24v",
            "bG9jYWxpemF0aW9uLnByb3RvGhlpby9jb21tb24vcHJveGltaXR5LnByb3Rv",
            "Gi5wcm90b2MtZ2VuLW9wZW5hcGl2Mi9vcHRpb25zL2Fubm90YXRpb25zLnBy",
            "b3RvIqQDCgVWZW51ZRIRCgJpZBgBIAEoCUIFkkECQAESCwoDdWlkGAIgASgJ",
            "EgwKBG5hbWUYAyABKAkSKgoNbG9jYWxpemVkTmFtZRgEIAEoCzITLmlvLkxv",
            "Y2FsaXplZFN0cmluZxIPCgdhZGRyZXNzGAUgASgJEi0KEGxvY2FsaXplZEFk",
            "ZHJlc3MYBiABKAsyEy5pby5Mb2NhbGl6ZWRTdHJpbmcSEAoIdGltZXpvbmUY",
            "ByABKAkSIgoJZ3BzQ29vcmRzGAggAygLMg8uaW8uR1BTTG9jYXRpb24SMgoH",
            "Y3JlYXRlZBgJIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXBCBZJB",
            "AkABEjIKB3VwZGF0ZWQYCiABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0",
            "YW1wQgWSQQJAATpjkkFgCl4qBVZlbnVlMjVWZW51ZSBob2xkcyBkZXRhaWxz",
            "IGFib3V0IHdoZXJlIHRoZSBldmVudCB0YWtlcyBwbGFjZdIBBG5hbWXSAQdh",
            "ZGRyZXNz0gEMaWFuYVRpbWV6b25lIpQBChpWZW51ZUxpbWl0ZWRGaWVsZHNS",
            "ZXNwb25zZRIKCgJpZBgBIAEoCRILCgN1aWQYAiABKAkSDAoEbmFtZRgDIAEo",
            "CTpPkkFMCkoqEVZlbnVlIChMaWdodCB2ZXIpMjVWZW51ZSBob2xkcyBkZXRh",
            "aWxzIGFib3V0IHdoZXJlIHRoZSBldmVudCB0YWtlcyBwbGFjZUJvCh1jb20u",
            "cGFzc2tpdC5ncnBjLkV2ZW50VGlja2V0c1oyc3Rhc2gucGFzc2tpdC5jb20v",
            "aW8vbW9kZWwvc2RrL2dvL2lvL2V2ZW50X3RpY2tldHOqAhlQYXNzS2l0Lkdy",
            "cGMuRXZlbnRUaWNrZXRzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::PassKit.Grpc.LocalizationReflection.Descriptor, global::PassKit.Grpc.ProximityReflection.Descriptor, global::PassKit.Grpc.Gateway.ProtocGenOpenapiv2.Options.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PassKit.Grpc.EventTickets.Venue), global::PassKit.Grpc.EventTickets.Venue.Parser, new[]{ "Id", "Uid", "Name", "LocalizedName", "Address", "LocalizedAddress", "Timezone", "GpsCoords", "Created", "Updated" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::PassKit.Grpc.EventTickets.VenueLimitedFieldsResponse), global::PassKit.Grpc.EventTickets.VenueLimitedFieldsResponse.Parser, new[]{ "Id", "Uid", "Name" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Venue : pb::IMessage<Venue>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Venue> _parser = new pb::MessageParser<Venue>(() => new Venue());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Venue> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::PassKit.Grpc.EventTickets.VenueReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Venue() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Venue(Venue other) : this() {
      id_ = other.id_;
      uid_ = other.uid_;
      name_ = other.name_;
      localizedName_ = other.localizedName_ != null ? other.localizedName_.Clone() : null;
      address_ = other.address_;
      localizedAddress_ = other.localizedAddress_ != null ? other.localizedAddress_.Clone() : null;
      timezone_ = other.timezone_;
      gpsCoords_ = other.gpsCoords_.Clone();
      created_ = other.created_ != null ? other.created_.Clone() : null;
      updated_ = other.updated_ != null ? other.updated_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Venue Clone() {
      return new Venue(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    /// <summary>
    /// PassKit generated venue id (22 characters).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 2;
    private string uid_ = "";
    /// <summary>
    /// User generated venue id; unique within the user account.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Uid {
      get { return uid_; }
      set {
        uid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 3;
    private string name_ = "";
    /// <summary>
    /// The venue name.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "localizedName" field.</summary>
    public const int LocalizedNameFieldNumber = 4;
    private global::PassKit.Grpc.LocalizedString localizedName_;
    /// <summary>
    /// Localized venue name.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::PassKit.Grpc.LocalizedString LocalizedName {
      get { return localizedName_; }
      set {
        localizedName_ = value;
      }
    }

    /// <summary>Field number for the "address" field.</summary>
    public const int AddressFieldNumber = 5;
    private string address_ = "";
    /// <summary>
    /// The venue address.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Address {
      get { return address_; }
      set {
        address_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "localizedAddress" field.</summary>
    public const int LocalizedAddressFieldNumber = 6;
    private global::PassKit.Grpc.LocalizedString localizedAddress_;
    /// <summary>
    /// Localized venue address.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::PassKit.Grpc.LocalizedString LocalizedAddress {
      get { return localizedAddress_; }
      set {
        localizedAddress_ = value;
      }
    }

    /// <summary>Field number for the "timezone" field.</summary>
    public const int TimezoneFieldNumber = 7;
    private string timezone_ = "";
    /// <summary>
    /// Timezone applied for the event dates. e.g. America/New_York, Asia/Singapore, Europe/London.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Timezone {
      get { return timezone_; }
      set {
        timezone_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "gpsCoords" field.</summary>
    public const int GpsCoordsFieldNumber = 8;
    private static readonly pb::FieldCodec<global::PassKit.Grpc.GPSLocation> _repeated_gpsCoords_codec
        = pb::FieldCodec.ForMessage(66, global::PassKit.Grpc.GPSLocation.Parser);
    private readonly pbc::RepeatedField<global::PassKit.Grpc.GPSLocation> gpsCoords_ = new pbc::RepeatedField<global::PassKit.Grpc.GPSLocation>();
    /// <summary>
    /// Optional GPS location details of the venue. If provided will be embedded into the ticket as the first GPS location.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::PassKit.Grpc.GPSLocation> GpsCoords {
      get { return gpsCoords_; }
    }

    /// <summary>Field number for the "created" field.</summary>
    public const int CreatedFieldNumber = 9;
    private global::Google.Protobuf.WellKnownTypes.Timestamp created_;
    /// <summary>
    /// The date the venue was created. Not writable.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp Created {
      get { return created_; }
      set {
        created_ = value;
      }
    }

    /// <summary>Field number for the "updated" field.</summary>
    public const int UpdatedFieldNumber = 10;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updated_;
    /// <summary>
    /// The date the venue updated. Not writable.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp Updated {
      get { return updated_; }
      set {
        updated_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Venue);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Venue other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Uid != other.Uid) return false;
      if (Name != other.Name) return false;
      if (!object.Equals(LocalizedName, other.LocalizedName)) return false;
      if (Address != other.Address) return false;
      if (!object.Equals(LocalizedAddress, other.LocalizedAddress)) return false;
      if (Timezone != other.Timezone) return false;
      if(!gpsCoords_.Equals(other.gpsCoords_)) return false;
      if (!object.Equals(Created, other.Created)) return false;
      if (!object.Equals(Updated, other.Updated)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Uid.Length != 0) hash ^= Uid.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (localizedName_ != null) hash ^= LocalizedName.GetHashCode();
      if (Address.Length != 0) hash ^= Address.GetHashCode();
      if (localizedAddress_ != null) hash ^= LocalizedAddress.GetHashCode();
      if (Timezone.Length != 0) hash ^= Timezone.GetHashCode();
      hash ^= gpsCoords_.GetHashCode();
      if (created_ != null) hash ^= Created.GetHashCode();
      if (updated_ != null) hash ^= Updated.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Uid.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Uid);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (localizedName_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(LocalizedName);
      }
      if (Address.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Address);
      }
      if (localizedAddress_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(LocalizedAddress);
      }
      if (Timezone.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Timezone);
      }
      gpsCoords_.WriteTo(output, _repeated_gpsCoords_codec);
      if (created_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(Created);
      }
      if (updated_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Updated);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Uid.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Uid);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (localizedName_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(LocalizedName);
      }
      if (Address.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Address);
      }
      if (localizedAddress_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(LocalizedAddress);
      }
      if (Timezone.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Timezone);
      }
      gpsCoords_.WriteTo(ref output, _repeated_gpsCoords_codec);
      if (created_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(Created);
      }
      if (updated_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Updated);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Uid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Uid);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (localizedName_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LocalizedName);
      }
      if (Address.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Address);
      }
      if (localizedAddress_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LocalizedAddress);
      }
      if (Timezone.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Timezone);
      }
      size += gpsCoords_.CalculateSize(_repeated_gpsCoords_codec);
      if (created_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Created);
      }
      if (updated_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Updated);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Venue other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Uid.Length != 0) {
        Uid = other.Uid;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.localizedName_ != null) {
        if (localizedName_ == null) {
          LocalizedName = new global::PassKit.Grpc.LocalizedString();
        }
        LocalizedName.MergeFrom(other.LocalizedName);
      }
      if (other.Address.Length != 0) {
        Address = other.Address;
      }
      if (other.localizedAddress_ != null) {
        if (localizedAddress_ == null) {
          LocalizedAddress = new global::PassKit.Grpc.LocalizedString();
        }
        LocalizedAddress.MergeFrom(other.LocalizedAddress);
      }
      if (other.Timezone.Length != 0) {
        Timezone = other.Timezone;
      }
      gpsCoords_.Add(other.gpsCoords_);
      if (other.created_ != null) {
        if (created_ == null) {
          Created = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        Created.MergeFrom(other.Created);
      }
      if (other.updated_ != null) {
        if (updated_ == null) {
          Updated = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        Updated.MergeFrom(other.Updated);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Uid = input.ReadString();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 34: {
            if (localizedName_ == null) {
              LocalizedName = new global::PassKit.Grpc.LocalizedString();
            }
            input.ReadMessage(LocalizedName);
            break;
          }
          case 42: {
            Address = input.ReadString();
            break;
          }
          case 50: {
            if (localizedAddress_ == null) {
              LocalizedAddress = new global::PassKit.Grpc.LocalizedString();
            }
            input.ReadMessage(LocalizedAddress);
            break;
          }
          case 58: {
            Timezone = input.ReadString();
            break;
          }
          case 66: {
            gpsCoords_.AddEntriesFrom(input, _repeated_gpsCoords_codec);
            break;
          }
          case 74: {
            if (created_ == null) {
              Created = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(Created);
            break;
          }
          case 82: {
            if (updated_ == null) {
              Updated = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(Updated);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Uid = input.ReadString();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 34: {
            if (localizedName_ == null) {
              LocalizedName = new global::PassKit.Grpc.LocalizedString();
            }
            input.ReadMessage(LocalizedName);
            break;
          }
          case 42: {
            Address = input.ReadString();
            break;
          }
          case 50: {
            if (localizedAddress_ == null) {
              LocalizedAddress = new global::PassKit.Grpc.LocalizedString();
            }
            input.ReadMessage(LocalizedAddress);
            break;
          }
          case 58: {
            Timezone = input.ReadString();
            break;
          }
          case 66: {
            gpsCoords_.AddEntriesFrom(ref input, _repeated_gpsCoords_codec);
            break;
          }
          case 74: {
            if (created_ == null) {
              Created = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(Created);
            break;
          }
          case 82: {
            if (updated_ == null) {
              Updated = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(Updated);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class VenueLimitedFieldsResponse : pb::IMessage<VenueLimitedFieldsResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<VenueLimitedFieldsResponse> _parser = new pb::MessageParser<VenueLimitedFieldsResponse>(() => new VenueLimitedFieldsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<VenueLimitedFieldsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::PassKit.Grpc.EventTickets.VenueReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VenueLimitedFieldsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VenueLimitedFieldsResponse(VenueLimitedFieldsResponse other) : this() {
      id_ = other.id_;
      uid_ = other.uid_;
      name_ = other.name_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VenueLimitedFieldsResponse Clone() {
      return new VenueLimitedFieldsResponse(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    /// <summary>
    /// PassKit generated venue id (22 characters).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 2;
    private string uid_ = "";
    /// <summary>
    /// User generated venue id; unique within the user account.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Uid {
      get { return uid_; }
      set {
        uid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 3;
    private string name_ = "";
    /// <summary>
    /// The venue name.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as VenueLimitedFieldsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(VenueLimitedFieldsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Uid != other.Uid) return false;
      if (Name != other.Name) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Uid.Length != 0) hash ^= Uid.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Uid.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Uid);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Uid.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Uid);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Uid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Uid);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(VenueLimitedFieldsResponse other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Uid.Length != 0) {
        Uid = other.Uid;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Uid = input.ReadString();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Uid = input.ReadString();
            break;
          }
          case 26: {
            Name = input.ReadString();
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