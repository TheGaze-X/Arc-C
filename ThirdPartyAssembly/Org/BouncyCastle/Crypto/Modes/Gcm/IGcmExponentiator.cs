using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Modes.Gcm
{
	// Token: 0x0200030F RID: 783
	[Token(Token = "0x200030F")]
	public interface IGcmExponentiator
	{
		// Token: 0x06001A5D RID: 6749
		[Token(Token = "0x6001A5D")]
		void Init(byte[] x);

		// Token: 0x06001A5E RID: 6750
		[Token(Token = "0x6001A5E")]
		void ExponentiateX(long pow, byte[] output);
	}
}
