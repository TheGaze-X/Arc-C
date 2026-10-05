using System;
using Il2CppDummyDll;
using Torappu.UI.Friend;

namespace Torappu.UI.CommonInviteDialog
{
	// Token: 0x02005BB7 RID: 23479
	[Token(Token = "0x2005BB7")]
	public class CommonInviteDialogItemData
	{
		// Token: 0x060220E9 RID: 139497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220E9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CommonInviteDialogItemData()
		{
		}

		// Token: 0x0402EB41 RID: 191297
		[Token(Token = "0x402EB41")]
		[FieldOffset(Offset = "0x10")]
		public FriendDataWithNameCard friendCard;

		// Token: 0x0402EB42 RID: 191298
		[Token(Token = "0x402EB42")]
		[FieldOffset(Offset = "0x18")]
		public string alias;

		// Token: 0x0402EB43 RID: 191299
		[Token(Token = "0x402EB43")]
		[FieldOffset(Offset = "0x20")]
		public long lastInviteTs;

		// Token: 0x0402EB44 RID: 191300
		[Token(Token = "0x402EB44")]
		[FieldOffset(Offset = "0x28")]
		public ValueBundle extraData;

		// Token: 0x0402EB45 RID: 191301
		[Token(Token = "0x402EB45")]
		[FieldOffset(Offset = "0x48")]
		public FriendUtil.OnlineStatus onlineStatus;
	}
}
