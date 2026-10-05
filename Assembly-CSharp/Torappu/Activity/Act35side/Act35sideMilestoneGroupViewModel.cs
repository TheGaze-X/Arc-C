using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using XLua;

namespace Torappu.Activity.Act35side
{
	// Token: 0x02007479 RID: 29817
	[Token(Token = "0x2007479")]
	public class Act35sideMilestoneGroupViewModel : TemplateActivityMilestoneGroupViewModel, IHotfixable
	{
		// Token: 0x0602A0E0 RID: 172256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0E0")]
		[Address(RVA = "0x2598750", Offset = "0x2597350", VA = "0x182598750")]
		public Act35sideMilestoneGroupViewModel(object param)
		{
		}

		// Token: 0x0602A0E1 RID: 172257 RVA: 0x000D7508 File Offset: 0x000D5708
		[Token(Token = "0x602A0E1")]
		[Address(RVA = "0x25985A0", Offset = "0x25971A0", VA = "0x1825985A0")]
		public Act35sideMilestoneGroupViewModel.LevelInfo GetLevelInfo()
		{
			return default(Act35sideMilestoneGroupViewModel.LevelInfo);
		}

		// Token: 0x0403C588 RID: 247176
		[Token(Token = "0x403C588")]
		[FieldOffset(Offset = "0xC0")]
		public List<Act35sideMilestoneDisplayRewardItemViewModel> grandRewardViewModelList;

		// Token: 0x0403C589 RID: 247177
		[Token(Token = "0x403C589")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403C58A RID: 247178
		[Token(Token = "0x403C58A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetLevelInfo;

		// Token: 0x0200747A RID: 29818
		[Token(Token = "0x200747A")]
		public class Plugin : ITemplateActivityMilestonePlugin
		{
			// Token: 0x0602A0E2 RID: 172258 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A0E2")]
			[Address(RVA = "0x25C3200", Offset = "0x25C1E00", VA = "0x1825C3200", Slot = "4")]
			public void InitMilestoneList(string actId, List<TemplateActivityMileStoneItemModel> milestoneList)
			{
			}

			// Token: 0x0602A0E3 RID: 172259 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A0E3")]
			[Address(RVA = "0x25C3560", Offset = "0x25C2160", VA = "0x1825C3560", Slot = "5")]
			public void UpdateMilestoneList(string actId, List<TemplateActivityMileStoneItemModel> milestoneList)
			{
			}

			// Token: 0x0602A0E4 RID: 172260 RVA: 0x000D7520 File Offset: 0x000D5720
			[Token(Token = "0x602A0E4")]
			[Address(RVA = "0x2301B80", Offset = "0x2300780", VA = "0x182301B80", Slot = "6")]
			public int SortMilestoneItem(TemplateActivityMileStoneItemModel m1, TemplateActivityMileStoneItemModel m2)
			{
				return 0;
			}

			// Token: 0x0602A0E5 RID: 172261 RVA: 0x000D7538 File Offset: 0x000D5738
			[Token(Token = "0x602A0E5")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "7")]
			public bool IsItemShow(TemplateActivityMileStoneItemModel itemModel)
			{
				return default(bool);
			}

			// Token: 0x0602A0E6 RID: 172262 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A0E6")]
			[Address(RVA = "0x25C3130", Offset = "0x25C1D30", VA = "0x1825C3130", Slot = "8")]
			public string GetMilestoneId(string actId)
			{
				return null;
			}

			// Token: 0x0602A0E7 RID: 172263 RVA: 0x000D7550 File Offset: 0x000D5750
			[Token(Token = "0x602A0E7")]
			[Address(RVA = "0x25C34F0", Offset = "0x25C20F0", VA = "0x1825C34F0", Slot = "9")]
			public int UpdateMilestoneCount(string actId)
			{
				return 0;
			}

			// Token: 0x0602A0E8 RID: 172264 RVA: 0x000D7568 File Offset: 0x000D5768
			[Token(Token = "0x602A0E8")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "10")]
			public bool NeedFocusToIdx()
			{
				return default(bool);
			}

			// Token: 0x0602A0E9 RID: 172265 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A0E9")]
			[Address(RVA = "0x25C30A0", Offset = "0x25C1CA0", VA = "0x1825C30A0", Slot = "11")]
			public IMilestoneServiceConfig GenOneMilConfig(string actId, string milestoneId, Action<List<RewardItemModel>> onProceed)
			{
				return null;
			}

			// Token: 0x0602A0EA RID: 172266 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A0EA")]
			[Address(RVA = "0x25C3030", Offset = "0x25C1C30", VA = "0x1825C3030", Slot = "12")]
			public IMilestoneServiceConfig GenAllMilConfig(string actId, List<TemplateActivityMileStoneItemModel> milestoneList, Action<List<RewardItemModel>> onProceed)
			{
				return null;
			}

			// Token: 0x0602A0EB RID: 172267 RVA: 0x000D7580 File Offset: 0x000D5780
			[Token(Token = "0x602A0EB")]
			[Address(RVA = "0x25C34A0", Offset = "0x25C20A0", VA = "0x1825C34A0", Slot = "13")]
			public bool IsMilestoneUnlock(string actId)
			{
				return default(bool);
			}

			// Token: 0x0602A0EC RID: 172268 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A0EC")]
			[Address(RVA = "0x25C3170", Offset = "0x25C1D70", VA = "0x1825C3170", Slot = "14")]
			public string GetMilestoneLockedToastDesc(string actId)
			{
				return null;
			}

			// Token: 0x0602A0ED RID: 172269 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A0ED")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Plugin()
			{
			}
		}

		// Token: 0x0200747B RID: 29819
		[Token(Token = "0x200747B")]
		public struct LevelInfo
		{
			// Token: 0x0403C58B RID: 247179
			[Token(Token = "0x403C58B")]
			[FieldOffset(Offset = "0x0")]
			public int countCurLevelNeed;

			// Token: 0x0403C58C RID: 247180
			[Token(Token = "0x403C58C")]
			[FieldOffset(Offset = "0x4")]
			public int countNextLevelNeed;

			// Token: 0x0403C58D RID: 247181
			[Token(Token = "0x403C58D")]
			[FieldOffset(Offset = "0x8")]
			public int curLevel;

			// Token: 0x0403C58E RID: 247182
			[Token(Token = "0x403C58E")]
			[FieldOffset(Offset = "0xC")]
			public bool levelMax;
		}
	}
}
