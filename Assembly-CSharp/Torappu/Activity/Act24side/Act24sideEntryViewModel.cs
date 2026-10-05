using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007592 RID: 30098
	[Token(Token = "0x2007592")]
	public class Act24sideEntryViewModel : TemplateActivityViewModel, IRefreshBattleTrapData, IHotfixable, IRefreshMissionData, IRefreshEatData
	{
		// Token: 0x0602A5DC RID: 173532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5DC")]
		[Address(RVA = "0x2600FA0", Offset = "0x25FFBA0", VA = "0x182600FA0")]
		public Act24sideEntryViewModel(object param)
		{
		}

		// Token: 0x0602A5DD RID: 173533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5DD")]
		[Address(RVA = "0x2600F30", Offset = "0x25FFB30", VA = "0x182600F30", Slot = "5")]
		public void RefreshMissionData()
		{
		}

		// Token: 0x0602A5DE RID: 173534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5DE")]
		[Address(RVA = "0x2600E50", Offset = "0x25FFA50", VA = "0x182600E50", Slot = "4")]
		public void RefreshBattleTrapData()
		{
		}

		// Token: 0x0602A5DF RID: 173535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5DF")]
		[Address(RVA = "0x2600EC0", Offset = "0x25FFAC0", VA = "0x182600EC0", Slot = "6")]
		public void RefreshEatData()
		{
		}

		// Token: 0x0403CF2F RID: 249647
		[Token(Token = "0x403CF2F")]
		[FieldOffset(Offset = "0x20")]
		public string actId;

		// Token: 0x0403CF30 RID: 249648
		[Token(Token = "0x403CF30")]
		[FieldOffset(Offset = "0x28")]
		public Act24sideEntryEatViewModel eatViewModel;

		// Token: 0x0403CF31 RID: 249649
		[Token(Token = "0x403CF31")]
		[FieldOffset(Offset = "0x30")]
		public Act24sideEntryBattleTrapViewModel trapViewModel;

		// Token: 0x0403CF32 RID: 249650
		[Token(Token = "0x403CF32")]
		[FieldOffset(Offset = "0x38")]
		public Act24sideEntryMissionViewModel missionViewModel;

		// Token: 0x0403CF33 RID: 249651
		[Token(Token = "0x403CF33")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403CF34 RID: 249652
		[Token(Token = "0x403CF34")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshMissionData;

		// Token: 0x0403CF35 RID: 249653
		[Token(Token = "0x403CF35")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshBattleTrapData;

		// Token: 0x0403CF36 RID: 249654
		[Token(Token = "0x403CF36")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RefreshEatData;

		// Token: 0x02007593 RID: 30099
		[Token(Token = "0x2007593")]
		public class Input
		{
			// Token: 0x0602A5E0 RID: 173536 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A5E0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403CF37 RID: 249655
			[Token(Token = "0x403CF37")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}
	}
}
