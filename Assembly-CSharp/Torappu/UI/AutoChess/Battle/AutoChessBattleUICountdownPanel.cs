using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x02006492 RID: 25746
	[Token(Token = "0x2006492")]
	public class AutoChessBattleUICountdownPanel : AutoChessBattleUIPanelBase, AutoChessBattleUIController.IPanelWithTick
	{
		// Token: 0x06025072 RID: 151666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025072")]
		[Address(RVA = "0x1FE68B0", Offset = "0x1FE54B0", VA = "0x181FE68B0", Slot = "7")]
		public override void OnValueChanged(AutoChessBattleUIViewModelProperty property)
		{
		}

		// Token: 0x06025073 RID: 151667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025073")]
		[Address(RVA = "0x1FE66E0", Offset = "0x1FE52E0", VA = "0x181FE66E0", Slot = "8")]
		public void OnTick()
		{
		}

		// Token: 0x06025074 RID: 151668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025074")]
		[Address(RVA = "0x1FE69A0", Offset = "0x1FE55A0", VA = "0x181FE69A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025075 RID: 151669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025075")]
		[Address(RVA = "0x1FE6D10", Offset = "0x1FE5910", VA = "0x181FE6D10")]
		public AutoChessBattleUICountdownPanel()
		{
		}

		// Token: 0x04033D5C RID: 212316
		[Token(Token = "0x4033D5C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _viewContainer;

		// Token: 0x04033D5D RID: 212317
		[Token(Token = "0x4033D5D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04033D5E RID: 212318
		[Token(Token = "0x4033D5E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _hintPanelCanvasGroup;

		// Token: 0x04033D5F RID: 212319
		[Token(Token = "0x4033D5F")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x04033D60 RID: 212320
		[Token(Token = "0x4033D60")]
		[FieldOffset(Offset = "0x40")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04033D61 RID: 212321
		[Token(Token = "0x4033D61")]
		[FieldOffset(Offset = "0x50")]
		private FadeSwitchTween m_fadeSwitchTween;

		// Token: 0x04033D62 RID: 212322
		[Token(Token = "0x4033D62")]
		[FieldOffset(Offset = "0x58")]
		private AutoChessCountDownView m_countdownView;

		// Token: 0x04033D63 RID: 212323
		[Token(Token = "0x4033D63")]
		[FieldOffset(Offset = "0x60")]
		private FadeSwitchTween m_hintFadeSwitchTween;

		// Token: 0x04033D64 RID: 212324
		[Token(Token = "0x4033D64")]
		[FieldOffset(Offset = "0x68")]
		private bool m_cachedIsShow;

		// Token: 0x04033D65 RID: 212325
		[Token(Token = "0x4033D65")]
		[FieldOffset(Offset = "0x69")]
		private bool m_cachedIsHintShow;

		// Token: 0x04033D66 RID: 212326
		[Token(Token = "0x4033D66")]
		[FieldOffset(Offset = "0x70")]
		private AutoChessBattleUIViewModel m_cachedViewModel;

		// Token: 0x04033D67 RID: 212327
		[Token(Token = "0x4033D67")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04033D68 RID: 212328
		[Token(Token = "0x4033D68")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04033D69 RID: 212329
		[Token(Token = "0x4033D69")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04033D6A RID: 212330
		[Token(Token = "0x4033D6A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
