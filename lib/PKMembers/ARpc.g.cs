// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: io/member/a_rpc.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PKMembers {

  /// <summary>Holder for reflection information generated from io/member/a_rpc.proto</summary>
  public static partial class ARpcReflection {

    #region Descriptor
    /// <summary>File descriptor for io/member/a_rpc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ARpcReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVpby9tZW1iZXIvYV9ycGMucHJvdG8SB21lbWJlcnMaHGdvb2dsZS9hcGkv",
            "YW5ub3RhdGlvbnMucHJvdG8aG2dvb2dsZS9wcm90b2J1Zi9lbXB0eS5wcm90",
            "bxoeaW8vY29tbW9uL2NvbW1vbl9vYmplY3RzLnByb3RvGhdpby9jb21tb24v",
            "bWVzc2FnZS5wcm90bxoaaW8vY29tbW9uL3BhZ2luYXRpb24ucHJvdG8aFmlv",
            "L2NvbW1vbi9maWx0ZXIucHJvdG8aFmlvL21lbWJlci9tZW1iZXIucHJvdG8a",
            "F2lvL21lbWJlci9wcm9ncmFtLnByb3RvGhRpby9tZW1iZXIvdGllci5wcm90",
            "bxoscHJvdG9jLWdlbi1zd2FnZ2VyL29wdGlvbnMvYW5ub3RhdGlvbnMucHJv",
            "dG8y/TEKB01lbWJlcnMSfQoNY3JlYXRlUHJvZ3JhbRIQLm1lbWJlcnMuUHJv",
            "Z3JhbRoGLmlvLklkIlKC0+STAhUiEC9tZW1iZXJzL3Byb2dyYW06ASqSQTQK",
            "CFByb2dyYW1zEg5DcmVhdGUgUHJvZ3JhbRoYQ3JlYXRlcyBhIHByb2dyYW0g",
            "cmVjb3JkEpEBCg11cGRhdGVQcm9ncmFtEhAubWVtYmVycy5Qcm9ncmFtGhAu",
            "bWVtYmVycy5Qcm9ncmFtIlyC0+STAhUaEC9tZW1iZXJzL3Byb2dyYW06ASqS",
            "QT4KCFByb2dyYW1zEg5VcGRhdGUgUHJvZ3JhbRoiVXBkYXRlcyBhbiBleGlz",
            "dGluZyBwcm9ncmFtIHJlY29yZBKAAQoKZ2V0UHJvZ3JhbRIGLmlvLklkGhAu",
            "bWVtYmVycy5Qcm9ncmFtIliC0+STAhcSFS9tZW1iZXJzL3Byb2dyYW0ve2lk",
            "fZJBOAoIUHJvZ3JhbXMSC0dldCBQcm9ncmFtGh9HZXRzIGFuIGV4aXN0aW5n",
            "IHByb2dyYW0gcmVjb3JkEpIBCgtjb3B5UHJvZ3JhbRIbLm1lbWJlcnMuUHJv",
            "Z3JhbUNvcHlSZXF1ZXN0GgYuaW8uSWQiXoLT5JMCGiIVL21lbWJlcnMvcHJv",
            "Z3JhbS9jb3B5OgEqkkE7CghQcm9ncmFtcxIMQ29weSBQcm9ncmFtGiFDb3Bp",
            "ZXMgYW4gZXhpc3RpbmcgcHJvZ3JhbSByZWNvcmQSlAIKDWRlbGV0ZVByb2dy",
            "YW0SBi5pby5JZBoWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eSLiAYLT5JMCGioV",
            "L21lbWJlcnMvcHJvZ3JhbS97aWR9OgEqkkG+AQoIUHJvZ3JhbXMSDkRlbGV0",
            "ZSBQcm9ncmFtGqEBRGVsZXRlcyBhbiBleGlzdGluZyBwcm9ncmFtIHJlY29y",
            "ZC4gRGVsZXRpbmcgYSBwcm9ncmFtIHJlc3VsdHMgaW4gYWxsIHRpZXJzLCBh",
            "bmQgbWVtYmVycyB1bmRlcm5lYXRoIGl0IGJlaW5nIGludmFsaWRhdGVkIGFu",
            "ZCByZW1vdmVkLiBOZWVkcyB0byBiZSB1c2VkIHdpdGggY2FyZS4SwAEKFmxp",
            "c3RQcm9ncmFtc0RlcHJlY2F0ZWQSDi5pby5QYWdpbmF0aW9uGhAubWVtYmVy",
            "cy5Qcm9ncmFtIoEBgtPkkwITEhEvbWVtYmVycy9wcm9ncmFtc5JBZQoIUHJv",
            "Z3JhbXMSGkxpc3QgUHJvZ3JhbXMgW0RFUFJFQ0FURURdGj1bREVQUkVDQVRF",
            "RDogT1Igb3BlcmF0b3IgaXMgbm90IHN1cHBvcnRlZF0gTGlzdHMgYWxsIHBy",
            "b2dyYW1zMAESggEKDGxpc3RQcm9ncmFtcxILLmlvLkZpbHRlcnMaEC5tZW1i",
            "ZXJzLlByb2dyYW0iUYLT5JMCGyIWL21lbWJlcnMvcHJvZ3JhbXMvbGlzdDoB",
            "KpJBLQoIUHJvZ3JhbXMSDUxpc3QgUHJvZ3JhbXMaEkxpc3RzIGFsbCBwcm9n",
            "cmFtczABEmgKCmNyZWF0ZVRpZXISDS5tZW1iZXJzLlRpZXIaBi5pby5JZCJD",
            "gtPkkwISIg0vbWVtYmVycy90aWVyOgEqkkEoCgVUaWVycxILQ3JlYXRlIFRp",
            "ZXIaEkNyZWF0ZXMgYSBuZXcgdGllchJ2Cgp1cGRhdGVUaWVyEg0ubWVtYmVy",
            "cy5UaWVyGg0ubWVtYmVycy5UaWVyIkqC0+STAhIaDS9tZW1iZXJzL3RpZXI6",
            "ASqSQS8KBVRpZXJzEgtVcGRhdGUgVGllchoZVXBkYXRlcyBhIHRpZXIgYnkg",
            "dGllciBpZBKXAQoHZ2V0VGllchIZLm1lbWJlcnMuVGllclJlcXVlc3RJbnB1",
            "dBoNLm1lbWJlcnMuVGllciJigtPkkwIkEiIvbWVtYmVycy90aWVyL3twcm9n",
            "cmFtSWR9L3t0aWVySWR9kkE1CgVUaWVycxIIR2V0IFRpZXIaIkdldCBhIHRp",
            "ZXIgYnkgcHJvZ3JhbSBhbmQgdGllciBpZHMS1gEKCmRlbGV0ZVRpZXISGS5t",
            "ZW1iZXJzLlRpZXJSZXF1ZXN0SW5wdXQaFi5nb29nbGUucHJvdG9idWYuRW1w",
            "dHkilAGC0+STAicqIi9tZW1iZXJzL3RpZXIve3Byb2dyYW1JZH0ve3RpZXJJ",
            "ZH06ASqSQWQKBVRpZXJzEgtEZWxldGUgVGllchpORGVsZXRlcyBhIHRpZXIg",
            "YW5kIG1lbWJlcnMgd2hvIGJlbG9uZyB0byB0aGUgdGllci4gTmVlZHMgdG8g",
            "YmUgdXNlZCB3aXRoIGNhcmUuEr0BChNsaXN0VGllcnNEZXByZWNhdGVkEh4u",
            "bWVtYmVycy5MaXN0UmVxdWVzdERlcHJlY2F0ZWQaDS5tZW1iZXJzLlRpZXIi",
            "dYLT5JMCEBIOL21lbWJlcnMvdGllcnOSQVwKBVRpZXJzEhdMaXN0IFRpZXJz",
            "IFtERVBSRUNBVEVEXRo6W0RFUFJFQ0FURUQ6IE9SIG9wZXJhdG9yIGlzIG5v",
            "dCBzdXBwb3J0ZWRdIExpc3RzIGFsbCB0aWVyczABErEBCglsaXN0VGllcnMS",
            "FC5tZW1iZXJzLkxpc3RSZXF1ZXN0Gg0ubWVtYmVycy5UaWVyIn2C0+STAhgi",
            "Ey9tZW1iZXJzL3RpZXJzL2xpc3Q6ASqSQVwKBVRpZXJzEhdMaXN0IFRpZXJz",
            "IFtERVBSRUNBVEVEXRo6W0RFUFJFQ0FURUQ6IE9SIG9wZXJhdG9yIGlzIG5v",
            "dCBzdXBwb3J0ZWRdIExpc3RzIGFsbCB0aWVyczABEnUKC2Vucm9sTWVtYmVy",
            "Eg8ubWVtYmVycy5NZW1iZXIaBi5pby5JZCJNgtPkkwIUIg8vbWVtYmVycy9t",
            "ZW1iZXI6ASqSQTAKB01lbWJlcnMSEEVucm9sIG5ldyBNZW1iZXIaE0Vucm9s",
            "cyBhIG5ldyBtZW1iZXISvgEKEWVucm9sTWVtYmVyUHVibGljEg8ubWVtYmVy",
            "cy5NZW1iZXIaBi5pby5JZCKPAYLT5JMCGyIWL21lbWJlcnMvbWVtYmVyL3B1",
            "YmxpYzoBKpJBawoHTWVtYmVycxIZRW5yb2wgbmV3IE1lbWJlciAocHVibGlj",
            "KRpFRW5yb2xzIGEgbmV3IG1lbWJlciBpbnRvIHRoZSBkZWZhdWx0IHRpZXIg",
            "b2YgYSBwcm9ncmFtIHRoYXQgaXMgcHVibGljEp4BChNnZXRNZW1iZXJSZWNv",
            "cmRCeUlkEgYuaW8uSWQaDy5tZW1iZXJzLk1lbWJlciJugtPkkwIZEhcvbWVt",
            "YmVycy9tZW1iZXIvaWQve2lkfZJBTAoHTWVtYmVycxIfR2V0IG1lbWJlciBy",
            "ZWNvcmQgYnkgUGFzc0tpdCBJRBogR2V0cyBtZW1iZXIgcmVjb3JkIGJ5IFBh",
            "c3NLaXQgSUQS5wEKG2dldE1lbWJlclJlY29yZEJ5RXh0ZXJuYWxJZBIoLm1l",
            "bWJlcnMuTWVtYmVyUmVjb3JkQnlFeHRlcm5hbElkUmVxdWVzdBoPLm1lbWJl",
            "cnMuTWVtYmVyIowBgtPkkwI1EjMvbWVtYmVycy9tZW1iZXIvZXh0ZXJuYWxJ",
            "ZC97cHJvZ3JhbUlkfS97ZXh0ZXJuYWxJZH2SQU4KB01lbWJlcnMSIEdldCBt",
            "ZW1iZXIgcmVjb3JkIGJ5IEV4dGVybmFsIElEGiFHZXRzIG1lbWJlciByZWNv",
            "cmQgYnkgRXh0ZXJuYWwgSUQSzAEKDWNoZWNrSW5NZW1iZXISIC5tZW1iZXJz",
            "Lk1lbWJlckNoZWNrSW5PdXRSZXF1ZXN0GhYuZ29vZ2xlLnByb3RvYnVmLkVt",
            "cHR5IoABgtPkkwIcIhcvbWVtYmVycy9tZW1iZXIvY2hlY2tJbjoBKpJBWwoH",
            "TWVtYmVycxIPQ2hlY2sgaW4gbWVtYmVyGj9DaGVja3MgaW4gYSBtZW1iZXIg",
            "YnkgZWl0aGVyIGludGVybmFsIFBhc3NLaXQgSUQgb3IgRXh0ZXJuYWwgSUQS",
            "0AEKDmNoZWNrT3V0TWVtYmVyEiAubWVtYmVycy5NZW1iZXJDaGVja0luT3V0",
            "UmVxdWVzdBoWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eSKDAYLT5JMCHSIYL21l",
            "bWJlcnMvbWVtYmVyL2NoZWNrT3V0OgEqkkFdCgdNZW1iZXJzEhBDaGVjayBv",
            "dXQgbWVtYmVyGkBDaGVja3Mgb3V0IGEgbWVtYmVyIGJ5IGVpdGhlciBpbnRl",
            "cm5hbCBQYXNzS2l0IElEIG9yIEV4dGVybmFsIElEEoQCChVsaXN0TWVtYmVy",
            "c0RlcHJlY2F0ZWQSHi5tZW1iZXJzLkxpc3RSZXF1ZXN0RGVwcmVjYXRlZBoP",
            "Lm1lbWJlcnMuTWVtYmVyIrcBgtPkkwIiEiAvbWVtYmVycy9tZW1iZXIvbGlz",
            "dC97cHJvZ3JhbUlkfZJBiwEKB01lbWJlcnMSGUxpc3QgbWVtYmVycyBbREVQ",
            "UkVDQVRFRF0aZVtERVBSRUNBVEVEOiBPUiBvcGVyYXRvciBpcyBub3Qgc3Vw",
            "cG9ydGVkXSBMaXN0IGFsbCBtZW1iZXJzIGZvciBhIGdpdmVuIHNlZ21lbnQu",
            "IFN1cHBvcnRzIHBhZ2luYXRpb24uMAESugEKC2xpc3RNZW1iZXJzEhQubWVt",
            "YmVycy5MaXN0UmVxdWVzdBoPLm1lbWJlcnMuTWVtYmVyIoEBgtPkkwIlIiAv",
            "bWVtYmVycy9tZW1iZXIvbGlzdC97cHJvZ3JhbUlkfToBKpJBUwoHTWVtYmVy",
            "cxIMTGlzdCBtZW1iZXJzGjpMaXN0IGFsbCBtZW1iZXJzIGZvciBhIGdpdmVu",
            "IHNlZ21lbnQuIFN1cHBvcnRzIHBhZ2luYXRpb24uMAESmwEKDHVwZGF0ZU1l",
            "bWJlchIPLm1lbWJlcnMuTWVtYmVyGgYuaW8uSWQicoLT5JMCFBoPL21lbWJl",
            "cnMvbWVtYmVyOgEqkkFVCgdNZW1iZXJzEg1VcGRhdGUgbWVtYmVyGjtVcGRh",
            "dGVzIG1lbWJlciBieSBlaXRoZXIgaW50ZXJuYWwgUGFzc0tpdCBJRCBvciBF",
            "eHRlcm5hbCBJRBLmAQoKZWFyblBvaW50cxIeLm1lbWJlcnMuRWFybkJ1cm5Q",
            "b2ludHNSZXF1ZXN0GhUubWVtYmVycy5NZW1iZXJQb2ludHMioAGC0+STAiAa",
            "Gy9tZW1iZXJzL21lbWJlci9wb2ludHMvZWFybjoBKpJBdwoHTWVtYmVycxIL",
            "RWFybiBwb2ludHMaX0Vhcm5zIHBvaW50cyBmb3IgYSBtZW1iZXIgKGlkZW50",
            "aWZpZWQgYnkgUGFzc0tpdCBJRCBvciBFeHRlcm5hbCBJRCkuIEFkZHMgdGhl",
            "IGFtb3VudHMgcHJvdmlkZWQuEugBCgpidXJuUG9pbnRzEh4ubWVtYmVycy5F",
            "YXJuQnVyblBvaW50c1JlcXVlc3QaFS5tZW1iZXJzLk1lbWJlclBvaW50cyKi",
            "AYLT5JMCIBobL21lbWJlcnMvbWVtYmVyL3BvaW50cy9idXJuOgEqkkF5CgdN",
            "ZW1iZXJzEgtCdXJuIHBvaW50cxphQnVybiBwb2ludHMgZm9yIGEgbWVtYmVy",
            "IChpZGVudGlmaWVkIGJ5IFBhc3NLaXQgSUQgb3IgRXh0ZXJuYWwgSUQpLiBE",
            "ZWR1Y3RzIHRoZSBhbW91bnRzIHByb3ZpZGVkLhLcAQoJc2V0UG9pbnRzEhku",
            "bWVtYmVycy5TZXRQb2ludHNSZXF1ZXN0GhUubWVtYmVycy5NZW1iZXJQb2lu",
            "dHMinAGC0+STAh8aGi9tZW1iZXJzL21lbWJlci9wb2ludHMvc2V0OgEqkkF0",
            "CgdNZW1iZXJzEgpTZXQgcG9pbnRzGl1TZXQgcG9pbnRzIGZvciBhIG1lbWJl",
            "ciAoaWRlbnRpZmllZCBieSBQYXNzS2l0IElEIG9yIEV4dGVybmFsIElEKS4g",
            "U2V0cyB0aGUgYW1vdW50cyBwcm92aWRlZC4StgEKFnVwZGF0ZU1lbWJlcnNC",
            "eVNlZ21lbnQSHS5tZW1iZXJzLk1lbWJlclNlZ21lbnRSZXF1ZXN0GhYuZ29v",
            "Z2xlLnByb3RvYnVmLkVtcHR5ImWC0+STAhwaFy9tZW1iZXJzL21lbWJlci9z",
            "ZWdtZW50OgEqkkFACgdNZW1iZXJzEhlVcGRhdGUgbWVtYmVycyBieSBzZWdt",
            "ZW50GhpVcGRhdGVzIG1lbWJlcnMgYnkgc2VnbWVudBK2AQoWZGVsZXRlTWVt",
            "YmVyc0J5U2VnbWVudBIdLm1lbWJlcnMuTWVtYmVyU2VnbWVudFJlcXVlc3Qa",
            "Fi5nb29nbGUucHJvdG9idWYuRW1wdHkiZYLT5JMCHCoXL21lbWJlcnMvbWVt",
            "YmVyL3NlZ21lbnQ6ASqSQUAKB01lbWJlcnMSGURlbGV0ZSBtZW1iZXJzIGJ5",
            "IHNlZ21lbnQaGkRlbGV0ZXMgbWVtYmVycyBieSBzZWdtZW50EqsBCgxkZWxl",
            "dGVNZW1iZXISDy5tZW1iZXJzLk1lbWJlchoWLmdvb2dsZS5wcm90b2J1Zi5F",
            "bXB0eSJygtPkkwIUKg8vbWVtYmVycy9tZW1iZXI6ASqSQVUKB01lbWJlcnMS",
            "DURlbGV0ZSBtZW1iZXIaO0RlbGV0ZXMgbWVtYmVyIGJ5IGVpdGhlciBpbnRl",
            "cm5hbCBQYXNzS2l0IElEIG9yIEV4dGVybmFsIElEErECChZjb3VudE1lbWJl",
            "cnNEZXByZWNhdGVkEh4ubWVtYmVycy5MaXN0UmVxdWVzdERlcHJlY2F0ZWQa",
            "CS5pby5Db3VudCLrAYLT5JMCHBIaL21lbWJlcnMvY291bnQve3Byb2dyYW1J",
            "ZH2SQcUBCgdNZW1iZXJzEiNDb3VudCBGaWx0ZXJlZCBNZW1iZXJzIFtERVBS",
            "RUNBVEVEXRpRW0RFUFJFQ0FURUQ6IE9SIG9wZXJhdG9yIGlzIG5vdCBzdXBw",
            "b3J0ZWRdIFJldHJpZXZlcyBhIGNvdW50IG9mIGZpbHRlcmVkIG1lbWJlcnMu",
            "SiIKAzQwMxIbChlVc2VyIGxhY2tzIGF1dGhvcml6YXRpb24uSh4KAzQwNBIX",
            "ChVSZWNvcmQgd2FzIG5vdCBmb3VuZC4S6AEKDGNvdW50TWVtYmVycxIULm1l",
            "bWJlcnMuTGlzdFJlcXVlc3QaCS5pby5Db3VudCK2AYLT5JMCHyIaL21lbWJl",
            "cnMvY291bnQve3Byb2dyYW1JZH06ASqSQY0BCgdNZW1iZXJzEhZDb3VudCBG",
            "aWx0ZXJlZCBNZW1iZXJzGiZSZXRyaWV2ZXMgYSBjb3VudCBvZiBmaWx0ZXJl",
            "ZCBtZW1iZXJzLkoiCgM0MDMSGwoZVXNlciBsYWNrcyBhdXRob3JpemF0aW9u",
            "LkoeCgM0MDQSFwoVUmVjb3JkIHdhcyBub3QgZm91bmQuEtIBChpnZXRNZXNz",
            "YWdlSGlzdG9yeUZvck1lbWJlchIOLmlvLlBhZ2luYXRpb24aCy5pby5NZXNz",
            "YWdlIpQBgtPkkwIaEhgvbWVtYmVycy9tZW1iZXIvbWVzc2FnZXOSQXEKB01l",
            "bWJlcnMSG0dldCBtZW1iZXJzIG1lc3NhZ2UgaGlzdG9yeRpJR2V0IGFsbCB0",
            "aGUgbWVzc2FnZSB0aGF0IGhhdmUgYmVlbiBzZW50IHRvIGEgbWVtYmVyLiBT",
            "dXBwb3J0cyBwYWdpbmF0aW9uLjABEtoBChVnZXRNZXRhS2V5c0ZvclByb2dy",
            "YW0SBi5pby5JZBoLLmlvLlN0cmluZ3MiqwGC0+STAhsSGS9tZW1iZXJzL21l",
            "bWJlci9tZXRhL3tpZH2SQYYBCgdNZW1iZXJzEhtHZXQgTWV0YSBLZXlzIGZv",
            "ciBhIFByb2dyYW0aXlJldHVybnMgYSBsaXN0IG9mIGRpc3RpbmN0IG1ldGEg",
            "ZmllbGQga2V5cy4gQ2FuIGJlIHVzZWQgZm9yIGJ1aWxkaW5nIGZpbHRlcnMg",
            "LyB0YWJsZSBoZWFkaW5ncy4SswIKEnJlbmV3TWVtYmVyc0V4cGlyeRIcLm1l",
            "bWJlcnMuVXBkYXRlRXhwaXJ5UmVxdWVzdBoJLmlvLkNvdW50IvMBgtPkkwIb",
            "GhYvbWVtYmVycy9tZW1iZXIvZXhwaXJ5OgEqkkHOAQoHTWVtYmVycxIaQmF0",
            "Y2ggdXBkYXRlIG1lbWJlciBleHBpcnkapgFCYXRjaCB1cGRhdGVzIGV4cGly",
            "eSBvZiBBTEwgYWN0aXZlIG1lbWJlcnMgYmVsb25nIHRvIHRoZSB0aWVyLiBT",
            "aG91bGQgb25seSBiZSB1c2VkIHdoZW4geW91IHdhbnQgdG8gdXBkYXRlIEFM",
            "TCB0aGUgZXhwaXJ5IGRhdGUgZm9yIGFsbCBtZW1iZXIgcmVjb3JkcyBpbiBh",
            "IGdpdmVuIHRpZXIuQsAGChdpby5wYXNza2l0LlBLaW8uTWVtYmVyc1osc3Rh",
            "c2gucGFzc2tpdC5jb20vaW8vbW9kZWwvc2RrL2dvL2lvL21lbWJlcnOqAglQ",
            "S01lbWJlcnOSQekFEoYCChNQYXNzS2l0IE1lbWJlcnMgQVBJEmxUaGUgUGFz",
            "c0tpdCBNZW1iZXJzIEFQSSBsZXRzIHlvdSBtYW5hZ2UgeW91ciBtZW1iZXJz",
            "aGlwIHByb2dyYW1zIGFuZCBwYXNzZXMgZm9yIEFwcGxlIFdhbGxldCBhbmQg",
            "R29vZ2xlIFBheS4aOGh0dHBzOi8vcGFzc2tpdC5jb20vbGVnYWwvdGVybXMt",
            "b2Ytc3Vic2NyaXB0aW9uLXNlcnZpY2UvIj8KD1Bhc3NLaXQgU3VwcG9ydBIX",
            "aHR0cHM6Ly9kb2NzLnBhc3NraXQuaW8aE3N1cHBvcnRAcGFzc2tpdC5jb20y",
            "BjEuMC1yYyoBAjIQYXBwbGljYXRpb24vanNvbjoQYXBwbGljYXRpb24vanNv",
            "blI5CgMyMDASMgooUmV0dXJuZWQgd2hlbiB0aGUgcmVxdWVzdCBpcyBzdWNj",
            "ZXNzZnVsLhIGCgSaAgEHUlAKAzQwMxJJCkdSZXR1cm5lZCB3aGVuIHRoZSB1",
            "c2VyIGRvZXMgbm90IGhhdmUgcGVybWlzc2lvbiB0byBhY2Nlc3MgdGhlIHJl",
            "c291cmNlLlI7CgM0MDQSNAoqUmV0dXJuZWQgd2hlbiB0aGUgcmVzb3VyY2Ug",
            "ZG9lcyBub3QgZXhpc3QuEgYKBJoCAQdSPAoDNTAwEjUKK1JldHVybmVkIHdo",
            "ZW4gdGhlcmUgaXMgYW4gdW5leHBlY3RlZCBlcnJvci4SBgoEmgIBB1JdCgM1",
            "MDMSVgpUUmV0dXJuZWQgd2hlbiB0aGUgdXNlciBpcyBiZWluZyB0aHJvdHRs",
            "ZWQuIEJhY2sgb2ZmIGZvciBhIGZldyBtcyBhbmQgdGhlbiB0cnkgYWdhaW4u",
            "Wj4KPAoKYXBpS2V5QXV0aBIuCAISGUpXVCBBdXRoZW50aWNhdGlvbiB0b2tl",
            "bi4aDUF1dGhvcml6YXRpb24gAmIQCg4KCmFwaUtleUF1dGgSAGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::PKIo.CommonObjectsReflection.Descriptor, global::PKIo.MessageReflection.Descriptor, global::PKIo.PaginationReflection.Descriptor, global::PKIo.FilterReflection.Descriptor, global::PKMembers.MemberReflection.Descriptor, global::PKMembers.ProgramReflection.Descriptor, global::PKMembers.TierReflection.Descriptor, global::Grpc.Gateway.ProtocGenSwagger.Options.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, null));
    }
    #endregion

  }
}

#endregion Designer generated code