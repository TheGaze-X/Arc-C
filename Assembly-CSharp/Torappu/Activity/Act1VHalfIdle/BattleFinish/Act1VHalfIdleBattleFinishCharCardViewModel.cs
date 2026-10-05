using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle.BattleFinish
{
	// Token: 0x02007823 RID: 30755
	[Token(Token = "0x2007823")]
	public class Act1VHalfIdleBattleFinishCharCardViewModel : IHotfixable
	{
		// Token: 0x0602B23D RID: 176701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B23D")]
		[Address(RVA = "0x26F25C0", Offset = "0x26F11C0", VA = "0x1826F25C0")]
		public Act1VHalfIdleBattleFinishCharCardViewModel()
		{
		}

		// Token: 0x0403E5BC RID: 255420
		[Token(Token = "0x403E5BC")]
		[FieldOffset(Offset = "0x10")]
		public bool levelup;

		// Token: 0x0403E5BD RID: 255421
		[Token(Token = "0x403E5BD")]
		[FieldOffset(Offset = "0x18")]
		public Act1VHalfIdleCharViewModel charModel;

		// Token: 0x0403E5BE RID: 255422
		[Token(Token = "0x403E5BE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
