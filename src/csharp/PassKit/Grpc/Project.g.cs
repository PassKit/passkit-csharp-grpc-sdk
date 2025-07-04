// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: io/common/project.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PassKit.Grpc {

  /// <summary>Holder for reflection information generated from io/common/project.proto</summary>
  public static partial class ProjectReflection {

    #region Descriptor
    /// <summary>File descriptor for io/common/project.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProjectReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chdpby9jb21tb24vcHJvamVjdC5wcm90bxICaW8aH2dvb2dsZS9wcm90b2J1",
            "Zi90aW1lc3RhbXAucHJvdG8aGWlvL2NvbW1vbi9wcm90b2NvbHMucHJvdG8a",
            "GGlvL2NvbW1vbi90ZW1wbGF0ZS5wcm90byLDAQoHUHJvamVjdBIiCghwcm90",
            "b2NvbBgBIAEoDjIQLmlvLlBhc3NQcm90b2NvbBIPCgdjbGFzc0lkGAIgASgJ",
            "EgwKBG5hbWUYAyABKAkSEQoJc2hvcnRDb2RlGAQgASgJEisKB2NyZWF0ZWQY",
            "BSABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wEg4KBnNlY3JldBgG",
            "IAEoCRILCgNrZXkYByABKAkSGAoQZW5jcnlwdGVkQ2xhc3NJZBgJIAEoCSJc",
            "ChhQcm9qZWN0QnlTaG9ydENvZGVSZXN1bHQSHAoHcHJvamVjdBgBIAEoCzIL",
            "LmlvLlByb2plY3QSIgoIdGVtcGxhdGUYAiABKAsyEC5pby5QYXNzVGVtcGxh",
            "dGUiOAoTUHJvamVjdFN0YXR1c0ZpbHRlchIhCgZzdGF0dXMYASABKA4yES5p",
            "by5Qcm9qZWN0U3RhdHVzKp4CCg1Qcm9qZWN0U3RhdHVzEhUKEU5PX1BST0pF",
            "Q1RfU1RBVFVTEAASJgoiUFJPSkVDVF9BQ1RJVkVfRk9SX09CSkVDVF9DUkVB",
            "VElPThABEigKJFBST0pFQ1RfRElTQUJMRURfRk9SX09CSkVDVF9DUkVBVElP",
            "ThACEhEKDVBST0pFQ1RfRFJBRlQQBBIVChFQUk9KRUNUX1BVQkxJU0hFRBAI",
            "EhMKD1BST0pFQ1RfUFJJVkFURRAQEhYKElBST0pFQ1RfT1ZFUl9RVU9UQRAg",
            "EhMKD1BST0pFQ1RfREVMRVRFRBBAEhoKFVBST0pFQ1RfRU1BSUxfV0FSTklO",
            "RxCAARIcChdQUk9KRUNUX0VNQUlMX1NVU1BFTkRFRBCAAkJHChBjb20ucGFz",
            "c2tpdC5ncnBjWiRzdGFzaC5wYXNza2l0LmNvbS9pby9tb2RlbC9zZGsvZ28v",
            "aW+qAgxQYXNzS2l0LkdycGNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::PassKit.Grpc.ProtocolsReflection.Descriptor, global::PassKit.Grpc.TemplateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::PassKit.Grpc.ProjectStatus), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PassKit.Grpc.Project), global::PassKit.Grpc.Project.Parser, new[]{ "Protocol", "ClassId", "Name", "ShortCode", "Created", "Secret", "Key", "EncryptedClassId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::PassKit.Grpc.ProjectByShortCodeResult), global::PassKit.Grpc.ProjectByShortCodeResult.Parser, new[]{ "Project", "Template" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::PassKit.Grpc.ProjectStatusFilter), global::PassKit.Grpc.ProjectStatusFilter.Parser, new[]{ "Status" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// Status options for a project. These can be combined using bitmasks.
  /// </summary>
  public enum ProjectStatus {
    /// <summary>
    /// Zero based enum, don't use 0.
    /// </summary>
    [pbr::OriginalName("NO_PROJECT_STATUS")] NoProjectStatus = 0,
    /// <summary>
    /// Active projects allow for creation of records (turned on by default).
    /// </summary>
    [pbr::OriginalName("PROJECT_ACTIVE_FOR_OBJECT_CREATION")] ProjectActiveForObjectCreation = 1,
    /// <summary>
    /// Disabled projects do not allow for creation of records (i.e. temporarily disable enroling of members / creating of coupons, etc).
    /// </summary>
    [pbr::OriginalName("PROJECT_DISABLED_FOR_OBJECT_CREATION")] ProjectDisabledForObjectCreation = 2,
    /// <summary>
    /// Default status for all projects. A draft project can do everything a published program can:
    /// Cards can be created, stats will show up, etc.
    /// Data belonging to draft projects is automatically purged every 7 days.
    /// A draft project uses a PassKit Apple Developer Certificate, and has a PassKit legal disclaimer on the back.
    /// Draft projects cannot be used for a production setup.
    /// </summary>
    [pbr::OriginalName("PROJECT_DRAFT")] ProjectDraft = 4,
    /// <summary>
    /// A project can only be published if a custom Apple Developer Certificate is uploaded, if payment details have been provided,
    /// and an account email address has been validated.
    /// Published projects do not have a PassKit legal disclaimer on the back.
    /// Published projects do not have their data purged on a 7 day basis.
    /// </summary>
    [pbr::OriginalName("PROJECT_PUBLISHED")] ProjectPublished = 8,
    /// <summary>
    /// A project is private: records can only by created by authorized users / via the portal interface.
    /// </summary>
    [pbr::OriginalName("PROJECT_PRIVATE")] ProjectPrivate = 16,
    /// <summary>
    /// The project is currently over quota, and new records cannot be created (set by system only; cannot be set by user)
    /// </summary>
    [pbr::OriginalName("PROJECT_OVER_QUOTA")] ProjectOverQuota = 32,
    /// <summary>
    /// A project which needs to be deleted. If delete flag is set, project will be deleted in the near future.
    /// </summary>
    [pbr::OriginalName("PROJECT_DELETED")] ProjectDeleted = 64,
    /// <summary>
    /// A project has exceeded the warning threshold for email bounces or complaints.
    /// </summary>
    [pbr::OriginalName("PROJECT_EMAIL_WARNING")] ProjectEmailWarning = 128,
    /// <summary>
    /// A project is unable to send emails as it has breached the email bounces or complaints threshold.
    /// </summary>
    [pbr::OriginalName("PROJECT_EMAIL_SUSPENDED")] ProjectEmailSuspended = 256,
  }

  #endregion

  #region Messages
  /// <summary>
  /// Project metadata object used throughout the platform.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Project : pb::IMessage<Project>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Project> _parser = new pb::MessageParser<Project>(() => new Project());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Project> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::PassKit.Grpc.ProjectReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Project() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Project(Project other) : this() {
      protocol_ = other.protocol_;
      classId_ = other.classId_;
      name_ = other.name_;
      shortCode_ = other.shortCode_;
      created_ = other.created_ != null ? other.created_.Clone() : null;
      secret_ = other.secret_;
      key_ = other.key_;
      encryptedClassId_ = other.encryptedClassId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Project Clone() {
      return new Project(this);
    }

    /// <summary>Field number for the "protocol" field.</summary>
    public const int ProtocolFieldNumber = 1;
    private global::PassKit.Grpc.PassProtocol protocol_ = global::PassKit.Grpc.PassProtocol.DoNotUse;
    /// <summary>
    /// The PassProtocol the project implements.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::PassKit.Grpc.PassProtocol Protocol {
      get { return protocol_; }
      set {
        protocol_ = value;
      }
    }

    /// <summary>Field number for the "classId" field.</summary>
    public const int ClassIdFieldNumber = 2;
    private string classId_ = "";
    /// <summary>
    /// The class ID that the projects refers to (highest level protocol object; i.e. member program id, coupon campaign id, etc).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ClassId {
      get { return classId_; }
      set {
        classId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 3;
    private string name_ = "";
    /// <summary>
    /// The project name.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "shortCode" field.</summary>
    public const int ShortCodeFieldNumber = 4;
    private string shortCode_ = "";
    /// <summary>
    /// The project short-code; used for creating public project URL's.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ShortCode {
      get { return shortCode_; }
      set {
        shortCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "created" field.</summary>
    public const int CreatedFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp created_;
    /// <summary>
    /// The timestamp when the project was created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp Created {
      get { return created_; }
      set {
        created_ = value;
      }
    }

    /// <summary>Field number for the "secret" field.</summary>
    public const int SecretFieldNumber = 6;
    private string secret_ = "";
    /// <summary>
    /// A shared secret used for creating signed links.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Secret {
      get { return secret_; }
      set {
        secret_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "key" field.</summary>
    public const int KeyFieldNumber = 7;
    private string key_ = "";
    /// <summary>
    /// A key used to create encrypted, signed links.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Key {
      get { return key_; }
      set {
        key_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "encryptedClassId" field.</summary>
    public const int EncryptedClassIdFieldNumber = 9;
    private string encryptedClassId_ = "";
    /// <summary>
    /// Encrypted class ID. Can be used in integrations where the Class ID needs to be publicly exposed.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string EncryptedClassId {
      get { return encryptedClassId_; }
      set {
        encryptedClassId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Project);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Project other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Protocol != other.Protocol) return false;
      if (ClassId != other.ClassId) return false;
      if (Name != other.Name) return false;
      if (ShortCode != other.ShortCode) return false;
      if (!object.Equals(Created, other.Created)) return false;
      if (Secret != other.Secret) return false;
      if (Key != other.Key) return false;
      if (EncryptedClassId != other.EncryptedClassId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Protocol != global::PassKit.Grpc.PassProtocol.DoNotUse) hash ^= Protocol.GetHashCode();
      if (ClassId.Length != 0) hash ^= ClassId.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (ShortCode.Length != 0) hash ^= ShortCode.GetHashCode();
      if (created_ != null) hash ^= Created.GetHashCode();
      if (Secret.Length != 0) hash ^= Secret.GetHashCode();
      if (Key.Length != 0) hash ^= Key.GetHashCode();
      if (EncryptedClassId.Length != 0) hash ^= EncryptedClassId.GetHashCode();
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
      if (Protocol != global::PassKit.Grpc.PassProtocol.DoNotUse) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Protocol);
      }
      if (ClassId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ClassId);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (ShortCode.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ShortCode);
      }
      if (created_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Created);
      }
      if (Secret.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Secret);
      }
      if (Key.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Key);
      }
      if (EncryptedClassId.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(EncryptedClassId);
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
      if (Protocol != global::PassKit.Grpc.PassProtocol.DoNotUse) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Protocol);
      }
      if (ClassId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ClassId);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (ShortCode.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ShortCode);
      }
      if (created_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Created);
      }
      if (Secret.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Secret);
      }
      if (Key.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Key);
      }
      if (EncryptedClassId.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(EncryptedClassId);
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
      if (Protocol != global::PassKit.Grpc.PassProtocol.DoNotUse) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Protocol);
      }
      if (ClassId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClassId);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (ShortCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ShortCode);
      }
      if (created_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Created);
      }
      if (Secret.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Secret);
      }
      if (Key.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Key);
      }
      if (EncryptedClassId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EncryptedClassId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Project other) {
      if (other == null) {
        return;
      }
      if (other.Protocol != global::PassKit.Grpc.PassProtocol.DoNotUse) {
        Protocol = other.Protocol;
      }
      if (other.ClassId.Length != 0) {
        ClassId = other.ClassId;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.ShortCode.Length != 0) {
        ShortCode = other.ShortCode;
      }
      if (other.created_ != null) {
        if (created_ == null) {
          Created = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        Created.MergeFrom(other.Created);
      }
      if (other.Secret.Length != 0) {
        Secret = other.Secret;
      }
      if (other.Key.Length != 0) {
        Key = other.Key;
      }
      if (other.EncryptedClassId.Length != 0) {
        EncryptedClassId = other.EncryptedClassId;
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
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Protocol = (global::PassKit.Grpc.PassProtocol) input.ReadEnum();
            break;
          }
          case 18: {
            ClassId = input.ReadString();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 34: {
            ShortCode = input.ReadString();
            break;
          }
          case 42: {
            if (created_ == null) {
              Created = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(Created);
            break;
          }
          case 50: {
            Secret = input.ReadString();
            break;
          }
          case 58: {
            Key = input.ReadString();
            break;
          }
          case 74: {
            EncryptedClassId = input.ReadString();
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
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Protocol = (global::PassKit.Grpc.PassProtocol) input.ReadEnum();
            break;
          }
          case 18: {
            ClassId = input.ReadString();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 34: {
            ShortCode = input.ReadString();
            break;
          }
          case 42: {
            if (created_ == null) {
              Created = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(Created);
            break;
          }
          case 50: {
            Secret = input.ReadString();
            break;
          }
          case 58: {
            Key = input.ReadString();
            break;
          }
          case 74: {
            EncryptedClassId = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Combined response of a project and its associated pass template when fetched by short code.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ProjectByShortCodeResult : pb::IMessage<ProjectByShortCodeResult>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ProjectByShortCodeResult> _parser = new pb::MessageParser<ProjectByShortCodeResult>(() => new ProjectByShortCodeResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ProjectByShortCodeResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::PassKit.Grpc.ProjectReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProjectByShortCodeResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProjectByShortCodeResult(ProjectByShortCodeResult other) : this() {
      project_ = other.project_ != null ? other.project_.Clone() : null;
      template_ = other.template_ != null ? other.template_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProjectByShortCodeResult Clone() {
      return new ProjectByShortCodeResult(this);
    }

    /// <summary>Field number for the "project" field.</summary>
    public const int ProjectFieldNumber = 1;
    private global::PassKit.Grpc.Project project_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::PassKit.Grpc.Project Project {
      get { return project_; }
      set {
        project_ = value;
      }
    }

    /// <summary>Field number for the "template" field.</summary>
    public const int TemplateFieldNumber = 2;
    private global::PassKit.Grpc.PassTemplate template_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::PassKit.Grpc.PassTemplate Template {
      get { return template_; }
      set {
        template_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ProjectByShortCodeResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ProjectByShortCodeResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Project, other.Project)) return false;
      if (!object.Equals(Template, other.Template)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (project_ != null) hash ^= Project.GetHashCode();
      if (template_ != null) hash ^= Template.GetHashCode();
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
      if (project_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Project);
      }
      if (template_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Template);
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
      if (project_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Project);
      }
      if (template_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Template);
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
      if (project_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Project);
      }
      if (template_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Template);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ProjectByShortCodeResult other) {
      if (other == null) {
        return;
      }
      if (other.project_ != null) {
        if (project_ == null) {
          Project = new global::PassKit.Grpc.Project();
        }
        Project.MergeFrom(other.Project);
      }
      if (other.template_ != null) {
        if (template_ == null) {
          Template = new global::PassKit.Grpc.PassTemplate();
        }
        Template.MergeFrom(other.Template);
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
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (project_ == null) {
              Project = new global::PassKit.Grpc.Project();
            }
            input.ReadMessage(Project);
            break;
          }
          case 18: {
            if (template_ == null) {
              Template = new global::PassKit.Grpc.PassTemplate();
            }
            input.ReadMessage(Template);
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
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (project_ == null) {
              Project = new global::PassKit.Grpc.Project();
            }
            input.ReadMessage(Project);
            break;
          }
          case 18: {
            if (template_ == null) {
              Template = new global::PassKit.Grpc.PassTemplate();
            }
            input.ReadMessage(Template);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Filter used to find projects by their current status.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ProjectStatusFilter : pb::IMessage<ProjectStatusFilter>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ProjectStatusFilter> _parser = new pb::MessageParser<ProjectStatusFilter>(() => new ProjectStatusFilter());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ProjectStatusFilter> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::PassKit.Grpc.ProjectReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProjectStatusFilter() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProjectStatusFilter(ProjectStatusFilter other) : this() {
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProjectStatusFilter Clone() {
      return new ProjectStatusFilter(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::PassKit.Grpc.ProjectStatus status_ = global::PassKit.Grpc.ProjectStatus.NoProjectStatus;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::PassKit.Grpc.ProjectStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ProjectStatusFilter);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ProjectStatusFilter other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != global::PassKit.Grpc.ProjectStatus.NoProjectStatus) hash ^= Status.GetHashCode();
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
      if (Status != global::PassKit.Grpc.ProjectStatus.NoProjectStatus) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Status);
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
      if (Status != global::PassKit.Grpc.ProjectStatus.NoProjectStatus) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Status);
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
      if (Status != global::PassKit.Grpc.ProjectStatus.NoProjectStatus) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ProjectStatusFilter other) {
      if (other == null) {
        return;
      }
      if (other.Status != global::PassKit.Grpc.ProjectStatus.NoProjectStatus) {
        Status = other.Status;
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
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Status = (global::PassKit.Grpc.ProjectStatus) input.ReadEnum();
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
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Status = (global::PassKit.Grpc.ProjectStatus) input.ReadEnum();
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
