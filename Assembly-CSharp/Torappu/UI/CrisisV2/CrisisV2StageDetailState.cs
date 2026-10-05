using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x0200594B RID: 22859
	[Token(Token = "0x200594B")]
	public class CrisisV2StageDetailState : PopupFloatState, IHotfixable
	{
		// Token: 0x06021516 RID: 136470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021516")]
		[Address(RVA = "0x1BBA860", Offset = "0x1BB9460", VA = "0x181BBA860", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06021517 RID: 136471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021517")]
		[Address(RVA = "0x1BBA580", Offset = "0x1BB9180", VA = "0x181BBA580", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06021518 RID: 136472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021518")]
		[Address(RVA = "0x1BBAAE0", Offset = "0x1BB96E0", VA = "0x181BBAAE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021519 RID: 136473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021519")]
		[Address(RVA = "0x1BBA680", Offset = "0x1BB9280", VA = "0x181BBA680")]
		public void OnEnemyInfoBtnClicked()
		{
		}

		// Token: 0x0602151A RID: 136474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602151A")]
		[Address(RVA = "0x1BBA5E0", Offset = "0x1BB91E0", VA = "0x181BBA5E0")]
		public void OnBackroundClicked()
		{
		}

		// Token: 0x0602151B RID: 136475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602151B")]
		[Address(RVA = "0x1BBACA0", Offset = "0x1BB98A0", VA = "0x181BBACA0")]
		public CrisisV2StageDetailState()
		{
		}

		// Token: 0x0602151C RID: 136476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602151C")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402D6DB RID: 186075
		[Token(Token = "0x402D6DB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CrisisV2StageDetailView _view;

		// Token: 0x0402D6DC RID: 186076
		[Token(Token = "0x402D6DC")]
		[FieldOffset(Offset = "0x78")]
		private CrisisV2StageDetailStateBean m_stateBean;

		// Token: 0x0402D6DD RID: 186077
		[Token(Token = "0x402D6DD")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x0402D6DE RID: 186078
		[Token(Token = "0x402D6DE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402D6DF RID: 186079
		[Token(Token = "0x402D6DF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402D6E0 RID: 186080
		[Token(Token = "0x402D6E0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402D6E1 RID: 186081
		[Token(Token = "0x402D6E1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnemyInfoBtnClicked;

		// Token: 0x0402D6E2 RID: 186082
		[Token(Token = "0x402D6E2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnBackroundClicked;

		// Token: 0x0402D6E3 RID: 186083
		[Token(Token = "0x402D6E3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
