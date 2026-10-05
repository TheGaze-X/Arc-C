using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02005009 RID: 20489
	[Token(Token = "0x2005009")]
	public class EnemyDuelRoundEndBarView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E67D RID: 124541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E67D")]
		[Address(RVA = "0x181D510", Offset = "0x181C110", VA = "0x18181D510")]
		public void Render(EnemyDuelRoundEndBarModel model)
		{
		}

		// Token: 0x0601E67E RID: 124542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E67E")]
		[Address(RVA = "0x181D0F0", Offset = "0x181BCF0", VA = "0x18181D0F0")]
		public void OnEntryTweenComplete()
		{
		}

		// Token: 0x0601E67F RID: 124543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E67F")]
		[Address(RVA = "0x181D460", Offset = "0x181C060", VA = "0x18181D460")]
		public void OnStatePause()
		{
		}

		// Token: 0x0601E680 RID: 124544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E680")]
		[Address(RVA = "0x181D2B0", Offset = "0x181BEB0", VA = "0x18181D2B0")]
		public void OnQuitBtnClicked()
		{
		}

		// Token: 0x0601E681 RID: 124545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E681")]
		[Address(RVA = "0x181D400", Offset = "0x181C000", VA = "0x18181D400")]
		public void OnQuitWindowConfirmClicked()
		{
		}

		// Token: 0x0601E682 RID: 124546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E682")]
		[Address(RVA = "0x181D380", Offset = "0x181BF80", VA = "0x18181D380")]
		public void OnQuitWindowCancelClicked()
		{
		}

		// Token: 0x0601E683 RID: 124547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E683")]
		[Address(RVA = "0x181DF10", Offset = "0x181CB10", VA = "0x18181DF10")]
		private void _OnQuit()
		{
		}

		// Token: 0x0601E684 RID: 124548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E684")]
		[Address(RVA = "0x181DCB0", Offset = "0x181C8B0", VA = "0x18181DCB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E685 RID: 124549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E685")]
		[Address(RVA = "0x181DC40", Offset = "0x181C840", VA = "0x18181DC40")]
		private void Update()
		{
		}

		// Token: 0x0601E686 RID: 124550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E686")]
		[Address(RVA = "0x181DFA0", Offset = "0x181CBA0", VA = "0x18181DFA0")]
		public EnemyDuelRoundEndBarView()
		{
		}

		// Token: 0x04028AAB RID: 166571
		[Token(Token = "0x4028AAB")]
		private const float BOTTOM_SHOW_DELAY = 0.16f;

		// Token: 0x04028AAC RID: 166572
		[Token(Token = "0x4028AAC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Top")]
		private Text _title;

		// Token: 0x04028AAD RID: 166573
		[Token(Token = "0x4028AAD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Top")]
		private GameObject _remainPlayerPanel;

		// Token: 0x04028AAE RID: 166574
		[Token(Token = "0x4028AAE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Top")]
		private Text _remainPlayer;

		// Token: 0x04028AAF RID: 166575
		[Token(Token = "0x4028AAF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Top")]
		private Text _totalPlayer;

		// Token: 0x04028AB0 RID: 166576
		[Token(Token = "0x4028AB0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Bottom")]
		private CanvasGroup _bottomBar;

		// Token: 0x04028AB1 RID: 166577
		[Token(Token = "0x4028AB1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Bottom")]
		private Text _countDownNum;

		// Token: 0x04028AB2 RID: 166578
		[Token(Token = "0x4028AB2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Bottom")]
		private Text _countDownText;

		// Token: 0x04028AB3 RID: 166579
		[Token(Token = "0x4028AB3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Bottom")]
		private UIButton _btnQuit;

		// Token: 0x04028AB4 RID: 166580
		[Token(Token = "0x4028AB4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Bottom")]
		private GameObject _btnQuitPanel;

		// Token: 0x04028AB5 RID: 166581
		[Token(Token = "0x4028AB5")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Bottom")]
		private CanvasGroup _windowQuit;

		// Token: 0x04028AB6 RID: 166582
		[Token(Token = "0x4028AB6")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Bottom")]
		private Text _windowText;

		// Token: 0x04028AB7 RID: 166583
		[Token(Token = "0x4028AB7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Bottom")]
		private UIAnimationLocation _windowQuitAnim;

		// Token: 0x04028AB8 RID: 166584
		[Token(Token = "0x4028AB8")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Bottom")]
		private UIAnimationLocation _sandClockAnim;

		// Token: 0x04028AB9 RID: 166585
		[Token(Token = "0x4028AB9")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isRoomMode;

		// Token: 0x04028ABA RID: 166586
		[Token(Token = "0x4028ABA")]
		[FieldOffset(Offset = "0x91")]
		private bool m_isRoomOwner;

		// Token: 0x04028ABB RID: 166587
		[Token(Token = "0x4028ABB")]
		[FieldOffset(Offset = "0x92")]
		private bool m_inited;

		// Token: 0x04028ABC RID: 166588
		[Token(Token = "0x4028ABC")]
		[FieldOffset(Offset = "0x94")]
		private int m_seconds;

		// Token: 0x04028ABD RID: 166589
		[Token(Token = "0x4028ABD")]
		[FieldOffset(Offset = "0x98")]
		private AnimationSwitchTween m_windowTween;

		// Token: 0x04028ABE RID: 166590
		[Token(Token = "0x4028ABE")]
		[FieldOffset(Offset = "0xA0")]
		private CountDownTask m_countDownTask;

		// Token: 0x04028ABF RID: 166591
		[Token(Token = "0x4028ABF")]
		[FieldOffset(Offset = "0xA8")]
		private FadeSwitchTween m_fadeTween;

		// Token: 0x04028AC0 RID: 166592
		[Token(Token = "0x4028AC0")]
		[FieldOffset(Offset = "0xB0")]
		private Tween m_sandClockTween;

		// Token: 0x04028AC1 RID: 166593
		[Token(Token = "0x4028AC1")]
		[FieldOffset(Offset = "0xB8")]
		private Tween m_startDelayCall;

		// Token: 0x04028AC2 RID: 166594
		[Token(Token = "0x4028AC2")]
		[FieldOffset(Offset = "0xC0")]
		private Tween m_endDelayCall;

		// Token: 0x04028AC3 RID: 166595
		[Token(Token = "0x4028AC3")]
		[FieldOffset(Offset = "0xC8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04028AC4 RID: 166596
		[Token(Token = "0x4028AC4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04028AC5 RID: 166597
		[Token(Token = "0x4028AC5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEntryTweenComplete;

		// Token: 0x04028AC6 RID: 166598
		[Token(Token = "0x4028AC6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnStatePause;

		// Token: 0x04028AC7 RID: 166599
		[Token(Token = "0x4028AC7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnQuitBtnClicked;

		// Token: 0x04028AC8 RID: 166600
		[Token(Token = "0x4028AC8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnQuitWindowConfirmClicked;

		// Token: 0x04028AC9 RID: 166601
		[Token(Token = "0x4028AC9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnQuitWindowCancelClicked;

		// Token: 0x04028ACA RID: 166602
		[Token(Token = "0x4028ACA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnQuit;

		// Token: 0x04028ACB RID: 166603
		[Token(Token = "0x4028ACB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04028ACC RID: 166604
		[Token(Token = "0x4028ACC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04028ACD RID: 166605
		[Token(Token = "0x4028ACD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
