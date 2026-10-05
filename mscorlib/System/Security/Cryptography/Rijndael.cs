using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x02000311 RID: 785
	[Token(Token = "0x2000311")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public abstract class Rijndael : SymmetricAlgorithm
	{
		// Token: 0x060019C4 RID: 6596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019C4")]
		[Address(RVA = "0x4B37A20", Offset = "0x4B36620", VA = "0x184B37A20")]
		protected Rijndael()
		{
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60019C5")]
		[Address(RVA = "0x4B375D0", Offset = "0x4B361D0", VA = "0x184B375D0")]
		public new static Rijndael Create()
		{
			return null;
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60019C6")]
		[Address(RVA = "0x4B37770", Offset = "0x4B36370", VA = "0x184B37770")]
		public new static Rijndael Create(string algName)
		{
			return null;
		}

		// Token: 0x04000DF8 RID: 3576
		[Token(Token = "0x4000DF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static KeySizes[] s_legalBlockSizes;

		// Token: 0x04000DF9 RID: 3577
		[Token(Token = "0x4000DF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static KeySizes[] s_legalKeySizes;
	}
}
