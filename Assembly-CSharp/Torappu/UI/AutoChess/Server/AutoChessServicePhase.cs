using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x020063E2 RID: 25570
	[Token(Token = "0x20063E2")]
	public abstract class AutoChessServicePhase : IHotfixable
	{
		// Token: 0x06024E05 RID: 151045
		[Token(Token = "0x6024E05")]
		public abstract void Enter(IAutoChessServiceCore core);

		// Token: 0x06024E06 RID: 151046
		[Token(Token = "0x6024E06")]
		public abstract void Leave();

		// Token: 0x06024E07 RID: 151047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024E07")]
		[Address(RVA = "0x1FBE330", Offset = "0x1FBCF30", VA = "0x181FBE330", Slot = "6")]
		public virtual void FixedUpdate()
		{
		}

		// Token: 0x06024E08 RID: 151048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024E08")]
		[Address(RVA = "0x1FC1000", Offset = "0x1FBFC00", VA = "0x181FC1000", Slot = "7")]
		public virtual void OnGUI()
		{
		}

		// Token: 0x06024E09 RID: 151049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024E09")]
		[Address(RVA = "0x1FC1060", Offset = "0x1FBFC60", VA = "0x181FC1060")]
		protected AutoChessServicePhase()
		{
		}

		// Token: 0x040338B0 RID: 211120
		[Token(Token = "0x40338B0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_FixedUpdate;

		// Token: 0x040338B1 RID: 211121
		[Token(Token = "0x40338B1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnGUI;

		// Token: 0x040338B2 RID: 211122
		[Token(Token = "0x40338B2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
