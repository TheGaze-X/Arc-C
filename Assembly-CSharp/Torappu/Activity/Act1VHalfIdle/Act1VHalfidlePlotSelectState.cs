using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007769 RID: 30569
	[Token(Token = "0x2007769")]
	public class Act1VHalfidlePlotSelectState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x0602AEDF RID: 175839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AEDF")]
		[Address(RVA = "0x26BB4F0", Offset = "0x26BA0F0", VA = "0x1826BB4F0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602AEE0 RID: 175840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEE0")]
		[Address(RVA = "0x26BB6B0", Offset = "0x26BA2B0", VA = "0x1826BB6B0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602AEE1 RID: 175841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEE1")]
		[Address(RVA = "0x26BBAD0", Offset = "0x26BA6D0", VA = "0x1826BBAD0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602AEE2 RID: 175842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEE2")]
		[Address(RVA = "0x26BB720", Offset = "0x26BA320", VA = "0x1826BB720", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0602AEE3 RID: 175843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEE3")]
		[Address(RVA = "0x26BBDE0", Offset = "0x26BA9E0", VA = "0x1826BBDE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AEE4 RID: 175844 RVA: 0x000DA700 File Offset: 0x000D8900
		[Token(Token = "0x602AEE4")]
		[Address(RVA = "0x26BBFF0", Offset = "0x26BABF0", VA = "0x1826BBFF0")]
		private bool _IsUIStable()
		{
			return default(bool);
		}

		// Token: 0x0602AEE5 RID: 175845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEE5")]
		[Address(RVA = "0x26BCAC0", Offset = "0x26BB6C0", VA = "0x1826BCAC0")]
		private void _StateBack()
		{
		}

		// Token: 0x0602AEE6 RID: 175846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEE6")]
		[Address(RVA = "0x26BBCA0", Offset = "0x26BA8A0", VA = "0x1826BBCA0")]
		private void _CloseState()
		{
		}

		// Token: 0x0602AEE7 RID: 175847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEE7")]
		[Address(RVA = "0x26BCE10", Offset = "0x26BBA10", VA = "0x1826BCE10")]
		private void _UnselectAll()
		{
		}

		// Token: 0x0602AEE8 RID: 175848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEE8")]
		[Address(RVA = "0x26BC0E0", Offset = "0x26BACE0", VA = "0x1826BC0E0")]
		private void _OnPlotItemClick(string plotId)
		{
		}

		// Token: 0x0602AEE9 RID: 175849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEE9")]
		[Address(RVA = "0x26BC730", Offset = "0x26BB330", VA = "0x1826BC730")]
		private void _SavePlot()
		{
		}

		// Token: 0x0602AEEA RID: 175850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEEA")]
		[Address(RVA = "0x26BC310", Offset = "0x26BAF10", VA = "0x1826BC310")]
		private void _OpenEnemyDetailPage(object param)
		{
		}

		// Token: 0x0602AEEB RID: 175851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEEB")]
		[Address(RVA = "0x26BC4B0", Offset = "0x26BB0B0", VA = "0x1826BC4B0")]
		private void _OpenPlotDetailDialog()
		{
		}

		// Token: 0x0602AEEC RID: 175852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEEC")]
		[Address(RVA = "0x26BB7F0", Offset = "0x26BA3F0", VA = "0x1826BB7F0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0602AEED RID: 175853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEED")]
		[Address(RVA = "0x26BB550", Offset = "0x26BA150", VA = "0x1826BB550")]
		public void OnBtnBackClicked()
		{
		}

		// Token: 0x0602AEEE RID: 175854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEEE")]
		[Address(RVA = "0x26BCC80", Offset = "0x26BB880", VA = "0x1826BCC80")]
		private void _TryRaiseResumeAVGSignal()
		{
		}

		// Token: 0x0602AEEF RID: 175855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEEF")]
		[Address(RVA = "0x26BCBE0", Offset = "0x26BB7E0", VA = "0x1826BCBE0")]
		private void _TryRaiseExitAVGSignal()
		{
		}

		// Token: 0x0602AEF0 RID: 175856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEF0")]
		[Address(RVA = "0x26BD020", Offset = "0x26BBC20", VA = "0x1826BD020")]
		public Act1VHalfidlePlotSelectState()
		{
		}

		// Token: 0x0602AEF1 RID: 175857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEF1")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602AEF2 RID: 175858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEF2")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0602AEF3 RID: 175859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEF3")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0403DEFF RID: 253695
		[Token(Token = "0x403DEFF")]
		[NonSerialized]
		public const int UNSELECT_ALL_PLOT = 0;

		// Token: 0x0403DF00 RID: 253696
		[Token(Token = "0x403DF00")]
		[NonSerialized]
		public const int PLOT_ITEM_CLICK = 1;

		// Token: 0x0403DF01 RID: 253697
		[Token(Token = "0x403DF01")]
		[NonSerialized]
		public const int SAVE_PLOT = 2;

		// Token: 0x0403DF02 RID: 253698
		[Token(Token = "0x403DF02")]
		[NonSerialized]
		public const int ENEMY_DETAIL_CLICKED = 3;

		// Token: 0x0403DF03 RID: 253699
		[Token(Token = "0x403DF03")]
		[NonSerialized]
		public const int PLOT_DERIVE_DETAIL_CLICKED = 4;

		// Token: 0x0403DF04 RID: 253700
		[Token(Token = "0x403DF04")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act1VHalfidlePlotSelectView _view;

		// Token: 0x0403DF05 RID: 253701
		[Token(Token = "0x403DF05")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act1VHalfidlePlotSelectDetailView _detailView;

		// Token: 0x0403DF06 RID: 253702
		[Token(Token = "0x403DF06")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _backPressArea;

		// Token: 0x0403DF07 RID: 253703
		[Token(Token = "0x403DF07")]
		[FieldOffset(Offset = "0x88")]
		private Act1VHalfidlePlotSelectStateBean m_stateBean;

		// Token: 0x0403DF08 RID: 253704
		[Token(Token = "0x403DF08")]
		[FieldOffset(Offset = "0x90")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403DF09 RID: 253705
		[Token(Token = "0x403DF09")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_hasInited;

		// Token: 0x0403DF0A RID: 253706
		[Token(Token = "0x403DF0A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403DF0B RID: 253707
		[Token(Token = "0x403DF0B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403DF0C RID: 253708
		[Token(Token = "0x403DF0C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403DF0D RID: 253709
		[Token(Token = "0x403DF0D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0403DF0E RID: 253710
		[Token(Token = "0x403DF0E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403DF0F RID: 253711
		[Token(Token = "0x403DF0F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__IsUIStable;

		// Token: 0x0403DF10 RID: 253712
		[Token(Token = "0x403DF10")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__StateBack;

		// Token: 0x0403DF11 RID: 253713
		[Token(Token = "0x403DF11")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CloseState;

		// Token: 0x0403DF12 RID: 253714
		[Token(Token = "0x403DF12")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UnselectAll;

		// Token: 0x0403DF13 RID: 253715
		[Token(Token = "0x403DF13")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnPlotItemClick;

		// Token: 0x0403DF14 RID: 253716
		[Token(Token = "0x403DF14")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SavePlot;

		// Token: 0x0403DF15 RID: 253717
		[Token(Token = "0x403DF15")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OpenEnemyDetailPage;

		// Token: 0x0403DF16 RID: 253718
		[Token(Token = "0x403DF16")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OpenPlotDetailDialog;

		// Token: 0x0403DF17 RID: 253719
		[Token(Token = "0x403DF17")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403DF18 RID: 253720
		[Token(Token = "0x403DF18")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnBtnBackClicked;

		// Token: 0x0403DF19 RID: 253721
		[Token(Token = "0x403DF19")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__TryRaiseResumeAVGSignal;

		// Token: 0x0403DF1A RID: 253722
		[Token(Token = "0x403DF1A")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__TryRaiseExitAVGSignal;

		// Token: 0x0403DF1B RID: 253723
		[Token(Token = "0x403DF1B")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
