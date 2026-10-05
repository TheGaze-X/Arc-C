using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x02000310 RID: 784
	[Token(Token = "0x2000310")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public sealed class RC2CryptoServiceProvider : RC2
	{
		// Token: 0x060019BA RID: 6586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019BA")]
		[Address(RVA = "0x4B317A0", Offset = "0x4B303A0", VA = "0x184B317A0")]
		public RC2CryptoServiceProvider()
		{
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x060019BB RID: 6587 RVA: 0x00011D30 File Offset: 0x0000FF30
		// (set) Token: 0x060019BC RID: 6588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C3")]
		public override int EffectiveKeySize
		{
			[Token(Token = "0x60019BB")]
			[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70", Slot = "28")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60019BC")]
			[Address(RVA = "0x4B319F0", Offset = "0x4B305F0", VA = "0x184B319F0", Slot = "29")]
			set
			{
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x060019BD RID: 6589 RVA: 0x00011D48 File Offset: 0x0000FF48
		// (set) Token: 0x060019BE RID: 6590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C4")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public bool UseSalt
		{
			[Token(Token = "0x60019BD")]
			[Address(RVA = "0x789390", Offset = "0x787F90", VA = "0x180789390")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60019BE")]
			[Address(RVA = "0x150B0D0", Offset = "0x1509CD0", VA = "0x18150B0D0")]
			set
			{
			}
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60019BF")]
		[Address(RVA = "0x4B31430", Offset = "0x4B30030", VA = "0x184B31430", Slot = "23")]
		public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
		{
			return null;
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60019C0")]
		[Address(RVA = "0x4B31340", Offset = "0x4B2FF40", VA = "0x184B31340", Slot = "25")]
		public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
		{
			return null;
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019C1")]
		[Address(RVA = "0x4B315E0", Offset = "0x4B301E0", VA = "0x184B315E0", Slot = "26")]
		public override void GenerateKey()
		{
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019C2")]
		[Address(RVA = "0x4B31520", Offset = "0x4B30120", VA = "0x184B31520", Slot = "27")]
		public override void GenerateIV()
		{
		}

		// Token: 0x04000DF6 RID: 3574
		[Token(Token = "0x4000DF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_use40bitSalt;

		// Token: 0x04000DF7 RID: 3575
		[Token(Token = "0x4000DF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static KeySizes[] s_legalKeySizes;
	}
}
