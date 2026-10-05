using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x020061EC RID: 25068
	[Token(Token = "0x20061EC")]
	public class BattleFinishHandBookStageState : UIPopupState
	{
		// Token: 0x060242D3 RID: 148179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60242D3")]
		[Address(RVA = "0x1ED0AB0", Offset = "0x1ECF6B0", VA = "0x181ED0AB0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060242D4 RID: 148180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60242D4")]
		[Address(RVA = "0x1ED0D40", Offset = "0x1ECF940", VA = "0x181ED0D40", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060242D5 RID: 148181 RVA: 0x000C3570 File Offset: 0x000C1770
		[Token(Token = "0x60242D5")]
		[Address(RVA = "0x1ED11E0", Offset = "0x1ECFDE0", VA = "0x181ED11E0")]
		private bool _InitActivityBattleFinish()
		{
			return default(bool);
		}

		// Token: 0x060242D6 RID: 148182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60242D6")]
		[Address(RVA = "0x1ED1180", Offset = "0x1ECFD80", VA = "0x181ED1180")]
		private void _DoSceneJump()
		{
		}

		// Token: 0x060242D7 RID: 148183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60242D7")]
		[Address(RVA = "0x1ED0E70", Offset = "0x1ECFA70", VA = "0x181ED0E70", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060242D8 RID: 148184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60242D8")]
		[Address(RVA = "0x1ED0B10", Offset = "0x1ECF710", VA = "0x181ED0B10", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x060242D9 RID: 148185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60242D9")]
		[Address(RVA = "0x1ED0C50", Offset = "0x1ECF850", VA = "0x181ED0C50", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x060242DA RID: 148186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60242DA")]
		[Address(RVA = "0x1ED0F50", Offset = "0x1ECFB50", VA = "0x181ED0F50", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x060242DB RID: 148187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60242DB")]
		[Address(RVA = "0x1ED1090", Offset = "0x1ECFC90", VA = "0x181ED1090", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x060242DC RID: 148188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60242DC")]
		[Address(RVA = "0x1ED13C0", Offset = "0x1ECFFC0", VA = "0x181ED13C0")]
		public BattleFinishHandBookStageState()
		{
		}

		// Token: 0x060242DD RID: 148189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60242DD")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060242DE RID: 148190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60242DE")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x040324B7 RID: 206007
		[Token(Token = "0x40324B7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _container;

		// Token: 0x040324B8 RID: 206008
		[Token(Token = "0x40324B8")]
		[FieldOffset(Offset = "0x68")]
		private BattleFinishHandBookStageStateBean m_stateBean;

		// Token: 0x040324B9 RID: 206009
		[Token(Token = "0x40324B9")]
		[FieldOffset(Offset = "0x70")]
		private BattleFinishHandBookStageView m_battleFinishView;

		// Token: 0x040324BA RID: 206010
		[Token(Token = "0x40324BA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040324BB RID: 206011
		[Token(Token = "0x40324BB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040324BC RID: 206012
		[Token(Token = "0x40324BC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitActivityBattleFinish;

		// Token: 0x040324BD RID: 206013
		[Token(Token = "0x40324BD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__DoSceneJump;

		// Token: 0x040324BE RID: 206014
		[Token(Token = "0x40324BE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x040324BF RID: 206015
		[Token(Token = "0x40324BF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x040324C0 RID: 206016
		[Token(Token = "0x40324C0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x040324C1 RID: 206017
		[Token(Token = "0x40324C1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x040324C2 RID: 206018
		[Token(Token = "0x40324C2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x040324C3 RID: 206019
		[Token(Token = "0x40324C3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
