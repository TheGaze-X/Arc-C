using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200638E RID: 25486
	[Token(Token = "0x200638E")]
	public class AutoChessStageInfoStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06024C31 RID: 150577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C31")]
		[Address(RVA = "0x1FAA2C0", Offset = "0x1FA8EC0", VA = "0x181FAA2C0")]
		public AutoChessStageInfoStateBean()
		{
		}

		// Token: 0x040335C5 RID: 210373
		[Token(Token = "0x40335C5")]
		[FieldOffset(Offset = "0x10")]
		public AutoChessStageInfoGroupViewModel viewModel;

		// Token: 0x040335C6 RID: 210374
		[Token(Token = "0x40335C6")]
		[FieldOffset(Offset = "0x18")]
		public AutoChessStageInfoProperty property;

		// Token: 0x040335C7 RID: 210375
		[Token(Token = "0x40335C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
