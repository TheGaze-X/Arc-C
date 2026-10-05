using System;
using Il2CppDummyDll;
using Torappu.AVG;
using XLua;

namespace Torappu.Battle.Cooperate
{
	// Token: 0x020026D1 RID: 9937
	[Token(Token = "0x20026D1")]
	public class CooperateMoveCameraAVGCommand : ICommandExecutor, IHotfixable
	{
		// Token: 0x1700234B RID: 9035
		// (get) Token: 0x060102F4 RID: 66292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700234B")]
		public string command
		{
			[Token(Token = "0x60102F4")]
			[Address(RVA = "0x7E6080", Offset = "0x7E4C80", VA = "0x1807E6080", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060102F5 RID: 66293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102F5")]
		[Address(RVA = "0x7E5B90", Offset = "0x7E4790", VA = "0x1807E5B90", Slot = "5")]
		public void Execute(Command command, Action<ICommandExecutor> finishCb)
		{
		}

		// Token: 0x060102F6 RID: 66294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102F6")]
		[Address(RVA = "0x7E5FC0", Offset = "0x7E4BC0", VA = "0x1807E5FC0", Slot = "6")]
		public void RaiseSignal(Command command)
		{
		}

		// Token: 0x060102F7 RID: 66295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102F7")]
		[Address(RVA = "0x7E5F60", Offset = "0x7E4B60", VA = "0x1807E5F60", Slot = "7")]
		public void ForceEnd()
		{
		}

		// Token: 0x060102F8 RID: 66296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102F8")]
		[Address(RVA = "0x7E6020", Offset = "0x7E4C20", VA = "0x1807E6020")]
		public CooperateMoveCameraAVGCommand()
		{
		}

		// Token: 0x04012106 RID: 73990
		[Token(Token = "0x4012106")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_command;

		// Token: 0x04012107 RID: 73991
		[Token(Token = "0x4012107")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Execute;

		// Token: 0x04012108 RID: 73992
		[Token(Token = "0x4012108")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RaiseSignal;

		// Token: 0x04012109 RID: 73993
		[Token(Token = "0x4012109")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ForceEnd;

		// Token: 0x0401210A RID: 73994
		[Token(Token = "0x401210A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
