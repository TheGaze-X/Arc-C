using System;
using Il2CppDummyDll;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000068")]
	internal class MD2Managed : MD2
	{
		// Token: 0x06000186 RID: 390 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x4ACBD20", Offset = "0x4ACA920", VA = "0x184ACBD20")]
		private byte[] Padding(int nLength)
		{
			return null;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x4ACBE30", Offset = "0x4ACAA30", VA = "0x184ACBE30")]
		public MD2Managed()
		{
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x4A9B9C0", Offset = "0x4A9A5C0", VA = "0x184A9B9C0", Slot = "20")]
		public override void Initialize()
		{
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x4ACB810", Offset = "0x4ACA410", VA = "0x184ACB810", Slot = "18")]
		protected override void HashCore(byte[] array, int ibStart, int cbSize)
		{
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x4ACB910", Offset = "0x4ACA510", VA = "0x184ACB910", Slot = "19")]
		protected override byte[] HashFinal()
		{
			return null;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x4ACBAB0", Offset = "0x4ACA6B0", VA = "0x184ACBAB0")]
		private void MD2Transform(byte[] state, byte[] checksum, byte[] block, int index)
		{
		}

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x28")]
		private byte[] state;

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x30")]
		private byte[] checksum;

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x38")]
		private byte[] buffer;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x40")]
		private int count;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x48")]
		private byte[] x;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[] PI_SUBST;
	}
}
