using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003929 RID: 14633
	[Token(Token = "0x2003929")]
	public abstract class UIPopupState : State
	{
		// Token: 0x0601720F RID: 94735
		[Token(Token = "0x601720F")]
		protected abstract IEnumerator ShowCoroutine(UIPopupState.TransactionContext context);

		// Token: 0x06017210 RID: 94736
		[Token(Token = "0x6017210")]
		protected abstract IEnumerator HideCoroutine(UIPopupState.TransactionContext context);

		// Token: 0x06017211 RID: 94737
		[Token(Token = "0x6017211")]
		protected abstract void ShowImmediately(UIPopupState.TransactionContext context);

		// Token: 0x06017212 RID: 94738
		[Token(Token = "0x6017212")]
		protected abstract void HideImmediately(UIPopupState.TransactionContext context);

		// Token: 0x06017213 RID: 94739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017213")]
		[Address(RVA = "0xF971C0", Offset = "0xF95DC0", VA = "0x180F971C0", Slot = "27")]
		protected virtual void DealWithOtherStateBeforeTransStart(UIPopupState.TransactionContext context, bool isFastMode)
		{
		}

		// Token: 0x06017214 RID: 94740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017214")]
		[Address(RVA = "0xF97320", Offset = "0xF95F20", VA = "0x180F97320", Slot = "28")]
		protected virtual void DealWithOtherStateWenTransEnd(UIPopupState.TransactionContext context, bool isFastMode)
		{
		}

		// Token: 0x06017215 RID: 94741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017215")]
		[Address(RVA = "0xF97920", Offset = "0xF96520", VA = "0x180F97920")]
		protected void SetStateActiveWithCustomize(State state, bool active)
		{
		}

		// Token: 0x06017216 RID: 94742 RVA: 0x00094F50 File Offset: 0x00093150
		[Token(Token = "0x6017216")]
		[Address(RVA = "0xF976A0", Offset = "0xF962A0", VA = "0x180F976A0")]
		protected static bool SetActiveByCanvasGroup(GameObject obj, bool active)
		{
			return default(bool);
		}

		// Token: 0x06017217 RID: 94743 RVA: 0x00094F68 File Offset: 0x00093168
		[Token(Token = "0x6017217")]
		[Address(RVA = "0xF97820", Offset = "0xF96420", VA = "0x180F97820")]
		protected static bool SetActiveByCanvasGroup(CanvasGroup canvasGroup, bool active)
		{
			return default(bool);
		}

		// Token: 0x06017218 RID: 94744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017218")]
		[Address(RVA = "0xF97480", Offset = "0xF96080", VA = "0x180F97480", Slot = "20")]
		public override ITransAction PickDynamicTransAction(State otherState, TransitionType transType)
		{
			return null;
		}

		// Token: 0x06017219 RID: 94745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017219")]
		[Address(RVA = "0xF981A0", Offset = "0xF96DA0", VA = "0x180F981A0")]
		private void _ShowTransEffect(UIPopupState.TransactionContext context, bool isFastMode)
		{
		}

		// Token: 0x0601721A RID: 94746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601721A")]
		[Address(RVA = "0xF97BF0", Offset = "0xF967F0", VA = "0x180F97BF0")]
		private void _HideTransEffect(UIPopupState.TransactionContext context, bool isFastMode)
		{
		}

		// Token: 0x0601721B RID: 94747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601721B")]
		[Address(RVA = "0xF98050", Offset = "0xF96C50", VA = "0x180F98050")]
		private IEnumerator _ShowCoroutineInternal(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0601721C RID: 94748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601721C")]
		[Address(RVA = "0xF97AA0", Offset = "0xF966A0", VA = "0x180F97AA0")]
		private IEnumerator _HideCoroutineInternal(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0601721D RID: 94749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601721D")]
		[Address(RVA = "0xF97EF0", Offset = "0xF96AF0", VA = "0x180F97EF0")]
		private void _InvokeTransitionEnd(UIPopupState.TransactionContext context, bool isFastMode)
		{
		}

		// Token: 0x0601721E RID: 94750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601721E")]
		[Address(RVA = "0xF984A0", Offset = "0xF970A0", VA = "0x180F984A0")]
		protected UIPopupState()
		{
		}

		// Token: 0x0601721F RID: 94751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601721F")]
		[Address(RVA = "0xF97A90", Offset = "0xF96690", VA = "0x180F97A90")]
		private ITransAction <>xLuaBaseProxy_PickDynamicTransAction(State P0, TransitionType P1)
		{
			return null;
		}

		// Token: 0x0401BEC0 RID: 114368
		[Token(Token = "0x401BEC0")]
		public const float POP_SMOOTH_DELAY = 0.05f;

		// Token: 0x0401BEC1 RID: 114369
		[Token(Token = "0x401BEC1")]
		[FieldOffset(Offset = "0x50")]
		private UIPopupState.StateTransition m_enterIn;

		// Token: 0x0401BEC2 RID: 114370
		[Token(Token = "0x401BEC2")]
		[FieldOffset(Offset = "0x58")]
		private UIPopupState.StateTransition m_exitBack;

		// Token: 0x0401BEC3 RID: 114371
		[Token(Token = "0x401BEC3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DealWithOtherStateBeforeTransStart;

		// Token: 0x0401BEC4 RID: 114372
		[Token(Token = "0x401BEC4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DealWithOtherStateWenTransEnd;

		// Token: 0x0401BEC5 RID: 114373
		[Token(Token = "0x401BEC5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetStateActiveWithCustomize;

		// Token: 0x0401BEC6 RID: 114374
		[Token(Token = "0x401BEC6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetActiveByCanvasGroup;

		// Token: 0x0401BEC7 RID: 114375
		[Token(Token = "0x401BEC7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix1_SetActiveByCanvasGroup;

		// Token: 0x0401BEC8 RID: 114376
		[Token(Token = "0x401BEC8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_PickDynamicTransAction;

		// Token: 0x0401BEC9 RID: 114377
		[Token(Token = "0x401BEC9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ShowTransEffect;

		// Token: 0x0401BECA RID: 114378
		[Token(Token = "0x401BECA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__HideTransEffect;

		// Token: 0x0401BECB RID: 114379
		[Token(Token = "0x401BECB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ShowCoroutineInternal;

		// Token: 0x0401BECC RID: 114380
		[Token(Token = "0x401BECC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__HideCoroutineInternal;

		// Token: 0x0401BECD RID: 114381
		[Token(Token = "0x401BECD")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InvokeTransitionEnd;

		// Token: 0x0401BECE RID: 114382
		[Token(Token = "0x401BECE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200392A RID: 14634
		[Token(Token = "0x200392A")]
		protected struct TransactionContext
		{
			// Token: 0x0401BECF RID: 114383
			[Token(Token = "0x401BECF")]
			[FieldOffset(Offset = "0x0")]
			public State otherState;

			// Token: 0x0401BED0 RID: 114384
			[Token(Token = "0x401BED0")]
			[FieldOffset(Offset = "0x8")]
			public TransitionType transType;

			// Token: 0x0401BED1 RID: 114385
			[Token(Token = "0x401BED1")]
			[FieldOffset(Offset = "0x10")]
			public TransActionListener callback;
		}

		// Token: 0x0200392B RID: 14635
		[Token(Token = "0x200392B")]
		private class StateTransition : ITransAction
		{
			// Token: 0x06017220 RID: 94752 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017220")]
			[Address(RVA = "0xF902A0", Offset = "0xF8EEA0", VA = "0x180F902A0")]
			public StateTransition(UIPopupState closure, TransitionSide side, Action<UIPopupState.TransactionContext, bool> process)
			{
			}

			// Token: 0x1700373C RID: 14140
			// (get) Token: 0x06017221 RID: 94753 RVA: 0x00094F80 File Offset: 0x00093180
			[Token(Token = "0x1700373C")]
			public TransActionType ActionType
			{
				[Token(Token = "0x6017221")]
				[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "6")]
				get
				{
					return TransActionType.SEQUENTIAL;
				}
			}

			// Token: 0x06017222 RID: 94754 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017222")]
			[Address(RVA = "0xF90130", Offset = "0xF8ED30", VA = "0x180F90130", Slot = "4")]
			public void Execute(State fromState, State toState, TransActionListener mustInvokeEnd)
			{
			}

			// Token: 0x06017223 RID: 94755 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017223")]
			[Address(RVA = "0xF8FFC0", Offset = "0xF8EBC0", VA = "0x180F8FFC0", Slot = "5")]
			public void ExecuteFastMode(State fromState, State toState, TransActionListener mustInvokeEnd)
			{
			}

			// Token: 0x1700373D RID: 14141
			// (get) Token: 0x06017224 RID: 94756 RVA: 0x00094F98 File Offset: 0x00093198
			[Token(Token = "0x1700373D")]
			public UIPopupState.TransactionContext context
			{
				[Token(Token = "0x6017224")]
				[Address(RVA = "0xF90300", Offset = "0xF8EF00", VA = "0x180F90300")]
				get
				{
					return default(UIPopupState.TransactionContext);
				}
			}

			// Token: 0x0401BED2 RID: 114386
			[Token(Token = "0x401BED2")]
			[FieldOffset(Offset = "0x10")]
			private UIPopupState m_closure;

			// Token: 0x0401BED3 RID: 114387
			[Token(Token = "0x401BED3")]
			[FieldOffset(Offset = "0x18")]
			private Action<UIPopupState.TransactionContext, bool> m_process;

			// Token: 0x0401BED4 RID: 114388
			[Token(Token = "0x401BED4")]
			[FieldOffset(Offset = "0x20")]
			private TransitionSide m_side;

			// Token: 0x0401BED5 RID: 114389
			[Token(Token = "0x401BED5")]
			[FieldOffset(Offset = "0x28")]
			private UIPopupState.TransactionContext m_context;

			// Token: 0x0401BED6 RID: 114390
			[Token(Token = "0x401BED6")]
			[FieldOffset(Offset = "0x48")]
			public TransitionType transType;
		}
	}
}
