using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F41 RID: 28481
	[Token(Token = "0x2006F41")]
	public class ActMultiV3MileStoneGroupViewModelPlugin : ITemplateActivityMilestonePlugin
	{
		// Token: 0x06028726 RID: 165670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028726")]
		[Address(RVA = "0x23CA540", Offset = "0x23C9140", VA = "0x1823CA540", Slot = "4")]
		public void InitMilestoneList(string actId, List<TemplateActivityMileStoneItemModel> milestoneList)
		{
		}

		// Token: 0x06028727 RID: 165671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028727")]
		[Address(RVA = "0x23CA830", Offset = "0x23C9430", VA = "0x1823CA830", Slot = "5")]
		public void UpdateMilestoneList(string actId, List<TemplateActivityMileStoneItemModel> milestoneList)
		{
		}

		// Token: 0x06028728 RID: 165672 RVA: 0x000D1CE8 File Offset: 0x000CFEE8
		[Token(Token = "0x6028728")]
		[Address(RVA = "0x2301B80", Offset = "0x2300780", VA = "0x182301B80", Slot = "6")]
		public int SortMilestoneItem(TemplateActivityMileStoneItemModel m1, TemplateActivityMileStoneItemModel m2)
		{
			return 0;
		}

		// Token: 0x06028729 RID: 165673 RVA: 0x000D1D00 File Offset: 0x000CFF00
		[Token(Token = "0x6028729")]
		[Address(RVA = "0x2376240", Offset = "0x2374E40", VA = "0x182376240", Slot = "7")]
		public bool IsItemShow(TemplateActivityMileStoneItemModel itemModel)
		{
			return default(bool);
		}

		// Token: 0x0602872A RID: 165674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602872A")]
		[Address(RVA = "0x23CA4D0", Offset = "0x23C90D0", VA = "0x1823CA4D0", Slot = "8")]
		public string GetMilestoneId(string actId)
		{
			return null;
		}

		// Token: 0x0602872B RID: 165675 RVA: 0x000D1D18 File Offset: 0x000CFF18
		[Token(Token = "0x602872B")]
		[Address(RVA = "0x23CA800", Offset = "0x23C9400", VA = "0x1823CA800", Slot = "9")]
		public int UpdateMilestoneCount(string actId)
		{
			return 0;
		}

		// Token: 0x0602872C RID: 165676 RVA: 0x000D1D30 File Offset: 0x000CFF30
		[Token(Token = "0x602872C")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "10")]
		public bool NeedFocusToIdx()
		{
			return default(bool);
		}

		// Token: 0x0602872D RID: 165677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602872D")]
		[Address(RVA = "0x23CA440", Offset = "0x23C9040", VA = "0x1823CA440", Slot = "11")]
		public IMilestoneServiceConfig GenOneMilConfig(string actId, string milestoneId, Action<List<RewardItemModel>> onProceed)
		{
			return null;
		}

		// Token: 0x0602872E RID: 165678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602872E")]
		[Address(RVA = "0x23CA3D0", Offset = "0x23C8FD0", VA = "0x1823CA3D0", Slot = "12")]
		public IMilestoneServiceConfig GenAllMilConfig(string actId, List<TemplateActivityMileStoneItemModel> milestoneList, Action<List<RewardItemModel>> onProceed)
		{
			return null;
		}

		// Token: 0x0602872F RID: 165679 RVA: 0x000D1D48 File Offset: 0x000CFF48
		[Token(Token = "0x602872F")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "13")]
		public bool IsMilestoneUnlock(string actId)
		{
			return default(bool);
		}

		// Token: 0x06028730 RID: 165680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028730")]
		[Address(RVA = "0x23CA500", Offset = "0x23C9100", VA = "0x1823CA500", Slot = "14")]
		public string GetMilestoneLockedToastDesc(string actId)
		{
			return null;
		}

		// Token: 0x06028731 RID: 165681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028731")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3MileStoneGroupViewModelPlugin()
		{
		}

		// Token: 0x0403988C RID: 235660
		[Token(Token = "0x403988C")]
		[FieldOffset(Offset = "0x10")]
		private bool m_hasAddedLockedItem;
	}
}
