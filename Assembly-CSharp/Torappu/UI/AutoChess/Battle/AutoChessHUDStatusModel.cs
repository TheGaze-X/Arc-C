using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using Torappu.Battle.DataCenter;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064CB RID: 25803
	[Token(Token = "0x20064CB")]
	public class AutoChessHUDStatusModel : IHotfixable
	{
		// Token: 0x17005779 RID: 22393
		// (get) Token: 0x06025140 RID: 151872 RVA: 0x000C65B8 File Offset: 0x000C47B8
		[Token(Token = "0x17005779")]
		public bool displayBondBar
		{
			[Token(Token = "0x6025140")]
			[Address(RVA = "0x1FEFBF0", Offset = "0x1FEE7F0", VA = "0x181FEFBF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700577A RID: 22394
		// (get) Token: 0x06025141 RID: 151873 RVA: 0x000C65D0 File Offset: 0x000C47D0
		[Token(Token = "0x1700577A")]
		public bool isBondCultivating
		{
			[Token(Token = "0x6025141")]
			[Address(RVA = "0x1FEFE60", Offset = "0x1FEEA60", VA = "0x181FEFE60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700577B RID: 22395
		// (get) Token: 0x06025142 RID: 151874 RVA: 0x000C65E8 File Offset: 0x000C47E8
		[Token(Token = "0x1700577B")]
		public bool hasPrev
		{
			[Token(Token = "0x6025142")]
			[Address(RVA = "0x1FEFDB0", Offset = "0x1FEE9B0", VA = "0x181FEFDB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700577C RID: 22396
		// (get) Token: 0x06025143 RID: 151875 RVA: 0x000C6600 File Offset: 0x000C4800
		[Token(Token = "0x1700577C")]
		public bool hasNext
		{
			[Token(Token = "0x6025143")]
			[Address(RVA = "0x1FEFCE0", Offset = "0x1FEE8E0", VA = "0x181FEFCE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700577D RID: 22397
		// (get) Token: 0x06025144 RID: 151876 RVA: 0x000C6618 File Offset: 0x000C4818
		[Token(Token = "0x1700577D")]
		public bool displayInfoBtn
		{
			[Token(Token = "0x6025144")]
			[Address(RVA = "0x1FEFC70", Offset = "0x1FEE870", VA = "0x181FEFC70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700577E RID: 22398
		// (get) Token: 0x06025145 RID: 151877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700577E")]
		public AutoChessBondItemModel selectedBondModel
		{
			[Token(Token = "0x6025145")]
			[Address(RVA = "0x1FEFF80", Offset = "0x1FEEB80", VA = "0x181FEFF80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700577F RID: 22399
		// (get) Token: 0x06025146 RID: 151878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700577F")]
		public string selectedBondId
		{
			[Token(Token = "0x6025146")]
			[Address(RVA = "0x1FEFEC0", Offset = "0x1FEEAC0", VA = "0x181FEFEC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005780 RID: 22400
		// (get) Token: 0x06025147 RID: 151879 RVA: 0x000C6630 File Offset: 0x000C4830
		// (set) Token: 0x06025148 RID: 151880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005780")]
		public int selectedBondIdx
		{
			[Token(Token = "0x6025147")]
			[Address(RVA = "0x1FEFF20", Offset = "0x1FEEB20", VA = "0x181FEFF20")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6025148")]
			[Address(RVA = "0x1FF0050", Offset = "0x1FEEC50", VA = "0x181FF0050")]
			set
			{
			}
		}

		// Token: 0x06025149 RID: 151881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025149")]
		[Address(RVA = "0x1FEF190", Offset = "0x1FEDD90", VA = "0x181FEF190")]
		public void UpdateData(AutoChessBattleUIViewModel viewModel, AutoChessDataCenter dataCenter, AutoChessBattleUIHUDModel hudModel)
		{
		}

		// Token: 0x0602514A RID: 151882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602514A")]
		[Address(RVA = "0x1FEEF90", Offset = "0x1FEDB90", VA = "0x181FEEF90")]
		public void ReqBondDisplay(bool tgtExpand)
		{
		}

		// Token: 0x0602514B RID: 151883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602514B")]
		[Address(RVA = "0x1FEF010", Offset = "0x1FEDC10", VA = "0x181FEF010")]
		public void SetSelectedBondId(string bondId)
		{
		}

		// Token: 0x0602514C RID: 151884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602514C")]
		[Address(RVA = "0x1FEEED0", Offset = "0x1FEDAD0", VA = "0x181FEEED0")]
		public void MovePrev()
		{
		}

		// Token: 0x0602514D RID: 151885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602514D")]
		[Address(RVA = "0x1FEEE10", Offset = "0x1FEDA10", VA = "0x181FEEE10")]
		public void MoveNext()
		{
		}

		// Token: 0x0602514E RID: 151886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602514E")]
		[Address(RVA = "0x1FEF550", Offset = "0x1FEE150", VA = "0x181FEF550")]
		private void _SetSelectedBondIdx(int idx)
		{
		}

		// Token: 0x0602514F RID: 151887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602514F")]
		[Address(RVA = "0x1FEF740", Offset = "0x1FEE340", VA = "0x181FEF740")]
		private void _UpdateBondModels(AutoChessBattleUIHUDModel hudModel)
		{
		}

		// Token: 0x06025150 RID: 151888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025150")]
		[Address(RVA = "0x1FEF390", Offset = "0x1FEDF90", VA = "0x181FEF390")]
		private void _RefreshSelection(AutoChessBattleUIViewModel viewModel)
		{
		}

		// Token: 0x06025151 RID: 151889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025151")]
		[Address(RVA = "0x1FEF800", Offset = "0x1FEE400", VA = "0x181FEF800")]
		private void _UpdateGameStatus(AutoChessBattleUIViewModel viewModel, AutoChessDataCenter dataCenter)
		{
		}

		// Token: 0x06025152 RID: 151890 RVA: 0x000C6648 File Offset: 0x000C4848
		[Token(Token = "0x6025152")]
		[Address(RVA = "0x1FEF2E0", Offset = "0x1FEDEE0", VA = "0x181FEF2E0")]
		private AutoChessHUDStatus _CalcStatus(AutoChessGameStateType statusState)
		{
			return AutoChessHUDStatus.REST;
		}

		// Token: 0x06025153 RID: 151891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025153")]
		[Address(RVA = "0x1FEF610", Offset = "0x1FEE210", VA = "0x181FEF610")]
		private void _SyncBattleFinish(AutoChessBattleUIViewModel viewModel)
		{
		}

		// Token: 0x06025154 RID: 151892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025154")]
		[Address(RVA = "0x1FEFA80", Offset = "0x1FEE680", VA = "0x181FEFA80")]
		public AutoChessHUDStatusModel()
		{
		}

		// Token: 0x04033EE2 RID: 212706
		[Token(Token = "0x4033EE2")]
		private const int INVALID_IDX = -1;

		// Token: 0x04033EE3 RID: 212707
		[Token(Token = "0x4033EE3")]
		[FieldOffset(Offset = "0x10")]
		public AutoChessHUDStatus status;

		// Token: 0x04033EE4 RID: 212708
		[Token(Token = "0x4033EE4")]
		[FieldOffset(Offset = "0x14")]
		public bool isInBossRound;

		// Token: 0x04033EE5 RID: 212709
		[Token(Token = "0x4033EE5")]
		[FieldOffset(Offset = "0x15")]
		public bool expandBondBar;

		// Token: 0x04033EE6 RID: 212710
		[Token(Token = "0x4033EE6")]
		[FieldOffset(Offset = "0x18")]
		public int loadSeqNum;

		// Token: 0x04033EE7 RID: 212711
		[Token(Token = "0x4033EE7")]
		[FieldOffset(Offset = "0x1C")]
		public SeqNumSource statusSeqNum;

		// Token: 0x04033EE8 RID: 212712
		[Token(Token = "0x4033EE8")]
		[FieldOffset(Offset = "0x28")]
		public SeqNumSource resetSeqNum;

		// Token: 0x04033EE9 RID: 212713
		[Token(Token = "0x4033EE9")]
		[FieldOffset(Offset = "0x34")]
		public SeqNumSource battleFinishSeqNum;

		// Token: 0x04033EEA RID: 212714
		[Token(Token = "0x4033EEA")]
		[FieldOffset(Offset = "0x40")]
		public SeqNumSource otherBattleFinishSeqNum;

		// Token: 0x04033EEB RID: 212715
		[Token(Token = "0x4033EEB")]
		[FieldOffset(Offset = "0x4C")]
		public int viewPlayerLostResult;

		// Token: 0x04033EEC RID: 212716
		[Token(Token = "0x4033EEC")]
		[FieldOffset(Offset = "0x50")]
		public bool isAllPerfect;

		// Token: 0x04033EED RID: 212717
		[Token(Token = "0x4033EED")]
		[FieldOffset(Offset = "0x54")]
		private AutoChessGameStateType m_gameState;

		// Token: 0x04033EEE RID: 212718
		[Token(Token = "0x4033EEE")]
		[FieldOffset(Offset = "0x58")]
		private AutoChessGameStatus.SubState m_subStatusState;

		// Token: 0x04033EEF RID: 212719
		[Token(Token = "0x4033EEF")]
		[FieldOffset(Offset = "0x5C")]
		private int m_selectedBondIdx;

		// Token: 0x04033EF0 RID: 212720
		[Token(Token = "0x4033EF0")]
		[FieldOffset(Offset = "0x60")]
		private string m_selectedBondId;

		// Token: 0x04033EF1 RID: 212721
		[Token(Token = "0x4033EF1")]
		[FieldOffset(Offset = "0x68")]
		private List<AutoChessBondItemModel> m_cachedBondModels;

		// Token: 0x04033EF2 RID: 212722
		[Token(Token = "0x4033EF2")]
		[FieldOffset(Offset = "0x70")]
		private bool m_bondInited;

		// Token: 0x04033EF3 RID: 212723
		[Token(Token = "0x4033EF3")]
		[FieldOffset(Offset = "0x78")]
		private AutoChessGameStatus.GameStateChecker m_stateChecker;

		// Token: 0x04033EF4 RID: 212724
		[Token(Token = "0x4033EF4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_displayBondBar;

		// Token: 0x04033EF5 RID: 212725
		[Token(Token = "0x4033EF5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isBondCultivating;

		// Token: 0x04033EF6 RID: 212726
		[Token(Token = "0x4033EF6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_hasPrev;

		// Token: 0x04033EF7 RID: 212727
		[Token(Token = "0x4033EF7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_hasNext;

		// Token: 0x04033EF8 RID: 212728
		[Token(Token = "0x4033EF8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_displayInfoBtn;

		// Token: 0x04033EF9 RID: 212729
		[Token(Token = "0x4033EF9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_selectedBondModel;

		// Token: 0x04033EFA RID: 212730
		[Token(Token = "0x4033EFA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_selectedBondId;

		// Token: 0x04033EFB RID: 212731
		[Token(Token = "0x4033EFB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_selectedBondIdx;

		// Token: 0x04033EFC RID: 212732
		[Token(Token = "0x4033EFC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_selectedBondIdx;

		// Token: 0x04033EFD RID: 212733
		[Token(Token = "0x4033EFD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04033EFE RID: 212734
		[Token(Token = "0x4033EFE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ReqBondDisplay;

		// Token: 0x04033EFF RID: 212735
		[Token(Token = "0x4033EFF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SetSelectedBondId;

		// Token: 0x04033F00 RID: 212736
		[Token(Token = "0x4033F00")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_MovePrev;

		// Token: 0x04033F01 RID: 212737
		[Token(Token = "0x4033F01")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_MoveNext;

		// Token: 0x04033F02 RID: 212738
		[Token(Token = "0x4033F02")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__SetSelectedBondIdx;

		// Token: 0x04033F03 RID: 212739
		[Token(Token = "0x4033F03")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__UpdateBondModels;

		// Token: 0x04033F04 RID: 212740
		[Token(Token = "0x4033F04")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__RefreshSelection;

		// Token: 0x04033F05 RID: 212741
		[Token(Token = "0x4033F05")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__UpdateGameStatus;

		// Token: 0x04033F06 RID: 212742
		[Token(Token = "0x4033F06")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__CalcStatus;

		// Token: 0x04033F07 RID: 212743
		[Token(Token = "0x4033F07")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__SyncBattleFinish;

		// Token: 0x04033F08 RID: 212744
		[Token(Token = "0x4033F08")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
