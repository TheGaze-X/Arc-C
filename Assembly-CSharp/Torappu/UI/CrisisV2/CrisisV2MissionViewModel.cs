using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005976 RID: 22902
	[Token(Token = "0x2005976")]
	public class CrisisV2MissionViewModel : IHotfixable
	{
		// Token: 0x06021656 RID: 136790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021656")]
		[Address(RVA = "0x1BC9B60", Offset = "0x1BC8760", VA = "0x181BC9B60")]
		public void LoadData(string mapId_)
		{
		}

		// Token: 0x06021657 RID: 136791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021657")]
		[Address(RVA = "0x1BC9D80", Offset = "0x1BC8980", VA = "0x181BC9D80")]
		public void RefreshData()
		{
		}

		// Token: 0x06021658 RID: 136792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021658")]
		[Address(RVA = "0x1BC9A20", Offset = "0x1BC8620", VA = "0x181BC9A20")]
		public List<CrisisV2MissionInfo> GetAllCompleteMissions()
		{
			return null;
		}

		// Token: 0x06021659 RID: 136793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021659")]
		[Address(RVA = "0x1BCA110", Offset = "0x1BC8D10", VA = "0x181BCA110")]
		private void _LoadBagMissionData(Dictionary<string, CrisisV2BagData> bag)
		{
		}

		// Token: 0x0602165A RID: 136794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602165A")]
		[Address(RVA = "0x1BCA460", Offset = "0x1BC9060", VA = "0x181BCA460")]
		private void _LoadChallengeMissionData(Dictionary<string, CrisisV2ChallengeNodeData> challenge)
		{
		}

		// Token: 0x0602165B RID: 136795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602165B")]
		[Address(RVA = "0x1BCA7E0", Offset = "0x1BC93E0", VA = "0x181BCA7E0")]
		private void _LoadTreasureMissionData(Dictionary<string, CrisisV2RewardNodeData> treasure)
		{
		}

		// Token: 0x0602165C RID: 136796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602165C")]
		[Address(RVA = "0x1BCAAB0", Offset = "0x1BC96B0", VA = "0x181BCAAB0")]
		private void _RefreshMissionItem(CrisisV2MissionItemModel missionModel, Dictionary<string, PlayerCrisisV2Season.NodeState> challengeInfo, Dictionary<string, PlayerCrisisV2Season.RewardInfo> treasureInfo, Dictionary<string, PlayerCrisisV2Season.BagState> runePackInfo)
		{
		}

		// Token: 0x0602165D RID: 136797 RVA: 0x000BA120 File Offset: 0x000B8320
		[Token(Token = "0x602165D")]
		[Address(RVA = "0x1BCA070", Offset = "0x1BC8C70", VA = "0x181BCA070")]
		private CrisisV2MissionItemModel.SortState _GetMissionSortState(PlayerCrisisV2Season.NodeState state)
		{
			return CrisisV2MissionItemModel.SortState.COMPLETE;
		}

		// Token: 0x0602165E RID: 136798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602165E")]
		[Address(RVA = "0x1BCAC60", Offset = "0x1BC9860", VA = "0x181BCAC60")]
		public CrisisV2MissionViewModel()
		{
		}

		// Token: 0x0402D8C7 RID: 186567
		[Token(Token = "0x402D8C7")]
		[FieldOffset(Offset = "0x10")]
		public List<CrisisV2MissionItemModel> sortedMissions;

		// Token: 0x0402D8C8 RID: 186568
		[Token(Token = "0x402D8C8")]
		[FieldOffset(Offset = "0x18")]
		public bool canClaimAll;

		// Token: 0x0402D8C9 RID: 186569
		[Token(Token = "0x402D8C9")]
		[FieldOffset(Offset = "0x20")]
		public string mapId;

		// Token: 0x0402D8CA RID: 186570
		[Token(Token = "0x402D8CA")]
		[FieldOffset(Offset = "0x28")]
		public int sequenceNum;

		// Token: 0x0402D8CB RID: 186571
		[Token(Token = "0x402D8CB")]
		[FieldOffset(Offset = "0x2C")]
		private CrisisV2StageType m_stageType;

		// Token: 0x0402D8CC RID: 186572
		[Token(Token = "0x402D8CC")]
		[FieldOffset(Offset = "0x30")]
		private string m_seasonId;

		// Token: 0x0402D8CD RID: 186573
		[Token(Token = "0x402D8CD")]
		[FieldOffset(Offset = "0x38")]
		private long m_rewardEndTime;

		// Token: 0x0402D8CE RID: 186574
		[Token(Token = "0x402D8CE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402D8CF RID: 186575
		[Token(Token = "0x402D8CF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0402D8D0 RID: 186576
		[Token(Token = "0x402D8D0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetAllCompleteMissions;

		// Token: 0x0402D8D1 RID: 186577
		[Token(Token = "0x402D8D1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadBagMissionData;

		// Token: 0x0402D8D2 RID: 186578
		[Token(Token = "0x402D8D2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadChallengeMissionData;

		// Token: 0x0402D8D3 RID: 186579
		[Token(Token = "0x402D8D3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadTreasureMissionData;

		// Token: 0x0402D8D4 RID: 186580
		[Token(Token = "0x402D8D4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RefreshMissionItem;

		// Token: 0x0402D8D5 RID: 186581
		[Token(Token = "0x402D8D5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetMissionSortState;

		// Token: 0x0402D8D6 RID: 186582
		[Token(Token = "0x402D8D6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
