using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001E78 RID: 7800
	[Token(Token = "0x2001E78")]
	public class CommandExecutorWrapper : ICommandExecutor, IHotfixable
	{
		// Token: 0x1700173A RID: 5946
		// (get) Token: 0x0600C140 RID: 49472 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C141 RID: 49473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700173A")]
		public string command
		{
			[Token(Token = "0x600C140")]
			[Address(RVA = "0x33E8340", Offset = "0x33E6F40", VA = "0x1833E8340", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600C141")]
			[Address(RVA = "0x33E83A0", Offset = "0x33E6FA0", VA = "0x1833E83A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600C142 RID: 49474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C142")]
		[Address(RVA = "0x33E8210", Offset = "0x33E6E10", VA = "0x1833E8210")]
		public CommandExecutorWrapper(string command, CommandExecuteDelegate executor, [Optional] Action forceEnd, [Optional] RaiseSignalDelegate signalReceiver)
		{
		}

		// Token: 0x0600C143 RID: 49475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C143")]
		[Address(RVA = "0x33E7F50", Offset = "0x33E6B50", VA = "0x1833E7F50", Slot = "5")]
		public void Execute(Command command, Action<ICommandExecutor> finishCb)
		{
		}

		// Token: 0x0600C144 RID: 49476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C144")]
		[Address(RVA = "0x33E8120", Offset = "0x33E6D20", VA = "0x1833E8120", Slot = "6")]
		public void RaiseSignal(Command command)
		{
		}

		// Token: 0x0600C145 RID: 49477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C145")]
		[Address(RVA = "0x33E8060", Offset = "0x33E6C60", VA = "0x1833E8060", Slot = "7")]
		public void ForceEnd()
		{
		}

		// Token: 0x0600C146 RID: 49478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C146")]
		[Address(RVA = "0x33E81A0", Offset = "0x33E6DA0", VA = "0x1833E81A0")]
		private void _OnFinish()
		{
		}

		// Token: 0x0400C29A RID: 49818
		[Token(Token = "0x400C29A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private CommandExecuteDelegate m_executor;

		// Token: 0x0400C29B RID: 49819
		[Token(Token = "0x400C29B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RaiseSignalDelegate m_signalReceiver;

		// Token: 0x0400C29C RID: 49820
		[Token(Token = "0x400C29C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Action m_forceEnd;

		// Token: 0x0400C29D RID: 49821
		[Token(Token = "0x400C29D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Action<ICommandExecutor> m_finishCb;

		// Token: 0x0400C29E RID: 49822
		[Token(Token = "0x400C29E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Command m_cachedCmd;

		// Token: 0x0400C2A0 RID: 49824
		[Token(Token = "0x400C2A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_command;

		// Token: 0x0400C2A1 RID: 49825
		[Token(Token = "0x400C2A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_command;

		// Token: 0x0400C2A2 RID: 49826
		[Token(Token = "0x400C2A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400C2A3 RID: 49827
		[Token(Token = "0x400C2A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Execute;

		// Token: 0x0400C2A4 RID: 49828
		[Token(Token = "0x400C2A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RaiseSignal;

		// Token: 0x0400C2A5 RID: 49829
		[Token(Token = "0x400C2A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ForceEnd;

		// Token: 0x0400C2A6 RID: 49830
		[Token(Token = "0x400C2A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnFinish;
	}
}
