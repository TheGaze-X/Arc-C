using System;
using Il2CppDummyDll;

namespace Mono.Security.Cryptography
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	public class MD2Managed : MD2
	{
		// Token: 0x0600019E RID: 414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x4A9BC90", Offset = "0x4A9A890", VA = "0x184A9BC90")]
		private byte[] Padding(int nLength)
		{
			return null;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x4A9BDA0", Offset = "0x4A9A9A0", VA = "0x184A9BDA0")]
		public MD2Managed()
		{
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x4A9B9C0", Offset = "0x4A9A5C0", VA = "0x184A9B9C0", Slot = "20")]
		public override void Initialize()
		{
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x4A9B720", Offset = "0x4A9A320", VA = "0x184A9B720", Slot = "18")]
		protected override void HashCore(byte[] array, int ibStart, int cbSize)
		{
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x4A9B820", Offset = "0x4A9A420", VA = "0x184A9B820", Slot = "19")]
		protected override byte[] HashFinal()
		{
			return null;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x4A9BA20", Offset = "0x4A9A620", VA = "0x184A9BA20")]
		private void MD2Transform(byte[] state, byte[] checksum, byte[] block, int index)
		{
		}

		// Token: 0x04000213 RID: 531
		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x28")]
		private byte[] state;

		// Token: 0x04000214 RID: 532
		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x30")]
		private byte[] checksum;

		// Token: 0x04000215 RID: 533
		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x38")]
		private byte[] buffer;

		// Token: 0x04000216 RID: 534
		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x40")]
		private int count;

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x48")]
		private byte[] x;

		// Token: 0x04000218 RID: 536
		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[] PI_SUBST;
	}
}
