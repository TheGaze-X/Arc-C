using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005DA9 RID: 23977
	[Token(Token = "0x2005DA9")]
	public class ClimbTowerSweepEndingState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x06022C3B RID: 142395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022C3B")]
		[Address(RVA = "0x1D59F20", Offset = "0x1D58B20", VA = "0x181D59F20", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06022C3C RID: 142396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C3C")]
		[Address(RVA = "0x1D59F80", Offset = "0x1D58B80", VA = "0x181D59F80", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06022C3D RID: 142397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022C3D")]
		[Address(RVA = "0x1D5A3C0", Offset = "0x1D58FC0", VA = "0x181D5A3C0", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x06022C3E RID: 142398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C3E")]
		[Address(RVA = "0x1D5A510", Offset = "0x1D59110", VA = "0x181D5A510")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022C3F RID: 142399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C3F")]
		[Address(RVA = "0x1D5A1C0", Offset = "0x1D58DC0", VA = "0x181D5A1C0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06022C40 RID: 142400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C40")]
		[Address(RVA = "0x1D5A600", Offset = "0x1D59200", VA = "0x181D5A600")]
		private void _RemoveStateToEntry()
		{
		}

		// Token: 0x06022C41 RID: 142401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C41")]
		[Address(RVA = "0x1D5A780", Offset = "0x1D59380", VA = "0x181D5A780")]
		public ClimbTowerSweepEndingState()
		{
		}

		// Token: 0x06022C43 RID: 142403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C43")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06022C44 RID: 142404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022C44")]
		[Address(RVA = "0x1089D20", Offset = "0x1088920", VA = "0x181089D20")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x0402FC96 RID: 195734
		[Token(Token = "0x402FC96")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ClimbTowerSweepEndingView _view;

		// Token: 0x0402FC97 RID: 195735
		[Token(Token = "0x402FC97")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _entryAnimLocation;

		// Token: 0x0402FC98 RID: 195736
		[Token(Token = "0x402FC98")]
		[FieldOffset(Offset = "0x88")]
		private ClimbTowerSweepEndingStateBean m_stateBean;

		// Token: 0x0402FC99 RID: 195737
		[Token(Token = "0x402FC99")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x0402FC9A RID: 195738
		[Token(Token = "0x402FC9A")]
		[FieldOffset(Offset = "0x98")]
		private Tween m_entryTween;

		// Token: 0x0402FC9B RID: 195739
		[Token(Token = "0x402FC9B")]
		[NonSerialized]
		public const int CLOSE_SWEEP_ENDING_STATE = 0;

		// Token: 0x0402FC9C RID: 195740
		[Token(Token = "0x402FC9C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402FC9D RID: 195741
		[Token(Token = "0x402FC9D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402FC9E RID: 195742
		[Token(Token = "0x402FC9E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0402FC9F RID: 195743
		[Token(Token = "0x402FC9F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402FCA0 RID: 195744
		[Token(Token = "0x402FCA0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0402FCA1 RID: 195745
		[Token(Token = "0x402FCA1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RemoveStateToEntry;

		// Token: 0x0402FCA2 RID: 195746
		[Token(Token = "0x402FCA2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
