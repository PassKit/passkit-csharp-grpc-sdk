// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: io/core/a_rpc_distribution.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace PassKit.Grpc {
  /// <summary>
  /// The PassKit Distribution API allows you to create SmartPass links and manage the distribution of digital passes to your customers via email.
  /// </summary>
  public static partial class Distribution
  {
    static readonly string __ServiceName = "io.Distribution";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PassKit.Grpc.EmailDistributionRequest> __Marshaller_io_EmailDistributionRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PassKit.Grpc.EmailDistributionRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PassKit.Grpc.SmartPassLinkRequest> __Marshaller_io_SmartPassLinkRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PassKit.Grpc.SmartPassLinkRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PassKit.Grpc.Url> __Marshaller_io_Url = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PassKit.Grpc.Url.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PassKit.Grpc.ClassObjectInput> __Marshaller_io_ClassObjectInput = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PassKit.Grpc.ClassObjectInput.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PassKit.Grpc.DataCollectionFields> __Marshaller_io_DataCollectionFields = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PassKit.Grpc.DataCollectionFields.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PassKit.Grpc.SmartPassCsvUploadRequest> __Marshaller_io_SmartPassCsvUploadRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PassKit.Grpc.SmartPassCsvUploadRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PassKit.Grpc.ImportProtocolRequest> __Marshaller_io_ImportProtocolRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PassKit.Grpc.ImportProtocolRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PassKit.Grpc.Payload> __Marshaller_io_Payload = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PassKit.Grpc.Payload.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PassKit.Grpc.EmailDistributionRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_sendWelcomeEmail = new grpc::Method<global::PassKit.Grpc.EmailDistributionRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "sendWelcomeEmail",
        __Marshaller_io_EmailDistributionRequest,
        __Marshaller_google_protobuf_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PassKit.Grpc.SmartPassLinkRequest, global::PassKit.Grpc.Url> __Method_getSmartPassLink = new grpc::Method<global::PassKit.Grpc.SmartPassLinkRequest, global::PassKit.Grpc.Url>(
        grpc::MethodType.Unary,
        __ServiceName,
        "getSmartPassLink",
        __Marshaller_io_SmartPassLinkRequest,
        __Marshaller_io_Url);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PassKit.Grpc.ClassObjectInput, global::PassKit.Grpc.DataCollectionFields> __Method_getDataCollectionPageFields = new grpc::Method<global::PassKit.Grpc.ClassObjectInput, global::PassKit.Grpc.DataCollectionFields>(
        grpc::MethodType.Unary,
        __ServiceName,
        "getDataCollectionPageFields",
        __Marshaller_io_ClassObjectInput,
        __Marshaller_io_DataCollectionFields);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PassKit.Grpc.SmartPassCsvUploadRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_uploadSmartPassCsv = new grpc::Method<global::PassKit.Grpc.SmartPassCsvUploadRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "uploadSmartPassCsv",
        __Marshaller_io_SmartPassCsvUploadRequest,
        __Marshaller_google_protobuf_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PassKit.Grpc.ImportProtocolRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_importProtocolCsv = new grpc::Method<global::PassKit.Grpc.ImportProtocolRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "importProtocolCsv",
        __Marshaller_io_ImportProtocolRequest,
        __Marshaller_google_protobuf_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PassKit.Grpc.Payload, global::PassKit.Grpc.Payload> __Method_validateBarcode = new grpc::Method<global::PassKit.Grpc.Payload, global::PassKit.Grpc.Payload>(
        grpc::MethodType.Unary,
        __ServiceName,
        "validateBarcode",
        __Marshaller_io_Payload,
        __Marshaller_io_Payload);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::PassKit.Grpc.ARpcDistributionReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for Distribution</summary>
    public partial class DistributionClient : grpc::ClientBase<DistributionClient>
    {
      /// <summary>Creates a new client for Distribution</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public DistributionClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Distribution that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public DistributionClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected DistributionClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected DistributionClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Sends a welcome email to a single recipient using a valid pass protocol (e.g., membership, coupon, ticket). Required Fields: passId or externalId, classId, protocol.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty sendWelcomeEmail(global::PassKit.Grpc.EmailDistributionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return sendWelcomeEmail(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a welcome email to a single recipient using a valid pass protocol (e.g., membership, coupon, ticket). Required Fields: passId or externalId, classId, protocol.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty sendWelcomeEmail(global::PassKit.Grpc.EmailDistributionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_sendWelcomeEmail, null, options, request);
      }
      /// <summary>
      /// Sends a welcome email to a single recipient using a valid pass protocol (e.g., membership, coupon, ticket). Required Fields: passId or externalId, classId, protocol.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> sendWelcomeEmailAsync(global::PassKit.Grpc.EmailDistributionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return sendWelcomeEmailAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a welcome email to a single recipient using a valid pass protocol (e.g., membership, coupon, ticket). Required Fields: passId or externalId, classId, protocol.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> sendWelcomeEmailAsync(global::PassKit.Grpc.EmailDistributionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_sendWelcomeEmail, null, options, request);
      }
      /// <summary>
      /// Generates and returns an encrypted SmartPass link for a member, coupon, or event ticket based on the request payload. Required Fields: passId or externalId, classId.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PassKit.Grpc.Url getSmartPassLink(global::PassKit.Grpc.SmartPassLinkRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return getSmartPassLink(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Generates and returns an encrypted SmartPass link for a member, coupon, or event ticket based on the request payload. Required Fields: passId or externalId, classId.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PassKit.Grpc.Url getSmartPassLink(global::PassKit.Grpc.SmartPassLinkRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_getSmartPassLink, null, options, request);
      }
      /// <summary>
      /// Generates and returns an encrypted SmartPass link for a member, coupon, or event ticket based on the request payload. Required Fields: passId or externalId, classId.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PassKit.Grpc.Url> getSmartPassLinkAsync(global::PassKit.Grpc.SmartPassLinkRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return getSmartPassLinkAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Generates and returns an encrypted SmartPass link for a member, coupon, or event ticket based on the request payload. Required Fields: passId or externalId, classId.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PassKit.Grpc.Url> getSmartPassLinkAsync(global::PassKit.Grpc.SmartPassLinkRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_getSmartPassLink, null, options, request);
      }
      /// <summary>
      /// Returns a list of fields to be displayed on the data collection page. For the Member protocol, classId is required. Required Fields: classId (only for MEMBERSHIP protocol)
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PassKit.Grpc.DataCollectionFields getDataCollectionPageFields(global::PassKit.Grpc.ClassObjectInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return getDataCollectionPageFields(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns a list of fields to be displayed on the data collection page. For the Member protocol, classId is required. Required Fields: classId (only for MEMBERSHIP protocol)
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PassKit.Grpc.DataCollectionFields getDataCollectionPageFields(global::PassKit.Grpc.ClassObjectInput request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_getDataCollectionPageFields, null, options, request);
      }
      /// <summary>
      /// Returns a list of fields to be displayed on the data collection page. For the Member protocol, classId is required. Required Fields: classId (only for MEMBERSHIP protocol)
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PassKit.Grpc.DataCollectionFields> getDataCollectionPageFieldsAsync(global::PassKit.Grpc.ClassObjectInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return getDataCollectionPageFieldsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns a list of fields to be displayed on the data collection page. For the Member protocol, classId is required. Required Fields: classId (only for MEMBERSHIP protocol)
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PassKit.Grpc.DataCollectionFields> getDataCollectionPageFieldsAsync(global::PassKit.Grpc.ClassObjectInput request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_getDataCollectionPageFields, null, options, request);
      }
      /// <summary>
      /// Accepts a CSV file containing user data and a project short code, processes SmartPass creation, and sends results to the user via email. Required Fields: shortCode, csv contents.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty uploadSmartPassCsv(global::PassKit.Grpc.SmartPassCsvUploadRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return uploadSmartPassCsv(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Accepts a CSV file containing user data and a project short code, processes SmartPass creation, and sends results to the user via email. Required Fields: shortCode, csv contents.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty uploadSmartPassCsv(global::PassKit.Grpc.SmartPassCsvUploadRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_uploadSmartPassCsv, null, options, request);
      }
      /// <summary>
      /// Accepts a CSV file containing user data and a project short code, processes SmartPass creation, and sends results to the user via email. Required Fields: shortCode, csv contents.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> uploadSmartPassCsvAsync(global::PassKit.Grpc.SmartPassCsvUploadRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return uploadSmartPassCsvAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Accepts a CSV file containing user data and a project short code, processes SmartPass creation, and sends results to the user via email. Required Fields: shortCode, csv contents.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> uploadSmartPassCsvAsync(global::PassKit.Grpc.SmartPassCsvUploadRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_uploadSmartPassCsv, null, options, request);
      }
      /// <summary>
      /// Imports and processes a formatted CSV file for a given protocol (e.g., member, coupon) and creates billable records. Required: classId, protocol, and valid csv contents.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty importProtocolCsv(global::PassKit.Grpc.ImportProtocolRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return importProtocolCsv(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Imports and processes a formatted CSV file for a given protocol (e.g., member, coupon) and creates billable records. Required: classId, protocol, and valid csv contents.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty importProtocolCsv(global::PassKit.Grpc.ImportProtocolRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_importProtocolCsv, null, options, request);
      }
      /// <summary>
      /// Imports and processes a formatted CSV file for a given protocol (e.g., member, coupon) and creates billable records. Required: classId, protocol, and valid csv contents.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> importProtocolCsvAsync(global::PassKit.Grpc.ImportProtocolRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return importProtocolCsvAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Imports and processes a formatted CSV file for a given protocol (e.g., member, coupon) and creates billable records. Required: classId, protocol, and valid csv contents.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> importProtocolCsvAsync(global::PassKit.Grpc.ImportProtocolRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_importProtocolCsv, null, options, request);
      }
      /// <summary>
      /// Validates a time-based one-time password (TOTP) barcode string in the format {{payload}}||{{key}}||{{timestamp}}||{{totp}}. If valid, returns the cleaned payload without TOTP metadata. Required Fields: payload.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PassKit.Grpc.Payload validateBarcode(global::PassKit.Grpc.Payload request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return validateBarcode(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Validates a time-based one-time password (TOTP) barcode string in the format {{payload}}||{{key}}||{{timestamp}}||{{totp}}. If valid, returns the cleaned payload without TOTP metadata. Required Fields: payload.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PassKit.Grpc.Payload validateBarcode(global::PassKit.Grpc.Payload request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_validateBarcode, null, options, request);
      }
      /// <summary>
      /// Validates a time-based one-time password (TOTP) barcode string in the format {{payload}}||{{key}}||{{timestamp}}||{{totp}}. If valid, returns the cleaned payload without TOTP metadata. Required Fields: payload.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PassKit.Grpc.Payload> validateBarcodeAsync(global::PassKit.Grpc.Payload request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return validateBarcodeAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Validates a time-based one-time password (TOTP) barcode string in the format {{payload}}||{{key}}||{{timestamp}}||{{totp}}. If valid, returns the cleaned payload without TOTP metadata. Required Fields: payload.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PassKit.Grpc.Payload> validateBarcodeAsync(global::PassKit.Grpc.Payload request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_validateBarcode, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override DistributionClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new DistributionClient(configuration);
      }
    }

  }
}
#endregion
