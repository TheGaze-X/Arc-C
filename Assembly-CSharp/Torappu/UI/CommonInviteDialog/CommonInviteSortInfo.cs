using System;
using Il2CppDummyDll;

namespace Torappu.UI.CommonInviteDialog
{
	// Token: 0x02005BB8 RID: 23480
	[Token(Token = "0x2005BB8")]
	public class CommonInviteSortInfo
	{
		// Token: 0x060220EA RID: 139498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220EA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CommonInviteSortInfo()
		{
		}

		// Token: 0x0402EB46 RID: 191302
		[Token(Token = "0x402EB46")]
		[FieldOffset(Offset = "0x10")]
		public CommonInviteSortInfo.CustomImpl custom;

		// Token: 0x0402EB47 RID: 191303
		[Token(Token = "0x402EB47")]
		[FieldOffset(Offset = "0x18")]
		public string uid;

		// Token: 0x0402EB48 RID: 191304
		[Token(Token = "0x402EB48")]
		[FieldOffset(Offset = "0x20")]
		public int playerLevel;

		// Token: 0x0402EB49 RID: 191305
		[Token(Token = "0x402EB49")]
		[FieldOffset(Offset = "0x24")]
		public bool isStarMark;

		// Token: 0x0402EB4A RID: 191306
		[Token(Token = "0x402EB4A")]
		[FieldOffset(Offset = "0x28")]
		public DateTime lastOnlineTime;

		// Token: 0x0402EB4B RID: 191307
		[Token(Token = "0x402EB4B")]
		[FieldOffset(Offset = "0x30")]
		public PlayerInviteInfo inviteInfo;

		// Token: 0x0402EB4C RID: 191308
		[Token(Token = "0x402EB4C")]
		[FieldOffset(Offset = "0x38")]
		public ValueBundle extraInfo;

		// Token: 0x02005BB9 RID: 23481
		[Token(Token = "0x2005BB9")]
		public struct CustomImpl
		{
			// Token: 0x0402EB4D RID: 191309
			[Token(Token = "0x402EB4D")]
			[FieldOffset(Offset = "0x0")]
			public bool alreadyInRoom;

			// Token: 0x0402EB4E RID: 191310
			[Token(Token = "0x402EB4E")]
			[FieldOffset(Offset = "0x1")]
			public bool isRecentMate;
		}
	}
}
