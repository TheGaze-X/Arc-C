using System;
using Il2CppDummyDll;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x0200057A RID: 1402
	[Token(Token = "0x200057A")]
	[Serializable]
	public struct ObscuredSByte : IFormattable, IEquatable<ObscuredSByte>, IComparable<ObscuredSByte>, IComparable<sbyte>, IComparable
	{
		// Token: 0x06002F23 RID: 12067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F23")]
		[Address(RVA = "0x540C6C0", Offset = "0x540B2C0", VA = "0x18540C6C0")]
		private ObscuredSByte(sbyte value)
		{
		}

		// Token: 0x06002F24 RID: 12068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F24")]
		[Address(RVA = "0x540C460", Offset = "0x540B060", VA = "0x18540C460")]
		public static void SetNewCryptoKey(sbyte newKey)
		{
		}

		// Token: 0x06002F25 RID: 12069 RVA: 0x00014118 File Offset: 0x00012318
		[Token(Token = "0x6002F25")]
		[Address(RVA = "0x540BD40", Offset = "0x540A940", VA = "0x18540BD40")]
		public static sbyte EncryptDecrypt(sbyte value)
		{
			return 0;
		}

		// Token: 0x06002F26 RID: 12070 RVA: 0x00014130 File Offset: 0x00012330
		[Token(Token = "0x6002F26")]
		[Address(RVA = "0x540BDD0", Offset = "0x540A9D0", VA = "0x18540BDD0")]
		public static sbyte EncryptDecrypt(sbyte value, sbyte key)
		{
			return 0;
		}

		// Token: 0x06002F27 RID: 12071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F27")]
		[Address(RVA = "0x540BAE0", Offset = "0x540A6E0", VA = "0x18540BAE0")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x06002F28 RID: 12072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F28")]
		[Address(RVA = "0x540C230", Offset = "0x540AE30", VA = "0x18540C230")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x06002F29 RID: 12073 RVA: 0x00014148 File Offset: 0x00012348
		[Token(Token = "0x6002F29")]
		[Address(RVA = "0x540C080", Offset = "0x540AC80", VA = "0x18540C080")]
		public sbyte GetEncrypted()
		{
			return 0;
		}

		// Token: 0x06002F2A RID: 12074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F2A")]
		[Address(RVA = "0x540C2D0", Offset = "0x540AED0", VA = "0x18540C2D0")]
		public void SetEncrypted(sbyte encrypted)
		{
		}

		// Token: 0x06002F2B RID: 12075 RVA: 0x00014160 File Offset: 0x00012360
		[Token(Token = "0x6002F2B")]
		[Address(RVA = "0x540C030", Offset = "0x540AC30", VA = "0x18540C030")]
		public sbyte GetDecrypted()
		{
			return 0;
		}

		// Token: 0x06002F2C RID: 12076 RVA: 0x00014178 File Offset: 0x00012378
		[Token(Token = "0x6002F2C")]
		[Address(RVA = "0x540C130", Offset = "0x540AD30", VA = "0x18540C130")]
		private sbyte InternalDecrypt()
		{
			return 0;
		}

		// Token: 0x06002F2D RID: 12077 RVA: 0x00014190 File Offset: 0x00012390
		[Token(Token = "0x6002F2D")]
		[Address(RVA = "0x540C7F0", Offset = "0x540B3F0", VA = "0x18540C7F0")]
		public static implicit operator ObscuredSByte(sbyte value)
		{
			return default(ObscuredSByte);
		}

		// Token: 0x06002F2E RID: 12078 RVA: 0x000141A8 File Offset: 0x000123A8
		[Token(Token = "0x6002F2E")]
		[Address(RVA = "0x540C820", Offset = "0x540B420", VA = "0x18540C820")]
		public static implicit operator sbyte(ObscuredSByte value)
		{
			return 0;
		}

		// Token: 0x06002F2F RID: 12079 RVA: 0x000141C0 File Offset: 0x000123C0
		[Token(Token = "0x6002F2F")]
		[Address(RVA = "0x540C870", Offset = "0x540B470", VA = "0x18540C870")]
		public static ObscuredSByte operator ++(ObscuredSByte input)
		{
			return default(ObscuredSByte);
		}

		// Token: 0x06002F30 RID: 12080 RVA: 0x000141D8 File Offset: 0x000123D8
		[Token(Token = "0x6002F30")]
		[Address(RVA = "0x540C750", Offset = "0x540B350", VA = "0x18540C750")]
		public static ObscuredSByte operator --(ObscuredSByte input)
		{
			return default(ObscuredSByte);
		}

		// Token: 0x06002F31 RID: 12081 RVA: 0x000141F0 File Offset: 0x000123F0
		[Token(Token = "0x6002F31")]
		[Address(RVA = "0x540C0D0", Offset = "0x540ACD0", VA = "0x18540C0D0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002F32 RID: 12082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F32")]
		[Address(RVA = "0x540C530", Offset = "0x540B130", VA = "0x18540C530", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002F33 RID: 12083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F33")]
		[Address(RVA = "0x540C610", Offset = "0x540B210", VA = "0x18540C610")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x06002F34 RID: 12084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F34")]
		[Address(RVA = "0x540C4C0", Offset = "0x540B0C0", VA = "0x18540C4C0")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06002F35 RID: 12085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F35")]
		[Address(RVA = "0x540C590", Offset = "0x540B190", VA = "0x18540C590", Slot = "4")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06002F36 RID: 12086 RVA: 0x00014208 File Offset: 0x00012408
		[Token(Token = "0x6002F36")]
		[Address(RVA = "0x540BEF0", Offset = "0x540AAF0", VA = "0x18540BEF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06002F37 RID: 12087 RVA: 0x00014220 File Offset: 0x00012420
		[Token(Token = "0x6002F37")]
		[Address(RVA = "0x540BE50", Offset = "0x540AA50", VA = "0x18540BE50", Slot = "5")]
		public bool Equals(ObscuredSByte obj)
		{
			return default(bool);
		}

		// Token: 0x06002F38 RID: 12088 RVA: 0x00014238 File Offset: 0x00012438
		[Token(Token = "0x6002F38")]
		[Address(RVA = "0x540BCC0", Offset = "0x540A8C0", VA = "0x18540BCC0", Slot = "6")]
		public int CompareTo(ObscuredSByte other)
		{
			return 0;
		}

		// Token: 0x06002F39 RID: 12089 RVA: 0x00014250 File Offset: 0x00012450
		[Token(Token = "0x6002F39")]
		[Address(RVA = "0x540BBE0", Offset = "0x540A7E0", VA = "0x18540BBE0", Slot = "7")]
		public int CompareTo(sbyte other)
		{
			return 0;
		}

		// Token: 0x06002F3A RID: 12090 RVA: 0x00014268 File Offset: 0x00012468
		[Token(Token = "0x6002F3A")]
		[Address(RVA = "0x540BC50", Offset = "0x540A850", VA = "0x18540BC50", Slot = "8")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x04001A2A RID: 6698
		[Token(Token = "0x4001A2A")]
		[FieldOffset(Offset = "0x0")]
		private static sbyte cryptoKey;

		// Token: 0x04001A2B RID: 6699
		[Token(Token = "0x4001A2B")]
		[FieldOffset(Offset = "0x0")]
		private sbyte currentCryptoKey;

		// Token: 0x04001A2C RID: 6700
		[Token(Token = "0x4001A2C")]
		[FieldOffset(Offset = "0x1")]
		private sbyte hiddenValue;

		// Token: 0x04001A2D RID: 6701
		[Token(Token = "0x4001A2D")]
		[FieldOffset(Offset = "0x2")]
		private bool inited;

		// Token: 0x04001A2E RID: 6702
		[Token(Token = "0x4001A2E")]
		[FieldOffset(Offset = "0x3")]
		private sbyte fakeValue;

		// Token: 0x04001A2F RID: 6703
		[Token(Token = "0x4001A2F")]
		[FieldOffset(Offset = "0x4")]
		private bool fakeValueActive;
	}
}
