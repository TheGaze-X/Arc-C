using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064D4 RID: 25812
	[Token(Token = "0x20064D4")]
	public class AutoChessBattleUIBondInfoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025174 RID: 151924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025174")]
		[Address(RVA = "0x1FE3960", Offset = "0x1FE2560", VA = "0x181FE3960")]
		public void Render(AutoChessBattleUIViewModel model, AutoChessGameStatus.AutoChessHUDTipDisplay tipDisplay)
		{
		}

		// Token: 0x06025175 RID: 151925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025175")]
		[Address(RVA = "0x1FE38D0", Offset = "0x1FE24D0", VA = "0x181FE38D0")]
		public void OnToggleBtnClicked()
		{
		}

		// Token: 0x06025176 RID: 151926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025176")]
		[Address(RVA = "0x1FE3CB0", Offset = "0x1FE28B0", VA = "0x181FE3CB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025177 RID: 151927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025177")]
		[Address(RVA = "0x1FE3ED0", Offset = "0x1FE2AD0", VA = "0x181FE3ED0")]
		private void _RenderBondList(AutoChessHUDStatusModel statusModel, AutoChessBattleUIBondViewModel bondModel, AutoChessGameStatus.SubState subState)
		{
		}

		// Token: 0x06025178 RID: 151928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025178")]
		[Address(RVA = "0x1FE40E0", Offset = "0x1FE2CE0", VA = "0x181FE40E0")]
		private void _RenderPause(AutoChessHUDStatusModel statusModel)
		{
		}

		// Token: 0x06025179 RID: 151929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025179")]
		[Address(RVA = "0x1FE3E10", Offset = "0x1FE2A10", VA = "0x181FE3E10")]
		private void _OnPostSetBgRt()
		{
		}

		// Token: 0x0602517A RID: 151930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602517A")]
		[Address(RVA = "0x1FE42D0", Offset = "0x1FE2ED0", VA = "0x181FE42D0")]
		public AutoChessBattleUIBondInfoView()
		{
		}

		// Token: 0x04033F50 RID: 212816
		[Token(Token = "0x4033F50")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _viewRoot;

		// Token: 0x04033F51 RID: 212817
		[Token(Token = "0x4033F51")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _expandAnim;

		// Token: 0x04033F52 RID: 212818
		[Token(Token = "0x4033F52")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _loopAnim;

		// Token: 0x04033F53 RID: 212819
		[Token(Token = "0x4033F53")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UISimpleRecycleLayoutItemView[] _prefabList;

		// Token: 0x04033F54 RID: 212820
		[Token(Token = "0x4033F54")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIRecycleHorizonLayoutGroup _layoutGroup;

		// Token: 0x04033F55 RID: 212821
		[Token(Token = "0x4033F55")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIWrappedScrollRect _scrollRect;

		// Token: 0x04033F56 RID: 212822
		[Token(Token = "0x4033F56")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _pauseObj;

		// Token: 0x04033F57 RID: 212823
		[Token(Token = "0x4033F57")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _toggleBtn;

		// Token: 0x04033F58 RID: 212824
		[Token(Token = "0x4033F58")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _toggleBtnCanvasGroup;

		// Token: 0x04033F59 RID: 212825
		[Token(Token = "0x4033F59")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _bgRt;

		// Token: 0x04033F5A RID: 212826
		[Token(Token = "0x4033F5A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _layoutRt;

		// Token: 0x04033F5B RID: 212827
		[Token(Token = "0x4033F5B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UILayoutDimensionListener _listener;

		// Token: 0x04033F5C RID: 212828
		[Token(Token = "0x4033F5C")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private CanvasGroup _listInfoAlphaHolder;

		// Token: 0x04033F5D RID: 212829
		[Token(Token = "0x4033F5D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float _pauseAlpha;

		// Token: 0x04033F5E RID: 212830
		[Token(Token = "0x4033F5E")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private float _minWidth;

		// Token: 0x04033F5F RID: 212831
		[Token(Token = "0x4033F5F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float _maxWidth;

		// Token: 0x04033F60 RID: 212832
		[Token(Token = "0x4033F60")]
		[FieldOffset(Offset = "0x9C")]
		private bool m_inited;

		// Token: 0x04033F61 RID: 212833
		[Token(Token = "0x4033F61")]
		[FieldOffset(Offset = "0xA0")]
		private AnimationSwitchTween m_expandTween;

		// Token: 0x04033F62 RID: 212834
		[Token(Token = "0x4033F62")]
		[FieldOffset(Offset = "0xA8")]
		private Tween m_loopTween;

		// Token: 0x04033F63 RID: 212835
		[Token(Token = "0x4033F63")]
		[FieldOffset(Offset = "0xB0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04033F64 RID: 212836
		[Token(Token = "0x4033F64")]
		[FieldOffset(Offset = "0xC0")]
		private UISimpleRecycleLayoutAdapter m_adapter;

		// Token: 0x04033F65 RID: 212837
		[Token(Token = "0x4033F65")]
		[FieldOffset(Offset = "0xC8")]
		private SeqNumSource.Checker m_playerIdxChecker;

		// Token: 0x04033F66 RID: 212838
		[Token(Token = "0x4033F66")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04033F67 RID: 212839
		[Token(Token = "0x4033F67")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnToggleBtnClicked;

		// Token: 0x04033F68 RID: 212840
		[Token(Token = "0x4033F68")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04033F69 RID: 212841
		[Token(Token = "0x4033F69")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderBondList;

		// Token: 0x04033F6A RID: 212842
		[Token(Token = "0x4033F6A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderPause;

		// Token: 0x04033F6B RID: 212843
		[Token(Token = "0x4033F6B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnPostSetBgRt;

		// Token: 0x04033F6C RID: 212844
		[Token(Token = "0x4033F6C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020064D5 RID: 25813
		[Token(Token = "0x20064D5")]
		private class OnPostLayoutAction : UILayoutDimensionListener.IAction
		{
			// Token: 0x0602517B RID: 151931 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602517B")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public OnPostLayoutAction(AutoChessBattleUIBondInfoView closure)
			{
			}

			// Token: 0x0602517C RID: 151932 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602517C")]
			[Address(RVA = "0x1FF11D0", Offset = "0x1FEFDD0", VA = "0x181FF11D0", Slot = "4")]
			public void DoAction()
			{
			}

			// Token: 0x04033F6D RID: 212845
			[Token(Token = "0x4033F6D")]
			[FieldOffset(Offset = "0x10")]
			private AutoChessBattleUIBondInfoView m_closure;
		}
	}
}
