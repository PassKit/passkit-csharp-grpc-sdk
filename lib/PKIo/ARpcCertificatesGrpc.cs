// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: io/core/a_rpc_certificates.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace PKIo {
  public static partial class Certificates
  {
    static readonly string __ServiceName = "io.Certificates";

    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PKIo.CertificateSigningRequest> __Marshaller_io_CertificateSigningRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PKIo.CertificateSigningRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PKIo.FileBytes> __Marshaller_io_FileBytes = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PKIo.FileBytes.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PKIo.CertificateData> __Marshaller_io_CertificateData = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PKIo.CertificateData.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PKIo.PassTypeIdentifier> __Marshaller_io_PassTypeIdentifier = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PKIo.PassTypeIdentifier.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PKIo.Pagination> __Marshaller_io_Pagination = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PKIo.Pagination.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PKIo.Filters> __Marshaller_io_Filters = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PKIo.Filters.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PKIo.Count> __Marshaller_io_Count = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PKIo.Count.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PKIo.NFCSigningCredentialsRequest> __Marshaller_io_NFCSigningCredentialsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PKIo.NFCSigningCredentialsRequest.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::PKIo.CertificateSigningRequest> __Method_getCertificateSigningRequest = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::PKIo.CertificateSigningRequest>(
        grpc::MethodType.Unary,
        __ServiceName,
        "getCertificateSigningRequest",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_io_CertificateSigningRequest);

    static readonly grpc::Method<global::PKIo.FileBytes, global::PKIo.CertificateData> __Method_addAppleCertificate = new grpc::Method<global::PKIo.FileBytes, global::PKIo.CertificateData>(
        grpc::MethodType.Unary,
        __ServiceName,
        "addAppleCertificate",
        __Marshaller_io_FileBytes,
        __Marshaller_io_CertificateData);

    static readonly grpc::Method<global::PKIo.FileBytes, global::PKIo.CertificateData> __Method_updateAppleCertificate = new grpc::Method<global::PKIo.FileBytes, global::PKIo.CertificateData>(
        grpc::MethodType.Unary,
        __ServiceName,
        "updateAppleCertificate",
        __Marshaller_io_FileBytes,
        __Marshaller_io_CertificateData);

    static readonly grpc::Method<global::PKIo.PassTypeIdentifier, global::PKIo.CertificateData> __Method_getAppleCertificateData = new grpc::Method<global::PKIo.PassTypeIdentifier, global::PKIo.CertificateData>(
        grpc::MethodType.Unary,
        __ServiceName,
        "getAppleCertificateData",
        __Marshaller_io_PassTypeIdentifier,
        __Marshaller_io_CertificateData);

    static readonly grpc::Method<global::PKIo.Pagination, global::PKIo.CertificateData> __Method_listAppleCertificatesDeprecated = new grpc::Method<global::PKIo.Pagination, global::PKIo.CertificateData>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "listAppleCertificatesDeprecated",
        __Marshaller_io_Pagination,
        __Marshaller_io_CertificateData);

    static readonly grpc::Method<global::PKIo.Filters, global::PKIo.CertificateData> __Method_listAppleCertificates = new grpc::Method<global::PKIo.Filters, global::PKIo.CertificateData>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "listAppleCertificates",
        __Marshaller_io_Filters,
        __Marshaller_io_CertificateData);

    static readonly grpc::Method<global::PKIo.Pagination, global::PKIo.Count> __Method_countAppleCertificatesDeprecated = new grpc::Method<global::PKIo.Pagination, global::PKIo.Count>(
        grpc::MethodType.Unary,
        __ServiceName,
        "countAppleCertificatesDeprecated",
        __Marshaller_io_Pagination,
        __Marshaller_io_Count);

    static readonly grpc::Method<global::PKIo.Filters, global::PKIo.Count> __Method_countAppleCertificates = new grpc::Method<global::PKIo.Filters, global::PKIo.Count>(
        grpc::MethodType.Unary,
        __ServiceName,
        "countAppleCertificates",
        __Marshaller_io_Filters,
        __Marshaller_io_Count);

    static readonly grpc::Method<global::PKIo.NFCSigningCredentialsRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_sendNFCSigningCredentials = new grpc::Method<global::PKIo.NFCSigningCredentialsRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "sendNFCSigningCredentials",
        __Marshaller_io_NFCSigningCredentialsRequest,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::PKIo.ARpcCertificatesReflection.Descriptor.Services[0]; }
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

      public virtual global::PKIo.CertificateSigningRequest getCertificateSigningRequest(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return getCertificateSigningRequest(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::PKIo.CertificateSigningRequest getCertificateSigningRequest(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_getCertificateSigningRequest, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::PKIo.CertificateSigningRequest> getCertificateSigningRequestAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return getCertificateSigningRequestAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::PKIo.CertificateSigningRequest> getCertificateSigningRequestAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_getCertificateSigningRequest, null, options, request);
      }
      public virtual global::PKIo.CertificateData addAppleCertificate(global::PKIo.FileBytes request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return addAppleCertificate(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::PKIo.CertificateData addAppleCertificate(global::PKIo.FileBytes request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_addAppleCertificate, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::PKIo.CertificateData> addAppleCertificateAsync(global::PKIo.FileBytes request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return addAppleCertificateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::PKIo.CertificateData> addAppleCertificateAsync(global::PKIo.FileBytes request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_addAppleCertificate, null, options, request);
      }
      public virtual global::PKIo.CertificateData updateAppleCertificate(global::PKIo.FileBytes request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return updateAppleCertificate(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::PKIo.CertificateData updateAppleCertificate(global::PKIo.FileBytes request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_updateAppleCertificate, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::PKIo.CertificateData> updateAppleCertificateAsync(global::PKIo.FileBytes request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return updateAppleCertificateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::PKIo.CertificateData> updateAppleCertificateAsync(global::PKIo.FileBytes request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_updateAppleCertificate, null, options, request);
      }
      public virtual global::PKIo.CertificateData getAppleCertificateData(global::PKIo.PassTypeIdentifier request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return getAppleCertificateData(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::PKIo.CertificateData getAppleCertificateData(global::PKIo.PassTypeIdentifier request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_getAppleCertificateData, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::PKIo.CertificateData> getAppleCertificateDataAsync(global::PKIo.PassTypeIdentifier request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return getAppleCertificateDataAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::PKIo.CertificateData> getAppleCertificateDataAsync(global::PKIo.PassTypeIdentifier request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_getAppleCertificateData, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::PKIo.CertificateData> listAppleCertificatesDeprecated(global::PKIo.Pagination request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return listAppleCertificatesDeprecated(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::PKIo.CertificateData> listAppleCertificatesDeprecated(global::PKIo.Pagination request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_listAppleCertificatesDeprecated, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::PKIo.CertificateData> listAppleCertificates(global::PKIo.Filters request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return listAppleCertificates(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::PKIo.CertificateData> listAppleCertificates(global::PKIo.Filters request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_listAppleCertificates, null, options, request);
      }
      public virtual global::PKIo.Count countAppleCertificatesDeprecated(global::PKIo.Pagination request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return countAppleCertificatesDeprecated(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::PKIo.Count countAppleCertificatesDeprecated(global::PKIo.Pagination request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_countAppleCertificatesDeprecated, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::PKIo.Count> countAppleCertificatesDeprecatedAsync(global::PKIo.Pagination request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return countAppleCertificatesDeprecatedAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::PKIo.Count> countAppleCertificatesDeprecatedAsync(global::PKIo.Pagination request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_countAppleCertificatesDeprecated, null, options, request);
      }
      public virtual global::PKIo.Count countAppleCertificates(global::PKIo.Filters request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return countAppleCertificates(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::PKIo.Count countAppleCertificates(global::PKIo.Filters request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_countAppleCertificates, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::PKIo.Count> countAppleCertificatesAsync(global::PKIo.Filters request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return countAppleCertificatesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::PKIo.Count> countAppleCertificatesAsync(global::PKIo.Filters request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_countAppleCertificates, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty sendNFCSigningCredentials(global::PKIo.NFCSigningCredentialsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return sendNFCSigningCredentials(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty sendNFCSigningCredentials(global::PKIo.NFCSigningCredentialsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_sendNFCSigningCredentials, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> sendNFCSigningCredentialsAsync(global::PKIo.NFCSigningCredentialsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return sendNFCSigningCredentialsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> sendNFCSigningCredentialsAsync(global::PKIo.NFCSigningCredentialsRequest request, grpc::CallOptions options)
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
