using System;
using Il2CppDummyDll;
using Torappu.AVG;
using XLua;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A5C RID: 10844
	[Token(Token = "0x2002A5C")]
	public class SandboxLockCameraAVGCommand : ICommandExecutor, IHotfixable
	{
		// Token: 0x17002790 RID: 10128
		// (get) Token: 0x06012017 RID: 73751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002790")]
		public string command
		{
			[Token(Token = "0x6012017")]
			[Address(RVA = "0xA1CF20", Offset = "0xA1BB20", VA = "0x180A1CF20", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06012018 RID: 73752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012018")]
		[Address(RVA = "0xA1CC30", Offset = "0xA1B830", VA = "0x180A1CC30", Slot = "5")]
		public void Execute(Command command, Action<ICommandExecutor> finishCb)
		{
		}

		// Token: 0x06012019 RID: 73753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012019")]
		[Address(RVA = "0xA1CE60", Offset = "0xA1BA60", VA = "0x180A1CE60", Slot = "6")]
		public void RaiseSignal(Command command)
		{
		}

		// Token: 0x0601201A RID: 73754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601201A")]
		[Address(RVA = "0xA1CE00", Offset = "0xA1BA00", VA = "0x180A1CE00", Slot = "7")]
		public void ForceEnd()
		{
		}

		// Token: 0x0601201B RID: 73755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601201B")]
		[Address(RVA = "0xA1CEC0", Offset = "0xA1BAC0", VA = "0x180A1CEC0")]
		public SandboxLockCameraAVGCommand()
		{
		}

		// Token: 0x04014561 RID: 83297
		[Token(Token = "0x4014561")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_command;

		// Token: 0x04014562 RID: 83298
		[Token(Token = "0x4014562")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Execute;

		// Token: 0x04014563 RID: 83299
		[Token(Token = "0x4014563")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RaiseSignal;

		// Token: 0x04014564 RID: 83300
		[Token(Token = "0x4014564")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ForceEnd;

		// Token: 0x04014565 RID: 83301
		[Token(Token = "0x4014565")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
