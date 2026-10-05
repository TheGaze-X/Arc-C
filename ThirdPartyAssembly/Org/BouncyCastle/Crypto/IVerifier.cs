using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x02000228 RID: 552
	[Token(Token = "0x2000228")]
	public interface IVerifier
	{
		// Token: 0x06001350 RID: 4944
		[Token(Token = "0x6001350")]
		bool IsVerified(byte[] data);

		// Token: 0x06001351 RID: 4945
		[Token(Token = "0x6001351")]
		bool IsVerified(byte[] source, int off, int length);
	}
}
