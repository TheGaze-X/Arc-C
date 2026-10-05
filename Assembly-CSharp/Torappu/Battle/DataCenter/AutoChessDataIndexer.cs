using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using XLua;

namespace Torappu.Battle.DataCenter
{
	// Token: 0x020026F8 RID: 9976
	[Token(Token = "0x20026F8")]
	public class AutoChessDataIndexer : IHotfixable
	{
		// Token: 0x06010398 RID: 66456 RVA: 0x00062F40 File Offset: 0x00061140
		[Token(Token = "0x6010398")]
		[Address(RVA = "0x7DFCF0", Offset = "0x7DE8F0", VA = "0x1807DFCF0")]
		public int GetSummonedEnemyIdentifierById(string enemyId)
		{
			return 0;
		}

		// Token: 0x06010399 RID: 66457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010399")]
		[Address(RVA = "0x7DFBF0", Offset = "0x7DE7F0", VA = "0x1807DFBF0")]
		public string GetSummonedEnemyIdByIdentifier(int identifier)
		{
			return null;
		}

		// Token: 0x0601039A RID: 66458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601039A")]
		[Address(RVA = "0x7E0C50", Offset = "0x7DF850", VA = "0x1807E0C50")]
		private void _InitSummonEnemyIdentifierIndexer()
		{
		}

		// Token: 0x0601039B RID: 66459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601039B")]
		[Address(RVA = "0x7DF7B0", Offset = "0x7DE3B0", VA = "0x1807DF7B0")]
		public string GetBondIdByIdentifier(int identifier)
		{
			return null;
		}

		// Token: 0x0601039C RID: 66460 RVA: 0x00062F58 File Offset: 0x00061158
		[Token(Token = "0x601039C")]
		[Address(RVA = "0x7DFA90", Offset = "0x7DE690", VA = "0x1807DFA90")]
		public int GetIdentifierByBondId(string bondId)
		{
			return 0;
		}

		// Token: 0x0601039D RID: 66461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601039D")]
		[Address(RVA = "0x7DF920", Offset = "0x7DE520", VA = "0x1807DF920")]
		public string GetChessIdByIdentifier(int identifier)
		{
			return null;
		}

		// Token: 0x0601039E RID: 66462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601039E")]
		[Address(RVA = "0x7E04D0", Offset = "0x7DF0D0", VA = "0x1807E04D0")]
		private void _InitIdentifierIndexer()
		{
		}

		// Token: 0x0601039F RID: 66463 RVA: 0x00062F70 File Offset: 0x00061170
		[Token(Token = "0x601039F")]
		[Address(RVA = "0x7DFDD0", Offset = "0x7DE9D0", VA = "0x1807DFDD0")]
		public bool TryGetCardUidByInstId(int instId, bool isToken, out uint cardUid)
		{
			return default(bool);
		}

		// Token: 0x060103A0 RID: 66464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60103A0")]
		[Address(RVA = "0x7DF0F0", Offset = "0x7DDCF0", VA = "0x1807DF0F0")]
		public void ClearInstCache()
		{
		}

		// Token: 0x060103A1 RID: 66465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60103A1")]
		[Address(RVA = "0x7DF320", Offset = "0x7DDF20", VA = "0x1807DF320")]
		public void ClearRunTimeCache()
		{
		}

		// Token: 0x060103A2 RID: 66466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60103A2")]
		[Address(RVA = "0x7DFEA0", Offset = "0x7DEAA0", VA = "0x1807DFEA0")]
		public void UpdateInst(PlayerBattleData playerBattleData, int playerIndex)
		{
		}

		// Token: 0x060103A3 RID: 66467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60103A3")]
		[Address(RVA = "0x7DF420", Offset = "0x7DE020", VA = "0x1807DF420")]
		public void ConstructRunTimeIndexer(List<ChessInst> battleChessInsts, BattlePlayerData battlePlayerData)
		{
		}

		// Token: 0x060103A4 RID: 66468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60103A4")]
		[Address(RVA = "0x7E0E60", Offset = "0x7DFA60", VA = "0x1807E0E60")]
		public AutoChessDataIndexer()
		{
		}

		// Token: 0x04012268 RID: 74344
		[Token(Token = "0x4012268")]
		[FieldOffset(Offset = "0x10")]
		public AutoChessDataIndexer.CharBondIndexer charBondIndexer;

