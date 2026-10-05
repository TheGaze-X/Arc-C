using System;
using System.Runtime.Versioning;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000BD RID: 189
	[Token(Token = "0x20000BD")]
	[System.Serializable]
	public readonly struct Boolean : System.IComparable, System.IConvertible, System.IComparable<bool>, System.IEquatable<bool>
	{
		// Token: 0x06000492 RID: 1170 RVA: 0x00004518 File Offset: 0x00002718
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x4CA6960", Offset = "0x4CA5560", VA = "0x184CA6960", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x4CA7180", Offset = "0x4CA5D80", VA = "0x184CA7180", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x4CA71D0", Offset = "0x4CA5DD0", VA = "0x184CA71D0", Slot = "20")]
		public string ToString(System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00004530 File Offset: 0x00002730
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x4CA68C0", Offset = "0x4CA54C0", VA = "0x184CA68C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00004548 File Offset: 0x00002748
		[Token(Token = "0x6000496")]
		[Address(RVA = "0x4CA6950", Offset = "0x4CA5550", VA = "0x184CA6950", Slot = "23")]
		[NonVersionable]
		public bool Equals(bool obj)
		{
			return default(bool);
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00004560 File Offset: 0x00002760
		[Token(Token = "0x6000497")]
		[Address(RVA = "0x4CA67B0", Offset = "0x4CA53B0", VA = "0x184CA67B0", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00004578 File Offset: 0x00002778
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x4CA6790", Offset = "0x4CA5390", VA = "0x184CA6790", Slot = "22")]
		public int CompareTo(bool value)
		{
			return 0;
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00004590 File Offset: 0x00002790
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x4CA6A30", Offset = "0x4CA5630", VA = "0x184CA6A30")]
		public static bool Parse(string value)
		{
			return default(bool);
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x000045A8 File Offset: 0x000027A8
		[Token(Token = "0x600049A")]
		[Address(RVA = "0x4CA6970", Offset = "0x4CA5570", VA = "0x184CA6970")]
		public static bool Parse(System.ReadOnlySpan<char> value)
		{
			return default(bool);
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x000045C0 File Offset: 0x000027C0
		[Token(Token = "0x600049B")]
		[Address(RVA = "0x4CA78A0", Offset = "0x4CA64A0", VA = "0x184CA78A0")]
		public static bool TryParse(string value, out bool result)
		{
			return default(bool);
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x000045D8 File Offset: 0x000027D8
		[Token(Token = "0x600049C")]
		[Address(RVA = "0x4CA73E0", Offset = "0x4CA5FE0", VA = "0x184CA73E0")]
		public static bool TryParse(System.ReadOnlySpan<char> value, out bool result)
		{
			return default(bool);
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x000045F0 File Offset: 0x000027F0
		[Token(Token = "0x600049D")]
		[Address(RVA = "0x4CA7250", Offset = "0x4CA5E50", VA = "0x184CA7250")]
		private static System.ReadOnlySpan<char> TrimWhiteSpaceAndNull(System.ReadOnlySpan<char> value)
		{
			return default(System.ReadOnlySpan<char>);
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00004608 File Offset: 0x00002808
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x54B800", Offset = "0x54A400", VA = "0x18054B800", Slot = "5")]
		public System.TypeCode GetTypeCode()
		{
			return System.TypeCode.Empty;
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00004620 File Offset: 0x00002820
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x4CA6BC0", Offset = "0x4CA57C0", VA = "0x184CA6BC0", Slot = "6")]
		private bool ToBoolean(System.IFormatProvider provider)
		{
			return default(bool);
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00004638 File Offset: 0x00002838
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x4CA6C20", Offset = "0x4CA5820", VA = "0x184CA6C20", Slot = "7")]
		private char ToChar(System.IFormatProvider provider)
		{
			return '\0';
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00004650 File Offset: 0x00002850
		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x4CA6F40", Offset = "0x4CA5B40", VA = "0x184CA6F40", Slot = "8")]
		private sbyte ToSByte(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00004668 File Offset: 0x00002868
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x4CA6BD0", Offset = "0x4CA57D0", VA = "0x184CA6BD0", Slot = "9")]
		private byte ToByte(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00004680 File Offset: 0x00002880
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x4CA6E50", Offset = "0x4CA5A50", VA = "0x184CA6E50", Slot = "10")]
		private short ToInt16(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00004698 File Offset: 0x00002898
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x4CA7090", Offset = "0x4CA5C90", VA = "0x184CA7090", Slot = "11")]
		private ushort ToUInt16(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x000046B0 File Offset: 0x000028B0
		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x4CA6EA0", Offset = "0x4CA5AA0", VA = "0x184CA6EA0", Slot = "12")]
		private int ToInt32(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x000046C8 File Offset: 0x000028C8
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x4CA70E0", Offset = "0x4CA5CE0", VA = "0x184CA70E0", Slot = "13")]
		private uint ToUInt32(System.IFormatProvider provider)
		{
			return 0U;
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x000046E0 File Offset: 0x000028E0
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x4CA6EF0", Offset = "0x4CA5AF0", VA = "0x184CA6EF0", Slot = "14")]
		private long ToInt64(System.IFormatProvider provider)
		{
			return 0L;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x000046F8 File Offset: 0x000028F8
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x4CA7130", Offset = "0x4CA5D30", VA = "0x184CA7130", Slot = "15")]
		private ulong ToUInt64(System.IFormatProvider provider)
		{
			return 0UL;
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00004710 File Offset: 0x00002910
		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x4CA6F90", Offset = "0x4CA5B90", VA = "0x184CA6F90", Slot = "16")]
		private float ToSingle(System.IFormatProvider provider)
		{
			return 0f;
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00004728 File Offset: 0x00002928
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x4CA6DF0", Offset = "0x4CA59F0", VA = "0x184CA6DF0", Slot = "17")]
		private double ToDouble(System.IFormatProvider provider)
		{
			return 0.0;
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00004740 File Offset: 0x00002940
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x4CA6D40", Offset = "0x4CA5940", VA = "0x184CA6D40", Slot = "18")]
		private decimal ToDecimal(System.IFormatProvider provider)
		{
			return 0m;
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00004758 File Offset: 0x00002958
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x4CA6CB0", Offset = "0x4CA58B0", VA = "0x184CA6CB0", Slot = "19")]
		private System.DateTime ToDateTime(System.IFormatProvider provider)
		{
			return default(System.DateTime);
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x4CA6FF0", Offset = "0x4CA5BF0", VA = "0x184CA6FF0", Slot = "21")]
		private object ToType(System.Type type, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x040002D0 RID: 720
		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x0")]
		private readonly bool m_value;

		// Token: 0x040002D1 RID: 721
		[Token(Token = "0x40002D1")]
		internal const int True = 1;

		// Token: 0x040002D2 RID: 722
		[Token(Token = "0x40002D2")]
		internal const int False = 0;

		// Token: 0x040002D3 RID: 723
		[Token(Token = "0x40002D3")]
		internal const string TrueLiteral = "True";

		// Token: 0x040002D4 RID: 724
		[Token(Token = "0x40002D4")]
		internal const string FalseLiteral = "False";

		// Token: 0x040002D5 RID: 725
		[Token(Token = "0x40002D5")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string TrueString;

		// Token: 0x040002D6 RID: 726
		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string FalseString;
	}
}
