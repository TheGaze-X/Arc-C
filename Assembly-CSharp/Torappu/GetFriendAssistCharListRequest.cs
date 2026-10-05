using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008B0 RID: 2224
	[Token(Token = "0x20008B0")]
	public class GetFriendAssistCharListRequest
	{
		// Token: 0x0600655A RID: 25946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600655A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GetFriendAssistCharListRequest()
		{
		}

		// Token: 0x0400328B RID: 12939
		[Token(Token = "0x400328B")]
		[FieldOffset(Offset = "0x10")]
		public string profession;

		// Token: 0x0400328C RID: 12940
		[Token(Token = "0x400328C")]
		[FieldOffset(Offset = "0x18")]
		public bool askRefresh;

		// Token: 0x0400328D RID: 12941
		[Token(Token = "0x400328D")]
		[FieldOffset(Offset = "0x20")]
		public string currSquadId;
	}
}
