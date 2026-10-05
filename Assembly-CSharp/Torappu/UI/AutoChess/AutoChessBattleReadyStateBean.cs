using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062A6 RID: 25254
	[Token(Token = "0x20062A6")]
	public class AutoChessBattleReadyStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602467D RID: 149117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602467D")]
		[Address(RVA = "0x1F37D20", Offset = "0x1F36920", VA = "0x181F37D20")]
		public AutoChessBattleReadyStateBean()
		{
		}

		// Token: 0x04032A96 RID: 207510
		[Token(Token = "0x4032A96")]
		[FieldOffset(Offset = "0x10")]
		public AutoChessBattleReadyProperty property;

		// Token: 0x04032A97 RID: 207511
		[Token(Token = "0x4032A97")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
