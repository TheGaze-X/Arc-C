using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x020002F9 RID: 761
	[Token(Token = "0x20002F9")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public abstract class DES : SymmetricAlgorithm
	{
		// Token: 0x0600190C RID: 6412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600190C")]
		[Address(RVA = "0x4B27520", Offset = "0x4B26120", VA = "0x184B27520")]
		protected DES()
		{
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x0600190D RID: 6413 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x0600190E RID: 6414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A9")]
		public override byte[] Key
		{
			[Token(Token = "0x600190D")]
			[Address(RVA = "0x4B275C0", Offset = "0x4B261C0", VA = "0x184B275C0", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x600190E")]
			[Address(RVA = "0x4B276C0", Offset = "0x4B262C0", VA = "0x184B276C0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600190F")]
		[Address(RVA = "0x4B26DB0", Offset = "0x4B259B0", VA = "0x184B26DB0")]
		public new static DES Create()
		{
			return null;
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001910")]
		[Address(RVA = "0x4B26CD0", Offset = "0x4B258D0", VA = "0x184B26CD0")]
		public new static DES Create(string algName)
		{
			return null;
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x00011A48 File Offset: 0x0000FC48
		[Token(Token = "0x6001911")]
		[Address(RVA = "0x4B27160", Offset = "0x4B25D60", VA = "0x184B27160")]
		public static bool IsWeakKey(byte[] rgbKey)
		{
			return default(bool);
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x00011A60 File Offset: 0x0000FC60
		[Token(Token = "0x6001912")]
		[Address(RVA = "0x4B26F80", Offset = "0x4B25B80", VA = "0x184B26F80")]
		public static bool IsSemiWeakKey(byte[] rgbKey)
		{
			return default(bool);
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x00011A78 File Offset: 0x0000FC78
		[Token(Token = "0x6001913")]
		[Address(RVA = "0x4B26F60", Offset = "0x4B25B60", VA = "0x184B26F60")]
		private static bool IsLegalKeySize(byte[] rgbKey)
		{
			return default(bool);
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x00011A90 File Offset: 0x0000FC90
		[Token(Token = "0x6001914")]
		[Address(RVA = "0x4B272B0", Offset = "0x4B25EB0", VA = "0x184B272B0")]
		private static ulong QuadWordFromBigEndian(byte[] block)
		{
			return 0UL;
		}

		// Token: 0x04000DC7 RID: 3527
		[Token(Token = "0x4000DC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static KeySizes[] s_legalBlockSizes;

		// Token: 0x04000DC8 RID: 3528
		[Token(Token = "0x4000DC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static KeySizes[] s_legalKeySizes;
	}
}
