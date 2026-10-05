using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013EE RID: 5102
	[Token(Token = "0x20013EE")]
	public class TypeStateMachine : StateMachine
	{
		// Token: 0x0600747F RID: 29823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600747F")]
		[Address(RVA = "0x2216060", Offset = "0x2214C60", VA = "0x182216060")]
		public TypeStateMachine()
		{
		}

		// Token: 0x06007480 RID: 29824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007480")]
		[Address(RVA = "0x22160F0", Offset = "0x2214CF0", VA = "0x1822160F0")]
		public TypeStateMachine(StateMachine.IBlackboard blackboard)
		{
		}

		// Token: 0x06007481 RID: 29825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007481")]
		[Address(RVA = "0x2215F50", Offset = "0x2214B50", VA = "0x182215F50")]
		public void SwitchState(StateMachine.IStateNode toState)
		{
		}

		// Token: 0x06007482 RID: 29826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007482")]
		[Address(RVA = "0x2215E70", Offset = "0x2214A70", VA = "0x182215E70", Slot = "10")]
		public virtual void RegisterState(StateMachine.IStateNode stateNode, bool asDefault = false)
		{
		}

		// Token: 0x06007483 RID: 29827 RVA: 0x00033CC0 File Offset: 0x00031EC0
		[Token(Token = "0x6007483")]
		[Address(RVA = "0x2215FA0", Offset = "0x2214BA0", VA = "0x182215FA0")]
		protected int Type2Int(Type type)
		{
			return 0;
		}

		// Token: 0x040071D2 RID: 29138
		[Token(Token = "0x40071D2")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<Type, int> m_type2int;
	}
}
