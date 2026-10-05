using System;
using Il2CppDummyDll;
using Torappu.AVG;
using XLua;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A5B RID: 10843
	[Token(Token = "0x2002A5B")]
	public class SandboxMoveCameraAVGCommand : ICommandExecutor, IHotfixable
	{
		// Token: 0x1700278F RID: 10127
		// (get) Token: 0x06012012 RID: 73746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700278F")]
		public string command
		{
			[Token(Token = "0x6012012")]
			[Address(RVA = "0xA1D380", Offset = "0xA1BF80", VA = "0x180A1D380", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06012013 RID: 73747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012013")]
		[Address(RVA = "0xA1CF90", Offset = "0xA1BB90", VA = "0x180A1CF90", Slot = "5")]
		public void Execute(Command command, Action<ICommandExecutor> finishCb)
		{
		}

		// Token: 0x06012014 RID: 73748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012014")]
		[Address(RVA = "0xA1D2C0", Offset = "0xA1BEC0", VA = "0x180A1D2C0", Slot = "6")]
		public void RaiseSignal(Command command)
		{
		}

		// Token: 0x06012015 RID: 73749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012015")]
		[Address(RVA = "0xA1D260", Offset = "0xA1BE60", VA = "0x180A1D260", Slot = "7")]
		public void ForceEnd()
		{
		}

		// Token: 0x06012016 RID: 73750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012016")]
		[Address(RVA = "0xA1D320", Offset = "0xA1BF20", VA = "0x180A1D320")]
		public SandboxMoveCameraAVGCommand()
		{
		}

		// Token: 0x0401455C RID: 83292
		[Token(Token = "0x401455C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_command;

		// Token: 0x0401455D RID: 83293
		[Token(Token = "0x401455D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Execute;

		// Token: 0x0401455E RID: 83294
		[Token(Token = "0x401455E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RaiseSignal;

		// Token: 0x0401455F RID: 83295
		[Token(Token = "0x401455F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ForceEnd;

		// Token: 0x04014560 RID: 83296
		[Token(Token = "0x4014560")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
