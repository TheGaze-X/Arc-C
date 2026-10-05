using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act12side
{
	// Token: 0x02007A5F RID: 31327
	[Token(Token = "0x2007A5F")]
	public class Act12sideMilestoneItemModel : IHotfixable
	{
		// Token: 0x0602BE19 RID: 179737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE19")]
		[Address(RVA = "0x27C2260", Offset = "0x27C0E60", VA = "0x1827C2260")]
		public Act12sideMilestoneItemModel()
		{
		}

		// Token: 0x0403F8C9 RID: 260297
		[Token(Token = "0x403F8C9")]
		[FieldOffset(Offset = "0x10")]
		public Act12sideMilestoneItemModel.MilestoneItemType itemType;

		// Token: 0x0403F8CA RID: 260298
		[Token(Token = "0x403F8CA")]
		[FieldOffset(Offset = "0x14")]
		public int milestoneStage;

		// Token: 0x0403F8CB RID: 260299
		[Token(Token = "0x403F8CB")]
		[FieldOffset(Offset = "0x18")]
		public Act12SideData.MileStoneInfo milestoneInfo;

		// Token: 0x0403F8CC RID: 260300
		[Token(Token = "0x403F8CC")]
		[FieldOffset(Offset = "0x20")]
		public Act12sideMilestoneItemModel.RewardState rewardState;

		// Token: 0x0403F8CD RID: 260301
		[Token(Token = "0x403F8CD")]
		[FieldOffset(Offset = "0x28")]
		public string actId;

		// Token: 0x0403F8CE RID: 260302
		[Token(Token = "0x403F8CE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007A60 RID: 31328
		[Token(Token = "0x2007A60")]
		public enum MilestoneItemType
		{
			// Token: 0x0403F8D0 RID: 260304
			[Token(Token = "0x403F8D0")]
			ITEM,
			// Token: 0x0403F8D1 RID: 260305
			[Token(Token = "0x403F8D1")]
			TITLE
		}

		// Token: 0x02007A61 RID: 31329
		[Token(Token = "0x2007A61")]
		public enum RewardState
		{
			// Token: 0x0403F8D3 RID: 260307
			[Token(Token = "0x403F8D3")]
			NORMAL,
			// Token: 0x0403F8D4 RID: 260308
			[Token(Token = "0x403F8D4")]
			ACTIVE,
			// Token: 0x0403F8D5 RID: 260309
			[Token(Token = "0x403F8D5")]
			COMPLETED
		}
	}
}
