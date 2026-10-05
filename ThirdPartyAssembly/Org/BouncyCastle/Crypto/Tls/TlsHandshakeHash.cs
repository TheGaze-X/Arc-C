using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000299 RID: 665
	[Token(Token = "0x2000299")]
	public interface TlsHandshakeHash : IDigest
	{
		// Token: 0x06001657 RID: 5719
		[Token(Token = "0x6001657")]
		void Init(TlsContext context);

		// Token: 0x06001658 RID: 5720
		[Token(Token = "0x6001658")]
		TlsHandshakeHash NotifyPrfDetermined();

		// Token: 0x06001659 RID: 5721
		[Token(Token = "0x6001659")]
		void TrackHashAlgorithm(byte hashAlgorithm);

		// Token: 0x0600165A RID: 5722
		[Token(Token = "0x600165A")]
		void SealHashAlgorithms();

		// Token: 0x0600165B RID: 5723
		[Token(Token = "0x600165B")]
		TlsHandshakeHash StopTracking();

		// Token: 0x0600165C RID: 5724
		[Token(Token = "0x600165C")]
		IDigest ForkPrfHash();

		// Token: 0x0600165D RID: 5725
		[Token(Token = "0x600165D")]
		byte[] GetFinalHash(byte hashAlgorithm);
	}
}
