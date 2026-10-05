using System;
using System.Text;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000169 RID: 361
	[Token(Token = "0x2000169")]
	internal struct XsdDateTime
	{
		// Token: 0x06000C6A RID: 3178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C6A")]
		[Address(RVA = "0x50364A0", Offset = "0x50350A0", VA = "0x1850364A0")]
		public XsdDateTime(string text, XsdDateTimeFlags kinds)
		{
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C6B")]
		[Address(RVA = "0x50366D0", Offset = "0x50352D0", VA = "0x1850366D0")]
		private XsdDateTime(XsdDateTime.Parser parser)
		{
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C6C")]
		[Address(RVA = "0x5034A10", Offset = "0x5033610", VA = "0x185034A10")]
		private void InitiateXsdDateTime(XsdDateTime.Parser parser)
		{
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x00006510 File Offset: 0x00004710
		[Token(Token = "0x6000C6D")]
		[Address(RVA = "0x5035CE0", Offset = "0x50348E0", VA = "0x185035CE0")]
		internal static bool TryParse(string text, XsdDateTimeFlags kinds, out XsdDateTime result)
		{
			return default(bool);
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C6E")]
		[Address(RVA = "0x5036760", Offset = "0x5035360", VA = "0x185036760")]
		public XsdDateTime(DateTime dateTime, XsdDateTimeFlags kinds)
		{
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C6F")]
		[Address(RVA = "0x5036910", Offset = "0x5035510", VA = "0x185036910")]
		public XsdDateTime(DateTimeOffset dateTimeOffset)
		{
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C70")]
		[Address(RVA = "0x5036310", Offset = "0x5034F10", VA = "0x185036310")]
		public XsdDateTime(DateTimeOffset dateTimeOffset, XsdDateTimeFlags kinds)
		{
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000C71 RID: 3185 RVA: 0x00006528 File Offset: 0x00004728
		[Token(Token = "0x1700033A")]
		private XsdDateTime.DateTimeTypeCode InternalTypeCode
		{
			[Token(Token = "0x6000C71")]
			[Address(RVA = "0x5036B30", Offset = "0x5035730", VA = "0x185036B30")]
			get
			{
				return XsdDateTime.DateTimeTypeCode.DateTime;
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000C72 RID: 3186 RVA: 0x00006540 File Offset: 0x00004740
		[Token(Token = "0x1700033B")]
		private XsdDateTime.XsdDateTimeKind InternalKind
		{
			[Token(Token = "0x6000C72")]
			[Address(RVA = "0x4C084D0", Offset = "0x4C070D0", VA = "0x184C084D0")]
			get
			{
				return XsdDateTime.XsdDateTimeKind.Unspecified;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000C73 RID: 3187 RVA: 0x00006558 File Offset: 0x00004758
		[Token(Token = "0x1700033C")]
		public int Year
		{
			[Token(Token = "0x6000C73")]
			[Address(RVA = "0x5036C30", Offset = "0x5035830", VA = "0x185036C30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000C74 RID: 3188 RVA: 0x00006570 File Offset: 0x00004770
		[Token(Token = "0x1700033D")]
		public int Month
		{
			[Token(Token = "0x6000C74")]
			[Address(RVA = "0x5036B90", Offset = "0x5035790", VA = "0x185036B90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000C75 RID: 3189 RVA: 0x00006588 File Offset: 0x00004788
		[Token(Token = "0x1700033E")]
		public int Day
		{
			[Token(Token = "0x6000C75")]
			[Address(RVA = "0x5036980", Offset = "0x5035580", VA = "0x185036980")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000C76 RID: 3190 RVA: 0x000065A0 File Offset: 0x000047A0
		[Token(Token = "0x1700033F")]
		public int Hour
		{
			[Token(Token = "0x6000C76")]
			[Address(RVA = "0x5036AE0", Offset = "0x50356E0", VA = "0x185036AE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x000065B8 File Offset: 0x000047B8
		[Token(Token = "0x17000340")]
		public int Minute
		{
			[Token(Token = "0x6000C77")]
			[Address(RVA = "0x5036B40", Offset = "0x5035740", VA = "0x185036B40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x000065D0 File Offset: 0x000047D0
		[Token(Token = "0x17000341")]
		public int Second
		{
			[Token(Token = "0x6000C78")]
			[Address(RVA = "0x5036BE0", Offset = "0x50357E0", VA = "0x185036BE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000C79 RID: 3193 RVA: 0x000065E8 File Offset: 0x000047E8
		[Token(Token = "0x17000342")]
		public int Fraction
		{
			[Token(Token = "0x6000C79")]
			[Address(RVA = "0x50369D0", Offset = "0x50355D0", VA = "0x1850369D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000C7A RID: 3194 RVA: 0x00006600 File Offset: 0x00004800
		[Token(Token = "0x17000343")]
		public int ZoneHour
		{
			[Token(Token = "0x6000C7A")]
			[Address(RVA = "0x4C084E0", Offset = "0x4C070E0", VA = "0x184C084E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000C7B RID: 3195 RVA: 0x00006618 File Offset: 0x00004818
		[Token(Token = "0x17000344")]
		public int ZoneMinute
		{
			[Token(Token = "0x6000C7B")]
			[Address(RVA = "0xFEDEC0", Offset = "0xFECAC0", VA = "0x180FEDEC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x00006630 File Offset: 0x00004830
		[Token(Token = "0x6000C7C")]
		[Address(RVA = "0x5036C80", Offset = "0x5035880", VA = "0x185036C80")]
		public static implicit operator DateTime(XsdDateTime xdt)
		{
			return default(DateTime);
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x00006648 File Offset: 0x00004848
		[Token(Token = "0x6000C7D")]
		[Address(RVA = "0x50372E0", Offset = "0x5035EE0", VA = "0x1850372E0")]
		public static implicit operator DateTimeOffset(XsdDateTime xdt)
		{
			return default(DateTimeOffset);
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7E")]
		[Address(RVA = "0x5035600", Offset = "0x5034200", VA = "0x185035600", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C7F")]
		[Address(RVA = "0x5034BF0", Offset = "0x50337F0", VA = "0x185034BF0")]
		private void PrintDate(StringBuilder sb)
		{
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C80")]
		[Address(RVA = "0x5034EC0", Offset = "0x5033AC0", VA = "0x185034EC0")]
		private void PrintTime(StringBuilder sb)
		{
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C81")]
		[Address(RVA = "0x5035290", Offset = "0x5033E90", VA = "0x185035290")]
		private void PrintZone(StringBuilder sb)
		{
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C82")]
		[Address(RVA = "0x5034B70", Offset = "0x5033770", VA = "0x185034B70")]
		private void IntToCharArray(char[] text, int start, int value, int digits)
		{
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C83")]
		[Address(RVA = "0x5035590", Offset = "0x5034190", VA = "0x185035590")]
		private void ShortToCharArray(char[] text, int start, int value)
		{
		}

		// Token: 0x0400063D RID: 1597
		[Token(Token = "0x400063D")]
		[FieldOffset(Offset = "0x0")]
		private DateTime dt;

		// Token: 0x0400063E RID: 1598
		[Token(Token = "0x400063E")]
		[FieldOffset(Offset = "0x8")]
		private uint extra;

		// Token: 0x0400063F RID: 1599
		[Token(Token = "0x400063F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int Lzyyyy;

		// Token: 0x04000640 RID: 1600
		[Token(Token = "0x4000640")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int Lzyyyy_;

		// Token: 0x04000641 RID: 1601
		[Token(Token = "0x4000641")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int Lzyyyy_MM;

		// Token: 0x04000642 RID: 1602
		[Token(Token = "0x4000642")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int Lzyyyy_MM_;

		// Token: 0x04000643 RID: 1603
		[Token(Token = "0x4000643")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int Lzyyyy_MM_dd;

		// Token: 0x04000644 RID: 1604
		[Token(Token = "0x4000644")]
		[FieldOffset(Offset = "0x14")]
		private static readonly int Lzyyyy_MM_ddT;

		// Token: 0x04000645 RID: 1605
		[Token(Token = "0x4000645")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int LzHH;

		// Token: 0x04000646 RID: 1606
		[Token(Token = "0x4000646")]
		[FieldOffset(Offset = "0x1C")]
		private static readonly int LzHH_;

		// Token: 0x04000647 RID: 1607
		[Token(Token = "0x4000647")]
		[FieldOffset(Offset = "0x20")]
		private static readonly int LzHH_mm;

		// Token: 0x04000648 RID: 1608
		[Token(Token = "0x4000648")]
		[FieldOffset(Offset = "0x24")]
		private static readonly int LzHH_mm_;

		// Token: 0x04000649 RID: 1609
		[Token(Token = "0x4000649")]
		[FieldOffset(Offset = "0x28")]
		private static readonly int LzHH_mm_ss;

		// Token: 0x0400064A RID: 1610
		[Token(Token = "0x400064A")]
		[FieldOffset(Offset = "0x2C")]
		private static readonly int Lz_;

		// Token: 0x0400064B RID: 1611
		[Token(Token = "0x400064B")]
		[FieldOffset(Offset = "0x30")]
		private static readonly int Lz_zz;

		// Token: 0x0400064C RID: 1612
		[Token(Token = "0x400064C")]
		[FieldOffset(Offset = "0x34")]
		private static readonly int Lz_zz_;

		// Token: 0x0400064D RID: 1613
		[Token(Token = "0x400064D")]
		[FieldOffset(Offset = "0x38")]
		private static readonly int Lz_zz_zz;

		// Token: 0x0400064E RID: 1614
		[Token(Token = "0x400064E")]
		[FieldOffset(Offset = "0x3C")]
		private static readonly int Lz__;

		// Token: 0x0400064F RID: 1615
		[Token(Token = "0x400064F")]
		[FieldOffset(Offset = "0x40")]
		private static readonly int Lz__mm;

		// Token: 0x04000650 RID: 1616
		[Token(Token = "0x4000650")]
		[FieldOffset(Offset = "0x44")]
		private static readonly int Lz__mm_;

		// Token: 0x04000651 RID: 1617
		[Token(Token = "0x4000651")]
		[FieldOffset(Offset = "0x48")]
		private static readonly int Lz__mm__;

		// Token: 0x04000652 RID: 1618
		[Token(Token = "0x4000652")]
		[FieldOffset(Offset = "0x4C")]
		private static readonly int Lz__mm_dd;

		// Token: 0x04000653 RID: 1619
		[Token(Token = "0x4000653")]
		[FieldOffset(Offset = "0x50")]
		private static readonly int Lz___;

		// Token: 0x04000654 RID: 1620
		[Token(Token = "0x4000654")]
		[FieldOffset(Offset = "0x54")]
		private static readonly int Lz___dd;

		// Token: 0x04000655 RID: 1621
		[Token(Token = "0x4000655")]
		[FieldOffset(Offset = "0x58")]
		private static readonly XmlTypeCode[] typeCodes;

		// Token: 0x0200016A RID: 362
		[Token(Token = "0x200016A")]
		private enum DateTimeTypeCode
		{
			// Token: 0x04000657 RID: 1623
			[Token(Token = "0x4000657")]
			DateTime,
			// Token: 0x04000658 RID: 1624
			[Token(Token = "0x4000658")]
			Time,
			// Token: 0x04000659 RID: 1625
			[Token(Token = "0x4000659")]
			Date,
			// Token: 0x0400065A RID: 1626
			[Token(Token = "0x400065A")]
			GYearMonth,
			// Token: 0x0400065B RID: 1627
			[Token(Token = "0x400065B")]
			GYear,
			// Token: 0x0400065C RID: 1628
			[Token(Token = "0x400065C")]
			GMonthDay,
			// Token: 0x0400065D RID: 1629
			[Token(Token = "0x400065D")]
			GDay,
			// Token: 0x0400065E RID: 1630
			[Token(Token = "0x400065E")]
			GMonth,
			// Token: 0x0400065F RID: 1631
			[Token(Token = "0x400065F")]
			XdrDateTime
		}

		// Token: 0x0200016B RID: 363
		[Token(Token = "0x200016B")]
		private enum XsdDateTimeKind
		{
			// Token: 0x04000661 RID: 1633
			[Token(Token = "0x4000661")]
			Unspecified,
			// Token: 0x04000662 RID: 1634
			[Token(Token = "0x4000662")]
			Zulu,
			// Token: 0x04000663 RID: 1635
			[Token(Token = "0x4000663")]
			LocalWestOfZulu,
			// Token: 0x04000664 RID: 1636
			[Token(Token = "0x4000664")]
			LocalEastOfZulu
		}

		// Token: 0x0200016C RID: 364
		[Token(Token = "0x200016C")]
		private struct Parser
		{
			// Token: 0x06000C85 RID: 3205 RVA: 0x00006660 File Offset: 0x00004860
			[Token(Token = "0x6000C85")]
			[Address(RVA = "0x5022720", Offset = "0x5021320", VA = "0x185022720")]
			public bool Parse(string text, XsdDateTimeFlags kinds)
			{
				return default(bool);
			}

			// Token: 0x06000C86 RID: 3206 RVA: 0x00006678 File Offset: 0x00004878
			[Token(Token = "0x6000C86")]
			[Address(RVA = "0x5021CC0", Offset = "0x50208C0", VA = "0x185021CC0")]
			private bool ParseDate(int start)
			{
				return default(bool);
			}

			// Token: 0x06000C87 RID: 3207 RVA: 0x00006690 File Offset: 0x00004890
			[Token(Token = "0x6000C87")]
			[Address(RVA = "0x5021FF0", Offset = "0x5020BF0", VA = "0x185021FF0")]
			private bool ParseTimeAndZoneAndWhitespace(int start)
			{
				return default(bool);
			}

			// Token: 0x06000C88 RID: 3208 RVA: 0x000066A8 File Offset: 0x000048A8
			[Token(Token = "0x6000C88")]
			[Address(RVA = "0x5021F80", Offset = "0x5020B80", VA = "0x185021F80")]
			private bool ParseTimeAndWhitespace(int start)
			{
				return default(bool);
			}

			// Token: 0x06000C89 RID: 3209 RVA: 0x000066C0 File Offset: 0x000048C0
			[Token(Token = "0x6000C89")]
			[Address(RVA = "0x5022080", Offset = "0x5020C80", VA = "0x185022080")]
			private bool ParseTime(ref int start)
			{
				return default(bool);
			}

			// Token: 0x06000C8A RID: 3210 RVA: 0x000066D8 File Offset: 0x000048D8
			[Token(Token = "0x6000C8A")]
			[Address(RVA = "0x5022470", Offset = "0x5021070", VA = "0x185022470")]
			private bool ParseZoneAndWhitespace(int start)
			{
				return default(bool);
			}

			// Token: 0x06000C8B RID: 3211 RVA: 0x000066F0 File Offset: 0x000048F0
			[Token(Token = "0x6000C8B")]
			[Address(RVA = "0x5021B90", Offset = "0x5020790", VA = "0x185021B90")]
			private bool Parse4Dig(int start, ref int num)
			{
				return default(bool);
			}

			// Token: 0x06000C8C RID: 3212 RVA: 0x00006708 File Offset: 0x00004908
			[Token(Token = "0x6000C8C")]
			[Address(RVA = "0x5021B00", Offset = "0x5020700", VA = "0x185021B00")]
			private bool Parse2Dig(int start, ref int num)
			{
				return default(bool);
			}

			// Token: 0x06000C8D RID: 3213 RVA: 0x00006720 File Offset: 0x00004920
			[Token(Token = "0x6000C8D")]
			[Address(RVA = "0x5021C80", Offset = "0x5020880", VA = "0x185021C80")]
			private bool ParseChar(int start, char ch)
			{
				return default(bool);
			}

			// Token: 0x06000C8E RID: 3214 RVA: 0x00006738 File Offset: 0x00004938
			[Token(Token = "0x6000C8E")]
			[Address(RVA = "0x5023760", Offset = "0x5022360", VA = "0x185023760")]
			private static bool Test(XsdDateTimeFlags left, XsdDateTimeFlags right)
			{
				return default(bool);
			}

			// Token: 0x04000665 RID: 1637
			[Token(Token = "0x4000665")]
			[FieldOffset(Offset = "0x0")]
			public XsdDateTime.DateTimeTypeCode typeCode;

			// Token: 0x04000666 RID: 1638
			[Token(Token = "0x4000666")]
			[FieldOffset(Offset = "0x4")]
			public int year;

			// Token: 0x04000667 RID: 1639
			[Token(Token = "0x4000667")]
			[FieldOffset(Offset = "0x8")]
			public int month;

			// Token: 0x04000668 RID: 1640
			[Token(Token = "0x4000668")]
			[FieldOffset(Offset = "0xC")]
			public int day;

			// Token: 0x04000669 RID: 1641
			[Token(Token = "0x4000669")]
			[FieldOffset(Offset = "0x10")]
			public int hour;

			// Token: 0x0400066A RID: 1642
			[Token(Token = "0x400066A")]
			[FieldOffset(Offset = "0x14")]
			public int minute;

			// Token: 0x0400066B RID: 1643
			[Token(Token = "0x400066B")]
			[FieldOffset(Offset = "0x18")]
			public int second;

			// Token: 0x0400066C RID: 1644
			[Token(Token = "0x400066C")]
			[FieldOffset(Offset = "0x1C")]
			public int fraction;

			// Token: 0x0400066D RID: 1645
			[Token(Token = "0x400066D")]
			[FieldOffset(Offset = "0x20")]
			public XsdDateTime.XsdDateTimeKind kind;

			// Token: 0x0400066E RID: 1646
			[Token(Token = "0x400066E")]
			[FieldOffset(Offset = "0x24")]
			public int zoneHour;

			// Token: 0x0400066F RID: 1647
			[Token(Token = "0x400066F")]
			[FieldOffset(Offset = "0x28")]
			public int zoneMinute;

			// Token: 0x04000670 RID: 1648
			[Token(Token = "0x4000670")]
			[FieldOffset(Offset = "0x30")]
			private string text;

			// Token: 0x04000671 RID: 1649
			[Token(Token = "0x4000671")]
			[FieldOffset(Offset = "0x38")]
			private int length;

			// Token: 0x04000672 RID: 1650
			[Token(Token = "0x4000672")]
			[FieldOffset(Offset = "0x0")]
			private static int[] Power10;
		}
	}
}
