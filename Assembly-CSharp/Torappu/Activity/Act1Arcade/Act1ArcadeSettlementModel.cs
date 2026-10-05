using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using Torappu.UI.Squad;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x0200795B RID: 31067
	[Token(Token = "0x200795B")]
	public class Act1ArcadeSettlementModel : IHotfixable
	{
		// Token: 0x17006631 RID: 26161
		// (get) Token: 0x0602B966 RID: 178534 RVA: 0x000DC848 File Offset: 0x000DAA48
		[Token(Token = "0x17006631")]
		public bool hasNewUnlockBadge
		{
			[Token(Token = "0x602B966")]
			[Address(RVA = "0x2782930", Offset = "0x2781530", VA = "0x182782930")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602B967 RID: 178535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B967")]
		[Address(RVA = "0x27813B0", Offset = "0x277FFB0", VA = "0x1827813B0")]
		public void InitModel()
		{
		}

		// Token: 0x0602B968 RID: 178536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B968")]
		[Address(RVA = "0x2781C30", Offset = "0x2780830", VA = "0x182781C30")]
		private void _InitBadgeData(string activityId, ActArcadeData arcadeData, PlayerActivity.PlayerArcadeActivity arcadePlayerData, string curZoneId, ArcadeFinishBattleResponse arcadeResponse)
		{
		}

		// Token: 0x0602B969 RID: 178537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B969")]
		[Address(RVA = "0x27825B0", Offset = "0x27811B0", VA = "0x1827825B0")]
		private void _InitScoreAndRank(string activityId, string stageId, ActArcadeData arcadeData, ArcadeFinishBattleResponse arcadeResponse)
		{
		}

		// Token: 0x0602B96A RID: 178538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B96A")]
		[Address(RVA = "0x2782340", Offset = "0x2780F40", VA = "0x182782340")]
		private void _InitMilestone(string activityId, ActArcadeData arcadeData, ArcadeFinishBattleResponse arcadeResponse)
		{
		}

		// Token: 0x0602B96B RID: 178539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B96B")]
		[Address(RVA = "0x27811F0", Offset = "0x277FDF0", VA = "0x1827811F0")]
		public TemplateActivityMileStoneItemModel GetMilestoneItemModel(int milestoneTokenNum, out int prefLevelTokenNum, out bool isReachMax, int startFindIndex = 0)
		{
			return null;
		}

		// Token: 0x0602B96C RID: 178540 RVA: 0x000DC860 File Offset: 0x000DAA60
		[Token(Token = "0x602B96C")]
		[Address(RVA = "0x2781B90", Offset = "0x2780790", VA = "0x182781B90")]
		private int _GetPrefLevelTokenNum(int curIndex)
		{
			return 0;
		}

		// Token: 0x0602B96D RID: 178541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B96D")]
		[Address(RVA = "0x2782790", Offset = "0x2781390", VA = "0x182782790")]
		public Act1ArcadeSettlementModel()
		{
		}

		// Token: 0x0403F0B7 RID: 258231
		[Token(Token = "0x403F0B7")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0403F0B8 RID: 258232
		[Token(Token = "0x403F0B8")]
		[FieldOffset(Offset = "0x18")]
		public List<Act1ArcadeSettlementModel.UnlockBadgeModel> newUnlockBadges;

		// Token: 0x0403F0B9 RID: 258233
		[Token(Token = "0x403F0B9")]
		[FieldOffset(Offset = "0x20")]
		public ListDict<string, ActArcadeData.ArcadeBadgeData> newStepBadges;

		// Token: 0x0403F0BA RID: 258234
		[Token(Token = "0x403F0BA")]
		[FieldOffset(Offset = "0x28")]
		public ActArcadeData.ArcadeBadgeData curBattleBadge;

		// Token: 0x0403F0BB RID: 258235
		[Token(Token = "0x403F0BB")]
		[FieldOffset(Offset = "0x30")]
		public int badgeTier;

		// Token: 0x0403F0BC RID: 258236
		[Token(Token = "0x403F0BC")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, ActArcadeData.ArcadeZoneAdditionalData> hasNewStageZoneDict;

		// Token: 0x0403F0BD RID: 258237
		[Token(Token = "0x403F0BD")]
		[FieldOffset(Offset = "0x40")]
		public int newScore;

		// Token: 0x0403F0BE RID: 258238
		[Token(Token = "0x403F0BE")]
		[FieldOffset(Offset = "0x44")]
		public bool hasNewRecord;

		// Token: 0x0403F0BF RID: 258239
		[Token(Token = "0x403F0BF")]
		[FieldOffset(Offset = "0x45")]
		public bool hasNewRank;

		// Token: 0x0403F0C0 RID: 258240
		[Token(Token = "0x403F0C0")]
		[FieldOffset(Offset = "0x48")]
		public ActArcadeData.Rank rank;

		// Token: 0x0403F0C1 RID: 258241
		[Token(Token = "0x403F0C1")]
		[FieldOffset(Offset = "0x4C")]
		public int milestoneBefore;

		// Token: 0x0403F0C2 RID: 258242
		[Token(Token = "0x403F0C2")]
		[FieldOffset(Offset = "0x50")]
		public int milestoneAdd;

		// Token: 0x0403F0C3 RID: 258243
		[Token(Token = "0x403F0C3")]
		[FieldOffset(Offset = "0x54")]
		public bool isMilestoneMax;

		// Token: 0x0403F0C4 RID: 258244
		[Token(Token = "0x403F0C4")]
		[FieldOffset(Offset = "0x58")]
		public List<TemplateActivityMileStoneItemModel> m_milestoneList;

		// Token: 0x0403F0C5 RID: 258245
		[Token(Token = "0x403F0C5")]
		[FieldOffset(Offset = "0x60")]
		public SquadItemStruct[] localSquads;

		// Token: 0x0403F0C6 RID: 258246
		[Token(Token = "0x403F0C6")]
		[FieldOffset(Offset = "0x68")]
		public SquadItemStruct assistSquadData;

		// Token: 0x0403F0C7 RID: 258247
		[Token(Token = "0x403F0C7")]
		[FieldOffset(Offset = "0x78")]
		public CharUISkinStruct randomSkin;

		// Token: 0x0403F0C8 RID: 258248
		[Token(Token = "0x403F0C8")]
		[FieldOffset(Offset = "0x90")]
		public StageData stageData;

		// Token: 0x0403F0C9 RID: 258249
		[Token(Token = "0x403F0C9")]
		[FieldOffset(Offset = "0x98")]
		public string playerName;

		// Token: 0x0403F0CA RID: 258250
		[Token(Token = "0x403F0CA")]
		[FieldOffset(Offset = "0xA0")]
		public long finishTs;

		// Token: 0x0403F0CB RID: 258251
		[Token(Token = "0x403F0CB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hasNewUnlockBadge;

		// Token: 0x0403F0CC RID: 258252
		[Token(Token = "0x403F0CC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitModel;

		// Token: 0x0403F0CD RID: 258253
		[Token(Token = "0x403F0CD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitBadgeData;

		// Token: 0x0403F0CE RID: 258254
		[Token(Token = "0x403F0CE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitScoreAndRank;

		// Token: 0x0403F0CF RID: 258255
		[Token(Token = "0x403F0CF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitMilestone;

		// Token: 0x0403F0D0 RID: 258256
		[Token(Token = "0x403F0D0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetMilestoneItemModel;

		// Token: 0x0403F0D1 RID: 258257
		[Token(Token = "0x403F0D1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetPrefLevelTokenNum;

		// Token: 0x0403F0D2 RID: 258258
		[Token(Token = "0x403F0D2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200795C RID: 31068
		[Token(Token = "0x200795C")]
		public enum SettlementViewStatus
		{
			// Token: 0x0403F0D4 RID: 258260
			[Token(Token = "0x403F0D4")]
			None,
			// Token: 0x0403F0D5 RID: 258261
			[Token(Token = "0x403F0D5")]
			Entry,
			// Token: 0x0403F0D6 RID: 258262
			[Token(Token = "0x403F0D6")]
			Badge,
			// Token: 0x0403F0D7 RID: 258263
			[Token(Token = "0x403F0D7")]
			Result,
			// Token: 0x0403F0D8 RID: 258264
			[Token(Token = "0x403F0D8")]
			End
		}

		// Token: 0x0200795D RID: 31069
		[Token(Token = "0x200795D")]
		public struct UnlockBadgeModel
		{
			// Token: 0x0403F0D9 RID: 258265
			[Token(Token = "0x403F0D9")]
			[FieldOffset(Offset = "0x0")]
			public ActArcadeData.BadgeType badgeType;

			// Token: 0x0403F0DA RID: 258266
			[Token(Token = "0x403F0DA")]
			[FieldOffset(Offset = "0x8")]
			public ActArcadeData.ArcadeBadgeTierData badgeTierData;
		}
	}
}
