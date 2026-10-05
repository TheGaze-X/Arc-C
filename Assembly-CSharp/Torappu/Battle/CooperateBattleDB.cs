using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Cooperate;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002671 RID: 9841
	[Token(Token = "0x2002671")]
	[CreateAssetMenu(fileName = "cooperate_battle_db", menuName = "Torappu/DB/Table/CooperateBattleTable")]
	[Serializable]
	public class CooperateBattleDB : ConstTable<CooperateModeBattleData, CooperateBattleDB>
	{
		// Token: 0x17002310 RID: 8976
		// (get) Token: 0x06010174 RID: 65908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002310")]
		public Dictionary<EndTileType, CooperateEndTileInfo> endTileInfo
		{
			[Token(Token = "0x6010174")]
			[Address(RVA = "0x7C2AE0", Offset = "0x7C16E0", VA = "0x1807C2AE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002311 RID: 8977
		// (get) Token: 0x06010175 RID: 65909 RVA: 0x00062388 File Offset: 0x00060588
		[Token(Token = "0x17002311")]
		public int costTransferCnt
		{
			[Token(Token = "0x6010175")]
			[Address(RVA = "0x7C2A60", Offset = "0x7C1660", VA = "0x1807C2A60")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17002312 RID: 8978
		// (get) Token: 0x06010176 RID: 65910 RVA: 0x000623A0 File Offset: 0x000605A0
		[Token(Token = "0x17002312")]
		public int getMaxMsgCntInOneUpdate
		{
			[Token(Token = "0x6010176")]
			[Address(RVA = "0x7C2EE0", Offset = "0x7C1AE0", VA = "0x1807C2EE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17002313 RID: 8979
		// (get) Token: 0x06010177 RID: 65911 RVA: 0x000623B8 File Offset: 0x000605B8
		[Token(Token = "0x17002313")]
		public int footballHardTypeFactor
		{
			[Token(Token = "0x6010177")]
			[Address(RVA = "0x7C2BE0", Offset = "0x7C17E0", VA = "0x1807C2BE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17002314 RID: 8980
		// (get) Token: 0x06010178 RID: 65912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002314")]
		public List<CooperateAheadGoalData> footballAheadGoalCntFactor
		{
			[Token(Token = "0x6010178")]
			[Address(RVA = "0x7C2B60", Offset = "0x7C1760", VA = "0x1807C2B60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002315 RID: 8981
		// (get) Token: 0x06010179 RID: 65913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002315")]
		public Dictionary<LASTROUNDRESULT, int> footballLastRoundResultFactor
		{
			[Token(Token = "0x6010179")]
			[Address(RVA = "0x7C2C60", Offset = "0x7C1860", VA = "0x1807C2C60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002316 RID: 8982
		// (get) Token: 0x0601017A RID: 65914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002316")]
		public Dictionary<int, List<CooperateWaveWeight>> footballLevelOfWaveFactor
		{
			[Token(Token = "0x601017A")]
			[Address(RVA = "0x7C2CE0", Offset = "0x7C18E0", VA = "0x1807C2CE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002317 RID: 8983
		// (get) Token: 0x0601017B RID: 65915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002317")]
		public List<CooperateTeamWeight> footballTeamWeights
		{
			[Token(Token = "0x601017B")]
			[Address(RVA = "0x7C2E60", Offset = "0x7C1A60", VA = "0x1807C2E60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002318 RID: 8984
		// (get) Token: 0x0601017C RID: 65916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002318")]
		public Dictionary<string, CooperateTeamPlayer> footballTeamPlayers
		{
			[Token(Token = "0x601017C")]
			[Address(RVA = "0x7C2DE0", Offset = "0x7C19E0", VA = "0x1807C2DE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002319 RID: 8985
		// (get) Token: 0x0601017D RID: 65917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002319")]
		public Dictionary<string, string> footballPlayersName
		{
			[Token(Token = "0x601017D")]
			[Address(RVA = "0x7C2D60", Offset = "0x7C1960", VA = "0x1807C2D60")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601017E RID: 65918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601017E")]
		[Address(RVA = "0x7C29F0", Offset = "0x7C15F0", VA = "0x1807C29F0")]
		public CooperateBattleDB()
		{
		}

		// Token: 0x04011E5F RID: 73311
		[Token(Token = "0x4011E5F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_endTileInfo;

		// Token: 0x04011E60 RID: 73312
		[Token(Token = "0x4011E60")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_costTransferCnt;

		// Token: 0x04011E61 RID: 73313
		[Token(Token = "0x4011E61")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_getMaxMsgCntInOneUpdate;

		// Token: 0x04011E62 RID: 73314
		[Token(Token = "0x4011E62")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_footballHardTypeFactor;

		// Token: 0x04011E63 RID: 73315
		[Token(Token = "0x4011E63")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_footballAheadGoalCntFactor;

		// Token: 0x04011E64 RID: 73316
		[Token(Token = "0x4011E64")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_footballLastRoundResultFactor;

		// Token: 0x04011E65 RID: 73317
		[Token(Token = "0x4011E65")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_footballLevelOfWaveFactor;

		// Token: 0x04011E66 RID: 73318
		[Token(Token = "0x4011E66")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_footballTeamWeights;

		// Token: 0x04011E67 RID: 73319
		[Token(Token = "0x4011E67")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_footballTeamPlayers;

		// Token: 0x04011E68 RID: 73320
		[Token(Token = "0x4011E68")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_footballPlayersName;

		// Token: 0x04011E69 RID: 73321
		[Token(Token = "0x4011E69")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
