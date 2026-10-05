using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000129 RID: 297
	[Token(Token = "0x2000129")]
	[System.CLSCompliant(false)]
	[System.Serializable]
	public readonly struct SByte : System.IComparable, System.IConvertible, System.IFormattable, System.IComparable<sbyte>, System.IEquatable<sbyte>, ISpanFormattable
	{
		// Token: 0x060009DD RID: 2525 RVA: 0x00009840 File Offset: 0x00007A40
		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x4CF75C0", Offset = "0x4CF61C0", VA = "0x184CF75C0", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00009858 File Offset: 0x00007A58
		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x4CF75B0", Offset = "0x4CF61B0", VA = "0x184CF75B0", Slot = "23")]
		public int CompareTo(sbyte value)
		{
			return 0;
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x00009870 File Offset: 0x00007A70
		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x4CF76A0", Offset = "0x4CF62A0", VA = "0x184CF76A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00009888 File Offset: 0x00007A88
		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x4CA6950", Offset = "0x4CA5550", VA = "0x184CA6950", Slot = "24")]
		[NonVersionable]
		public bool Equals(sbyte obj)
		{
			return default(bool);
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x000098A0 File Offset: 0x00007AA0
		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x4CF7730", Offset = "0x4CF6330", VA = "0x184CF7730", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x4CF8130", Offset = "0x4CF6D30", VA = "0x184CF8130", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x4CF80A0", Offset = "0x4CF6CA0", VA = "0x184CF80A0", Slot = "20")]
		public string ToString(System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x4CF8090", Offset = "0x4CF6C90", VA = "0x184CF8090")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x4CF7F00", Offset = "0x4CF6B00", VA = "0x184CF7F00", Slot = "22")]
		public string ToString(string format, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x000098B8 File Offset: 0x00007AB8
		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x4CF81B0", Offset = "0x4CF6DB0", VA = "0x184CF81B0", Slot = "25")]
		public bool TryFormat(System.Span<char> destination, out int charsWritten, [System.Runtime.InteropServices.Optional] System.ReadOnlySpan<char> format, [System.Runtime.InteropServices.Optional] System.IFormatProvider provider)
		{
			return default(bool);
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x000098D0 File Offset: 0x00007AD0
		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x4CF7740", Offset = "0x4CF6340", VA = "0x184CF7740")]
		[System.CLSCompliant(false)]
		public static sbyte Parse(string s, System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x000098E8 File Offset: 0x00007AE8
		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x4CF7980", Offset = "0x4CF6580", VA = "0x184CF7980")]
		[System.CLSCompliant(false)]
		public static sbyte Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x00009900 File Offset: 0x00007B00
		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x4CF77D0", Offset = "0x4CF63D0", VA = "0x184CF77D0")]
		private static sbyte Parse(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles style, System.Globalization.NumberFormatInfo info)
		{
			return 0;
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x00009918 File Offset: 0x00007B18
		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x4CF83C0", Offset = "0x4CF6FC0", VA = "0x184CF83C0")]
		[System.CLSCompliant(false)]
		public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out sbyte result)
		{
			return default(bool);
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x00009930 File Offset: 0x00007B30
		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x4CF82F0", Offset = "0x4CF6EF0", VA = "0x184CF82F0")]
		private static bool TryParse(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles style, System.Globalization.NumberFormatInfo info, out sbyte result)
		{
			return default(bool);
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x00009948 File Offset: 0x00007B48
		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x54AE00", Offset = "0x549A00", VA = "0x18054AE00", Slot = "5")]
		public System.TypeCode GetTypeCode()
		{
			return System.TypeCode.Empty;
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x00009960 File Offset: 0x00007B60
		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x4CF7A30", Offset = "0x4CF6630", VA = "0x184CF7A30", Slot = "6")]
		private bool ToBoolean(System.IFormatProvider provider)
		{
			return default(bool);
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00009978 File Offset: 0x00007B78
		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x4CF7AD0", Offset = "0x4CF66D0", VA = "0x184CF7AD0", Slot = "7")]
		private char ToChar(System.IFormatProvider provider)
		{
			return '\0';
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x00009990 File Offset: 0x00007B90
		[Token(Token = "0x60009EF")]
		[Address(RVA = "0xDF9A30", Offset = "0xDF8630", VA = "0x180DF9A30", Slot = "8")]
		private sbyte ToSByte(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x000099A8 File Offset: 0x00007BA8
		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x4CF7A80", Offset = "0x4CF6680", VA = "0x184CF7A80", Slot = "9")]
		private byte ToByte(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x000099C0 File Offset: 0x00007BC0
		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x4CF7C70", Offset = "0x4CF6870", VA = "0x184CF7C70", Slot = "10")]
		private short ToInt16(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x000099D8 File Offset: 0x00007BD8
		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x4CF7E10", Offset = "0x4CF6A10", VA = "0x184CF7E10", Slot = "11")]
		private ushort ToUInt16(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x000099F0 File Offset: 0x00007BF0
		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x4CF7CC0", Offset = "0x4CF68C0", VA = "0x184CF7CC0", Slot = "12")]
		private int ToInt32(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00009A08 File Offset: 0x00007C08
		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x4CF7E60", Offset = "0x4CF6A60", VA = "0x184CF7E60", Slot = "13")]
		private uint ToUInt32(System.IFormatProvider provider)
		{
			return 0U;
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x00009A20 File Offset: 0x00007C20
		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x4CF7CD0", Offset = "0x4CF68D0", VA = "0x184CF7CD0", Slot = "14")]
		private long ToInt64(System.IFormatProvider provider)
		{
			return 0L;
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00009A38 File Offset: 0x00007C38
		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x4CF7EB0", Offset = "0x4CF6AB0", VA = "0x184CF7EB0", Slot = "15")]
		private ulong ToUInt64(System.IFormatProvider provider)
		{
			return 0UL;
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x00009A50 File Offset: 0x00007C50
		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x4CF7D20", Offset = "0x4CF6920", VA = "0x184CF7D20", Slot = "16")]
		private float ToSingle(System.IFormatProvider provider)
		{
			return 0f;
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x00009A68 File Offset: 0x00007C68
		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x4CF7C20", Offset = "0x4CF6820", VA = "0x184CF7C20", Slot = "17")]
		private double ToDouble(System.IFormatProvider provider)
		{
			return 0.0;
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x00009A80 File Offset: 0x00007C80
		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x4CF7BB0", Offset = "0x4CF67B0", VA = "0x184CF7BB0", Slot = "18")]
		private decimal ToDecimal(System.IFormatProvider provider)
		{
			return 0m;
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x00009A98 File Offset: 0x00007C98
		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x4CF7B20", Offset = "0x4CF6720", VA = "0x184CF7B20", Slot = "19")]
		private System.DateTime ToDateTime(System.IFormatProvider provider)
		{
			return default(System.DateTime);
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x4CF7D70", Offset = "0x4CF6970", VA = "0x184CF7D70", Slot = "21")]
		private object ToType(System.Type type, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x04000489 RID: 1161
		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly sbyte m_value;

		// Token: 0x0400048A RID: 1162
		[Token(Token = "0x400048A")]
		public const sbyte MaxValue = 127;

		// Token: 0x0400048B RID: 1163
		[Token(Token = "0x400048B")]
		public const sbyte MinValue = -128;
	}
}
