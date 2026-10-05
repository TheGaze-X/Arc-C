using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x0200603A RID: 24634
	[Token(Token = "0x200603A")]
	public class CarvingMainBoardState : UIPopupState, IHotfixable
	{
		// Token: 0x060239EF RID: 145903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60239EF")]
		[Address(RVA = "0x1E48C80", Offset = "0x1E47880", VA = "0x181E48C80", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060239F0 RID: 145904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239F0")]
		[Address(RVA = "0x1E48F10", Offset = "0x1E47B10", VA = "0x181E48F10", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060239F1 RID: 145905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239F1")]
		[Address(RVA = "0x1E49290", Offset = "0x1E47E90", VA = "0x181E49290", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x060239F2 RID: 145906 RVA: 0x000C1608 File Offset: 0x000BF808
		[Token(Token = "0x60239F2")]
		[Address(RVA = "0x1E49D60", Offset = "0x1E48960", VA = "0x181E49D60", Slot = "12")]
		public override bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x060239F3 RID: 145907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239F3")]
		[Address(RVA = "0x1E49840", Offset = "0x1E48440", VA = "0x181E49840", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060239F4 RID: 145908 RVA: 0x000C1620 File Offset: 0x000BF820
		[Token(Token = "0x60239F4")]
		[Address(RVA = "0x1E4A340", Offset = "0x1E48F40", VA = "0x181E4A340")]
		private bool _TriggerTutorialAVG()
		{
			return default(bool);
		}

		// Token: 0x060239F5 RID: 145909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239F5")]
		[Address(RVA = "0x1E4A530", Offset = "0x1E49130", VA = "0x181E4A530")]
		private void _TryOpenIntroDialogue([Optional] Story story)
		{
		}

		// Token: 0x060239F6 RID: 145910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239F6")]
		[Address(RVA = "0x1E49DD0", Offset = "0x1E489D0", VA = "0x181E49DD0")]
		private void _InitIfNot(CarvingMainPage page)
		{
		}

		// Token: 0x060239F7 RID: 145911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239F7")]
		[Address(RVA = "0x1E49F80", Offset = "0x1E48B80", VA = "0x181E49F80")]
		private void _PlayShowAnim()
		{
		}

		// Token: 0x060239F8 RID: 145912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60239F8")]
		[Address(RVA = "0x1E49A20", Offset = "0x1E48620", VA = "0x181E49A20", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x060239F9 RID: 145913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60239F9")]
		[Address(RVA = "0x1E48CE0", Offset = "0x1E478E0", VA = "0x181E48CE0", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x060239FA RID: 145914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239FA")]
		[Address(RVA = "0x1E49B60", Offset = "0x1E48760", VA = "0x181E49B60", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x060239FB RID: 145915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239FB")]
		[Address(RVA = "0x1E48E20", Offset = "0x1E47A20", VA = "0x181E48E20", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x060239FC RID: 145916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60239FC")]
		[Address(RVA = "0x1E498C0", Offset = "0x1E484C0", VA = "0x181E498C0", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x060239FD RID: 145917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239FD")]
		[Address(RVA = "0x1E4A650", Offset = "0x1E49250", VA = "0x181E4A650")]
		public CarvingMainBoardState()
		{
		}

		// Token: 0x060239FF RID: 145919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239FF")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06023A00 RID: 145920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A00")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x06023A01 RID: 145921 RVA: 0x000C1638 File Offset: 0x000BF838
		[Token(Token = "0x6023A01")]
		[Address(RVA = "0x11033F0", Offset = "0x1101FF0", VA = "0x1811033F0")]
		private bool <>xLuaBaseProxy_UseEarlyFromDataListener(Type P0)
		{
			return default(bool);
		}

		// Token: 0x06023A02 RID: 145922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A02")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06023A03 RID: 145923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023A03")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x04031533 RID: 202035
		[Token(Token = "0x4031533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CarvingMainBoardView _boardView;

		// Token: 0x04031534 RID: 202036
		[Token(Token = "0x4031534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CarvingMainCardDeskView _cardDeskView;

		// Token: 0x04031535 RID: 202037
		[Token(Token = "0x4031535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _cardSlotShowAnimDelay;

		// Token: 0x04031536 RID: 202038
		[Token(Token = "0x4031536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _showAnimLocation;

		// Token: 0x04031537 RID: 202039
		[Token(Token = "0x4031537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private CarvingMainCardDetailBlocker _cardDetailBlocker;

		// Token: 0x04031538 RID: 202040
		[Token(Token = "0x4031538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04031539 RID: 202041
		[Token(Token = "0x4031539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private CarvingMainBoardStateBean m_stateBean;

		// Token: 0x0403153A RID: 202042
		[Token(Token = "0x403153A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int m_showAnimSeqNum;

		// Token: 0x0403153B RID: 202043
		[Token(Token = "0x403153B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Tween m_showTween;

		// Token: 0x0403153C RID: 202044
		[Token(Token = "0x403153C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private string m_actId;

		// Token: 0x0403153D RID: 202045
		[Token(Token = "0x403153D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool m_isInited;

		// Token: 0x0403153E RID: 202046
		[Token(Token = "0x403153E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int m_dialogueInstId;

		// Token: 0x0403153F RID: 202047
		[Token(Token = "0x403153F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04031540 RID: 202048
		[Token(Token = "0x4031540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04031541 RID: 202049
		[Token(Token = "0x4031541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x04031542 RID: 202050
		[Token(Token = "0x4031542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x04031543 RID: 202051
		[Token(Token = "0x4031543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04031544 RID: 202052
		[Token(Token = "0x4031544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TriggerTutorialAVG;

		// Token: 0x04031545 RID: 202053
		[Token(Token = "0x4031545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TryOpenIntroDialogue;

		// Token: 0x04031546 RID: 202054
		[Token(Token = "0x4031546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04031547 RID: 202055
		[Token(Token = "0x4031547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__PlayShowAnim;

		// Token: 0x04031548 RID: 202056
		[Token(Token = "0x4031548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x04031549 RID: 202057
		[Token(Token = "0x4031549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0403154A RID: 202058
		[Token(Token = "0x403154A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x0403154B RID: 202059
		[Token(Token = "0x403154B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x0403154C RID: 202060
		[Token(Token = "0x403154C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x0403154D RID: 202061
		[Token(Token = "0x403154D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
