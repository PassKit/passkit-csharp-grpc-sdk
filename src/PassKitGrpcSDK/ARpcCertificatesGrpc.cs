// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: io/core/a_rpc_certificates.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace PassKitGrpcSDK {
  public static partial class Certificates
  {
    static readonly string __ServiceName = "io.Certificates";

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

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

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

    static readonly grpc::Marshaller<global::PassKitGrpcSDK.PassTypeIdentifier> __Marshaller_io_PassTypeIdentifier = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PassKitGrpcSDK.PassTypeIdentifier.Parser));
    static readonly grpc::Marshaller<global::PassKitGrpcSDK.CertificateData> __Marshaller_io_CertificateData = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PassKitGrpcSDK.CertificateData.Parser));
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    static readonly grpc::Marshaller<global::PassKitGrpcSDK.CertificateSigningRequest> __Marshaller_io_CertificateSigningRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PassKitGrpcSDK.CertificateSigningRequest.Parser));
    static readonly grpc::Marshaller<global::PassKitGrpcSDK.FileBytes> __Marshaller_io_FileBytes = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PassKitGrpcSDK.FileBytes.Parser));
    static readonly grpc::Marshaller<global::PassKitGrpcSDK.Pagination> __Marshaller_io_Pagination = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PassKitGrpcSDK.Pagination.Parser));
    static readonly grpc::Marshaller<global::PassKitGrpcSDK.Filters> __Marshaller_io_Filters = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PassKitGrpcSDK.Filters.Parser));
    static readonly grpc::Marshaller<global::PassKitGrpcSDK.Count> __Marshaller_io_Count = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PassKitGrpcSDK.Count.Parser));
    static readonly grpc::Marshaller<global::PassKitGrpcSDK.NFCSigningCredentialsRequest> __Marshaller_io_NFCSigningCredentialsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PassKitGrpcSDK.NFCSigningCredentialsRequest.Parser));

    static readonly grpc::Method<global::PassKitGrpcSDK.PassTypeIdentifier, global::PassKitGrpcSDK.CertificateData> __Method_getAppleCertificateData = new grpc::Method<global::PassKitGrpcSDK.PassTypeIdentifier, global::PassKitGrpcSDK.CertificateData>(
        grpc::MethodType.Unary,
        __ServiceName,
        "getAppleCertificateData",
        __Marshaller_io_PassTypeIdentifier,
        __Marshaller_io_CertificateData);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::PassKitGrpcSDK.CertificateSigningRequest> __Method_getCertificateSigningRequest = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::PassKitGrpcSDK.CertificateSigningRequest>(
        grpc::MethodType.Unary,
        __ServiceName,
        "getCertificateSigningRequest",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_io_CertificateSigningRequest);

    static readonly grpc::Method<global::PassKitGrpcSDK.FileBytes, global::PassKitGrpcSDK.CertificateData> __Method_addAppleCertificate = new grpc::Method<global::PassKitGrpcSDK.FileBytes, global::PassKitGrpcSDK.CertificateData>(
        grpc::MethodType.Unary,
        __ServiceName,
        "addAppleCertificate",
        __Marshaller_io_FileBytes,
        __Marshaller_io_CertificateData);

    static readonly grpc::Method<global::PassKitGrpcSDK.FileBytes, global::PassKitGrpcSDK.CertificateData> __Method_updateAppleCertificate = new grpc::Method<global::PassKitGrpcSDK.FileBytes, global::PassKitGrpcSDK.CertificateData>(
        grpc::MethodType.Unary,
        __ServiceName,
        "updateAppleCertificate",
        __Marshaller_io_FileBytes,
        __Marshaller_io_CertificateData);

    static readonly grpc::Method<global::PassKitGrpcSDK.Pagination, global::PassKitGrpcSDK.CertificateData> __Method_listAppleCertificatesDeprecated = new grpc::Method<global::PassKitGrpcSDK.Pagination, global::PassKitGrpcSDK.CertificateData>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "listAppleCertificatesDeprecated",
        __Marshaller_io_Pagination,
        __Marshaller_io_CertificateData);

    static readonly grpc::Method<global::PassKitGrpcSDK.Filters, global::PassKitGrpcSDK.CertificateData> __Method_listAppleCertificates = new grpc::Method<global::PassKitGrpcSDK.Filters, global::PassKitGrpcSDK.CertificateData>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "listAppleCertificates",
        __Marshaller_io_Filters,
        __Marshaller_io_CertificateData);

    static readonly grpc::Method<global::PassKitGrpcSDK.Pagination, global::PassKitGrpcSDK.Count> __Method_countAppleCertificatesDeprecated = new grpc::Method<global::PassKitGrpcSDK.Pagination, global::PassKitGrpcSDK.Count>(
        grpc::MethodType.Unary,
        __ServiceName,
        "countAppleCertificatesDeprecated",
        __Marshaller_io_Pagination,
        __Marshaller_io_Count);

    static readonly grpc::Method<global::PassKitGrpcSDK.Filters, global::PassKitGrpcSDK.Count> __Method_countAppleCertificates = new grpc::Method<global::PassKitGrpcSDK.Filters, global::PassKitGrpcSDK.Count>(
        grpc::MethodType.Unary,
        __ServiceName,
        "countAppleCertificates",
        __Marshaller_io_Filters,
        __Marshaller_io_Count);

    static readonly grpc::Method<global::PassKitGrpcSDK.NFCSigningCredentialsRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_sendNFCSigningCredentials = new grpc::Method<global::PassKitGrpcSDK.NFCSigningCredentialsRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "sendNFCSigningCredentials",
        __Marshaller_io_NFCSigningCredentialsRequest,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::PassKitGrpcSDK.ARpcCertificatesReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for Certificates</summary>
    public partial class CertificatesClient : grpc::ClientBase<CertificatesClient>
    {
      /// <summary>Creates a new client for Certificates</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CertificatesClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Certificates that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CertificatesClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CertificatesClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CertificatesClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::PassKitGrpcSDK.CertificateData getAppleCertificateData(global::PassKitGrpcSDK.PassTypeIdentifier request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return getAppleCertificateData(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::PassKitGrpcSDK.CertificateData getAppleCertificateData(global::PassKitGrpcSDK.PassTypeIdentifier request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_getAppleCertificateData, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::PassKitGrpcSDK.CertificateData> getAppleCertificateDataAsync(global::PassKitGrpcSDK.PassTypeIdentifier request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return getAppleCertificateDataAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::PassKitGrpcSDK.CertificateData> getAppleCertificateDataAsync(global::PassKitGrpcSDK.PassTypeIdentifier request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_getAppleCertificateData, null, options, request);
      }
      public virtual global::PassKitGrpcSDK.CertificateSigningRequest getCertificateSigningRequest(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return getCertificateSigningRequest(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::PassKitGrpcSDK.CertificateSigningRequest getCertificateSigningRequest(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_getCertificateSigningRequest, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::PassKitGrpcSDK.CertificateSigningRequest> getCertificateSigningRequestAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return getCertificateSigningRequestAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::PassKitGrpcSDK.CertificateSigningRequest> getCertificateSigningRequestAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_getCertificateSigningRequest, null, options, request);
      }
      public virtual global::PassKitGrpcSDK.CertificateData addAppleCertificate(global::PassKitGrpcSDK.FileBytes request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return addAppleCertificate(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::PassKitGrpcSDK.CertificateData addAppleCertificate(global::PassKitGrpcSDK.FileBytes request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_addAppleCertificate, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::PassKitGrpcSDK.CertificateData> addAppleCertificateAsync(global::PassKitGrpcSDK.FileBytes request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return addAppleCertificateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::PassKitGrpcSDK.CertificateData> addAppleCertificateAsync(global::PassKitGrpcSDK.FileBytes request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_addAppleCertificate, null, options, request);
      }
      public virtual global::PassKitGrpcSDK.CertificateData updateAppleCertificate(global::PassKitGrpcSDK.FileBytes request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return updateAppleCertificate(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::PassKitGrpcSDK.CertificateData updateAppleCertificate(global::PassKitGrpcSDK.FileBytes request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_updateAppleCertificate, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::PassKitGrpcSDK.CertificateData> updateAppleCertificateAsync(global::PassKitGrpcSDK.FileBytes request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return updateAppleCertificateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::PassKitGrpcSDK.CertificateData> updateAppleCertificateAsync(global::PassKitGrpcSDK.FileBytes request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_updateAppleCertificate, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::PassKitGrpcSDK.CertificateData> listAppleCertificatesDeprecated(global::PassKitGrpcSDK.Pagination request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return listAppleCertificatesDeprecated(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::PassKitGrpcSDK.CertificateData> listAppleCertificatesDeprecated(global::PassKitGrpcSDK.Pagination request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_listAppleCertificatesDeprecated, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::PassKitGrpcSDK.CertificateData> listAppleCertificates(global::PassKitGrpcSDK.Filters request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return listAppleCertificates(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::PassKitGrpcSDK.CertificateData> listAppleCertificates(global::PassKitGrpcSDK.Filters request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_listAppleCertificates, null, options, request);
      }
      public virtual global::PassKitGrpcSDK.Count countAppleCertificatesDeprecated(global::PassKitGrpcSDK.Pagination request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return countAppleCertificatesDeprecated(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::PassKitGrpcSDK.Count countAppleCertificatesDeprecated(global::PassKitGrpcSDK.Pagination request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_countAppleCertificatesDeprecated, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::PassKitGrpcSDK.Count> countAppleCertificatesDeprecatedAsync(global::PassKitGrpcSDK.Pagination request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return countAppleCertificatesDeprecatedAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::PassKitGrpcSDK.Count> countAppleCertificatesDeprecatedAsync(global::PassKitGrpcSDK.Pagination request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_countAppleCertificatesDeprecated, null, options, request);
      }
      public virtual global::PassKitGrpcSDK.Count countAppleCertificates(global::PassKitGrpcSDK.Filters request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return countAppleCertificates(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::PassKitGrpcSDK.Count countAppleCertificates(global::PassKitGrpcSDK.Filters request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_countAppleCertificates, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::PassKitGrpcSDK.Count> countAppleCertificatesAsync(global::PassKitGrpcSDK.Filters request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return countAppleCertificatesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::PassKitGrpcSDK.Count> countAppleCertificatesAsync(global::PassKitGrpcSDK.Filters request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_countAppleCertificates, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty sendNFCSigningCredentials(global::PassKitGrpcSDK.NFCSigningCredentialsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return sendNFCSigningCredentials(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty sendNFCSigningCredentials(global::PassKitGrpcSDK.NFCSigningCredentialsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_sendNFCSigningCredentials, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> sendNFCSigningCredentialsAsync(global::PassKitGrpcSDK.NFCSigningCredentialsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return sendNFCSigningCredentialsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> sendNFCSigningCredentialsAsync(global::PassKitGrpcSDK.NFCSigningCredentialsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_sendNFCSigningCredentials, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override CertificatesClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CertificatesClient(configuration);
      }
    }

  }
}
#endregion