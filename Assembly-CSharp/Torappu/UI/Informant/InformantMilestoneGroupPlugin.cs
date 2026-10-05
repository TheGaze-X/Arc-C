using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Activity;
using Torappu.UI.ActivityStage;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A19 RID: 18969
	[Token(Token = "0x2004A19")]
	public class InformantMilestoneGroupPlugin : ITemplateActivityMilestonePlugin, IHotfixable
	{
		// Token: 0x0601C89B RID: 116891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C89B")]
		[Address(RVA = "0x15FE340", Offset = "0x15FCF40", VA = "0x1815FE340", Slot = "4")]
		public void InitMilestoneList(string actId, List<TemplateActivityMileStoneItemModel> milestoneList)
		{
		}

		// Token: 0x0601C89C RID: 116892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C89C")]
		[Address(RVA = "0x15FE9F0", Offset = "0x15FD5F0", VA = "0x1815FE9F0", Slot = "5")]
		public void UpdateMilestoneList(string actId, List<TemplateActivityMileStoneItemModel> milestoneList)
		{
		}

		// Token: 0x0601C89D RID: 116893 RVA: 0x000A8990 File Offset: 0x000A6B90
		[Token(Token = "0x601C89D")]
		[Address(RVA = "0x15FE800", Offset = "0x15FD400", VA = "0x1815FE800", Slot = "6")]
		public int SortMilestoneItem(TemplateActivityMileStoneItemModel m1, TemplateActivityMileStoneItemModel m2)
		{
			return 0;
		}

		// Token: 0x0601C89E RID: 116894 RVA: 0x000A89A8 File Offset: 0x000A6BA8
		[Token(Token = "0x601C89E")]
		[Address(RVA = "0x15FE6C0", Offset = "0x15FD2C0", VA = "0x1815FE6C0", Slot = "7")]
		public bool IsItemShow(TemplateActivityMileStoneItemModel itemModel)
		{
			return default(bool);
		}

		// Token: 0x0601C89F RID: 116895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C89F")]
		[Address(RVA = "0x15FE1D0", Offset = "0x15FCDD0", VA = "0x1815FE1D0", Slot = "8")]
		public string GetMilestoneId(string actId)
		{
			return null;
		}

		// Token: 0x0601C8A0 RID: 116896 RVA: 0x000A89C0 File Offset: 0x000A6BC0
		[Token(Token = "0x601C8A0")]
		[Address(RVA = "0x15FE8B0", Offset = "0x15FD4B0", VA = "0x1815FE8B0", Slot = "9")]
		public int UpdateMilestoneCount(string actId)
		{
			return 0;
		}

		// Token: 0x0601C8A1 RID: 116897 RVA: 0x000A89D8 File Offset: 0x000A6BD8
		[Token(Token = "0x601C8A1")]
		[Address(RVA = "0x15FE7A0", Offset = "0x15FD3A0", VA = "0x1815FE7A0", Slot = "10")]
		public bool NeedFocusToIdx()
		{
			return default(bool);
		}

		// Token: 0x0601C8A2 RID: 116898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C8A2")]
		[Address(RVA = "0x15FE100", Offset = "0x15FCD00", VA = "0x1815FE100", Slot = "11")]
		public IMilestoneServiceConfig GenOneMilConfig(string actId, string milestoneId, Action<List<RewardItemModel>> onProceed)
		{
			return null;
		}

		// Token: 0x0601C8A3 RID: 116899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C8A3")]
		[Address(RVA = "0x15FE040", Offset = "0x15FCC40", VA = "0x1815FE040", Slot = "12")]
		public IMilestoneServiceConfig GenAllMilConfig(string actId, List<TemplateActivityMileStoneItemModel> milestoneList, Action<List<RewardItemModel>> onProceed)
		{
			return null;
		}

		// Token: 0x0601C8A4 RID: 116900 RVA: 0x000A89F0 File Offset: 0x000A6BF0
		[Token(Token = "0x601C8A4")]
		[Address(RVA = "0x15FE730", Offset = "0x15FD330", VA = "0x1815FE730", Slot = "13")]
		public bool IsMilestoneUnlock(string actId)
		{
			return default(bool);
		}

		// Token: 0x0601C8A5 RID: 116901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C8A5")]
		[Address(RVA = "0x15FE2B0", Offset = "0x15FCEB0", VA = "0x1815FE2B0", Slot = "14")]
		public string GetMilestoneLockedToastDesc(string actId)
		{
			return null;
		}

		// Token: 0x0601C8A6 RID: 116902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8A6")]
		[Address(RVA = "0x15FEC40", Offset = "0x15FD840", VA = "0x1815FEC40")]
		public InformantMilestoneGroupPlugin()
		{
		}

		// Token: 0x040256CA RID: 153290
		[Token(Token = "0x40256CA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitMilestoneList;

		// Token: 0x040256CB RID: 153291
		[Token(Token = "0x40256CB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateMilestoneList;

		// Token: 0x040256CC RID: 153292
		[Token(Token = "0x40256CC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SortMilestoneItem;

		// Token: 0x040256CD RID: 153293
		[Token(Token = "0x40256CD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsItemShow;

		// Token: 0x040256CE RID: 153294
		[Token(Token = "0x40256CE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetMilestoneId;

		// Token: 0x040256CF RID: 153295
		[Token(Token = "0x40256CF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateMilestoneCount;

		// Token: 0x040256D0 RID: 153296
		[Token(Token = "0x40256D0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_NeedFocusToIdx;

		// Token: 0x040256D1 RID: 153297
		[Token(Token = "0x40256D1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GenOneMilConfig;

		// Token: 0x040256D2 RID: 153298
		[Token(Token = "0x40256D2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GenAllMilConfig;

		// Token: 0x040256D3 RID: 153299
		[Token(Token = "0x40256D3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_IsMilestoneUnlock;

		// Token: 0x040256D4 RID: 153300
		[Token(Token = "0x40256D4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetMilestoneLockedToastDesc;

		// Token: 0x040256D5 RID: 153301
		[Token(Token = "0x40256D5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
