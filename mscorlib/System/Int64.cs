using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000FE RID: 254
	[Token(Token = "0x20000FE")]
	[System.Serializable]
	public readonly struct Int64 : System.IComparable, System.IConvertible, System.IFormattable, System.IComparable<long>, System.IEquatable<long>, ISpanFormattable
	{
		// Token: 0x06000856 RID: 2134 RVA: 0x000086B8 File Offset: 0x000068B8
		[Token(Token = "0x6000856")]
		[Address(RVA = "0x4CD9F20", Offset = "0x4CD8B20", VA = "0x184CD9F20", Slot = "4")]
		public int CompareTo(object value)
		{
			return 0;
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x000086D0 File Offset: 0x000068D0
		[Token(Token = "0x6000857")]
		[Address(RVA = "0x4CDA010", Offset = "0x4CD8C10", VA = "0x184CDA010", Slot = "23")]
		public int CompareTo(long value)
		{
			return 0;
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x000086E8 File Offset: 0x000068E8
		[Token(Token = "0x6000858")]
		[Address(RVA = "0x4CDA040", Offset = "0x4CD8C40", VA = "0x184CDA040", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00008700 File Offset: 0x00006900
		[Token(Token = "0x6000859")]
		[Address(RVA = "0x4CDA030", Offset = "0x4CD8C30", VA = "0x184CDA030", Slot = "24")]
		[NonVersionable]
		public bool Equals(long obj)
		{
			return default(bool);
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00008718 File Offset: 0x00006918
		[Token(Token = "0x600085A")]
		[Address(RVA = "0x4CDA0D0", Offset = "0x4CD8CD0", VA = "0x184CDA0D0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600085B")]
		[Address(RVA = "0x4CDA890", Offset = "0x4CD9490", VA = "0x184CDA890", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600085C")]
		[Address(RVA = "0x4CDA910", Offset = "0x4CD9510", VA = "0x184CDA910", Slot = "20")]
		public string ToString(System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600085D")]
		[Address(RVA = "0x4CDAA70", Offset = "0x4CD9670", VA = "0x184CDAA70")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600085E")]
		[Address(RVA = "0x4CDA9A0", Offset = "0x4CD95A0", VA = "0x184CDA9A0", Slot = "22")]
		public string ToString(string format, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00008730 File Offset: 0x00006930
		[Token(Token = "0x600085F")]
		[Address(RVA = "0x4CDAB30", Offset = "0x4CD9730", VA = "0x184CDAB30", Slot = "25")]
		public bool TryFormat(System.Span<char> destination, out int charsWritten, [System.Runtime.InteropServices.Optional] System.ReadOnlySpan<char> format, [System.Runtime.InteropServices.Optional] System.IFormatProvider provider)
		{
			return default(bool);
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00008748 File Offset: 0x00006948
		[Token(Token = "0x6000860")]
		[Address(RVA = "0x4CDA1D0", Offset = "0x4CD8DD0", VA = "0x184CDA1D0")]
		public static long Parse(string s)
		{
			return 0L;
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00008760 File Offset: 0x00006960
		[Token(Token = "0x6000861")]
		[Address(RVA = "0x4CDA2A0", Offset = "0x4CD8EA0", VA = "0x184CDA2A0")]
		public static long Parse(string s, System.IFormatProvider provider)
		{
			return 0L;
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00008778 File Offset: 0x00006978
		[Token(Token = "0x6000862")]
		[Address(RVA = "0x4CDA0E0", Offset = "0x4CD8CE0", VA = "0x184CDA0E0")]
		public static long Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider)
		{
			return 0L;
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00008790 File Offset: 0x00006990
		[Token(Token = "0x6000863")]
		[Address(RVA = "0x4CDABE0", Offset = "0x4CD97E0", VA = "0x184CDABE0")]
		public static bool TryParse(string s, out long result)
		{
			return default(bool);
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x000087A8 File Offset: 0x000069A8
		[Token(Token = "0x6000864")]
		[Address(RVA = "0x4CDACC0", Offset = "0x4CD98C0", VA = "0x184CDACC0")]
		public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out long result)
		{
			return default(bool);
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x000087C0 File Offset: 0x000069C0
		[Token(Token = "0x6000865")]
		[Address(RVA = "0x2110790", Offset = "0x210F390", VA = "0x182110790", Slot = "5")]
		public System.TypeCode GetTypeCode()
		{
			return System.TypeCode.Empty;
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x000087D8 File Offset: 0x000069D8
		[Token(Token = "0x6000866")]
		[Address(RVA = "0x4CDA380", Offset = "0x4CD8F80", VA = "0x184CDA380", Slot = "6")]
		private bool ToBoolean(System.IFormatProvider provider)
		{
			return default(bool);
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x000087F0 File Offset: 0x000069F0
		[Token(Token = "0x6000867")]
		[Address(RVA = "0x4CDA420", Offset = "0x4CD9020", VA = "0x184CDA420", Slot = "7")]
		private char ToChar(System.IFormatProvider provider)
		{
			return '\0';
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00008808 File Offset: 0x00006A08
		[Token(Token = "0x6000868")]
		[Address(RVA = "0x4CDA660", Offset = "0x4CD9260", VA = "0x184CDA660", Slot = "8")]
		private sbyte ToSByte(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00008820 File Offset: 0x00006A20
		[Token(Token = "0x6000869")]
		[Address(RVA = "0x4CDA3D0", Offset = "0x4CD8FD0", VA = "0x184CDA3D0", Slot = "9")]
		private byte ToByte(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00008838 File Offset: 0x00006A38
		[Token(Token = "0x600086A")]
		[Address(RVA = "0x4CDA5C0", Offset = "0x4CD91C0", VA = "0x184CDA5C0", Slot = "10")]
		private short ToInt16(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00008850 File Offset: 0x00006A50
		[Token(Token = "0x600086B")]
		[Address(RVA = "0x4CDA7A0", Offset = "0x4CD93A0", VA = "0x184CDA7A0", Slot = "11")]
		private ushort ToUInt16(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00008868 File Offset: 0x00006A68
		[Token(Token = "0x600086C")]
		[Address(RVA = "0x4CDA610", Offset = "0x4CD9210", VA = "0x184CDA610", Slot = "12")]
		private int ToInt32(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00008880 File Offset: 0x00006A80
		[Token(Token = "0x600086D")]
		[Address(RVA = "0x4CDA7F0", Offset = "0x4CD93F0", VA = "0x184CDA7F0", Slot = "13")]
		private uint ToUInt32(System.IFormatProvider provider)
		{
			return 0U;
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00008898 File Offset: 0x00006A98
		[Token(Token = "0x600086E")]
		[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550", Slot = "14")]
		private long ToInt64(System.IFormatProvider provider)
		{
			return 0L;
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x000088B0 File Offset: 0x00006AB0
		[Token(Token = "0x600086F")]
		[Address(RVA = "0x4CDA840", Offset = "0x4CD9440", VA = "0x184CDA840", Slot = "15")]
		private ulong ToUInt64(System.IFormatProvider provider)
		{
			return 0UL;
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x000088C8 File Offset: 0x00006AC8
		[Token(Token = "0x6000870")]
		[Address(RVA = "0x4CDA6B0", Offset = "0x4CD92B0", VA = "0x184CDA6B0", Slot = "16")]
		private float ToSingle(System.IFormatProvider provider)
		{
			return 0f;
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x000088E0 File Offset: 0x00006AE0
		[Token(Token = "0x6000871")]
		[Address(RVA = "0x4CDA570", Offset = "0x4CD9170", VA = "0x184CDA570", Slot = "17")]
		private double ToDouble(System.IFormatProvider provider)
		{
			return 0.0;
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x000088F8 File Offset: 0x00006AF8
		[Token(Token = "0x6000872")]
		[Address(RVA = "0x4CDA500", Offset = "0x4CD9100", VA = "0x184CDA500", Slot = "18")]
		private decimal ToDecimal(System.IFormatProvider provider)
		{
			return 0m;
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00008910 File Offset: 0x00006B10
		[Token(Token = "0x6000873")]
		[Address(RVA = "0x4CDA470", Offset = "0x4CD9070", VA = "0x184CDA470", Slot = "19")]
		private System.DateTime ToDateTime(System.IFormatProvider provider)
		{
			return default(System.DateTime);
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000874")]
		[Address(RVA = "0x4CDA700", Offset = "0x4CD9300", VA = "0x184CDA700", Slot = "21")]
		private object ToType(System.Type type, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x0400043A RID: 1082
		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly long m_value;

		// Token: 0x0400043B RID: 1083
		[Token(Token = "0x400043B")]
		public const long MaxValue = 9223372036854775807L;

		// Token: 0x0400043C RID: 1084
		[Token(Token = "0x400043C")]
		public const long MinValue = -9223372036854775808L;
	}
}
