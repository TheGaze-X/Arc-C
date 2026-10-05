using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Il2CppDummyDll;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x02000024 RID: 36
	[Token(Token = "0x2000024")]
	[Preserve]
	public class JsonSerializerSettings
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600006C RID: 108 RVA: 0x000021A8 File Offset: 0x000003A8
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700001A")]
		public ReferenceLoopHandling ReferenceLoopHandling
		{
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x4D6C730", Offset = "0x4D6B330", VA = "0x184D6C730")]
			get
			{
				return ReferenceLoopHandling.Error;
			}
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x4D6CF80", Offset = "0x4D6BB80", VA = "0x184D6CF80")]
			set
			{
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600006E RID: 110 RVA: 0x000021C0 File Offset: 0x000003C0
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700001B")]
		public MissingMemberHandling MissingMemberHandling
		{
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x4D6C5F0", Offset = "0x4D6B1F0", VA = "0x184D6C5F0")]
			get
			{
				return MissingMemberHandling.Ignore;
			}
			[Token(Token = "0x600006F")]
			[Address(RVA = "0x4D6CE00", Offset = "0x4D6BA00", VA = "0x184D6CE00")]
			set
			{
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000021D8 File Offset: 0x000003D8
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700001C")]
		public ObjectCreationHandling ObjectCreationHandling
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x4D6C690", Offset = "0x4D6B290", VA = "0x184D6C690")]
			get
			{
				return ObjectCreationHandling.Auto;
			}
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x4D6CEC0", Offset = "0x4D6BAC0", VA = "0x184D6CEC0")]
			set
			{
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000021F0 File Offset: 0x000003F0
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700001D")]
		public NullValueHandling NullValueHandling
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x4D6C640", Offset = "0x4D6B240", VA = "0x184D6C640")]
			get
			{
				return NullValueHandling.Include;
			}
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x4D6CE60", Offset = "0x4D6BA60", VA = "0x184D6CE60")]
			set
			{
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00002208 File Offset: 0x00000408
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700001E")]
		public DefaultValueHandling DefaultValueHandling
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x4D6C440", Offset = "0x4D6B040", VA = "0x184D6C440")]
			get
			{
				return DefaultValueHandling.Include;
			}
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x4D6CB50", Offset = "0x4D6B750", VA = "0x184D6CB50")]
			set
			{
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700001F")]
		public IList<JsonConverter> Converters
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x2569110", Offset = "0x2567D10", VA = "0x182569110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x4D6CA00", Offset = "0x4D6B600", VA = "0x184D6CA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00002220 File Offset: 0x00000420
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000020")]
		public PreserveReferencesHandling PreserveReferencesHandling
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x4D6C6E0", Offset = "0x4D6B2E0", VA = "0x184D6C6E0")]
			get
			{
				return PreserveReferencesHandling.None;
			}
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x4D6CF20", Offset = "0x4D6BB20", VA = "0x184D6CF20")]
			set
			{
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00002238 File Offset: 0x00000438
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000021")]
		public TypeNameHandling TypeNameHandling
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x4D6C860", Offset = "0x4D6B460", VA = "0x184D6C860")]
			get
			{
				return TypeNameHandling.None;
			}
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x4D6D1B0", Offset = "0x4D6BDB0", VA = "0x184D6D1B0")]
			set
			{
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00002250 File Offset: 0x00000450
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000022")]
		public MetadataPropertyHandling MetadataPropertyHandling
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x4D6C5A0", Offset = "0x4D6B1A0", VA = "0x184D6C5A0")]
			get
			{
				return MetadataPropertyHandling.Default;
			}
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x4D6CDA0", Offset = "0x4D6B9A0", VA = "0x184D6CDA0")]
			set
			{
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00002268 File Offset: 0x00000468
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000023")]
		public FormatterAssemblyStyle TypeNameAssemblyFormat
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x4D6C810", Offset = "0x4D6B410", VA = "0x184D6C810")]
			get
			{
				return FormatterAssemblyStyle.Simple;
			}
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x4D6D150", Offset = "0x4D6BD50", VA = "0x184D6D150")]
			set
			{
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00002280 File Offset: 0x00000480
		// (set) Token: 0x06000081 RID: 129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000024")]
		public ConstructorHandling ConstructorHandling
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x4D6C1A0", Offset = "0x4D6ADA0", VA = "0x184D6C1A0")]
			get
			{
				return ConstructorHandling.Default;
			}
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x4D6C910", Offset = "0x4D6B510", VA = "0x184D6C910")]
			set
			{
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000025")]
		public IContractResolver ContractResolver
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x371A260", Offset = "0x3718E60", VA = "0x18371A260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x371A3C0", Offset = "0x3718FC0", VA = "0x18371A3C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000026")]
		public IEqualityComparer EqualityComparer
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x4D6C490", Offset = "0x4D6B090", VA = "0x184D6C490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x4D6CBB0", Offset = "0x4D6B7B0", VA = "0x184D6CBB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000027")]
		[Obsolete("ReferenceResolver property is obsolete. Use the ReferenceResolverProvider property to set the IReferenceResolver: settings.ReferenceResolverProvider = () => resolver")]
		public IReferenceResolver ReferenceResolver
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x4D6C790", Offset = "0x4D6B390", VA = "0x184D6C790")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x4D6CFF0", Offset = "0x4D6BBF0", VA = "0x184D6CFF0")]
			set
			{
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000028")]
		public Func<IReferenceResolver> ReferenceResolverProvider
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x4D6C780", Offset = "0x4D6B380", VA = "0x184D6C780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x4D6CFE0", Offset = "0x4D6BBE0", VA = "0x184D6CFE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000029")]
		public ITraceWriter TraceWriter
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x4D6C800", Offset = "0x4D6B400", VA = "0x184D6C800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x4D6D140", Offset = "0x4D6BD40", VA = "0x184D6D140")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700002A")]
		public SerializationBinder Binder
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x22F8880", Offset = "0x22F7480", VA = "0x1822F8880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x22F8A90", Offset = "0x22F7690", VA = "0x1822F8A90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700002B")]
		public EventHandler<ErrorEventArgs> Error
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x22F8840", Offset = "0x22F7440", VA = "0x1822F8840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x22F8A40", Offset = "0x22F7640", VA = "0x1822F8A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00002298 File Offset: 0x00000498
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700002C")]
		public StreamingContext Context
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x4D6C1F0", Offset = "0x4D6ADF0", VA = "0x184D6C1F0")]
			get
			{
				return default(StreamingContext);
			}
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x4D6C970", Offset = "0x4D6B570", VA = "0x184D6C970")]
			set
			{
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700002D")]
		public string DateFormatString
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x4D6C360", Offset = "0x4D6AF60", VA = "0x184D6C360")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x4D6CA70", Offset = "0x4D6B670", VA = "0x184D6CA70")]
			set
			{
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000094 RID: 148 RVA: 0x000022B0 File Offset: 0x000004B0
		// (set) Token: 0x06000095 RID: 149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700002E")]
		public int? MaxDepth
		{
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x4D6C590", Offset = "0x4D6B190", VA = "0x184D6C590")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x4D6CCE0", Offset = "0x4D6B8E0", VA = "0x184D6CCE0")]
			set
			{
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000096 RID: 150 RVA: 0x000022C8 File Offset: 0x000004C8
		// (set) Token: 0x06000097 RID: 151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700002F")]
		public Formatting Formatting
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x4D6C540", Offset = "0x4D6B140", VA = "0x184D6C540")]
			get
			{
				return Formatting.None;
			}
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x4D6CC80", Offset = "0x4D6B880", VA = "0x184D6CC80")]
			set
			{
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000098 RID: 152 RVA: 0x000022E0 File Offset: 0x000004E0
		// (set) Token: 0x06000099 RID: 153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000030")]
		public DateFormatHandling DateFormatHandling
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x4D6C310", Offset = "0x4D6AF10", VA = "0x184D6C310")]
			get
			{
				return DateFormatHandling.IsoDateFormat;
			}
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x4D6CA10", Offset = "0x4D6B610", VA = "0x184D6CA10")]
			set
			{
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600009A RID: 154 RVA: 0x000022F8 File Offset: 0x000004F8
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000031")]
		public DateTimeZoneHandling DateTimeZoneHandling
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x4D6C3F0", Offset = "0x4D6AFF0", VA = "0x184D6C3F0")]
			get
			{
				return DateTimeZoneHandling.Local;
			}
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x4D6CAF0", Offset = "0x4D6B6F0", VA = "0x184D6CAF0")]
			set
			{
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00002310 File Offset: 0x00000510
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000032")]
		public DateParseHandling DateParseHandling
		{
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x4D6C3A0", Offset = "0x4D6AFA0", VA = "0x184D6C3A0")]
			get
			{
				return DateParseHandling.None;
			}
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x4D6CA90", Offset = "0x4D6B690", VA = "0x184D6CA90")]
			set
			{
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00002328 File Offset: 0x00000528
		// (set) Token: 0x0600009F RID: 159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000033")]
		public FloatFormatHandling FloatFormatHandling
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x4D6C4A0", Offset = "0x4D6B0A0", VA = "0x184D6C4A0")]
			get
			{
				return FloatFormatHandling.String;
			}
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x4D6CBC0", Offset = "0x4D6B7C0", VA = "0x184D6CBC0")]
			set
			{
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00002340 File Offset: 0x00000540
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000034")]
		public FloatParseHandling FloatParseHandling
		{
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x4D6C4F0", Offset = "0x4D6B0F0", VA = "0x184D6C4F0")]
			get
			{
				return FloatParseHandling.Double;
			}
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x4D6CC20", Offset = "0x4D6B820", VA = "0x184D6CC20")]
			set
			{
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00002358 File Offset: 0x00000558
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000035")]
		public StringEscapeHandling StringEscapeHandling
		{
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x4D6C7B0", Offset = "0x4D6B3B0", VA = "0x184D6C7B0")]
			get
			{
				return StringEscapeHandling.Default;
			}
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x4D6D0E0", Offset = "0x4D6BCE0", VA = "0x184D6D0E0")]
			set
			{
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000036")]
		public CultureInfo Culture
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x4D6C2B0", Offset = "0x4D6AEB0", VA = "0x184D6C2B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30")]
			set
			{
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00002370 File Offset: 0x00000570
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000037")]
		public bool CheckAdditionalContent
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x4D6C150", Offset = "0x4D6AD50", VA = "0x184D6C150")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x4D6C8B0", Offset = "0x4D6B4B0", VA = "0x184D6C8B0")]
			set
			{
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x4D6BF90", Offset = "0x4D6AB90", VA = "0x184D6BF90")]
		public JsonSerializerSettings()
		{
		}

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		internal const ReferenceLoopHandling DefaultReferenceLoopHandling = ReferenceLoopHandling.Error;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		internal const MissingMemberHandling DefaultMissingMemberHandling = MissingMemberHandling.Ignore;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		internal const NullValueHandling DefaultNullValueHandling = NullValueHandling.Include;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		internal const DefaultValueHandling DefaultDefaultValueHandling = DefaultValueHandling.Include;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		internal const ObjectCreationHandling DefaultObjectCreationHandling = ObjectCreationHandling.Auto;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		internal const PreserveReferencesHandling DefaultPreserveReferencesHandling = PreserveReferencesHandling.None;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		internal const ConstructorHandling DefaultConstructorHandling = ConstructorHandling.Default;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		internal const TypeNameHandling DefaultTypeNameHandling = TypeNameHandling.None;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		internal const MetadataPropertyHandling DefaultMetadataPropertyHandling = MetadataPropertyHandling.Default;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		internal const FormatterAssemblyStyle DefaultTypeNameAssemblyFormat = FormatterAssemblyStyle.Simple;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly StreamingContext DefaultContext;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		internal const Formatting DefaultFormatting = Formatting.None;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		internal const DateFormatHandling DefaultDateFormatHandling = DateFormatHandling.IsoDateFormat;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		internal const DateTimeZoneHandling DefaultDateTimeZoneHandling = DateTimeZoneHandling.RoundtripKind;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		internal const DateParseHandling DefaultDateParseHandling = DateParseHandling.DateTime;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		internal const FloatParseHandling DefaultFloatParseHandling = FloatParseHandling.Double;

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		internal const FloatFormatHandling DefaultFloatFormatHandling = FloatFormatHandling.String;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		internal const StringEscapeHandling DefaultStringEscapeHandling = StringEscapeHandling.Default;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		internal const FormatterAssemblyStyle DefaultFormatterAssemblyStyle = FormatterAssemblyStyle.Simple;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly CultureInfo DefaultCulture;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		internal const bool DefaultCheckAdditionalContent = false;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		internal const string DefaultDateFormatString = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x10")]
		internal Formatting? _formatting;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x18")]
		internal DateFormatHandling? _dateFormatHandling;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x20")]
		internal DateTimeZoneHandling? _dateTimeZoneHandling;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x28")]
		internal DateParseHandling? _dateParseHandling;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x30")]
		internal FloatFormatHandling? _floatFormatHandling;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x38")]
		internal FloatParseHandling? _floatParseHandling;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x40")]
		internal StringEscapeHandling? _stringEscapeHandling;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x48")]
		internal CultureInfo _culture;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x50")]
		internal bool? _checkAdditionalContent;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x54")]
		internal int? _maxDepth;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x5C")]
		internal bool _maxDepthSet;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x60")]
		internal string _dateFormatString;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x68")]
		internal bool _dateFormatStringSet;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x6C")]
		internal FormatterAssemblyStyle? _typeNameAssemblyFormat;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x74")]
		internal DefaultValueHandling? _defaultValueHandling;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x7C")]
		internal PreserveReferencesHandling? _preserveReferencesHandling;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x84")]
		internal NullValueHandling? _nullValueHandling;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x8C")]
		internal ObjectCreationHandling? _objectCreationHandling;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x94")]
		internal MissingMemberHandling? _missingMemberHandling;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x9C")]
		internal ReferenceLoopHandling? _referenceLoopHandling;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0xA8")]
		internal StreamingContext? _context;

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0xC0")]
		internal ConstructorHandling? _constructorHandling;

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0xC8")]
		internal TypeNameHandling? _typeNameHandling;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0xD0")]
		internal MetadataPropertyHandling? _metadataPropertyHandling;
	}
}
