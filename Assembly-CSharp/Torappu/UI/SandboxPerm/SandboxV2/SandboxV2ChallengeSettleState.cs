using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004172 RID: 16754
	[Token(Token = "0x2004172")]
	public class SandboxV2ChallengeSettleState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x06019DC4 RID: 105924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019DC4")]
		[Address(RVA = "0x12B7DD0", Offset = "0x12B69D0", VA = "0x1812B7DD0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06019DC5 RID: 105925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DC5")]
		[Address(RVA = "0x12B7E30", Offset = "0x12B6A30", VA = "0x1812B7E30", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06019DC6 RID: 105926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019DC6")]
		[Address(RVA = "0x12B80C0", Offset = "0x12B6CC0", VA = "0x1812B80C0", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x06019DC7 RID: 105927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DC7")]
		[Address(RVA = "0x12B8210", Offset = "0x12B6E10", VA = "0x1812B8210", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x06019DC8 RID: 105928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DC8")]
		[Address(RVA = "0x12B8010", Offset = "0x12B6C10", VA = "0x1812B8010", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06019DC9 RID: 105929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DC9")]
		[Address(RVA = "0x12B83F0", Offset = "0x12B6FF0", VA = "0x1812B83F0")]
		private void _OnConfirmClicked()
		{
		}

		// Token: 0x06019DCA RID: 105930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DCA")]
		[Address(RVA = "0x12B8700", Offset = "0x12B7300", VA = "0x1812B8700")]
		public SandboxV2ChallengeSettleState()
		{
		}

		// Token: 0x06019DCC RID: 105932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DCC")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06019DCD RID: 105933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019DCD")]
		[Address(RVA = "0x1089D20", Offset = "0x1088920", VA = "0x181089D20")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x06019DCE RID: 105934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DCE")]
		[Address(RVA = "0x12B83C0", Offset = "0x12B6FC0", VA = "0x1812B83C0")]
		private void <>xLuaBaseProxy_ShowImmediately(UIPopupState.TransactionContext P0)
		{
		}

		// Token: 0x040207D4 RID: 133076
		[Token(Token = "0x40207D4")]
		[NonSerialized]
		public const int ON_CONFIRM_CLICKED = 0;

		// Token: 0x040207D5 RID: 133077
		[Token(Token = "0x40207D5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SandboxV2ChallengeSettleView _challengeSettleView;

		// Token: 0x040207D6 RID: 133078
		[Token(Token = "0x40207D6")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _animShow;

		// Token: 0x040207D7 RID: 133079
		[Token(Token = "0x40207D7")]
		[FieldOffset(Offset = "0x88")]
		private SandboxV2ChallengeSettleState.SandboxV2ChallengeSettleStateBean m_stateBean;

		// Token: 0x040207D8 RID: 133080
		[Token(Token = "0x40207D8")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_showTween;

		// Token: 0x040207D9 RID: 133081
		[Token(Token = "0x40207D9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040207DA RID: 133082
		[Token(Token = "0x40207DA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040207DB RID: 133083
		[Token(Token = "0x40207DB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x040207DC RID: 133084
		[Token(Token = "0x40207DC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x040207DD RID: 133085
		[Token(Token = "0x40207DD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x040207DE RID: 133086
		[Token(Token = "0x40207DE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnConfirmClicked;

		// Token: 0x040207DF RID: 133087
		[Token(Token = "0x40207DF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004173 RID: 16755
		[Token(Token = "0x2004173")]
		public class SandboxV2ChallengeSettleStateBean : IStateBean, IHotfixable
		{
			// Token: 0x06019DCF RID: 105935 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019DCF")]
			[Address(RVA = "0x12B7CE0", Offset = "0x12B68E0", VA = "0x1812B7CE0")]
			public SandboxV2ChallengeSettleStateBean()
			{
			}

			// Token: 0x040207E0 RID: 133088
			[Token(Token = "0x40207E0")]
			[FieldOffset(Offset = "0x10")]
			public SandboxV2ChallengeSettleProperty property;

			// Token: 0x040207E1 RID: 133089
			[Token(Token = "0x40207E1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
