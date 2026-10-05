using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002EB RID: 747
	[Token(Token = "0x20002EB")]
	public class RC5Parameters : KeyParameter
	{
		// Token: 0x06001927 RID: 6439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001927")]
		[Address(RVA = "0x5294590", Offset = "0x5293190", VA = "0x185294590")]
		public RC5Parameters(byte[] key, int rounds)
		{
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06001928 RID: 6440 RVA: 0x0000C3C0 File Offset: 0x0000A5C0
		[Token(Token = "0x17000385")]
		public int Rounds
		{
			[Token(Token = "0x6001928")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04000D45 RID: 3397
		[Token(Token = "0x4000D45")]
		[FieldOffset(Offset = "0x18")]
		private readonly int rounds;
	}
}
