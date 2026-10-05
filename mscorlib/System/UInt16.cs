using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000147 RID: 327
	[Token(Token = "0x2000147")]
	[System.CLSCompliant(false)]
	[System.Serializable]
	public readonly struct UInt16 : System.IComparable, System.IConvertible, System.IFormattable, System.IComparable<ushort>, System.IEquatable<ushort>, ISpanFormattable
	{
		// Token: 0x06000B7C RID: 2940 RVA: 0x0000ADD0 File Offset: 0x00008FD0
		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0x4D06E70", Offset = "0x4D05A70", VA = "0x184D06E70", Slot = "4")]
		public int CompareTo(object value)
		{
			return 0;
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x0000ADE8 File Offset: 0x00008FE8
		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0x4CA8CC0", Offset = "0x4CA78C0", VA = "0x184CA8CC0", Slot = "23")]
		public int CompareTo(ushort value)
		{
			return 0;
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x0000AE00 File Offset: 0x00009000
		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0x4D06F50", Offset = "0x4D05B50", VA = "0x184D06F50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x0000AE18 File Offset: 0x00009018
		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0x4CA90E0", Offset = "0x4CA7CE0", VA = "0x184CA90E0", Slot = "24")]
		[NonVersionable]
		public bool Equals(ushort obj)
		{
			return default(bool);
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x0000AE30 File Offset: 0x00009030
		[Token(Token = "0x6000B80")]
		[Address(RVA = "0x3D28B50", Offset = "0x3D27750", VA = "0x183D28B50", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x4D077F0", Offset = "0x4D063F0", VA = "0x184D077F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B82")]
		[Address(RVA = "0x4D07A00", Offset = "0x4D06600", VA = "0x184D07A00", Slot = "20")]
		public string ToString(System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B83")]
		[Address(RVA = "0x4D07870", Offset = "0x4D06470", VA = "0x184D07870")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B84")]
		[Address(RVA = "0x4D07930", Offset = "0x4D06530", VA = "0x184D07930", Slot = "22")]
		public string ToString(string format, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x0000AE48 File Offset: 0x00009048
		[Token(Token = "0x6000B85")]
		[Address(RVA = "0x4D07A90", Offset = "0x4D06690", VA = "0x184D07A90", Slot = "25")]
		public bool TryFormat(System.Span<char> destination, out int charsWritten, [System.Runtime.InteropServices.Optional] System.ReadOnlySpan<char> format, [System.Runtime.InteropServices.Optional] System.IFormatProvider provider)
		{
			return default(bool);
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x0000AE60 File Offset: 0x00009060
		[Token(Token = "0x6000B86")]
		[Address(RVA = "0x4D07120", Offset = "0x4D05D20", VA = "0x184D07120")]
		[System.CLSCompliant(false)]
		public static ushort Parse(string s)
		{
			return 0;
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x0000AE78 File Offset: 0x00009078
		[Token(Token = "0x6000B87")]
		[Address(RVA = "0x4D06FE0", Offset = "0x4D05BE0", VA = "0x184D06FE0")]
		[System.CLSCompliant(false)]
		public static ushort Parse(string s, System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x0000AE90 File Offset: 0x00009090
		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x4D07070", Offset = "0x4D05C70", VA = "0x184D07070")]
		[System.CLSCompliant(false)]
		public static ushort Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x0000AEA8 File Offset: 0x000090A8
		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x4D071A0", Offset = "0x4D05DA0", VA = "0x184D071A0")]
		private static ushort Parse(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles style, System.Globalization.NumberFormatInfo info)
		{
			return 0;
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x0000AEC0 File Offset: 0x000090C0
		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x4D07B40", Offset = "0x4D06740", VA = "0x184D07B40")]
		[System.CLSCompliant(false)]
		public static bool TryParse(string s, out ushort result)
		{
			return default(bool);
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x0000AED8 File Offset: 0x000090D8
		[Token(Token = "0x6000B8B")]
		[Address(RVA = "0x4D07C40", Offset = "0x4D06840", VA = "0x184D07C40")]
		[System.CLSCompliant(false)]
		public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out ushort result)
		{
			return default(bool);
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x0000AEF0 File Offset: 0x000090F0
		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0x4D07D40", Offset = "0x4D06940", VA = "0x184D07D40")]
		private static bool TryParse(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles style, System.Globalization.NumberFormatInfo info, out ushort result)
		{
			return default(bool);
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x0000AF08 File Offset: 0x00009108
		[Token(Token = "0x6000B8D")]
		[Address(RVA = "0x5586F0", Offset = "0x5572F0", VA = "0x1805586F0", Slot = "5")]
		public System.TypeCode GetTypeCode()
		{
			return System.TypeCode.Empty;
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x0000AF20 File Offset: 0x00009120
		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0x4D072E0", Offset = "0x4D05EE0", VA = "0x184D072E0", Slot = "6")]
		private bool ToBoolean(System.IFormatProvider provider)
		{
			return default(bool);
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x0000AF38 File Offset: 0x00009138
		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x4D07380", Offset = "0x4D05F80", VA = "0x184D07380", Slot = "7")]
		private char ToChar(System.IFormatProvider provider)
		{
			return '\0';
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x0000AF50 File Offset: 0x00009150
		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x4D07610", Offset = "0x4D06210", VA = "0x184D07610", Slot = "8")]
		private sbyte ToSByte(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x0000AF68 File Offset: 0x00009168
		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x4D07330", Offset = "0x4D05F30", VA = "0x184D07330", Slot = "9")]
		private byte ToByte(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x0000AF80 File Offset: 0x00009180
		[Token(Token = "0x6000B92")]
		[Address(RVA = "0x4D07520", Offset = "0x4D06120", VA = "0x184D07520", Slot = "10")]
		private short ToInt16(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x0000AF98 File Offset: 0x00009198
		[Token(Token = "0x6000B93")]
		[Address(RVA = "0x3D28B50", Offset = "0x3D27750", VA = "0x183D28B50", Slot = "11")]
		private ushort ToUInt16(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x0000AFB0 File Offset: 0x000091B0
		[Token(Token = "0x6000B94")]
		[Address(RVA = "0x4D07570", Offset = "0x4D06170", VA = "0x184D07570", Slot = "12")]
		private int ToInt32(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x0000AFC8 File Offset: 0x000091C8
		[Token(Token = "0x6000B95")]
		[Address(RVA = "0x4D07750", Offset = "0x4D06350", VA = "0x184D07750", Slot = "13")]
		private uint ToUInt32(System.IFormatProvider provider)
		{
			return 0U;
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x0000AFE0 File Offset: 0x000091E0
		[Token(Token = "0x6000B96")]
		[Address(RVA = "0x4D075C0", Offset = "0x4D061C0", VA = "0x184D075C0", Slot = "14")]
		private long ToInt64(System.IFormatProvider provider)
		{
			return 0L;
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x0000AFF8 File Offset: 0x000091F8
		[Token(Token = "0x6000B97")]
		[Address(RVA = "0x4D077A0", Offset = "0x4D063A0", VA = "0x184D077A0", Slot = "15")]
		private ulong ToUInt64(System.IFormatProvider provider)
		{
			return 0UL;
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x0000B010 File Offset: 0x00009210
		[Token(Token = "0x6000B98")]
		[Address(RVA = "0x4D07660", Offset = "0x4D06260", VA = "0x184D07660", Slot = "16")]
		private float ToSingle(System.IFormatProvider provider)
		{
			return 0f;
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x0000B028 File Offset: 0x00009228
		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x4D074D0", Offset = "0x4D060D0", VA = "0x184D074D0", Slot = "17")]
		private double ToDouble(System.IFormatProvider provider)
		{
			return 0.0;
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x0000B040 File Offset: 0x00009240
		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0x4D07460", Offset = "0x4D06060", VA = "0x184D07460", Slot = "18")]
		private decimal ToDecimal(System.IFormatProvider provider)
		{
			return 0m;
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x0000B058 File Offset: 0x00009258
		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0x4D073D0", Offset = "0x4D05FD0", VA = "0x184D073D0", Slot = "19")]
		private System.DateTime ToDateTime(System.IFormatProvider provider)
		{
			return default(System.DateTime);
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0x4D076B0", Offset = "0x4D062B0", VA = "0x184D076B0", Slot = "21")]
		private object ToType(System.Type type, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x040004E7 RID: 1255
		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ushort m_value;

		// Token: 0x040004E8 RID: 1256
		[Token(Token = "0x40004E8")]
		public const ushort MaxValue = 65535;

		// Token: 0x040004E9 RID: 1257
		[Token(Token = "0x40004E9")]
		public const ushort MinValue = 0;
	}
}
