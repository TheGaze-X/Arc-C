using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013EF RID: 5103
	[Token(Token = "0x20013EF")]
	public class HierachyStateMachine<StateType, DataType, BlackboardType> : StateMachine where StateType : struct where BlackboardType : class, StateMachine.IBlackboard
	{
		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x06007484 RID: 29828 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007485 RID: 29829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000E3B")]
		public DataType data
		{
			[Token(Token = "0x6007484")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6007485")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x06007486 RID: 29830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E3C")]
		public BlackboardType blackboard
		{
			[Token(Token = "0x6007486")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x06007487 RID: 29831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E3D")]
		public override string stateDebugString
		{
			[Token(Token = "0x6007487")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x06007488 RID: 29832 RVA: 0x00033CD8 File Offset: 0x00031ED8
		[Token(Token = "0x17000E3E")]
		protected override bool manageBlackboard
		{
			[Token(Token = "0x6007488")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007489 RID: 29833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007489")]
		public HierachyStateMachine(DataType data, BlackboardType blackboard)
		{
		}

		// Token: 0x0600748A RID: 29834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600748A")]
		public void SwitchState(StateType toState)
		{
		}

		// Token: 0x0600748B RID: 29835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600748B")]
		public void RegisterState(StateType state, HierachyStateMachine<StateType, DataType, BlackboardType>.StateNode stateNode, bool asDefault = false)
		{
		}

		// Token: 0x020013F0 RID: 5104
		[Token(Token = "0x20013F0")]
		public class StateNode : StateMachine.IStateNode
		{
			// Token: 0x17000E3F RID: 3647
			// (get) Token: 0x0600748C RID: 29836 RVA: 0x00033CF0 File Offset: 0x00031EF0
			[Token(Token = "0x17000E3F")]
			public bool isActiveNode
			{
				[Token(Token = "0x600748C")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000E40 RID: 3648
			// (get) Token: 0x0600748D RID: 29837 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E40")]
			protected DataType data
			{
				[Token(Token = "0x600748D")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000E41 RID: 3649
			// (get) Token: 0x0600748E RID: 29838 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E41")]
			protected BlackboardType blackboard
			{
				[Token(Token = "0x600748E")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000E42 RID: 3650
			// (get) Token: 0x0600748F RID: 29839 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E42")]
			protected HierachyStateMachine<StateType, DataType, BlackboardType> stateMachine
			{
				[Token(Token = "0x600748F")]
				get
				{
					return null;
				}
			}

			// Token: 0x06007490 RID: 29840 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007490")]
			public virtual void OnInit(HierachyStateMachine<StateType, DataType, BlackboardType> stateMachine)
			{
			}

			// Token: 0x06007491 RID: 29841 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007491")]
			public virtual void OnEnter(int lastState)
			{
			}

			// Token: 0x06007492 RID: 29842 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007492")]
			public virtual void OnExit(int newState)
			{
			}

			// Token: 0x06007493 RID: 29843 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007493")]
			public virtual void OnTick(FP deltaTime)
			{
			}

			// Token: 0x06007494 RID: 29844 RVA: 0x00033D08 File Offset: 0x00031F08
			[Token(Token = "0x6007494")]
			public virtual bool CheckSwitchOut(int nextState)
			{
				return default(bool);
			}

			// Token: 0x06007495 RID: 29845 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007495")]
			protected void SwitchState(StateType type)
			{
			}

			// Token: 0x06007496 RID: 29846 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007496")]
			public StateNode()
			{
			}

			// Token: 0x040071D4 RID: 29140
			[Token(Token = "0x40071D4")]
			[FieldOffset(Offset = "0x0")]
			private HierachyStateMachine<StateType, DataType, BlackboardType> m_stateMachine;
		}

		// Token: 0x020013F1 RID: 5105
		[Token(Token = "0x20013F1")]
		public class SubStateMachine<SubStateType> : HierachyStateMachine<SubStateType, DataType, BlackboardType> where SubStateType : struct
		{
			// Token: 0x17000E43 RID: 3651
			// (get) Token: 0x06007497 RID: 29847 RVA: 0x00033D20 File Offset: 0x00031F20
			[Token(Token = "0x17000E43")]
			protected override bool manageBlackboard
			{
				[Token(Token = "0x6007497")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06007498 RID: 29848 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007498")]
			public SubStateMachine(HierachyStateMachine<StateType, DataType, BlackboardType> parent)
			{
			}

			// Token: 0x040071D5 RID: 29141
			[Token(Token = "0x40071D5")]
			[FieldOffset(Offset = "0x0")]
			protected HierachyStateMachine<StateType, DataType, BlackboardType> parent;
		}

		// Token: 0x020013F2 RID: 5106
		[Token(Token = "0x20013F2")]
		public abstract class SubStateMachineNode<SubStateType> : HierachyStateMachine<StateType, DataType, BlackboardType>.StateNode where SubStateType : struct
		{
			// Token: 0x17000E44 RID: 3652
			// (get) Token: 0x06007499 RID: 29849 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600749A RID: 29850 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000E44")]
			private protected HierachyStateMachine<StateType, DataType, BlackboardType>.SubStateMachine<SubStateType> subStateMachine
			{
				[Token(Token = "0x6007499")]
				[CompilerGenerated]
				protected get
				{
					return null;
				}
				[Token(Token = "0x600749A")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0600749B RID: 29851 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600749B")]
			public override void OnInit(HierachyStateMachine<StateType, DataType, BlackboardType> stateMachine)
			{
			}

			// Token: 0x0600749C RID: 29852 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600749C")]
			public override void OnEnter(int lastState)
			{
			}

			// Token: 0x0600749D RID: 29853 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600749D")]
			public override void OnTick(FP deltaTime)
			{
			}

			// Token: 0x0600749E RID: 29854 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600749E")]
			public override void OnExit(int newState)
			{
			}

			// Token: 0x0600749F RID: 29855 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600749F")]
			protected void SwitchParentState(StateType toState)
			{
			}

			// Token: 0x060074A0 RID: 29856
			[Token(Token = "0x60074A0")]
			protected abstract void ExitByDefault();

			// Token: 0x060074A1 RID: 29857
			[Token(Token = "0x60074A1")]
			protected abstract void InitStateMachine(HierachyStateMachine<StateType, DataType, BlackboardType>.SubStateMachine<SubStateType> stateMachine);

			// Token: 0x060074A2 RID: 29858 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60074A2")]
			protected SubStateMachineNode()
			{
			}

			// Token: 0x020013F3 RID: 5107
			[Token(Token = "0x20013F3")]
			protected class SubStateNode : HierachyStateMachine<SubStateType, DataType, BlackboardType>.StateNode
			{
				// Token: 0x17000E45 RID: 3653
				// (get) Token: 0x060074A3 RID: 29859 RVA: 0x00002050 File Offset: 0x00000250
				// (set) Token: 0x060074A4 RID: 29860 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x17000E45")]
				private protected HierachyStateMachine<StateType, DataType, BlackboardType>.SubStateMachineNode<SubStateType> parentState
				{
					[Token(Token = "0x60074A3")]
					[CompilerGenerated]
					protected get
					{
						return null;
					}
					[Token(Token = "0x60074A4")]
					[CompilerGenerated]
					private set
					{
					}
				}

				// Token: 0x060074A5 RID: 29861 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60074A5")]
				public SubStateNode(HierachyStateMachine<StateType, DataType, BlackboardType>.SubStateMachineNode<SubStateType> parentState)
				{
				}

				// Token: 0x060074A6 RID: 29862 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60074A6")]
				protected void SwitchParentState(StateType toState)
				{
				}

				// Token: 0x060074A7 RID: 29863 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60074A7")]
				protected void ExitParentByDefault()
				{
				}
			}
		}
	}
}
