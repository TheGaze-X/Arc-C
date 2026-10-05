using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x020073E9 RID: 29673
	[Token(Token = "0x20073E9")]
	public class Act3D0CampSelectState : UIPopupState
	{
		// Token: 0x06029E95 RID: 171669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029E95")]
		[Address(RVA = "0x25845A0", Offset = "0x25831A0", VA = "0x1825845A0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06029E96 RID: 171670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E96")]
		[Address(RVA = "0x2584840", Offset = "0x2583440", VA = "0x182584840", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06029E97 RID: 171671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E97")]
		[Address(RVA = "0x2584A60", Offset = "0x2583660", VA = "0x182584A60", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x06029E98 RID: 171672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E98")]
		[Address(RVA = "0x2585530", Offset = "0x2584130", VA = "0x182585530")]
		private void _OnCampSelected(object _)
		{
		}

		// Token: 0x06029E99 RID: 171673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E99")]
		[Address(RVA = "0x2584E50", Offset = "0x2583A50", VA = "0x182584E50")]
		private void _InitCampSelectView()
		{
		}

		// Token: 0x06029E9A RID: 171674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E9A")]
		[Address(RVA = "0x2585210", Offset = "0x2583E10", VA = "0x182585210")]
		private void _OnCampSelectConfirmed(string campId)
		{
		}

		// Token: 0x06029E9B RID: 171675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E9B")]
		[Address(RVA = "0x2585190", Offset = "0x2583D90", VA = "0x182585190")]
		private void _OnCampResultConfirmed()
		{
		}

		// Token: 0x06029E9C RID: 171676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029E9C")]
		[Address(RVA = "0x2584600", Offset = "0x2583200", VA = "0x182584600", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x06029E9D RID: 171677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E9D")]
		[Address(RVA = "0x2584740", Offset = "0x2583340", VA = "0x182584740", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x06029E9E RID: 171678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029E9E")]
		[Address(RVA = "0x2584BF0", Offset = "0x25837F0", VA = "0x182584BF0", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x06029E9F RID: 171679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E9F")]
		[Address(RVA = "0x2584D30", Offset = "0x2583930", VA = "0x182584D30", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x06029EA0 RID: 171680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EA0")]
		[Address(RVA = "0x25856B0", Offset = "0x25842B0", VA = "0x1825856B0")]
		public Act3D0CampSelectState()
		{
		}

		// Token: 0x06029EA1 RID: 171681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EA1")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06029EA2 RID: 171682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EA2")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0403C106 RID: 246022
		[Token(Token = "0x403C106")]
		private const float FADE_DURATION = 0.23f;

		// Token: 0x0403C107 RID: 246023
		[Token(Token = "0x403C107")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x0403C108 RID: 246024
		[Token(Token = "0x403C108")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _campSelectContainer;

		// Token: 0x0403C109 RID: 246025
		[Token(Token = "0x403C109")]
		[FieldOffset(Offset = "0x70")]
		private Act3D0CampSelectView m_campSelectView;

		// Token: 0x0403C10A RID: 246026
		[Token(Token = "0x403C10A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403C10B RID: 246027
		[Token(Token = "0x403C10B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403C10C RID: 246028
		[Token(Token = "0x403C10C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0403C10D RID: 246029
		[Token(Token = "0x403C10D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnCampSelected;

		// Token: 0x0403C10E RID: 246030
		[Token(Token = "0x403C10E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitCampSelectView;

		// Token: 0x0403C10F RID: 246031
		[Token(Token = "0x403C10F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnCampSelectConfirmed;

		// Token: 0x0403C110 RID: 246032
		[Token(Token = "0x403C110")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnCampResultConfirmed;

		// Token: 0x0403C111 RID: 246033
		[Token(Token = "0x403C111")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0403C112 RID: 246034
		[Token(Token = "0x403C112")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x0403C113 RID: 246035
		[Token(Token = "0x403C113")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0403C114 RID: 246036
		[Token(Token = "0x403C114")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x0403C115 RID: 246037
		[Token(Token = "0x403C115")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
