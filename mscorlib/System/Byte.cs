using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000BE RID: 190
	[Token(Token = "0x20000BE")]
	[System.Serializable]
	public readonly struct Byte : System.IComparable, System.IConvertible, System.IFormattable, System.IComparable<byte>, System.IEquatable<byte>, ISpanFormattable
	{
		// Token: 0x060004AF RID: 1199 RVA: 0x00004770 File Offset: 0x00002970
		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x4CA7A20", Offset = "0x4CA6620", VA = "0x184CA7A20", Slot = "4")]
		public int CompareTo(object value)
		{
			return 0;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00004788 File Offset: 0x00002988
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x4CA7A10", Offset = "0x4CA6610", VA = "0x184CA7A10", Slot = "23")]
		public int CompareTo(byte value)
		{
			return 0;
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x000047A0 File Offset: 0x000029A0
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x4CA7B00", Offset = "0x4CA6700", VA = "0x184CA7B00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x000047B8 File Offset: 0x000029B8
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x4CA6950", Offset = "0x4CA5550", VA = "0x184CA6950", Slot = "24")]
		[NonVersionable]
		public bool Equals(byte obj)
		{
			return default(bool);
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x000047D0 File Offset: 0x000029D0
		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xDF9A30", Offset = "0xDF8630", VA = "0x180DF9A30", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x000047E8 File Offset: 0x000029E8
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x4CA7E40", Offset = "0x4CA6A40", VA = "0x184CA7E40")]
		public static byte Parse(string s, System.Globalization.NumberStyles style)
		{
			return 0;
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00004800 File Offset: 0x00002A00
		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x4CA7D90", Offset = "0x4CA6990", VA = "0x184CA7D90")]
		public static byte Parse(string s, System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00004818 File Offset: 0x00002A18
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x4CA7CD0", Offset = "0x4CA68D0", VA = "0x184CA7CD0")]
		public static byte Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00004830 File Offset: 0x00002A30
		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x4CA7B90", Offset = "0x4CA6790", VA = "0x184CA7B90")]
		private static byte Parse(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles style, System.Globalization.NumberFormatInfo info)
		{
			return 0;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00004848 File Offset: 0x00002A48
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x4CA8860", Offset = "0x4CA7460", VA = "0x184CA8860")]
		public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out byte result)
		{
			return default(bool);
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00004860 File Offset: 0x00002A60
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x4CA87B0", Offset = "0x4CA73B0", VA = "0x184CA87B0")]
		private static bool TryParse(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles style, System.Globalization.NumberFormatInfo info, out byte result)
		{
			return default(bool);
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x4CA8680", Offset = "0x4CA7280", VA = "0x184CA8680", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x4CA85C0", Offset = "0x4CA71C0", VA = "0x184CA85C0")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x4CA8460", Offset = "0x4CA7060", VA = "0x184CA8460", Slot = "20")]
		public string ToString(System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x4CA84F0", Offset = "0x4CA70F0", VA = "0x184CA84F0", Slot = "22")]
		public string ToString(string format, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00004878 File Offset: 0x00002A78
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x4CA8700", Offset = "0x4CA7300", VA = "0x184CA8700", Slot = "25")]
		public bool TryFormat(System.Span<char> destination, out int charsWritten, [System.Runtime.InteropServices.Optional] System.ReadOnlySpan<char> format, [System.Runtime.InteropServices.Optional] System.IFormatProvider provider)
		{
			return default(bool);
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00004890 File Offset: 0x00002A90
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x54BA20", Offset = "0x54A620", VA = "0x18054BA20", Slot = "5")]
		public System.TypeCode GetTypeCode()
		{
			return System.TypeCode.Empty;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x000048A8 File Offset: 0x00002AA8
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x4CA7EF0", Offset = "0x4CA6AF0", VA = "0x184CA7EF0", Slot = "6")]
		private bool ToBoolean(System.IFormatProvider provider)
		{
			return default(bool);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x000048C0 File Offset: 0x00002AC0
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x4CA7F40", Offset = "0x4CA6B40", VA = "0x184CA7F40", Slot = "7")]
		private char ToChar(System.IFormatProvider provider)
		{
			return '\0';
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x000048D8 File Offset: 0x00002AD8
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x4CA8200", Offset = "0x4CA6E00", VA = "0x184CA8200", Slot = "8")]
		private sbyte ToSByte(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x000048F0 File Offset: 0x00002AF0
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xDF9A30", Offset = "0xDF8630", VA = "0x180DF9A30", Slot = "9")]
		private byte ToByte(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00004908 File Offset: 0x00002B08
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x4CA8110", Offset = "0x4CA6D10", VA = "0x184CA8110", Slot = "10")]
		private short ToInt16(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00004920 File Offset: 0x00002B20
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x4CA8370", Offset = "0x4CA6F70", VA = "0x184CA8370", Slot = "11")]
		private ushort ToUInt16(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00004938 File Offset: 0x00002B38
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x4CA8160", Offset = "0x4CA6D60", VA = "0x184CA8160", Slot = "12")]
		private int ToInt32(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00004950 File Offset: 0x00002B50
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x4CA83C0", Offset = "0x4CA6FC0", VA = "0x184CA83C0", Slot = "13")]
		private uint ToUInt32(System.IFormatProvider provider)
		{
			return 0U;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00004968 File Offset: 0x00002B68
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x4CA81B0", Offset = "0x4CA6DB0", VA = "0x184CA81B0", Slot = "14")]
		private long ToInt64(System.IFormatProvider provider)
		{
			return 0L;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00004980 File Offset: 0x00002B80
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x4CA8410", Offset = "0x4CA7010", VA = "0x184CA8410", Slot = "15")]
		private ulong ToUInt64(System.IFormatProvider provider)
		{
			return 0UL;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00004998 File Offset: 0x00002B98
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x4CA8280", Offset = "0x4CA6E80", VA = "0x184CA8280", Slot = "16")]
		private float ToSingle(System.IFormatProvider provider)
		{
			return 0f;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x000049B0 File Offset: 0x00002BB0
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x4CA80C0", Offset = "0x4CA6CC0", VA = "0x184CA80C0", Slot = "17")]
		private double ToDouble(System.IFormatProvider provider)
		{
			return 0.0;
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x000049C8 File Offset: 0x00002BC8
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x4CA8020", Offset = "0x4CA6C20", VA = "0x184CA8020", Slot = "18")]
		private decimal ToDecimal(System.IFormatProvider provider)
		{
			return 0m;
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x000049E0 File Offset: 0x00002BE0
		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x4CA7F90", Offset = "0x4CA6B90", VA = "0x184CA7F90", Slot = "19")]
		private System.DateTime ToDateTime(System.IFormatProvider provider)
		{
			return default(System.DateTime);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x4CA82D0", Offset = "0x4CA6ED0", VA = "0x184CA82D0", Slot = "21")]
		private object ToType(System.Type type, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x040002D7 RID: 727
		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly byte m_value;

		// Token: 0x040002D8 RID: 728
		[Token(Token = "0x40002D8")]
		public const byte MaxValue = 255;

		// Token: 0x040002D9 RID: 729
		[Token(Token = "0x40002D9")]
		public const byte MinValue = 0;
	}
}
