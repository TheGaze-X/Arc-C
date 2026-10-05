using System;
using Il2CppDummyDll;

namespace Torappu.UI.CommonInviteDialog
{
	// Token: 0x02005BB6 RID: 23478
	[Token(Token = "0x2005BB6")]
	public class CommonInviteItemDataGroup
	{
		// Token: 0x060220E8 RID: 139496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220E8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CommonInviteItemDataGroup()
		{
		}

		// Token: 0x0402EB3D RID: 191293
		[Token(Token = "0x402EB3D")]
		[FieldOffset(Offset = "0x10")]
		public string uid;

		// Token: 0x0402EB3E RID: 191294
		[Token(Token = "0x402EB3E")]
		[FieldOffset(Offset = "0x18")]
		public int invitedSendCd;

		// Token: 0x0402EB3F RID: 191295
		[Token(Token = "0x402EB3F")]
		[FieldOffset(Offset = "0x20")]
		public CommonInviteDialogItemData itemData;

		// Token: 0x0402EB40 RID: 191296
		[Token(Token = "0x402EB40")]
		[FieldOffset(Offset = "0x28")]
		public CommonInviteSortInfo sortInfo;
	}
}
