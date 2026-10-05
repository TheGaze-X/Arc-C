using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002E0 RID: 736
	[Token(Token = "0x20002E0")]
	public class IesWithCipherParameters : IesParameters
	{
		// Token: 0x06001900 RID: 6400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001900")]
		[Address(RVA = "0x528ED80", Offset = "0x528D980", VA = "0x18528ED80")]
		public IesWithCipherParameters(byte[] derivation, byte[] encoding, int macKeySize, int cipherKeySize)
		{
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06001901 RID: 6401 RVA: 0x0000C390 File Offset: 0x0000A590
		[Token(Token = "0x17000379")]
		public int CipherKeySize
		{
			[Token(Token = "0x6001901")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04000D32 RID: 3378
		[Token(Token = "0x4000D32")]
		[FieldOffset(Offset = "0x28")]
		private int cipherKeySize;
	}
}
