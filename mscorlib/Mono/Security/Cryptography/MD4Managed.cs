using System;
using Il2CppDummyDll;

namespace Mono.Security.Cryptography
{
	// Token: 0x0200006A RID: 106
	[Token(Token = "0x200006A")]
	internal class MD4Managed : MD4
	{
		// Token: 0x0600018F RID: 399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x4ACC390", Offset = "0x4ACAF90", VA = "0x184ACC390")]
		public MD4Managed()
		{
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x4A9C6C0", Offset = "0x4A9B2C0", VA = "0x184A9C6C0", Slot = "20")]
		public override void Initialize()
		{
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x4A9C250", Offset = "0x4A9AE50", VA = "0x184A9C250", Slot = "18")]
		protected override void HashCore(byte[] array, int ibStart, int cbSize)
		{
		}

		// Token: 0x06000192 RID: 402 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x4ACC030", Offset = "0x4ACAC30", VA = "0x184ACC030", Slot = "19")]
		protected override byte[] HashFinal()
		{
			return null;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x4ACC330", Offset = "0x4ACAF30", VA = "0x184ACC330")]
		private byte[] Padding(int nLength)
		{
			return null;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00002C70 File Offset: 0x00000E70
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x4A9C180", Offset = "0x4A9AD80", VA = "0x184A9C180")]
		private uint F(uint x, uint y, uint z)
		{
			return 0U;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00002C88 File Offset: 0x00000E88
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x4A9C1E0", Offset = "0x4A9ADE0", VA = "0x184A9C1E0")]
		private uint G(uint x, uint y, uint z)
		{
			return 0U;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00002CA0 File Offset: 0x00000EA0
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x4A9C240", Offset = "0x4A9AE40", VA = "0x184A9C240")]
		private uint H(uint x, uint y, uint z)
		{
			return 0U;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002CB8 File Offset: 0x00000EB8
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x4A9D1D0", Offset = "0x4A9BDD0", VA = "0x184A9D1D0")]
		private uint ROL(uint x, byte n)
		{
			return 0U;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x4A9C140", Offset = "0x4A9AD40", VA = "0x184A9C140")]
		private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s)
		{
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x4A9C190", Offset = "0x4A9AD90", VA = "0x184A9C190")]
		private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s)
		{
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x4A9C1F0", Offset = "0x4A9ADF0", VA = "0x184A9C1F0")]
		private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s)
		{
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x4A9C070", Offset = "0x4A9AC70", VA = "0x184A9C070")]
		private void Encode(byte[] output, uint[] input)
		{
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x4A9BFC0", Offset = "0x4A9ABC0", VA = "0x184A9BFC0")]
		private void Decode(uint[] output, byte[] input, int index)
		{
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x4A9C790", Offset = "0x4A9B390", VA = "0x184A9C790")]
		private void MD4Transform(uint[] state, byte[] block, int index)
		{
		}

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x28")]
		private uint[] state;

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x30")]
		private byte[] buffer;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x38")]
		private uint[] count;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x40")]
		private uint[] x;

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x48")]
		private byte[] digest;
	}
}
