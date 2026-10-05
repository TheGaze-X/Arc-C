using System;
using Il2CppDummyDll;

namespace Torappu.UI.CommonInviteDialog
{
	// Token: 0x02005BAB RID: 23467
	[Token(Token = "0x2005BAB")]
	public class InviteRequest
	{
		// Token: 0x060220CF RID: 139471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220CF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public InviteRequest()
		{
		}

		// Token: 0x0402EB03 RID: 191235
		[Token(Token = "0x402EB03")]
		[FieldOffset(Offset = "0x10")]
		public string inviteId;

		// Token: 0x0402EB04 RID: 191236
		[Token(Token = "0x402EB04")]
		[FieldOffset(Offset = "0x18")]
		public PlayerInviteType inviteType;

		// Token: 0x0402EB05 RID: 191237
		[Token(Token = "0x402EB05")]
		[FieldOffset(Offset = "0x20")]
		public string toUid;
	}
}
