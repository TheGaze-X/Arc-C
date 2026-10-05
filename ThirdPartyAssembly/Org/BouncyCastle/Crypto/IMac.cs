using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x02000221 RID: 545
	[Token(Token = "0x2000221")]
	public interface IMac
	{
		// Token: 0x06001333 RID: 4915
		[Token(Token = "0x6001333")]
		void Init(ICipherParameters parameters);

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06001334 RID: 4916
		[Token(Token = "0x170002AA")]
		string AlgorithmName { [Token(Token = "0x6001334")] get; }

		// Token: 0x06001335 RID: 4917
		[Token(Token = "0x6001335")]
		int GetMacSize();

		// Token: 0x06001336 RID: 4918
		[Token(Token = "0x6001336")]
		void Update(byte input);

		// Token: 0x06001337 RID: 4919
		[Token(Token = "0x6001337")]
		void BlockUpdate(byte[] input, int inOff, int len);

		// Token: 0x06001338 RID: 4920
		[Token(Token = "0x6001338")]
		int DoFinal(byte[] output, int outOff);

		// Token: 0x06001339 RID: 4921
		[Token(Token = "0x6001339")]
		void Reset();
	}
}
