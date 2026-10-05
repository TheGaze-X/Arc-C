using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x02006507 RID: 25863
	[Token(Token = "0x2006507")]
	public class AutoChessBattleUIPrepReadyPanel : AutoChessBattleUIPanelBase
	{
		// Token: 0x060252DA RID: 152282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252DA")]
		[Address(RVA = "0x2022E30", Offset = "0x2021A30", VA = "0x182022E30", Slot = "7")]
		public override void OnValueChanged(AutoChessBattleUIViewModelProperty property)
		{
		}

		// Token: 0x060252DB RID: 152283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252DB")]
		[Address(RVA = "0x2023320", Offset = "0x2021F20", VA = "0x182023320")]
		private void _RegisterTutorialGOIfNeed()
		{
		}

		// Token: 0x060252DC RID: 152284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252DC")]
		[Address(RVA = "0x2022DA0", Offset = "0x20219A0", VA = "0x182022DA0")]
		public void EventOnReadyBtnClick()
		{
		}

		// Token: 0x060252DD RID: 152285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252DD")]
		[Address(RVA = "0x2023230", Offset = "0x2021E30", VA = "0x182023230")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060252DE RID: 152286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252DE")]
		[Address(RVA = "0x2023440", Offset = "0x2022040", VA = "0x182023440")]
		private void _RenderPlayerPart(AutoChessBattleUIViewModel viewModel, bool currIsSelfReady)
		{
		}

		// Token: 0x060252DF RID: 152287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252DF")]
		[Address(RVA = "0x20237C0", Offset = "0x20223C0", VA = "0x1820237C0")]
		public AutoChessBattleUIPrepReadyPanel()
		{
		}

		// Token: 0x0403423E RID: 213566
		[Token(Token = "0x403423E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0403423F RID: 213567
		[Token(Token = "0x403423F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _animationLocation;

		// Token: 0x04034240 RID: 213568
		[Token(Token = "0x4034240")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelPlayer;

		// Token: 0x04034241 RID: 213569
		[Token(Token = "0x4034241")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _playerContainer;

		// Token: 0x04034242 RID: 213570
		[Token(Token = "0x4034242")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AutoChessBattleUIPrepReadyPlayerView _playerPrefab;

		// Token: 0x04034243 RID: 213571
		[Token(Token = "0x4034243")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button _btnPrepReady;

		// Token: 0x04034244 RID: 213572
		[Token(Token = "0x4034244")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _multiReference;

		// Token: 0x04034245 RID: 213573
		[Token(Token = "0x4034245")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _singleReference;

		// Token: 0x04034246 RID: 213574
		[Token(Token = "0x4034246")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _btnRect;

		// Token: 0x04034247 RID: 213575
		[Token(Token = "0x4034247")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isInited;

		// Token: 0x04034248 RID: 213576
		[Token(Token = "0x4034248")]
		[FieldOffset(Offset = "0x78")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04034249 RID: 213577
		[Token(Token = "0x4034249")]
		[FieldOffset(Offset = "0x88")]
		private FadeSwitchTween m_fadeSwitchTween;

		// Token: 0x0403424A RID: 213578
		[Token(Token = "0x403424A")]
		[FieldOffset(Offset = "0x90")]
		private bool m_cachedIsShow;

		// Token: 0x0403424B RID: 213579
		[Token(Token = "0x403424B")]
		[FieldOffset(Offset = "0x98")]
		private AnimationSwitchTween m_readyTween;

		// Token: 0x0403424C RID: 213580
		[Token(Token = "0x403424C")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_cachedIsSelfReady;

		// Token: 0x0403424D RID: 213581
		[Token(Token = "0x403424D")]
		[FieldOffset(Offset = "0xA8")]
		private List<AutoChessBattleUIPrepReadyPlayerView> m_players;

		// Token: 0x0403424E RID: 213582
		[Token(Token = "0x403424E")]
		[FieldOffset(Offset = "0xB0")]
		private int m_cachedPlayerReadyCount;

		// Token: 0x0403424F RID: 213583
		[Token(Token = "0x403424F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04034250 RID: 213584
		[Token(Token = "0x4034250")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGOIfNeed;

		// Token: 0x04034251 RID: 213585
		[Token(Token = "0x4034251")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnReadyBtnClick;

		// Token: 0x04034252 RID: 213586
		[Token(Token = "0x4034252")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04034253 RID: 213587
		[Token(Token = "0x4034253")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderPlayerPart;

		// Token: 0x04034254 RID: 213588
		[Token(Token = "0x4034254")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
