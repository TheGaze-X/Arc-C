using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x02000225 RID: 549
	[Token(Token = "0x2000225")]
	public interface ISignerWithRecovery : ISigner
	{
		// Token: 0x06001346 RID: 4934
		[Token(Token = "0x6001346")]
		bool HasFullMessage();

		// Token: 0x06001347 RID: 4935
		[Token(Token = "0x6001347")]
		byte[] GetRecoveredMessage();

		// Token: 0x06001348 RID: 4936
		[Token(Token = "0x6001348")]
		void UpdateWithRecoveredMessage(byte[] signature);
	}
}
