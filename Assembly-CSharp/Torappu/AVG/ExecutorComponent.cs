using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001E79 RID: 7801
	[Token(Token = "0x2001E79")]
	public abstract class ExecutorComponent : AVGComponent
	{
		// Token: 0x1700173B RID: 5947
		// (get) Token: 0x0600C147 RID: 49479 RVA: 0x00047040 File Offset: 0x00045240
		// (set) Token: 0x0600C148 RID: 49480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700173B")]
		public bool isExecuting
		{
			[Token(Token = "0x600C147")]
			[Address(RVA = "0x33E9AF0", Offset = "0x33E86F0", VA = "0x1833E9AF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600C148")]
			[Address(RVA = "0x33E9B50", Offset = "0x33E8750", VA = "0x1833E9B50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600C149 RID: 49481
		[Token(Token = "0x600C149")]
		public abstract Dictionary<string, ExecutorComponent.Executor> GetExecutors();

		// Token: 0x0600C14A RID: 49482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C14A")]
		[Address(RVA = "0x33E97D0", Offset = "0x33E83D0", VA = "0x1833E97D0", Slot = "9")]
		public virtual Dictionary<string, ExecutorComponent.SignalReceiver> GetSignalReceivers()
		{
			return null;
		}

		// Token: 0x0600C14B RID: 49483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C14B")]
		[Address(RVA = "0x33E9870", Offset = "0x33E8470", VA = "0x1833E9870", Slot = "7")]
		public override void OnReset()
		{
		}

		// Token: 0x0600C14C RID: 49484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C14C")]
		[Address(RVA = "0x33E9170", Offset = "0x33E7D70", VA = "0x1833E9170", Slot = "4")]
		public sealed override IList<ICommandExecutor> GetCommandExecutors()
		{
			return null;
		}

		// Token: 0x0600C14D RID: 49485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C14D")]
		[Address(RVA = "0x33E8F10", Offset = "0x33E7B10", VA = "0x1833E8F10", Slot = "10")]
		protected virtual ICommandExecutor GenerateExecutorWrapper(ExecutorComponent.WrapperOptions options)
		{
			return null;
		}

		// Token: 0x0600C14E RID: 49486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C14E")]
		[Address(RVA = "0x33E8CC0", Offset = "0x33E78C0", VA = "0x1833E8CC0")]
		protected void Execute(Command command, Action finishCb)
		{
		}

		// Token: 0x0600C14F RID: 49487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C14F")]
		[Address(RVA = "0x33E9920", Offset = "0x33E8520", VA = "0x1833E9920")]
		protected void RaiseSignal(Command command)
		{
		}

		// Token: 0x0600C150 RID: 49488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C150")]
		[Address(RVA = "0x33D3770", Offset = "0x33D2370", VA = "0x1833D3770", Slot = "11")]
		protected virtual void OnFinish()
		{
		}

		// Token: 0x0600C151 RID: 49489
		[Token(Token = "0x600C151")]
		protected abstract void ForceCommandEnd();

		// Token: 0x0600C152 RID: 49490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C152")]
		[Address(RVA = "0x33E8E10", Offset = "0x33E7A10", VA = "0x1833E8E10")]
		protected void FinishCommand()
		{
		}

		// Token: 0x0600C153 RID: 49491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C153")]
		[Address(RVA = "0x33E99F0", Offset = "0x33E85F0", VA = "0x1833E99F0")]
		protected ExecutorComponent()
		{
		}

		// Token: 0x0600C154 RID: 49492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C154")]
		[Address(RVA = "0x33E99E0", Offset = "0x33E85E0", VA = "0x1833E99E0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0400C2A7 RID: 49831
		[Token(Token = "0x400C2A7")]
		[FieldOffset(Offset = "0x28")]
		private ICommandExecutor[] m_executorWrappers;

		// Token: 0x0400C2A8 RID: 49832
		[Token(Token = "0x400C2A8")]
		[FieldOffset(Offset = "0x30")]
		private Action m_finishCb;

		// Token: 0x0400C2A9 RID: 49833
		[Token(Token = "0x400C2A9")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, ExecutorComponent.Executor> m_executors;

		// Token: 0x0400C2AA RID: 49834
		[Token(Token = "0x400C2AA")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, ExecutorComponent.SignalReceiver> m_signalReceivers;

		// Token: 0x0400C2AC RID: 49836
		[Token(Token = "0x400C2AC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isExecuting;

		// Token: 0x0400C2AD RID: 49837
		[Token(Token = "0x400C2AD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isExecuting;

		// Token: 0x0400C2AE RID: 49838
		[Token(Token = "0x400C2AE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetSignalReceivers;

		// Token: 0x0400C2AF RID: 49839
		[Token(Token = "0x400C2AF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400C2B0 RID: 49840
		[Token(Token = "0x400C2B0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCommandExecutors;

		// Token: 0x0400C2B1 RID: 49841
		[Token(Token = "0x400C2B1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GenerateExecutorWrapper;

		// Token: 0x0400C2B2 RID: 49842
		[Token(Token = "0x400C2B2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Execute;

		// Token: 0x0400C2B3 RID: 49843
		[Token(Token = "0x400C2B3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RaiseSignal;

		// Token: 0x0400C2B4 RID: 49844
		[Token(Token = "0x400C2B4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0400C2B5 RID: 49845
		[Token(Token = "0x400C2B5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_FinishCommand;

		// Token: 0x0400C2B6 RID: 49846
		[Token(Token = "0x400C2B6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001E7A RID: 7802
		// (Invoke) Token: 0x0600C156 RID: 49494
		[Token(Token = "0x2001E7A")]
		public delegate bool Executor(Command command);

		// Token: 0x02001E7B RID: 7803
		// (Invoke) Token: 0x0600C15A RID: 49498
		[Token(Token = "0x2001E7B")]
		public delegate void SignalReceiver(Command command);

		// Token: 0x02001E7C RID: 7804
		[Token(Token = "0x2001E7C")]
		protected struct WrapperOptions
		{
			// Token: 0x0400C2B7 RID: 49847
			[Token(Token = "0x400C2B7")]
			[FieldOffset(Offset = "0x0")]
			public string command;

			// Token: 0x0400C2B8 RID: 49848
			[Token(Token = "0x400C2B8")]
			[FieldOffset(Offset = "0x8")]
			public CommandExecuteDelegate executor;

			// Token: 0x0400C2B9 RID: 49849
			[Token(Token = "0x400C2B9")]
			[FieldOffset(Offset = "0x10")]
			public Action forceEnd;

			// Token: 0x0400C2BA RID: 49850
			[Token(Token = "0x400C2BA")]
			[FieldOffset(Offset = "0x18")]
			public RaiseSignalDelegate signalReceiver;
		}
	}
}
