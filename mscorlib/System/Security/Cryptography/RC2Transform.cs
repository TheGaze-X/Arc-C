using System;
using Il2CppDummyDll;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x02000339 RID: 825
	[Token(Token = "0x2000339")]
	internal class RC2Transform : SymmetricTransform
	{
		// Token: 0x06001B6A RID: 7018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B6A")]
		[Address(RVA = "0x4B62A60", Offset = "0x4B61660", VA = "0x184B62A60")]
		public RC2Transform(RC2 rc2Algo, bool encryption, byte[] key, byte[] iv)
		{
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B6B")]
		[Address(RVA = "0x4B61F70", Offset = "0x4B60B70", VA = "0x184B61F70", Slot = "17")]
		protected override void ECB(byte[] input, byte[] output)
		{
		}

		// Token: 0x04000EC5 RID: 3781
		[Token(Token = "0x4000EC5")]
		[FieldOffset(Offset = "0x58")]
		private ushort R0;

		// Token: 0x04000EC6 RID: 3782
		[Token(Token = "0x4000EC6")]
		[FieldOffset(Offset = "0x5A")]
		private ushort R1;

		// Token: 0x04000EC7 RID: 3783
		[Token(Token = "0x4000EC7")]
		[FieldOffset(Offset = "0x5C")]
		private ushort R2;

		// Token: 0x04000EC8 RID: 3784
		[Token(Token = "0x4000EC8")]
		[FieldOffset(Offset = "0x5E")]
		private ushort R3;

		// Token: 0x04000EC9 RID: 3785
		[Token(Token = "0x4000EC9")]
		[FieldOffset(Offset = "0x60")]
		private ushort[] K;

		// Token: 0x04000ECA RID: 3786
		[Token(Token = "0x4000ECA")]
		[FieldOffset(Offset = "0x68")]
		private int j;

		// Token: 0x04000ECB RID: 3787
		[Token(Token = "0x4000ECB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[] pitable;
	}
}
