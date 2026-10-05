using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x020002E8 RID: 744
	[Token(Token = "0x20002E8")]
	[System.Runtime.CompilerServices.TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
	public abstract class Aes : SymmetricAlgorithm
	{
		// Token: 0x0600189B RID: 6299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600189B")]
		[Address(RVA = "0x4B23410", Offset = "0x4B22010", VA = "0x184B23410")]
		protected Aes()
		{
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600189C")]
		[Address(RVA = "0x4B230E0", Offset = "0x4B21CE0", VA = "0x184B230E0")]
		public new static Aes Create()
		{
			return null;
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600189D")]
		[Address(RVA = "0x4B22FB0", Offset = "0x4B21BB0", VA = "0x184B22FB0")]
		public new static Aes Create(string algorithmName)
		{
			return null;
		}

		// Token: 0x04000D99 RID: 3481
		[Token(Token = "0x4000D99")]
		[FieldOffset(Offset = "0x0")]
		private static KeySizes[] s_legalBlockSizes;

		// Token: 0x04000D9A RID: 3482
		[Token(Token = "0x4000D9A")]
		[FieldOffset(Offset = "0x8")]
		private static KeySizes[] s_legalKeySizes;
	}
}
