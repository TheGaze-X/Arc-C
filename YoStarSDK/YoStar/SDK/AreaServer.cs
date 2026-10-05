using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YoStar.SDK
{
	// Token: 0x02000071 RID: 113
	[Token(Token = "0x2000071")]
	public class AreaServer
	{
		// Token: 0x0600024B RID: 587 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x5BDFA10", Offset = "0x5BDE610", VA = "0x185BDFA10")]
		public AreaServer()
		{
		}

		// Token: 0x04000201 RID: 513
		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x10")]
		public Server? CURRENT_SERVER;

		// Token: 0x04000202 RID: 514
		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x18")]
		public List<Server> SUPPORT_SERVERS;
	}
}
