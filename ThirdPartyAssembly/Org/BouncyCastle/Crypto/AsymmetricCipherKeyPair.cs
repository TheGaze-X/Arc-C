using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x0200020A RID: 522
	[Token(Token = "0x200020A")]
	public class AsymmetricCipherKeyPair
	{
		// Token: 0x06001293 RID: 4755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001293")]
		[Address(RVA = "0x521F2E0", Offset = "0x521DEE0", VA = "0x18521F2E0")]
		public AsymmetricCipherKeyPair(AsymmetricKeyParameter publicParameter, AsymmetricKeyParameter privateParameter)
		{
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06001294 RID: 4756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000299")]
		public AsymmetricKeyParameter Public
		{
			[Token(Token = "0x6001294")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06001295 RID: 4757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700029A")]
		public AsymmetricKeyParameter Private
		{
			[Token(Token = "0x6001295")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400094C RID: 2380
		[Token(Token = "0x400094C")]
		[FieldOffset(Offset = "0x10")]
		private readonly AsymmetricKeyParameter publicParameter;

		// Token: 0x0400094D RID: 2381
		[Token(Token = "0x400094D")]
		[FieldOffset(Offset = "0x18")]
		private readonly AsymmetricKeyParameter privateParameter;
	}
}