		// Token: 0x04012269 RID: 74345
		[Token(Token = "0x4012269")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<int, string> m_id2BondIdDict;

		// Token: 0x0401226A RID: 74346
		[Token(Token = "0x401226A")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, int> m_bondId2IdDict;

		// Token: 0x0401226B RID: 74347
		[Token(Token = "0x401226B")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<int, string> m_id2ChessIdDict;

		// Token: 0x0401226C RID: 74348
		[Token(Token = "0x401226C")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, int> m_chessId2IdDict;

		// Token: 0x0401226D RID: 74349
		[Token(Token = "0x401226D")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<int, string> m_enemyIdentifierToId;

		// Token: 0x0401226E RID: 74350
		[Token(Token = "0x401226E")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, int> m_enemyIdToIdentifier;

		// Token: 0x0401226F RID: 74351
		[Token(Token = "0x401226F")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<int, int> instId2PlayerIndex;

		// Token: 0x04012270 RID: 74352
		[Token(Token = "0x4012270")]
		[FieldOffset(Offset = "0x50")]
		public ListDict<int, string> instId2ChessId;

		// Token: 0x04012271 RID: 74353
		[Token(Token = "0x4012271")]
		[FieldOffset(Offset = "0x58")]
		public ListDict<int, int> instId2Position;

		// Token: 0x04012272 RID: 74354
		[Token(Token = "0x4012272")]
		[FieldOffset(Offset = "0x60")]
		public ListDict<int, List<int>> instId2Equips;

		// Token: 0x04012273 RID: 74355
		[Token(Token = "0x4012273")]
		[FieldOffset(Offset = "0x68")]
		public ListDict<int, int> equipId2Equiper;

		// Token: 0x04012274 RID: 74356
		[Token(Token = "0x4012274")]
		[FieldOffset(Offset = "0x70")]
		public ListDict<string, int> chessCntDict;

		// Token: 0x04012275 RID: 74357
		[Token(Token = "0x4012275")]
		[FieldOffset(Offset = "0x78")]
		public Dictionary<int, uint> runtimeChess2CardDict;

		// Token: 0x04012276 RID: 74358
		[Token(Token = "0x4012276")]
		[FieldOffset(Offset = "0x80")]
		public Dictionary<uint, int> runtimeCard2ChessDict;

		// Token: 0x04012277 RID: 74359
		[Token(Token = "0x4012277")]
		[FieldOffset(Offset = "0x88")]
		public ListDict<int, int> tokenInstId2MaxDeployCnt;

		// Token: 0x04012278 RID: 74360
		[Token(Token = "0x4012278")]
		[FieldOffset(Offset = "0x90")]
		public Dictionary<int, uint> runtimeToken2CardDict;

		// Token: 0x04012279 RID: 74361
		[Token(Token = "0x4012279")]
		[FieldOffset(Offset = "0x98")]
		public Dictionary<uint, AutoChessSkillTriggerType> runtimeCardSkillTriggerTypeDict;

		// Token: 0x0401227A RID: 74362
		[Token(Token = "0x401227A")]
		[FieldOffset(Offset = "0xA0")]
		public ListDict<int, int> mlyssCopiedChessUid2CopiedChessInstId;

		// Token: 0x0401227B RID: 74363
		[Token(Token = "0x401227B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetSummonedEnemyIdentifierById;

		// Token: 0x0401227C RID: 74364
		[Token(Token = "0x401227C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetSummonedEnemyIdByIdentifier;

		// Token: 0x0401227D RID: 74365
		[Token(Token = "0x401227D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitSummonEnemyIdentifierIndexer;

		// Token: 0x0401227E RID: 74366
		[Token(Token = "0x401227E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetBondIdByIdentifier;

		// Token: 0x0401227F RID: 74367
		[Token(Token = "0x401227F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetIdentifierByBondId;

		// Token: 0x04012280 RID: 74368
		[Token(Token = "0x4012280")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetChessIdByIdentifier;

		// Token: 0x04012281 RID: 74369
		[Token(Token = "0x4012281")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIdentifierIndexer;

		// Token: 0x04012282 RID: 74370
		[Token(Token = "0x4012282")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TryGetCardUidByInstId;

		// Token: 0x04012283 RID: 74371
		[Token(Token = "0x4012283")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ClearInstCache;

		// Token: 0x04012284 RID: 74372
		[Token(Token = "0x4012284")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ClearRunTimeCache;

		// Token: 0x04012285 RID: 74373
		[Token(Token = "0x4012285")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_UpdateInst;

		// Token: 0x04012286 RID: 74374
		[Token(Token = "0x4012286")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ConstructRunTimeIndexer;

		// Token: 0x04012287 RID: 74375
		[Token(Token = "0x4012287")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020026F9 RID: 9977
		[Token(Token = "0x20026F9")]
		public class CharBondIndexer : IHotfixable
		{
			// Token: 0x060103A5 RID: 66469 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60103A5")]
			[Address(RVA = "0x7E23B0", Offset = "0x7E0FB0", VA = "0x1807E23B0")]
			public void ClearInstCache()
			{
			}

			// Token: 0x060103A6 RID: 66470 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60103A6")]
			[Address(RVA = "0x7E2AC0", Offset = "0x7E16C0", VA = "0x1807E2AC0")]
			public void UpdateInsts(PlayerBattleData playerBattleData, int playerIndex)
			{
			}

			// Token: 0x060103A7 RID: 66471 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60103A7")]
			[Address(RVA = "0x7E3040", Offset = "0x7E1C40", VA = "0x1807E3040")]
			private void _AddExtraChessIdsWithBond(int playerIndex, string bondId, int instId)
			{
			}

			// Token: 0x060103A8 RID: 66472 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60103A8")]
			[Address(RVA = "0x7E2760", Offset = "0x7E1360", VA = "0x1807E2760")]
			public List<string> GetChessIdsWithBond(string bondId, int playerIndex)
			{
				return null;
			}

			// Token: 0x060103A9 RID: 66473 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60103A9")]
			[Address(RVA = "0x7E2510", Offset = "0x7E1110", VA = "0x1807E2510")]
			public List<string> GetCharBondIdsByInstId(int instId)
			{
				return null;
			}

			// Token: 0x060103AA RID: 66474 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60103AA")]
			[Address(RVA = "0x7E33D0", Offset = "0x7E1FD0", VA = "0x1807E33D0")]
			private Dictionary<string, List<string>> _GenerateBasicChessIdsWithBond(int playerIndex)
			{
				return null;
			}

			// Token: 0x060103AB RID: 66475 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60103AB")]
			[Address(RVA = "0x7E2480", Offset = "0x7E1080", VA = "0x1807E2480")]
			public List<string> GetCharBasicBondIds(int instId)
			{
				return null;
			}

			// Token: 0x060103AC RID: 66476 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60103AC")]
			[Address(RVA = "0x7E3860", Offset = "0x7E2460", VA = "0x1807E3860")]
			public CharBondIndexer()
			{
			}

			// Token: 0x04012288 RID: 74376
			[Token(Token = "0x4012288")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<int, Dictionary<string, List<string>>> m_basicChessIdsWithBond;

			// Token: 0x04012289 RID: 74377
			[Token(Token = "0x4012289")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<int, List<string>> m_charBondIdsDict;

			// Token: 0x0401228A RID: 74378
			[Token(Token = "0x401228A")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<int, List<string>> m_charExtraBondIdsDict;

			// Token: 0x0401228B RID: 74379
			[Token(Token = "0x401228B")]
			[FieldOffset(Offset = "0x28")]
			public Dictionary<int, Dictionary<string, List<string>>> m_chessIdsWithBond;

			// Token: 0x0401228C RID: 74380
			[Token(Token = "0x401228C")]
			[FieldOffset(Offset = "0x30")]
			public Dictionary<int, Dictionary<string, HashSet<string>>> m_extraChessIdsWithBond;

			// Token: 0x0401228D RID: 74381
			[Token(Token = "0x401228D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_ClearInstCache;

			// Token: 0x0401228E RID: 74382
			[Token(Token = "0x401228E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateInsts;

			// Token: 0x0401228F RID: 74383
			[Token(Token = "0x401228F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__AddExtraChessIdsWithBond;

			// Token: 0x04012290 RID: 74384
			[Token(Token = "0x4012290")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetChessIdsWithBond;

			// Token: 0x04012291 RID: 74385
			[Token(Token = "0x4012291")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetCharBondIdsByInstId;

			// Token: 0x04012292 RID: 74386
			[Token(Token = "0x4012292")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__GenerateBasicChessIdsWithBond;

			// Token: 0x04012293 RID: 74387
			[Token(Token = "0x4012293")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_GetCharBasicBondIds;

			// Token: 0x04012294 RID: 74388
			[Token(Token = "0x4012294")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
