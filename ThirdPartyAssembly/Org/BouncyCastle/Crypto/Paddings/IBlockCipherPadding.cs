using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Paddings
{
	// Token: 0x020002F0 RID: 752
	[Token(Token = "0x20002F0")]
	public interface IBlockCipherPadding
	{
		// Token: 0x06001940 RID: 6464
		[Token(Token = "0x6001940")]
		void Init(SecureRandom random);

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06001941 RID: 6465
		[Token(Token = "0x17000392")]
		string PaddingName { [Token(Token = "0x6001941")] get; }

		// Token: 0x06001942 RID: 6466
		[Token(Token = "0x6001942")]
		int AddPadding(byte[] input, int inOff);

		// Token: 0x06001943 RID: 6467
		[Token(Token = "0x6001943")]
		int PadCount(byte[] input);
	}
}
