using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200077D RID: 1917
	[Token(Token = "0x200077D")]
	public class PlayerSyncGoodPurchaseResult : PlayerSyncResult
	{
		// Token: 0x060063F6 RID: 25590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063F6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerSyncGoodPurchaseResult()
		{
		}

		// Token: 0x0400301D RID: 12317
		[Token(Token = "0x400301D")]
		[FieldOffset(Offset = "0x10")]
		public GetGoodPurchaseStateResponse goodPurchaseState;
	}
}
