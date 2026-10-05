using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064A4 RID: 25764
	[Token(Token = "0x20064A4")]
	public class AutoChessBattleUIRoundStartDialog : UICompDialog<AutoChessBattleUIRoundStartDialog.Input>
	{
		// Token: 0x060250AE RID: 151726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250AE")]
		[Address(RVA = "0x1FED2A0", Offset = "0x1FEBEA0", VA = "0x181FED2A0", Slot = "18")]
		protected override void OnRender(AutoChessBattleUIRoundStartDialog.Input input)
		{
		}

		// Token: 0x060250AF RID: 151727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60250AF")]
		[Address(RVA = "0x1FED5C0", Offset = "0x1FEC1C0", VA = "0x181FED5C0")]
		private IEnumerator _ShowAnimCoroutine()
		{
			return null;
		}

		// Token: 0x060250B0 RID: 151728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60250B0")]
		[Address(RVA = "0x1FED680", Offset = "0x1FEC280", VA = "0x181FED680")]
		private IEnumerator _ShowInAnimCoroutine()
		{
			return null;
		}

		// Token: 0x060250B1 RID: 151729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60250B1")]
		[Address(RVA = "0x1FED740", Offset = "0x1FEC340", VA = "0x181FED740")]
		private IEnumerator _ShowOutAnimCoroutine()
		{
			return null;
		}

		// Token: 0x060250B2 RID: 151730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250B2")]
		[Address(RVA = "0x1FED840", Offset = "0x1FEC440", VA = "0x181FED840")]
		public AutoChessBattleUIRoundStartDialog()
		{
		}

		// Token: 0x04033DC5 RID: 212421
		[Token(Token = "0x4033DC5")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		public static float MAX_SHOW_TIME;

		// Token: 0x04033DC6 RID: 212422
		[Token(Token = "0x4033DC6")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _inAnimationLocation;

		// Token: 0x04033DC7 RID: 212423
		[Token(Token = "0x4033DC7")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _outAnimationLocation;

		// Token: 0x04033DC8 RID: 212424
		[Token(Token = "0x4033DC8")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _txtRoundBefore;

		// Token: 0x04033DC9 RID: 212425
		[Token(Token = "0x4033DC9")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _txtRound;

		// Token: 0x04033DCA RID: 212426
		[Token(Token = "0x4033DCA")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _txtGoldCount;

		// Token: 0x04033DCB RID: 212427
		[Token(Token = "0x4033DCB")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float _normalWaitTime;

		// Token: 0x04033DCC RID: 212428
		[Token(Token = "0x4033DCC")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _panelRoundTip;

		// Token: 0x04033DCD RID: 212429
		[Token(Token = "0x4033DCD")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text _txtRoundTip;

		// Token: 0x04033DCE RID: 212430
		[Token(Token = "0x4033DCE")]
		[FieldOffset(Offset = "0xC0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04033DCF RID: 212431
		[Token(Token = "0x4033DCF")]
		[FieldOffset(Offset = "0xD0")]
		private Tween m_tween;

		// Token: 0x04033DD0 RID: 212432
		[Token(Token = "0x4033DD0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04033DD1 RID: 212433
		[Token(Token = "0x4033DD1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ShowAnimCoroutine;

		// Token: 0x04033DD2 RID: 212434
		[Token(Token = "0x4033DD2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ShowInAnimCoroutine;

		// Token: 0x04033DD3 RID: 212435
		[Token(Token = "0x4033DD3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ShowOutAnimCoroutine;

		// Token: 0x04033DD4 RID: 212436
		[Token(Token = "0x4033DD4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020064A5 RID: 25765
		[Token(Token = "0x20064A5")]
		public class Input
		{
			// Token: 0x060250B6 RID: 151734 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60250B6")]
			[Address(RVA = "0x5A4AB0", Offset = "0x5A36B0", VA = "0x1805A4AB0")]
			public Input()
			{
			}

			// Token: 0x04033DD5 RID: 212437
			[Token(Token = "0x4033DD5")]
			[FieldOffset(Offset = "0x10")]
			public int round;

			// Token: 0x04033DD6 RID: 212438
			[Token(Token = "0x4033DD6")]
			[FieldOffset(Offset = "0x14")]
			public int gold;

			// Token: 0x04033DD7 RID: 212439
			[Token(Token = "0x4033DD7")]
			[FieldOffset(Offset = "0x18")]
			public int remainRoundCnt;
		}
	}
}
