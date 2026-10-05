using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Il2CppDummyDll;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	[Preserve]
	public class JsonSerializer
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060001EE RID: 494 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060001EF RID: 495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000003")]
		public virtual event EventHandler<ErrorEventArgs> Error
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x4D70350", Offset = "0x4D6EF50", VA = "0x184D70350", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x4D707F0", Offset = "0x4D6F3F0", VA = "0x184D707F0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000065")]
		public virtual IReferenceResolver ReferenceResolver
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x4D6EAF0", Offset = "0x4D6D6F0", VA = "0x184D6EAF0", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x4D71120", Offset = "0x4D6FD20", VA = "0x184D71120", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000066")]
		public virtual SerializationBinder Binder
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x4D708A0", Offset = "0x4D6F4A0", VA = "0x184D708A0", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000067")]
		public virtual ITraceWriter TraceWriter
		{
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000068")]
		public virtual IEqualityComparer EqualityComparer
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x5EC4C0", Offset = "0x5EB0C0", VA = "0x1805EC4C0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00002A60 File Offset: 0x00000C60
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000069")]
		public virtual TypeNameHandling TypeNameHandling
		{
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "14")]
			get
			{
				return TypeNameHandling.None;
			}
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x4D71280", Offset = "0x4D6FE80", VA = "0x184D71280", Slot = "15")]
			set
			{
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00002A78 File Offset: 0x00000C78
		// (set) Token: 0x060001FB RID: 507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700006A")]
		public virtual FormatterAssemblyStyle TypeNameAssemblyFormat
		{
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30", Slot = "16")]
			get
			{
				return FormatterAssemblyStyle.Simple;
			}
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x4D71210", Offset = "0x4D6FE10", VA = "0x184D71210", Slot = "17")]
			set
			{
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00002A90 File Offset: 0x00000C90
		// (set) Token: 0x060001FD RID: 509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700006B")]
		public virtual PreserveReferencesHandling PreserveReferencesHandling
		{
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "18")]
			get
			{
				return PreserveReferencesHandling.None;
			}
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x4D71040", Offset = "0x4D6FC40", VA = "0x184D71040", Slot = "19")]
			set
			{
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001FE RID: 510 RVA: 0x00002AA8 File Offset: 0x00000CA8
		// (set) Token: 0x060001FF RID: 511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700006C")]
		public virtual ReferenceLoopHandling ReferenceLoopHandling
		{
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880", Slot = "20")]
			get
			{
				return ReferenceLoopHandling.Error;
			}
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x4D710B0", Offset = "0x4D6FCB0", VA = "0x184D710B0", Slot = "21")]
			set
			{
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00002AC0 File Offset: 0x00000CC0
		// (set) Token: 0x06000201 RID: 513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700006D")]
		public virtual MissingMemberHandling MissingMemberHandling
		{
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890", Slot = "22")]
			get
			{
				return MissingMemberHandling.Ignore;
			}
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x4D70EF0", Offset = "0x4D6FAF0", VA = "0x184D70EF0", Slot = "23")]
			set
			{
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00002AD8 File Offset: 0x00000CD8
		// (set) Token: 0x06000203 RID: 515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700006E")]
		public virtual NullValueHandling NullValueHandling
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610", Slot = "24")]
			get
			{
				return NullValueHandling.Include;
			}
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x4D70F60", Offset = "0x4D6FB60", VA = "0x184D70F60", Slot = "25")]
			set
			{
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00002AF0 File Offset: 0x00000CF0
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700006F")]
		public virtual DefaultValueHandling DefaultValueHandling
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x4FD4B0", Offset = "0x4FC0B0", VA = "0x1804FD4B0", Slot = "26")]
			get
			{
				return DefaultValueHandling.Include;
			}
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x4D70C20", Offset = "0x4D6F820", VA = "0x184D70C20", Slot = "27")]
			set
			{
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00002B08 File Offset: 0x00000D08
		// (set) Token: 0x06000207 RID: 519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000070")]
		public virtual ObjectCreationHandling ObjectCreationHandling
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200", Slot = "28")]
			get
			{
				return ObjectCreationHandling.Auto;
			}
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x4D70FD0", Offset = "0x4D6FBD0", VA = "0x184D70FD0", Slot = "29")]
			set
			{
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000208 RID: 520 RVA: 0x00002B20 File Offset: 0x00000D20
		// (set) Token: 0x06000209 RID: 521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000071")]
		public virtual ConstructorHandling ConstructorHandling
		{
			[Token(Token = "0x6000208")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700", Slot = "30")]
			get
			{
				return ConstructorHandling.Default;
			}
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x4D70990", Offset = "0x4D6F590", VA = "0x184D70990", Slot = "31")]
			set
			{
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600020A RID: 522 RVA: 0x00002B38 File Offset: 0x00000D38
		// (set) Token: 0x0600020B RID: 523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000072")]
		public virtual MetadataPropertyHandling MetadataPropertyHandling
		{
			[Token(Token = "0x600020A")]
			[Address(RVA = "0x22FB140", Offset = "0x22F9D40", VA = "0x1822FB140", Slot = "32")]
			get
			{
				return MetadataPropertyHandling.Default;
			}
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x4D70E80", Offset = "0x4D6FA80", VA = "0x184D70E80", Slot = "33")]
			set
			{
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000073")]
		public virtual JsonConverterCollection Converters
		{
			[Token(Token = "0x600020C")]
			[Address(RVA = "0x4D70450", Offset = "0x4D6F050", VA = "0x184D70450", Slot = "34")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600020D RID: 525 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600020E RID: 526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000074")]
		public virtual IContractResolver ContractResolver
		{
			[Token(Token = "0x600020D")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950", Slot = "35")]
			get
			{
				return null;
			}
			[Token(Token = "0x600020E")]
			[Address(RVA = "0x4D70A20", Offset = "0x4D6F620", VA = "0x184D70A20", Slot = "36")]
			set
			{
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600020F RID: 527 RVA: 0x00002B50 File Offset: 0x00000D50
		// (set) Token: 0x06000210 RID: 528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000075")]
		public virtual StreamingContext Context
		{
			[Token(Token = "0x600020F")]
			[Address(RVA = "0x157CDD0", Offset = "0x157B9D0", VA = "0x18157CDD0", Slot = "37")]
			get
			{
				return default(StreamingContext);
			}
			[Token(Token = "0x6000210")]
			[Address(RVA = "0x4D70A00", Offset = "0x4D6F600", VA = "0x184D70A00", Slot = "38")]
			set
			{
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000211 RID: 529 RVA: 0x00002B68 File Offset: 0x00000D68
		// (set) Token: 0x06000212 RID: 530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000076")]
		public virtual Formatting Formatting
		{
			[Token(Token = "0x6000211")]
			[Address(RVA = "0x4D70750", Offset = "0x4D6F350", VA = "0x184D70750", Slot = "39")]
			get
			{
				return Formatting.None;
			}
			[Token(Token = "0x6000212")]
			[Address(RVA = "0x4D70D50", Offset = "0x4D6F950", VA = "0x184D70D50", Slot = "40")]
			set
			{
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000213 RID: 531 RVA: 0x00002B80 File Offset: 0x00000D80
		// (set) Token: 0x06000214 RID: 532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000077")]
		public virtual DateFormatHandling DateFormatHandling
		{
			[Token(Token = "0x6000213")]
			[Address(RVA = "0x4D70560", Offset = "0x4D6F160", VA = "0x184D70560", Slot = "41")]
			get
			{
				return DateFormatHandling.IsoDateFormat;
			}
			[Token(Token = "0x6000214")]
			[Address(RVA = "0x4D70AD0", Offset = "0x4D6F6D0", VA = "0x184D70AD0", Slot = "42")]
			set
			{
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000215 RID: 533 RVA: 0x00002B98 File Offset: 0x00000D98
		// (set) Token: 0x06000216 RID: 534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000078")]
		public virtual DateTimeZoneHandling DateTimeZoneHandling
		{
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x4D70650", Offset = "0x4D6F250", VA = "0x184D70650", Slot = "43")]
			get
			{
				return DateTimeZoneHandling.Local;
			}
			[Token(Token = "0x6000216")]
			[Address(RVA = "0x4D70BC0", Offset = "0x4D6F7C0", VA = "0x184D70BC0", Slot = "44")]
			set
			{
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000217 RID: 535 RVA: 0x00002BB0 File Offset: 0x00000DB0
		// (set) Token: 0x06000218 RID: 536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000079")]
		public virtual DateParseHandling DateParseHandling
		{
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x4D705F0", Offset = "0x4D6F1F0", VA = "0x184D705F0", Slot = "45")]
			get
			{
				return DateParseHandling.None;
			}
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x4D70B60", Offset = "0x4D6F760", VA = "0x184D70B60", Slot = "46")]
			set
			{
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000219 RID: 537 RVA: 0x00002BC8 File Offset: 0x00000DC8
		// (set) Token: 0x0600021A RID: 538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700007A")]
		public virtual FloatParseHandling FloatParseHandling
		{
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x4D70700", Offset = "0x4D6F300", VA = "0x184D70700", Slot = "47")]
			get
			{
				return FloatParseHandling.Double;
			}
			[Token(Token = "0x600021A")]
			[Address(RVA = "0x4D70CF0", Offset = "0x4D6F8F0", VA = "0x184D70CF0", Slot = "48")]
			set
			{
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00002BE0 File Offset: 0x00000DE0
		// (set) Token: 0x0600021C RID: 540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700007B")]
		public virtual FloatFormatHandling FloatFormatHandling
		{
			[Token(Token = "0x600021B")]
			[Address(RVA = "0x4D706B0", Offset = "0x4D6F2B0", VA = "0x184D706B0", Slot = "49")]
			get
			{
				return FloatFormatHandling.String;
			}
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x4D70C90", Offset = "0x4D6F890", VA = "0x184D70C90", Slot = "50")]
			set
			{
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600021D RID: 541 RVA: 0x00002BF8 File Offset: 0x00000DF8
		// (set) Token: 0x0600021E RID: 542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700007C")]
		public virtual StringEscapeHandling StringEscapeHandling
		{
			[Token(Token = "0x600021D")]
			[Address(RVA = "0x4D707A0", Offset = "0x4D6F3A0", VA = "0x184D707A0", Slot = "51")]
			get
			{
				return StringEscapeHandling.Default;
			}
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x4D711B0", Offset = "0x4D6FDB0", VA = "0x184D711B0", Slot = "52")]
			set
			{
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000220 RID: 544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700007D")]
		public virtual string DateFormatString
		{
			[Token(Token = "0x600021F")]
			[Address(RVA = "0x4D705B0", Offset = "0x4D6F1B0", VA = "0x184D705B0", Slot = "53")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x4D70B30", Offset = "0x4D6F730", VA = "0x184D70B30", Slot = "54")]
			set
			{
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000221 RID: 545 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000222 RID: 546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700007E")]
		public virtual CultureInfo Culture
		{
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x4D704F0", Offset = "0x4D6F0F0", VA = "0x184D704F0", Slot = "55")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x22F8A70", Offset = "0x22F7670", VA = "0x1822F8A70", Slot = "56")]
			set
			{
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000223 RID: 547 RVA: 0x00002C10 File Offset: 0x00000E10
		// (set) Token: 0x06000224 RID: 548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700007F")]
		public virtual int? MaxDepth
		{
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x22F8850", Offset = "0x22F7450", VA = "0x1822F8850", Slot = "57")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x4D70DB0", Offset = "0x4D6F9B0", VA = "0x184D70DB0", Slot = "58")]
			set
			{
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000225 RID: 549 RVA: 0x00002C28 File Offset: 0x00000E28
		// (set) Token: 0x06000226 RID: 550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000080")]
		public virtual bool CheckAdditionalContent
		{
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x4D70400", Offset = "0x4D6F000", VA = "0x184D70400", Slot = "59")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x4D70930", Offset = "0x4D6F530", VA = "0x184D70930", Slot = "60")]
			set
			{
			}
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00002C40 File Offset: 0x00000E40
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x4D6EB70", Offset = "0x4D6D770", VA = "0x184D6EB70")]
		internal bool IsCheckAdditionalContentSet()
		{
			return default(bool);
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x4D701F0", Offset = "0x4D6EDF0", VA = "0x184D701F0")]
		public JsonSerializer()
		{
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x4D6E190", Offset = "0x4D6CD90", VA = "0x184D6E190")]
		public static JsonSerializer Create()
		{
			return null;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x4D6DFE0", Offset = "0x4D6CBE0", VA = "0x184D6DFE0")]
		public static JsonSerializer Create(JsonSerializerSettings settings)
		{
			return null;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x4D6DD60", Offset = "0x4D6C960", VA = "0x184D6DD60")]
		public static JsonSerializer CreateDefault()
		{
			return null;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x4D6DFA0", Offset = "0x4D6CBA0", VA = "0x184D6DFA0")]
		public static JsonSerializer CreateDefault(JsonSerializerSettings settings)
		{
			return null;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x4D6D210", Offset = "0x4D6BE10", VA = "0x184D6D210")]
		private static void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings)
		{
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x4D6F040", Offset = "0x4D6DC40", VA = "0x184D6F040")]
		public void Populate(TextReader reader, object target)
		{
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x4D6EFE0", Offset = "0x4D6DBE0", VA = "0x184D6EFE0")]
		public void Populate(JsonReader reader, object target)
		{
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x4D6EBD0", Offset = "0x4D6D7D0", VA = "0x184D6EBD0", Slot = "61")]
		internal virtual void PopulateInternal(JsonReader reader, object target)
		{
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x4D6E750", Offset = "0x4D6D350", VA = "0x184D6E750")]
		public object Deserialize(JsonReader reader)
		{
			return null;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x4D6E800", Offset = "0x4D6D400", VA = "0x184D6E800")]
		public object Deserialize(TextReader reader, Type objectType)
		{
			return null;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000233")]
		public T Deserialize<T>(JsonReader reader)
		{
			return null;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x4D6E7A0", Offset = "0x4D6D3A0", VA = "0x184D6E7A0")]
		public object Deserialize(JsonReader reader, Type objectType)
		{
			return null;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x4D6E320", Offset = "0x4D6CF20", VA = "0x184D6E320", Slot = "62")]
		internal virtual object DeserializeInternal(JsonReader reader, Type objectType)
		{
			return null;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x4D6FD00", Offset = "0x4D6E900", VA = "0x184D6FD00")]
		private void SetupReader(JsonReader reader, out CultureInfo previousCulture, out DateTimeZoneHandling? previousDateTimeZoneHandling, out DateParseHandling? previousDateParseHandling, out FloatParseHandling? previousFloatParseHandling, out int? previousMaxDepth, out string previousDateFormatString)
		{
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x4D6F170", Offset = "0x4D6DD70", VA = "0x184D6F170")]
		private void ResetReader(JsonReader reader, CultureInfo previousCulture, DateTimeZoneHandling? previousDateTimeZoneHandling, DateParseHandling? previousDateParseHandling, FloatParseHandling? previousFloatParseHandling, int? previousMaxDepth, string previousDateFormatString)
		{
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x4D6FB30", Offset = "0x4D6E730", VA = "0x184D6FB30")]
		public void Serialize(TextWriter textWriter, object value)
		{
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x4D6FAC0", Offset = "0x4D6E6C0", VA = "0x184D6FAC0")]
		public void Serialize(JsonWriter jsonWriter, object value, Type objectType)
		{
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x4D6F940", Offset = "0x4D6E540", VA = "0x184D6F940")]
		public void Serialize(TextWriter textWriter, object value, Type objectType)
		{
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x4D6FCA0", Offset = "0x4D6E8A0", VA = "0x184D6FCA0")]
		public void Serialize(JsonWriter jsonWriter, object value)
		{
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x4D6F340", Offset = "0x4D6DF40", VA = "0x184D6F340", Slot = "63")]
		internal virtual void SerializeInternal(JsonWriter jsonWriter, object value, Type objectType)
		{
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x4D6EAF0", Offset = "0x4D6D6F0", VA = "0x184D6EAF0")]
		internal IReferenceResolver GetReferenceResolver()
		{
			return null;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x4D6E930", Offset = "0x4D6D530", VA = "0x184D6E930")]
		internal JsonConverter GetMatchingConverter(Type type)
		{
			return null;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x4D6EA10", Offset = "0x4D6D610", VA = "0x184D6EA10")]
		internal static JsonConverter GetMatchingConverter(IList<JsonConverter> converters, Type objectType)
		{
			return null;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x4D6EBB0", Offset = "0x4D6D7B0", VA = "0x184D6EBB0")]
		internal void OnError(ErrorEventArgs e)
		{
		}

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x10")]
		internal TypeNameHandling _typeNameHandling;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x14")]
		internal FormatterAssemblyStyle _typeNameAssemblyFormat;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x18")]
		internal PreserveReferencesHandling _preserveReferencesHandling;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x1C")]
		internal ReferenceLoopHandling _referenceLoopHandling;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x20")]
		internal MissingMemberHandling _missingMemberHandling;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x24")]
		internal ObjectCreationHandling _objectCreationHandling;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x28")]
		internal NullValueHandling _nullValueHandling;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x2C")]
		internal DefaultValueHandling _defaultValueHandling;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x30")]
		internal ConstructorHandling _constructorHandling;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x34")]
		internal MetadataPropertyHandling _metadataPropertyHandling;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x38")]
		internal JsonConverterCollection _converters;

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x40")]
		internal IContractResolver _contractResolver;

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x48")]
		internal ITraceWriter _traceWriter;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x50")]
		internal IEqualityComparer _equalityComparer;

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x58")]
		internal SerializationBinder _binder;

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x60")]
		internal StreamingContext _context;

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x70")]
		private IReferenceResolver _referenceResolver;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x78")]
		private Formatting? _formatting;

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x80")]
		private DateFormatHandling? _dateFormatHandling;

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x88")]
		private DateTimeZoneHandling? _dateTimeZoneHandling;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x90")]
		private DateParseHandling? _dateParseHandling;

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x98")]
		private FloatFormatHandling? _floatFormatHandling;

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0xA0")]
		private FloatParseHandling? _floatParseHandling;

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0xA8")]
		private StringEscapeHandling? _stringEscapeHandling;

		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0xB0")]
		private CultureInfo _culture;

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0xB8")]
		private int? _maxDepth;

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0xC0")]
		private bool _maxDepthSet;

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0xC1")]
		private bool? _checkAdditionalContent;

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0xC8")]
		private string _dateFormatString;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0xD0")]
		private bool _dateFormatStringSet;
	}
}
