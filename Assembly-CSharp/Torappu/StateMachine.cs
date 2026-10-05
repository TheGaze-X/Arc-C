using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013E9 RID: 5097
	[Token(Token = "0x20013E9")]
	public class StateMachine
	{
		// Token: 0x17000E34 RID: 3636
		// (get) Token: 0x06007454 RID: 29780 RVA: 0x00033C30 File Offset: 0x00031E30
		// (set) Token: 0x06007455 RID: 29781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000E34")]
		public int currentStateId
		{
			[Token(Token = "0x6007454")]
			[Address(RVA = "0x14DAA90", Offset = "0x14D9690", VA = "0x1814DAA90")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6007455")]
			[Address(RVA = "0x14DAB10", Offset = "0x14D9710", VA = "0x1814DAB10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x06007456 RID: 29782 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007457 RID: 29783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000E35")]
		public StateMachine.IStateNode currentState
		{
			[Token(Token = "0x6007456")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6007457")]
			[Address(RVA = "0x5EC4C0", Offset = "0x5EB0C0", VA = "0x1805EC4C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E36 RID: 3638
		// (get) Token: 0x06007458 RID: 29784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E36")]
		public virtual string stateDebugString
		{
			[Token(Token = "0x6007458")]
			[Address(RVA = "0x2215150", Offset = "0x2213D50", VA = "0x182215150", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x06007459 RID: 29785 RVA: 0x00033C48 File Offset: 0x00031E48
		[Token(Token = "0x17000E37")]
		protected virtual bool manageBlackboard
		{
			[Token(Token = "0x6007459")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x0600745A RID: 29786 RVA: 0x00033C60 File Offset: 0x00031E60
		[Token(Token = "0x17000E38")]
		public bool isRunning
		{
			[Token(Token = "0x600745A")]
			[Address(RVA = "0x22150E0", Offset = "0x2213CE0", VA = "0x1822150E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x0600745B RID: 29787 RVA: 0x00033C78 File Offset: 0x00031E78
		[Token(Token = "0x17000E39")]
		public bool isLocked
		{
			[Token(Token = "0x600745B")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600745C RID: 29788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600745C")]
		[Address(RVA = "0x22148C0", Offset = "0x22134C0", VA = "0x1822148C0")]
		public void RegisterState(int stateId, StateMachine.IStateNode state, bool asDefault = false)
		{
		}

		// Token: 0x0600745D RID: 29789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600745D")]
		[Address(RVA = "0x22149E0", Offset = "0x22135E0", VA = "0x1822149E0")]
		public void Start(int stateId = 0)
		{
		}

		// Token: 0x0600745E RID: 29790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600745E")]
		[Address(RVA = "0x2214A70", Offset = "0x2213670", VA = "0x182214A70")]
		public void Stop()
		{
		}

		// Token: 0x0600745F RID: 29791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600745F")]
		[Address(RVA = "0x2214A90", Offset = "0x2213690", VA = "0x182214A90")]
		public void Tick(FP deltaTime)
		{
		}

		// Token: 0x06007460 RID: 29792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007460")]
		[Address(RVA = "0x2214A80", Offset = "0x2213680", VA = "0x182214A80")]
		public void SwitchState(int newStateId)
		{
		}

		// Token: 0x06007461 RID: 29793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007461")]
		[Address(RVA = "0x2214980", Offset = "0x2213580", VA = "0x182214980")]
		public void SetDefaultState(int stateId)
		{
		}

		// Token: 0x06007462 RID: 29794 RVA: 0x00033C90 File Offset: 0x00031E90
		[Token(Token = "0x6007462")]
		[Address(RVA = "0x4FD4B0", Offset = "0x4FC0B0", VA = "0x1804FD4B0")]
		public int GetDefaultState()
		{
			return 0;
		}

		// Token: 0x06007463 RID: 29795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007463")]
		[Address(RVA = "0x2214650", Offset = "0x2213250", VA = "0x182214650")]
		public StateMachine.IStateNode GetStateNode(int stateId)
		{
			return null;
		}

		// Token: 0x06007464 RID: 29796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007464")]
		[Address(RVA = "0x2214FF0", Offset = "0x2213BF0", VA = "0x182214FF0")]
		protected StateMachine(StateMachine.IBlackboard blackboard)
		{
		}

		// Token: 0x06007465 RID: 29797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007465")]
		[Address(RVA = "0x2214760", Offset = "0x2213360", VA = "0x182214760", Slot = "6")]
		protected virtual void OnStateChanged(int newStateId, int oldStateId)
		{
		}

		// Token: 0x06007466 RID: 29798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007466")]
		[Address(RVA = "0x22146D0", Offset = "0x22132D0", VA = "0x1822146D0", Slot = "7")]
		protected virtual void OnStart()
		{
		}

		// Token: 0x06007467 RID: 29799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007467")]
		[Address(RVA = "0x2214840", Offset = "0x2213440", VA = "0x182214840", Slot = "8")]
		protected virtual void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06007468 RID: 29800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007468")]
		[Address(RVA = "0x2214780", Offset = "0x2213380", VA = "0x182214780", Slot = "9")]
		protected virtual void OnTerminate(int lastStateId)
		{
		}

		// Token: 0x06007469 RID: 29801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007469")]
		[Address(RVA = "0x2214C10", Offset = "0x2213810", VA = "0x182214C10")]
		private void _SwitchStateInternal(int newStateId, bool force)
		{
		}

		// Token: 0x0600746A RID: 29802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600746A")]
		[Address(RVA = "0x2214B80", Offset = "0x2213780", VA = "0x182214B80")]
		private void _FinishSwitchState()
		{
		}

		// Token: 0x0600746B RID: 29803 RVA: 0x00033CA8 File Offset: 0x00031EA8
		[Token(Token = "0x600746B")]
		[Address(RVA = "0x2214B10", Offset = "0x2213710", VA = "0x182214B10")]
		private bool _CheckValidState(int state)
		{
			return default(bool);
		}

		// Token: 0x040071C6 RID: 29126
		[Token(Token = "0x40071C6")]
		public const int DEFAULT_STATE = 0;

		// Token: 0x040071C7 RID: 29127
		[Token(Token = "0x40071C7")]
		public const int TERMINAL_STATE = -1;

		// Token: 0x040071C8 RID: 29128
		[Token(Token = "0x40071C8")]
		[FieldOffset(Offset = "0x10")]
		public Action<int> onStarted;

		// Token: 0x040071C9 RID: 29129
		[Token(Token = "0x40071C9")]
		[FieldOffset(Offset = "0x18")]
		public Action<int, int> onStateChanged;

		// Token: 0x040071CA RID: 29130
		[Token(Token = "0x40071CA")]
		[FieldOffset(Offset = "0x20")]
		public Action<int> onTerminated;

		// Token: 0x040071CB RID: 29131
		[Token(Token = "0x40071CB")]
		[FieldOffset(Offset = "0x28")]
		private bool m_switchLocked;

		// Token: 0x040071CC RID: 29132
		[Token(Token = "0x40071CC")]
		[FieldOffset(Offset = "0x2C")]
		private int m_defaultStateId;

		// Token: 0x040071CD RID: 29133
		[Token(Token = "0x40071CD")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<int, StateMachine.IStateNode> m_states;

		// Token: 0x040071CE RID: 29134
		[Token(Token = "0x40071CE")]
		[FieldOffset(Offset = "0x38")]
		private Queue<KeyValuePair<int, bool>> m_pendingQueue;

		// Token: 0x040071CF RID: 29135
		[Token(Token = "0x40071CF")]
		[FieldOffset(Offset = "0x40")]
		protected StateMachine.IBlackboard m_blackboard;

		// Token: 0x020013EA RID: 5098
		[Token(Token = "0x20013EA")]
		public interface IBlackboard
		{
			// Token: 0x0600746C RID: 29804
			[Token(Token = "0x600746C")]
			void OnReset();

			// Token: 0x0600746D RID: 29805
			[Token(Token = "0x600746D")]
			void OnTick(FP deltaTime);

			// Token: 0x0600746E RID: 29806
			[Token(Token = "0x600746E")]
			void OnStop();
		}

		// Token: 0x020013EB RID: 5099
		[Token(Token = "0x20013EB")]
		public interface IStateNode
		{
			// Token: 0x17000E3A RID: 3642
			// (get) Token: 0x0600746F RID: 29807
			[Token(Token = "0x17000E3A")]
			bool isActiveNode { [Token(Token = "0x600746F")] get; }

			// Token: 0x06007470 RID: 29808
			[Token(Token = "0x6007470")]
			void OnEnter(int lastState);

			// Token: 0x06007471 RID: 29809
			[Token(Token = "0x6007471")]
			void OnExit(int nextState);

			// Token: 0x06007472 RID: 29810
			[Token(Token = "0x6007472")]
			void OnTick(FP deltaTime);

			// Token: 0x06007473 RID: 29811
			[Token(Token = "0x6007473")]
			bool CheckSwitchOut(int nextState);
		}

		// Token: 0x020013EC RID: 5100
		[Token(Token = "0x20013EC")]
		public class DefaultBlackboard : StateMachine.IBlackboard
		{
			// Token: 0x06007474 RID: 29812 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007474")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
			public virtual void OnReset()
			{
			}

			// Token: 0x06007475 RID: 29813 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007475")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
			public virtual void OnTick(FP deltaTime)
			{
			}

			// Token: 0x06007476 RID: 29814 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007476")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "9")]
			public virtual void OnStop()
			{
			}

			// Token: 0x06007477 RID: 29815 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007477")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DefaultBlackboard()
			{
			}
		}
	}
}
