using System;
using Il2CppDummyDll;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x0200056B RID: 1387
	[Token(Token = "0x200056B")]
	[Serializable]
	public struct ObscuredChar : IEquatable<ObscuredChar>, IComparable<ObscuredChar>, IComparable<char>, IComparable
	{
		// Token: 0x06002DFA RID: 11770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DFA")]
		[Address(RVA = "0x53F2510", Offset = "0x53F1110", VA = "0x1853F2510")]
		private ObscuredChar(char value)
		{
		}

		// Token: 0x06002DFB RID: 11771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DFB")]
		[Address(RVA = "0x53F2360", Offset = "0x53F0F60", VA = "0x1853F2360")]
		public static void SetNewCryptoKey(char newKey)
		{
		}

		// Token: 0x06002DFC RID: 11772 RVA: 0x00013188 File Offset: 0x00011388
		[Token(Token = "0x6002DFC")]
		[Address(RVA = "0x53F1C40", Offset = "0x53F0840", VA = "0x1853F1C40")]
		public static char EncryptDecrypt(char value)
		{
			return '\0';
		}

		// Token: 0x06002DFD RID: 11773 RVA: 0x000131A0 File Offset: 0x000113A0
		[Token(Token = "0x6002DFD")]
		[Address(RVA = "0x53F1CD0", Offset = "0x53F08D0", VA = "0x1853F1CD0")]
		public static char EncryptDecrypt(char value, char key)
		{
			return '\0';
		}

		// Token: 0x06002DFE RID: 11774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DFE")]
		[Address(RVA = "0x53F1980", Offset = "0x53F0580", VA = "0x1853F1980")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x06002DFF RID: 11775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DFF")]
		[Address(RVA = "0x53F2150", Offset = "0x53F0D50", VA = "0x1853F2150")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x06002E00 RID: 11776 RVA: 0x000131B8 File Offset: 0x000113B8
		[Token(Token = "0x6002E00")]
		[Address(RVA = "0x53F1F80", Offset = "0x53F0B80", VA = "0x1853F1F80")]
		public char GetEncrypted()
		{
			return '\0';
		}

		// Token: 0x06002E01 RID: 11777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E01")]
		[Address(RVA = "0x53F21D0", Offset = "0x53F0DD0", VA = "0x1853F21D0")]
		public void SetEncrypted(char encrypted)
		{
		}

		// Token: 0x06002E02 RID: 11778 RVA: 0x000131D0 File Offset: 0x000113D0
		[Token(Token = "0x6002E02")]
		[Address(RVA = "0x53F1F30", Offset = "0x53F0B30", VA = "0x1853F1F30")]
		public char GetDecrypted()
		{
			return '\0';
		}

		// Token: 0x06002E03 RID: 11779 RVA: 0x000131E8 File Offset: 0x000113E8
		[Token(Token = "0x6002E03")]
		[Address(RVA = "0x53F2050", Offset = "0x53F0C50", VA = "0x1853F2050")]
		private char InternalDecrypt()
		{
			return '\0';
		}

		// Token: 0x06002E04 RID: 11780 RVA: 0x00013200 File Offset: 0x00011400
		[Token(Token = "0x6002E04")]
		[Address(RVA = "0x53F2690", Offset = "0x53F1290", VA = "0x1853F2690")]
		public static implicit operator ObscuredChar(char value)
		{
			return default(ObscuredChar);
		}

		// Token: 0x06002E05 RID: 11781 RVA: 0x00013218 File Offset: 0x00011418
		[Token(Token = "0x6002E05")]
		[Address(RVA = "0x53F2640", Offset = "0x53F1240", VA = "0x1853F2640")]
		public static implicit operator char(ObscuredChar value)
		{
			return '\0';
		}

		// Token: 0x06002E06 RID: 11782 RVA: 0x00013230 File Offset: 0x00011430
		[Token(Token = "0x6002E06")]
		[Address(RVA = "0x53F26C0", Offset = "0x53F12C0", VA = "0x1853F26C0")]
		public static ObscuredChar operator ++(ObscuredChar input)
		{
			return default(ObscuredChar);
		}

		// Token: 0x06002E07 RID: 11783 RVA: 0x00013248 File Offset: 0x00011448
		[Token(Token = "0x6002E07")]
		[Address(RVA = "0x53F25A0", Offset = "0x53F11A0", VA = "0x1853F25A0")]
		public static ObscuredChar operator --(ObscuredChar input)
		{
			return default(ObscuredChar);
		}

		// Token: 0x06002E08 RID: 11784 RVA: 0x00013260 File Offset: 0x00011460
		[Token(Token = "0x6002E08")]
		[Address(RVA = "0x53F1FD0", Offset = "0x53F0BD0", VA = "0x1853F1FD0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002E09 RID: 11785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E09")]
		[Address(RVA = "0x53F2450", Offset = "0x53F1050", VA = "0x1853F2450", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002E0A RID: 11786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E0A")]
		[Address(RVA = "0x53F23C0", Offset = "0x53F0FC0", VA = "0x1853F23C0")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06002E0B RID: 11787 RVA: 0x00013278 File Offset: 0x00011478
		[Token(Token = "0x6002E0B")]
		[Address(RVA = "0x53F1D50", Offset = "0x53F0950", VA = "0x1853F1D50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06002E0C RID: 11788 RVA: 0x00013290 File Offset: 0x00011490
		[Token(Token = "0x6002E0C")]
		[Address(RVA = "0x53F1E90", Offset = "0x53F0A90", VA = "0x1853F1E90", Slot = "4")]
		public bool Equals(ObscuredChar obj)
		{
			return default(bool);
		}

		// Token: 0x06002E0D RID: 11789 RVA: 0x000132A8 File Offset: 0x000114A8
		[Token(Token = "0x6002E0D")]
		[Address(RVA = "0x53F1A80", Offset = "0x53F0680", VA = "0x1853F1A80", Slot = "5")]
		public int CompareTo(ObscuredChar other)
		{
			return 0;
		}

		// Token: 0x06002E0E RID: 11790 RVA: 0x000132C0 File Offset: 0x000114C0
		[Token(Token = "0x6002E0E")]
		[Address(RVA = "0x53F1B20", Offset = "0x53F0720", VA = "0x1853F1B20", Slot = "6")]
		public int CompareTo(char other)
		{
			return 0;
		}

		// Token: 0x06002E0F RID: 11791 RVA: 0x000132D8 File Offset: 0x000114D8
		[Token(Token = "0x6002E0F")]
		[Address(RVA = "0x53F1BB0", Offset = "0x53F07B0", VA = "0x1853F1BB0", Slot = "7")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x040019CB RID: 6603
		[Token(Token = "0x40019CB")]
		[FieldOffset(Offset = "0x0")]
		private static char cryptoKey;

		// Token: 0x040019CC RID: 6604
		[Token(Token = "0x40019CC")]
		[FieldOffset(Offset = "0x0")]
		private char currentCryptoKey;

		// Token: 0x040019CD RID: 6605
		[Token(Token = "0x40019CD")]
		[FieldOffset(Offset = "0x2")]
		private char hiddenValue;

		// Token: 0x040019CE RID: 6606
		[Token(Token = "0x40019CE")]
		[FieldOffset(Offset = "0x4")]
		private bool inited;

		// Token: 0x040019CF RID: 6607
		[Token(Token = "0x40019CF")]
		[FieldOffset(Offset = "0x6")]
		private char fakeValue;

		// Token: 0x040019D0 RID: 6608
		[Token(Token = "0x40019D0")]
		[FieldOffset(Offset = "0x8")]
		private bool fakeValueActive;
	}
}
