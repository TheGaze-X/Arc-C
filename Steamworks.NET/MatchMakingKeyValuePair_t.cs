using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200017A RID: 378
	[Token(Token = "0x200017A")]
	public struct MatchMakingKeyValuePair_t
	{
		// Token: 0x060008B1 RID: 2225 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60008B1")]
		[Address(RVA = "0xD6AD60", Offset = "0xD69960", VA = "0x180D6AD60")]
		private MatchMakingKeyValuePair_t(string strKey, string strValue)
		{
		}

		// Token: 0x04000A21 RID: 2593
		[Token(Token = "0x4000A21")]
		[FieldOffset(Offset = "0x0")]
		public string m_szKey;

		// Token: 0x04000A22 RID: 2594
		[Token(Token = "0x4000A22")]
		[FieldOffset(Offset = "0x8")]
		public string m_szValue;
	}
}
