// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: io/core/a_rpc_images.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PassKit.Grpc {

  /// <summary>Holder for reflection information generated from io/core/a_rpc_images.proto</summary>
  public static partial class ARpcImagesReflection {

    #region Descriptor
    /// <summary>File descriptor for io/core/a_rpc_images.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ARpcImagesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chppby9jb3JlL2FfcnBjX2ltYWdlcy5wcm90bxICaW8aHGdvb2dsZS9hcGkv",
            "YW5ub3RhdGlvbnMucHJvdG8aG2dvb2dsZS9wcm90b2J1Zi9lbXB0eS5wcm90",
            "bxoucHJvdG9jLWdlbi1vcGVuYXBpdjIvb3B0aW9ucy9hbm5vdGF0aW9ucy5w",
            "cm90bxoeaW8vY29tbW9uL2NvbW1vbl9vYmplY3RzLnByb3RvGhppby9jb21t",
            "b24vcGFnaW5hdGlvbi5wcm90bxoUaW8vaW1hZ2UvaW1hZ2UucHJvdG8aFmlv",
            "L2NvbW1vbi9maWx0ZXIucHJvdG8yxBsKBkltYWdlcxKgAQoPc2V0UHJvZmls",
            "ZUltYWdlEhUuaW8uUHJvZmlsZUltYWdlSW5wdXQaFi5nb29nbGUucHJvdG9i",
            "dWYuRW1wdHkiXpJBQhIRU2V0IHByb2ZpbGUgaW1hZ2UaLVNldCB0aGUgcHJv",
            "ZmlsZSBpbWFnZSBmb3IgdGhlIGxvZ2dlZCBpbiB1c2VyLoLT5JMCEyIOL2lt",
            "YWdlL3Byb2ZpbGU6ASoSlAEKD2dldFByb2ZpbGVJbWFnZRIWLmdvb2dsZS5w",
            "cm90b2J1Zi5FbXB0eRoHLmlvLlVybCJgkkFHEhFHZXQgcHJvZmlsZSBpbWFn",
            "ZRoyR2V0cyB0aGUgcHJvZmlsZSBpbWFnZSBVUkwgZm9yIHRoZSBsb2dnZWQg",
            "aW4gdXNlci6C0+STAhASDi9pbWFnZS9wcm9maWxlEm8KDGNyZWF0ZUltYWdl",
            "cxIULmlvLkNyZWF0ZUltYWdlSW5wdXQaDC5pby5JbWFnZUlkcyI7kkEmEg1D",
            "cmVhdGUgSW1hZ2VzGhVDcmVhdGVzIGltYWdlIHJlY29yZC6C0+STAgwiBy9p",
            "bWFnZXM6ASoScgoLdXBkYXRlSW1hZ2USFC5pby5VcGRhdGVJbWFnZUlucHV0",
            "Gg8uaW8uSW1hZ2VSZWNvcmQiPJJBKBIMVXBkYXRlIEltYWdlGhhVcGRhdGVz",
            "IGFuIGltYWdlIHJlY29yZC6C0+STAgsaBi9pbWFnZToBKhJeCgtnZXRJbWFn",
            "ZVVSTBIGLmlvLklkGgcuaW8uVXJsIj6SQSgSDUdldCBJbWFnZSBVUkwaF1Jl",
            "dHJpZXZlcyBhbiBpbWFnZSB1cmwugtPkkwINEgsvaW1hZ2Uve2lkfRLxAQoQ",
            "Z2V0U3RhbXBJbWFnZVVSTBIVLmlvLlN0YW1wSW1hZ2VSZXF1ZXN0GgcuaW8u",
            "VXJsIrwBkkGWARITR2V0IFN0YW1wIEltYWdlIFVSTBo7UmV0cmlldmVzIGEg",
            "c3RhbXAgaW1hZ2UgdXJsIHdpdGggdGhlIHN1cHBsaWVkIHN0YW1wIHN0YXR1",
            "cy5KIgoDNDAzEhsKGVVzZXIgbGFja3MgYXV0aG9yaXphdGlvbi5KHgoDNDA0",
            "EhcKFVJlY29yZCB3YXMgbm90IGZvdW5kLoLT5JMCHBIaL2ltYWdlL3N0YW1w",
            "L3tpZH0ve3N0YXR1c30ShQEKE2dldFN0YW1wSW1hZ2VDb25maWcSBi5pby5J",
            "ZBoULmlvLlN0YW1wSW1hZ2VDb25maWciUJJBLRIQR2V0IFN0YW1wIENvbmZp",
            "ZxoZUmV0cmlldmVzIGEgc3RhbXAgY29uZmlnLoLT5JMCGhIYL2ltYWdlL3N0",
            "YW1wL2NvbmZpZy97aWR9EpYBChZ1cGRhdGVTdGFtcEltYWdlQ29uZmlnEhQu",
            "aW8uU3RhbXBJbWFnZUNvbmZpZxoGLmlvLklkIl6SQT0SE1VwZGF0ZSBTdGFt",
            "cCBDb25maWcaJlVwZGF0ZXMgYSBwcm92aWRlZCBzdGFtcCBpbWFnZSBjb25m",
            "aWcugtPkkwIYGhMvaW1hZ2Uvc3RhbXAvY29uZmlnOgEqEsABChRnZXRTdGFt",
            "cEltYWdlUHJldmlldxIcLmlvLlN0YW1wSW1hZ2VQcmV2aWV3UmVxdWVzdBoV",
            "LmlvLlN0YW1wSW1hZ2VQcmV2aWV3InOSQVESF0dldCBTdGFtcCBJbWFnZSBQ",
            "cmV2aWV3GjZHZXRzIGEgcHJldmlldyBpbWFnZSBvZiB0aGUgcHJvdmlkZWQg",
            "c3RhbXBJbWFnZUNvbmZpZy6C0+STAhkiFC9pbWFnZS9zdGFtcC9wcmV2aWV3",
            "OgEqEpoBChRnZXRMb2NhbGl6ZWRJbWFnZVVSTBIXLmlvLkxvY2FsaXplZElt",
            "YWdlSW5wdXQaBy5pby5VcmwiYJJBOxIXR2V0IExvY2FsaXplZCBJbWFnZSBV",
            "UkwaIFJldHJpZXZlcyBhIGxvY2FsaXplZCBpbWFnZSBVUkwugtPkkwIcEhov",
            "aW1hZ2Uve2lkfS97bGFuZ3VhZ2VDb2RlfRJDChNnZXRQcm9maWxlSW1hZ2VC",
            "eUlkEgYuaW8uSWQaBy5pby5VcmwiG4LT5JMCFRITL2ltYWdlL3Byb2ZpbGUv",
            "e2lkfRJ2Cg5nZXRJbWFnZUJ1bmRsZRIGLmlvLklkGg8uaW8uSW1hZ2VCdW5k",
            "bGUiS5JBLhIQR2V0IEltYWdlIEJ1bmRsZRoaUmV0cmlldmVzIGFuIGltYWdl",
            "IGJ1bmRsZS6C0+STAhQSEi9pbWFnZS9idW5kbGUve2lkfRJwCgxnZXRJbWFn",
            "ZURhdGESBi5pby5JZBoPLmlvLkltYWdlUmVjb3JkIkeSQSwSDkdldCBJbWFn",
            "ZSBEYXRhGhpSZXRyaWV2ZXMgYW4gaW1hZ2UgcmVjb3JkLoLT5JMCEhIQL2lt",
            "YWdlL2RhdGEve2lkfRJsCgtkZWxldGVJbWFnZRIGLmlvLklkGhYuZ29vZ2xl",
            "LnByb3RvYnVmLkVtcHR5Ij2SQScSDERlbGV0ZSBJbWFnZRoXRGVsZXRlcyBh",
            "biBpbWFnZSByZWNvcmSC0+STAg0qCy9pbWFnZS97aWR9EqEBChRkZWxldGVM",
            "b2NhbGl6ZWRJbWFnZRIXLmlvLkxvY2FsaXplZEltYWdlSW5wdXQaDy5pby5J",
            "bWFnZVJlY29yZCJfkkE6EhZEZWxldGUgTG9jYWxpemVkIEltYWdlGiBEZWxl",
            "dGVzIGEgbG9jYWxpemVkIGltYWdlIHJlY29yZILT5JMCHCoaL2ltYWdlL3tp",
            "ZH0ve2xhbmd1YWdlQ29kZX0SpwEKG2xpc3RJbWFnZXNGb3JVc2VyRGVwcmVj",
            "YXRlZBIOLmlvLlBhZ2luYXRpb24aDy5pby5JbWFnZVJlY29yZCJlkkFOEhdH",
            "ZXQgQWxsIEltYWdlcyBGb3IgVXNlchozUmV0cmlldmVzIGFsbCBpbWFnZXMg",
            "c3RvcmVkIHVuZGVyIHRoZSB1c2VyIGFjY291bnQugtPkkwIOEgwvaW1hZ2Vz",
            "L3VzZXIwARKiAQoRbGlzdEltYWdlc0ZvclVzZXISCy5pby5GaWx0ZXJzGg8u",
            "aW8uSW1hZ2VSZWNvcmQibZJBThIXR2V0IEFsbCBJbWFnZXMgRm9yIFVzZXIa",
            "M1JldHJpZXZlcyBhbGwgaW1hZ2VzIHN0b3JlZCB1bmRlciB0aGUgdXNlciBh",
            "Y2NvdW50LoLT5JMCFiIRL2ltYWdlcy91c2VyL2xpc3Q6ASowARKXAQoUbGlz",
            "dEltYWdlc0RlcHJlY2F0ZWQSDi5pby5QYWdpbmF0aW9uGg8uaW8uSW1hZ2VS",
            "ZWNvcmQiXJJBShIYR2V0IEFsbCBBdmFpbGFibGUgSW1hZ2VzGi5SZXRyaWV2",
            "ZXMgYWxsIGltYWdlcyBzdG9yZWQgdW5kZXIgdGhlIGNvbXBhbnkugtPkkwIJ",
            "EgcvaW1hZ2VzMAESkgEKCmxpc3RJbWFnZXMSCy5pby5GaWx0ZXJzGg8uaW8u",
            "SW1hZ2VSZWNvcmQiZJJBShIYR2V0IEFsbCBBdmFpbGFibGUgSW1hZ2VzGi5S",
            "ZXRyaWV2ZXMgYWxsIGltYWdlcyBzdG9yZWQgdW5kZXIgdGhlIGNvbXBhbnku",
            "gtPkkwIRIgwvaW1hZ2VzL2xpc3Q6ASowARKyAQoVY291bnRJbWFnZXNEZXBy",
            "ZWNhdGVkEg4uaW8uUGFnaW5hdGlvbhoJLmlvLkNvdW50In6SQWYSJkNvdW50",
            "IEFsbCBJbWFnZXMgQXZhaWxhYmxlIHRvIFRoZSBVc2VyGjxSZXRyaWV2ZXMg",
            "YSBjb3VudCBvZiBpbWFnZXMgc3RvcmVkIHVuZGVyIHRoZSB1c2VyJ3MgY29t",
            "cGFueS6C0+STAg8SDS9pbWFnZXMvY291bnQSqQEKC2NvdW50SW1hZ2VzEgsu",
            "aW8uRmlsdGVycxoJLmlvLkNvdW50IoEBkkFmEiZDb3VudCBBbGwgSW1hZ2Vz",
            "IEF2YWlsYWJsZSB0byBUaGUgVXNlcho8UmV0cmlldmVzIGEgY291bnQgb2Yg",
            "aW1hZ2VzIHN0b3JlZCB1bmRlciB0aGUgdXNlcidzIGNvbXBhbnkugtPkkwIS",
            "Ig0vaW1hZ2VzL2NvdW50OgEqEvkBChxjb3VudEltYWdlc0ZvclVzZXJEZXBy",
            "ZWNhdGVkEg4uaW8uUGFnaW5hdGlvbhoJLmlvLkNvdW50Ir0BkkGfARIiQ291",
            "bnQgQWxsIEltYWdlcyBPd25lZCBieSBUaGUgVXNlcho1UmV0cmlldmVzIGFs",
            "bCBpbWFnZXMgc3RvcmVkIHVuZGVyIHRoZSB1c2VyJ3MgYWNjb3VudC5KIgoD",
            "NDAzEhsKGVVzZXIgbGFja3MgYXV0aG9yaXphdGlvbi5KHgoDNDA0EhcKFVJl",
            "Y29yZCB3YXMgbm90IGZvdW5kLoLT5JMCFBISL2ltYWdlcy91c2VyL2NvdW50",
            "EqkBChJjb3VudEltYWdlc0ZvclVzZXISCy5pby5GaWx0ZXJzGgkuaW8uQ291",
            "bnQie5JBWxIiQ291bnQgQWxsIEltYWdlcyBPd25lZCBieSBUaGUgVXNlcho1",
            "UmV0cmlldmVzIGFsbCBpbWFnZXMgc3RvcmVkIHVuZGVyIHRoZSB1c2VyJ3Mg",
            "YWNjb3VudC6C0+STAhciEi9pbWFnZXMvdXNlci9jb3VudDoBKkLkBgoQY29t",
            "LnBhc3NraXQuZ3JwY1okc3Rhc2gucGFzc2tpdC5jb20vaW8vbW9kZWwvc2Rr",
            "L2dvL2lvqgIMUGFzc0tpdC5HcnBjkkGZBhLUAQoSUGFzc0tpdCBJbWFnZXMg",
            "QVBJEkNBUEkgZm9yIG1hbmFnaW5nIGltYWdlIGFzc2V0cyBmb3IgUGFzcyBU",
            "ZW1wbGF0ZXMgJiBXYWxsZXQgUHJvamVjdHMuGjhodHRwczovL3Bhc3NraXQu",
            "Y29tL2xlZ2FsL3Rlcm1zLW9mLXN1YnNjcmlwdGlvbi1zZXJ2aWNlLyI/Cg9Q",
            "YXNzS2l0IFN1cHBvcnQSF2h0dHBzOi8vZG9jcy5wYXNza2l0LmlvGhNzdXBw",
            "b3J0QHBhc3NraXQuY29tKgECMhBhcHBsaWNhdGlvbi9qc29uOhBhcHBsaWNh",
            "dGlvbi9qc29uUjkKAzIwMBIyCihSZXR1cm5lZCB3aGVuIHRoZSByZXF1ZXN0",
            "IGlzIHN1Y2Nlc3NmdWwuEgYKBJoCAQdSNAoDNDAwEi0KK1JldHVybmVkIHdo",
            "ZW4gd3JvbmcgdXNlciBpbnB1dCBpcyBwcm92aWRlZC5SMAoDNDAxEikKJ1Jl",
            "dHVybmVkIHdoZW4gdGhlIHVzZXIgaXMgdW5hdXRob3JpemVkLlJQCgM0MDMS",
            "SQpHUmV0dXJuZWQgd2hlbiB0aGUgdXNlciBkb2VzIG5vdCBoYXZlIHBlcm1p",
            "c3Npb24gdG8gYWNjZXNzIHRoZSByZXNvdXJjZS5SOwoDNDA0EjQKKlJldHVy",
            "bmVkIHdoZW4gdGhlIHJlc291cmNlIGRvZXMgbm90IGV4aXN0LhIGCgSaAgEH",
            "UjwKAzUwMBI1CitSZXR1cm5lZCB3aGVuIHRoZXJlIGlzIGFuIHVuZXhwZWN0",
            "ZWQgZXJyb3IuEgYKBJoCAQdSVwoDNTAzElAKTlNlcnZlciBpcyB1bmF2YWls",
            "YWJsZS4gQmFjayBvZmYgZm9yIDI1MG1zIGFuZCByZXBlYXQgcmVxdWVzdCB1",
            "bnRpbCBzdWNjZXNzZnVsLlo+CjwKCmFwaUtleUF1dGgSLggCEhlKV1QgQXV0",
            "aGVudGljYXRpb24gdG9rZW4uGg1BdXRob3JpemF0aW9uIAJiEAoOCgphcGlL",
            "ZXlBdXRoEgBiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::PassKit.Grpc.Gateway.ProtocGenOpenapiv2.Options.AnnotationsReflection.Descriptor, global::PassKit.Grpc.CommonObjectsReflection.Descriptor, global::PassKit.Grpc.PaginationReflection.Descriptor, global::PassKit.Grpc.ImageReflection.Descriptor, global::PassKit.Grpc.FilterReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, null));
    }
    #endregion

  }
}

#endregion Designer generated code
