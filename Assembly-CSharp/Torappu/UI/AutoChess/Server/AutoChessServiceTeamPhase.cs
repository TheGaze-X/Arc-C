using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x020063E3 RID: 25571
	[Token(Token = "0x20063E3")]
	public class AutoChessServiceTeamPhase : AutoChessServicePhase
	{
		// Token: 0x06024E0A RID: 151050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024E0A")]
		[Address(RVA = "0x1FC1200", Offset = "0x1FBFE00", VA = "0x181FC1200", Slot = "4")]
		public override void Enter(IAutoChessServiceCore core)
		{
		}

		// Token: 0x06024E0B RID: 151051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024E0B")]
		[Address(RVA = "0x1FC1260", Offset = "0x1FBFE60", VA = "0x181FC1260", Slot = "5")]
		public override void Leave()
		{
		}

		// Token: 0x06024E0C RID: 151052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024E0C")]
		[Address(RVA = "0x1FC12C0", Offset = "0x1FBFEC0", VA = "0x181FC12C0")]
		public AutoChessServiceTeamPhase()
		{
		}

		// Token: 0x040338B3 RID: 211123
		[Token(Token = "0x40338B3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Enter;

		// Token: 0x040338B4 RID: 211124
		[Token(Token = "0x40338B4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Leave;

		// Token: 0x040338B5 RID: 211125
		[Token(Token = "0x40338B5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
