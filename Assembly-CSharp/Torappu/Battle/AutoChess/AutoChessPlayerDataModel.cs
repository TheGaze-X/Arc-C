using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.DataCenter;
using XLua;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x0200277F RID: 10111
	[Token(Token = "0x200277F")]
	public class AutoChessPlayerDataModel : AutoChessDataCenter.AutoChessDataModelBase
	{
		// Token: 0x17002411 RID: 9233
		// (get) Token: 0x06010806 RID: 67590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002411")]
		public Dictionary<int, AutoChessPlayerDataModel.ScenePlayerData> allPlayerDatas
		{
			[Token(Token = "0x6010806")]
			[Address(RVA = "0x84D660", Offset = "0x84C260", VA = "0x18084D660")]
			get
			{
				return null;
			}
		}

		// Token: 0x06010807 RID: 67591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010807")]
		[Address(RVA = "0x84C880", Offset = "0x84B480", VA = "0x18084C880")]
		public AutoChessPlayerDataModel.ScenePlayerData EnsureScenePlayerData(int index)
		{
			return null;
		}

		// Token: 0x06010808 RID: 67592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010808")]
		[Address(RVA = "0x84CB40", Offset = "0x84B740", VA = "0x18084CB40")]
		public AutoChessPlayerDataModel.ScenePlayerData GetPlayerData(int index)
		{
			return null;
		}

		// Token: 0x06010809 RID: 67593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010809")]
		[Address(RVA = "0x84C990", Offset = "0x84B590", VA = "0x18084C990")]
		public string GetPlayerBandId(int index)
		{
			return null;
		}

		// Token: 0x0601080A RID: 67594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601080A")]
		[Address(RVA = "0x84CC00", Offset = "0x84B800", VA = "0x18084CC00")]
		public List<SquadSlot> GetPlayerSquadSlot(int index)
		{
			return null;
		}

		// Token: 0x0601080B RID: 67595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601080B")]
		[Address(RVA = "0x84CA20", Offset = "0x84B620", VA = "0x18084CA20")]
		public PlayerBattleData GetPlayerBattleData(int index)
		{
			return null;
		}

		// Token: 0x0601080C RID: 67596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601080C")]
		[Address(RVA = "0x84CAB0", Offset = "0x84B6B0", VA = "0x18084CAB0")]
		public PlayerCard GetPlayerCard(int index)
		{
			return null;
		}

		// Token: 0x0601080D RID: 67597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601080D")]
		[Address(RVA = "0x84D2D0", Offset = "0x84BED0", VA = "0x18084D2D0")]
		public void UpdateData(ScenePlayerStaticData staticData)
		{
		}

		// Token: 0x0601080E RID: 67598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601080E")]
		[Address(RVA = "0x84D050", Offset = "0x84BC50", VA = "0x18084D050")]
		public void UpdateData(ScenePlayerRunTimeData runTimeData)
		{
		}

		// Token: 0x0601080F RID: 67599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601080F")]
		[Address(RVA = "0x84CC90", Offset = "0x84B890", VA = "0x18084CC90")]
		public void RefreshPlayerChessPositionInfo()
		{
		}

		// Token: 0x06010810 RID: 67600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010810")]
		[Address(RVA = "0x84D510", Offset = "0x84C110", VA = "0x18084D510")]
		public void UpdateData(int playerUidIndex, AutoChessPlayerConnectStateType connectStateType)
		{
		}

		// Token: 0x06010811 RID: 67601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010811")]
		[Address(RVA = "0x84D5B0", Offset = "0x84C1B0", VA = "0x18084D5B0")]
		public AutoChessPlayerDataModel()
		{
		}

		// Token: 0x04012805 RID: 75781
		[Token(Token = "0x4012805")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<int, AutoChessPlayerDataModel.ScenePlayerData> m_allPlayerDatas;

		// Token: 0x04012806 RID: 75782
		[Token(Token = "0x4012806")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_allPlayerDatas;

		// Token: 0x04012807 RID: 75783
		[Token(Token = "0x4012807")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EnsureScenePlayerData;

		// Token: 0x04012808 RID: 75784
		[Token(Token = "0x4012808")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetPlayerData;

		// Token: 0x04012809 RID: 75785
		[Token(Token = "0x4012809")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetPlayerBandId;

		// Token: 0x0401280A RID: 75786
		[Token(Token = "0x401280A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetPlayerSquadSlot;

		// Token: 0x0401280B RID: 75787
		[Token(Token = "0x401280B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetPlayerBattleData;

		// Token: 0x0401280C RID: 75788
		[Token(Token = "0x401280C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetPlayerCard;

		// Token: 0x0401280D RID: 75789
		[Token(Token = "0x401280D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0401280E RID: 75790
		[Token(Token = "0x401280E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix1_UpdateData;

		// Token: 0x0401280F RID: 75791
		[Token(Token = "0x401280F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_RefreshPlayerChessPositionInfo;

		// Token: 0x04012810 RID: 75792
		[Token(Token = "0x4012810")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix2_UpdateData;

		// Token: 0x04012811 RID: 75793
		[Token(Token = "0x4012811")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002780 RID: 10112
		[Token(Token = "0x2002780")]
		public class ScenePlayerData : IHotfixable
		{
			// Token: 0x17002412 RID: 9234
			// (get) Token: 0x06010812 RID: 67602 RVA: 0x00064A10 File Offset: 0x00062C10
			[Token(Token = "0x17002412")]
			public bool isPrepareStateReady
			{
				[Token(Token = "0x6010812")]
				[Address(RVA = "0x8571F0", Offset = "0x855DF0", VA = "0x1808571F0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002413 RID: 9235
			// (get) Token: 0x06010813 RID: 67603 RVA: 0x00064A28 File Offset: 0x00062C28
			[Token(Token = "0x17002413")]
			public bool isDead
			{
				[Token(Token = "0x6010813")]
				[Address(RVA = "0x857180", Offset = "0x855D80", VA = "0x180857180")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06010814 RID: 67604 RVA: 0x00064A40 File Offset: 0x00062C40
			[Token(Token = "0x6010814")]
			[Address(RVA = "0x856AF0", Offset = "0x8556F0", VA = "0x180856AF0")]
			public int GetBondStackCount(string bondId)
			{
				return 0;
			}

			// Token: 0x06010815 RID: 67605 RVA: 0x00064A58 File Offset: 0x00062C58
			[Token(Token = "0x6010815")]
			[Address(RVA = "0x856A30", Offset = "0x855630", VA = "0x180856A30")]
			public int GetBondCharCount(string bondId)
			{
				return 0;
			}

			// Token: 0x06010816 RID: 67606 RVA: 0x00064A70 File Offset: 0x00062C70
			[Token(Token = "0x6010816")]
			[Address(RVA = "0x856930", Offset = "0x855530", VA = "0x180856930")]
			public bool AddBondCount(string bondId, int count)
			{
				return default(bool);
			}

			// Token: 0x06010817 RID: 67607 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010817")]
			[Address(RVA = "0x856BB0", Offset = "0x8557B0", VA = "0x180856BB0")]
			public void RefreshBonds()
			{
			}

			// Token: 0x06010818 RID: 67608 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010818")]
			[Address(RVA = "0x856F20", Offset = "0x855B20", VA = "0x180856F20")]
			public ScenePlayerData()
			{
			}

			// Token: 0x04012812 RID: 75794
			[Token(Token = "0x4012812")]
			[FieldOffset(Offset = "0x10")]
			public int index;

			// Token: 0x04012813 RID: 75795
			[Token(Token = "0x4012813")]
			[FieldOffset(Offset = "0x18")]
			public string uid;

			// Token: 0x04012814 RID: 75796
			[Token(Token = "0x4012814")]
			[FieldOffset(Offset = "0x20")]
			public string bandId;

			// Token: 0x04012815 RID: 75797
			[Token(Token = "0x4012815")]
			[FieldOffset(Offset = "0x28")]
			public List<SquadSlot> squadSlots;

			// Token: 0x04012816 RID: 75798
			[Token(Token = "0x4012816")]
			[FieldOffset(Offset = "0x30")]
			public PlayerCard playerCard;

			// Token: 0x04012817 RID: 75799
			[Token(Token = "0x4012817")]
			[FieldOffset(Offset = "0x38")]
			public int hp;

			// Token: 0x04012818 RID: 75800
			[Token(Token = "0x4012818")]
			[FieldOffset(Offset = "0x3C")]
			public int shopLevel;

			// Token: 0x04012819 RID: 75801
			[Token(Token = "0x4012819")]
			[FieldOffset(Offset = "0x40")]
			public int shopCoin;

			// Token: 0x0401281A RID: 75802
			[Token(Token = "0x401281A")]
			[FieldOffset(Offset = "0x44")]
			public bool gameFinished;

			// Token: 0x0401281B RID: 75803
			[Token(Token = "0x401281B")]
			[FieldOffset(Offset = "0x48")]
			public int maxDeploymentCnt;

			// Token: 0x0401281C RID: 75804
			[Token(Token = "0x401281C")]
			[FieldOffset(Offset = "0x4C")]
			public AutoChessPlayerGameStateType gameState;

			// Token: 0x0401281D RID: 75805
			[Token(Token = "0x401281D")]
			[FieldOffset(Offset = "0x50")]
			public AutoChessPlayerConnectStateType connectState;

			// Token: 0x0401281E RID: 75806
			[Token(Token = "0x401281E")]
			[FieldOffset(Offset = "0x58")]
			public PlayerBattleData playerBattleData;

			// Token: 0x0401281F RID: 75807
			[Token(Token = "0x401281F")]
			[FieldOffset(Offset = "0x60")]
			public List<BattleEffectEnemyInfo> effectEnemies;

			// Token: 0x04012820 RID: 75808
			[Token(Token = "0x4012820")]
			[FieldOffset(Offset = "0x68")]
			public PreparationRoundAnalytics roundAnalytics;

			// Token: 0x04012821 RID: 75809
			[Token(Token = "0x4012821")]
			[FieldOffset(Offset = "0x70")]
			public Dictionary<string, GarrisonBond> garrisonBonds;

			// Token: 0x04012822 RID: 75810
			[Token(Token = "0x4012822")]
			[FieldOffset(Offset = "0x78")]
			public List<ActAutoChessData.ActAutoChessBondInfo> activeBonds;

			// Token: 0x04012823 RID: 75811
			[Token(Token = "0x4012823")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isPrepareStateReady;

			// Token: 0x04012824 RID: 75812
			[Token(Token = "0x4012824")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_isDead;

			// Token: 0x04012825 RID: 75813
			[Token(Token = "0x4012825")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetBondStackCount;

			// Token: 0x04012826 RID: 75814
			[Token(Token = "0x4012826")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetBondCharCount;

			// Token: 0x04012827 RID: 75815
			[Token(Token = "0x4012827")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AddBondCount;

			// Token: 0x04012828 RID: 75816
			[Token(Token = "0x4012828")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_RefreshBonds;

			// Token: 0x04012829 RID: 75817
			[Token(Token = "0x4012829")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
