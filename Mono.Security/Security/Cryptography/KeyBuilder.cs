using System;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace Mono.Security.Cryptography
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	public sealed class KeyBuilder
	{
		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000080")]
		private static RandomNumberGenerator Rng
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x4A9B6A0", Offset = "0x4A9A2A0", VA = "0x184A9B6A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x4A9B5B0", Offset = "0x4A9A1B0", VA = "0x184A9B5B0")]
		public static byte[] Key(int size)
		{
			return null;
		}

		// Token: 0x04000212 RID: 530
		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x0")]
		private static RandomNumberGenerator rng;
	}
}
