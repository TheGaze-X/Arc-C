using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI.EnemyDuel.Service;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FFD RID: 20477
	[Token(Token = "0x2004FFD")]
	public class EnemyDuelPerformState : EnemyDuelBattleState, IValueMsgReceiver
	{
		// Token: 0x0601E64E RID: 124494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E64E")]
		[Address(RVA = "0x181B070", Offset = "0x1819C70", VA = "0x18181B070", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601E64F RID: 124495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E64F")]
		[Address(RVA = "0x181B2E0", Offset = "0x1819EE0", VA = "0x18181B2E0", Slot = "32")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601E650 RID: 124496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E650")]
		[Address(RVA = "0x181B440", Offset = "0x181A040", VA = "0x18181B440")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E651 RID: 124497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E651")]
		[Address(RVA = "0x181B130", Offset = "0x1819D30", VA = "0x18181B130", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601E652 RID: 124498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E652")]
		[Address(RVA = "0x181B390", Offset = "0x1819F90", VA = "0x18181B390", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x0601E653 RID: 124499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E653")]
		[Address(RVA = "0x181B880", Offset = "0x181A480", VA = "0x18181B880")]
		private void _PlayEnterAnim()
		{
		}

		// Token: 0x0601E654 RID: 124500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E654")]
		[Address(RVA = "0x181BC60", Offset = "0x181A860", VA = "0x18181BC60")]
		private void _UpdateData()
		{
		}

		// Token: 0x0601E655 RID: 124501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E655")]
		[Address(RVA = "0x181B580", Offset = "0x181A180", VA = "0x18181B580")]
		private void _OnBattleFinishWait(object obj)
		{
		}

		// Token: 0x0601E656 RID: 124502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E656")]
		[Address(RVA = "0x181B650", Offset = "0x181A250", VA = "0x18181B650")]
		private void _OnDisableEmoticonClicked()
		{
		}

		// Token: 0x0601E657 RID: 124503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E657")]
		[Address(RVA = "0x181BBD0", Offset = "0x181A7D0", VA = "0x18181BBD0")]
		private void _SetPerformCanvasRaycast(bool isOn)
		{
		}

		// Token: 0x0601E658 RID: 124504 RVA: 0x000AE5B8 File Offset: 0x000AC7B8
		[Token(Token = "0x601E658")]
		[Address(RVA = "0x181B0D0", Offset = "0x1819CD0", VA = "0x18181B0D0", Slot = "31")]
		protected override EnemyDuelServiceGameState GetSupportedGameState()
		{
			return EnemyDuelServiceGameState.NONE;
		}

		// Token: 0x0601E659 RID: 124505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E659")]
		[Address(RVA = "0x181BF70", Offset = "0x181AB70", VA = "0x18181BF70")]
		public EnemyDuelPerformState()
		{
		}

		// Token: 0x0601E65B RID: 124507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E65B")]
		[Address(RVA = "0x17FAF90", Offset = "0x17F9B90", VA = "0x1817FAF90")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601E65C RID: 124508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E65C")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x04028A2F RID: 166447
		[Token(Token = "0x4028A2F")]
		[NonSerialized]
		public const int MSG_ON_DISABLE_EMOTICON_CLICKED = 0;

		// Token: 0x04028A30 RID: 166448
		[Token(Token = "0x4028A30")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private EnemyDuelPerformView _performView;

		// Token: 0x04028A31 RID: 166449
		[Token(Token = "0x4028A31")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04028A32 RID: 166450
		[Token(Token = "0x4028A32")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private EnemyDuelRoundStartView _startView;

		// Token: 0x04028A33 RID: 166451
		[Token(Token = "0x4028A33")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIAnimationLocation _startAnim;

		// Token: 0x04028A34 RID: 166452
		[Token(Token = "0x4028A34")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private CanvasGroup _performCanvasGroup;

		// Token: 0x04028A35 RID: 166453
		[Token(Token = "0x4028A35")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_isInited;

		// Token: 0x04028A36 RID: 166454
		[Token(Token = "0x4028A36")]
		[FieldOffset(Offset = "0xC0")]
		private EnemyDuelBattleStateBean m_stateBean;

		// Token: 0x04028A37 RID: 166455
		[Token(Token = "0x4028A37")]
		[FieldOffset(Offset = "0xC8")]
		private Tween m_enterTween;

		// Token: 0x04028A38 RID: 166456
		[Token(Token = "0x4028A38")]
		[FieldOffset(Offset = "0xD0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04028A39 RID: 166457
		[Token(Token = "0x4028A39")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04028A3A RID: 166458
		[Token(Token = "0x4028A3A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04028A3B RID: 166459
		[Token(Token = "0x4028A3B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04028A3C RID: 166460
		[Token(Token = "0x4028A3C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04028A3D RID: 166461
		[Token(Token = "0x4028A3D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x04028A3E RID: 166462
		[Token(Token = "0x4028A3E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlayEnterAnim;

		// Token: 0x04028A3F RID: 166463
		[Token(Token = "0x4028A3F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateData;

		// Token: 0x04028A40 RID: 166464
		[Token(Token = "0x4028A40")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnBattleFinishWait;

		// Token: 0x04028A41 RID: 166465
		[Token(Token = "0x4028A41")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnDisableEmoticonClicked;

		// Token: 0x04028A42 RID: 166466
		[Token(Token = "0x4028A42")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SetPerformCanvasRaycast;

		// Token: 0x04028A43 RID: 166467
		[Token(Token = "0x4028A43")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetSupportedGameState;

		// Token: 0x04028A44 RID: 166468
		[Token(Token = "0x4028A44")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
