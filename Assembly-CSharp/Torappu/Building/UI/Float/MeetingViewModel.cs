using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DC4 RID: 7620
	[Token(Token = "0x2001DC4")]
	public class MeetingViewModel
	{
		// Token: 0x0600BBFE RID: 48126 RVA: 0x000460C8 File Offset: 0x000442C8
		[Token(Token = "0x600BBFE")]
		[Address(RVA = "0x3398410", Offset = "0x3397010", VA = "0x183398410")]
		public bool CheckIfCanSettleCredit(out string errorAlert)
		{
			return default(bool);
		}

		// Token: 0x0600BBFF RID: 48127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBFF")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void LoadData()
		{
		}

		// Token: 0x0600BC00 RID: 48128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC00")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MeetingViewModel()
		{
		}

		// Token: 0x0400BBF4 RID: 48116
		[Token(Token = "0x400BBF4")]
		[FieldOffset(Offset = "0x10")]
		public int creditFromAssist;

		// Token: 0x0400BBF5 RID: 48117
		[Token(Token = "0x400BBF5")]
		[FieldOffset(Offset = "0x14")]
		public int creditFromAssistMax;

		// Token: 0x0400BBF6 RID: 48118
		[Token(Token = "0x400BBF6")]
		[FieldOffset(Offset = "0x18")]
		public int creditFromDorm;

		// Token: 0x0400BBF7 RID: 48119
		[Token(Token = "0x400BBF7")]
		[FieldOffset(Offset = "0x1C")]
		public int creditFromDormMax;

		// Token: 0x0400BBF8 RID: 48120
		[Token(Token = "0x400BBF8")]
		[FieldOffset(Offset = "0x20")]
		public int creditFromVisit;

		// Token: 0x0400BBF9 RID: 48121
		[Token(Token = "0x400BBF9")]
		[FieldOffset(Offset = "0x24")]
		public int creditFromVisitMax;

		// Token: 0x0400BBFA RID: 48122
		[Token(Token = "0x400BBFA")]
		[FieldOffset(Offset = "0x28")]
		public int totalCredit;

		// Token: 0x0400BBFB RID: 48123
		[Token(Token = "0x400BBFB")]
		[FieldOffset(Offset = "0x2C")]
		public int totalCreditMax;

		// Token: 0x0400BBFC RID: 48124
		[Token(Token = "0x400BBFC")]
		[FieldOffset(Offset = "0x30")]
		public bool hasCreditSettled;

		// Token: 0x0400BBFD RID: 48125
		[Token(Token = "0x400BBFD")]
		[FieldOffset(Offset = "0x34")]
		public int visitNum;

		// Token: 0x0400BBFE RID: 48126
		[Token(Token = "0x400BBFE")]
		[FieldOffset(Offset = "0x38")]
		public RoomSlotModel slotModel;
	}
}
