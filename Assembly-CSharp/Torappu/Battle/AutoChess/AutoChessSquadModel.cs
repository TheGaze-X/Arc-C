using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using XLua;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002788 RID: 10120
	[Token(Token = "0x2002788")]
	public class AutoChessSquadModel : IHotfixable
	{
		// Token: 0x0601082F RID: 67631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601082F")]
		[Address(RVA = "0x84E940", Offset = "0x84D540", VA = "0x18084E940")]
		public Dictionary<string, ChessSquad> EnsureChessSquadDB(int playerIndex)
		{
			return null;
		}

		// Token: 0x06010830 RID: 67632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010830")]
		[Address(RVA = "0x84ED70", Offset = "0x84D970", VA = "0x18084ED70")]
		public ChessSquad GetChessSquad(string chessId, int playerIndex)
		{
			return null;
		}

		// Token: 0x06010831 RID: 67633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010831")]
		[Address(RVA = "0x84F390", Offset = "0x84DF90", VA = "0x18084F390")]
		private void _GatherTrapConfig(Dictionary<string, ChessSquad> chessSquadDB)
		{
		}

		// Token: 0x06010832 RID: 67634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010832")]
		[Address(RVA = "0x84F060", Offset = "0x84DC60", VA = "0x18084F060")]
		private void _GatherSquadsViaPlayer(Dictionary<string, ChessSquad> chessSquadDB, List<SquadSlot> squadSlots)
		{
		}

		// Token: 0x06010833 RID: 67635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010833")]
		[Address(RVA = "0x84FEC0", Offset = "0x84EAC0", VA = "0x18084FEC0")]
		private ActAutoChessData.ActAutoChessShopCharChessInfoData _GetLevelStatus(int shopLevel, bool isGolden)
		{
			return null;
		}

		// Token: 0x06010834 RID: 67636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010834")]
		[Address(RVA = "0x84F870", Offset = "0x84E470", VA = "0x18084F870")]
		private ChessSquad _GetChessSquadConfig(string chessId, ActAutoChessData.ActAutoChessCharShopChessData shopChessData, SquadSlot slot, bool isGolden)
		{
			return null;
		}

		// Token: 0x06010835 RID: 67637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010835")]
		[Address(RVA = "0x84EE60", Offset = "0x84DA60", VA = "0x18084EE60")]
		private static void _AppendUniequip(string equipKey, ActAutoChessData.ActAutoChessShopCharChessInfoData levelStatus, AdvancedCharacterInst inst)
		{
		}

		// Token: 0x06010836 RID: 67638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010836")]
		[Address(RVA = "0x84FFC0", Offset = "0x84EBC0", VA = "0x18084FFC0")]
		public AutoChessSquadModel()
		{
		}

		// Token: 0x04012869 RID: 75881
		[Token(Token = "0x4012869")]
		[FieldOffset(Offset = "0x10")]
		private ActAutoChessData m_actData;

		// Token: 0x0401286A RID: 75882
		[Token(Token = "0x401286A")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<int, Dictionary<string, ChessSquad>> m_chessSquadDB;

		// Token: 0x0401286B RID: 75883
		[Token(Token = "0x401286B")]
		[FieldOffset(Offset = "0x20")]
		public List<PoolManager.ObjectConfig> chessPoolConfigs;

		// Token: 0x0401286C RID: 75884
		[Token(Token = "0x401286C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EnsureChessSquadDB;

		// Token: 0x0401286D RID: 75885
		[Token(Token = "0x401286D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetChessSquad;

		// Token: 0x0401286E RID: 75886
		[Token(Token = "0x401286E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GatherTrapConfig;

		// Token: 0x0401286F RID: 75887
		[Token(Token = "0x401286F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GatherSquadsViaPlayer;

		// Token: 0x04012870 RID: 75888
		[Token(Token = "0x4012870")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetLevelStatus;

		// Token: 0x04012871 RID: 75889
		[Token(Token = "0x4012871")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetChessSquadConfig;

		// Token: 0x04012872 RID: 75890
		[Token(Token = "0x4012872")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__AppendUniequip;

		// Token: 0x04012873 RID: 75891
		[Token(Token = "0x4012873")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
