// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: io/single_use_coupons/a_rpc.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PassKitGrpcSDK.SingleUseCoupons {

  /// <summary>Holder for reflection information generated from io/single_use_coupons/a_rpc.proto</summary>
  public static partial class ARpcReflection {

    #region Descriptor
    /// <summary>File descriptor for io/single_use_coupons/a_rpc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ARpcReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFpby9zaW5nbGVfdXNlX2NvdXBvbnMvYV9ycGMucHJvdG8SEnNpbmdsZV91",
            "c2VfY291cG9ucxobZ29vZ2xlL3Byb3RvYnVmL2VtcHR5LnByb3RvGhxnb29n",
            "bGUvYXBpL2Fubm90YXRpb25zLnByb3RvGh5pby9jb21tb24vY29tbW9uX29i",
            "amVjdHMucHJvdG8aGmlvL2NvbW1vbi9wYWdpbmF0aW9uLnByb3RvGhZpby9j",
            "b21tb24vZmlsdGVyLnByb3RvGhlpby9jb21tb24vcmVwb3J0aW5nLnByb3Rv",
            "Ghhpby9jb21tb24vcGVyc29uYWwucHJvdG8aJGlvL3NpbmdsZV91c2VfY291",
            "cG9ucy9jYW1wYWlnbi5wcm90bxohaW8vc2luZ2xlX3VzZV9jb3Vwb25zL29m",
            "ZmVyLnByb3RvGiJpby9zaW5nbGVfdXNlX2NvdXBvbnMvY291cG9uLnByb3Rv",
            "Gi5wcm90b2MtZ2VuLW9wZW5hcGl2Mi9vcHRpb25zL2Fubm90YXRpb25zLnBy",
            "b3RvMutAChBTaW5nbGVVc2VDb3Vwb25zEsABChRjcmVhdGVDb3Vwb25DYW1w",
            "YWlnbhIiLnNpbmdsZV91c2VfY291cG9ucy5Db3Vwb25DYW1wYWlnbhoGLmlv",
            "LklkInyC0+STAh8iGi9jb3Vwb24vc2luZ2xlVXNlL2NhbXBhaWduOgEqkkFU",
            "ChBDb3Vwb24gQ2FtcGFpZ25zEhZDcmVhdGUgQ291cG9uIENhbXBhaWduGihD",
            "cmVhdGVzIGEgbmV3IFNpbmdsZSBVc2UgQ291cG9uIENhbXBhaWduEtQBChR1",
            "cGRhdGVDb3Vwb25DYW1wYWlnbhIiLnNpbmdsZV91c2VfY291cG9ucy5Db3Vw",
            "b25DYW1wYWlnbhoiLnNpbmdsZV91c2VfY291cG9ucy5Db3Vwb25DYW1wYWln",
            "biJ0gtPkkwIfGhovY291cG9uL3NpbmdsZVVzZS9jYW1wYWlnbjoBKpJBTAoQ",
            "Q291cG9uIENhbXBhaWducxIWVXBkYXRlIENvdXBvbiBDYW1wYWlnbhogVXBk",
            "YXRlcyBhbiBleGlzdGluZyBQYXNzIFByb2plY3QStAEKEWdldENvdXBvbkNh",
            "bXBhaWduEgYuaW8uSWQaIi5zaW5nbGVfdXNlX2NvdXBvbnMuQ291cG9uQ2Ft",
            "cGFpZ24ic4LT5JMCIRIfL2NvdXBvbi9zaW5nbGVVc2UvY2FtcGFpZ24ve2lk",
            "fZJBSQoQQ291cG9uIENhbXBhaWducxITR2V0IENvdXBvbiBDYW1wYWlnbhog",
            "R2V0cyBhbiBleGlzdGluZyBDb3Vwb24gQ2FtcGFpZ24SngMKFGRlbGV0ZUNv",
            "dXBvbkNhbXBhaWduEgYuaW8uSWQaFi5nb29nbGUucHJvdG9idWYuRW1wdHki",
            "5QKC0+STAiQqHy9jb3Vwb24vc2luZ2xlVXNlL2NhbXBhaWduL3tpZH06ASqS",
            "QbcCChBDb3Vwb24gQ2FtcGFpZ25zEhZEZWxldGUgQ291cG9uIENhbXBhaWdu",
            "GooCRGVsZXRlcyBhbiBleGlzdGluZyBDb3Vwb24gQ2FtcGFpZ24gYnkgaWQu",
            "IERlbGV0aW5nIGEgQ291cG9uIENhbXBhaWduIHJlc3VsdHMgaW4gdGhlIHJl",
            "bGF0ZWQgb2ZmZXIgYmVpbmcgZGVsZXRlZCwgYW5kIGFsbCBjb3Vwb25zIGJl",
            "aW5nIGludmFsaWRhdGVkIGluIHRoZSBjdXN0b21lcnMgTW9iaWxlIFdhbGxl",
            "dDsgcmVuZGVyaW5nIHRoZW0gdW51c2FibGUuIFRoaXMgbWV0aG9kIG5lZWRz",
            "IHRvIGJlIHVzZWQgd2l0aCBjYXJlLCB0aGlzIGlzIGlycmV2ZXJzaWJsZS4S",
            "lAIKHWxpc3RDb3Vwb25DYW1wYWlnbnNEZXByZWNhdGVkEg4uaW8uUGFnaW5h",
            "dGlvbhoiLnNpbmdsZV91c2VfY291cG9ucy5Db3Vwb25DYW1wYWlnbiK8AYLT",
            "5JMCHRIbL2NvdXBvbi9zaW5nbGVVc2UvY2FtcGFpZ25zkkGVAQoQQ291cG9u",
            "IENhbXBhaWducxIiTGlzdCBDb3Vwb24gQ2FtcGFpZ25zIFtERVBSRUNBVEVE",
            "XRpdW0RFUFJFQ0FURUQ6IE9SIG9wZXJhdG9yIGlzIG5vdCBzdXBwb3J0ZWRd",
            "IExpc3RzIGFsbCBDb3Vwb24gQ2FtcGFpZ25zIGZvciB0aGUgbG9nZ2VkIGlu",
            "IHVzZXIuMAESvgQKE2xpc3RDb3Vwb25DYW1wYWlnbnMSCy5pby5GaWx0ZXJz",
            "GiIuc2luZ2xlX3VzZV9jb3Vwb25zLkNvdXBvbkNhbXBhaWduIvMDgtPkkwIl",
            "IiAvY291cG9uL3NpbmdsZVVzZS9jYW1wYWlnbnMvbGlzdDoBKpJBxAMKEENv",
            "dXBvbiBDYW1wYWlnbnMSFUxpc3QgQ291cG9uIENhbXBhaWducxqYA0xpc3Rz",
            "IGFsbCBDb3Vwb24gQ2FtcGFpZ25zIGZvciB0aGUgbG9nZ2VkIGluIHVzZXIu",
            "Cgo8c3BhbiBzdHlsZT0iZm9udC13ZWlnaHQ6Ym9sZCI+QWJvdXQgZmlsdGVy",
            "IGZpZWxkIG5hbWVzLCBvcGVyYXRvcnMgYW5kIHNhbXBsZSBwYXlsb2Fkczo8",
            "L3NwYW4+IDxhIHRhcmdldD0iX2JsYW5rIiBocmVmPSJodHRwczovL2hlbHAu",
            "cGFzc2tpdC5jb20vZW4vYXJ0aWNsZXMvNDEzMDk2Ny1jb3Vwb24tcHJvdG9j",
            "b2wtZmlsdGVyaW5nLWxpc3RpbmctYW5kLWNvdW50aW5nLWJ5LWFwaSNmaWx0",
            "ZXItY2FtcGFpZ25zIj5odHRwczovL2hlbHAucGFzc2tpdC5jb20vZW4vYXJ0",
            "aWNsZXMvNDEzMDk2Ny1jb3Vwb24tcHJvdG9jb2wtZmlsdGVyaW5nLWxpc3Rp",
            "bmctYW5kLWNvdW50aW5nLWJ5LWFwaSNmaWx0ZXItY2FtcGFpZ25zPC9hPjAB",
            "EvIBCgxnZXRBbmFseXRpY3MSFC5pby5BbmFseXRpY3NSZXF1ZXN0GjMuc2lu",
            "Z2xlX3VzZV9jb3Vwb25zLkNvdXBvbkNhbXBhaWduQW5hbHl0aWNzUmVzcG9u",
            "c2UilgGC0+STAjASLi9jb3Vwb24vc2luZ2xlVXNlL2NhbXBhaWduL3tjbGFz",
            "c0lkfS9hbmFseXRpY3OSQV0KEENvdXBvbiBDYW1wYWlnbnMSHUdldCBDb3Vw",
            "b24gQ2FtcGFpZ24gQW5hbHl0aWNzGipSZXRyaWV2ZXMgcHJvdG9jb2wgc3Bl",
            "Y2lmaWMgYW5hbHl0aWNzIGRhdGESowEKEWNyZWF0ZUNvdXBvbk9mZmVyEh8u",
            "c2luZ2xlX3VzZV9jb3Vwb25zLkNvdXBvbk9mZmVyGgYuaW8uSWQiZYLT5JMC",
            "HCIXL2NvdXBvbi9zaW5nbGVVc2Uvb2ZmZXI6ASqSQUAKDUNvdXBvbiBPZmZl",
            "cnMSE0NyZWF0ZSBDb3Vwb24gT2ZmZXIaGkNyZWF0ZXMgYSBuZXcgQ291cG9u",
            "IE9mZmVyEsIBChF1cGRhdGVDb3Vwb25PZmZlchIfLnNpbmdsZV91c2VfY291",
            "cG9ucy5Db3Vwb25PZmZlchofLnNpbmdsZV91c2VfY291cG9ucy5Db3Vwb25P",
            "ZmZlciJrgtPkkwIcGhcvY291cG9uL3NpbmdsZVVzZS9vZmZlcjoBKpJBRgoN",
            "Q291cG9uIE9mZmVycxITVXBkYXRlIENvdXBvbiBPZmZlchogVXBkYXRlcyBh",
            "biBleGlzdGluZyBDb3Vwb24gT2ZmZXISogEKDmdldENvdXBvbk9mZmVyEgYu",
            "aW8uSWQaHy5zaW5nbGVfdXNlX2NvdXBvbnMuQ291cG9uT2ZmZXIiZ4LT5JMC",
            "HhIcL2NvdXBvbi9zaW5nbGVVc2Uvb2ZmZXIve2lkfZJBQAoNQ291cG9uIE9m",
            "ZmVycxIQR2V0IENvdXBvbiBPZmZlchodR2V0cyBhbiBleGlzdGluZyBDb3Vw",
            "b24gT2ZmZXIS2wIKEWRlbGV0ZUNvdXBvbk9mZmVyEgYuaW8uSWQaFi5nb29n",
            "bGUucHJvdG9idWYuRW1wdHkipQKC0+STAiEqHC9jb3Vwb24vc2luZ2xlVXNl",
            "L29mZmVyL3tpZH06ASqSQfoBCg1Db3Vwb24gT2ZmZXJzEhNEZWxldGUgQ291",
            "cG9uIE9mZmVyGtMBRGVsZXRlcyBhbiBleGlzdGluZyBDb3Vwb24gT2ZmZXIg",
            "YnkgaWQuIERlbGV0aW5nIGEgQ291cG9uIE9mZmVyIHJlc3VsdHMgaW4gYWxs",
            "IGNvdXBvbnMgYmVpbmcgaW52YWxpZGF0ZWQgaW4gdGhlIGN1c3RvbWVycyBN",
            "b2JpbGUgV2FsbGV0OyByZW5kZXJpbmcgdGhlbSB1bnVzYWJsZS4gTmVlZHMg",
            "dG8gYmUgdXNlZCB3aXRoIGNhcmUsIHRoaXMgaXMgaXJyZXZlcnNpYmxlLhKh",
            "AgoabGlzdENvdXBvbk9mZmVyc0RlcHJlY2F0ZWQSNS5zaW5nbGVfdXNlX2Nv",
            "dXBvbnMuQ291cG9uT2ZmZXJzTGlzdFJlcXVlc3REZXByZWNhdGVkGh8uc2lu",
            "Z2xlX3VzZV9jb3Vwb25zLkNvdXBvbk9mZmVyIqgBgtPkkwIaEhgvY291cG9u",
            "L3NpbmdsZVVzZS9vZmZlcnOSQYQBCg1Db3Vwb24gT2ZmZXJzEh9MaXN0IENv",
            "dXBvbiBPZmZlcnMgW0RFUFJFQ0FURURdGlJbREVQUkVDQVRFRDogT1Igb3Bl",
            "cmF0b3IgaXMgbm90IHN1cHBvcnRlZF0gTGlzdHMgYWxsIENvdXBvbiBPZmZl",
            "cnMgZm9yIGEgY2FtcGFpZ24uMAESvgQKEGxpc3RDb3Vwb25PZmZlcnMSKy5z",
            "aW5nbGVfdXNlX2NvdXBvbnMuQ291cG9uT2ZmZXJzTGlzdFJlcXVlc3QaHy5z",
            "aW5nbGVfdXNlX2NvdXBvbnMuQ291cG9uT2ZmZXIi2QOC0+STAiIiHS9jb3Vw",
            "b24vc2luZ2xlVXNlL29mZmVycy9saXN0OgEqkkGtAwoNQ291cG9uIE9mZmVy",
            "cxISTGlzdCBDb3Vwb24gT2ZmZXJzGocDTGlzdHMgYWxsIENvdXBvbiBPZmZl",
            "cnMgZm9yIGEgY2FtcGFpZ24uCgo8c3BhbiBzdHlsZT0iZm9udC13ZWlnaHQ6",
            "Ym9sZCI+QWJvdXQgZmlsdGVyIGZpZWxkIG5hbWVzLCBvcGVyYXRvcnMgYW5k",
            "IHNhbXBsZSBwYXlsb2Fkczo8L3NwYW4+IDxhIHRhcmdldD0iX2JsYW5rIiBo",
            "cmVmPSJodHRwczovL2hlbHAucGFzc2tpdC5jb20vZW4vYXJ0aWNsZXMvNDEz",
            "MDk2Ny1jb3Vwb24tcHJvdG9jb2wtZmlsdGVyaW5nLWxpc3RpbmctYW5kLWNv",
            "dW50aW5nLWJ5LWFwaSNmaWx0ZXItb2ZmZXJzIj5odHRwczovL2hlbHAucGFz",
            "c2tpdC5jb20vZW4vYXJ0aWNsZXMvNDEzMDk2Ny1jb3Vwb24tcHJvdG9jb2wt",
            "ZmlsdGVyaW5nLWxpc3RpbmctYW5kLWNvdW50aW5nLWJ5LWFwaSNmaWx0ZXIt",
            "b2ZmZXJzPC9hPjABEo8BCgxjcmVhdGVDb3Vwb24SGi5zaW5nbGVfdXNlX2Nv",
            "dXBvbnMuQ291cG9uGgYuaW8uSWQiW4LT5JMCHSIYL2NvdXBvbi9zaW5nbGVV",
            "c2UvY291cG9uOgEqkkE1CgdDb3Vwb25zEg1DcmVhdGUgQ291cG9uGhtDcmVh",
            "dGVzIGEgbmV3IHVuaXF1ZSBDb3Vwb24SjgEKDHVwZGF0ZUNvdXBvbhIaLnNp",
            "bmdsZV91c2VfY291cG9ucy5Db3Vwb24aBi5pby5JZCJagtPkkwIdGhgvY291",
            "cG9uL3NpbmdsZVVzZS9jb3Vwb246ASqSQTQKB0NvdXBvbnMSDVVwZGF0ZSBD",
            "b3Vwb24aGlVwZGF0ZXMgYW4gZXhpc3RpbmcgQ291cG9uEr4BChNzdHJlYW1D",
            "b3Vwb25VcGRhdGVzEhouc2luZ2xlX3VzZV9jb3Vwb25zLkNvdXBvbhoGLmlv",
            "LklkIn+SQXwKB0NvdXBvbnMSJ1N0cmVhbSBDb3Vwb24gVXBkYXRlcyAoZ1JQ",
            "QyBTREtzcyBvbmx5KRpIVXBkYXRlcyBleGlzdGluZyBDb3Vwb24gcmVjb3Jk",
            "cyB2aWEgc3RyZWFtLiBUbyBiZSB1c2VkIGZvciBiYXRjaCB1cGRhdGUuKAEw",
            "ARLrAgoMcmVkZWVtQ291cG9uEhouc2luZ2xlX3VzZV9jb3Vwb25zLkNvdXBv",
            "bhoGLmlvLklkIrYCgtPkkwIkGh8vY291cG9uL3NpbmdsZVVzZS9jb3Vwb24v",
            "cmVkZWVtOgEqkkGIAgoHQ291cG9ucxINUmVkZWVtIENvdXBvbhrtAVJlZGVl",
            "bXMgYW4gZXhpc3RpbmcgQ291cG9uLiBVc2UgdGhpcyBlbmRwb2ludCB3aGVu",
            "IHlvdSB3YW50IHRvIGNhcHR1cmUgcmVkZW1wdGlvbiBkYXRhIGFuZCB0cmln",
            "Z2VyIHRoZSBzd2l0Y2ggdG8gdGhlIHJlZGVtcHRpb24gZGVzaWduIG9mIHRo",
            "ZSBjb3Vwb24uIFRoZSBjb3Vwb24gY2Fubm90IGJlIHVzZWQgYWdhaW4gYWZ0",
            "ZXIgY2FsbGluZyB0aGlzIGVuZHBvaW50LCBhbmQgaXMgbWFya2VkIGFzIHJl",
            "ZGVlbWVkLhKLAgoWdXBkYXRlQ291cG9uRXh0ZXJuYWxJZBIuLnNpbmdsZV91",
            "c2VfY291cG9ucy5Db3Vwb25OZXdFeHRlcm5hbElkUmVxdWVzdBoGLmlvLklk",
            "IrgBgtPkkwIoGiMvY291cG9uL3NpbmdsZVVzZS9jb3Vwb24vZXh0ZXJuYWxJ",
            "ZDoBKpJBhgEKB0NvdXBvbnMSGVVwZGF0ZSBDb3Vwb24gRXh0ZXJuYWwgSWQa",
            "YFVwZGF0ZXMgYW4gZXh0ZXJuYWwgaWQgb2YgYW4gZXhpc3RpbmcgY291cG9u",
            "LiBFeHRlbmFsIGlkIG5lZWRzIHRvIGJlIHVuaXF1ZSB3aXRoaW4gdGhlIGNh",
            "bXBhaWduLhLLAQoXc3RyZWFtQ291cG9uUmVkZW1wdGlvbnMSGi5zaW5nbGVf",
            "dXNlX2NvdXBvbnMuQ291cG9uGgYuaW8uSWQihwGSQYMBCgdDb3Vwb25zEipT",
            "dHJlYW0gQ291cG9uIFJlZGVtcHRpb25zIChnUlBDIFNES3Mgb25seSkaTFJl",
            "ZGVlbXMgZXhpc3RpbmcgQ291cG9uIHJlY29yZHMgdmlhIHN0cmVhbS4gVG8g",
            "YmUgdXNlZCBmb3IgYmF0Y2ggcmVkZW1wdGlvbi4oATABEo4BCg1nZXRDb3Vw",
            "b25CeUlkEgYuaW8uSWQaGi5zaW5nbGVfdXNlX2NvdXBvbnMuQ291cG9uIlmC",
            "0+STAh8SHS9jb3Vwb24vc2luZ2xlVXNlL2NvdXBvbi97aWR9kkExCgdDb3Vw",
            "b25zEhBHZXQgQ291cG9uIGJ5IElEGhRHZXRzIGEgQ291cG9uIHJlY29yZBL0",
            "AQoVZ2V0Q291cG9uQnlFeHRlcm5hbElkEiUuc2luZ2xlX3VzZV9jb3Vwb25z",
            "LkV4dGVybmFsSWRSZXF1ZXN0Ghouc2luZ2xlX3VzZV9jb3Vwb25zLkNvdXBv",
            "biKXAYLT5JMCRRJDL2NvdXBvbi9zaW5nbGVVc2UvY291cG9uL2V4dGVybmFs",
            "SWQve2NvdXBvbkNhbXBhaWduSWR9L3tleHRlcm5hbElkfZJBSQoHQ291cG9u",
            "cxIZR2V0IENvdXBvbiBieSBFeHRlcm5hbCBJRBojR2V0cyBhIENvdXBvbiBy",
            "ZWNvcmQgYnkgRXh0ZXJuYWwgSUQSwgIKCnZvaWRDb3Vwb24SGi5zaW5nbGVf",
            "dXNlX2NvdXBvbnMuQ291cG9uGhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5Iv8B",
            "gtPkkwIdKhgvY291cG9uL3NpbmdsZVVzZS9jb3Vwb246ASqSQdgBCgdDb3Vw",
            "b25zEgtWb2lkIENvdXBvbhq/AVZvaWRzIChkZWxldGVzKSBhbiBleGlzdGlu",
            "ZyBDb3Vwb24gYnkgSUQgb3IgRXh0ZXJuYWwgSUQuIEludmFsaWRhdGVzIHRo",
            "ZSBjb3Vwb24gaW4gdGhlIGN1c3RvbWVycyBNb2JpbGUgV2FsbGV0OyByZW5k",
            "ZXJpbmcgaXQgdXNlbGVzcy4gVGhpcyBtZXRob2QgaXMgaXJyZXZlcnNpYmxl",
            "IGFuZCBzaG91bGQgYmUgdXNlZCB3aXRoIGNhcmUuErgCCiVsaXN0Q291cG9u",
            "c0J5Q291cG9uQ2FtcGFpZ25EZXByZWNhdGVkEikuc2luZ2xlX3VzZV9jb3Vw",
            "b25zLkxpc3RSZXF1ZXN0RGVwcmVjYXRlZBoaLnNpbmdsZV91c2VfY291cG9u",
            "cy5Db3Vwb24ixQGC0+STAi4SLC9jb3Vwb24vc2luZ2xlVXNlL2NvdXBvbnMv",
            "e2NvdXBvbkNhbXBhaWduSWR9kkGNAQoHQ291cG9ucxIZTGlzdCBDb3Vwb25z",
            "IFtERVBSRUNBVEVEXRpnW0RFUFJFQ0FURUQ6IE9SIG9wZXJhdG9yIGlzIG5v",
            "dCBzdXBwb3J0ZWRdIExpc3QgYWxsIGNvdXBvbnMgZm9yIGEgQ291cG9uIENh",
            "bXBhaWduLiBTdXBwb3J0cyBwYWdpbmF0aW9uLjABEtcEChtsaXN0Q291cG9u",
            "c0J5Q291cG9uQ2FtcGFpZ24SHy5zaW5nbGVfdXNlX2NvdXBvbnMuTGlzdFJl",
            "cXVlc3QaGi5zaW5nbGVfdXNlX2NvdXBvbnMuQ291cG9uIvgDgtPkkwI2IjEv",
            "Y291cG9uL3NpbmdsZVVzZS9jb3Vwb25zL2xpc3Qve2NvdXBvbkNhbXBhaWdu",
            "SWR9OgEqkkG4AwoHQ291cG9ucxIMTGlzdCBDb3Vwb25zGp4DTGlzdCBhbGwg",
            "Y291cG9ucyBmb3IgYSBDb3Vwb24gQ2FtcGFpZ24uIFN1cHBvcnRzIHBhZ2lu",
            "YXRpb24uCgo8c3BhbiBzdHlsZT0iZm9udC13ZWlnaHQ6Ym9sZCI+QWJvdXQg",
            "ZmlsdGVyIGZpZWxkIG5hbWVzLCBvcGVyYXRvcnMgYW5kIHNhbXBsZSBwYXls",
            "b2Fkczo8L3NwYW4+IDxhIHRhcmdldD0iX2JsYW5rIiBocmVmPSJodHRwczov",
            "L2hlbHAucGFzc2tpdC5jb20vZW4vYXJ0aWNsZXMvNDEzMDk2Ny1jb3Vwb24t",
            "cHJvdG9jb2wtZmlsdGVyaW5nLWxpc3RpbmctYW5kLWNvdW50aW5nLWJ5LWFw",
            "aSNmaWx0ZXItY291cG9ucyI+aHR0cHM6Ly9oZWxwLnBhc3NraXQuY29tL2Vu",
            "L2FydGljbGVzLzQxMzA5NjctY291cG9uLXByb3RvY29sLWZpbHRlcmluZy1s",
            "aXN0aW5nLWFuZC1jb3VudGluZy1ieS1hcGkjZmlsdGVyLWNvdXBvbnM8L2E+",
            "MAESmAIKJmNvdW50Q291cG9uc0J5Q291cG9uQ2FtcGFpZ25EZXByZWNhdGVk",
            "Eikuc2luZ2xlX3VzZV9jb3Vwb25zLkxpc3RSZXF1ZXN0RGVwcmVjYXRlZBoJ",
            "LmlvLkNvdW50IrcBgtPkkwI0EjIvY291cG9uL3NpbmdsZVVzZS9jb3Vwb25z",
            "L2NvdW50L3tjb3Vwb25DYW1wYWlnbklkfZJBegoHQ291cG9ucxIaQ291bnQg",
            "Q291cG9ucyBbREVQUkVDQVRFRF0aU1tERVBSRUNBVEVEOiBPUiBvcGVyYXRv",
            "ciBpcyBub3Qgc3VwcG9ydGVkXSBDb3VudCBhbGwgY291cG9ucyBmb3IgYSBD",
            "b3Vwb24gQ2FtcGFpZ24uErMEChxjb3VudENvdXBvbnNCeUNvdXBvbkNhbXBh",
            "aWduEh8uc2luZ2xlX3VzZV9jb3Vwb25zLkxpc3RSZXF1ZXN0GgkuaW8uQ291",
            "bnQi5gOC0+STAjciMi9jb3Vwb24vc2luZ2xlVXNlL2NvdXBvbnMvY291bnQv",
            "e2NvdXBvbkNhbXBhaWduSWR9OgEqkkGlAwoHQ291cG9ucxINQ291bnQgQ291",
            "cG9ucxqKA0NvdW50IGFsbCBjb3Vwb25zIGZvciBhIENvdXBvbiBDYW1wYWln",
            "bi4KCjxzcGFuIHN0eWxlPSJmb250LXdlaWdodDpib2xkIj5BYm91dCBmaWx0",
            "ZXIgZmllbGQgbmFtZXMsIG9wZXJhdG9ycyBhbmQgc2FtcGxlIHBheWxvYWRz",
            "Ojwvc3Bhbj4gPGEgdGFyZ2V0PSJfYmxhbmsiIGhyZWY9Imh0dHBzOi8vaGVs",
            "cC5wYXNza2l0LmNvbS9lbi9hcnRpY2xlcy80MTMwOTY3LWNvdXBvbi1wcm90",
            "b2NvbC1maWx0ZXJpbmctbGlzdGluZy1hbmQtY291bnRpbmctYnktYXBpI2Zp",
            "bHRlci1jb3Vwb25zIj5odHRwczovL2hlbHAucGFzc2tpdC5jb20vZW4vYXJ0",
            "aWNsZXMvNDEzMDk2Ny1jb3Vwb24tcHJvdG9jb2wtZmlsdGVyaW5nLWxpc3Rp",
            "bmctYW5kLWNvdW50aW5nLWJ5LWFwaSNmaWx0ZXItY291cG9uczwvYT4StAEK",
            "C3BhdGNoUGVyc29uEhEuaW8uUGVyc29uUmVxdWVzdBoGLmlvLklkIokBgtPk",
            "kwIkMh8vY291cG9uL3NpbmdsZVVzZS9jb3Vwb24vcGVyc29uOgEqkkFcCgdD",
            "b3Vwb25zEhtVcGRhdGUgUGVyc29uYWwgSW5mb3JtYXRpb24aNFVwZGF0ZXMg",
            "cGVyc29uYWwgaW5mb3JtYXRpb24gb2YgYSBjb3Vwb24gcGFzcyBob2xkZXIS",
            "uQEKEmNvcHlDb3Vwb25DYW1wYWlnbhInLnNpbmdsZV91c2VfY291cG9ucy5D",
            "YW1wYWlnbkNvcHlSZXF1ZXN0GgYuaW8uSWQicoLT5JMCJCIfL2NvdXBvbi9z",
            "aW5nbGVVc2UvY2FtcGFpZ24vY29weToBKpJBRQoQQ291cG9uIENhbXBhaWdu",
            "cxINQ29weSBDYW1wYWlnbhoiQ29waWVzIGFuIGV4aXN0aW5nIGNhbXBhaWdu",
            "IHJlY29yZBLwAQoWZ2V0TWV0YUtleXNGb3JDYW1wYWlnbhIGLmlvLklkGgsu",
            "aW8uU3RyaW5ncyLAAYLT5JMCJhIkL2NvdXBvbi9zaW5nbGVVc2UvY2FtcGFp",
            "Z24vbWV0YS97aWR9kkGQAQoQQ291cG9uIENhbXBhaWducxIcR2V0IE1ldGEg",
            "S2V5cyBmb3IgYSBDYW1wYWlnbhpeUmV0dXJucyBhIGxpc3Qgb2YgZGlzdGlu",
            "Y3QgbWV0YSBmaWVsZCBrZXlzLiBDYW4gYmUgdXNlZCBmb3IgYnVpbGRpbmcg",
            "ZmlsdGVycyAvIHRhYmxlIGhlYWRpbmdzLkKFCAohY29tLnBhc3NraXQuZ3Jw",
            "Yy5TaW5nbGVVc2VDb3Vwb25zWjdzdGFzaC5wYXNza2l0LmNvbS9pby9tb2Rl",
            "bC9zZGsvZ28vaW8vc2luZ2xlX3VzZV9jb3Vwb25zqgIfUGFzc0tpdEdycGNT",
            "REsuU2luZ2xlVXNlQ291cG9uc5JBgwcSvgIKHVBhc3NLaXQgU2luZ2xlIFVz",
            "ZSBDb3Vwb24gQVBJEpwBVGhpcyBwcm90b2NvbCBpcyBzdWl0IGZvciBjYXNl",
            "cyB3aGVyZSB0aGUgdXNlciByZXF1aXJlcyBhIGNsZWFuIGFuZCBzaW1wbGUg",
            "c2luZ2xlIHVzZSBjb3Vwb24gZm9yIHNob3J0IHRlcm0gY291cG9uIGNhbXBh",
            "aWducyBpbiBBcHBsZSBXYWxsZXQgYW5kIEdvb2dsZSBQYXkuGjhodHRwczov",
            "L3Bhc3NraXQuY29tL2xlZ2FsL3Rlcm1zLW9mLXN1YnNjcmlwdGlvbi1zZXJ2",
            "aWNlLyI/Cg9QYXNzS2l0IFN1cHBvcnQSF2h0dHBzOi8vZG9jcy5wYXNza2l0",
            "LmlvGhNzdXBwb3J0QHBhc3NraXQuY29tMgMxLjAqAQIyEGFwcGxpY2F0aW9u",
            "L2pzb246EGFwcGxpY2F0aW9uL2pzb25SOQoDMjAwEjIKKFJldHVybmVkIHdo",
            "ZW4gdGhlIHJlcXVlc3QgaXMgc3VjY2Vzc2Z1bC4SBgoEmgIBB1I0CgM0MDAS",
            "LQorUmV0dXJuZWQgd2hlbiB3cm9uZyB1c2VyIGlucHV0IGlzIHByb3ZpZGVk",
            "LlIwCgM0MDESKQonUmV0dXJuZWQgd2hlbiB0aGUgdXNlciBpcyB1bmF1dGhv",
            "cml6ZWQuUlAKAzQwMxJJCkdSZXR1cm5lZCB3aGVuIHRoZSB1c2VyIGRvZXMg",
            "bm90IGhhdmUgcGVybWlzc2lvbiB0byBhY2Nlc3MgdGhlIHJlc291cmNlLlI7",
            "CgM0MDQSNAoqUmV0dXJuZWQgd2hlbiB0aGUgcmVzb3VyY2UgZG9lcyBub3Qg",
            "ZXhpc3QuEgYKBJoCAQdSPAoDNTAwEjUKK1JldHVybmVkIHdoZW4gdGhlcmUg",
            "aXMgYW4gdW5leHBlY3RlZCBlcnJvci4SBgoEmgIBB1JXCgM1MDMSUApOU2Vy",
            "dmVyIGlzIHVuYXZhaWxhYmxlLiBCYWNrIG9mZiBmb3IgMjUwbXMgYW5kIHJl",
            "cGVhdCByZXF1ZXN0IHVudGlsIHN1Y2Nlc3NmdWwuWj4KPAoKYXBpS2V5QXV0",
            "aBIuCAISGUpXVCBBdXRoZW50aWNhdGlvbiB0b2tlbi4aDUF1dGhvcml6YXRp",
            "b24gAmIQCg4KCmFwaUtleUF1dGgSAGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::PassKitGrpcSDK.CommonObjectsReflection.Descriptor, global::PassKitGrpcSDK.PaginationReflection.Descriptor, global::PassKitGrpcSDK.FilterReflection.Descriptor, global::PassKitGrpcSDK.ReportingReflection.Descriptor, global::PassKitGrpcSDK.PersonalReflection.Descriptor, global::PassKitGrpcSDK.SingleUseCoupons.CampaignReflection.Descriptor, global::PassKitGrpcSDK.SingleUseCoupons.OfferReflection.Descriptor, global::PassKitGrpcSDK.SingleUseCoupons.CouponReflection.Descriptor, global::PassKitGrpcSDK.Gateway.ProtocGenOpenapiv2.Options.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, null));
    }
    #endregion

  }
}

#endregion Designer generated code
