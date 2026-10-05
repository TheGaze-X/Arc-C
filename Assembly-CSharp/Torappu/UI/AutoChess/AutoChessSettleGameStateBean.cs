using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062F5 RID: 25333
	[Token(Token = "0x20062F5")]
	public class AutoChessSettleGameStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06024839 RID: 149561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024839")]
		[Address(RVA = "0x1F5AFF0", Offset = "0x1F59BF0", VA = "0x181F5AFF0")]
		public AutoChessSettleGameStateBean()
		{
		}

		// Token: 0x04032E5A RID: 208474
		[Token(Token = "0x4032E5A")]
		[FieldOffset(Offset = "0x10")]
		public AutoChessSettleGameViewProperty property;

		// Token: 0x04032E5B RID: 208475
		[Token(Token = "0x4032E5B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
