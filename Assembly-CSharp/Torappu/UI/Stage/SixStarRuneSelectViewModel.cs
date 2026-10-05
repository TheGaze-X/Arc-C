using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006840 RID: 26688
	[Token(Token = "0x2006840")]
	public class SixStarRuneSelectViewModel : IHotfixable
	{
		// Token: 0x0602636D RID: 156525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602636D")]
		[Address(RVA = "0x214B910", Offset = "0x214A510", VA = "0x18214B910")]
		public void LoadData(string stageId, string groupId)
		{
		}

		// Token: 0x0602636E RID: 156526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602636E")]
		[Address(RVA = "0x214C290", Offset = "0x214AE90", VA = "0x18214C290")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x0602636F RID: 156527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602636F")]
		[Address(RVA = "0x214C590", Offset = "0x214B190", VA = "0x18214C590")]
		public void SetGroupLocked(int minLevel)
		{
		}

		// Token: 0x06026370 RID: 156528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026370")]
		[Address(RVA = "0x214C690", Offset = "0x214B290", VA = "0x18214C690")]
		public void SetGroupUnlock(int minLevel)
		{
		}

		// Token: 0x06026371 RID: 156529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026371")]
		[Address(RVA = "0x214B810", Offset = "0x214A410", VA = "0x18214B810")]
		public SixStarRuneSelectGroupViewModel GetGroupModel(int level)
		{
			return null;
		}

		// Token: 0x06026372 RID: 156530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026372")]
		[Address(RVA = "0x214CAF0", Offset = "0x214B6F0", VA = "0x18214CAF0")]
		private void _UpdateCompleteStatus(PlayerDungeon playerData)
		{
		}

		// Token: 0x06026373 RID: 156531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026373")]
		[Address(RVA = "0x214CC90", Offset = "0x214B890", VA = "0x18214CC90")]
		private void _UpdateCurrPoint()
		{
		}

		// Token: 0x06026374 RID: 156532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026374")]
		[Address(RVA = "0x214C780", Offset = "0x214B380", VA = "0x18214C780")]
		private static SixStarRuneSelectGroupViewModel _LoadRuneData(int level, List<string> runeIdList, Dictionary<string, SixStarRuneData> runeDataMap)
		{
			return null;
		}

		// Token: 0x06026375 RID: 156533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026375")]
		[Address(RVA = "0x214CD70", Offset = "0x214B970", VA = "0x18214CD70")]
		public SixStarRuneSelectViewModel()
		{
		}

		// Token: 0x04035DCC RID: 220620
		[Token(Token = "0x4035DCC")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x04035DCD RID: 220621
		[Token(Token = "0x4035DCD")]
		[FieldOffset(Offset = "0x18")]
		public string milestoneGroupId;

		// Token: 0x04035DCE RID: 220622
		[Token(Token = "0x4035DCE")]
		[FieldOffset(Offset = "0x20")]
		public bool showTrackPoint;

		// Token: 0x04035DCF RID: 220623
		[Token(Token = "0x4035DCF")]
		[FieldOffset(Offset = "0x24")]
		public int totalGotPoint;

		// Token: 0x04035DD0 RID: 220624
		[Token(Token = "0x4035DD0")]
		[FieldOffset(Offset = "0x28")]
		public int maxPoint;

		// Token: 0x04035DD1 RID: 220625
		[Token(Token = "0x4035DD1")]
		[FieldOffset(Offset = "0x2C")]
		public int currPoint;

		// Token: 0x04035DD2 RID: 220626
		[Token(Token = "0x4035DD2")]
		[FieldOffset(Offset = "0x30")]
		public string nextRewardTip;

		// Token: 0x04035DD3 RID: 220627
		[Token(Token = "0x4035DD3")]
		[FieldOffset(Offset = "0x38")]
		public bool showNextTip;

		// Token: 0x04035DD4 RID: 220628
		[Token(Token = "0x4035DD4")]
		[FieldOffset(Offset = "0x40")]
		public UIItemViewModel nextRewardItem;

		// Token: 0x04035DD5 RID: 220629
		[Token(Token = "0x4035DD5")]
		[FieldOffset(Offset = "0x48")]
		public List<SixStarRuneSelectGroupViewModel> runeGroupModel;

		// Token: 0x04035DD6 RID: 220630
		[Token(Token = "0x4035DD6")]
		[FieldOffset(Offset = "0x50")]
		private List<SixStarRuneSelectViewModel.MilestoneInfo> m_milestoneRewardPointList;

		// Token: 0x04035DD7 RID: 220631
		[Token(Token = "0x4035DD7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04035DD8 RID: 220632
		[Token(Token = "0x4035DD8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x04035DD9 RID: 220633
		[Token(Token = "0x4035DD9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetGroupLocked;

		// Token: 0x04035DDA RID: 220634
		[Token(Token = "0x4035DDA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetGroupUnlock;

		// Token: 0x04035DDB RID: 220635
		[Token(Token = "0x4035DDB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetGroupModel;

		// Token: 0x04035DDC RID: 220636
		[Token(Token = "0x4035DDC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateCompleteStatus;

		// Token: 0x04035DDD RID: 220637
		[Token(Token = "0x4035DDD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateCurrPoint;

		// Token: 0x04035DDE RID: 220638
		[Token(Token = "0x4035DDE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__LoadRuneData;

		// Token: 0x04035DDF RID: 220639
		[Token(Token = "0x4035DDF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006841 RID: 26689
		[Token(Token = "0x2006841")]
		private class MilestoneInfo : IComparable, IHotfixable
		{
			// Token: 0x06026376 RID: 156534 RVA: 0x000CA638 File Offset: 0x000C8838
			[Token(Token = "0x6026376")]
			[Address(RVA = "0x21480C0", Offset = "0x2146CC0", VA = "0x1821480C0", Slot = "4")]
			public int CompareTo(object obj)
			{
				return 0;
			}

			// Token: 0x06026377 RID: 156535 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026377")]
			[Address(RVA = "0x2148190", Offset = "0x2146D90", VA = "0x182148190")]
			public MilestoneInfo()
			{
			}

			// Token: 0x04035DE0 RID: 220640
			[Token(Token = "0x4035DE0")]
			[FieldOffset(Offset = "0x10")]
			public int point;

			// Token: 0x04035DE1 RID: 220641
			[Token(Token = "0x4035DE1")]
			[FieldOffset(Offset = "0x18")]
			public ItemBundle reward;

			// Token: 0x04035DE2 RID: 220642
			[Token(Token = "0x4035DE2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CompareTo;

			// Token: 0x04035DE3 RID: 220643
			[Token(Token = "0x4035DE3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
