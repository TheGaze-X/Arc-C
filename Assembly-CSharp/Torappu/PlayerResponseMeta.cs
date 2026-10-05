using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000610 RID: 1552
	[Token(Token = "0x2000610")]
	public class PlayerResponseMeta
	{
		// Token: 0x06006237 RID: 25143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006237")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerResponseMeta()
		{
		}

		// Token: 0x04002D97 RID: 11671
		[Token(Token = "0x4002D97")]
		[FieldOffset(Offset = "0x10")]
		public List<PlayerPushMessage> extraPushMsg;
	}
}
