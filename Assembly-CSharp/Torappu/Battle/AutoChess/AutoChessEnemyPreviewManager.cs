using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002764 RID: 10084
	[Token(Token = "0x2002764")]
	public class AutoChessEnemyPreviewManager : IHotfixable
	{
		// Token: 0x06010702 RID: 67330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010702")]
		[Address(RVA = "0x82CA70", Offset = "0x82B670", VA = "0x18082CA70")]
		public void Load()
		{
		}

		// Token: 0x06010703 RID: 67331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010703")]
		[Address(RVA = "0x82CBA0", Offset = "0x82B7A0", VA = "0x18082CBA0")]
		public void Unload()
		{
		}

		// Token: 0x06010704 RID: 67332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010704")]
		[Address(RVA = "0x82DB20", Offset = "0x82C720", VA = "0x18082DB20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06010705 RID: 67333 RVA: 0x000641E8 File Offset: 0x000623E8
		[Token(Token = "0x6010705")]
		[Address(RVA = "0x82D590", Offset = "0x82C190", VA = "0x18082D590")]
		private GridPosition _GetBetterGridToSpawn(GridPosition pos, int total)
		{
			return default(GridPosition);
		}

		// Token: 0x06010706 RID: 67334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010706")]
		[Address(RVA = "0x82CF00", Offset = "0x82BB00", VA = "0x18082CF00")]
		private void _GeneratePreviewData(LevelData levelData, int roundIndex)
		{
		}

		// Token: 0x06010707 RID: 67335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010707")]
		[Address(RVA = "0x82E4B0", Offset = "0x82D0B0", VA = "0x18082E4B0")]
		private IEnumerator _SpawnPreviewEnemies()
		{
			return null;
		}

		// Token: 0x06010708 RID: 67336 RVA: 0x00064200 File Offset: 0x00062400
		[Token(Token = "0x6010708")]
		[Address(RVA = "0x82CDE0", Offset = "0x82B9E0", VA = "0x18082CDE0")]
		private int _CompareActionByTime(AutoChessEnemyPreviewManager.PreviewEnemyData dataL, AutoChessEnemyPreviewManager.PreviewEnemyData dataR)
		{
			return 0;
		}

		// Token: 0x06010709 RID: 67337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010709")]
		[Address(RVA = "0x82E560", Offset = "0x82D160", VA = "0x18082E560")]
		public AutoChessEnemyPreviewManager()
		{
		}

		// Token: 0x04012671 RID: 75377
		[Token(Token = "0x4012671")]
		private const int MAX_PREVIEW_CNT = 50;

		// Token: 0x04012672 RID: 75378
		[Token(Token = "0x4012672")]
		[FieldOffset(Offset = "0x10")]
		private int m_mapRowOffset;

		// Token: 0x04012673 RID: 75379
		[Token(Token = "0x4012673")]
		[FieldOffset(Offset = "0x14")]
		private int m_bossMapRowOffset;

		// Token: 0x04012674 RID: 75380
		[Token(Token = "0x4012674")]
		[FieldOffset(Offset = "0x18")]
		private ListDict<int, List<int>> m_betterGridToSpawn;

		// Token: 0x04012675 RID: 75381
		[Token(Token = "0x4012675")]
		[FieldOffset(Offset = "0x20")]
		private List<int> m_backUpTiles;

		// Token: 0x04012676 RID: 75382
		[Token(Token = "0x4012676")]
		[FieldOffset(Offset = "0x28")]
		private ListDict<int, int> m_gridSpawnStatus;

		// Token: 0x04012677 RID: 75383
		[Token(Token = "0x4012677")]
		[FieldOffset(Offset = "0x30")]
		private List<AutoChessEnemyPreviewManager.PreviewEnemyData> m_previewEnemyData;

		// Token: 0x04012678 RID: 75384
		[Token(Token = "0x4012678")]
		[FieldOffset(Offset = "0x38")]
		private List<ObjectPtr<Enemy>> m_spawnedEnemy;

		// Token: 0x04012679 RID: 75385
		[Token(Token = "0x4012679")]
		[FieldOffset(Offset = "0x40")]
		private IEnumerator m_spawnCoroutine;

		// Token: 0x0401267A RID: 75386
		[Token(Token = "0x401267A")]
		[FieldOffset(Offset = "0x48")]
		private bool m_inited;

		// Token: 0x0401267B RID: 75387
		[Token(Token = "0x401267B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Load;

		// Token: 0x0401267C RID: 75388
		[Token(Token = "0x401267C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Unload;

		// Token: 0x0401267D RID: 75389
		[Token(Token = "0x401267D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401267E RID: 75390
		[Token(Token = "0x401267E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetBetterGridToSpawn;

		// Token: 0x0401267F RID: 75391
		[Token(Token = "0x401267F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GeneratePreviewData;

		// Token: 0x04012680 RID: 75392
		[Token(Token = "0x4012680")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SpawnPreviewEnemies;

		// Token: 0x04012681 RID: 75393
		[Token(Token = "0x4012681")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CompareActionByTime;

		// Token: 0x04012682 RID: 75394
		[Token(Token = "0x4012682")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002765 RID: 10085
		[Token(Token = "0x2002765")]
		private struct PreviewEnemyData
		{
			// Token: 0x04012683 RID: 75395
			[Token(Token = "0x4012683")]
			[FieldOffset(Offset = "0x0")]
			public float actionDelay;

			// Token: 0x04012684 RID: 75396
			[Token(Token = "0x4012684")]
			[FieldOffset(Offset = "0x4")]
			public GridPosition startPosition;

			// Token: 0x04012685 RID: 75397
			[Token(Token = "0x4012685")]
			[FieldOffset(Offset = "0x10")]
			public string enemyKey;

			// Token: 0x04012686 RID: 75398
			[Token(Token = "0x4012686")]
			[FieldOffset(Offset = "0x18")]
			public int count;
		}
	}
}
