using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000149 RID: 329
	[Token(Token = "0x2000149")]
	[System.CLSCompliant(false)]
	[System.Serializable]
	public readonly struct UInt64 : System.IComparable, System.IConvertible, System.IFormattable, System.IComparable<ulong>, System.IEquatable<ulong>, ISpanFormattable
	{
		// Token: 0x06000BBD RID: 3005 RVA: 0x0000B2F8 File Offset: 0x000094F8
		[Token(Token = "0x6000BBD")]
		[Address(RVA = "0x4D08CF0", Offset = "0x4D078F0", VA = "0x184D08CF0", Slot = "4")]
		public int CompareTo(object value)
		{
			return 0;
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x0000B310 File Offset: 0x00009510
		[Token(Token = "0x6000BBE")]
		[Address(RVA = "0x4D08CD0", Offset = "0x4D078D0", VA = "0x184D08CD0", Slot = "23")]
		public int CompareTo(ulong value)
		{
			return 0;
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x0000B328 File Offset: 0x00009528
		[Token(Token = "0x6000BBF")]
		[Address(RVA = "0x4D08DE0", Offset = "0x4D079E0", VA = "0x184D08DE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x0000B340 File Offset: 0x00009540
		[Token(Token = "0x6000BC0")]
		[Address(RVA = "0x4CDA030", Offset = "0x4CD8C30", VA = "0x184CDA030", Slot = "24")]
		[NonVersionable]
		public bool Equals(ulong obj)
		{
			return default(bool);
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x0000B358 File Offset: 0x00009558
		[Token(Token = "0x6000BC1")]
		[Address(RVA = "0x4D08E70", Offset = "0x4D07A70", VA = "0x184D08E70", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000BC2")]
		[Address(RVA = "0x4D098F0", Offset = "0x4D084F0", VA = "0x184D098F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000BC3")]
		[Address(RVA = "0x4D09860", Offset = "0x4D08460", VA = "0x184D09860", Slot = "20")]
		public string ToString(System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000BC4")]
		[Address(RVA = "0x4D096D0", Offset = "0x4D082D0", VA = "0x184D096D0")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000BC5")]
		[Address(RVA = "0x4D09790", Offset = "0x4D08390", VA = "0x184D09790", Slot = "22")]
		public string ToString(string format, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x0000B370 File Offset: 0x00009570
		[Token(Token = "0x6000BC6")]
		[Address(RVA = "0x4D09970", Offset = "0x4D08570", VA = "0x184D09970", Slot = "25")]
		public bool TryFormat(System.Span<char> destination, out int charsWritten, [System.Runtime.InteropServices.Optional] System.ReadOnlySpan<char> format, [System.Runtime.InteropServices.Optional] System.IFormatProvider provider)
		{
			return default(bool);
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x0000B388 File Offset: 0x00009588
		[Token(Token = "0x6000BC7")]
		[Address(RVA = "0x4D09020", Offset = "0x4D07C20", VA = "0x184D09020")]
		[System.CLSCompliant(false)]
		public static ulong Parse(string s)
		{
			return 0UL;
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x0000B3A0 File Offset: 0x000095A0
		[Token(Token = "0x6000BC8")]
		[Address(RVA = "0x4D08F50", Offset = "0x4D07B50", VA = "0x184D08F50")]
		[System.CLSCompliant(false)]
		public static ulong Parse(string s, System.Globalization.NumberStyles style)
		{
			return 0UL;
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x0000B3B8 File Offset: 0x000095B8
		[Token(Token = "0x6000BC9")]
		[Address(RVA = "0x4D08E80", Offset = "0x4D07A80", VA = "0x184D08E80")]
		[System.CLSCompliant(false)]
		public static ulong Parse(string s, System.IFormatProvider provider)
		{
			return 0UL;
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x0000B3D0 File Offset: 0x000095D0
		[Token(Token = "0x6000BCA")]
		[Address(RVA = "0x4D090E0", Offset = "0x4D07CE0", VA = "0x184D090E0")]
		[System.CLSCompliant(false)]
		public static ulong Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider)
		{
			return 0UL;
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x0000B3E8 File Offset: 0x000095E8
		[Token(Token = "0x6000BCB")]
		[Address(RVA = "0x4D09B20", Offset = "0x4D08720", VA = "0x184D09B20")]
		[System.CLSCompliant(false)]
		public static bool TryParse(string s, out ulong result)
		{
			return default(bool);
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x0000B400 File Offset: 0x00009600
		[Token(Token = "0x6000BCC")]
		[Address(RVA = "0x4D09A20", Offset = "0x4D08620", VA = "0x184D09A20")]
		[System.CLSCompliant(false)]
		public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out ulong result)
		{
			return default(bool);
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x0000B418 File Offset: 0x00009618
		[Token(Token = "0x6000BCD")]
		[Address(RVA = "0x21127B0", Offset = "0x21113B0", VA = "0x1821127B0", Slot = "5")]
		public System.TypeCode GetTypeCode()
		{
			return System.TypeCode.Empty;
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x0000B430 File Offset: 0x00009630
		[Token(Token = "0x6000BCE")]
		[Address(RVA = "0x4D091C0", Offset = "0x4D07DC0", VA = "0x184D091C0", Slot = "6")]
		private bool ToBoolean(System.IFormatProvider provider)
		{
			return default(bool);
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x0000B448 File Offset: 0x00009648
		[Token(Token = "0x6000BCF")]
		[Address(RVA = "0x4D09260", Offset = "0x4D07E60", VA = "0x184D09260", Slot = "7")]
		private char ToChar(System.IFormatProvider provider)
		{
			return '\0';
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x0000B460 File Offset: 0x00009660
		[Token(Token = "0x6000BD0")]
		[Address(RVA = "0x4D094F0", Offset = "0x4D080F0", VA = "0x184D094F0", Slot = "8")]
		private sbyte ToSByte(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x0000B478 File Offset: 0x00009678
		[Token(Token = "0x6000BD1")]
		[Address(RVA = "0x4D09210", Offset = "0x4D07E10", VA = "0x184D09210", Slot = "9")]
		private byte ToByte(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x0000B490 File Offset: 0x00009690
		[Token(Token = "0x6000BD2")]
		[Address(RVA = "0x4D09400", Offset = "0x4D08000", VA = "0x184D09400", Slot = "10")]
		private short ToInt16(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x0000B4A8 File Offset: 0x000096A8
		[Token(Token = "0x6000BD3")]
		[Address(RVA = "0x4D09630", Offset = "0x4D08230", VA = "0x184D09630", Slot = "11")]
		private ushort ToUInt16(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x0000B4C0 File Offset: 0x000096C0
		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0x4D09450", Offset = "0x4D08050", VA = "0x184D09450", Slot = "12")]
		private int ToInt32(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x0000B4D8 File Offset: 0x000096D8
		[Token(Token = "0x6000BD5")]
		[Address(RVA = "0x4D09680", Offset = "0x4D08280", VA = "0x184D09680", Slot = "13")]
		private uint ToUInt32(System.IFormatProvider provider)
		{
			return 0U;
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x0000B4F0 File Offset: 0x000096F0
		[Token(Token = "0x6000BD6")]
		[Address(RVA = "0x4D094A0", Offset = "0x4D080A0", VA = "0x184D094A0", Slot = "14")]
		private long ToInt64(System.IFormatProvider provider)
		{
			return 0L;
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x0000B508 File Offset: 0x00009708
		[Token(Token = "0x6000BD7")]
		[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550", Slot = "15")]
		private ulong ToUInt64(System.IFormatProvider provider)
		{
			return 0UL;
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x0000B520 File Offset: 0x00009720
		[Token(Token = "0x6000BD8")]
		[Address(RVA = "0x4D09540", Offset = "0x4D08140", VA = "0x184D09540", Slot = "16")]
		private float ToSingle(System.IFormatProvider provider)
		{
			return 0f;
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x0000B538 File Offset: 0x00009738
		[Token(Token = "0x6000BD9")]
		[Address(RVA = "0x4D093B0", Offset = "0x4D07FB0", VA = "0x184D093B0", Slot = "17")]
		private double ToDouble(System.IFormatProvider provider)
		{
			return 0.0;
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x0000B550 File Offset: 0x00009750
		[Token(Token = "0x6000BDA")]
		[Address(RVA = "0x4D09340", Offset = "0x4D07F40", VA = "0x184D09340", Slot = "18")]
		private decimal ToDecimal(System.IFormatProvider provider)
		{
			return 0m;
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x0000B568 File Offset: 0x00009768
		[Token(Token = "0x6000BDB")]
		[Address(RVA = "0x4D092B0", Offset = "0x4D07EB0", VA = "0x184D092B0", Slot = "19")]
		private System.DateTime ToDateTime(System.IFormatProvider provider)
		{
			return default(System.DateTime);
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000BDC")]
		[Address(RVA = "0x4D09590", Offset = "0x4D08190", VA = "0x184D09590", Slot = "21")]
		private object ToType(System.Type type, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x040004ED RID: 1261
		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ulong m_value;

		// Token: 0x040004EE RID: 1262
		[Token(Token = "0x40004EE")]
		public const ulong MaxValue = 18446744073709551615UL;

		// Token: 0x040004EF RID: 1263
		[Token(Token = "0x40004EF")]
		public const ulong MinValue = 0UL;
	}
}
