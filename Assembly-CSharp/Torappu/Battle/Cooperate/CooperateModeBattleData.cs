using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Cooperate
{
	// Token: 0x020026D4 RID: 9940
	[Token(Token = "0x20026D4")]
	[Serializable]
	public class CooperateModeBattleData : IHotfixable
	{
		// Token: 0x06010307 RID: 66311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010307")]
		[Address(RVA = "0x7E5900", Offset = "0x7E4500", VA = "0x1807E5900")]
		public CooperateModeBattleData()
		{
		}

		// Token: 0x04012117 RID: 74007
		[Token(Token = "0x4012117")]
		[FieldOffset(Offset = "0x10")]
		public int costTransferred;

		// Token: 0x04012118 RID: 74008
		[Token(Token = "0x4012118")]
		[FieldOffset(Offset = "0x14")]
		public int getMaxMsgCntInOneUpdate;

		// Token: 0x04012119 RID: 74009
		[Token(Token = "0x4012119")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<EndTileType, CooperateEndTileInfo> endTileInfo;

		// Token: 0x0401211A RID: 74010
		[Token(Token = "0x401211A")]
		[FieldOffset(Offset = "0x20")]
		public List<CooperateAheadGoalData> footballAheadGoalCntFactor;

		// Token: 0x0401211B RID: 74011
		[Token(Token = "0x401211B")]
		[FieldOffset(Offset = "0x28")]
		public int footballHardTypeFactor;

		// Token: 0x0401211C RID: 74012
		[Token(Token = "0x401211C")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<LASTROUNDRESULT, int> footballLastRoundResultFactor;

		// Token: 0x0401211D RID: 74013
		[Token(Token = "0x401211D")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<int, List<CooperateWaveWeight>> footballLevelOfWaveFactor;

		// Token: 0x0401211E RID: 74014
		[Token(Token = "0x401211E")]
		[FieldOffset(Offset = "0x40")]
		public List<CooperateTeamWeight> footballTeamWeights;

		// Token: 0x0401211F RID: 74015
		[Token(Token = "0x401211F")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, CooperateTeamPlayer> footballTeamPlayers;

		// Token: 0x04012120 RID: 74016
		[Token(Token = "0x4012120")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<string, string> footballPlayersName;

		// Token: 0x04012121 RID: 74017
		[Token(Token = "0x4012121")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020026D5 RID: 9941
		[Token(Token = "0x20026D5")]
		[Serializable]
		public class CooperateModeBuffDataPart
		{
			// Token: 0x06010308 RID: 66312 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010308")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CooperateModeBuffDataPart()
			{
			}

			// Token: 0x04012122 RID: 74018
			[Token(Token = "0x4012122")]
			[FieldOffset(Offset = "0x10")]
			public List<ProfessionCategory> filter;

			// Token: 0x04012123 RID: 74019
			[Token(Token = "0x4012123")]
			[FieldOffset(Offset = "0x18")]
			public string description;

			// Token: 0x04012124 RID: 74020
			[Token(Token = "0x4012124")]
			[FieldOffset(Offset = "0x20")]
			public string descriptionHead;

			// Token: 0x04012125 RID: 74021
			[Token(Token = "0x4012125")]
			[FieldOffset(Offset = "0x28")]
			public List<CooperateModeBattleData.CooperateModeBuffDataPart.CooperateModeBuffLevelPhase> levelPhases;

			// Token: 0x020026D6 RID: 9942
			[Token(Token = "0x20026D6")]
			[Serializable]
			public class CooperateModeBuffLevelPhase
			{
				// Token: 0x06010309 RID: 66313 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6010309")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public CooperateModeBuffLevelPhase()
				{
				}

				// Token: 0x04012126 RID: 74022
				[Token(Token = "0x4012126")]
				[FieldOffset(Offset = "0x10")]
				public List<Blackboard.DataPair> blackboard;
			}
		}
	}
}
