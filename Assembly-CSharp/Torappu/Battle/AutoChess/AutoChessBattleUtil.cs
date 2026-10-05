using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.DataCenter;
using Torappu.ObjectPool;
using UnityEngine;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002701 RID: 9985
	[Token(Token = "0x2002701")]
	public static class AutoChessBattleUtil
	{
		// Token: 0x17002382 RID: 9090
		// (get) Token: 0x060103D6 RID: 66518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002382")]
		public static AutoChessDataIndexer indexer
		{
			[Token(Token = "0x60103D6")]
			[Address(RVA = "0x7F6830", Offset = "0x7F5430", VA = "0x1807F6830")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002383 RID: 9091
		// (get) Token: 0x060103D7 RID: 66519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002383")]
		public static AutoChessMapAreaManager.TileIndexer tileIndexer
		{
			[Token(Token = "0x60103D7")]
			[Address(RVA = "0x7F6860", Offset = "0x7F5460", VA = "0x1807F6860")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002384 RID: 9092
		// (get) Token: 0x060103D8 RID: 66520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002384")]
		public static Dictionary<int, ChessInst> chessInstMap
		{
			[Token(Token = "0x60103D8")]
			[Address(RVA = "0x7F6730", Offset = "0x7F5330", VA = "0x1807F6730")]
			get
			{
				return null;
			}
		}

		// Token: 0x060103D9 RID: 66521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60103D9")]
		[Address(RVA = "0x7F1F70", Offset = "0x7F0B70", VA = "0x1807F1F70")]
		public static string GetBondIdByIdentifier(int identifier)
		{
			return null;
		}

		// Token: 0x060103DA RID: 66522 RVA: 0x000631B0 File Offset: 0x000613B0
		[Token(Token = "0x60103DA")]
		[Address(RVA = "0x7F4250", Offset = "0x7F2E50", VA = "0x1807F4250")]
		public static int GetIdentifierByBondId(string bondId)
		{
			return 0;
		}

		// Token: 0x060103DB RID: 66523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60103DB")]
		[Address(RVA = "0x7F3550", Offset = "0x7F2150", VA = "0x1807F3550")]
		public static string GetChessIdByIdentifier(int identifier)
		{
			return null;
		}

		// Token: 0x060103DC RID: 66524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60103DC")]
		[Address(RVA = "0x7F3590", Offset = "0x7F2190", VA = "0x1807F3590")]
		public static string GetChessId(int instId)
		{
			return null;
		}

		// Token: 0x060103DD RID: 66525 RVA: 0x000631C8 File Offset: 0x000613C8
		[Token(Token = "0x60103DD")]
		[Address(RVA = "0x7F3410", Offset = "0x7F2010", VA = "0x1807F3410")]
		public static ChessBasicInfo GetChessBasicInfo(string chessId)
		{
			return default(ChessBasicInfo);
		}

		// Token: 0x060103DE RID: 66526 RVA: 0x000631E0 File Offset: 0x000613E0
		[Token(Token = "0x60103DE")]
		[Address(RVA = "0x7F3480", Offset = "0x7F2080", VA = "0x1807F3480")]
		public static ChessBasicInfo GetChessBasicInfo(int instId)
		{
			return default(ChessBasicInfo);
		}

		// Token: 0x060103DF RID: 66527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60103DF")]
		[Address(RVA = "0x7F38B0", Offset = "0x7F24B0", VA = "0x1807F38B0")]
		public static ChessSquad GetChessSquad(int instId)
		{
			return null;
		}

		// Token: 0x060103E0 RID: 66528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60103E0")]
		[Address(RVA = "0x7F3530", Offset = "0x7F2130", VA = "0x1807F3530")]
		public static AdvancedCharacterInst GetChessCharacterInst(int instId)
		{
			return null;
		}

		// Token: 0x060103E1 RID: 66529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60103E1")]
		[Address(RVA = "0x7F34D0", Offset = "0x7F20D0", VA = "0x1807F34D0")]
		public static AdvancedCharacterInst GetChessCharacterInst(string chessId, int playerIndex)
		{
			return null;
		}

		// Token: 0x060103E2 RID: 66530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60103E2")]
		[Address(RVA = "0x7F3270", Offset = "0x7F1E70", VA = "0x1807F3270")]
		public static Sprite GetChessAvatar(string chessId, int playerIndex)
		{
			return null;
		}

		// Token: 0x060103E3 RID: 66531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60103E3")]
		[Address(RVA = "0x7F4020", Offset = "0x7F2C20", VA = "0x1807F4020")]
		public static List<ActAutoChessData.ActAutoChessBuffInfoData> GetEquipEffectBuffs(string equipChessId)
		{
			return null;
		}

		// Token: 0x060103E4 RID: 66532 RVA: 0x000631F8 File Offset: 0x000613F8
		[Token(Token = "0x60103E4")]
		[Address(RVA = "0x7F3970", Offset = "0x7F2570", VA = "0x1807F3970")]
		public static AutoChessItemType GetChessType(string chessId)
		{
			return AutoChessItemType.CHAR;
		}

		// Token: 0x060103E5 RID: 66533 RVA: 0x00063210 File Offset: 0x00061410
		[Token(Token = "0x60103E5")]
		[Address(RVA = "0x7F50A0", Offset = "0x7F3CA0", VA = "0x1807F50A0")]
		public static bool IsEquipOrMagic(string chessId)
		{
			return default(bool);
		}

		// Token: 0x060103E6 RID: 66534 RVA: 0x00063228 File Offset: 0x00061428
		[Token(Token = "0x60103E6")]
		[Address(RVA = "0x7F4E70", Offset = "0x7F3A70", VA = "0x1807F4E70")]
		public static bool IsChar(string chessId)
		{
			return default(bool);
		}

		// Token: 0x060103E7 RID: 66535 RVA: 0x00063240 File Offset: 0x00061440
		[Token(Token = "0x60103E7")]
		[Address(RVA = "0x7F5340", Offset = "0x7F3F40", VA = "0x1807F5340")]
		public static bool IsMagic(int instId)
		{
			return default(bool);
		}

		// Token: 0x060103E8 RID: 66536 RVA: 0x00063258 File Offset: 0x00061458
		[Token(Token = "0x60103E8")]
		[Address(RVA = "0x7F5100", Offset = "0x7F3D00", VA = "0x1807F5100")]
		public static bool IsGolden(string chessId)
		{
			return default(bool);
		}

		// Token: 0x060103E9 RID: 66537 RVA: 0x00063270 File Offset: 0x00061470
		[Token(Token = "0x60103E9")]
		[Address(RVA = "0x7F37D0", Offset = "0x7F23D0", VA = "0x1807F37D0")]
		public static int GetChessItemLevel(int instId)
		{
			return 0;
		}

		// Token: 0x060103EA RID: 66538 RVA: 0x00063288 File Offset: 0x00061488
		[Token(Token = "0x60103EA")]
		[Address(RVA = "0x7F3800", Offset = "0x7F2400", VA = "0x1807F3800")]
		public static int GetChessLevel(uint cardUid)
		{
			return 0;
		}

		// Token: 0x060103EB RID: 66539 RVA: 0x000632A0 File Offset: 0x000614A0
		[Token(Token = "0x60103EB")]
		[Address(RVA = "0x7F5CC0", Offset = "0x7F48C0", VA = "0x1807F5CC0")]
		public static bool TryGetInstId(GridPosition pos, out int instId)
		{
			return default(bool);
		}

		// Token: 0x060103EC RID: 66540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60103EC")]
		[Address(RVA = "0x7F3710", Offset = "0x7F2310", VA = "0x1807F3710")]
		public static ChessInst GetChessInstByPos(GridPosition pos)
		{
			return null;
		}

		// Token: 0x060103ED RID: 66541 RVA: 0x000632B8 File Offset: 0x000614B8
		[Token(Token = "0x60103ED")]
		[Address(RVA = "0x7F4310", Offset = "0x7F2F10", VA = "0x1807F4310")]
		public static int GetInstId(GridPosition pos)
		{
			return 0;
		}

		// Token: 0x060103EE RID: 66542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60103EE")]
		[Address(RVA = "0x7F18A0", Offset = "0x7F04A0", VA = "0x1807F18A0")]
		public static ChessInst GetBattleInstById(int instId, bool isToken = false)
		{
			return null;
		}

		// Token: 0x060103EF RID: 66543 RVA: 0x000632D0 File Offset: 0x000614D0
		[Token(Token = "0x60103EF")]
		[Address(RVA = "0x7F2BF0", Offset = "0x7F17F0", VA = "0x1807F2BF0")]
		public static int GetCharCountSameCol(GridPosition pos)
		{
			return 0;
		}

		// Token: 0x060103F0 RID: 66544 RVA: 0x000632E8 File Offset: 0x000614E8
		[Token(Token = "0x60103F0")]
		[Address(RVA = "0x7F2DF0", Offset = "0x7F19F0", VA = "0x1807F2DF0")]
		public static int GetCharCountSameRow(GridPosition pos)
		{
			return 0;
		}

		// Token: 0x060103F1 RID: 66545 RVA: 0x00063300 File Offset: 0x00061500
		[Token(Token = "0x60103F1")]
		[Address(RVA = "0x7F5A80", Offset = "0x7F4680", VA = "0x1807F5A80")]
		public static bool TryGetChessPos(int instId, bool isToken, bool checkInHand, out GridPosition pos)
		{
			return default(bool);
		}

		// Token: 0x060103F2 RID: 66546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60103F2")]
		[Address(RVA = "0x7F0720", Offset = "0x7EF320", VA = "0x1807F0720")]
		public static void ApplyInstDataToSharedData(BattleCharacterData charData, string chessId, int instId)
		{
		}

		// Token: 0x17002385 RID: 9093
		// (get) Token: 0x060103F3 RID: 66547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002385")]
		public static List<GridPosition> handTilesList
		{
			[Token(Token = "0x60103F3")]
			[Address(RVA = "0x7F6770", Offset = "0x7F5370", VA = "0x1807F6770")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002386 RID: 9094
		// (get) Token: 0x060103F4 RID: 66548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002386")]
		public static HashSet<GridPosition> handTiles
		{
			[Token(Token = "0x60103F4")]
			[Address(RVA = "0x7F67D0", Offset = "0x7F53D0", VA = "0x1807F67D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002387 RID: 9095
		// (get) Token: 0x060103F5 RID: 66549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002387")]
		public static HashSet<GridPosition> validHandTiles
		{
			[Token(Token = "0x60103F5")]
			[Address(RVA = "0x7F68B0", Offset = "0x7F54B0", VA = "0x1807F68B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002388 RID: 9096
		// (get) Token: 0x060103F6 RID: 66550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002388")]
		public static HashSet<GridPosition> battleFieldTiles
		{
			[Token(Token = "0x60103F6")]
			[Address(RVA = "0x7F66D0", Offset = "0x7F52D0", VA = "0x1807F66D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060103F7 RID: 66551 RVA: 0x00063318 File Offset: 0x00061518
		[Token(Token = "0x60103F7")]
		[Address(RVA = "0x7F5200", Offset = "0x7F3E00", VA = "0x1807F5200")]
		public static bool IsHand(GridPosition position)
		{
			return default(bool);
		}

		// Token: 0x060103F8 RID: 66552 RVA: 0x00063330 File Offset: 0x00061530
		[Token(Token = "0x60103F8")]
		[Address(RVA = "0x7F54A0", Offset = "0x7F40A0", VA = "0x1807F54A0")]
		public static bool IsValidHand(GridPosition position)
		{
			return default(bool);
		}

		// Token: 0x060103F9 RID: 66553 RVA: 0x00063348 File Offset: 0x00061548
		[Token(Token = "0x60103F9")]
		[Address(RVA = "0x7F4B10", Offset = "0x7F3710", VA = "0x1807F4B10")]
		public static bool IsBattleField(GridPosition position)
		{
			return default(bool);
		}

		// Token: 0x060103FA RID: 66554 RVA: 0x00063360 File Offset: 0x00061560
		[Token(Token = "0x60103FA")]
		[Address(RVA = "0x7F5160", Offset = "0x7F3D60", VA = "0x1807F5160")]
		public static bool IsHand(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x060103FB RID: 66555 RVA: 0x00063378 File Offset: 0x00061578
		[Token(Token = "0x60103FB")]
		[Address(RVA = "0x7F5540", Offset = "0x7F4140", VA = "0x1807F5540")]
		public static bool IsValidHand(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x060103FC RID: 66556 RVA: 0x00063390 File Offset: 0x00061590
		[Token(Token = "0x60103FC")]
		[Address(RVA = "0x7F4BA0", Offset = "0x7F37A0", VA = "0x1807F4BA0")]
		public static bool IsBattleField(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x060103FD RID: 66557 RVA: 0x000633A8 File Offset: 0x000615A8
		[Token(Token = "0x60103FD")]
		[Address(RVA = "0x7F52E0", Offset = "0x7F3EE0", VA = "0x1807F52E0")]
		public static bool IsLeftPlayer(GridPosition position)
		{
			return default(bool);
		}

		// Token: 0x060103FE RID: 66558 RVA: 0x000633C0 File Offset: 0x000615C0
		[Token(Token = "0x60103FE")]
		[Address(RVA = "0x7F5440", Offset = "0x7F4040", VA = "0x1807F5440")]
		public static bool IsRightPlayer(GridPosition position)
		{
			return default(bool);
		}

		// Token: 0x060103FF RID: 66559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60103FF")]
		[Address(RVA = "0x7F4340", Offset = "0x7F2F40", VA = "0x1807F4340")]
		public static Tile GetTileByPosition(int position)
		{
			return null;
		}

		// Token: 0x06010400 RID: 66560 RVA: 0x000633D8 File Offset: 0x000615D8
		[Token(Token = "0x6010400")]
		[Address(RVA = "0x7F1A10", Offset = "0x7F0610", VA = "0x1807F1A10")]
		public static int GetBattlePlayerIndexByPosition(GridPosition position)
		{
			return 0;
		}

		// Token: 0x06010401 RID: 66561 RVA: 0x000633F0 File Offset: 0x000615F0
		[Token(Token = "0x6010401")]
		[Address(RVA = "0x7F5650", Offset = "0x7F4250", VA = "0x1807F5650")]
		public static BattleEnemyKilledInfo TakeKilledInfoSnapShot(int enemyInstId)
		{
			return default(BattleEnemyKilledInfo);
		}

		// Token: 0x06010402 RID: 66562 RVA: 0x00063408 File Offset: 0x00061608
		[Token(Token = "0x6010402")]
		[Address(RVA = "0x7F3B70", Offset = "0x7F2770", VA = "0x1807F3B70")]
		public static int GetEnemyKilledByPlayer(BattleEnemyKilledInfo killedInfo, Enemy enemy)
		{
			return 0;
		}

		// Token: 0x06010403 RID: 66563 RVA: 0x00063420 File Offset: 0x00061620
		[Token(Token = "0x6010403")]
		[Address(RVA = "0x7F63C0", Offset = "0x7F4FC0", VA = "0x1807F63C0")]
		private static GridPosition _FetchContextPosition()
		{
			return default(GridPosition);
		}

		// Token: 0x06010404 RID: 66564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010404")]
		[Address(RVA = "0x7F1330", Offset = "0x7EFF30", VA = "0x1807F1330")]
		public static Character CreateDummy(BattleCharacterData data)
		{
			return null;
		}

		// Token: 0x06010405 RID: 66565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010405")]
		[Address(RVA = "0x7F0F40", Offset = "0x7EFB40", VA = "0x1807F0F40")]
		public static Character CreateDummy(string chessId, bool isToken, int instId = -1)
		{
			return null;
		}

		// Token: 0x06010406 RID: 66566 RVA: 0x00063438 File Offset: 0x00061638
		[Token(Token = "0x6010406")]
		[Address(RVA = "0x7F52A0", Offset = "0x7F3EA0", VA = "0x1807F52A0")]
		public static bool IsHost(BattleCharacterData data)
		{
			return default(bool);
		}

		// Token: 0x06010407 RID: 66567 RVA: 0x00063450 File Offset: 0x00061650
		[Token(Token = "0x6010407")]
		[Address(RVA = "0x7F4ED0", Offset = "0x7F3AD0", VA = "0x1807F4ED0")]
		public static bool IsCharacterRelatedToken(Character character)
		{
			return default(bool);
		}

		// Token: 0x06010408 RID: 66568 RVA: 0x00063468 File Offset: 0x00061668
		[Token(Token = "0x6010408")]
		[Address(RVA = "0x7F4F80", Offset = "0x7F3B80", VA = "0x1807F4F80")]
		public static bool IsChessIdHasRelatedTokenInPrepare(int instId)
		{
			return default(bool);
		}

		// Token: 0x06010409 RID: 66569 RVA: 0x00063480 File Offset: 0x00061680
		[Token(Token = "0x6010409")]
		[Address(RVA = "0x7F5970", Offset = "0x7F4570", VA = "0x1807F5970")]
		public static bool TryGetCharacterInstId(Character character, out int instId)
		{
			return default(bool);
		}

		// Token: 0x0601040A RID: 66570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601040A")]
		[Address(RVA = "0x7F3040", Offset = "0x7F1C40", VA = "0x1807F3040")]
		public static string GetCharacterChessId(Character character)
		{
			return null;
		}

		// Token: 0x0601040B RID: 66571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601040B")]
		[Address(RVA = "0x7F2FE0", Offset = "0x7F1BE0", VA = "0x1807F2FE0")]
		public static BattleCharacterData GetCharacterChessData(string chessId)
		{
			return null;
		}

		// Token: 0x0601040C RID: 66572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601040C")]
		[Address(RVA = "0x7F4450", Offset = "0x7F3050", VA = "0x1807F4450")]
		public static BattleCharacterData GetTokenChessData(string chessId)
		{
			return null;
		}

		// Token: 0x0601040D RID: 66573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601040D")]
		[Address(RVA = "0x7F3E00", Offset = "0x7F2A00", VA = "0x1807F3E00")]
		public static BattleCharacterData GetEquipChessData(string chessId)
		{
			return null;
		}

		// Token: 0x0601040E RID: 66574 RVA: 0x00063498 File Offset: 0x00061698
		[Token(Token = "0x601040E")]
		[Address(RVA = "0x7F3E60", Offset = "0x7F2A60", VA = "0x1807F3E60")]
		public static int GetEquipCntByCardUid(uint cardUid, bool checkIsGolden)
		{
			return 0;
		}

		// Token: 0x0601040F RID: 66575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601040F")]
		[Address(RVA = "0x7F4220", Offset = "0x7F2E20", VA = "0x1807F4220")]
		public static List<int> GetEquipInstIds(GridPosition pos)
		{
			return null;
		}

		// Token: 0x06010410 RID: 66576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010410")]
		[Address(RVA = "0x7F41A0", Offset = "0x7F2DA0", VA = "0x1807F41A0")]
		public static List<int> GetEquipInstIds(int instId)
		{
			return null;
		}

		// Token: 0x06010411 RID: 66577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010411")]
		[Address(RVA = "0x7F1710", Offset = "0x7F0310", VA = "0x1807F1710")]
		public static Deck.Card FindCard(uint cardUid)
		{
			return null;
		}

		// Token: 0x06010412 RID: 66578 RVA: 0x000634B0 File Offset: 0x000616B0
		[Token(Token = "0x6010412")]
		[Address(RVA = "0x7F4290", Offset = "0x7F2E90", VA = "0x1807F4290")]
		public static int GetInstIdByCardUid(uint cardUid)
		{
			return 0;
		}

		// Token: 0x06010413 RID: 66579 RVA: 0x000634C8 File Offset: 0x000616C8
		[Token(Token = "0x6010413")]
		[Address(RVA = "0x7F5910", Offset = "0x7F4510", VA = "0x1807F5910")]
		public static bool TryGetCardUidByInstId(int instId, bool isToken, out uint cardUid)
		{
			return default(bool);
		}

		// Token: 0x06010414 RID: 66580 RVA: 0x000634E0 File Offset: 0x000616E0
		[Token(Token = "0x6010414")]
		[Address(RVA = "0x7F44F0", Offset = "0x7F30F0", VA = "0x1807F44F0")]
		public static int GetTokenMaxDeployCnt(int instId)
		{
			return 0;
		}

		// Token: 0x06010415 RID: 66581 RVA: 0x000634F8 File Offset: 0x000616F8
		[Token(Token = "0x6010415")]
		[Address(RVA = "0x7F46D0", Offset = "0x7F32D0", VA = "0x1807F46D0")]
		public static int GetTokenRestCount(int instId)
		{
			return 0;
		}

		// Token: 0x06010416 RID: 66582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010416")]
		[Address(RVA = "0x7F2A50", Offset = "0x7F1650", VA = "0x1807F2A50")]
		public static List<string> GetCharBondIds(ChessInst chessInst)
		{
			return null;
		}

		// Token: 0x06010417 RID: 66583 RVA: 0x00063510 File Offset: 0x00061710
		[Token(Token = "0x6010417")]
		[Address(RVA = "0x7F5380", Offset = "0x7F3F80", VA = "0x1807F5380")]
		public static bool IsManiAffectedBond(string bondId)
		{
			return default(bool);
		}

		// Token: 0x06010418 RID: 66584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010418")]
		[Address(RVA = "0x7F2AB0", Offset = "0x7F16B0", VA = "0x1807F2AB0")]
		public static List<string> GetCharBondIds(Character character)
		{
			return null;
		}

		// Token: 0x06010419 RID: 66585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010419")]
		[Address(RVA = "0x7F3650", Offset = "0x7F2250", VA = "0x1807F3650")]
		public static List<string> GetChessIdsWithBond(string bondId, int playerIndex)
		{
			return null;
		}

		// Token: 0x0601041A RID: 66586 RVA: 0x00063528 File Offset: 0x00061728
		[Token(Token = "0x601041A")]
		[Address(RVA = "0x7F09B0", Offset = "0x7EF5B0", VA = "0x1807F09B0")]
		public static bool CheckIfCharBondActive(int playerIndex, string bondId, string checkChessId)
		{
			return default(bool);
		}

		// Token: 0x0601041B RID: 66587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601041B")]
		[Address(RVA = "0x7F2470", Offset = "0x7F1070", VA = "0x1807F2470")]
		public static ActAutoChessData.ActAutoChessBondInfo GetBondInfo(string bondId)
		{
			return null;
		}

		// Token: 0x0601041C RID: 66588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601041C")]
		[Address(RVA = "0x7F27B0", Offset = "0x7F13B0", VA = "0x1807F27B0")]
		public static void GetCharBondIdsSameRow(GridPosition pos, List<string> bondIds)
		{
		}

		// Token: 0x0601041D RID: 66589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601041D")]
		[Address(RVA = "0x7F2220", Offset = "0x7F0E20", VA = "0x1807F2220")]
		public static void GetBondIdsAllInhand(List<string> bondIds)
		{
		}

		// Token: 0x0601041E RID: 66590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601041E")]
		[Address(RVA = "0x7F1FB0", Offset = "0x7F0BB0", VA = "0x1807F1FB0")]
		public static void GetBondIdsAllInBattle(List<string> bondIds)
		{
		}

		// Token: 0x0601041F RID: 66591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601041F")]
		[Address(RVA = "0x7F2500", Offset = "0x7F1100", VA = "0x1807F2500")]
		public static void GetCharBondIdsSameCol(GridPosition pos, List<string> bondIds)
		{
		}

		// Token: 0x06010420 RID: 66592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010420")]
		[Address(RVA = "0x7F4A40", Offset = "0x7F3640", VA = "0x1807F4A40")]
		public static string GetTrapEffectCounterString(string chessId)
		{
			return null;
		}

		// Token: 0x06010421 RID: 66593 RVA: 0x00063540 File Offset: 0x00061740
		[Token(Token = "0x6010421")]
		[Address(RVA = "0x7F0850", Offset = "0x7EF450", VA = "0x1807F0850")]
		public static bool CheckCharChessCanComb(string chessId)
		{
			return default(bool);
		}

		// Token: 0x06010422 RID: 66594 RVA: 0x00063558 File Offset: 0x00061758
		[Token(Token = "0x6010422")]
		[Address(RVA = "0x7F4A80", Offset = "0x7F3680", VA = "0x1807F4A80")]
		public static bool HasSameChess(string chessId)
		{
			return default(bool);
		}

		// Token: 0x06010423 RID: 66595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010423")]
		[Address(RVA = "0x7F3830", Offset = "0x7F2430", VA = "0x1807F3830")]
		public static string GetChessNormalId(string chessId)
		{
			return null;
		}

		// Token: 0x06010424 RID: 66596 RVA: 0x00063570 File Offset: 0x00061770
		[Token(Token = "0x6010424")]
		[Address(RVA = "0x7F1460", Offset = "0x7F0060", VA = "0x1807F1460")]
		public static bool DestroyEntityToDummy(Entity entity, Entity.FinishReason reason)
		{
			return default(bool);
		}

		// Token: 0x06010425 RID: 66597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010425")]
		[Address(RVA = "0x7F5DC0", Offset = "0x7F49C0", VA = "0x1807F5DC0")]
		private static void _FadeDeadDummy(Character dummyCharacter)
		{
		}

		// Token: 0x06010426 RID: 66598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010426")]
		[Address(RVA = "0x7F0C80", Offset = "0x7EF880", VA = "0x1807F0C80")]
		public static void CollectPoolConfig(ref List<PoolManager.ObjectConfig> configs, ChessSquad config)
		{
		}

		// Token: 0x06010427 RID: 66599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010427")]
		[Address(RVA = "0x7F39E0", Offset = "0x7F25E0", VA = "0x1807F39E0")]
		public static string GetEnemyIdFromEffectId(string effectId)
		{
			return null;
		}

		// Token: 0x06010428 RID: 66600 RVA: 0x00063588 File Offset: 0x00061788
		[Token(Token = "0x6010428")]
		[Address(RVA = "0x7F4CB0", Offset = "0x7F38B0", VA = "0x1807F4CB0")]
		public static bool IsBossEnemy(string enemyKey)
		{
			return default(bool);
		}

		// Token: 0x06010429 RID: 66601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010429")]
		[Address(RVA = "0x7F1B20", Offset = "0x7F0720", VA = "0x1807F1B20")]
		public static string GetBondDesc(string bondId, int stack)
		{
			return null;
		}

		// Token: 0x0601042A RID: 66602 RVA: 0x000635A0 File Offset: 0x000617A0
		[Token(Token = "0x601042A")]
		[Address(RVA = "0x7F0BC0", Offset = "0x7EF7C0", VA = "0x1807F0BC0")]
		public static bool CheckIfDisplayChess(ActAutoChessData actData, string chessId)
		{
			return default(bool);
		}

		// Token: 0x0601042B RID: 66603 RVA: 0x000635B8 File Offset: 0x000617B8
		[Token(Token = "0x601042B")]
		[Address(RVA = "0x7F5CF0", Offset = "0x7F48F0", VA = "0x1807F5CF0")]
		public static bool TryGetPlayerIndexByUid(uint uid, out int resultPlayerIndex)
		{
			return default(bool);
		}

		// Token: 0x0601042C RID: 66604 RVA: 0x000635D0 File Offset: 0x000617D0
		[Token(Token = "0x601042C")]
		[Address(RVA = "0x7F1B10", Offset = "0x7F0710", VA = "0x1807F1B10")]
		public static PlayerSide GetBattlePlayerSide(bool isRightPlayer)
		{
			return PlayerSide.DEFAULT;
		}
	}
}
