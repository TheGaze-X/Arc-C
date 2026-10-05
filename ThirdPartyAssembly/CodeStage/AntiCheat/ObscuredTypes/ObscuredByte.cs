using System;
using Il2CppDummyDll;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x0200056A RID: 1386
	[Token(Token = "0x200056A")]
	[Serializable]
	public struct ObscuredByte : IFormattable, IEquatable<ObscuredByte>, IComparable<ObscuredByte>, IComparable<byte>, IComparable
	{
		// Token: 0x06002DDF RID: 11743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DDF")]
		[Address(RVA = "0x53F1730", Offset = "0x53F0330", VA = "0x1853F1730")]
		private ObscuredByte(byte value)
		{
		}

		// Token: 0x06002DE0 RID: 11744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DE0")]
		[Address(RVA = "0x53F14D0", Offset = "0x53F00D0", VA = "0x1853F14D0")]
		public static void SetNewCryptoKey(byte newKey)
		{
		}

		// Token: 0x06002DE1 RID: 11745 RVA: 0x00013020 File Offset: 0x00011220
		[Token(Token = "0x6002DE1")]
		[Address(RVA = "0x53F0E50", Offset = "0x53EFA50", VA = "0x1853F0E50")]
		public static byte EncryptDecrypt(byte value)
		{
			return 0;
		}

		// Token: 0x06002DE2 RID: 11746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DE2")]
		[Address(RVA = "0x53F0C00", Offset = "0x53EF800", VA = "0x1853F0C00")]
		public static void EncryptDecrypt(byte[] value)
		{
		}

		// Token: 0x06002DE3 RID: 11747 RVA: 0x00013038 File Offset: 0x00011238
		[Token(Token = "0x6002DE3")]
		[Address(RVA = "0x53F0CF0", Offset = "0x53EF8F0", VA = "0x1853F0CF0")]
		public static byte EncryptDecrypt(byte value, byte key)
		{
			return 0;
		}

		// Token: 0x06002DE4 RID: 11748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DE4")]
		[Address(RVA = "0x53F0D70", Offset = "0x53EF970", VA = "0x1853F0D70")]
		public static void EncryptDecrypt(byte[] value, byte key)
		{
		}

		// Token: 0x06002DE5 RID: 11749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DE5")]
		[Address(RVA = "0x53F09A0", Offset = "0x53EF5A0", VA = "0x1853F09A0")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x06002DE6 RID: 11750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DE6")]
		[Address(RVA = "0x53F12C0", Offset = "0x53EFEC0", VA = "0x1853F12C0")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x06002DE7 RID: 11751 RVA: 0x00013050 File Offset: 0x00011250
		[Token(Token = "0x6002DE7")]
		[Address(RVA = "0x53F1110", Offset = "0x53EFD10", VA = "0x1853F1110")]
		public byte GetEncrypted()
		{
			return 0;
		}

		// Token: 0x06002DE8 RID: 11752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DE8")]
		[Address(RVA = "0x53F1340", Offset = "0x53EFF40", VA = "0x1853F1340")]
		public void SetEncrypted(byte encrypted)
		{
		}

		// Token: 0x06002DE9 RID: 11753 RVA: 0x00013068 File Offset: 0x00011268
		[Token(Token = "0x6002DE9")]
		[Address(RVA = "0x53F10C0", Offset = "0x53EFCC0", VA = "0x1853F10C0")]
		public byte GetDecrypted()
		{
			return 0;
		}

		// Token: 0x06002DEA RID: 11754 RVA: 0x00013080 File Offset: 0x00011280
		[Token(Token = "0x6002DEA")]
		[Address(RVA = "0x53F11C0", Offset = "0x53EFDC0", VA = "0x1853F11C0")]
		private byte InternalDecrypt()
		{
			return 0;
		}

		// Token: 0x06002DEB RID: 11755 RVA: 0x00013098 File Offset: 0x00011298
		[Token(Token = "0x6002DEB")]
		[Address(RVA = "0x53F18B0", Offset = "0x53F04B0", VA = "0x1853F18B0")]
		public static implicit operator ObscuredByte(byte value)
		{
			return default(ObscuredByte);
		}

		// Token: 0x06002DEC RID: 11756 RVA: 0x000130B0 File Offset: 0x000112B0
		[Token(Token = "0x6002DEC")]
		[Address(RVA = "0x53F1860", Offset = "0x53F0460", VA = "0x1853F1860")]
		public static implicit operator byte(ObscuredByte value)
		{
			return 0;
		}

		// Token: 0x06002DED RID: 11757 RVA: 0x000130C8 File Offset: 0x000112C8
		[Token(Token = "0x6002DED")]
		[Address(RVA = "0x53F18E0", Offset = "0x53F04E0", VA = "0x1853F18E0")]
		public static ObscuredByte operator ++(ObscuredByte input)
		{
			return default(ObscuredByte);
		}

		// Token: 0x06002DEE RID: 11758 RVA: 0x000130E0 File Offset: 0x000112E0
		[Token(Token = "0x6002DEE")]
		[Address(RVA = "0x53F17C0", Offset = "0x53F03C0", VA = "0x1853F17C0")]
		public static ObscuredByte operator --(ObscuredByte input)
		{
			return default(ObscuredByte);
		}

		// Token: 0x06002DEF RID: 11759 RVA: 0x000130F8 File Offset: 0x000112F8
		[Token(Token = "0x6002DEF")]
		[Address(RVA = "0x53F1160", Offset = "0x53EFD60", VA = "0x1853F1160", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002DF0 RID: 11760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DF0")]
		[Address(RVA = "0x53F15A0", Offset = "0x53F01A0", VA = "0x1853F15A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002DF1 RID: 11761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DF1")]
		[Address(RVA = "0x53F1530", Offset = "0x53F0130", VA = "0x1853F1530")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x06002DF2 RID: 11762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DF2")]
		[Address(RVA = "0x53F1680", Offset = "0x53F0280", VA = "0x1853F1680")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06002DF3 RID: 11763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DF3")]
		[Address(RVA = "0x53F1600", Offset = "0x53F0200", VA = "0x1853F1600", Slot = "4")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06002DF4 RID: 11764 RVA: 0x00013110 File Offset: 0x00011310
		[Token(Token = "0x6002DF4")]
		[Address(RVA = "0x53F0EE0", Offset = "0x53EFAE0", VA = "0x1853F0EE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06002DF5 RID: 11765 RVA: 0x00013128 File Offset: 0x00011328
		[Token(Token = "0x6002DF5")]
		[Address(RVA = "0x53F1020", Offset = "0x53EFC20", VA = "0x1853F1020", Slot = "5")]
		public bool Equals(ObscuredByte obj)
		{
			return default(bool);
		}

		// Token: 0x06002DF6 RID: 11766 RVA: 0x00013140 File Offset: 0x00011340
		[Token(Token = "0x6002DF6")]
		[Address(RVA = "0x53F0AA0", Offset = "0x53EF6A0", VA = "0x1853F0AA0", Slot = "6")]
		public int CompareTo(ObscuredByte other)
		{
			return 0;
		}

		// Token: 0x06002DF7 RID: 11767 RVA: 0x00013158 File Offset: 0x00011358
		[Token(Token = "0x6002DF7")]
		[Address(RVA = "0x53F0B90", Offset = "0x53EF790", VA = "0x1853F0B90", Slot = "7")]
		public int CompareTo(byte other)
		{
			return 0;
		}

		// Token: 0x06002DF8 RID: 11768 RVA: 0x00013170 File Offset: 0x00011370
		[Token(Token = "0x6002DF8")]
		[Address(RVA = "0x53F0B20", Offset = "0x53EF720", VA = "0x1853F0B20", Slot = "8")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x040019C5 RID: 6597
		[Token(Token = "0x40019C5")]
		[FieldOffset(Offset = "0x0")]
		private static byte cryptoKey;

		// Token: 0x040019C6 RID: 6598
		[Token(Token = "0x40019C6")]
		[FieldOffset(Offset = "0x0")]
		private byte currentCryptoKey;

		// Token: 0x040019C7 RID: 6599
		[Token(Token = "0x40019C7")]
		[FieldOffset(Offset = "0x1")]
		private byte hiddenValue;

		// Token: 0x040019C8 RID: 6600
		[Token(Token = "0x40019C8")]
		[FieldOffset(Offset = "0x2")]
		private bool inited;

		// Token: 0x040019C9 RID: 6601
		[Token(Token = "0x40019C9")]
		[FieldOffset(Offset = "0x3")]
		private byte fakeValue;

		// Token: 0x040019CA RID: 6602
		[Token(Token = "0x40019CA")]
		[FieldOffset(Offset = "0x4")]
		private bool fakeValueActive;
	}
}
