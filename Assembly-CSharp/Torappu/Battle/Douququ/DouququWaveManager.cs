using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using XLua;

namespace Torappu.Battle.Douququ
{
	// Token: 0x02002A35 RID: 10805
	[Token(Token = "0x2002A35")]
	public class DouququWaveManager : IHotfixable
	{
		// Token: 0x17002775 RID: 10101
		// (get) Token: 0x06011F01 RID: 73473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002775")]
		public List<TeamData> teamList
		{
			[Token(Token = "0x6011F01")]
			[Address(RVA = "0x9C8C20", Offset = "0x9C7820", VA = "0x1809C8C20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002776 RID: 10102
		// (get) Token: 0x06011F02 RID: 73474 RVA: 0x0006DBC0 File Offset: 0x0006BDC0
		[Token(Token = "0x17002776")]
		public int totalWaveCnt
		{
			[Token(Token = "0x6011F02")]
			[Address(RVA = "0x9C8C80", Offset = "0x9C7880", VA = "0x1809C8C80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06011F03 RID: 73475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F03")]
		[Address(RVA = "0x9C6100", Offset = "0x9C4D00", VA = "0x1809C6100")]
		public void Init(GameModeFactory.DouququGameMode gameMode, LevelData levelData)
		{
		}

		// Token: 0x06011F04 RID: 73476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F04")]
		[Address(RVA = "0x9C8270", Offset = "0x9C6E70", VA = "0x1809C8270")]
		private void _ProcessRoundData()
		{
		}

		// Token: 0x06011F05 RID: 73477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F05")]
		[Address(RVA = "0x9C7FE0", Offset = "0x9C6BE0", VA = "0x1809C7FE0")]
		private void _ProcessEnemyData()
		{
		}

		// Token: 0x06011F06 RID: 73478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F06")]
		[Address(RVA = "0x9C6550", Offset = "0x9C5150", VA = "0x1809C6550")]
		private static void _AddToRoundList(ref List<EnemyGenerationData> list, string key, int cnt)
		{
		}

		// Token: 0x06011F07 RID: 73479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011F07")]
		[Address(RVA = "0x9C70F0", Offset = "0x9C5CF0", VA = "0x1809C70F0")]
		private LevelData.WaveData _GenerateRound(int round)
		{
			return null;
		}

		// Token: 0x06011F08 RID: 73480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F08")]
		[Address(RVA = "0x9C84A0", Offset = "0x9C70A0", VA = "0x1809C84A0")]
		private static void _SelectEnemyForEachTeam(List<EnemyGenerationData> selected, List<EnemyGenerationData> enemyForTheRound, int typeCnt)
		{
		}

		// Token: 0x06011F09 RID: 73481 RVA: 0x0006DBD8 File Offset: 0x0006BDD8
		[Token(Token = "0x6011F09")]
		[Address(RVA = "0x9C6780", Offset = "0x9C5380", VA = "0x1809C6780")]
		private static bool _AvailableEnemy(string enemyId)
		{
			return default(bool);
		}

		// Token: 0x06011F0A RID: 73482 RVA: 0x0006DBF0 File Offset: 0x0006BDF0
		[Token(Token = "0x6011F0A")]
		[Address(RVA = "0x9C7E80", Offset = "0x9C6A80", VA = "0x1809C7E80")]
		private int _GetActionCnt()
		{
			return 0;
		}

		// Token: 0x06011F0B RID: 73483 RVA: 0x0006DC08 File Offset: 0x0006BE08
		[Token(Token = "0x6011F0B")]
		[Address(RVA = "0x9C7F60", Offset = "0x9C6B60", VA = "0x1809C7F60")]
		private static bool _NeedRoute(LevelData.WaveData.FragmentData.ActionData action)
		{
			return default(bool);
		}

		// Token: 0x06011F0C RID: 73484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F0C")]
		[Address(RVA = "0x9C8700", Offset = "0x9C7300", VA = "0x1809C8700")]
		private void _TideRoute()
		{
		}

		// Token: 0x06011F0D RID: 73485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011F0D")]
		[Address(RVA = "0x9C6EE0", Offset = "0x9C5AE0", VA = "0x1809C6EE0")]
		private static LevelData.WaveData _GenerateDefaultWave()
		{
			return null;
		}

		// Token: 0x06011F0E RID: 73486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F0E")]
		[Address(RVA = "0x9C79D0", Offset = "0x9C65D0", VA = "0x1809C79D0")]
		private void _GenerateTeam(float score, string tileKey, List<EnemyGenerationData> enemyList, bool unharmful, LevelData.WaveData outWave)
		{
		}

		// Token: 0x06011F0F RID: 73487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F0F")]
		[Address(RVA = "0x9C7410", Offset = "0x9C6010", VA = "0x1809C7410")]
		private void _GenerateTeamWave(string tileKey, List<EnemyGenerationData> enemyList, bool unharmful, LevelData.WaveData outWave)
		{
		}

		// Token: 0x06011F10 RID: 73488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011F10")]
		[Address(RVA = "0x9C6840", Offset = "0x9C5440", VA = "0x1809C6840")]
		private List<int[]> _FindSpawnPositions(string tileKey)
		{
			return null;
		}

		// Token: 0x06011F11 RID: 73489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F11")]
		[Address(RVA = "0x9C6AC0", Offset = "0x9C56C0", VA = "0x1809C6AC0")]
		private void _GenerateActionForEnemy(string enemyId, int[] position, float spawnDelay, bool unharmful, LevelData.WaveData outWave)
		{
		}

		// Token: 0x06011F12 RID: 73490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F12")]
		[Address(RVA = "0x9C8A80", Offset = "0x9C7680", VA = "0x1809C8A80")]
		public DouququWaveManager()
		{
		}

		// Token: 0x04014398 RID: 82840
		[Token(Token = "0x4014398")]
		[FieldOffset(Offset = "0x10")]
		private LevelData m_levelData;

		// Token: 0x04014399 RID: 82841
		[Token(Token = "0x4014399")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<EnemyGenerationData> m_allEnemyExtraData;

		// Token: 0x0401439A RID: 82842
		[Token(Token = "0x401439A")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<RoundData> m_roundDataList;

		// Token: 0x0401439B RID: 82843
		[Token(Token = "0x401439B")]
		[FieldOffset(Offset = "0x28")]
		private readonly List<TeamData> m_teamList;

		// Token: 0x0401439C RID: 82844
		[Token(Token = "0x401439C")]
		[FieldOffset(Offset = "0x30")]
		private readonly Dictionary<string, List<int[]>> m_startPos;

		// Token: 0x0401439D RID: 82845
		[Token(Token = "0x401439D")]
		[FieldOffset(Offset = "0x38")]
		private GameModeFactory.DouququGameMode m_gameMode;

		// Token: 0x0401439E RID: 82846
		[Token(Token = "0x401439E")]
		private const string TILE_START = "tile_start";

		// Token: 0x0401439F RID: 82847
		[Token(Token = "0x401439F")]
		private const string TILE_END = "tile_end";

		// Token: 0x040143A0 RID: 82848
		[Token(Token = "0x40143A0")]
		private const float DOUQUQU_ENEMY_WAVE_INTERVAL = 3f;

		// Token: 0x040143A1 RID: 82849
		[Token(Token = "0x40143A1")]
		private const float MAX_ENEMY_COST = 999999f;

		// Token: 0x040143A2 RID: 82850
		[Token(Token = "0x40143A2")]
		private const float MAX_WAIT_TIME = 10000f;

		// Token: 0x040143A3 RID: 82851
		[Token(Token = "0x40143A3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_teamList;

		// Token: 0x040143A4 RID: 82852
		[Token(Token = "0x40143A4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_totalWaveCnt;

		// Token: 0x040143A5 RID: 82853
		[Token(Token = "0x40143A5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040143A6 RID: 82854
		[Token(Token = "0x40143A6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ProcessRoundData;

		// Token: 0x040143A7 RID: 82855
		[Token(Token = "0x40143A7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ProcessEnemyData;

		// Token: 0x040143A8 RID: 82856
		[Token(Token = "0x40143A8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__AddToRoundList;

		// Token: 0x040143A9 RID: 82857
		[Token(Token = "0x40143A9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GenerateRound;

		// Token: 0x040143AA RID: 82858
		[Token(Token = "0x40143AA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SelectEnemyForEachTeam;

		// Token: 0x040143AB RID: 82859
		[Token(Token = "0x40143AB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__AvailableEnemy;

		// Token: 0x040143AC RID: 82860
		[Token(Token = "0x40143AC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetActionCnt;

		// Token: 0x040143AD RID: 82861
		[Token(Token = "0x40143AD")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__NeedRoute;

		// Token: 0x040143AE RID: 82862
		[Token(Token = "0x40143AE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TideRoute;

		// Token: 0x040143AF RID: 82863
		[Token(Token = "0x40143AF")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GenerateDefaultWave;

		// Token: 0x040143B0 RID: 82864
		[Token(Token = "0x40143B0")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GenerateTeam;

		// Token: 0x040143B1 RID: 82865
		[Token(Token = "0x40143B1")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GenerateTeamWave;

		// Token: 0x040143B2 RID: 82866
		[Token(Token = "0x40143B2")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__FindSpawnPositions;

		// Token: 0x040143B3 RID: 82867
		[Token(Token = "0x40143B3")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__GenerateActionForEnemy;

		// Token: 0x040143B4 RID: 82868
		[Token(Token = "0x40143B4")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
