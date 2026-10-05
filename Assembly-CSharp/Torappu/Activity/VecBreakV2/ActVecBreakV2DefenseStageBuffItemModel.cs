using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E1D RID: 28189
	[Token(Token = "0x2006E1D")]
	public class ActVecBreakV2DefenseStageBuffItemModel : IHotfixable, IComparable<ActVecBreakV2DefenseStageBuffItemModel>
	{
		// Token: 0x0602820A RID: 164362 RVA: 0x000D0B90 File Offset: 0x000CED90
		[Token(Token = "0x602820A")]
		[Address(RVA = "0x2364900", Offset = "0x2363500", VA = "0x182364900", Slot = "4")]
		public int CompareTo(ActVecBreakV2DefenseStageBuffItemModel other)
		{
			return 0;
		}

		// Token: 0x0602820B RID: 164363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602820B")]
		[Address(RVA = "0x23649F0", Offset = "0x23635F0", VA = "0x1823649F0")]
		public void LoadBasicData(string stageId, ActVecBreakV2DefenseBasicData basicData, string firstStageId, long tsNow)
		{
		}

		// Token: 0x0602820C RID: 164364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602820C")]
		[Address(RVA = "0x2364AE0", Offset = "0x23636E0", VA = "0x182364AE0")]
		public void LoadBuffData(ActVecBreakV2DefenseDetailData detailData, ActVecBreakV2BattleBuffData buffData, ActVecBreakV2StageRewardData rewardData)
		{
		}

		// Token: 0x0602820D RID: 164365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602820D")]
		[Address(RVA = "0x2364C00", Offset = "0x2363800", VA = "0x182364C00")]
		public void RefreshData(PlayerActivity.PlayerVecBreakV2.DefendStageInfo playerDefenseStageInfo)
		{
		}

		// Token: 0x0602820E RID: 164366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602820E")]
		[Address(RVA = "0x2364CC0", Offset = "0x23638C0", VA = "0x182364CC0")]
		public ActVecBreakV2DefenseStageBuffItemModel()
		{
		}

		// Token: 0x04038F85 RID: 233349
		[Token(Token = "0x4038F85")]
		[FieldOffset(Offset = "0x10")]
		public bool isFirstStage;

		// Token: 0x04038F86 RID: 233350
		[Token(Token = "0x4038F86")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x04038F87 RID: 233351
		[Token(Token = "0x4038F87")]
		[FieldOffset(Offset = "0x20")]
		public string stageGroupId;

		// Token: 0x04038F88 RID: 233352
		[Token(Token = "0x4038F88")]
		[FieldOffset(Offset = "0x28")]
		public string buffId;

		// Token: 0x04038F89 RID: 233353
		[Token(Token = "0x4038F89")]
		[FieldOffset(Offset = "0x30")]
		public string buffIconId;

		// Token: 0x04038F8A RID: 233354
		[Token(Token = "0x4038F8A")]
		[FieldOffset(Offset = "0x38")]
		public int sortId;

		// Token: 0x04038F8B RID: 233355
		[Token(Token = "0x4038F8B")]
		[FieldOffset(Offset = "0x3C")]
		public bool isStageStarted;

		// Token: 0x04038F8C RID: 233356
		[Token(Token = "0x4038F8C")]
		[FieldOffset(Offset = "0x40")]
		public long timeLimitRewardStartTs;

		// Token: 0x04038F8D RID: 233357
		[Token(Token = "0x4038F8D")]
		[FieldOffset(Offset = "0x48")]
		public long timeLimitRewardEndTs;

		// Token: 0x04038F8E RID: 233358
		[Token(Token = "0x4038F8E")]
		[FieldOffset(Offset = "0x50")]
		public int verticalIndex;

		// Token: 0x04038F8F RID: 233359
		[Token(Token = "0x4038F8F")]
		[FieldOffset(Offset = "0x54")]
		public int horizonIndex;

		// Token: 0x04038F90 RID: 233360
		[Token(Token = "0x4038F90")]
		[FieldOffset(Offset = "0x58")]
		public long stageStartTs;

		// Token: 0x04038F91 RID: 233361
		[Token(Token = "0x4038F91")]
		[FieldOffset(Offset = "0x60")]
		public string buffName;

		// Token: 0x04038F92 RID: 233362
		[Token(Token = "0x4038F92")]
		[FieldOffset(Offset = "0x68")]
		public string buffDesc;

		// Token: 0x04038F93 RID: 233363
		[Token(Token = "0x4038F93")]
		[FieldOffset(Offset = "0x70")]
		public bool isBuffUnlocked;

		// Token: 0x04038F94 RID: 233364
		[Token(Token = "0x4038F94")]
		[FieldOffset(Offset = "0x71")]
		public bool isTimeLimitRewardClaimed;

		// Token: 0x04038F95 RID: 233365
		[Token(Token = "0x4038F95")]
		[FieldOffset(Offset = "0x72")]
		public bool isNormalRewardClaimed;

		// Token: 0x04038F96 RID: 233366
		[Token(Token = "0x4038F96")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04038F97 RID: 233367
		[Token(Token = "0x4038F97")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadBasicData;

		// Token: 0x04038F98 RID: 233368
		[Token(Token = "0x4038F98")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadBuffData;

		// Token: 0x04038F99 RID: 233369
		[Token(Token = "0x4038F99")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04038F9A RID: 233370
		[Token(Token = "0x4038F9A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
