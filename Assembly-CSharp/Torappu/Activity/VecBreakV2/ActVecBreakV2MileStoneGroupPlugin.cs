using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E42 RID: 28226
	[Token(Token = "0x2006E42")]
	public class ActVecBreakV2MileStoneGroupPlugin : ITemplateActivityMilestonePlugin
	{
		// Token: 0x060282AF RID: 164527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282AF")]
		[Address(RVA = "0x2375F80", Offset = "0x2374B80", VA = "0x182375F80", Slot = "4")]
		public void InitMilestoneList(string actId, List<TemplateActivityMileStoneItemModel> milestoneList)
		{
		}

		// Token: 0x060282B0 RID: 164528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282B0")]
		[Address(RVA = "0x23762A0", Offset = "0x2374EA0", VA = "0x1823762A0", Slot = "5")]
		public void UpdateMilestoneList(string actId, List<TemplateActivityMileStoneItemModel> milestoneList)
		{
		}

		// Token: 0x060282B1 RID: 164529 RVA: 0x000D0CF8 File Offset: 0x000CEEF8
		[Token(Token = "0x60282B1")]
		[Address(RVA = "0x2301B80", Offset = "0x2300780", VA = "0x182301B80", Slot = "6")]
		public int SortMilestoneItem(TemplateActivityMileStoneItemModel m1, TemplateActivityMileStoneItemModel m2)
		{
			return 0;
		}

		// Token: 0x060282B2 RID: 164530 RVA: 0x000D0D10 File Offset: 0x000CEF10
		[Token(Token = "0x60282B2")]
		[Address(RVA = "0x2376240", Offset = "0x2374E40", VA = "0x182376240", Slot = "7")]
		public bool IsItemShow(TemplateActivityMileStoneItemModel itemModel)
		{
			return default(bool);
		}

		// Token: 0x060282B3 RID: 164531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60282B3")]
		[Address(RVA = "0x2375F10", Offset = "0x2374B10", VA = "0x182375F10", Slot = "8")]
		public string GetMilestoneId(string actId)
		{
			return null;
		}

		// Token: 0x060282B4 RID: 164532 RVA: 0x000D0D28 File Offset: 0x000CEF28
		[Token(Token = "0x60282B4")]
		[Address(RVA = "0x2376270", Offset = "0x2374E70", VA = "0x182376270", Slot = "9")]
		public int UpdateMilestoneCount(string actId)
		{
			return 0;
		}

		// Token: 0x060282B5 RID: 164533 RVA: 0x000D0D40 File Offset: 0x000CEF40
		[Token(Token = "0x60282B5")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "10")]
		public bool NeedFocusToIdx()
		{
			return default(bool);
		}

		// Token: 0x060282B6 RID: 164534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60282B6")]
		[Address(RVA = "0x2375E80", Offset = "0x2374A80", VA = "0x182375E80", Slot = "11")]
		public IMilestoneServiceConfig GenOneMilConfig(string actId, string milestoneId, Action<List<RewardItemModel>> onProceed)
		{
			return null;
		}

		// Token: 0x060282B7 RID: 164535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60282B7")]
		[Address(RVA = "0x2375E10", Offset = "0x2374A10", VA = "0x182375E10", Slot = "12")]
		public IMilestoneServiceConfig GenAllMilConfig(string actId, List<TemplateActivityMileStoneItemModel> milestoneList, Action<List<RewardItemModel>> onProceed)
		{
			return null;
		}

		// Token: 0x060282B8 RID: 164536 RVA: 0x000D0D58 File Offset: 0x000CEF58
		[Token(Token = "0x60282B8")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "13")]
		public bool IsMilestoneUnlock(string actId)
		{
			return default(bool);
		}

		// Token: 0x060282B9 RID: 164537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60282B9")]
		[Address(RVA = "0x2375F40", Offset = "0x2374B40", VA = "0x182375F40", Slot = "14")]
		public string GetMilestoneLockedToastDesc(string actId)
		{
			return null;
		}

		// Token: 0x060282BA RID: 164538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282BA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActVecBreakV2MileStoneGroupPlugin()
		{
		}

		// Token: 0x040390C3 RID: 233667
		[Token(Token = "0x40390C3")]
		[FieldOffset(Offset = "0x10")]
		private bool m_hasLockedItem;
	}
}
