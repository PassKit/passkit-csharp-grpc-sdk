// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: io/common/links.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PKIo {

  /// <summary>Holder for reflection information generated from io/common/links.proto</summary>
  public static partial class LinksReflection {

    #region Descriptor
    /// <summary>File descriptor for io/common/links.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LinksReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVpby9jb21tb24vbGlua3MucHJvdG8SAmlvGh5pby9jb21tb24vY29tbW9u",
            "X29iamVjdHMucHJvdG8aHGlvL2NvbW1vbi9sb2NhbGl6YXRpb24ucHJvdG8i",
            "0wEKBExpbmsSCgoCaWQYASABKAkSCwoDdXJsGAIgASgJEg0KBXRpdGxlGAMg",
            "ASgJEhoKBHR5cGUYBCABKA4yDC5pby5MaW5rVHlwZRIqCg1sb2NhbGl6ZWRM",
            "aW5rGAUgASgLMhMuaW8uTG9jYWxpemVkU3RyaW5nEisKDmxvY2FsaXplZFRp",
            "dGxlGAYgASgLMhMuaW8uTG9jYWxpemVkU3RyaW5nEhwKBXVzYWdlGAcgAygO",
            "Mg0uaW8uVXNhZ2VUeXBlEhAKCHBvc2l0aW9uGAggASgNIiEKBkRiTGluaxIX",
            "CgVsaW5rcxgBIAMoCzIILmlvLkxpbmsqawoITGlua1R5cGUSEgoOVVJJX0RP",
            "X05PVF9VU0UQABILCgdVUklfV0VCEAESCwoHVVJJX1RFTBACEg0KCVVSSV9F",
            "TUFJTBADEhAKDFVSSV9MT0NBVElPThAEEhAKDFVSSV9DQUxFTkRBUhAFQj4K",
            "D2lvLnBhc3NraXQuUEtpb1okc3Rhc2gucGFzc2tpdC5jb20vaW8vbW9kZWwv",
            "c2RrL2dvL2lvqgIEUEtJb2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::PKIo.CommonObjectsReflection.Descriptor, global::PKIo.LocalizationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::PKIo.LinkType), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PKIo.Link), global::PKIo.Link.Parser, new[]{ "Id", "Url", "Title", "Type", "LocalizedLink", "LocalizedTitle", "Usage", "Position" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::PKIo.DbLink), global::PKIo.DbLink.Parser, new[]{ "Links" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// Used to specify the type of link for link field. Each type has different icon on Google Pay.
  /// </summary>
  public enum LinkType {
    /// <summary>
    /// A link to website.
    /// </summary>
    [pbr::OriginalName("URI_DO_NOT_USE")] UriDoNotUse = 0,
    /// <summary>
    /// A link to website.
    /// </summary>
    [pbr::OriginalName("URI_WEB")] UriWeb = 1,
    /// <summary>
    /// A phone number.
    /// </summary>
    [pbr::OriginalName("URI_TEL")] UriTel = 2,
    /// <summary>
    /// An email address.
    /// </summary>
    [pbr::OriginalName("URI_EMAIL")] UriEmail = 3,
    /// <summary>
    /// A location address.
    /// </summary>
    [pbr::OriginalName("URI_LOCATION")] UriLocation = 4,
    /// <summary>
    /// A calendar event.
    /// </summary>
    [pbr::OriginalName("URI_CALENDAR")] UriCalendar = 5,
  }

  #endregion

  #region Messages
  /// <summary>
  /// Used to specify links put on the back of the pass.
  /// </summary>
  public sealed partial class Link : pb::IMessage<Link> {
    private static readonly pb::MessageParser<Link> _parser = new pb::MessageParser<Link>(() => new Link());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Link> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::PKIo.LinksReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Link() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Link(Link other) : this() {
      id_ = other.id_;
      url_ = other.url_;
      title_ = other.title_;
      type_ = other.type_;
      localizedLink_ = other.localizedLink_ != null ? other.localizedLink_.Clone() : null;
      localizedTitle_ = other.localizedTitle_ != null ? other.localizedTitle_.Clone() : null;
      usage_ = other.usage_.Clone();
      position_ = other.position_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Link Clone() {
      return new Link(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    /// <summary>
    /// Link Id. Not writable.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "url" field.</summary>
    public const int UrlFieldNumber = 2;
    private string url_ = "";
    /// <summary>
    /// A link text.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Url {
      get { return url_; }
      set {
        url_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "title" field.</summary>
    public const int TitleFieldNumber = 3;
    private string title_ = "";
    /// <summary>
    /// Title for the link.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Title {
      get { return title_; }
      set {
        title_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 4;
    private global::PKIo.LinkType type_ = global::PKIo.LinkType.UriDoNotUse;
    /// <summary>
    /// Type of link data.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::PKIo.LinkType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "localizedLink" field.</summary>
    public const int LocalizedLinkFieldNumber = 5;
    private global::PKIo.LocalizedString localizedLink_;
    /// <summary>
    /// This customises link text for different languages. Ignored by Google Pay passes.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::PKIo.LocalizedString LocalizedLink {
      get { return localizedLink_; }
      set {
        localizedLink_ = value;
      }
    }

    /// <summary>Field number for the "localizedTitle" field.</summary>
    public const int LocalizedTitleFieldNumber = 6;
    private global::PKIo.LocalizedString localizedTitle_;
    /// <summary>
    /// This translates link title in different languages.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::PKIo.LocalizedString LocalizedTitle {
      get { return localizedTitle_; }
      set {
        localizedTitle_ = value;
      }
    }

    /// <summary>Field number for the "usage" field.</summary>
    public const int UsageFieldNumber = 7;
    private static readonly pb::FieldCodec<global::PKIo.UsageType> _repeated_usage_codec
        = pb::FieldCodec.ForEnum(58, x => (int) x, x => (global::PKIo.UsageType) x);
    private readonly pbc::RepeatedField<global::PKIo.UsageType> usage_ = new pbc::RepeatedField<global::PKIo.UsageType>();
    /// <summary>
    /// Indicates which wallets the link should be rendered for (this allows to hide certain link on Apple Wallet, and vise versa).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::PKIo.UsageType> Usage {
      get { return usage_; }
    }

    /// <summary>Field number for the "position" field.</summary>
    public const int PositionFieldNumber = 8;
    private uint position_;
    /// <summary>
    /// Links will be rendered in order of their position, from lowest to highest. Position can be any value, E.g. 3 links with positions 30, 10, 20 would render 10 first, 20 second and 30 third.  If no position is provided, the order of the links cannot be guaranteed.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Position {
      get { return position_; }
      set {
        position_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Link);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Link other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Url != other.Url) return false;
      if (Title != other.Title) return false;
      if (Type != other.Type) return false;
      if (!object.Equals(LocalizedLink, other.LocalizedLink)) return false;
      if (!object.Equals(LocalizedTitle, other.LocalizedTitle)) return false;
      if(!usage_.Equals(other.usage_)) return false;
      if (Position != other.Position) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Url.Length != 0) hash ^= Url.GetHashCode();
      if (Title.Length != 0) hash ^= Title.GetHashCode();
      if (Type != global::PKIo.LinkType.UriDoNotUse) hash ^= Type.GetHashCode();
      if (localizedLink_ != null) hash ^= LocalizedLink.GetHashCode();
      if (localizedTitle_ != null) hash ^= LocalizedTitle.GetHashCode();
      hash ^= usage_.GetHashCode();
      if (Position != 0) hash ^= Position.GetHashCode();
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Url.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Url);
      }
      if (Title.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Title);
      }
      if (Type != global::PKIo.LinkType.UriDoNotUse) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Type);
      }
      if (localizedLink_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(LocalizedLink);
      }
      if (localizedTitle_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(LocalizedTitle);
      }
      usage_.WriteTo(output, _repeated_usage_codec);
      if (Position != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Position);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Url.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Url);
      }
      if (Title.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Title);
      }
      if (Type != global::PKIo.LinkType.UriDoNotUse) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (localizedLink_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LocalizedLink);
      }
      if (localizedTitle_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LocalizedTitle);
      }
      size += usage_.CalculateSize(_repeated_usage_codec);
      if (Position != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Position);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Link other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Url.Length != 0) {
        Url = other.Url;
      }
      if (other.Title.Length != 0) {
        Title = other.Title;
      }
      if (other.Type != global::PKIo.LinkType.UriDoNotUse) {
        Type = other.Type;
      }
      if (other.localizedLink_ != null) {
        if (localizedLink_ == null) {
          LocalizedLink = new global::PKIo.LocalizedString();
        }
        LocalizedLink.MergeFrom(other.LocalizedLink);
      }
      if (other.localizedTitle_ != null) {
        if (localizedTitle_ == null) {
          LocalizedTitle = new global::PKIo.LocalizedString();
        }
        LocalizedTitle.MergeFrom(other.LocalizedTitle);
      }
      usage_.Add(other.usage_);
      if (other.Position != 0) {
        Position = other.Position;
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
            Id = input.ReadString();
            break;
          }
          case 18: {
            Url = input.ReadString();
            break;
          }
          case 26: {
            Title = input.ReadString();
            break;
          }
          case 32: {
            Type = (global::PKIo.LinkType) input.ReadEnum();
            break;
          }
          case 42: {
            if (localizedLink_ == null) {
              LocalizedLink = new global::PKIo.LocalizedString();
            }
            input.ReadMessage(LocalizedLink);
            break;
          }
          case 50: {
            if (localizedTitle_ == null) {
              LocalizedTitle = new global::PKIo.LocalizedString();
            }
            input.ReadMessage(LocalizedTitle);
            break;
          }
          case 58:
          case 56: {
            usage_.AddEntriesFrom(input, _repeated_usage_codec);
            break;
          }
          case 64: {
            Position = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class DbLink : pb::IMessage<DbLink> {
    private static readonly pb::MessageParser<DbLink> _parser = new pb::MessageParser<DbLink>(() => new DbLink());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DbLink> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::PKIo.LinksReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DbLink() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DbLink(DbLink other) : this() {
      links_ = other.links_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DbLink Clone() {
      return new DbLink(this);
    }

    /// <summary>Field number for the "links" field.</summary>
    public const int LinksFieldNumber = 1;
    private static readonly pb::FieldCodec<global::PKIo.Link> _repeated_links_codec
        = pb::FieldCodec.ForMessage(10, global::PKIo.Link.Parser);
    private readonly pbc::RepeatedField<global::PKIo.Link> links_ = new pbc::RepeatedField<global::PKIo.Link>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::PKIo.Link> Links {
      get { return links_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DbLink);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DbLink other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!links_.Equals(other.links_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= links_.GetHashCode();
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
      links_.WriteTo(output, _repeated_links_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += links_.CalculateSize(_repeated_links_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DbLink other) {
      if (other == null) {
        return;
      }
      links_.Add(other.links_);
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
            links_.AddEntriesFrom(input, _repeated_links_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
