using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000776 RID: 1910
	[Token(Token = "0x2000776")]
	public enum PlayerSyncModuleMask
	{
		// Token: 0x04003008 RID: 12296
		[Token(Token = "0x4003008")]
		NONE,
		// Token: 0x04003009 RID: 12297
		[Token(Token = "0x4003009")]
		UNREAD_MAILS,
		// Token: 0x0400300A RID: 12298
		[Token(Token = "0x400300A")]
		FRIEND_REQ,
		// Token: 0x0400300B RID: 12299
		[Token(Token = "0x400300B")]
		ANNOUNCE_VER = 4,
		// Token: 0x0400300C RID: 12300
		[Token(Token = "0x400300C")]
		REFRESH_USER_CARD = 8,
		// Token: 0x0400300D RID: 12301
		[Token(Token = "0x400300D")]
		GOOD_PURCHASE_STATE = 16,
		// Token: 0x0400300E RID: 12302
		[Token(Token = "0x400300E")]
		CASH_PURCHASE_STATE = 32,
		// Token: 0x0400300F RID: 12303
		[Token(Token = "0x400300F")]
		CLUE_STATE = 64,
		// Token: 0x04003010 RID: 12304
		[Token(Token = "0x4003010")]
		SYNC_BUILDING = 128,
		// Token: 0x04003011 RID: 12305
		[Token(Token = "0x4003011")]
		SYNC_CRISIS = 256,
		// Token: 0x04003012 RID: 12306
		[Token(Token = "0x4003012")]
		SYNC_ACTIVITY = 512,
		// Token: 0x04003013 RID: 12307
		[Token(Token = "0x4003013")]
		SYNC_MEDAL = 1024,
		// Token: 0x04003014 RID: 12308
		[Token(Token = "0x4003014")]
		CHECK_FORBIDDEN = 2048,
		// Token: 0x04003015 RID: 12309
		[Token(Token = "0x4003015")]
		SYNC_ACTIVITY_FIXED_INTERVAL = 4096
	}
}
