using System;
using Il2CppDummyDll;

namespace Torappu.UI.CommonInviteDialog
{
	// Token: 0x02005BAD RID: 23469
	[Token(Token = "0x2005BAD")]
	public class InvitedRefreshRequest
	{
		// Token: 0x060220D1 RID: 139473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220D1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public InvitedRefreshRequest()
		{
		}

		// Token: 0x0402EB07 RID: 191239
		[Token(Token = "0x402EB07")]
		[FieldOffset(Offset = "0x10")]
		public string inviteId;

		// Token: 0x0402EB08 RID: 191240
		[Token(Token = "0x402EB08")]
		[FieldOffset(Offset = "0x18")]
		public PlayerInviteType inviteType;
	}
}
