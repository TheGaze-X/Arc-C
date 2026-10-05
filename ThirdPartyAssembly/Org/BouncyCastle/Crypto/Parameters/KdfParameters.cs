using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002E2 RID: 738
	[Token(Token = "0x20002E2")]
	public class KdfParameters : IDerivationParameters
	{
		// Token: 0x06001904 RID: 6404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001904")]
		[Address(RVA = "0x4B61C30", Offset = "0x4B60830", VA = "0x184B61C30")]
		public KdfParameters(byte[] shared, byte[] iv)
		{
		}

		// Token: 0x06001905 RID: 6405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001905")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
		public byte[] GetSharedSecret()
		{
			return null;
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001906")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
		public byte[] GetIV()
		{
			return null;
		}

		// Token: 0x04000D34 RID: 3380
		[Token(Token = "0x4000D34")]
		[FieldOffset(Offset = "0x10")]
		private byte[] iv;

		// Token: 0x04000D35 RID: 3381
		[Token(Token = "0x4000D35")]
		[FieldOffset(Offset = "0x18")]
		private byte[] shared;
	}
}
