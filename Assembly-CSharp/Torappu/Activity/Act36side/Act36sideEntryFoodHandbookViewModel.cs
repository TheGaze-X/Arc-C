using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using Torappu.UI.ActivityStage.Extern;
using XLua;

namespace Torappu.Activity.Act36side
{
	// Token: 0x02007445 RID: 29765
	[Token(Token = "0x2007445")]
	public class Act36sideEntryFoodHandbookViewModel : TemplateActivityViewModel, IHotfixable
	{
		// Token: 0x0602A020 RID: 172064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A020")]
		[Address(RVA = "0x259AC20", Offset = "0x2599820", VA = "0x18259AC20")]
		public Act36sideEntryFoodHandbookViewModel(object param)
		{
		}

		// Token: 0x0602A021 RID: 172065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A021")]
		[Address(RVA = "0x259AA00", Offset = "0x2599600", VA = "0x18259AA00")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x0403C3DD RID: 246749
		[Token(Token = "0x403C3DD")]
		[FieldOffset(Offset = "0x20")]
		private DateTime m_actRewardEndTs;

		// Token: 0x0403C3DE RID: 246750
		[Token(Token = "0x403C3DE")]
		[FieldOffset(Offset = "0x28")]
		public Act36sideEntryFoodHandbookViewModel.Status currStatus;

		// Token: 0x0403C3DF RID: 246751
		[Token(Token = "0x403C3DF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403C3E0 RID: 246752
		[Token(Token = "0x403C3E0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x02007446 RID: 29766
		[Token(Token = "0x2007446")]
		public class Input
		{
			// Token: 0x0602A022 RID: 172066 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A022")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403C3E1 RID: 246753
			[Token(Token = "0x403C3E1")]
			[FieldOffset(Offset = "0x10")]
			public ActivityBasicInfo actBasicInfo;
		}

		// Token: 0x02007447 RID: 29767
		[Token(Token = "0x2007447")]
		public enum Status
		{
			// Token: 0x0403C3E3 RID: 246755
			[Token(Token = "0x403C3E3")]
			TIME_OUT,
			// Token: 0x0403C3E4 RID: 246756
			[Token(Token = "0x403C3E4")]
			OPEN,
			// Token: 0x0403C3E5 RID: 246757
			[Token(Token = "0x403C3E5")]
			HAS_REWARD
		}
	}
}
