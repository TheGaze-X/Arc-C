using System;
using DG.Tweening;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x020036FC RID: 14076
	[Token(Token = "0x20036FC")]
	public class UIStateTransitionTween<TState> where TState : struct
	{
		// Token: 0x170035AA RID: 13738
		// (get) Token: 0x0601659C RID: 91548 RVA: 0x00090AE0 File Offset: 0x0008ECE0
		[Token(Token = "0x170035AA")]
		public bool isPlaying
		{
			[Token(Token = "0x601659C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170035AB RID: 13739
		// (get) Token: 0x0601659D RID: 91549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170035AB")]
		public TState state
		{
			[Token(Token = "0x601659D")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601659E RID: 91550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601659E")]
		public UIStateTransitionTween(TState defaultState)
		{
		}

		// Token: 0x0601659F RID: 91551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601659F")]
		public void SetTweenProvider(TState fromState, TState toState, UIStateTransitionTween<TState>.TweenProvider tweenProvider)
		{
		}

		// Token: 0x060165A0 RID: 91552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165A0")]
		public void GoToState(TState toState, bool isFastMode = false)
		{
		}

		// Token: 0x060165A1 RID: 91553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165A1")]
		private void _SetCurrentStateAndUpdateKey(TState state)
		{
		}

		// Token: 0x060165A2 RID: 91554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60165A2")]
		private EnumIntDictionary<TState, UIStateTransitionTween<TState>.TweenProvider> _GetStateTweenDict(TState state)
		{
			return null;
		}

		// Token: 0x060165A3 RID: 91555 RVA: 0x00090AF8 File Offset: 0x0008ECF8
		[Token(Token = "0x60165A3")]
		private bool _TryGetTransition(TState fromState, TState toState, out UIStateTransitionTween<TState>.TweenProvider tweenProvider)
		{
			return default(bool);
		}

		// Token: 0x0401AE33 RID: 110131
		[Token(Token = "0x401AE33")]
		[FieldOffset(Offset = "0x0")]
		private EnumIntDictionary<TState, EnumIntDictionary<TState, UIStateTransitionTween<TState>.TweenProvider>> m_tweenDict;

		// Token: 0x0401AE34 RID: 110132
		[Token(Token = "0x401AE34")]
		[FieldOffset(Offset = "0x0")]
		private Tween m_cachedTween;

		// Token: 0x0401AE35 RID: 110133
		[Token(Token = "0x401AE35")]
		[FieldOffset(Offset = "0x0")]
		private TState m_currentState;

		// Token: 0x0401AE36 RID: 110134
		[Token(Token = "0x401AE36")]
		[FieldOffset(Offset = "0x0")]
		private int m_currentStateIntKey;

		// Token: 0x020036FD RID: 14077
		// (Invoke) Token: 0x060165A5 RID: 91557
		[Token(Token = "0x20036FD")]
		public delegate Tween TweenProvider();
	}
}
