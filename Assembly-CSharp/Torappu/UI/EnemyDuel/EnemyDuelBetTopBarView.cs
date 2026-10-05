using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FCB RID: 20427
	[Token(Token = "0x2004FCB")]
	public class EnemyDuelBetTopBarView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E55C RID: 124252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E55C")]
		[Address(RVA = "0x1814420", Offset = "0x1813020", VA = "0x181814420")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E55D RID: 124253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E55D")]
		[Address(RVA = "0x1813F30", Offset = "0x1812B30", VA = "0x181813F30")]
		public void Render(EnemyDuelTopBarViewModel topBarViewModel)
		{
		}

		// Token: 0x0601E55E RID: 124254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E55E")]
		[Address(RVA = "0x1814780", Offset = "0x1813380", VA = "0x181814780")]
		private void _UpdatePingInterval()
		{
		}

		// Token: 0x0601E55F RID: 124255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E55F")]
		[Address(RVA = "0x18143B0", Offset = "0x1812FB0", VA = "0x1818143B0")]
		private void Update()
		{
		}

		// Token: 0x0601E560 RID: 124256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E560")]
		[Address(RVA = "0x1813EB0", Offset = "0x1812AB0", VA = "0x181813EB0")]
		public void OnExitBtnClicked()
		{
		}

		// Token: 0x0601E561 RID: 124257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E561")]
		[Address(RVA = "0x1813D00", Offset = "0x1812900", VA = "0x181813D00")]
		public void OnBtnDisableEmoticonClicked()
		{
		}

		// Token: 0x0601E562 RID: 124258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E562")]
		[Address(RVA = "0x1814600", Offset = "0x1813200", VA = "0x181814600")]
		private void _RecordGameAnalytics()
		{
		}

		// Token: 0x0601E563 RID: 124259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E563")]
		[Address(RVA = "0x1813E20", Offset = "0x1812A20", VA = "0x181813E20")]
		public void OnBtnEmoticonClicked()
		{
		}

		// Token: 0x0601E564 RID: 124260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E564")]
		[Address(RVA = "0x18148A0", Offset = "0x18134A0", VA = "0x1818148A0")]
		public EnemyDuelBetTopBarView()
		{
		}

		// Token: 0x04028882 RID: 166018
		[Token(Token = "0x4028882")]
		private const string FORMAT_PING = "{0}";

		// Token: 0x04028883 RID: 166019
		[Token(Token = "0x4028883")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textPing;

		// Token: 0x04028884 RID: 166020
		[Token(Token = "0x4028884")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textRoomName;

		// Token: 0x04028885 RID: 166021
		[Token(Token = "0x4028885")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private long _refreshPingInterval;

		// Token: 0x04028886 RID: 166022
		[Token(Token = "0x4028886")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _animEmojiSwitch;

		// Token: 0x04028887 RID: 166023
		[Token(Token = "0x4028887")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private EnemyDuelBetTopBarEmoticonBtn _pnlEmoticonBtn;

		// Token: 0x04028888 RID: 166024
		[Token(Token = "0x4028888")]
		[FieldOffset(Offset = "0x48")]
		private List<ActivityEnemyDuelConstData.PingCond> m_cachedPingConds;

		// Token: 0x04028889 RID: 166025
		[Token(Token = "0x4028889")]
		[FieldOffset(Offset = "0x50")]
		private CountDownTask m_countDownTask;

		// Token: 0x0402888A RID: 166026
		[Token(Token = "0x402888A")]
		[FieldOffset(Offset = "0x58")]
		private bool m_inited;

		// Token: 0x0402888B RID: 166027
		[Token(Token = "0x402888B")]
		[FieldOffset(Offset = "0x60")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402888C RID: 166028
		[Token(Token = "0x402888C")]
		[FieldOffset(Offset = "0x70")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402888D RID: 166029
		[Token(Token = "0x402888D")]
		[FieldOffset(Offset = "0x80")]
		private UISwitchTween m_emojiDisableSwitchTween;

		// Token: 0x0402888E RID: 166030
		[Token(Token = "0x402888E")]
		[FieldOffset(Offset = "0x88")]
		private int m_cachedLoadSeqNum;

		// Token: 0x0402888F RID: 166031
		[Token(Token = "0x402888F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04028890 RID: 166032
		[Token(Token = "0x4028890")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04028891 RID: 166033
		[Token(Token = "0x4028891")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdatePingInterval;

		// Token: 0x04028892 RID: 166034
		[Token(Token = "0x4028892")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04028893 RID: 166035
		[Token(Token = "0x4028893")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnExitBtnClicked;

		// Token: 0x04028894 RID: 166036
		[Token(Token = "0x4028894")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnBtnDisableEmoticonClicked;

		// Token: 0x04028895 RID: 166037
		[Token(Token = "0x4028895")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RecordGameAnalytics;

		// Token: 0x04028896 RID: 166038
		[Token(Token = "0x4028896")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnBtnEmoticonClicked;

		// Token: 0x04028897 RID: 166039
		[Token(Token = "0x4028897")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
