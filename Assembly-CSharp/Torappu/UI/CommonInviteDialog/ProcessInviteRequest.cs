using System;
using Il2CppDummyDll;

namespace Torappu.UI.CommonInviteDialog
{
	// Token: 0x02005BAE RID: 23470
	[Token(Token = "0x2005BAE")]
	public class ProcessInviteRequest
	{
		// Token: 0x060220D2 RID: 139474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220D2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ProcessInviteRequest()
		{
		}

		// Token: 0x0402EB09 RID: 191241
		[Token(Token = "0x402EB09")]
		[FieldOffset(Offset = "0x10")]
		public string inviteId;

		// Token: 0x0402EB0A RID: 191242
		[Token(Token = "0x402EB0A")]
		[FieldOffset(Offset = "0x18")]
		public PlayerInviteType inviteType;

		// Token: 0x0402EB0B RID: 191243
		[Token(Token = "0x402EB0B")]
		[FieldOffset(Offset = "0x20")]
		public string fromUid;

		// Token: 0x0402EB0C RID: 191244
		[Token(Token = "0x402EB0C")]
		[FieldOffset(Offset = "0x28")]
		public int fromIdx;

		// Token: 0x0402EB0D RID: 191245
		[Token(Token = "0x402EB0D")]
		[FieldOffset(Offset = "0x2C")]
		public int operate;
	}
}
