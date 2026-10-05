using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000FD RID: 253
	[Token(Token = "0x20000FD")]
	[System.Serializable]
	public readonly struct Int32 : System.IComparable, System.IConvertible, System.IFormattable, System.IComparable<int>, System.IEquatable<int>, ISpanFormattable
	{
		// Token: 0x06000834 RID: 2100 RVA: 0x00008400 File Offset: 0x00006600
		[Token(Token = "0x6000834")]
		[Address(RVA = "0x4CD8ED0", Offset = "0x4CD7AD0", VA = "0x184CD8ED0", Slot = "4")]
		public int CompareTo(object value)
		{
			return 0;
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00008418 File Offset: 0x00006618
		[Token(Token = "0x6000835")]
		[Address(RVA = "0x4CD8FC0", Offset = "0x4CD7BC0", VA = "0x184CD8FC0", Slot = "23")]
		public int CompareTo(int value)
		{
			return 0;
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00008430 File Offset: 0x00006630
		[Token(Token = "0x6000836")]
		[Address(RVA = "0x4CD8FE0", Offset = "0x4CD7BE0", VA = "0x184CD8FE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00008448 File Offset: 0x00006648
		[Token(Token = "0x6000837")]
		[Address(RVA = "0x263CAD0", Offset = "0x263B6D0", VA = "0x18263CAD0", Slot = "24")]
		[NonVersionable]
		public bool Equals(int obj)
		{
			return default(bool);
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00008460 File Offset: 0x00006660
		[Token(Token = "0x6000838")]
		[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000839")]
		[Address(RVA = "0x4CD9970", Offset = "0x4CD8570", VA = "0x184CD9970", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600083A")]
		[Address(RVA = "0x4CD9A80", Offset = "0x4CD8680", VA = "0x184CD9A80")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600083B")]
		[Address(RVA = "0x4CD99F0", Offset = "0x4CD85F0", VA = "0x184CD99F0", Slot = "20")]
		public string ToString(System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600083C")]
		[Address(RVA = "0x4CD9B40", Offset = "0x4CD8740", VA = "0x184CD9B40", Slot = "22")]
		public string ToString(string format, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x00008478 File Offset: 0x00006678
		[Token(Token = "0x600083D")]
		[Address(RVA = "0x4CD9C10", Offset = "0x4CD8810", VA = "0x184CD9C10", Slot = "25")]
		public bool TryFormat(System.Span<char> destination, out int charsWritten, [System.Runtime.InteropServices.Optional] System.ReadOnlySpan<char> format, [System.Runtime.InteropServices.Optional] System.IFormatProvider provider)
		{
			return default(bool);
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00008490 File Offset: 0x00006690
		[Token(Token = "0x600083E")]
		[Address(RVA = "0x4CD9060", Offset = "0x4CD7C60", VA = "0x184CD9060")]
		public static int Parse(string s)
		{
			return 0;
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x000084A8 File Offset: 0x000066A8
		[Token(Token = "0x600083F")]
		[Address(RVA = "0x4CD9390", Offset = "0x4CD7F90", VA = "0x184CD9390")]
		public static int Parse(string s, System.Globalization.NumberStyles style)
		{
			return 0;
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x000084C0 File Offset: 0x000066C0
		[Token(Token = "0x6000840")]
		[Address(RVA = "0x4CD92B0", Offset = "0x4CD7EB0", VA = "0x184CD92B0")]
		public static int Parse(string s, System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x000084D8 File Offset: 0x000066D8
		[Token(Token = "0x6000841")]
		[Address(RVA = "0x4CD9130", Offset = "0x4CD7D30", VA = "0x184CD9130")]
		public static int Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x000084F0 File Offset: 0x000066F0
		[Token(Token = "0x6000842")]
		[Address(RVA = "0x4CD9220", Offset = "0x4CD7E20", VA = "0x184CD9220")]
		public static int Parse(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles style = System.Globalization.NumberStyles.Integer, [System.Runtime.InteropServices.Optional] System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00008508 File Offset: 0x00006708
		[Token(Token = "0x6000843")]
		[Address(RVA = "0x4CD9E40", Offset = "0x4CD8A40", VA = "0x184CD9E40")]
		public static bool TryParse(string s, out int result)
		{
			return default(bool);
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00008520 File Offset: 0x00006720
		[Token(Token = "0x6000844")]
		[Address(RVA = "0x4CD9D50", Offset = "0x4CD8950", VA = "0x184CD9D50")]
		public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out int result)
		{
			return default(bool);
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00008538 File Offset: 0x00006738
		[Token(Token = "0x6000845")]
		[Address(RVA = "0x4CD9CB0", Offset = "0x4CD88B0", VA = "0x184CD9CB0")]
		public static bool TryParse(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out int result)
		{
			return default(bool);
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00008550 File Offset: 0x00006750
		[Token(Token = "0x6000846")]
		[Address(RVA = "0x54AFD0", Offset = "0x549BD0", VA = "0x18054AFD0", Slot = "5")]
		public System.TypeCode GetTypeCode()
		{
			return System.TypeCode.Empty;
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x00008568 File Offset: 0x00006768
		[Token(Token = "0x6000847")]
		[Address(RVA = "0x4CD9470", Offset = "0x4CD8070", VA = "0x184CD9470", Slot = "6")]
		private bool ToBoolean(System.IFormatProvider provider)
		{
			return default(bool);
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00008580 File Offset: 0x00006780
		[Token(Token = "0x6000848")]
		[Address(RVA = "0x4CD9510", Offset = "0x4CD8110", VA = "0x184CD9510", Slot = "7")]
		private char ToChar(System.IFormatProvider provider)
		{
			return '\0';
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00008598 File Offset: 0x00006798
		[Token(Token = "0x6000849")]
		[Address(RVA = "0x4CD9750", Offset = "0x4CD8350", VA = "0x184CD9750", Slot = "8")]
		private sbyte ToSByte(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x000085B0 File Offset: 0x000067B0
		[Token(Token = "0x600084A")]
		[Address(RVA = "0x4CD94C0", Offset = "0x4CD80C0", VA = "0x184CD94C0", Slot = "9")]
		private byte ToByte(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x000085C8 File Offset: 0x000067C8
		[Token(Token = "0x600084B")]
		[Address(RVA = "0x4CD96B0", Offset = "0x4CD82B0", VA = "0x184CD96B0", Slot = "10")]
		private short ToInt16(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x000085E0 File Offset: 0x000067E0
		[Token(Token = "0x600084C")]
		[Address(RVA = "0x4CD9880", Offset = "0x4CD8480", VA = "0x184CD9880", Slot = "11")]
		private ushort ToUInt16(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x000085F8 File Offset: 0x000067F8
		[Token(Token = "0x600084D")]
		[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260", Slot = "12")]
		private int ToInt32(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00008610 File Offset: 0x00006810
		[Token(Token = "0x600084E")]
		[Address(RVA = "0x4CD98D0", Offset = "0x4CD84D0", VA = "0x184CD98D0", Slot = "13")]
		private uint ToUInt32(System.IFormatProvider provider)
		{
			return 0U;
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00008628 File Offset: 0x00006828
		[Token(Token = "0x600084F")]
		[Address(RVA = "0x4CD9700", Offset = "0x4CD8300", VA = "0x184CD9700", Slot = "14")]
		private long ToInt64(System.IFormatProvider provider)
		{
			return 0L;
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00008640 File Offset: 0x00006840
		[Token(Token = "0x6000850")]
		[Address(RVA = "0x4CD9920", Offset = "0x4CD8520", VA = "0x184CD9920", Slot = "15")]
		private ulong ToUInt64(System.IFormatProvider provider)
		{
			return 0UL;
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00008658 File Offset: 0x00006858
		[Token(Token = "0x6000851")]
		[Address(RVA = "0x4CD97A0", Offset = "0x4CD83A0", VA = "0x184CD97A0", Slot = "16")]
		private float ToSingle(System.IFormatProvider provider)
		{
			return 0f;
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00008670 File Offset: 0x00006870
		[Token(Token = "0x6000852")]
		[Address(RVA = "0x4CD9660", Offset = "0x4CD8260", VA = "0x184CD9660", Slot = "17")]
		private double ToDouble(System.IFormatProvider provider)
		{
			return 0.0;
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00008688 File Offset: 0x00006888
		[Token(Token = "0x6000853")]
		[Address(RVA = "0x4CD95F0", Offset = "0x4CD81F0", VA = "0x184CD95F0", Slot = "18")]
		private decimal ToDecimal(System.IFormatProvider provider)
		{
			return 0m;
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x000086A0 File Offset: 0x000068A0
		[Token(Token = "0x6000854")]
		[Address(RVA = "0x4CD9560", Offset = "0x4CD8160", VA = "0x184CD9560", Slot = "19")]
		private System.DateTime ToDateTime(System.IFormatProvider provider)
		{
			return default(System.DateTime);
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000855")]
		[Address(RVA = "0x4CD97F0", Offset = "0x4CD83F0", VA = "0x184CD97F0", Slot = "21")]
		private object ToType(System.Type type, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x04000437 RID: 1079
		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly int m_value;

		// Token: 0x04000438 RID: 1080
		[Token(Token = "0x4000438")]
		public const int MaxValue = 2147483647;

		// Token: 0x04000439 RID: 1081
		[Token(Token = "0x4000439")]
		public const int MinValue = -2147483648;
	}
}
