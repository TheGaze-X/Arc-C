using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Activity;
using Torappu.UI.ActivityStage;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FB2 RID: 20402
	[Token(Token = "0x2004FB2")]
	public class EnemyDuelMileStoneGroupPlugin : ITemplateActivityMilestonePlugin, IHotfixable
	{
		// Token: 0x0601E4F9 RID: 124153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4F9")]
		[Address(RVA = "0x1805E20", Offset = "0x1804A20", VA = "0x181805E20", Slot = "4")]
		public void InitMilestoneList(string actId, List<TemplateActivityMileStoneItemModel> milestoneList)
		{
		}

		// Token: 0x0601E4FA RID: 124154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4FA")]
		[Address(RVA = "0x1806440", Offset = "0x1805040", VA = "0x181806440", Slot = "5")]
		public void UpdateMilestoneList(string actId, List<TemplateActivityMileStoneItemModel> milestoneList)
		{
		}

		// Token: 0x0601E4FB RID: 124155 RVA: 0x000AE1F8 File Offset: 0x000AC3F8
		[Token(Token = "0x601E4FB")]
		[Address(RVA = "0x18062D0", Offset = "0x1804ED0", VA = "0x1818062D0", Slot = "6")]
		public int SortMilestoneItem(TemplateActivityMileStoneItemModel m1, TemplateActivityMileStoneItemModel m2)
		{
			return 0;
		}

		// Token: 0x0601E4FC RID: 124156 RVA: 0x000AE210 File Offset: 0x000AC410
		[Token(Token = "0x601E4FC")]
		[Address(RVA = "0x1806170", Offset = "0x1804D70", VA = "0x181806170", Slot = "7")]
		public bool IsItemShow(TemplateActivityMileStoneItemModel itemModel)
		{
			return default(bool);
		}

		// Token: 0x0601E4FD RID: 124157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E4FD")]
		[Address(RVA = "0x1805CD0", Offset = "0x18048D0", VA = "0x181805CD0", Slot = "8")]
		public string GetMilestoneId(string actId)
		{
			return null;
		}

		// Token: 0x0601E4FE RID: 124158 RVA: 0x000AE228 File Offset: 0x000AC428
		[Token(Token = "0x601E4FE")]
		[Address(RVA = "0x1806380", Offset = "0x1804F80", VA = "0x181806380", Slot = "9")]
		public int UpdateMilestoneCount(string actId)
		{
			return 0;
		}

		// Token: 0x0601E4FF RID: 124159 RVA: 0x000AE240 File Offset: 0x000AC440
		[Token(Token = "0x601E4FF")]
		[Address(RVA = "0x1806270", Offset = "0x1804E70", VA = "0x181806270", Slot = "10")]
		public bool NeedFocusToIdx()
		{
			return default(bool);
		}

		// Token: 0x0601E500 RID: 124160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E500")]
		[Address(RVA = "0x1805C00", Offset = "0x1804800", VA = "0x181805C00", Slot = "11")]
		public IMilestoneServiceConfig GenOneMilConfig(string actId, string milestoneId, Action<List<RewardItemModel>> onProceed)
		{
			return null;
		}

		// Token: 0x0601E501 RID: 124161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E501")]
		[Address(RVA = "0x1805B40", Offset = "0x1804740", VA = "0x181805B40", Slot = "12")]
		public IMilestoneServiceConfig GenAllMilConfig(string actId, List<TemplateActivityMileStoneItemModel> milestoneList, Action<List<RewardItemModel>> onProceed)
		{
			return null;
		}

		// Token: 0x0601E502 RID: 124162 RVA: 0x000AE258 File Offset: 0x000AC458
		[Token(Token = "0x601E502")]
		[Address(RVA = "0x1806200", Offset = "0x1804E00", VA = "0x181806200", Slot = "13")]
		public bool IsMilestoneUnlock(string actId)
		{
			return default(bool);
		}

		// Token: 0x0601E503 RID: 124163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E503")]
		[Address(RVA = "0x1805D90", Offset = "0x1804990", VA = "0x181805D90", Slot = "14")]
		public string GetMilestoneLockedToastDesc(string actId)
		{
			return null;
		}

		// Token: 0x0601E504 RID: 124164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E504")]
		[Address(RVA = "0x1806620", Offset = "0x1805220", VA = "0x181806620")]
		public EnemyDuelMileStoneGroupPlugin()
		{
		}

		// Token: 0x0402878F RID: 165775
		[Token(Token = "0x402878F")]
		[FieldOffset(Offset = "0x10")]
		private bool m_hasAddedLockedItem;

		// Token: 0x04028790 RID: 165776
		[Token(Token = "0x4028790")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitMilestoneList;

		// Token: 0x04028791 RID: 165777
		[Token(Token = "0x4028791")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateMilestoneList;

		// Token: 0x04028792 RID: 165778
		[Token(Token = "0x4028792")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SortMilestoneItem;

		// Token: 0x04028793 RID: 165779
		[Token(Token = "0x4028793")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsItemShow;

		// Token: 0x04028794 RID: 165780
		[Token(Token = "0x4028794")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetMilestoneId;

		// Token: 0x04028795 RID: 165781
		[Token(Token = "0x4028795")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateMilestoneCount;

		// Token: 0x04028796 RID: 165782
		[Token(Token = "0x4028796")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_NeedFocusToIdx;

		// Token: 0x04028797 RID: 165783
		[Token(Token = "0x4028797")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GenOneMilConfig;

		// Token: 0x04028798 RID: 165784
		[Token(Token = "0x4028798")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GenAllMilConfig;

		// Token: 0x04028799 RID: 165785
		[Token(Token = "0x4028799")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_IsMilestoneUnlock;

		// Token: 0x0402879A RID: 165786
		[Token(Token = "0x402879A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetMilestoneLockedToastDesc;

		// Token: 0x0402879B RID: 165787
		[Token(Token = "0x402879B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
