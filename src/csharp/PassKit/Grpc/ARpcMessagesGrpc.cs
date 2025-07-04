// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: io/core/a_rpc_messages.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace PassKit.Grpc {
  public static partial class Messages
  {
    static readonly string __ServiceName = "io.Messages";

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
    static readonly grpc::Marshaller<global::PassKit.Grpc.Id> __Marshaller_io_Id = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PassKit.Grpc.Id.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PassKit.Grpc.Message> __Marshaller_io_Message = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PassKit.Grpc.Message.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PassKit.Grpc.SendMessageRequest> __Marshaller_io_SendMessageRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PassKit.Grpc.SendMessageRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PassKit.Grpc.SendMessageResponse> __Marshaller_io_SendMessageResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PassKit.Grpc.SendMessageResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PassKit.Grpc.Id, global::PassKit.Grpc.Message> __Method_getMessage = new grpc::Method<global::PassKit.Grpc.Id, global::PassKit.Grpc.Message>(
        grpc::MethodType.Unary,
        __ServiceName,
        "getMessage",
        __Marshaller_io_Id,
        __Marshaller_io_Message);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PassKit.Grpc.Message, global::PassKit.Grpc.Id> __Method_createMessage = new grpc::Method<global::PassKit.Grpc.Message, global::PassKit.Grpc.Id>(
        grpc::MethodType.Unary,
        __ServiceName,
        "createMessage",
        __Marshaller_io_Message,
        __Marshaller_io_Id);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PassKit.Grpc.Message, global::Google.Protobuf.WellKnownTypes.Empty> __Method_updateMessage = new grpc::Method<global::PassKit.Grpc.Message, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "updateMessage",
        __Marshaller_io_Message,
        __Marshaller_google_protobuf_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PassKit.Grpc.Id, global::Google.Protobuf.WellKnownTypes.Empty> __Method_deleteMessage = new grpc::Method<global::PassKit.Grpc.Id, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "deleteMessage",
        __Marshaller_io_Id,
        __Marshaller_google_protobuf_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PassKit.Grpc.SendMessageRequest, global::PassKit.Grpc.SendMessageResponse> __Method_sendMessage = new grpc::Method<global::PassKit.Grpc.SendMessageRequest, global::PassKit.Grpc.SendMessageResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "sendMessage",
        __Marshaller_io_SendMessageRequest,
        __Marshaller_io_SendMessageResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::PassKit.Grpc.ARpcMessagesReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for Messages</summary>
    public partial class MessagesClient : grpc::ClientBase<MessagesClient>
    {
      /// <summary>Creates a new client for Messages</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public MessagesClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Messages that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public MessagesClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected MessagesClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected MessagesClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Retrieves a single message by its ID. Required Fields: id.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PassKit.Grpc.Message getMessage(global::PassKit.Grpc.Id request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return getMessage(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves a single message by its ID. Required Fields: id.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PassKit.Grpc.Message getMessage(global::PassKit.Grpc.Id request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_getMessage, null, options, request);
      }
      /// <summary>
      /// Retrieves a single message by its ID. Required Fields: id.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PassKit.Grpc.Message> getMessageAsync(global::PassKit.Grpc.Id request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return getMessageAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves a single message by its ID. Required Fields: id.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PassKit.Grpc.Message> getMessageAsync(global::PassKit.Grpc.Id request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_getMessage, null, options, request);
      }
      /// <summary>
      /// Creates a new message that can be linked to a pass or class. Required Fields: id.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PassKit.Grpc.Id createMessage(global::PassKit.Grpc.Message request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return createMessage(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a new message that can be linked to a pass or class. Required Fields: id.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PassKit.Grpc.Id createMessage(global::PassKit.Grpc.Message request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_createMessage, null, options, request);
      }
      /// <summary>
      /// Creates a new message that can be linked to a pass or class. Required Fields: id.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PassKit.Grpc.Id> createMessageAsync(global::PassKit.Grpc.Message request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return createMessageAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a new message that can be linked to a pass or class. Required Fields: id.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PassKit.Grpc.Id> createMessageAsync(global::PassKit.Grpc.Message request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_createMessage, null, options, request);
      }
      /// <summary>
      /// Updates an existing message by ID. Required Fields: id.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty updateMessage(global::PassKit.Grpc.Message request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return updateMessage(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates an existing message by ID. Required Fields: id.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty updateMessage(global::PassKit.Grpc.Message request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_updateMessage, null, options, request);
      }
      /// <summary>
      /// Updates an existing message by ID. Required Fields: id.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> updateMessageAsync(global::PassKit.Grpc.Message request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return updateMessageAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates an existing message by ID. Required Fields: id.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> updateMessageAsync(global::PassKit.Grpc.Message request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_updateMessage, null, options, request);
      }
      /// <summary>
      /// Deletes a message by its ID. Required Fields: id. Note: Deleting a message removes it from all linked passes.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty deleteMessage(global::PassKit.Grpc.Id request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return deleteMessage(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes a message by its ID. Required Fields: id. Note: Deleting a message removes it from all linked passes.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty deleteMessage(global::PassKit.Grpc.Id request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_deleteMessage, null, options, request);
      }
      /// <summary>
      /// Deletes a message by its ID. Required Fields: id. Note: Deleting a message removes it from all linked passes.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> deleteMessageAsync(global::PassKit.Grpc.Id request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return deleteMessageAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes a message by its ID. Required Fields: id. Note: Deleting a message removes it from all linked passes.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> deleteMessageAsync(global::PassKit.Grpc.Id request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_deleteMessage, null, options, request);
      }
      /// <summary>
      /// Sends a message to specified pass IDs or to all passes in a class. Required: passId, protocol.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PassKit.Grpc.SendMessageResponse sendMessage(global::PassKit.Grpc.SendMessageRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return sendMessage(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a message to specified pass IDs or to all passes in a class. Required: passId, protocol.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PassKit.Grpc.SendMessageResponse sendMessage(global::PassKit.Grpc.SendMessageRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_sendMessage, null, options, request);
      }
      /// <summary>
      /// Sends a message to specified pass IDs or to all passes in a class. Required: passId, protocol.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PassKit.Grpc.SendMessageResponse> sendMessageAsync(global::PassKit.Grpc.SendMessageRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return sendMessageAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a message to specified pass IDs or to all passes in a class. Required: passId, protocol.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PassKit.Grpc.SendMessageResponse> sendMessageAsync(global::PassKit.Grpc.SendMessageRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_sendMessage, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override MessagesClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new MessagesClient(configuration);
      }
    }

  }
}
#endregion
