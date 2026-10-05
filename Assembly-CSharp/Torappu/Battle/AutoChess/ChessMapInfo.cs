using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.DataCenter;
using XLua;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002776 RID: 10102
	[Token(Token = "0x2002776")]
	public class ChessMapInfo : AutoChessDataCenter.AutoChessDataModelBase
	{
		// Token: 0x170023F3 RID: 9203
		// (get) Token: 0x060107BD RID: 67517 RVA: 0x000646C8 File Offset: 0x000628C8
		[Token(Token = "0x170023F3")]
		public int chessCountInHand
		{
			[Token(Token = "0x60107BD")]
			[Address(RVA = "0x8535F0", Offset = "0x8521F0", VA = "0x1808535F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170023F4 RID: 9204
		// (get) Token: 0x060107BE RID: 67518 RVA: 0x000646E0 File Offset: 0x000628E0
		[Token(Token = "0x170023F4")]
		public int charCountInBattle
		{
			[Token(Token = "0x60107BE")]
			[Address(RVA = "0x8533E0", Offset = "0x851FE0", VA = "0x1808533E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060107BF RID: 67519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107BF")]
		[Address(RVA = "0x851CA0", Offset = "0x8508A0", VA = "0x180851CA0")]
		public void ReqChangePositionInBattle(GridPosition oldPos, GridPosition newPos)
		{
		}

		// Token: 0x060107C0 RID: 67520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107C0")]
		[Address(RVA = "0x851E30", Offset = "0x850A30", VA = "0x180851E30")]
		public void SendTokenToValidHand(int instId, bool removeOrigin = true)
		{
		}

		// Token: 0x060107C1 RID: 67521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107C1")]
		[Address(RVA = "0x8522F0", Offset = "0x850EF0", VA = "0x1808522F0")]
		public void UpdateData(PlayerBattleData data)
		{
		}

		// Token: 0x060107C2 RID: 67522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107C2")]
		[Address(RVA = "0x852960", Offset = "0x851560", VA = "0x180852960")]
		private void _CheckSelfNewGainedChess()
		{
		}

		// Token: 0x060107C3 RID: 67523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107C3")]
		[Address(RVA = "0x8530F0", Offset = "0x851CF0", VA = "0x1808530F0")]
		private void _OnSelfGainedNewChess(ChessInst chessInst)
		{
		}

		// Token: 0x060107C4 RID: 67524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107C4")]
		[Address(RVA = "0x852EF0", Offset = "0x851AF0", VA = "0x180852EF0")]
		private void _FromPositionInfos(List<ChessPositionInfo> chessPositionInfos)
		{
		}

		// Token: 0x060107C5 RID: 67525 RVA: 0x000646F8 File Offset: 0x000628F8
		[Token(Token = "0x60107C5")]
		[Address(RVA = "0x8524E0", Offset = "0x8510E0", VA = "0x1808524E0")]
		private bool _CheckNoPositionChess(PlayerBattleData data)
		{
			return default(bool);
		}

		// Token: 0x060107C6 RID: 67526 RVA: 0x00064710 File Offset: 0x00062910
		[Token(Token = "0x60107C6")]
		[Address(RVA = "0x852410", Offset = "0x851010", VA = "0x180852410")]
		private bool _AddNoPositionChess(int instId, AutoChessItemType itemType)
		{
			return default(bool);
		}

		// Token: 0x060107C7 RID: 67527 RVA: 0x00064728 File Offset: 0x00062928
		[Token(Token = "0x60107C7")]
		[Address(RVA = "0x8518A0", Offset = "0x8504A0", VA = "0x1808518A0")]
		public bool RemoveAllInstIdRelatedToken(int instId)
		{
			return default(bool);
		}

		// Token: 0x060107C8 RID: 67528 RVA: 0x00064740 File Offset: 0x00062940
		[Token(Token = "0x60107C8")]
		[Address(RVA = "0x851280", Offset = "0x84FE80", VA = "0x180851280")]
		public bool OptimizeHandMap()
		{
			return default(bool);
		}

		// Token: 0x060107C9 RID: 67529 RVA: 0x00064758 File Offset: 0x00062958
		[Token(Token = "0x60107C9")]
		[Address(RVA = "0x850F40", Offset = "0x84FB40", VA = "0x180850F40")]
		public GridPosition GetFirstEmptyHand()
		{
			return default(GridPosition);
		}

		// Token: 0x060107CA RID: 67530 RVA: 0x00064770 File Offset: 0x00062970
		[Token(Token = "0x60107CA")]
		[Address(RVA = "0x850CB0", Offset = "0x84F8B0", VA = "0x180850CB0")]
		public bool AddChessInst(GridPosition pos, int instId, SharedConsts.Direction direction, AutoChessItemType chessType)
		{
			return default(bool);
		}

		// Token: 0x060107CB RID: 67531 RVA: 0x00064788 File Offset: 0x00062988
		[Token(Token = "0x60107CB")]
		[Address(RVA = "0x851BE0", Offset = "0x8507E0", VA = "0x180851BE0")]
		public bool RemoveChessInst(GridPosition pos)
		{
			return default(bool);
		}

		// Token: 0x060107CC RID: 67532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60107CC")]
		[Address(RVA = "0x853250", Offset = "0x851E50", VA = "0x180853250")]
		public ChessMapInfo()
		{
		}

		// Token: 0x04012796 RID: 75670
		[Token(Token = "0x4012796")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<int, ChessInst> chessInstMap;

		// Token: 0x04012797 RID: 75671
		[Token(Token = "0x4012797")]
		[FieldOffset(Offset = "0x20")]
		private HashSet<int> m_sharedNeedRemoveSet;

		// Token: 0x04012798 RID: 75672
		[Token(Token = "0x4012798")]
		[FieldOffset(Offset = "0x28")]
		private List<int> m_cachedInsts;

		// Token: 0x04012799 RID: 75673
		[Token(Token = "0x4012799")]
		[FieldOffset(Offset = "0x30")]
		private HashSet<int> m_cachedSelfMapInstIds;

		// Token: 0x0401279A RID: 75674
		[Token(Token = "0x401279A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_chessCountInHand;

		// Token: 0x0401279B RID: 75675
		[Token(Token = "0x401279B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_charCountInBattle;

		// Token: 0x0401279C RID: 75676
		[Token(Token = "0x401279C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ReqChangePositionInBattle;

		// Token: 0x0401279D RID: 75677
		[Token(Token = "0x401279D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SendTokenToValidHand;

		// Token: 0x0401279E RID: 75678
		[Token(Token = "0x401279E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0401279F RID: 75679
		[Token(Token = "0x401279F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CheckSelfNewGainedChess;

		// Token: 0x040127A0 RID: 75680
		[Token(Token = "0x40127A0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnSelfGainedNewChess;

		// Token: 0x040127A1 RID: 75681
		[Token(Token = "0x40127A1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__FromPositionInfos;

		// Token: 0x040127A2 RID: 75682
		[Token(Token = "0x40127A2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CheckNoPositionChess;

		// Token: 0x040127A3 RID: 75683
		[Token(Token = "0x40127A3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__AddNoPositionChess;

		// Token: 0x040127A4 RID: 75684
		[Token(Token = "0x40127A4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_RemoveAllInstIdRelatedToken;

		// Token: 0x040127A5 RID: 75685
		[Token(Token = "0x40127A5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OptimizeHandMap;

		// Token: 0x040127A6 RID: 75686
		[Token(Token = "0x40127A6")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetFirstEmptyHand;

		// Token: 0x040127A7 RID: 75687
		[Token(Token = "0x40127A7")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_AddChessInst;

		// Token: 0x040127A8 RID: 75688
		[Token(Token = "0x40127A8")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_RemoveChessInst;

		// Token: 0x040127A9 RID: 75689
		[Token(Token = "0x40127A9")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
