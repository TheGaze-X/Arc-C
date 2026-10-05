using System;
using System.Collections;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu;
using UnityEngine;
using XLua;

namespace HGSDK.UI
{
	// Token: 0x020001CF RID: 463
	[Token(Token = "0x20001CF")]
	public class UIStateMachine<StateType> : EnumStateMachine<StateType> where StateType : struct
	{
		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060007F7 RID: 2039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000118")]
		private protected HGSDK.UIPage page
		{
			[Token(Token = "0x60007F6")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x60007F7")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000119")]
		protected new UIStateMachine<StateType>.IUIState currentState
		{
			[Token(Token = "0x60007F8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060007F9 RID: 2041 RVA: 0x00003DE0 File Offset: 0x00001FE0
		// (set) Token: 0x060007FA RID: 2042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700011A")]
		private protected bool isTransiting
		{
			[Token(Token = "0x60007F9")]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x60007FA")]
			private set
			{
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060007FB RID: 2043 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060007FC RID: 2044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000001")]
		public event Action<UIStateMachine<StateType>.IUIState, UIStateMachine<StateType>.IUIState> onStateTransitionStart
		{
			[Token(Token = "0x60007FB")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007FC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060007FD RID: 2045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011B")]
		public StateType state
		{
			[Token(Token = "0x60007FD")]
			get
			{
				return null;
			}
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007FE")]
		public UIStateMachine(HGSDK.UIPage page)
		{
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007FF")]
		public void RegisterState(UIStateMachine<StateType>.IUIState stateNode, bool asDefault = false)
		{
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000800")]
		public new void SwitchState(StateType toState)
		{
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000801")]
		public void SwitchState(StateType toState, float duration)
		{
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000802")]
		private UIStateMachine<StateType>.IUIState _GetState(StateType stateType)
		{
			return null;
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000803")]
		private IEnumerator _DoTransition(UIStateMachine<StateType>.TransitionParam param)
		{
			return null;
		}

		// Token: 0x04000A3B RID: 2619
		[Token(Token = "0x4000A3B")]
		[FieldOffset(Offset = "0x0")]
		private bool m_isTransitting;

		// Token: 0x04000A3C RID: 2620
		[Token(Token = "0x4000A3C")]
		[FieldOffset(Offset = "0x0")]
		private Coroutine m_transitCoroutine;

		// Token: 0x020001D0 RID: 464
		[Token(Token = "0x20001D0")]
		public interface IUIState : StateMachine.IStateNode
		{
			// Token: 0x1700011C RID: 284
			// (get) Token: 0x06000804 RID: 2052
			[Token(Token = "0x1700011C")]
			StateType myState { [Token(Token = "0x6000804")] get; }

			// Token: 0x06000805 RID: 2053
			[Token(Token = "0x6000805")]
			void OnRegister(UIStateMachine<StateType> stateMachine, HGSDK.UIPage page);

			// Token: 0x06000806 RID: 2054
			[Token(Token = "0x6000806")]
			IEnumerator ShowCoroutine(UIStateMachine<StateType>.TransitionParam param);

			// Token: 0x06000807 RID: 2055
			[Token(Token = "0x6000807")]
			IEnumerator HideCoroutine(UIStateMachine<StateType>.TransitionParam param);
		}

		// Token: 0x020001D1 RID: 465
		[Token(Token = "0x20001D1")]
		[RequireComponent(typeof(CanvasGroup))]
		public abstract class UIStateBehaviour : MonoBehaviour, UIStateMachine<StateType>.IUIState, StateMachine.IStateNode, IHotfixable
		{
			// Token: 0x1700011D RID: 285
			// (get) Token: 0x06000808 RID: 2056
			[Token(Token = "0x1700011D")]
			public abstract StateType myState { [Token(Token = "0x6000808")] get; }

			// Token: 0x1700011E RID: 286
			// (get) Token: 0x06000809 RID: 2057 RVA: 0x00003DF8 File Offset: 0x00001FF8
			[Token(Token = "0x1700011E")]
			public bool isActiveNode
			{
				[Token(Token = "0x6000809")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700011F RID: 287
			// (get) Token: 0x0600080A RID: 2058 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700011F")]
			protected CanvasGroup canvasGroup
			{
				[Token(Token = "0x600080A")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000120 RID: 288
			// (get) Token: 0x0600080B RID: 2059 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600080C RID: 2060 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000120")]
			private protected HGSDK.UIPage page
			{
				[Token(Token = "0x600080B")]
				[CompilerGenerated]
				protected get
				{
					return null;
				}
				[Token(Token = "0x600080C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000121 RID: 289
			// (get) Token: 0x0600080D RID: 2061 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000121")]
			protected UIStateMachine<StateType> stateMachine
			{
				[Token(Token = "0x600080D")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600080E RID: 2062 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600080E")]
			public virtual void OnRegister(UIStateMachine<StateType> stateMachine, HGSDK.UIPage page)
			{
			}

			// Token: 0x0600080F RID: 2063 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600080F")]
			public virtual IEnumerator ShowCoroutine(UIStateMachine<StateType>.TransitionParam param)
			{
				return null;
			}

			// Token: 0x06000810 RID: 2064 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000810")]
			public virtual IEnumerator HideCoroutine(UIStateMachine<StateType>.TransitionParam param)
			{
				return null;
			}

			// Token: 0x06000811 RID: 2065 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000811")]
			public virtual void OnEnter(int lastState)
			{
			}

			// Token: 0x06000812 RID: 2066 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000812")]
			public virtual void OnExit(int nextState)
			{
			}

			// Token: 0x06000813 RID: 2067 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000813")]
			public virtual void OnTick(FP deltaTime)
			{
			}

			// Token: 0x06000814 RID: 2068 RVA: 0x00003E10 File Offset: 0x00002010
			[Token(Token = "0x6000814")]
			public virtual bool CheckSwitchOut(int nextState)
			{
				return default(bool);
			}

			// Token: 0x06000815 RID: 2069 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000815")]
			protected virtual void ActiveState()
			{
			}

			// Token: 0x06000816 RID: 2070 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000816")]
			protected virtual void DeactiveState()
			{
			}

			// Token: 0x06000817 RID: 2071 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000817")]
			protected virtual void OnDestroy()
			{
			}

			// Token: 0x06000818 RID: 2072 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000818")]
			private void _ClearTween()
			{
			}

			// Token: 0x06000819 RID: 2073 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000819")]
			protected UIStateBehaviour()
			{
			}

			// Token: 0x04000A3F RID: 2623
			[Token(Token = "0x4000A3F")]
			[FieldOffset(Offset = "0x0")]
			private CanvasGroup m_canvasGroup;

			// Token: 0x04000A40 RID: 2624
			[Token(Token = "0x4000A40")]
			[FieldOffset(Offset = "0x0")]
			private UIStateMachine<StateType> m_stateMachine;

			// Token: 0x04000A41 RID: 2625
			[Token(Token = "0x4000A41")]
			[FieldOffset(Offset = "0x0")]
			private Tween m_lastTween;

			// Token: 0x04000A43 RID: 2627
			[Token(Token = "0x4000A43")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isActiveNode;

			// Token: 0x04000A44 RID: 2628
			[Token(Token = "0x4000A44")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_canvasGroup;

			// Token: 0x04000A45 RID: 2629
			[Token(Token = "0x4000A45")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_page;

			// Token: 0x04000A46 RID: 2630
			[Token(Token = "0x4000A46")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_set_page;

			// Token: 0x04000A47 RID: 2631
			[Token(Token = "0x4000A47")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_stateMachine;

			// Token: 0x04000A48 RID: 2632
			[Token(Token = "0x4000A48")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnRegister;

			// Token: 0x04000A49 RID: 2633
			[Token(Token = "0x4000A49")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_ShowCoroutine;

			// Token: 0x04000A4A RID: 2634
			[Token(Token = "0x4000A4A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_HideCoroutine;

			// Token: 0x04000A4B RID: 2635
			[Token(Token = "0x4000A4B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnEnter;

			// Token: 0x04000A4C RID: 2636
			[Token(Token = "0x4000A4C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnExit;

			// Token: 0x04000A4D RID: 2637
			[Token(Token = "0x4000A4D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnTick;

			// Token: 0x04000A4E RID: 2638
			[Token(Token = "0x4000A4E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CheckSwitchOut;

			// Token: 0x04000A4F RID: 2639
			[Token(Token = "0x4000A4F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_ActiveState;

			// Token: 0x04000A50 RID: 2640
			[Token(Token = "0x4000A50")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_DeactiveState;

			// Token: 0x04000A51 RID: 2641
			[Token(Token = "0x4000A51")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnDestroy;

			// Token: 0x04000A52 RID: 2642
			[Token(Token = "0x4000A52")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__ClearTween;

			// Token: 0x04000A53 RID: 2643
			[Token(Token = "0x4000A53")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020001D4 RID: 468
		[Token(Token = "0x20001D4")]
		public struct TransitionParam
		{
			// Token: 0x04000A5C RID: 2652
			[Token(Token = "0x4000A5C")]
			[FieldOffset(Offset = "0x0")]
			public StateType fromState;

			// Token: 0x04000A5D RID: 2653
			[Token(Token = "0x4000A5D")]
			[FieldOffset(Offset = "0x0")]
			public StateType toState;

			// Token: 0x04000A5E RID: 2654
			[Token(Token = "0x4000A5E")]
			[FieldOffset(Offset = "0x0")]
			public float duration;
		}
	}
}
