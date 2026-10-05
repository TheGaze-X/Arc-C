using System;
using Il2CppDummyDll;

namespace Torappu.UI.CommonInviteDialog
{
	// Token: 0x02005BB0 RID: 23472
	[Token(Token = "0x2005BB0")]
	public class InvitedSettingRequest
	{
		// Token: 0x060220D4 RID: 139476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220D4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public InvitedSettingRequest()
		{
		}

		// Token: 0x0402EB0F RID: 191247
		[Token(Token = "0x402EB0F")]
		[FieldOffset(Offset = "0x10")]
		public string inviteId;

		// Token: 0x0402EB10 RID: 191248
		[Token(Token = "0x402EB10")]
		[FieldOffset(Offset = "0x18")]
		public PlayerInviteType inviteType;

		// Token: 0x0402EB11 RID: 191249
		[Token(Token = "0x402EB11")]
		[FieldOffset(Offset = "0x1C")]
		public int operate;
	}
}
