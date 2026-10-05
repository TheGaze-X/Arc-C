using System;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000053")]
	public abstract class RC4 : SymmetricAlgorithm
	{
		// Token: 0x060001DA RID: 474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x4AA3250", Offset = "0x4AA1E50", VA = "0x184AA3250")]
		public RC4()
		{
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001DB RID: 475 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060001DC RID: 476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000087")]
		public override byte[] IV
		{
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x4AA32F0", Offset = "0x4AA1EF0", VA = "0x184AA32F0", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x4AA2F40", Offset = "0x4AA1B40", VA = "0x184AA2F40")]
		public new static RC4 Create()
		{
			return null;
		}

		// Token: 0x0400022A RID: 554
		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x0")]
		private static KeySizes[] s_legalBlockSizes;

		// Token: 0x0400022B RID: 555
		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x8")]
		private static KeySizes[] s_legalKeySizes;
	}
}
