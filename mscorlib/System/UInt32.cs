using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000148 RID: 328
	[Token(Token = "0x2000148")]
	[System.CLSCompliant(false)]
	[System.Serializable]
	public readonly struct UInt32 : System.IComparable, System.IConvertible, System.IFormattable, System.IComparable<uint>, System.IEquatable<uint>, ISpanFormattable
	{
		// Token: 0x06000B9D RID: 2973 RVA: 0x0000B070 File Offset: 0x00009270
		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0x4D07DF0", Offset = "0x4D069F0", VA = "0x184D07DF0", Slot = "4")]
		public int CompareTo(object value)
		{
			return 0;
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x0000B088 File Offset: 0x00009288
		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0x4D07EE0", Offset = "0x4D06AE0", VA = "0x184D07EE0", Slot = "23")]
		public int CompareTo(uint value)
		{
			return 0;
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x0000B0A0 File Offset: 0x000092A0
		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0x4D07F00", Offset = "0x4D06B00", VA = "0x184D07F00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x0000B0B8 File Offset: 0x000092B8
		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0x263CAD0", Offset = "0x263B6D0", VA = "0x18263CAD0", Slot = "24")]
		[NonVersionable]
		public bool Equals(uint obj)
		{
			return default(bool);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x0000B0D0 File Offset: 0x000092D0
		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0x4D089E0", Offset = "0x4D075E0", VA = "0x184D089E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0x4D08890", Offset = "0x4D07490", VA = "0x184D08890", Slot = "20")]
		public string ToString(System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0x4D08920", Offset = "0x4D07520", VA = "0x184D08920")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0x4D087C0", Offset = "0x4D073C0", VA = "0x184D087C0", Slot = "22")]
		public string ToString(string format, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x0000B0E8 File Offset: 0x000092E8
		[Token(Token = "0x6000BA6")]
		[Address(RVA = "0x4D08A60", Offset = "0x4D07660", VA = "0x184D08A60", Slot = "25")]
		public bool TryFormat(System.Span<char> destination, out int charsWritten, [System.Runtime.InteropServices.Optional] System.ReadOnlySpan<char> format, [System.Runtime.InteropServices.Optional] System.IFormatProvider provider)
		{
			return default(bool);
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x0000B100 File Offset: 0x00009300
		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0x4D07F80", Offset = "0x4D06B80", VA = "0x184D07F80")]
		[System.CLSCompliant(false)]
		public static uint Parse(string s)
		{
			return 0U;
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x0000B118 File Offset: 0x00009318
		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0x4D08040", Offset = "0x4D06C40", VA = "0x184D08040")]
		[System.CLSCompliant(false)]
		public static uint Parse(string s, System.Globalization.NumberStyles style)
		{
			return 0U;
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x0000B130 File Offset: 0x00009330
		[Token(Token = "0x6000BA9")]
		[Address(RVA = "0x4D08110", Offset = "0x4D06D10", VA = "0x184D08110")]
		[System.CLSCompliant(false)]
		public static uint Parse(string s, System.IFormatProvider provider)
		{
			return 0U;
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x0000B148 File Offset: 0x00009348
		[Token(Token = "0x6000BAA")]
		[Address(RVA = "0x4D081E0", Offset = "0x4D06DE0", VA = "0x184D081E0")]
		[System.CLSCompliant(false)]
		public static uint Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider)
		{
			return 0U;
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x0000B160 File Offset: 0x00009360
		[Token(Token = "0x6000BAB")]
		[Address(RVA = "0x4D08BF0", Offset = "0x4D077F0", VA = "0x184D08BF0")]
		[System.CLSCompliant(false)]
		public static bool TryParse(string s, out uint result)
		{
			return default(bool);
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x0000B178 File Offset: 0x00009378
		[Token(Token = "0x6000BAC")]
		[Address(RVA = "0x4D08B00", Offset = "0x4D07700", VA = "0x184D08B00")]
		[System.CLSCompliant(false)]
		public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out uint result)
		{
			return default(bool);
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x0000B190 File Offset: 0x00009390
		[Token(Token = "0x6000BAD")]
		[Address(RVA = "0x2114980", Offset = "0x2113580", VA = "0x182114980", Slot = "5")]
		public System.TypeCode GetTypeCode()
		{
			return System.TypeCode.Empty;
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x0000B1A8 File Offset: 0x000093A8
		[Token(Token = "0x6000BAE")]
		[Address(RVA = "0x4D082C0", Offset = "0x4D06EC0", VA = "0x184D082C0", Slot = "6")]
		private bool ToBoolean(System.IFormatProvider provider)
		{
			return default(bool);
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x0000B1C0 File Offset: 0x000093C0
		[Token(Token = "0x6000BAF")]
		[Address(RVA = "0x4D08360", Offset = "0x4D06F60", VA = "0x184D08360", Slot = "7")]
		private char ToChar(System.IFormatProvider provider)
		{
			return '\0';
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x0000B1D8 File Offset: 0x000093D8
		[Token(Token = "0x6000BB0")]
		[Address(RVA = "0x4D085F0", Offset = "0x4D071F0", VA = "0x184D085F0", Slot = "8")]
		private sbyte ToSByte(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x0000B1F0 File Offset: 0x000093F0
		[Token(Token = "0x6000BB1")]
		[Address(RVA = "0x4D08310", Offset = "0x4D06F10", VA = "0x184D08310", Slot = "9")]
		private byte ToByte(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x0000B208 File Offset: 0x00009408
		[Token(Token = "0x6000BB2")]
		[Address(RVA = "0x4D08500", Offset = "0x4D07100", VA = "0x184D08500", Slot = "10")]
		private short ToInt16(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x0000B220 File Offset: 0x00009420
		[Token(Token = "0x6000BB3")]
		[Address(RVA = "0x4D08720", Offset = "0x4D07320", VA = "0x184D08720", Slot = "11")]
		private ushort ToUInt16(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x0000B238 File Offset: 0x00009438
		[Token(Token = "0x6000BB4")]
		[Address(RVA = "0x4D08550", Offset = "0x4D07150", VA = "0x184D08550", Slot = "12")]
		private int ToInt32(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x0000B250 File Offset: 0x00009450
		[Token(Token = "0x6000BB5")]
		[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260", Slot = "13")]
		private uint ToUInt32(System.IFormatProvider provider)
		{
			return 0U;
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x0000B268 File Offset: 0x00009468
		[Token(Token = "0x6000BB6")]
		[Address(RVA = "0x4D085A0", Offset = "0x4D071A0", VA = "0x184D085A0", Slot = "14")]
		private long ToInt64(System.IFormatProvider provider)
		{
			return 0L;
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x0000B280 File Offset: 0x00009480
		[Token(Token = "0x6000BB7")]
		[Address(RVA = "0x4D08770", Offset = "0x4D07370", VA = "0x184D08770", Slot = "15")]
		private ulong ToUInt64(System.IFormatProvider provider)
		{
			return 0UL;
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x0000B298 File Offset: 0x00009498
		[Token(Token = "0x6000BB8")]
		[Address(RVA = "0x4D08640", Offset = "0x4D07240", VA = "0x184D08640", Slot = "16")]
		private float ToSingle(System.IFormatProvider provider)
		{
			return 0f;
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x0000B2B0 File Offset: 0x000094B0
		[Token(Token = "0x6000BB9")]
		[Address(RVA = "0x4D084B0", Offset = "0x4D070B0", VA = "0x184D084B0", Slot = "17")]
		private double ToDouble(System.IFormatProvider provider)
		{
			return 0.0;
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x0000B2C8 File Offset: 0x000094C8
		[Token(Token = "0x6000BBA")]
		[Address(RVA = "0x4D08440", Offset = "0x4D07040", VA = "0x184D08440", Slot = "18")]
		private decimal ToDecimal(System.IFormatProvider provider)
		{
			return 0m;
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x0000B2E0 File Offset: 0x000094E0
		[Token(Token = "0x6000BBB")]
		[Address(RVA = "0x4D083B0", Offset = "0x4D06FB0", VA = "0x184D083B0", Slot = "19")]
		private System.DateTime ToDateTime(System.IFormatProvider provider)
		{
			return default(System.DateTime);
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000BBC")]
		[Address(RVA = "0x4D08690", Offset = "0x4D07290", VA = "0x184D08690", Slot = "21")]
		private object ToType(System.Type type, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x040004EA RID: 1258
		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly uint m_value;

		// Token: 0x040004EB RID: 1259
		[Token(Token = "0x40004EB")]
		public const uint MaxValue = 4294967295U;

		// Token: 0x040004EC RID: 1260
		[Token(Token = "0x40004EC")]
		public const uint MinValue = 0U;
	}
}
