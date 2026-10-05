using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x020061EF RID: 25071
	[Token(Token = "0x20061EF")]
	public class BattleFinishHomeState : UIPopupState
	{
		// Token: 0x060242EB RID: 148203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60242EB")]
		[Address(RVA = "0x1ED1EF0", Offset = "0x1ED0AF0", VA = "0x181ED1EF0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060242EC RID: 148204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60242EC")]
		[Address(RVA = "0x1ED2180", Offset = "0x1ED0D80", VA = "0x181ED2180", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060242ED RID: 148205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60242ED")]
		[Address(RVA = "0x1ED25A0", Offset = "0x1ED11A0", VA = "0x181ED25A0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060242EE RID: 148206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60242EE")]
		[Address(RVA = "0x1ED2650", Offset = "0x1ED1250", VA = "0x181ED2650", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x060242EF RID: 148207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60242EF")]
		[Address(RVA = "0x1ED1F50", Offset = "0x1ED0B50", VA = "0x181ED1F50", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x060242F0 RID: 148208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60242F0")]
		[Address(RVA = "0x1ED2790", Offset = "0x1ED1390", VA = "0x181ED2790", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x060242F1 RID: 148209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60242F1")]
		[Address(RVA = "0x1ED2090", Offset = "0x1ED0C90", VA = "0x181ED2090", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x060242F2 RID: 148210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60242F2")]
		[Address(RVA = "0x1ED2880", Offset = "0x1ED1480", VA = "0x181ED2880")]
		public BattleFinishHomeState()
		{
		}

		// Token: 0x060242F3 RID: 148211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60242F3")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060242F4 RID: 148212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60242F4")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x040324CA RID: 206026
		[Token(Token = "0x40324CA")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private BattleFinishHomeStateBean _stateBean;

		// Token: 0x040324CB RID: 206027
		[Token(Token = "0x40324CB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIFullScreenImage _blurBackground;

		// Token: 0x040324CC RID: 206028
		[Token(Token = "0x40324CC")]
		[FieldOffset(Offset = "0x70")]
		private BattleFinishHomeView m_view;

		// Token: 0x040324CD RID: 206029
		[Token(Token = "0x40324CD")]
		[FieldOffset(Offset = "0x78")]
		private float m_animEndTime;

		// Token: 0x040324CE RID: 206030
		[Token(Token = "0x40324CE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040324CF RID: 206031
		[Token(Token = "0x40324CF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040324D0 RID: 206032
		[Token(Token = "0x40324D0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x040324D1 RID: 206033
		[Token(Token = "0x40324D1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x040324D2 RID: 206034
		[Token(Token = "0x40324D2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x040324D3 RID: 206035
		[Token(Token = "0x40324D3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x040324D4 RID: 206036
		[Token(Token = "0x40324D4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x040324D5 RID: 206037
		[Token(Token = "0x40324D5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
