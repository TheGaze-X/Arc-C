using System;
using Il2CppDummyDll;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x0200033F RID: 831
	[Token(Token = "0x200033F")]
	internal class TripleDESTransform : SymmetricTransform
	{
		// Token: 0x06001B95 RID: 7061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B95")]
		[Address(RVA = "0x4B68880", Offset = "0x4B67480", VA = "0x184B68880")]
		public TripleDESTransform(TripleDES algo, bool encryption, byte[] key, byte[] iv)
		{
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B96")]
		[Address(RVA = "0x4B68670", Offset = "0x4B67270", VA = "0x184B68670", Slot = "17")]
		protected override void ECB(byte[] input, byte[] output)
		{
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001B97")]
		[Address(RVA = "0x4B687D0", Offset = "0x4B673D0", VA = "0x184B687D0")]
		internal static byte[] GetStrongKey()
		{
			return null;
		}

		// Token: 0x04000ED9 RID: 3801
		[Token(Token = "0x4000ED9")]
		[FieldOffset(Offset = "0x58")]
		private DESTransform E1;

		// Token: 0x04000EDA RID: 3802
		[Token(Token = "0x4000EDA")]
		[FieldOffset(Offset = "0x60")]
		private DESTransform D2;

		// Token: 0x04000EDB RID: 3803
		[Token(Token = "0x4000EDB")]
		[FieldOffset(Offset = "0x68")]
		private DESTransform E3;

		// Token: 0x04000EDC RID: 3804
		[Token(Token = "0x4000EDC")]
		[FieldOffset(Offset = "0x70")]
		private DESTransform D1;

		// Token: 0x04000EDD RID: 3805
		[Token(Token = "0x4000EDD")]
		[FieldOffset(Offset = "0x78")]
		private DESTransform E2;

		// Token: 0x04000EDE RID: 3806
		[Token(Token = "0x4000EDE")]
		[FieldOffset(Offset = "0x80")]
		private DESTransform D3;
	}
}
