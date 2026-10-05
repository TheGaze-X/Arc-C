using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064C6 RID: 25798
	[Token(Token = "0x20064C6")]
	public class AutoChessBattleUIHUDInfoPanel : AutoChessBattleUIPanelBase, ICompDialogCallBack
	{
		// Token: 0x0602512F RID: 151855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602512F")]
		[Address(RVA = "0x1FE99E0", Offset = "0x1FE85E0", VA = "0x181FE99E0", Slot = "8")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x06025130 RID: 151856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025130")]
		[Address(RVA = "0x1FE9B00", Offset = "0x1FE8700", VA = "0x181FE9B00", Slot = "7")]
		public override void OnValueChanged(AutoChessBattleUIViewModelProperty property)
		{
		}

		// Token: 0x06025131 RID: 151857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025131")]
		[Address(RVA = "0x1FE9A70", Offset = "0x1FE8670", VA = "0x181FE9A70")]
		public void OnHUDReset()
		{
		}

		// Token: 0x06025132 RID: 151858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025132")]
		[Address(RVA = "0x1FE9E90", Offset = "0x1FE8A90", VA = "0x181FE9E90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025133 RID: 151859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025133")]
		[Address(RVA = "0x1FEA100", Offset = "0x1FE8D00", VA = "0x181FEA100")]
		private void _InitTabModelList()
		{
		}

		// Token: 0x06025134 RID: 151860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025134")]
		[Address(RVA = "0x1FEA3F0", Offset = "0x1FE8FF0", VA = "0x181FEA3F0")]
		private void _PlayEnterAnim()
		{
		}

		// Token: 0x06025135 RID: 151861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025135")]
		[Address(RVA = "0x1FEA4F0", Offset = "0x1FE90F0", VA = "0x181FEA4F0")]
		private void _SelectTabPagerTab(AutoChessGameStatus.AutoChessHUDTipDisplay display, bool inEnemyPreview)
		{
		}

		// Token: 0x06025136 RID: 151862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025136")]
		[Address(RVA = "0x1FEA630", Offset = "0x1FE9230", VA = "0x181FEA630")]
		public AutoChessBattleUIHUDInfoPanel()
		{
		}

		// Token: 0x04033EBC RID: 212668
		[Token(Token = "0x4033EBC")]
		private const string TAB_BOND_DETAIL = "tab_bond_detail";

		// Token: 0x04033EBD RID: 212669
		[Token(Token = "0x4033EBD")]
		private const string TAB_PLAYER_INFO = "tab_player_info";

		// Token: 0x04033EBE RID: 212670
		[Token(Token = "0x4033EBE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04033EBF RID: 212671
		[Token(Token = "0x4033EBF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AutoChessBattleUIPlayerInfoView _playerInfoView;

		// Token: 0x04033EC0 RID: 212672
		[Token(Token = "0x4033EC0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AutoChessBattleUIBondInfoView _bondInfoView;

		// Token: 0x04033EC1 RID: 212673
		[Token(Token = "0x4033EC1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UITabPager _tabPager;

		// Token: 0x04033EC2 RID: 212674
		[Token(Token = "0x4033EC2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _blockerObj;

		// Token: 0x04033EC3 RID: 212675
		[Token(Token = "0x4033EC3")]
		[FieldOffset(Offset = "0x50")]
		private bool m_inited;

		// Token: 0x04033EC4 RID: 212676
		[Token(Token = "0x4033EC4")]
		[FieldOffset(Offset = "0x58")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04033EC5 RID: 212677
		[Token(Token = "0x4033EC5")]
		[FieldOffset(Offset = "0x68")]
		private SeqNumSource.Checker m_resetChecker;

		// Token: 0x04033EC6 RID: 212678
		[Token(Token = "0x4033EC6")]
		[FieldOffset(Offset = "0x70")]
		private int m_loadSeqNum;

		// Token: 0x04033EC7 RID: 212679
		[Token(Token = "0x4033EC7")]
		[FieldOffset(Offset = "0x78")]
		private Tween m_enterTween;

		// Token: 0x04033EC8 RID: 212680
		[Token(Token = "0x4033EC8")]
		[FieldOffset(Offset = "0x80")]
		private UITabPager.Core m_tabPagerCore;

		// Token: 0x04033EC9 RID: 212681
		[Token(Token = "0x4033EC9")]
		[FieldOffset(Offset = "0x88")]
		private List<UITabPager.TabPageViewModel> m_tabPageModelList;

		// Token: 0x04033ECA RID: 212682
		[Token(Token = "0x4033ECA")]
		[FieldOffset(Offset = "0x90")]
		private AutoChessBattleUIViewModelProperty m_prop;

		// Token: 0x04033ECB RID: 212683
		[Token(Token = "0x4033ECB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x04033ECC RID: 212684
		[Token(Token = "0x4033ECC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04033ECD RID: 212685
		[Token(Token = "0x4033ECD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnHUDReset;

		// Token: 0x04033ECE RID: 212686
		[Token(Token = "0x4033ECE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04033ECF RID: 212687
		[Token(Token = "0x4033ECF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitTabModelList;

		// Token: 0x04033ED0 RID: 212688
		[Token(Token = "0x4033ED0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlayEnterAnim;

		// Token: 0x04033ED1 RID: 212689
		[Token(Token = "0x4033ED1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SelectTabPagerTab;

		// Token: 0x04033ED2 RID: 212690
		[Token(Token = "0x4033ED2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020064C7 RID: 25799
		[Token(Token = "0x20064C7")]
		private class TabDataSource : UITabPager.TabDataSource
		{
			// Token: 0x06025137 RID: 151863 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025137")]
			[Address(RVA = "0x1FF14F0", Offset = "0x1FF00F0", VA = "0x181FF14F0")]
			public TabDataSource(AutoChessBattleUIHUDInfoPanel closure)
			{
			}

			// Token: 0x06025138 RID: 151864 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6025138")]
			[Address(RVA = "0x1FF1450", Offset = "0x1FF0050", VA = "0x181FF1450", Slot = "5")]
			public override UITabPager.TabPageViewModel GetTab(int index)
			{
				return null;
			}

			// Token: 0x06025139 RID: 151865 RVA: 0x000C65A0 File Offset: 0x000C47A0
			[Token(Token = "0x6025139")]
			[Address(RVA = "0x1FF13D0", Offset = "0x1FEFFD0", VA = "0x181FF13D0", Slot = "4")]
			public override int GetTabCount()
			{
				return 0;
			}

			// Token: 0x04033ED3 RID: 212691
			[Token(Token = "0x4033ED3")]
			[FieldOffset(Offset = "0x10")]
			private AutoChessBattleUIHUDInfoPanel m_closure;

			// Token: 0x04033ED4 RID: 212692
			[Token(Token = "0x4033ED4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033ED5 RID: 212693
			[Token(Token = "0x4033ED5")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetTab;

			// Token: 0x04033ED6 RID: 212694
			[Token(Token = "0x4033ED6")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetTabCount;
		}

		// Token: 0x020064C8 RID: 25800
		[Token(Token = "0x20064C8")]
		private class BondDetailTabModel : UITabPager.TabPageViewModel
		{
			// Token: 0x0602513A RID: 151866 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602513A")]
			[Address(RVA = "0x1FF0480", Offset = "0x1FEF080", VA = "0x181FF0480", Slot = "4")]
			public override object GetDialogInput()
			{
				return null;
			}

			// Token: 0x0602513B RID: 151867 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602513B")]
			[Address(RVA = "0x1FF0530", Offset = "0x1FEF130", VA = "0x181FF0530")]
			public BondDetailTabModel()
			{
			}

			// Token: 0x0602513C RID: 151868 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602513C")]
			[Address(RVA = "0x16071F0", Offset = "0x1605DF0", VA = "0x1816071F0")]
			private object <>xLuaBaseProxy_GetDialogInput()
			{
				return null;
			}

			// Token: 0x04033ED7 RID: 212695
			[Token(Token = "0x4033ED7")]
			[FieldOffset(Offset = "0x30")]
			public AutoChessBattleUIHUDInfoPanel closure;

			// Token: 0x04033ED8 RID: 212696
			[Token(Token = "0x4033ED8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetDialogInput;

			// Token: 0x04033ED9 RID: 212697
			[Token(Token = "0x4033ED9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020064C9 RID: 25801
		[Token(Token = "0x20064C9")]
		private class PlayerInfoTabModel : UITabPager.TabPageViewModel
		{
			// Token: 0x0602513D RID: 151869 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602513D")]
			[Address(RVA = "0x1FF1290", Offset = "0x1FEFE90", VA = "0x181FF1290", Slot = "4")]
			public override object GetDialogInput()
			{
				return null;
			}

			// Token: 0x0602513E RID: 151870 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602513E")]
			[Address(RVA = "0x1FF1370", Offset = "0x1FEFF70", VA = "0x181FF1370")]
			public PlayerInfoTabModel()
			{
			}

			// Token: 0x0602513F RID: 151871 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602513F")]
			[Address(RVA = "0x16071F0", Offset = "0x1605DF0", VA = "0x1816071F0")]
			private object <>xLuaBaseProxy_GetDialogInput()
			{
				return null;
			}

			// Token: 0x04033EDA RID: 212698
			[Token(Token = "0x4033EDA")]
			[FieldOffset(Offset = "0x30")]
			public AutoChessBattleUIHUDInfoPanel closure;

			// Token: 0x04033EDB RID: 212699
			[Token(Token = "0x4033EDB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetDialogInput;

			// Token: 0x04033EDC RID: 212700
			[Token(Token = "0x4033EDC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
