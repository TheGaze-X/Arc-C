using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using XLua;

namespace Torappu.Activity.Act1mainss
{
	// Token: 0x0200784C RID: 30796
	[Token(Token = "0x200784C")]
	public class Act1MainSSApCostRewardViewModel : TemplateActivityViewModel
	{
		// Token: 0x17006511 RID: 25873
		// (get) Token: 0x0602B305 RID: 176901 RVA: 0x000DB120 File Offset: 0x000D9320
		// (set) Token: 0x0602B306 RID: 176902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006511")]
		public int rewardPoint
		{
			[Token(Token = "0x602B305")]
			[Address(RVA = "0x271A330", Offset = "0x2718F30", VA = "0x18271A330")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x602B306")]
			[Address(RVA = "0x271A390", Offset = "0x2718F90", VA = "0x18271A390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602B307 RID: 176903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B307")]
		[Address(RVA = "0x271A150", Offset = "0x2718D50", VA = "0x18271A150")]
		public Act1MainSSApCostRewardViewModel(object param)
		{
		}

		// Token: 0x0602B308 RID: 176904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B308")]
		[Address(RVA = "0x27196A0", Offset = "0x27182A0", VA = "0x1827196A0")]
		public Act1MainSSApCostRewardViewModel.Output GetOutput()
		{
			return null;
		}

		// Token: 0x0602B309 RID: 176905 RVA: 0x000DB138 File Offset: 0x000D9338
		[Token(Token = "0x602B309")]
		[Address(RVA = "0x2719B30", Offset = "0x2718730", VA = "0x182719B30")]
		public int GetRewardCount()
		{
			return 0;
		}

		// Token: 0x0602B30A RID: 176906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B30A")]
		[Address(RVA = "0x2719CA0", Offset = "0x27188A0", VA = "0x182719CA0")]
		private void _LoadData()
		{
		}

		// Token: 0x0602B30B RID: 176907 RVA: 0x000DB150 File Offset: 0x000D9350
		[Token(Token = "0x602B30B")]
		[Address(RVA = "0x271A0C0", Offset = "0x2718CC0", VA = "0x18271A0C0")]
		private static int _RewardItemComparison(Act1MainSSApCostRewardViewModel.Act1MainSSApCostRewardItem x, Act1MainSSApCostRewardViewModel.Act1MainSSApCostRewardItem y)
		{
			return 0;
		}

		// Token: 0x0403E6F9 RID: 255737
		[Token(Token = "0x403E6F9")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<Act1MainSSApCostRewardViewModel.Act1MainSSApCostRewardItem> m_rewardItems;

		// Token: 0x0403E6FA RID: 255738
		[Token(Token = "0x403E6FA")]
		[FieldOffset(Offset = "0x28")]
		private readonly Dictionary<string, UIItemViewModel> m_presentingItemDict;

		// Token: 0x0403E6FB RID: 255739
		[Token(Token = "0x403E6FB")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<UIItemViewModel> m_presentingItemList;

		// Token: 0x0403E6FC RID: 255740
		[Token(Token = "0x403E6FC")]
		[FieldOffset(Offset = "0x38")]
		private long m_endTime;

		// Token: 0x0403E6FE RID: 255742
		[Token(Token = "0x403E6FE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_rewardPoint;

		// Token: 0x0403E6FF RID: 255743
		[Token(Token = "0x403E6FF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_rewardPoint;

		// Token: 0x0403E700 RID: 255744
		[Token(Token = "0x403E700")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403E701 RID: 255745
		[Token(Token = "0x403E701")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetOutput;

		// Token: 0x0403E702 RID: 255746
		[Token(Token = "0x403E702")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetRewardCount;

		// Token: 0x0403E703 RID: 255747
		[Token(Token = "0x403E703")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadData;

		// Token: 0x0403E704 RID: 255748
		[Token(Token = "0x403E704")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RewardItemComparison;

		// Token: 0x0200784D RID: 30797
		[Token(Token = "0x200784D")]
		public class Input
		{
			// Token: 0x0602B30C RID: 176908 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B30C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403E705 RID: 255749
			[Token(Token = "0x403E705")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}

		// Token: 0x0200784E RID: 30798
		[Token(Token = "0x200784E")]
		public class Output
		{
			// Token: 0x0602B30D RID: 176909 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B30D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Output()
			{
			}

			// Token: 0x0403E706 RID: 255750
			[Token(Token = "0x403E706")]
			[FieldOffset(Offset = "0x10")]
			public int unconfirmedPoint;

			// Token: 0x0403E707 RID: 255751
			[Token(Token = "0x403E707")]
			[FieldOffset(Offset = "0x14")]
			public int rewardCount;

			// Token: 0x0403E708 RID: 255752
			[Token(Token = "0x403E708")]
			[FieldOffset(Offset = "0x18")]
			public List<UIItemViewModel> presentingItems;

			// Token: 0x0403E709 RID: 255753
			[Token(Token = "0x403E709")]
			[FieldOffset(Offset = "0x20")]
			public bool canProgress;
		}

		// Token: 0x0200784F RID: 30799
		[Token(Token = "0x200784F")]
		public class Act1MainSSApCostRewardItem
		{
			// Token: 0x0602B30E RID: 176910 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B30E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act1MainSSApCostRewardItem()
			{
			}

			// Token: 0x0403E70A RID: 255754
			[Token(Token = "0x403E70A")]
			[FieldOffset(Offset = "0x10")]
			public int index;

			// Token: 0x0403E70B RID: 255755
			[Token(Token = "0x403E70B")]
			[FieldOffset(Offset = "0x18")]
			public string itemId;

			// Token: 0x0403E70C RID: 255756
			[Token(Token = "0x403E70C")]
			[FieldOffset(Offset = "0x20")]
			public ItemType itemType;

			// Token: 0x0403E70D RID: 255757
			[Token(Token = "0x403E70D")]
			[FieldOffset(Offset = "0x24")]
			public int itemCount;
		}
	}
}
