using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000FC RID: 252
	[Token(Token = "0x20000FC")]
	[System.Serializable]
	public readonly struct Int16 : System.IComparable, System.IConvertible, System.IFormattable, System.IComparable<short>, System.IEquatable<short>, ISpanFormattable
	{
		// Token: 0x06000815 RID: 2069 RVA: 0x00008190 File Offset: 0x00006390
		[Token(Token = "0x6000815")]
		[Address(RVA = "0x4CD7F30", Offset = "0x4CD6B30", VA = "0x184CD7F30", Slot = "4")]
		public int CompareTo(object value)
		{
			return 0;
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x000081A8 File Offset: 0x000063A8
		[Token(Token = "0x6000816")]
		[Address(RVA = "0x4CD8010", Offset = "0x4CD6C10", VA = "0x184CD8010", Slot = "23")]
		public int CompareTo(short value)
		{
			return 0;
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x000081C0 File Offset: 0x000063C0
		[Token(Token = "0x6000817")]
		[Address(RVA = "0x4CD8020", Offset = "0x4CD6C20", VA = "0x184CD8020", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x000081D8 File Offset: 0x000063D8
		[Token(Token = "0x6000818")]
		[Address(RVA = "0x4CA90E0", Offset = "0x4CA7CE0", VA = "0x184CA90E0", Slot = "24")]
		[NonVersionable]
		public bool Equals(short obj)
		{
			return default(bool);
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x000081F0 File Offset: 0x000063F0
		[Token(Token = "0x6000819")]
		[Address(RVA = "0x4CD80B0", Offset = "0x4CD6CB0", VA = "0x184CD80B0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600081A")]
		[Address(RVA = "0x4CD8B20", Offset = "0x4CD7720", VA = "0x184CD8B20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600081B")]
		[Address(RVA = "0x4CD8A80", Offset = "0x4CD7680", VA = "0x184CD8A80", Slot = "20")]
		public string ToString(System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600081C")]
		[Address(RVA = "0x4CD8B10", Offset = "0x4CD7710", VA = "0x184CD8B10")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600081D")]
		[Address(RVA = "0x4CD88F0", Offset = "0x4CD74F0", VA = "0x184CD88F0", Slot = "22")]
		public string ToString(string format, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00008208 File Offset: 0x00006408
		[Token(Token = "0x600081E")]
		[Address(RVA = "0x4CD8BA0", Offset = "0x4CD77A0", VA = "0x184CD8BA0", Slot = "25")]
		public bool TryFormat(System.Span<char> destination, out int charsWritten, [System.Runtime.InteropServices.Optional] System.ReadOnlySpan<char> format, [System.Runtime.InteropServices.Optional] System.IFormatProvider provider)
		{
			return default(bool);
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x00008220 File Offset: 0x00006420
		[Token(Token = "0x600081F")]
		[Address(RVA = "0x4CD80C0", Offset = "0x4CD6CC0", VA = "0x184CD80C0")]
		public static short Parse(string s, System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x00008238 File Offset: 0x00006438
		[Token(Token = "0x6000820")]
		[Address(RVA = "0x4CD8170", Offset = "0x4CD6D70", VA = "0x184CD8170")]
		public static short Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00008250 File Offset: 0x00006450
		[Token(Token = "0x6000821")]
		[Address(RVA = "0x4CD8230", Offset = "0x4CD6E30", VA = "0x184CD8230")]
		private static short Parse(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles style, System.Globalization.NumberFormatInfo info)
		{
			return 0;
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00008268 File Offset: 0x00006468
		[Token(Token = "0x6000822")]
		[Address(RVA = "0x4CD8DB0", Offset = "0x4CD79B0", VA = "0x184CD8DB0")]
		public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out short result)
		{
			return default(bool);
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00008280 File Offset: 0x00006480
		[Token(Token = "0x6000823")]
		[Address(RVA = "0x4CD8CE0", Offset = "0x4CD78E0", VA = "0x184CD8CE0")]
		private static bool TryParse(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles style, System.Globalization.NumberFormatInfo info, out short result)
		{
			return default(bool);
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00008298 File Offset: 0x00006498
		[Token(Token = "0x6000824")]
		[Address(RVA = "0x54AC30", Offset = "0x549830", VA = "0x18054AC30", Slot = "5")]
		public System.TypeCode GetTypeCode()
		{
			return System.TypeCode.Empty;
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x000082B0 File Offset: 0x000064B0
		[Token(Token = "0x6000825")]
		[Address(RVA = "0x4CD83E0", Offset = "0x4CD6FE0", VA = "0x184CD83E0", Slot = "6")]
		private bool ToBoolean(System.IFormatProvider provider)
		{
			return default(bool);
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x000082C8 File Offset: 0x000064C8
		[Token(Token = "0x6000826")]
		[Address(RVA = "0x4CD8480", Offset = "0x4CD7080", VA = "0x184CD8480", Slot = "7")]
		private char ToChar(System.IFormatProvider provider)
		{
			return '\0';
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x000082E0 File Offset: 0x000064E0
		[Token(Token = "0x6000827")]
		[Address(RVA = "0x4CD86C0", Offset = "0x4CD72C0", VA = "0x184CD86C0", Slot = "8")]
		private sbyte ToSByte(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x000082F8 File Offset: 0x000064F8
		[Token(Token = "0x6000828")]
		[Address(RVA = "0x4CD8430", Offset = "0x4CD7030", VA = "0x184CD8430", Slot = "9")]
		private byte ToByte(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00008310 File Offset: 0x00006510
		[Token(Token = "0x6000829")]
		[Address(RVA = "0x3D28B50", Offset = "0x3D27750", VA = "0x183D28B50", Slot = "10")]
		private short ToInt16(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00008328 File Offset: 0x00006528
		[Token(Token = "0x600082A")]
		[Address(RVA = "0x4CD8800", Offset = "0x4CD7400", VA = "0x184CD8800", Slot = "11")]
		private ushort ToUInt16(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00008340 File Offset: 0x00006540
		[Token(Token = "0x600082B")]
		[Address(RVA = "0x4CD8620", Offset = "0x4CD7220", VA = "0x184CD8620", Slot = "12")]
		private int ToInt32(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00008358 File Offset: 0x00006558
		[Token(Token = "0x600082C")]
		[Address(RVA = "0x4CD8850", Offset = "0x4CD7450", VA = "0x184CD8850", Slot = "13")]
		private uint ToUInt32(System.IFormatProvider provider)
		{
			return 0U;
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00008370 File Offset: 0x00006570
		[Token(Token = "0x600082D")]
		[Address(RVA = "0x4CD8670", Offset = "0x4CD7270", VA = "0x184CD8670", Slot = "14")]
		private long ToInt64(System.IFormatProvider provider)
		{
			return 0L;
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00008388 File Offset: 0x00006588
		[Token(Token = "0x600082E")]
		[Address(RVA = "0x4CD88A0", Offset = "0x4CD74A0", VA = "0x184CD88A0", Slot = "15")]
		private ulong ToUInt64(System.IFormatProvider provider)
		{
			return 0UL;
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x000083A0 File Offset: 0x000065A0
		[Token(Token = "0x600082F")]
		[Address(RVA = "0x4CD8710", Offset = "0x4CD7310", VA = "0x184CD8710", Slot = "16")]
		private float ToSingle(System.IFormatProvider provider)
		{
			return 0f;
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x000083B8 File Offset: 0x000065B8
		[Token(Token = "0x6000830")]
		[Address(RVA = "0x4CD85D0", Offset = "0x4CD71D0", VA = "0x184CD85D0", Slot = "17")]
		private double ToDouble(System.IFormatProvider provider)
		{
			return 0.0;
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x000083D0 File Offset: 0x000065D0
		[Token(Token = "0x6000831")]
		[Address(RVA = "0x4CD8560", Offset = "0x4CD7160", VA = "0x184CD8560", Slot = "18")]
		private decimal ToDecimal(System.IFormatProvider provider)
		{
			return 0m;
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x000083E8 File Offset: 0x000065E8
		[Token(Token = "0x6000832")]
		[Address(RVA = "0x4CD84D0", Offset = "0x4CD70D0", VA = "0x184CD84D0", Slot = "19")]
		private System.DateTime ToDateTime(System.IFormatProvider provider)
		{
			return default(System.DateTime);
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000833")]
		[Address(RVA = "0x4CD8760", Offset = "0x4CD7360", VA = "0x184CD8760", Slot = "21")]
		private object ToType(System.Type type, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x04000434 RID: 1076
		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly short m_value;

		// Token: 0x04000435 RID: 1077
		[Token(Token = "0x4000435")]
		public const short MaxValue = 32767;

		// Token: 0x04000436 RID: 1078
		[Token(Token = "0x4000436")]
		public const short MinValue = -32768;
	}
}
