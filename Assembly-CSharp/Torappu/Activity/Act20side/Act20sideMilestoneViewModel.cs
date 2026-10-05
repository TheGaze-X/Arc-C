using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x0200769E RID: 30366
	[Token(Token = "0x200769E")]
	public class Act20sideMilestoneViewModel : IHotfixable
	{
		// Token: 0x0602AB39 RID: 174905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB39")]
		[Address(RVA = "0x2679970", Offset = "0x2678570", VA = "0x182679970")]
		public void LoadData(string activityId)
		{
		}

		// Token: 0x0602AB3A RID: 174906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB3A")]
		[Address(RVA = "0x2679700", Offset = "0x2678300", VA = "0x182679700")]
		private void InitItemGetTip()
		{
		}

		// Token: 0x0602AB3B RID: 174907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB3B")]
		[Address(RVA = "0x2679FD0", Offset = "0x2678BD0", VA = "0x182679FD0")]
		private void RefreshProgress()
		{
		}

		// Token: 0x0602AB3C RID: 174908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB3C")]
		[Address(RVA = "0x2679EC0", Offset = "0x2678AC0", VA = "0x182679EC0")]
		private void RefreshCollectNum()
		{
		}

		// Token: 0x0602AB3D RID: 174909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AB3D")]
		[Address(RVA = "0x2679440", Offset = "0x2678040", VA = "0x182679440")]
		public Act20sideMilestoneViewModel.RecycleInfo GetRecyclePartValue()
		{
			return null;
		}

		// Token: 0x0602AB3E RID: 174910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AB3E")]
		[Address(RVA = "0x2678F50", Offset = "0x2677B50", VA = "0x182678F50")]
		public List<Act20sideMilestoneLoopItemViewModel> GetItemListForAnim(int rowNum = 4)
		{
			return null;
		}

		// Token: 0x0602AB3F RID: 174911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AB3F")]
		[Address(RVA = "0x2679DB0", Offset = "0x26789B0", VA = "0x182679DB0")]
		public List<Act20sideMilestoneLoopItemViewModel> RearrangeItemList(int rowNum = 4)
		{
			return null;
		}

		// Token: 0x0602AB40 RID: 174912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB40")]
		[Address(RVA = "0x267A060", Offset = "0x2678C60", VA = "0x18267A060")]
		public Act20sideMilestoneViewModel()
		{
		}

		// Token: 0x0403D888 RID: 252040
		[Token(Token = "0x403D888")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403D889 RID: 252041
		[Token(Token = "0x403D889")]
		[FieldOffset(Offset = "0x18")]
		private PlayerActivity.PlayerAct20SideActivity.MilestoneStateInfo _mileStoneData;

		// Token: 0x0403D88A RID: 252042
		[Token(Token = "0x403D88A")]
		[FieldOffset(Offset = "0x20")]
		public int milestonePointInterval;

		// Token: 0x0403D88B RID: 252043
		[Token(Token = "0x403D88B")]
		[FieldOffset(Offset = "0x24")]
		public int packageNum;

		// Token: 0x0403D88C RID: 252044
		[Token(Token = "0x403D88C")]
		[FieldOffset(Offset = "0x28")]
		public int remainProgressNum;

		// Token: 0x0403D88D RID: 252045
		[Token(Token = "0x403D88D")]
		[FieldOffset(Offset = "0x2C")]
		public int colNum;

		// Token: 0x0403D88E RID: 252046
		[Token(Token = "0x403D88E")]
		[FieldOffset(Offset = "0x30")]
		public int collectedPartNum;

		// Token: 0x0403D88F RID: 252047
		[Token(Token = "0x403D88F")]
		[FieldOffset(Offset = "0x34")]
		public int totalPartNum;

		// Token: 0x0403D890 RID: 252048
		[Token(Token = "0x403D890")]
		[FieldOffset(Offset = "0x38")]
		public string obtainItemRangeTip;

		// Token: 0x0403D891 RID: 252049
		[Token(Token = "0x403D891")]
		[FieldOffset(Offset = "0x40")]
		public string actCurrencyName;

		// Token: 0x0403D892 RID: 252050
		[Token(Token = "0x403D892")]
		[FieldOffset(Offset = "0x48")]
		private List<Act20sideMilestoneLoopItemViewModel> _cachedLoopItemList;

		// Token: 0x0403D893 RID: 252051
		[Token(Token = "0x403D893")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403D894 RID: 252052
		[Token(Token = "0x403D894")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitItemGetTip;

		// Token: 0x0403D895 RID: 252053
		[Token(Token = "0x403D895")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshProgress;

		// Token: 0x0403D896 RID: 252054
		[Token(Token = "0x403D896")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RefreshCollectNum;

		// Token: 0x0403D897 RID: 252055
		[Token(Token = "0x403D897")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetRecyclePartValue;

		// Token: 0x0403D898 RID: 252056
		[Token(Token = "0x403D898")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetItemListForAnim;

		// Token: 0x0403D899 RID: 252057
		[Token(Token = "0x403D899")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RearrangeItemList;

		// Token: 0x0403D89A RID: 252058
		[Token(Token = "0x403D89A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200769F RID: 30367
		[Token(Token = "0x200769F")]
		public class RecycleInfo
		{
			// Token: 0x0602AB41 RID: 174913 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AB41")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RecycleInfo()
			{
			}

			// Token: 0x0403D89B RID: 252059
			[Token(Token = "0x403D89B")]
			[FieldOffset(Offset = "0x10")]
			public int recycleNum;

			// Token: 0x0403D89C RID: 252060
			[Token(Token = "0x403D89C")]
			[FieldOffset(Offset = "0x14")]
			public int recycleVal;
		}
	}
}
