using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x0200022D RID: 557
	[Token(Token = "0x200022D")]
	public class KeyGenerationParameters
	{
		// Token: 0x0600135B RID: 4955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600135B")]
		[Address(RVA = "0x524A510", Offset = "0x5249110", VA = "0x18524A510")]
		public KeyGenerationParameters(SecureRandom random, int strength)
		{
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x0600135C RID: 4956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B1")]
		public SecureRandom Random
		{
			[Token(Token = "0x600135C")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x0600135D RID: 4957 RVA: 0x0000A788 File Offset: 0x00008988
		[Token(Token = "0x170002B2")]
		public int Strength
		{
			[Token(Token = "0x600135D")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04000960 RID: 2400
		[Token(Token = "0x4000960")]
		[FieldOffset(Offset = "0x10")]
		private SecureRandom random;

		// Token: 0x04000961 RID: 2401
		[Token(Token = "0x4000961")]
		[FieldOffset(Offset = "0x18")]
		private int strength;
	}
}
