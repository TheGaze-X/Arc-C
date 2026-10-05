using System;
using Il2CppDummyDll;

namespace Mono.Security.Cryptography
{
	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	public class MD4Managed : MD4
	{
		// Token: 0x060001A7 RID: 423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x4A9D1F0", Offset = "0x4A9BDF0", VA = "0x184A9D1F0")]
		public MD4Managed()
		{
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x4A9C6C0", Offset = "0x4A9B2C0", VA = "0x184A9C6C0", Slot = "20")]
		public override void Initialize()
		{
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x4A9C250", Offset = "0x4A9AE50", VA = "0x184A9C250", Slot = "18")]
		protected override void HashCore(byte[] array, int ibStart, int cbSize)
		{
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x4A9C3C0", Offset = "0x4A9AFC0", VA = "0x184A9C3C0", Slot = "19")]
		protected override byte[] HashFinal()
		{
			return null;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x4A9D170", Offset = "0x4A9BD70", VA = "0x184A9D170")]
		private byte[] Padding(int nLength)
		{
			return null;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x4A9C180", Offset = "0x4A9AD80", VA = "0x184A9C180")]
		private uint F(uint x, uint y, uint z)
		{
			return 0U;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000027D8 File Offset: 0x000009D8
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x4A9C1E0", Offset = "0x4A9ADE0", VA = "0x184A9C1E0")]
		private uint G(uint x, uint y, uint z)
		{
			return 0U;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000027F0 File Offset: 0x000009F0
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x4A9C240", Offset = "0x4A9AE40", VA = "0x184A9C240")]
		private uint H(uint x, uint y, uint z)
		{
			return 0U;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002808 File Offset: 0x00000A08
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x4A9D1D0", Offset = "0x4A9BDD0", VA = "0x184A9D1D0")]
		private uint ROL(uint x, byte n)
		{
			return 0U;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x4A9C140", Offset = "0x4A9AD40", VA = "0x184A9C140")]
		private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s)
		{
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x4A9C190", Offset = "0x4A9AD90", VA = "0x184A9C190")]
		private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s)
		{
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x4A9C1F0", Offset = "0x4A9ADF0", VA = "0x184A9C1F0")]
		private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s)
		{
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x4A9C070", Offset = "0x4A9AC70", VA = "0x184A9C070")]
		private void Encode(byte[] output, uint[] input)
		{
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x4A9BFC0", Offset = "0x4A9ABC0", VA = "0x184A9BFC0")]
		private void Decode(uint[] output, byte[] input, int index)
		{
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x4A9C790", Offset = "0x4A9B390", VA = "0x184A9C790")]
		private void MD4Transform(uint[] state, byte[] block, int index)
		{
		}

		// Token: 0x04000219 RID: 537
		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x28")]
		private uint[] state;

		// Token: 0x0400021A RID: 538
		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x30")]
		private byte[] buffer;

		// Token: 0x0400021B RID: 539
		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x38")]
		private uint[] count;

		// Token: 0x0400021C RID: 540
		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x40")]
		private uint[] x;

		// Token: 0x0400021D RID: 541
		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x48")]
		private byte[] digest;
	}
}
