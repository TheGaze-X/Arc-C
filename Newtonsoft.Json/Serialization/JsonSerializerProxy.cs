using System;
using System.Collections;
using System.Globalization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000AE RID: 174
	[Token(Token = "0x20000AE")]
	[Preserve]
	internal class JsonSerializerProxy : JsonSerializer
	{
		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000664 RID: 1636 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000665 RID: 1637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000004")]
		public override event EventHandler<ErrorEventArgs> Error
		{
			[Token(Token = "0x6000664")]
			[Address(RVA = "0x4DD8990", Offset = "0x4DD7590", VA = "0x184DD8990", Slot = "4")]
			add
			{
			}
			[Token(Token = "0x6000665")]
			[Address(RVA = "0x4DD92C0", Offset = "0x4DD7EC0", VA = "0x184DD92C0", Slot = "5")]
			remove
			{
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000667 RID: 1639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700012C")]
		public override IReferenceResolver ReferenceResolver
		{
			[Token(Token = "0x6000666")]
			[Address(RVA = "0x4DD9130", Offset = "0x4DD7D30", VA = "0x184DD9130", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000667")]
			[Address(RVA = "0x4DD9A80", Offset = "0x4DD8680", VA = "0x184DD9A80", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000669 RID: 1641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700012D")]
		public override ITraceWriter TraceWriter
		{
			[Token(Token = "0x6000668")]
			[Address(RVA = "0x4DD91D0", Offset = "0x4DD7DD0", VA = "0x184DD91D0", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000669")]
			[Address(RVA = "0x4DD9B30", Offset = "0x4DD8730", VA = "0x184DD9B30", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600066B RID: 1643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700012E")]
		public override IEqualityComparer EqualityComparer
		{
			[Token(Token = "0x600066A")]
			[Address(RVA = "0x4DD8DC0", Offset = "0x4DD79C0", VA = "0x184DD8DC0", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x600066B")]
			[Address(RVA = "0x4DD96F0", Offset = "0x4DD82F0", VA = "0x184DD96F0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012F")]
		public override JsonConverterCollection Converters
		{
			[Token(Token = "0x600066C")]
			[Address(RVA = "0x4DD8B90", Offset = "0x4DD7790", VA = "0x184DD8B90", Slot = "34")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x000047D0 File Offset: 0x000029D0
		// (set) Token: 0x0600066E RID: 1646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000130")]
		public override DefaultValueHandling DefaultValueHandling
		{
			[Token(Token = "0x600066D")]
			[Address(RVA = "0x4DD8D70", Offset = "0x4DD7970", VA = "0x184DD8D70", Slot = "26")]
			get
			{
				return DefaultValueHandling.Include;
			}
			[Token(Token = "0x600066E")]
			[Address(RVA = "0x4DD96A0", Offset = "0x4DD82A0", VA = "0x184DD96A0", Slot = "27")]
			set
			{
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000670 RID: 1648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000131")]
		public override IContractResolver ContractResolver
		{
			[Token(Token = "0x600066F")]
			[Address(RVA = "0x4DD8B40", Offset = "0x4DD7740", VA = "0x184DD8B40", Slot = "35")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000670")]
			[Address(RVA = "0x4DD9490", Offset = "0x4DD8090", VA = "0x184DD9490", Slot = "36")]
			set
			{
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000671 RID: 1649 RVA: 0x000047E8 File Offset: 0x000029E8
		// (set) Token: 0x06000672 RID: 1650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000132")]
		public override MissingMemberHandling MissingMemberHandling
		{
			[Token(Token = "0x6000671")]
			[Address(RVA = "0x4DD8FA0", Offset = "0x4DD7BA0", VA = "0x184DD8FA0", Slot = "22")]
			get
			{
				return MissingMemberHandling.Ignore;
			}
			[Token(Token = "0x6000672")]
			[Address(RVA = "0x4DD98F0", Offset = "0x4DD84F0", VA = "0x184DD98F0", Slot = "23")]
			set
			{
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x00004800 File Offset: 0x00002A00
		// (set) Token: 0x06000674 RID: 1652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000133")]
		public override NullValueHandling NullValueHandling
		{
			[Token(Token = "0x6000673")]
			[Address(RVA = "0x4DD8FF0", Offset = "0x4DD7BF0", VA = "0x184DD8FF0", Slot = "24")]
			get
			{
				return NullValueHandling.Include;
			}
			[Token(Token = "0x6000674")]
			[Address(RVA = "0x4DD9940", Offset = "0x4DD8540", VA = "0x184DD9940", Slot = "25")]
			set
			{
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000675 RID: 1653 RVA: 0x00004818 File Offset: 0x00002A18
		// (set) Token: 0x06000676 RID: 1654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000134")]
		public override ObjectCreationHandling ObjectCreationHandling
		{
			[Token(Token = "0x6000675")]
			[Address(RVA = "0x4DD9040", Offset = "0x4DD7C40", VA = "0x184DD9040", Slot = "28")]
			get
			{
				return ObjectCreationHandling.Auto;
			}
			[Token(Token = "0x6000676")]
			[Address(RVA = "0x4DD9990", Offset = "0x4DD8590", VA = "0x184DD9990", Slot = "29")]
			set
			{
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x00004830 File Offset: 0x00002A30
		// (set) Token: 0x06000678 RID: 1656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000135")]
		public override ReferenceLoopHandling ReferenceLoopHandling
		{
			[Token(Token = "0x6000677")]
			[Address(RVA = "0x4DD90E0", Offset = "0x4DD7CE0", VA = "0x184DD90E0", Slot = "20")]
			get
			{
				return ReferenceLoopHandling.Error;
			}
			[Token(Token = "0x6000678")]
			[Address(RVA = "0x4DD9A30", Offset = "0x4DD8630", VA = "0x184DD9A30", Slot = "21")]
			set
			{
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x00004848 File Offset: 0x00002A48
		// (set) Token: 0x0600067A RID: 1658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000136")]
		public override PreserveReferencesHandling PreserveReferencesHandling
		{
			[Token(Token = "0x6000679")]
			[Address(RVA = "0x4DD9090", Offset = "0x4DD7C90", VA = "0x184DD9090", Slot = "18")]
			get
			{
				return PreserveReferencesHandling.None;
			}
			[Token(Token = "0x600067A")]
			[Address(RVA = "0x4DD99E0", Offset = "0x4DD85E0", VA = "0x184DD99E0", Slot = "19")]
			set
			{
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600067B RID: 1659 RVA: 0x00004860 File Offset: 0x00002A60
		// (set) Token: 0x0600067C RID: 1660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000137")]
		public override TypeNameHandling TypeNameHandling
		{
			[Token(Token = "0x600067B")]
			[Address(RVA = "0x4DD9270", Offset = "0x4DD7E70", VA = "0x184DD9270", Slot = "14")]
			get
			{
				return TypeNameHandling.None;
			}
			[Token(Token = "0x600067C")]
			[Address(RVA = "0x4DD9BE0", Offset = "0x4DD87E0", VA = "0x184DD9BE0", Slot = "15")]
			set
			{
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600067D RID: 1661 RVA: 0x00004878 File Offset: 0x00002A78
		// (set) Token: 0x0600067E RID: 1662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000138")]
		public override MetadataPropertyHandling MetadataPropertyHandling
		{
			[Token(Token = "0x600067D")]
			[Address(RVA = "0x4DD8F50", Offset = "0x4DD7B50", VA = "0x184DD8F50", Slot = "32")]
			get
			{
				return MetadataPropertyHandling.Default;
			}
			[Token(Token = "0x600067E")]
			[Address(RVA = "0x4DD98A0", Offset = "0x4DD84A0", VA = "0x184DD98A0", Slot = "33")]
			set
			{
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x00004890 File Offset: 0x00002A90
		// (set) Token: 0x06000680 RID: 1664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000139")]
		public override FormatterAssemblyStyle TypeNameAssemblyFormat
		{
			[Token(Token = "0x600067F")]
			[Address(RVA = "0x4DD9220", Offset = "0x4DD7E20", VA = "0x184DD9220", Slot = "16")]
			get
			{
				return FormatterAssemblyStyle.Simple;
			}
			[Token(Token = "0x6000680")]
			[Address(RVA = "0x4DD9B90", Offset = "0x4DD8790", VA = "0x184DD9B90", Slot = "17")]
			set
			{
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x000048A8 File Offset: 0x00002AA8
		// (set) Token: 0x06000682 RID: 1666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700013A")]
		public override ConstructorHandling ConstructorHandling
		{
			[Token(Token = "0x6000681")]
			[Address(RVA = "0x4DD8A90", Offset = "0x4DD7690", VA = "0x184DD8A90", Slot = "30")]
			get
			{
				return ConstructorHandling.Default;
			}
			[Token(Token = "0x6000682")]
			[Address(RVA = "0x4DD93E0", Offset = "0x4DD7FE0", VA = "0x184DD93E0", Slot = "31")]
			set
			{
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000684 RID: 1668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700013B")]
		public override SerializationBinder Binder
		{
			[Token(Token = "0x6000683")]
			[Address(RVA = "0x4DD89F0", Offset = "0x4DD75F0", VA = "0x184DD89F0", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000684")]
			[Address(RVA = "0x4DD9320", Offset = "0x4DD7F20", VA = "0x184DD9320", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x000048C0 File Offset: 0x00002AC0
		// (set) Token: 0x06000686 RID: 1670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700013C")]
		public override StreamingContext Context
		{
			[Token(Token = "0x6000685")]
			[Address(RVA = "0x4DD8AE0", Offset = "0x4DD76E0", VA = "0x184DD8AE0", Slot = "37")]
			get
			{
				return default(StreamingContext);
			}
			[Token(Token = "0x6000686")]
			[Address(RVA = "0x4DD9430", Offset = "0x4DD8030", VA = "0x184DD9430", Slot = "38")]
			set
			{
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x000048D8 File Offset: 0x00002AD8
		// (set) Token: 0x06000688 RID: 1672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700013D")]
		public override Formatting Formatting
		{
			[Token(Token = "0x6000687")]
			[Address(RVA = "0x4DD8EB0", Offset = "0x4DD7AB0", VA = "0x184DD8EB0", Slot = "39")]
			get
			{
				return Formatting.None;
			}
			[Token(Token = "0x6000688")]
			[Address(RVA = "0x4DD97F0", Offset = "0x4DD83F0", VA = "0x184DD97F0", Slot = "40")]
			set
			{
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x000048F0 File Offset: 0x00002AF0
		// (set) Token: 0x0600068A RID: 1674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700013E")]
		public override DateFormatHandling DateFormatHandling
		{
			[Token(Token = "0x6000689")]
			[Address(RVA = "0x4DD8C30", Offset = "0x4DD7830", VA = "0x184DD8C30", Slot = "41")]
			get
			{
				return DateFormatHandling.IsoDateFormat;
			}
			[Token(Token = "0x600068A")]
			[Address(RVA = "0x4DD9550", Offset = "0x4DD8150", VA = "0x184DD9550", Slot = "42")]
			set
			{
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x00004908 File Offset: 0x00002B08
		// (set) Token: 0x0600068C RID: 1676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700013F")]
		public override DateTimeZoneHandling DateTimeZoneHandling
		{
			[Token(Token = "0x600068B")]
			[Address(RVA = "0x4DD8D20", Offset = "0x4DD7920", VA = "0x184DD8D20", Slot = "43")]
			get
			{
				return DateTimeZoneHandling.Local;
			}
			[Token(Token = "0x600068C")]
			[Address(RVA = "0x4DD9650", Offset = "0x4DD8250", VA = "0x184DD9650", Slot = "44")]
			set
			{
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x00004920 File Offset: 0x00002B20
		// (set) Token: 0x0600068E RID: 1678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000140")]
		public override DateParseHandling DateParseHandling
		{
			[Token(Token = "0x600068D")]
			[Address(RVA = "0x4DD8CD0", Offset = "0x4DD78D0", VA = "0x184DD8CD0", Slot = "45")]
			get
			{
				return DateParseHandling.None;
			}
			[Token(Token = "0x600068E")]
			[Address(RVA = "0x4DD9600", Offset = "0x4DD8200", VA = "0x184DD9600", Slot = "46")]
			set
			{
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x00004938 File Offset: 0x00002B38
		// (set) Token: 0x06000690 RID: 1680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000141")]
		public override FloatFormatHandling FloatFormatHandling
		{
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x4DD8E10", Offset = "0x4DD7A10", VA = "0x184DD8E10", Slot = "49")]
			get
			{
				return FloatFormatHandling.String;
			}
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x4DD9750", Offset = "0x4DD8350", VA = "0x184DD9750", Slot = "50")]
			set
			{
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x00004950 File Offset: 0x00002B50
		// (set) Token: 0x06000692 RID: 1682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000142")]
		public override FloatParseHandling FloatParseHandling
		{
			[Token(Token = "0x6000691")]
			[Address(RVA = "0x4DD8E60", Offset = "0x4DD7A60", VA = "0x184DD8E60", Slot = "47")]
			get
			{
				return FloatParseHandling.Double;
			}
			[Token(Token = "0x6000692")]
			[Address(RVA = "0x4DD97A0", Offset = "0x4DD83A0", VA = "0x184DD97A0", Slot = "48")]
			set
			{
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x00004968 File Offset: 0x00002B68
		// (set) Token: 0x06000694 RID: 1684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000143")]
		public override StringEscapeHandling StringEscapeHandling
		{
			[Token(Token = "0x6000693")]
			[Address(RVA = "0x4DD9180", Offset = "0x4DD7D80", VA = "0x184DD9180", Slot = "51")]
			get
			{
				return StringEscapeHandling.Default;
			}
			[Token(Token = "0x6000694")]
			[Address(RVA = "0x4DD9AE0", Offset = "0x4DD86E0", VA = "0x184DD9AE0", Slot = "52")]
			set
			{
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000696 RID: 1686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000144")]
		public override string DateFormatString
		{
			[Token(Token = "0x6000695")]
			[Address(RVA = "0x4DD8C80", Offset = "0x4DD7880", VA = "0x184DD8C80", Slot = "53")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000696")]
			[Address(RVA = "0x4DD95A0", Offset = "0x4DD81A0", VA = "0x184DD95A0", Slot = "54")]
			set
			{
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000698 RID: 1688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000145")]
		public override CultureInfo Culture
		{
			[Token(Token = "0x6000697")]
			[Address(RVA = "0x4DD8BE0", Offset = "0x4DD77E0", VA = "0x184DD8BE0", Slot = "55")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000698")]
			[Address(RVA = "0x4DD94F0", Offset = "0x4DD80F0", VA = "0x184DD94F0", Slot = "56")]
			set
			{
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x00004980 File Offset: 0x00002B80
		// (set) Token: 0x0600069A RID: 1690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000146")]
		public override int? MaxDepth
		{
			[Token(Token = "0x6000699")]
			[Address(RVA = "0x4DD8F00", Offset = "0x4DD7B00", VA = "0x184DD8F00", Slot = "57")]
			get
			{
				return null;
			}
			[Token(Token = "0x600069A")]
			[Address(RVA = "0x4DD9840", Offset = "0x4DD8440", VA = "0x184DD9840", Slot = "58")]
			set
			{
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x00004998 File Offset: 0x00002B98
		// (set) Token: 0x0600069C RID: 1692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000147")]
		public override bool CheckAdditionalContent
		{
			[Token(Token = "0x600069B")]
			[Address(RVA = "0x4DD8A40", Offset = "0x4DD7640", VA = "0x184DD8A40", Slot = "59")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600069C")]
			[Address(RVA = "0x4DD9380", Offset = "0x4DD7F80", VA = "0x184DD9380", Slot = "60")]
			set
			{
			}
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600069D")]
		[Address(RVA = "0x4DD87C0", Offset = "0x4DD73C0", VA = "0x184DD87C0")]
		internal JsonSerializerInternalBase GetInternalSerializer()
		{
			return null;
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600069E")]
		[Address(RVA = "0x4DD8900", Offset = "0x4DD7500", VA = "0x184DD8900")]
		public JsonSerializerProxy(JsonSerializerInternalReader serializerReader)
		{
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600069F")]
		[Address(RVA = "0x4DD8870", Offset = "0x4DD7470", VA = "0x184DD8870")]
		public JsonSerializerProxy(JsonSerializerInternalWriter serializerWriter)
		{
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x4DD8770", Offset = "0x4DD7370", VA = "0x184DD8770", Slot = "62")]
		internal override object DeserializeInternal(JsonReader reader, Type objectType)
		{
			return null;
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x4DD87E0", Offset = "0x4DD73E0", VA = "0x184DD87E0", Slot = "61")]
		internal override void PopulateInternal(JsonReader reader, object target)
		{
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x4DD8820", Offset = "0x4DD7420", VA = "0x184DD8820", Slot = "63")]
		internal override void SerializeInternal(JsonWriter jsonWriter, object value, Type rootType)
		{
		}

		// Token: 0x040002D4 RID: 724
		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0xE0")]
		private readonly JsonSerializerInternalReader _serializerReader;

		// Token: 0x040002D5 RID: 725
		[Token(Token = "0x40002D5")]
		[FieldOffset(Offset = "0xE8")]
		private readonly JsonSerializerInternalWriter _serializerWriter;

		// Token: 0x040002D6 RID: 726
		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0xF0")]
		private readonly JsonSerializer _serializer;
	}
}
