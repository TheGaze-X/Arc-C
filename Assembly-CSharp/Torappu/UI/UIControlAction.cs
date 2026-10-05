using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x02003688 RID: 13960
	[Token(Token = "0x2003688")]
	public sealed class UIControlAction : BehaviourTransAction
	{
		// Token: 0x0601634F RID: 90959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601634F")]
		[Address(RVA = "0xEA3430", Offset = "0xEA2030", VA = "0x180EA3430", Slot = "7")]
		public override void Execute(State fromState, State toState, TransActionListener mustInvokeEnd)
		{
		}

		// Token: 0x06016350 RID: 90960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016350")]
		[Address(RVA = "0xEA33E0", Offset = "0xEA1FE0", VA = "0x180EA33E0", Slot = "9")]
		public override void ExecuteFastMode(State fromState, State toState, TransActionListener mustInvokeEnd)
		{
		}

		// Token: 0x17003562 RID: 13666
		// (get) Token: 0x06016351 RID: 90961 RVA: 0x0008FFA0 File Offset: 0x0008E1A0
		[Token(Token = "0x17003562")]
		public override TransActionType ActionType
		{
			[Token(Token = "0x6016351")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "8")]
			get
			{
				return TransActionType.SEQUENTIAL;
			}
		}

		// Token: 0x06016352 RID: 90962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016352")]
		[Address(RVA = "0xEA34F0", Offset = "0xEA20F0", VA = "0x180EA34F0")]
		private void _OnAnimationEnd()
		{
		}

		// Token: 0x06016353 RID: 90963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016353")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UIControlAction()
		{
		}

		// Token: 0x0401AAF4 RID: 109300
		[Token(Token = "0x401AAF4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TransActionType m_type;

		// Token: 0x0401AAF5 RID: 109301
		[Token(Token = "0x401AAF5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationSequence m_animationSequence;

		// Token: 0x0401AAF6 RID: 109302
		[Token(Token = "0x401AAF6")]
		[FieldOffset(Offset = "0x28")]
		private TransActionListener m_listener;
	}
}
