// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: io/common/localization.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PassKit.Grpc {

  /// <summary>Holder for reflection information generated from io/common/localization.proto</summary>
  public static partial class LocalizationReflection {

    #region Descriptor
    /// <summary>File descriptor for io/common/localization.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LocalizationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chxpby9jb21tb24vbG9jYWxpemF0aW9uLnByb3RvEgJpbyKDAQoPTG9jYWxp",
            "emVkU3RyaW5nEjsKDHRyYW5zbGF0aW9ucxgBIAMoCzIlLmlvLkxvY2FsaXpl",
            "ZFN0cmluZy5UcmFuc2xhdGlvbnNFbnRyeRozChFUcmFuc2xhdGlvbnNFbnRy",
            "eRILCgNrZXkYASABKAkSDQoFdmFsdWUYAiABKAk6AjgBKpcDCgxMYW5ndWFn",
            "ZUNvZGUSBgoCRU4QABIGCgJBUhAEEgsKB1pIX0hBTlMQCBILCgdaSF9IQU5U",
            "EAwSCQoFWkhfSEsQEBIGCgJDQRAUEgYKAkhSEBgSBgoCQ1MQHBIGCgJEQRAg",
            "EgYKAkRFECQSCQoFRU5fQVUQKBIJCgVFTl9HQhAsEgkKBUVOX0NBEDASCQoF",
            "RU5fVVMQNBIJCgVFTl9JThA4EgYKAkVTEDwSCgoGRVNfNDE5EEASBgoCRkkQ",
            "RBIGCgJGUhBIEgkKBUZSX0NBEEwSBgoCRUwQUBIGCgJIRRBUEgYKAkhJEFgS",
            "BgoCSFUQXBIGCgJJRBBgEgYKAklUEGQSBgoCSkEQaBIGCgJLTxBsEgYKAk1T",
            "EHASBgoCTVQQdBIGCgJOTBB4EgYKAk5CEHwSBwoCUEwQgAESBwoCUFQQhAES",
            "CgoFUFRfQlIQiAESBwoCUk8QjAESBwoCUlUQkAESBwoCU0sQlAESBwoCU1YQ",
            "mAESBwoCVEgQnAESBwoCVFIQoAESBwoCVUsQpAESBwoCVkkQqAFCRwoQY29t",
            "LnBhc3NraXQuZ3JwY1okc3Rhc2gucGFzc2tpdC5jb20vaW8vbW9kZWwvc2Rr",
            "L2dvL2lvqgIMUGFzc0tpdC5HcnBjYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::PassKit.Grpc.LanguageCode), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PassKit.Grpc.LocalizedString), global::PassKit.Grpc.LocalizedString.Parser, new[]{ "Translations" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// This is a list of supported languages.
  /// </summary>
  public enum LanguageCode {
    /// <summary>
    /// English
    /// </summary>
    [pbr::OriginalName("EN")] En = 0,
    /// <summary>
    /// (Arabic) العربية
    /// </summary>
    [pbr::OriginalName("AR")] Ar = 4,
    /// <summary>
    /// 简体中文 (Chinese)
    /// </summary>
    [pbr::OriginalName("ZH_HANS")] ZhHans = 8,
    /// <summary>
    /// 繁體中文 (Traditional Chinese)
    /// </summary>
    [pbr::OriginalName("ZH_HANT")] ZhHant = 12,
    /// <summary>
    /// 香港中文 (Cantonese)
    /// </summary>
    [pbr::OriginalName("ZH_HK")] ZhHk = 16,
    /// <summary>
    /// Català (Catalan)
    /// </summary>
    [pbr::OriginalName("CA")] Ca = 20,
    /// <summary>
    /// Hrvatski (Croatian)
    /// </summary>
    [pbr::OriginalName("HR")] Hr = 24,
    /// <summary>
    /// Čeština (Czech)
    /// </summary>
    [pbr::OriginalName("CS")] Cs = 28,
    /// <summary>
    /// Dansk (Danish)
    /// </summary>
    [pbr::OriginalName("DA")] Da = 32,
    /// <summary>
    /// Deutsch (German)
    /// </summary>
    [pbr::OriginalName("DE")] De = 36,
    /// <summary>
    /// English (Australia)
    /// </summary>
    [pbr::OriginalName("EN_AU")] EnAu = 40,
    /// <summary>
    /// English (British)
    /// </summary>
    [pbr::OriginalName("EN_GB")] EnGb = 44,
    /// <summary>
    /// English (Canada)
    /// </summary>
    [pbr::OriginalName("EN_CA")] EnCa = 48,
    /// <summary>
    /// English (India)
    /// </summary>
    [pbr::OriginalName("EN_US")] EnUs = 52,
    /// <summary>
    /// English (United States)
    /// </summary>
    [pbr::OriginalName("EN_IN")] EnIn = 56,
    /// <summary>
    /// Español (Spanish)
    /// </summary>
    [pbr::OriginalName("ES")] Es = 60,
    /// <summary>
    /// Español (Latin America)
    /// </summary>
    [pbr::OriginalName("ES_419")] Es419 = 64,
    /// <summary>
    /// Suomi (Finnish)
    /// </summary>
    [pbr::OriginalName("FI")] Fi = 68,
    /// <summary>
    /// Français (French)
    /// </summary>
    [pbr::OriginalName("FR")] Fr = 72,
    /// <summary>
    /// Français (Canada)
    /// </summary>
    [pbr::OriginalName("FR_CA")] FrCa = 76,
    /// <summary>
    /// Ελληνικά (Greek)
    /// </summary>
    [pbr::OriginalName("EL")] El = 80,
    /// <summary>
    /// (Hebrew) עברית
    /// </summary>
    [pbr::OriginalName("HE")] He = 84,
    /// <summary>
    /// हिन्दी (Hindi)
    /// </summary>
    [pbr::OriginalName("HI")] Hi = 88,
    /// <summary>
    /// Magyar (Hungarian)
    /// </summary>
    [pbr::OriginalName("HU")] Hu = 92,
    /// <summary>
    /// Bahasa Indonesia (Indonesian)
    /// </summary>
    [pbr::OriginalName("ID")] Id = 96,
    /// <summary>
    /// Italiano (Italian)
    /// </summary>
    [pbr::OriginalName("IT")] It = 100,
    /// <summary>
    /// 日本語 (Japanese)
    /// </summary>
    [pbr::OriginalName("JA")] Ja = 104,
    /// <summary>
    /// 한국어 (Korean)
    /// </summary>
    [pbr::OriginalName("KO")] Ko = 108,
    /// <summary>
    /// Bahasa Melayu (Malay)
    /// </summary>
    [pbr::OriginalName("MS")] Ms = 112,
    /// <summary>
    /// Malti (Maltese)
    /// </summary>
    [pbr::OriginalName("MT")] Mt = 116,
    /// <summary>
    /// Nederlands (Dutch)
    /// </summary>
    [pbr::OriginalName("NL")] Nl = 120,
    /// <summary>
    /// Norsk Bokmål (Norwegian)
    /// </summary>
    [pbr::OriginalName("NB")] Nb = 124,
    /// <summary>
    /// Polski (Polish)
    /// </summary>
    [pbr::OriginalName("PL")] Pl = 128,
    /// <summary>
    /// Português de Portugal (Portuguese)
    /// </summary>
    [pbr::OriginalName("PT")] Pt = 132,
    /// <summary>
    /// Português (Brazilian Portuguese)
    /// </summary>
    [pbr::OriginalName("PT_BR")] PtBr = 136,
    /// <summary>
    /// Română (Romanian)
    /// </summary>
    [pbr::OriginalName("RO")] Ro = 140,
    /// <summary>
    /// Русский (Russian)
    /// </summary>
    [pbr::OriginalName("RU")] Ru = 144,
    /// <summary>
    /// Slovenčina (Slovakian)
    /// </summary>
    [pbr::OriginalName("SK")] Sk = 148,
    /// <summary>
    /// Svenska (Swedish)
    /// </summary>
    [pbr::OriginalName("SV")] Sv = 152,
    /// <summary>
    /// ภาษาไทย (Thai)
    /// </summary>
    [pbr::OriginalName("TH")] Th = 156,
    /// <summary>
    /// Türkçe (Turkish)
    /// </summary>
    [pbr::OriginalName("TR")] Tr = 160,
    /// <summary>
    /// Українська (Ukrainian)
    /// </summary>
    [pbr::OriginalName("UK")] Uk = 164,
    /// <summary>
    /// Tiếng Việt (Vietnamese)
    /// </summary>
    [pbr::OriginalName("VI")] Vi = 168,
  }

  #endregion

  #region Messages
  /// <summary>
  /// Localized strings are optionally used to provide translated values for each of supported language.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class LocalizedString : pb::IMessage<LocalizedString>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LocalizedString> _parser = new pb::MessageParser<LocalizedString>(() => new LocalizedString());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LocalizedString> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::PassKit.Grpc.LocalizationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LocalizedString() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LocalizedString(LocalizedString other) : this() {
      translations_ = other.translations_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LocalizedString Clone() {
      return new LocalizedString(this);
    }

    /// <summary>Field number for the "translations" field.</summary>
    public const int TranslationsFieldNumber = 1;
    private static readonly pbc::MapField<string, string>.Codec _map_translations_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 10);
    private readonly pbc::MapField<string, string> translations_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Translations key is a valid LanguageCode. The value represents the translated string.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, string> Translations {
      get { return translations_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LocalizedString);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LocalizedString other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!Translations.Equals(other.Translations)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= Translations.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      translations_.WriteTo(output, _map_translations_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      translations_.WriteTo(ref output, _map_translations_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += translations_.CalculateSize(_map_translations_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LocalizedString other) {
      if (other == null) {
        return;
      }
      translations_.MergeFrom(other.translations_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            translations_.AddEntriesFrom(input, _map_translations_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            translations_.AddEntriesFrom(ref input, _map_translations_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
