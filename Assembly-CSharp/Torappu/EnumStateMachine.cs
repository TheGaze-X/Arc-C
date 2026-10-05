using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013ED RID: 5101
	[Token(Token = "0x20013ED")]
	public class EnumStateMachine<StateType> : StateMachine where StateType : struct
	{
		// Token: 0x06007478 RID: 29816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007478")]
		public EnumStateMachine()
		{
		}

		// Token: 0x06007479 RID: 29817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007479")]
		public EnumStateMachine(StateMachine.IBlackboard blackboard)
		{
		}

		// Token: 0x0600747A RID: 29818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600747A")]
		public void Start(StateType stateType)
		{
		}

		// Token: 0x0600747B RID: 29819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600747B")]
		public void SwitchState(StateType toState)
		{
		}

		// Token: 0x0600747C RID: 29820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600747C")]
		public virtual void RegisterState(StateType state, StateMachine.IStateNode stateNode, bool asDefault = false)
		{
		}

		// Token: 0x0600747D RID: 29821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600747D")]
		public void SetDefaultState(StateType state)
		{
		}

		// Token: 0x0600747E RID: 29822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600747E")]
		protected StateMachine.IStateNode GetStateNode(StateType state)
		{
			return null;
		}
	}
}
