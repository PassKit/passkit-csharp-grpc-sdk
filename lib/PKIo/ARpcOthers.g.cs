// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: io/core/a_rpc_others.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PKIo {

  /// <summary>Holder for reflection information generated from io/core/a_rpc_others.proto</summary>
  public static partial class ARpcOthersReflection {

    #region Descriptor
    /// <summary>File descriptor for io/core/a_rpc_others.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ARpcOthersReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chppby9jb3JlL2FfcnBjX290aGVycy5wcm90bxICaW8aHGdvb2dsZS9hcGkv",
            "YW5ub3RhdGlvbnMucHJvdG8aG2dvb2dsZS9wcm90b2J1Zi9lbXB0eS5wcm90",
            "bxoscHJvdG9jLWdlbi1zd2FnZ2VyL29wdGlvbnMvYW5ub3RhdGlvbnMucHJv",
            "dG8aHmlvL2NvbW1vbi9jb21tb25fb2JqZWN0cy5wcm90bxocaW8vY29tbW9u",
            "L2Rpc3RyaWJ1dGlvbi5wcm90bxoXaW8vY29tbW9uL3Byb2plY3QucHJvdG8a",
            "F2lvL2NvbW1vbi9tZXNzYWdlLnByb3RvGhNpby9jb21tb24vam9iLnByb3Rv",
            "Ghppby9jb21tb24vcGFnaW5hdGlvbi5wcm90bxoWaW8vY29tbW9uL2ZpbHRl",
            "ci5wcm90bxobaW8vY29tbW9uL2ludGVncmF0aW9uLnByb3RvGhJpby91c2Vy",
            "L3VzZXIucHJvdG8y5woKBVVzZXJzEkAKCmNyZWF0ZVVzZXISCy5pby5OZXdV",
            "c2VyGhMuaW8uTmV3VXNlclJlc3BvbnNlIhCC0+STAgoiBS91c2VyOgEqEjUK",
            "B25ld1VzZXISCy5pby5OZXdVc2VyGgcuaW8uSldUIhSC0+STAg4iCS91c2Vy",
            "L25ldzoBKhI2CgZ2ZXJpZnkSBi5pby5JZBoLLmlvLkJvb2xlYW4iF4LT5JMC",
            "ERoML3VzZXIvdmVyaWZ5OgEqEl4KF3Jlc2VuZFZlcmlmaWNhdGlvbkVtYWls",
            "EhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5GgsuaW8uQm9vbGVhbiIegtPkkwIY",
            "IhMvdXNlci92ZXJpZnkvcmVzZW5kOgEqEk0KB2dldFVzZXISFi5nb29nbGUu",
            "cHJvdG9idWYuRW1wdHkaEy5pby5HZXRVc2VyUmVzcG9uc2UiFYLT5JMCDxIN",
            "L3VzZXIvcHJvZmlsZRI0CgVsb2dpbhIPLmlvLkNyZWRlbnRpYWxzGgcuaW8u",
            "SldUIhGC0+STAgsiBi9sb2dpbjoBKhJQCg1yZXNldFBhc3N3b3JkEg8uaW8u",
            "Q3JlZGVudGlhbHMaFi5nb29nbGUucHJvdG9idWYuRW1wdHkiFoLT5JMCEBoL",
            "L3VzZXIvcmVzZXQ6ASoSXgoVc2VuZFBhc3N3b3JkUmVzZXRMaW5rEgwuaW8u",
            "VXNlcm5hbWUaFi5nb29nbGUucHJvdG9idWYuRW1wdHkiH4LT5JMCGSIUL3Vz",
            "ZXIvcmVzZXQvcGFzc3dvcmQ6ASoSYQoOY2hhbmdlUGFzc3dvcmQSFi5pby5Q",
            "YXNzd29yZFJlc2V0SW5wdXQaFi5nb29nbGUucHJvdG9idWYuRW1wdHkiH4LT",
            "5JMCGRoUL3VzZXIvcmVzZXQvcGFzc3dvcmQ6ASoSYAohZ2V0UHJvamVjdHNG",
            "b3JVc2VyUXVlcnlEZXByZWNhdGVkEg4uaW8uUGFnaW5hdGlvbhoLLmlvLlBy",
            "b2plY3QiHILT5JMCFhIUL3Byb2plY3RzL3VzZXIvcXVlcnkwARJUChpnZXRQ",
            "cm9qZWN0c1F1ZXJ5RGVwcmVjYXRlZBIOLmlvLlBhZ2luYXRpb24aCy5pby5Q",
            "cm9qZWN0IheC0+STAhESDy9wcm9qZWN0cy9xdWVyeTABElUKF2dldFByb2pl",
            "Y3RzRm9yVXNlclF1ZXJ5EgsuaW8uRmlsdGVycxoLLmlvLlByb2plY3QiHoLT",
            "5JMCGCITL3Byb2plY3RzL3VzZXIvbGlzdDoBKjABEkkKEGdldFByb2plY3Rz",
            "UXVlcnkSCy5pby5GaWx0ZXJzGgsuaW8uUHJvamVjdCIZgtPkkwITIg4vcHJv",
            "amVjdHMvbGlzdDoBKjABEkIKEGdldFByb2plY3RCeVV1aWQSBi5pby5JZBoL",
            "LmlvLlByb2plY3QiGYLT5JMCExIRL3Byb2plY3RzL2lkL3tpZH0SYwogZ2V0",
            "UHJvamVjdEFuZFRlbXBsYXRlQnlTaG9ydENvZGUSBi5pby5JZBocLmlvLlBy",
            "b2plY3RCeVNob3J0Q29kZVJlc3VsdCIZgtPkkwITEhEvcHJvamVjdHMvc2Mv",
            "e2lkfRJdChJnZXRQcm9qZWN0c0ZvclVzZXISFy5pby5Qcm9qZWN0U3RhdHVz",
            "RmlsdGVyGgsuaW8uUHJvamVjdCIfgtPkkwIZEhcvcHJvamVjdHMvdXNlci97",
            "c3RhdHVzfTABElEKC2dldFByb2plY3RzEhcuaW8uUHJvamVjdFN0YXR1c0Zp",
            "bHRlchoLLmlvLlByb2plY3QiGoLT5JMCFBISL3Byb2plY3RzL3tzdGF0dXN9",
            "MAEyjwMKCE1lc3NhZ2VzEsQBCgtzZW5kTWVzc2FnZRILLmlvLk1lc3NhZ2Ua",
            "Bi5pby5JZCKfAYLT5JMCDSIIL21lc3NhZ2U6ASqSQYgBEgxTZW5kIE1lc3Nh",
            "Z2UaRkNyZWF0ZXMgYSBuZXcgbWVzc2FnZSBpbiB0aGUgZGF0YWJhc2UgYW5k",
            "IHVwZGF0ZXMgYWxsIHJlbGV2YW50IHBhc3Nlcy5KMAoDNDAwEikKJ1RoZXJl",
            "IGlzIGEgcHJvYmxlbSB3aXRoIHRoZSBpbnB1dCBkYXRhLhK7AQoLZ2V0TWVz",
            "c2FnZXMSDi5pby5QYWdpbmF0aW9uGgsuaW8uTWVzc2FnZSKMAYLT5JMCCxIJ",
            "L21lc3NhZ2VzkkF4EgxHZXQgTWVzc2FnZXMaNlJldHJpZXZlcyBhbGwgbWVz",
            "c2FnZXMgbWF0Y2hpbmcgdGhlIGNyaXRlcmlhIHByb3ZpZGVkLkowCgM0MDAS",
            "KQonVGhlcmUgaXMgYSBwcm9ibGVtIHdpdGggdGhlIGlucHV0IGRhdGEuMAEy",
            "uwIKDERpc3RyaWJ1dGlvbhKqAgoQc2VuZFdlbGNvbWVFbWFpbBIcLmlvLkVt",
            "YWlsRGlzdHJpYnV0aW9uUmVxdWVzdBoWLmdvb2dsZS5wcm90b2J1Zi5FbXB0",
            "eSLfAYLT5JMCGCITL2Rpc3RyaWJ1dGlvbi9lbWFpbDoBKpJBvQESElNlbmQg",
            "V2VsY29tZSBFbWFpbBouU2VuZHMgYSB3ZWxjb21lIGVtYWlsIHRvIGFuIGlu",
            "ZGl2aWR1YWwgcmVjb3JkLkowCgM0MDASKQonVGhlcmUgaXMgYSBwcm9ibGVt",
            "IHdpdGggdGhlIGlucHV0IGRhdGEuSh4KAzQwNBIXChVSZWNvcmQgd2FzIG5v",
            "dCBmb3VuZC5KJQoDNTAwEh4KHFRoZXJlIHdhcyBhbiBpbnRlcm5hbCBlcnJv",
            "ci4ysgQKBEpvYnMS3gEKCWltcG9ydENzdhIULmlvLkNzdkltcG9ydFJlcXVl",
            "c3QaBi5pby5JZCKyAYLT5JMCFCIPL2pvYi9jc3ZfaW1wb3J0OgEqkkGUARIK",
            "SW1wb3J0IENzdhoqVGFrZXMgYSBwcm92aWRlZCBjc3YgYW5kIGJ1aWxkcyBh",
            "IENzdiBqb2IuSjAKAzQwMBIpCidUaGVyZSBpcyBhIHByb2JsZW0gd2l0aCB0",
            "aGUgaW5wdXQgZGF0YS5KKAoDNDEzEiEKH1RoZSBmaWxlIHByb3ZpZGVkIGlz",
            "IHRvbyBsYXJnZS4SpwEKB2dldEpvYnMSDi5pby5QYWdpbmF0aW9uGgcuaW8u",
            "Sm9iIoABgtPkkwIHEgUvam9ic5JBcBIIR2V0IEpvYnMaMlJldHJpZXZlcyBh",
            "bGwgam9icyBtYXRjaGluZyB0aGUgY3JpdGVyaWEgcHJvdmlkZWQuSjAKAzQw",
            "MBIpCidUaGVyZSBpcyBhIHByb2JsZW0gd2l0aCB0aGUgaW5wdXQgZGF0YS4w",
            "ARKeAQoGZ2V0Sm9iEgYuaW8uSWQaBy5pby5Kb2IiggGC0+STAgsSCS9qb2Iv",
            "e2lkfZJBbhIHR2V0IEpvYhoxUmV0cmlldmVzIGEgam9iIHJlY29yZCB3aXRo",
            "IHRoZSBjb3JyZXNwb25kaW5nIGlkLkowCgM0MDASKQonVGhlcmUgaXMgYSBw",
            "cm9ibGVtIHdpdGggdGhlIGlucHV0IGRhdGEuMo0ZCgxJbnRlZ3JhdGlvbnMS",
            "gQIKEmNyZWF0ZUludGVncmF0aW9ucxIWLmlvLkludGVncmF0aW9uQ29uZmln",
            "cxoGLmlvLklkIsoBgtPkkwIeIhkvaW50ZWdyYXRpb25zL2ludGVncmF0aW9u",
            "OgEqkkGiARITQ3JlYXRlIEludGVncmF0aW9ucxojU2V0cyB1cCBpbnRlZ3Jh",
            "dGlvbiBjb25maWd1cmF0aW9ucy5KMAoDNDAwEikKJ1RoZXJlIGlzIGEgcHJv",
            "YmxlbSB3aXRoIHRoZSBpbnB1dCBkYXRhLko0CgM0MDMSLQorUmV0dXJuZWQg",
            "d2hlbiB0aGUgdXNlciBsYWNrcyBhdXRob3JpemF0aW9uLhL3AQoPZ2V0SW50",
            "ZWdyYXRpb25zEhMuaW8uUHJvdG9jb2xJZElucHV0GhYuaW8uSW50ZWdyYXRp",
            "b25Db25maWdzIrYBgtPkkwIwEi4vaW50ZWdyYXRpb25zL2ludGVncmF0aW9u",
            "L3twcm90b2NvbH0ve2NsYXNzSWR9kkF9EhBHZXQgSW50ZWdyYXRpb25zGiVS",
            "ZXRyaWV2ZXMgaW50ZWdyYXRpb24gY29uZmlndXJhdGlvbnMuSiIKAzQwMxIb",
            "ChlVc2VyIGxhY2tzIGF1dGhvcml6YXRpb24uSh4KAzQwNBIXChVSZWNvcmQg",
            "d2FzIG5vdCBmb3VuZC4S4wIKEnVwZGF0ZUludGVncmF0aW9ucxIWLmlvLklu",
            "dGVncmF0aW9uQ29uZmlncxoGLmlvLklkIqwCgtPkkwIeGhkvaW50ZWdyYXRp",
            "b25zL2ludGVncmF0aW9uOgEqkkGEAhITVXBkYXRlIEludGVncmF0aW9ucxoe",
            "VXBkYXRlcyBhbiBpbnRlZ3JhdGlvbiByZWNvcmQuSjAKAzQwMBIpCidUaGVy",
            "ZSBpcyBhIHByb2JsZW0gd2l0aCB0aGUgaW5wdXQgZGF0YS5KIgoDNDAzEhsK",
            "GVVzZXIgbGFja3MgYXV0aG9yaXphdGlvbi5KHgoDNDA0EhcKFVJlY29yZCB3",
            "YXMgbm90IGZvdW5kLkpXCgM1MDMSUApOU2VydmVyIGlzIHVuYXZhaWxhYmxl",
            "LiBCYWNrIG9mZiBmb3IgMjUwbXMgYW5kIHJlcGVhdCByZXF1ZXN0IHVudGls",
            "IHN1Y2Nlc3NmdWwuEvUBChJkZWxldGVJbnRlZ3JhdGlvbnMSEy5pby5Qcm90",
            "b2NvbElkSW5wdXQaFi5nb29nbGUucHJvdG9idWYuRW1wdHkisQGC0+STAjAq",
            "Li9pbnRlZ3JhdGlvbnMvaW50ZWdyYXRpb24ve3Byb3RvY29sfS97Y2xhc3NJ",
            "ZH2SQXgSE0RlbGV0ZSBJbnRlZ3JhdGlvbnMaHURlbGV0ZXMgYW4gaW50ZWdy",
            "YXRpb24gcmVjb3JkSiIKAzQwMxIbChlVc2VyIGxhY2tzIGF1dGhvcml6YXRp",
            "b24uSh4KAzQwNBIXChVSZWNvcmQgd2FzIG5vdCBmb3VuZC4SyAIKFmNyZWF0",
            "ZVNpbmtTdWJzY3JpcHRpb24SFC5pby5TaW5rU3Vic2NyaXB0aW9uGgYuaW8u",
            "SWQijwKC0+STAhciEi9pbnRlZ3JhdGlvbnMvc2luazoBKpJB7gESGENyZWF0",
            "ZSBTaW5rIFN1YnNjcmlwdGlvbhpqQ3JlYXRlcyBhIHNpbmsgc3Vic2NyaXB0",
            "aW9uIHNvIHRoYXQgUGFzc0tpdCBjYW4gc2VuZCBhIG1lc3NhZ2UgdG8gYSBV",
            "UkwgYWZ0ZXIgY2VydGFpbiBldmVudCBoYXMgY29tcGxldGVkLkowCgM0MDAS",
            "KQonVGhlcmUgaXMgYSBwcm9ibGVtIHdpdGggdGhlIGlucHV0IGRhdGEuSjQK",
            "AzQwMxItCitSZXR1cm5lZCB3aGVuIHRoZSB1c2VyIGxhY2tzIGF1dGhvcml6",
            "YXRpb24uEoMCChNnZXRTaW5rU3Vic2NyaXB0aW9uEhcuaW8uU3Vic2NyaXB0",
            "aW9uUmVxdWVzdBoULmlvLlNpbmtTdWJzY3JpcHRpb24ivAGC0+STAjASLi9p",
            "bnRlZ3JhdGlvbnMvc2luay97cHJvdG9jb2x9L3tzdWJzY3JpcHRpb25JZH2S",
            "QYIBEhVHZXQgU2luayBTdWJzY3JpcHRpb24aJVJldHJpZXZlcyBhIHNpbmsg",
            "c3Vic2NyaXB0aW9uIGNvbmZpZy5KIgoDNDAzEhsKGVVzZXIgbGFja3MgYXV0",
            "aG9yaXphdGlvbi5KHgoDNDA0EhcKFVJlY29yZCB3YXMgbm90IGZvdW5kLhLW",
            "AgofbGlzdFNpbmtTdWJzY3JpcHRpb25zRGVwcmVjYXRlZBIZLmlvLkxpc3RS",
            "ZXF1ZXN0RGVwcmVjYXRlZBoULmlvLlNpbmtTdWJzY3JpcHRpb24i/wGC0+ST",
            "AhoSGC9pbnRlZ3JhdGlvbnMvc2lua3MvbGlzdJJB2wESJExpc3QgU2luayBT",
            "dWJzY3JpcHRpb25zIFtERVBSRUNBVEVEXRpvW0RFUFJFQ0FURUQ6IE9SIG9w",
            "ZXJhdG9yIGlzIG5vdCBzdXBwb3J0ZWRdIExpc3QgYWxsIHNpbmsgc3Vic2Ny",
            "aXB0aW9ucyBmb3IgYSBnaXZlbiBzZWdtZW50LiBTdXBwb3J0IHBhZ2luYXRp",
            "b24uSiIKAzQwMxIbChlVc2VyIGxhY2tzIGF1dGhvcml6YXRpb24uSh4KAzQw",
            "NBIXChVSZWNvcmQgd2FzIG5vdCBmb3VuZC4wARKNAgoVbGlzdFNpbmtTdWJz",
            "Y3JpcHRpb25zEg8uaW8uTGlzdFJlcXVlc3QaFC5pby5TaW5rU3Vic2NyaXB0",
            "aW9uIsoBgtPkkwIdIhgvaW50ZWdyYXRpb25zL3NpbmtzL2xpc3Q6ASqSQaMB",
            "EhdMaXN0IFNpbmsgU3Vic2NyaXB0aW9ucxpETGlzdCBhbGwgc2luayBzdWJz",
            "Y3JpcHRpb25zIGZvciBhIGdpdmVuIHNlZ21lbnQuIFN1cHBvcnQgcGFnaW5h",
            "dGlvbi5KIgoDNDAzEhsKGVVzZXIgbGFja3MgYXV0aG9yaXphdGlvbi5KHgoD",
            "NDA0EhcKFVJlY29yZCB3YXMgbm90IGZvdW5kLjABEugCChZ1cGRhdGVTaW5r",
            "U3Vic2NyaXB0aW9uEhQuaW8uU2lua1N1YnNjcmlwdGlvbhoGLmlvLklkIq8C",
            "gtPkkwIXGhIvaW50ZWdyYXRpb25zL3Npbms6ASqSQY4CEhhVcGRhdGUgU2lu",
            "ayBTdWJzY3JpcHRpb24aI1VwZGF0ZXMgYSBzaW5rIHN1YnNjcmlwdGlvbiBy",
            "ZWNvcmQuSjAKAzQwMBIpCidUaGVyZSBpcyBhIHByb2JsZW0gd2l0aCB0aGUg",
            "aW5wdXQgZGF0YS5KIgoDNDAzEhsKGVVzZXIgbGFja3MgYXV0aG9yaXphdGlv",
            "bi5KHgoDNDA0EhcKFVJlY29yZCB3YXMgbm90IGZvdW5kLkpXCgM1MDMSUApO",
            "U2VydmVyIGlzIHVuYXZhaWxhYmxlLiBCYWNrIG9mZiBmb3IgMjUwbXMgYW5k",
            "IHJlcGVhdCByZXF1ZXN0IHVudGlsIHN1Y2Nlc3NmdWwuEokCChZkZWxldGVT",
            "aW5rU3Vic2NyaXB0aW9uEhcuaW8uU3Vic2NyaXB0aW9uUmVxdWVzdBoWLmdv",
            "b2dsZS5wcm90b2J1Zi5FbXB0eSK9AYLT5JMCMCouL2ludGVncmF0aW9ucy9z",
            "aW5rL3twcm90b2NvbH0ve3N1YnNjcmlwdGlvbklkfZJBgwESGERlbGV0ZSBT",
            "aW5rIFN1YnNjcmlwdGlvbhojRGVsZXRlcyBhbiBzaW5rIHN1YnNjcmlwdGlv",
            "biByZWNvcmRKIgoDNDAzEhsKGVVzZXIgbGFja3MgYXV0aG9yaXphdGlvbi5K",
            "HgoDNDA0EhcKFVJlY29yZCB3YXMgbm90IGZvdW5kLhLvAQoaZ2V0U2FtcGxl",
            "U3Vic2NyaXB0aW9uRXZlbnQSBi5pby5JZBoULmlvLlNpbmtTdWJzY3JpcHRp",
            "b24isgGC0+STAhsSGS9pbnRlZ3JhdGlvbnMvc2luay9zYW1wbGWSQY0BEh1H",
            "ZXQgU2FtcGxlIFN1YnNjcmlwdGlvbiBFdmVudBooUmV0cmlldmVzIGEgc2Ft",
            "cGxlIHN1YnNjcmlwdGlvbiBwYXlsb2FkLkoiCgM0MDMSGwoZVXNlciBsYWNr",
            "cyBhdXRob3JpemF0aW9uLkoeCgM0MDQSFwoVUmVjb3JkIHdhcyBub3QgZm91",
            "bmQuQj4KD2lvLnBhc3NraXQuUEtpb1okc3Rhc2gucGFzc2tpdC5jb20vaW8v",
            "bW9kZWwvc2RrL2dvL2lvqgIEUEtJb2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::Grpc.Gateway.ProtocGenSwagger.Options.AnnotationsReflection.Descriptor, global::PKIo.CommonObjectsReflection.Descriptor, global::PKIo.DistributionReflection.Descriptor, global::PKIo.ProjectReflection.Descriptor, global::PKIo.MessageReflection.Descriptor, global::PKIo.JobReflection.Descriptor, global::PKIo.PaginationReflection.Descriptor, global::PKIo.FilterReflection.Descriptor, global::PKIo.IntegrationReflection.Descriptor, global::PKIo.UserReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, null));
    }
    #endregion

  }
}

#endregion Designer generated code