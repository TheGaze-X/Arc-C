using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x0200456D RID: 17773
	[Token(Token = "0x200456D")]
	public class RoguelikeTopicBattlePassStateBean : IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x0601B130 RID: 110896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B130")]
		[Address(RVA = "0x1433000", Offset = "0x1431C00", VA = "0x181433000")]
		public void LoadData(string topicId, RoguelikeTopicBattlePassStyle style)
		{
		}

		// Token: 0x0601B131 RID: 110897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B131")]
		[Address(RVA = "0x14339B0", Offset = "0x14325B0", VA = "0x1814339B0")]
		private void _FocusOnNextGrandPrize()
		{
		}

		// Token: 0x0601B132 RID: 110898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B132")]
		[Address(RVA = "0x1433B80", Offset = "0x1432780", VA = "0x181433B80")]
		private void _LoadGrandPrizeData(RoguelikeTopicDetail topicData, Dictionary<string, RoguelikeTopicBP> rewardIdDataMap, int bpLimitPoint, PlayerRoguelikeV2.OuterData.BattlePass playerBattlePass, int currBpPoint, RoguelikeTopicBattlePassStyle style, bool bpPurchaseAvailable)
		{
		}

		// Token: 0x0601B133 RID: 110899 RVA: 0x000A4358 File Offset: 0x000A2558
		[Token(Token = "0x601B133")]
		[Address(RVA = "0x1432EA0", Offset = "0x1431AA0", VA = "0x181432EA0")]
		public static bool CheckIfRewardGot(PlayerRoguelikeV2.OuterData.BattlePass playerBattlePass, string id)
		{
			return default(bool);
		}

		// Token: 0x0601B134 RID: 110900 RVA: 0x000A4370 File Offset: 0x000A2570
		[Token(Token = "0x601B134")]
		[Address(RVA = "0x1432F80", Offset = "0x1431B80", VA = "0x181432F80")]
		public static bool CheckIfRewardValid(RoguelikeTopicBP targetBpData, int currBpPoint)
		{
			return default(bool);
		}

		// Token: 0x0601B135 RID: 110901 RVA: 0x000A4388 File Offset: 0x000A2588
		[Token(Token = "0x601B135")]
		[Address(RVA = "0x1432E20", Offset = "0x1431A20", VA = "0x181432E20")]
		public static bool CheckBpDataWithinLimit(RoguelikeTopicBP bpData, int bpLimitPoint)
		{
			return default(bool);
		}

		// Token: 0x0601B136 RID: 110902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B136")]
		[Address(RVA = "0x1434040", Offset = "0x1432C40", VA = "0x181434040")]
		public RoguelikeTopicBattlePassStateBean()
		{
		}

		// Token: 0x04022CD5 RID: 142549
		[Token(Token = "0x4022CD5")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeTopicBattlePassProperty battlePassProperty;

		// Token: 0x04022CD6 RID: 142550
		[Token(Token = "0x4022CD6")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeTopicBPGreatPrizeProperty greatRewardProperty;

		// Token: 0x04022CD7 RID: 142551
		[Token(Token = "0x4022CD7")]
		[FieldOffset(Offset = "0x20")]
		public string topicId;

		// Token: 0x04022CD8 RID: 142552
		[Token(Token = "0x4022CD8")]
		[FieldOffset(Offset = "0x28")]
		public bool bpPurchaseSystemUnlocked;

		// Token: 0x04022CD9 RID: 142553
		[Token(Token = "0x4022CD9")]
		[FieldOffset(Offset = "0x30")]
		public string selectedPurchaseGrandPrizeId;

		// Token: 0x04022CDA RID: 142554
		[Token(Token = "0x4022CDA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04022CDB RID: 142555
		[Token(Token = "0x4022CDB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__FocusOnNextGrandPrize;

		// Token: 0x04022CDC RID: 142556
		[Token(Token = "0x4022CDC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadGrandPrizeData;

		// Token: 0x04022CDD RID: 142557
		[Token(Token = "0x4022CDD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckIfRewardGot;

		// Token: 0x04022CDE RID: 142558
		[Token(Token = "0x4022CDE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckIfRewardValid;

		// Token: 0x04022CDF RID: 142559
		[Token(Token = "0x4022CDF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckBpDataWithinLimit;

		// Token: 0x04022CE0 RID: 142560
		[Token(Token = "0x4022CE0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
