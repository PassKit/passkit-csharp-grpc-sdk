// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: io/scheduler/a_rpc.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PassKit.Grpc.Scheduler {

  /// <summary>Holder for reflection information generated from io/scheduler/a_rpc.proto</summary>
  public static partial class ARpcReflection {

    #region Descriptor
    /// <summary>File descriptor for io/scheduler/a_rpc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ARpcReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chhpby9zY2hlZHVsZXIvYV9ycGMucHJvdG8SCXNjaGVkdWxlchocZ29vZ2xl",
            "L2FwaS9hbm5vdGF0aW9ucy5wcm90bxobZ29vZ2xlL3Byb3RvYnVmL2VtcHR5",
            "LnByb3RvGi5wcm90b2MtZ2VuLW9wZW5hcGl2Mi9vcHRpb25zL2Fubm90YXRp",
            "b25zLnByb3RvGh5pby9jb21tb24vY29tbW9uX29iamVjdHMucHJvdG8aHGlv",
            "L3NjaGVkdWxlci9zY2hlZHVsZXIucHJvdG8aHGN0L3NjaGVkdWxlci9zY2hl",
            "ZHVsZXIucHJvdG8yrBEKCVNjaGVkdWxlchKPAgoTY3JlYXRlU2NoZWR1bGlu",
            "Z0pvYhIRLmN0LlNjaGVkdWxpbmdKb2IaGS5jdC5TY2hlZHVsaW5nSm9iUmVz",
            "cG9uc2UiyQGSQasBCg9TY2hlZHVsaW5nIEpvYnMSFUNyZWF0ZSBTY2hlZHVs",
            "aW5nIEpvYhoZQ3JlYXRlcyBhIHNjaGVkdWxpbmcgam9iLkowCgM0MDASKQon",
            "VGhlcmUgaXMgYSBwcm9ibGVtIHdpdGggdGhlIGlucHV0IGRhdGEuSjQKAzQw",
            "MxItCitSZXR1cm5lZCB3aGVuIHRoZSB1c2VyIGxhY2tzIGF1dGhvcml6YXRp",
            "b24ugtPkkwIUIg8vc2NoZWR1bGluZy9qb2I6ASoSiAIKEGdldFNjaGVkdWxp",
            "bmdKb2ISBi5pby5JZBoRLmN0LlNjaGVkdWxpbmdKb2Ii2AGSQbgBCg9TY2hl",
            "ZHVsaW5nIEpvYnMSEkdldCBTY2hlZHVsaW5nIEpvYhpNUmV0cmlldmVzIGEg",
            "c2NoZWR1bGluZyBqb2IuIERlbGV0ZWQgam9iIHdpbGwgcmV0dXJuIGhpc3Rv",
            "cnkgbG9ncyBvbmx5IGlmIGFueS5KIgoDNDAzEhsKGVVzZXIgbGFja3MgYXV0",
            "aG9yaXphdGlvbi5KHgoDNDA0EhcKFVJlY29yZCB3YXMgbm90IGZvdW5kLoLT",
            "5JMCFhIUL3NjaGVkdWxpbmcvam9iL3tpZH0S1QMKE3VwZGF0ZVNjaGVkdWxp",
            "bmdKb2ISES5jdC5TY2hlZHVsaW5nSm9iGhkuY3QuU2NoZWR1bGluZ0pvYlJl",
            "c3BvbnNlIo8DkkHxAgoPU2NoZWR1bGluZyBKb2JzEhVVcGRhdGUgU2NoZWR1",
            "bGluZyBKb2IaeFVwZGF0ZXMgYSBzY2hlZHVsaW5nIGpvYi4gRnVsbCBTY2hl",
            "ZHVsZXJKb2Igb2JqZWN0IGlzIHJlcXVpcmVkLiBBbiBlbXB0eSBvciBudWxs",
            "IHZhbHVlIHdpbGwgb3ZlcnJpZGUgYW55IGV4aXN0aW5nIHZhbHVlLkowCgM0",
            "MDASKQonVGhlcmUgaXMgYSBwcm9ibGVtIHdpdGggdGhlIGlucHV0IGRhdGEu",
            "SiIKAzQwMxIbChlVc2VyIGxhY2tzIGF1dGhvcml6YXRpb24uSh4KAzQwNBIX",
            "ChVSZWNvcmQgd2FzIG5vdCBmb3VuZC5KVwoDNTAzElAKTlNlcnZlciBpcyB1",
            "bmF2YWlsYWJsZS4gQmFjayBvZmYgZm9yIDI1MG1zIGFuZCByZXBlYXQgcmVx",
            "dWVzdCB1bnRpbCBzdWNjZXNzZnVsLoLT5JMCFBoPL3NjaGVkdWxpbmcvam9i",
            "OgEqEvoCChJwYXRjaFNjaGVkdWxpbmdKb2ISES5jdC5TY2hlZHVsaW5nSm9i",
            "GhkuY3QuU2NoZWR1bGluZ0pvYlJlc3BvbnNlIrUCkkGXAgoPU2NoZWR1bGlu",
            "ZyBKb2JzEhRQYXRjaCBTY2hlZHVsaW5nIEpvYhofUGF0Y2ggdXBkYXRlcyBh",
            "IHNjaGVkdWxpbmcgam9iLkowCgM0MDASKQonVGhlcmUgaXMgYSBwcm9ibGVt",
            "IHdpdGggdGhlIGlucHV0IGRhdGEuSiIKAzQwMxIbChlVc2VyIGxhY2tzIGF1",
            "dGhvcml6YXRpb24uSh4KAzQwNBIXChVSZWNvcmQgd2FzIG5vdCBmb3VuZC5K",
            "VwoDNTAzElAKTlNlcnZlciBpcyB1bmF2YWlsYWJsZS4gQmFjayBvZmYgZm9y",
            "IDI1MG1zIGFuZCByZXBlYXQgcmVxdWVzdCB1bnRpbCBzdWNjZXNzZnVsLoLT",
            "5JMCFDIPL3NjaGVkdWxpbmcvam9iOgEqEqoCChNkZWxldGVTY2hlZHVsaW5n",
            "Sm9iEgYuaW8uSWQaFi5nb29nbGUucHJvdG9idWYuRW1wdHki8gGSQdIBCg9T",
            "Y2hlZHVsaW5nIEpvYnMSFURlbGV0ZSBTY2hlZHVsaW5nIEpvYhpSRGVsZXRl",
            "cyBhIHNjaGVkdWxpbmcgam9iLiBIaXN0b3J5IGxvZ3MgYXJlIHN0aWxsIGF2",
            "YWlsYWJsZSBhZnRlciBkZWxldGluZyB0aGUgam9iLko0CgM0MDMSLQorUmV0",
            "dXJuZWQgd2hlbiB0aGUgdXNlciBsYWNrcyBhdXRob3JpemF0aW9uLkoeCgM0",
            "MDQSFwoVUmVjb3JkIHdhcyBub3QgZm91bmQugtPkkwIWKhQvc2NoZWR1bGlu",
            "Zy9qb2Ive2lkfRL6AQoXZ2V0U2NoZWR1bGluZ0pvYkhpc3RvcnkSBi5pby5J",
            "ZBoOLmN0LkpvYkhpc3RvcnkixgGSQaIBCg1Kb2IgSGlzdG9yaWVzEhpHZXQg",
            "U2NoZWR1bGluZyBKb2IgSGlzdG9yeRoxUmV0cmlldmVzIGEgc2NoZWR1bGlu",
            "ZyBqb2IgaGlzdG9yeSBieSB0aGUgbG9nIGlkLkoiCgM0MDMSGwoZVXNlciBs",
            "YWNrcyBhdXRob3JpemF0aW9uLkoeCgM0MDQSFwoVUmVjb3JkIHdhcyBub3Qg",
            "Zm91bmQugtPkkwIaEhgvc2NoZWR1bGluZy9oaXN0b3J5L3tpZH0SggIKGmxp",
            "c3RTY2hlZHVsaW5nSm9iSGlzdG9yaWVzEhYuc2NoZWR1bGVyLkxpc3RSZXF1",
            "ZXN0Gg4uY3QuSm9iSGlzdG9yeSK5AZJBkgEKDUpvYiBIaXN0b3JpZXMSHUxp",
            "c3QgU2NoZWR1bGluZyBKb2IgSGlzdG9yaWVzGh5MaXN0IHNjaGVkdWxpbmcg",
            "am9iIGhpc3Rvcmllcy5KIgoDNDAzEhsKGVVzZXIgbGFja3MgYXV0aG9yaXph",
            "dGlvbi5KHgoDNDA0EhcKFVJlY29yZCB3YXMgbm90IGZvdW5kLoLT5JMCHSIY",
            "L3NjaGVkdWxpbmcvaGlzdG9yeS9saXN0OgEqMAFC3QIKGmNvbS5wYXNza2l0",
            "LmdycGMuU2NoZWR1bGVyWi5zdGFzaC5wYXNza2l0LmNvbS9pby9tb2RlbC9z",
            "ZGsvZ28vaW8vc2NoZWR1bGVyqgIWUGFzc0tpdC5HcnBjLlNjaGVkdWxlcpJB",
            "9AESygEKFVBhc3NLaXQgU2NoZWR1bGVyIEFQSRIxVGhpcyBwcm90b2NvbCBz",
            "Y2hlZHVsZSByZWN1cnNpdmUgb3Igb25lLW9mZiBqb2JzLho4aHR0cHM6Ly9w",
            "YXNza2l0LmNvbS9sZWdhbC90ZXJtcy1vZi1zdWJzY3JpcHRpb24tc2Vydmlj",
            "ZS8iPwoPUGFzc0tpdCBTdXBwb3J0EhdodHRwczovL2RvY3MucGFzc2tpdC5p",
            "bxoTc3VwcG9ydEBwYXNza2l0LmNvbTIDMS4wKgECMhBhcHBsaWNhdGlvbi9q",
            "c29uOhBhcHBsaWNhdGlvbi9qc29uYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::PassKit.Grpc.Gateway.ProtocGenOpenapiv2.Options.AnnotationsReflection.Descriptor, global::PassKit.Grpc.CommonObjectsReflection.Descriptor, global::PassKit.Grpc.Scheduler.SchedulerReflection.Descriptor, global::PassKit.Grpc.Ct.SchedulerReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, null));
    }
    #endregion

  }
}

#endregion Designer generated code
