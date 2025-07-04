// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: io/common/protocols.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PassKit.Grpc {

  /// <summary>Holder for reflection information generated from io/common/protocols.proto</summary>
  public static partial class ProtocolsReflection {

    #region Descriptor
    /// <summary>File descriptor for io/common/protocols.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProtocolsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chlpby9jb21tb24vcHJvdG9jb2xzLnByb3RvEgJpbyqgAQoMUGFzc1Byb3Rv",
            "Y29sEhwKGFBBU1NfUFJPVE9DT0xfRE9fTk9UX1VTRRAAEhAKDFJBV19QUk9U",
            "T0NPTBABEg8KC1YxX1BST1RPQ09MEAISEwoPRkxJR0hUX1BST1RPQ09MEAMS",
            "DgoKTUVNQkVSU0hJUBBkEhUKEVNJTkdMRV9VU0VfQ09VUE9OEGUSEwoPRVZF",
            "TlRfVElDS0VUSU5HEGYqjgIKFFByb3RvY29sQ29tbW9uRXZlbnRzEiUKIVBS",
            "T1RPQ09MX0NPTU1PTl9FVkVOVFNfRE9fTk9UX1VTRRAAEhgKFEVWRU5UX09C",
            "SkVDVF9DUkVBVEVEEAESGAoURVZFTlRfT0JKRUNUX1VQREFURUQQAhIYChRF",
            "VkVOVF9PQkpFQ1RfRVhQSVJFRBADEhgKFEVWRU5UX09CSkVDVF9ERUxFVEVE",
            "EAQSFQoRRVZFTlRfUEFTU19JU1NVRUQQBRIYChRFVkVOVF9QQVNTX0lOU1RB",
            "TExFRBAGEhoKFkVWRU5UX1BBU1NfVU5JTlNUQUxMRUQQBxIaChZFVkVOVF9Q",
            "QVNTX0lOVkFMSURBVEVEEAhCRwoQY29tLnBhc3NraXQuZ3JwY1okc3Rhc2gu",
            "cGFzc2tpdC5jb20vaW8vbW9kZWwvc2RrL2dvL2lvqgIMUGFzc0tpdC5HcnBj",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::PassKit.Grpc.PassProtocol), typeof(global::PassKit.Grpc.ProtocolCommonEvents), }, null, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// Enum representing different protocols supported.
  /// </summary>
  public enum PassProtocol {
    [pbr::OriginalName("PASS_PROTOCOL_DO_NOT_USE")] DoNotUse = 0,
    /// <summary>
    /// Reserved for raw pass protocol.
    /// </summary>
    [pbr::OriginalName("RAW_PROTOCOL")] RawProtocol = 1,
    /// <summary>
    /// Reserved for migrating legacy v1 passes.
    /// </summary>
    [pbr::OriginalName("V1_PROTOCOL")] V1Protocol = 2,
    /// <summary>
    /// Flights protocol: https://docs.passkit.io/protocols/boarding/
    /// </summary>
    [pbr::OriginalName("FLIGHT_PROTOCOL")] FlightProtocol = 3,
    /// <summary>
    /// Values 100 onwards are for PassKit generic protocols.
    /// Generic Membership protocol: https://docs.passkit.io/protocols/member/
    /// </summary>
    [pbr::OriginalName("MEMBERSHIP")] Membership = 100,
    /// <summary>
    /// Single Use Coupon protocol: https://docs.passkit.io/protocols/coupon/
    /// </summary>
    [pbr::OriginalName("SINGLE_USE_COUPON")] SingleUseCoupon = 101,
    /// <summary>
    /// Event Ticket protocol: https://docs.passkit.io/protocols/event/
    /// </summary>
    [pbr::OriginalName("EVENT_TICKETING")] EventTicketing = 102,
  }

  /// <summary>
  /// Enum describing events common to all protocols.
  /// </summary>
  public enum ProtocolCommonEvents {
    [pbr::OriginalName("PROTOCOL_COMMON_EVENTS_DO_NOT_USE")] DoNotUse = 0,
    /// <summary>
    /// Values 0-100 onwards are for PassKit events
    /// </summary>
    [pbr::OriginalName("EVENT_OBJECT_CREATED")] EventObjectCreated = 1,
    /// <summary>
    /// Set to when the object was updated
    /// </summary>
    [pbr::OriginalName("EVENT_OBJECT_UPDATED")] EventObjectUpdated = 2,
    /// <summary>
    /// Set to when the object was expired
    /// </summary>
    [pbr::OriginalName("EVENT_OBJECT_EXPIRED")] EventObjectExpired = 3,
    /// <summary>
    /// Set to when the object was deleted
    /// </summary>
    [pbr::OriginalName("EVENT_OBJECT_DELETED")] EventObjectDeleted = 4,
    /// <summary>
    /// Pass has been issued.
    /// </summary>
    [pbr::OriginalName("EVENT_PASS_ISSUED")] EventPassIssued = 5,
    /// <summary>
    /// Pass has been installed in a wallet.
    /// </summary>
    [pbr::OriginalName("EVENT_PASS_INSTALLED")] EventPassInstalled = 6,
    /// <summary>
    /// Pass has been uninstalled (possibly deleted) from a wallet.
    /// </summary>
    [pbr::OriginalName("EVENT_PASS_UNINSTALLED")] EventPassUninstalled = 7,
    /// <summary>
    /// Pass has been invalidated.
    /// </summary>
    [pbr::OriginalName("EVENT_PASS_INVALIDATED")] EventPassInvalidated = 8,
  }

  #endregion

}

#endregion Designer generated code
