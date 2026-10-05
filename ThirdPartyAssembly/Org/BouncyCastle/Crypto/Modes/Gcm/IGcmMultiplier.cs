using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Modes.Gcm
{
	// Token: 0x02000310 RID: 784
	[Token(Token = "0x2000310")]
	public interface IGcmMultiplier
	{
		// Token: 0x06001A5F RID: 6751
		[Token(Token = "0x6001A5F")]
		void Init(byte[] H);

		// Token: 0x06001A60 RID: 6752
		[Token(Token = "0x6001A60")]
		void MultiplyH(byte[] x);
	}
}
