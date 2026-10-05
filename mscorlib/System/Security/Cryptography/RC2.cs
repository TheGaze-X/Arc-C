using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x0200030F RID: 783
	[Token(Token = "0x200030F")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public abstract class RC2 : SymmetricAlgorithm
	{
		// Token: 0x060019B2 RID: 6578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019B2")]
		[Address(RVA = "0x4B31D60", Offset = "0x4B30960", VA = "0x184B31D60")]
		protected RC2()
		{
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x060019B3 RID: 6579 RVA: 0x00011D00 File Offset: 0x0000FF00
		// (set) Token: 0x060019B4 RID: 6580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C1")]
		public virtual int EffectiveKeySize
		{
			[Token(Token = "0x60019B3")]
			[Address(RVA = "0x4B31E00", Offset = "0x4B30A00", VA = "0x184B31E00", Slot = "28")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60019B4")]
			[Address(RVA = "0x4B31E10", Offset = "0x4B30A10", VA = "0x184B31E10", Slot = "29")]
			set
			{
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x060019B5 RID: 6581 RVA: 0x00011D18 File Offset: 0x0000FF18
		// (set) Token: 0x060019B6 RID: 6582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C2")]
		public override int KeySize
		{
			[Token(Token = "0x60019B5")]
			[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70", Slot = "16")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60019B6")]
			[Address(RVA = "0x4B31F80", Offset = "0x4B30B80", VA = "0x184B31F80", Slot = "17")]
			set
			{
			}
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60019B7")]
		[Address(RVA = "0x4B31A70", Offset = "0x4B30670", VA = "0x184B31A70")]
		public new static RC2 Create()
		{
			return null;
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60019B8")]
		[Address(RVA = "0x4B31AC0", Offset = "0x4B306C0", VA = "0x184B31AC0")]
		public new static RC2 Create(string AlgName)
		{
			return null;
		}

		// Token: 0x04000DF3 RID: 3571
		[Token(Token = "0x4000DF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected int EffectiveKeySizeValue;

		// Token: 0x04000DF4 RID: 3572
		[Token(Token = "0x4000DF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static KeySizes[] s_legalBlockSizes;

		// Token: 0x04000DF5 RID: 3573
		[Token(Token = "0x4000DF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static KeySizes[] s_legalKeySizes;
	}
}
