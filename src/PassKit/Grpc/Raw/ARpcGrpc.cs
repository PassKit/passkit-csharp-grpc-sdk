// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: io/raw/a_rpc.proto
// </auto-generated>
// Original file comments:
// *
// This protocol is suit for cases where the business logic is handled elsewhere, and the purpose is purely to issue and
// update content for Apple Wallet and Google Pay.
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace PassKit.Grpc.Raw {
  public static partial class Raw
  {
    static readonly string __ServiceName = "raw.Raw";

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

    static readonly grpc::Marshaller<global::PassKit.Grpc.Raw.PassProject> __Marshaller_raw_PassProject = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PassKit.Grpc.Raw.PassProject.Parser));
    static readonly grpc::Marshaller<global::PassKit.Grpc.Id> __Marshaller_io_Id = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PassKit.Grpc.Id.Parser));
    static readonly grpc::Marshaller<global::PassKit.Grpc.Raw.PassProjectCopyRequest> __Marshaller_raw_PassProjectCopyRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PassKit.Grpc.Raw.PassProjectCopyRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    static readonly grpc::Marshaller<global::PassKit.Grpc.Raw.Pass> __Marshaller_raw_Pass = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PassKit.Grpc.Raw.Pass.Parser));
    static readonly grpc::Marshaller<global::PassKit.Grpc.Raw.PassRecordByExternalIdRequest> __Marshaller_raw_PassRecordByExternalIdRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PassKit.Grpc.Raw.PassRecordByExternalIdRequest.Parser));
    static readonly grpc::Marshaller<global::PassKit.Grpc.Raw.ListPassesByPassProjectRequest> __Marshaller_raw_ListPassesByPassProjectRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PassKit.Grpc.Raw.ListPassesByPassProjectRequest.Parser));
    static readonly grpc::Marshaller<global::PassKit.Grpc.Raw.ListPassesByPassTemplateRequest> __Marshaller_raw_ListPassesByPassTemplateRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PassKit.Grpc.Raw.ListPassesByPassTemplateRequest.Parser));

    static readonly grpc::Method<global::PassKit.Grpc.Raw.PassProject, global::PassKit.Grpc.Id> __Method_createPassProject = new grpc::Method<global::PassKit.Grpc.Raw.PassProject, global::PassKit.Grpc.Id>(
        grpc::MethodType.Unary,
        __ServiceName,
        "createPassProject",
        __Marshaller_raw_PassProject,
        __Marshaller_io_Id);

    static readonly grpc::Method<global::PassKit.Grpc.Raw.PassProject, global::PassKit.Grpc.Raw.PassProject> __Method_updatePassProject = new grpc::Method<global::PassKit.Grpc.Raw.PassProject, global::PassKit.Grpc.Raw.PassProject>(
        grpc::MethodType.Unary,
        __ServiceName,
        "updatePassProject",
        __Marshaller_raw_PassProject,
        __Marshaller_raw_PassProject);

    static readonly grpc::Method<global::PassKit.Grpc.Id, global::PassKit.Grpc.Raw.PassProject> __Method_getPassProject = new grpc::Method<global::PassKit.Grpc.Id, global::PassKit.Grpc.Raw.PassProject>(
        grpc::MethodType.Unary,
        __ServiceName,
        "getPassProject",
        __Marshaller_io_Id,
        __Marshaller_raw_PassProject);

    static readonly grpc::Method<global::PassKit.Grpc.Raw.PassProjectCopyRequest, global::PassKit.Grpc.Id> __Method_copyPassProject = new grpc::Method<global::PassKit.Grpc.Raw.PassProjectCopyRequest, global::PassKit.Grpc.Id>(
        grpc::MethodType.Unary,
        __ServiceName,
        "copyPassProject",
        __Marshaller_raw_PassProjectCopyRequest,
        __Marshaller_io_Id);

    static readonly grpc::Method<global::PassKit.Grpc.Id, global::Google.Protobuf.WellKnownTypes.Empty> __Method_deletePassProject = new grpc::Method<global::PassKit.Grpc.Id, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "deletePassProject",
        __Marshaller_io_Id,
        __Marshaller_google_protobuf_Empty);

    static readonly grpc::Method<global::PassKit.Grpc.Raw.Pass, global::PassKit.Grpc.Id> __Method_createPass = new grpc::Method<global::PassKit.Grpc.Raw.Pass, global::PassKit.Grpc.Id>(
        grpc::MethodType.Unary,
        __ServiceName,
        "createPass",
        __Marshaller_raw_Pass,
        __Marshaller_io_Id);

    static readonly grpc::Method<global::PassKit.Grpc.Raw.Pass, global::PassKit.Grpc.Id> __Method_updatePass = new grpc::Method<global::PassKit.Grpc.Raw.Pass, global::PassKit.Grpc.Id>(
        grpc::MethodType.Unary,
        __ServiceName,
        "updatePass",
        __Marshaller_raw_Pass,
        __Marshaller_io_Id);

    static readonly grpc::Method<global::PassKit.Grpc.Raw.Pass, global::PassKit.Grpc.Id> __Method_streamPassUpdates = new grpc::Method<global::PassKit.Grpc.Raw.Pass, global::PassKit.Grpc.Id>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "streamPassUpdates",
        __Marshaller_raw_Pass,
        __Marshaller_io_Id);

    static readonly grpc::Method<global::PassKit.Grpc.Id, global::PassKit.Grpc.Raw.Pass> __Method_getPassById = new grpc::Method<global::PassKit.Grpc.Id, global::PassKit.Grpc.Raw.Pass>(
        grpc::MethodType.Unary,
        __ServiceName,
        "getPassById",
        __Marshaller_io_Id,
        __Marshaller_raw_Pass);

    static readonly grpc::Method<global::PassKit.Grpc.Raw.PassRecordByExternalIdRequest, global::PassKit.Grpc.Raw.Pass> __Method_getPassByExternalId = new grpc::Method<global::PassKit.Grpc.Raw.PassRecordByExternalIdRequest, global::PassKit.Grpc.Raw.Pass>(
        grpc::MethodType.Unary,
        __ServiceName,
        "getPassByExternalId",
        __Marshaller_raw_PassRecordByExternalIdRequest,
        __Marshaller_raw_Pass);

    static readonly grpc::Method<global::PassKit.Grpc.Raw.Pass, global::Google.Protobuf.WellKnownTypes.Empty> __Method_deletePass = new grpc::Method<global::PassKit.Grpc.Raw.Pass, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "deletePass",
        __Marshaller_raw_Pass,
        __Marshaller_google_protobuf_Empty);

    static readonly grpc::Method<global::PassKit.Grpc.Raw.ListPassesByPassProjectRequest, global::PassKit.Grpc.Raw.Pass> __Method_listPassesByPassProject = new grpc::Method<global::PassKit.Grpc.Raw.ListPassesByPassProjectRequest, global::PassKit.Grpc.Raw.Pass>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "listPassesByPassProject",
        __Marshaller_raw_ListPassesByPassProjectRequest,
        __Marshaller_raw_Pass);

    static readonly grpc::Method<global::PassKit.Grpc.Raw.ListPassesByPassTemplateRequest, global::PassKit.Grpc.Raw.Pass> __Method_listPassesByPassTemplate = new grpc::Method<global::PassKit.Grpc.Raw.ListPassesByPassTemplateRequest, global::PassKit.Grpc.Raw.Pass>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "listPassesByPassTemplate",
        __Marshaller_raw_ListPassesByPassTemplateRequest,
        __Marshaller_raw_Pass);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::PassKit.Grpc.Raw.ARpcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for Raw</summary>
    public partial class RawClient : grpc::ClientBase<RawClient>
    {
      /// <summary>Creates a new client for Raw</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public RawClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Raw that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public RawClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected RawClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected RawClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::PassKit.Grpc.Id createPassProject(global::PassKit.Grpc.Raw.PassProject request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return createPassProject(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::PassKit.Grpc.Id createPassProject(global::PassKit.Grpc.Raw.PassProject request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_createPassProject, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::PassKit.Grpc.Id> createPassProjectAsync(global::PassKit.Grpc.Raw.PassProject request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return createPassProjectAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::PassKit.Grpc.Id> createPassProjectAsync(global::PassKit.Grpc.Raw.PassProject request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_createPassProject, null, options, request);
      }
      public virtual global::PassKit.Grpc.Raw.PassProject updatePassProject(global::PassKit.Grpc.Raw.PassProject request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return updatePassProject(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::PassKit.Grpc.Raw.PassProject updatePassProject(global::PassKit.Grpc.Raw.PassProject request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_updatePassProject, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::PassKit.Grpc.Raw.PassProject> updatePassProjectAsync(global::PassKit.Grpc.Raw.PassProject request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return updatePassProjectAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::PassKit.Grpc.Raw.PassProject> updatePassProjectAsync(global::PassKit.Grpc.Raw.PassProject request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_updatePassProject, null, options, request);
      }
      public virtual global::PassKit.Grpc.Raw.PassProject getPassProject(global::PassKit.Grpc.Id request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return getPassProject(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::PassKit.Grpc.Raw.PassProject getPassProject(global::PassKit.Grpc.Id request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_getPassProject, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::PassKit.Grpc.Raw.PassProject> getPassProjectAsync(global::PassKit.Grpc.Id request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return getPassProjectAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::PassKit.Grpc.Raw.PassProject> getPassProjectAsync(global::PassKit.Grpc.Id request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_getPassProject, null, options, request);
      }
      public virtual global::PassKit.Grpc.Id copyPassProject(global::PassKit.Grpc.Raw.PassProjectCopyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return copyPassProject(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::PassKit.Grpc.Id copyPassProject(global::PassKit.Grpc.Raw.PassProjectCopyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_copyPassProject, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::PassKit.Grpc.Id> copyPassProjectAsync(global::PassKit.Grpc.Raw.PassProjectCopyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return copyPassProjectAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::PassKit.Grpc.Id> copyPassProjectAsync(global::PassKit.Grpc.Raw.PassProjectCopyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_copyPassProject, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty deletePassProject(global::PassKit.Grpc.Id request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return deletePassProject(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty deletePassProject(global::PassKit.Grpc.Id request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_deletePassProject, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> deletePassProjectAsync(global::PassKit.Grpc.Id request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return deletePassProjectAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> deletePassProjectAsync(global::PassKit.Grpc.Id request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_deletePassProject, null, options, request);
      }
      public virtual global::PassKit.Grpc.Id createPass(global::PassKit.Grpc.Raw.Pass request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return createPass(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::PassKit.Grpc.Id createPass(global::PassKit.Grpc.Raw.Pass request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_createPass, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::PassKit.Grpc.Id> createPassAsync(global::PassKit.Grpc.Raw.Pass request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return createPassAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::PassKit.Grpc.Id> createPassAsync(global::PassKit.Grpc.Raw.Pass request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_createPass, null, options, request);
      }
      public virtual global::PassKit.Grpc.Id updatePass(global::PassKit.Grpc.Raw.Pass request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return updatePass(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::PassKit.Grpc.Id updatePass(global::PassKit.Grpc.Raw.Pass request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_updatePass, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::PassKit.Grpc.Id> updatePassAsync(global::PassKit.Grpc.Raw.Pass request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return updatePassAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::PassKit.Grpc.Id> updatePassAsync(global::PassKit.Grpc.Raw.Pass request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_updatePass, null, options, request);
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::PassKit.Grpc.Raw.Pass, global::PassKit.Grpc.Id> streamPassUpdates(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return streamPassUpdates(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::PassKit.Grpc.Raw.Pass, global::PassKit.Grpc.Id> streamPassUpdates(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_streamPassUpdates, null, options);
      }
      public virtual global::PassKit.Grpc.Raw.Pass getPassById(global::PassKit.Grpc.Id request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return getPassById(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::PassKit.Grpc.Raw.Pass getPassById(global::PassKit.Grpc.Id request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_getPassById, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::PassKit.Grpc.Raw.Pass> getPassByIdAsync(global::PassKit.Grpc.Id request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return getPassByIdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::PassKit.Grpc.Raw.Pass> getPassByIdAsync(global::PassKit.Grpc.Id request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_getPassById, null, options, request);
      }
      public virtual global::PassKit.Grpc.Raw.Pass getPassByExternalId(global::PassKit.Grpc.Raw.PassRecordByExternalIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return getPassByExternalId(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::PassKit.Grpc.Raw.Pass getPassByExternalId(global::PassKit.Grpc.Raw.PassRecordByExternalIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_getPassByExternalId, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::PassKit.Grpc.Raw.Pass> getPassByExternalIdAsync(global::PassKit.Grpc.Raw.PassRecordByExternalIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return getPassByExternalIdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::PassKit.Grpc.Raw.Pass> getPassByExternalIdAsync(global::PassKit.Grpc.Raw.PassRecordByExternalIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_getPassByExternalId, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty deletePass(global::PassKit.Grpc.Raw.Pass request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return deletePass(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty deletePass(global::PassKit.Grpc.Raw.Pass request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_deletePass, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> deletePassAsync(global::PassKit.Grpc.Raw.Pass request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return deletePassAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> deletePassAsync(global::PassKit.Grpc.Raw.Pass request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_deletePass, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::PassKit.Grpc.Raw.Pass> listPassesByPassProject(global::PassKit.Grpc.Raw.ListPassesByPassProjectRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return listPassesByPassProject(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::PassKit.Grpc.Raw.Pass> listPassesByPassProject(global::PassKit.Grpc.Raw.ListPassesByPassProjectRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_listPassesByPassProject, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::PassKit.Grpc.Raw.Pass> listPassesByPassTemplate(global::PassKit.Grpc.Raw.ListPassesByPassTemplateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return listPassesByPassTemplate(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::PassKit.Grpc.Raw.Pass> listPassesByPassTemplate(global::PassKit.Grpc.Raw.ListPassesByPassTemplateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_listPassesByPassTemplate, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override RawClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new RawClient(configuration);
      }
    }

  }
}
#endregion