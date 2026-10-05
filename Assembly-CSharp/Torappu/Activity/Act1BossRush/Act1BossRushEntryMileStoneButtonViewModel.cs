using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using Torappu.UI.BossRush;
using XLua;

namespace Torappu.Activity.Act1BossRush
{
	// Token: 0x020070B0 RID: 28848
	[Token(Token = "0x20070B0")]
	public class Act1BossRushEntryMileStoneButtonViewModel : TemplateActivityViewModel, IHotfixable
	{
		// Token: 0x0602902E RID: 167982 RVA: 0x000D4130 File Offset: 0x000D2330
		[Token(Token = "0x602902E")]
		[Address(RVA = "0x2466030", Offset = "0x2464C30", VA = "0x182466030")]
		public MilestoneStruct GetMilestoneStruct()
		{
			return default(MilestoneStruct);
		}

		// Token: 0x0602902F RID: 167983 RVA: 0x000D4148 File Offset: 0x000D2348
		[Token(Token = "0x602902F")]
		[Address(RVA = "0x24660F0", Offset = "0x2464CF0", VA = "0x1824660F0")]
		public bool HasRewardCanClaim()
		{
			return default(bool);
		}

		// Token: 0x06029030 RID: 167984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029030")]
		[Address(RVA = "0x2466170", Offset = "0x2464D70", VA = "0x182466170")]
		public Act1BossRushEntryMileStoneButtonViewModel(object param)
		{
		}

		// Token: 0x0403A896 RID: 239766
		[Token(Token = "0x403A896")]
		[FieldOffset(Offset = "0x20")]
		private Func<MilestoneStruct> m_getMilestoneStructFunc;

		// Token: 0x0403A897 RID: 239767
		[Token(Token = "0x403A897")]
		[FieldOffset(Offset = "0x28")]
		private Func<bool> m_hasMileStoneRewardFunc;

		// Token: 0x0403A898 RID: 239768
		[Token(Token = "0x403A898")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetMilestoneStruct;

		// Token: 0x0403A899 RID: 239769
		[Token(Token = "0x403A899")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HasRewardCanClaim;

		// Token: 0x0403A89A RID: 239770
		[Token(Token = "0x403A89A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020070B1 RID: 28849
		[Token(Token = "0x20070B1")]
		public class Input
		{
			// Token: 0x06029031 RID: 167985 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029031")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403A89B RID: 239771
			[Token(Token = "0x403A89B")]
			[FieldOffset(Offset = "0x10")]
			public Func<MilestoneStruct> getMilestoneStructFunc;

			// Token: 0x0403A89C RID: 239772
			[Token(Token = "0x403A89C")]
			[FieldOffset(Offset = "0x18")]
			public Func<bool> hasMileStoneRewardFunc;
		}
	}
}
