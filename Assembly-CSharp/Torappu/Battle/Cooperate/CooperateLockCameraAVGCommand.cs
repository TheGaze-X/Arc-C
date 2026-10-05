using System;
using Il2CppDummyDll;
using Torappu.AVG;
using XLua;

namespace Torappu.Battle.Cooperate
{
	// Token: 0x020026D2 RID: 9938
	[Token(Token = "0x20026D2")]
	public class CooperateLockCameraAVGCommand : ICommandExecutor, IHotfixable
	{
		// Token: 0x1700234C RID: 9036
		// (get) Token: 0x060102F9 RID: 66297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700234C")]
		public string command
		{
			[Token(Token = "0x60102F9")]
			[Address(RVA = "0x7E5890", Offset = "0x7E4490", VA = "0x1807E5890", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060102FA RID: 66298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102FA")]
		[Address(RVA = "0x7E55A0", Offset = "0x7E41A0", VA = "0x1807E55A0", Slot = "5")]
		public void Execute(Command command, Action<ICommandExecutor> finishCb)
		{
		}

		// Token: 0x060102FB RID: 66299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102FB")]
		[Address(RVA = "0x7E57D0", Offset = "0x7E43D0", VA = "0x1807E57D0", Slot = "6")]
		public void RaiseSignal(Command command)
		{
		}

		// Token: 0x060102FC RID: 66300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102FC")]
		[Address(RVA = "0x7E5770", Offset = "0x7E4370", VA = "0x1807E5770", Slot = "7")]
		public void ForceEnd()
		{
		}

		// Token: 0x060102FD RID: 66301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102FD")]
		[Address(RVA = "0x7E5830", Offset = "0x7E4430", VA = "0x1807E5830")]
		public CooperateLockCameraAVGCommand()
		{
		}

		// Token: 0x0401210B RID: 73995
		[Token(Token = "0x401210B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_command;

		// Token: 0x0401210C RID: 73996
		[Token(Token = "0x401210C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Execute;

		// Token: 0x0401210D RID: 73997
		[Token(Token = "0x401210D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RaiseSignal;

		// Token: 0x0401210E RID: 73998
		[Token(Token = "0x401210E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ForceEnd;

		// Token: 0x0401210F RID: 73999
		[Token(Token = "0x401210F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
