using System;
using Il2CppDummyDll;
using Torappu.UI.TemplateCharSelect;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006330 RID: 25392
	[Token(Token = "0x2006330")]
	public class AutoChessSquadCharSelectCharInputData : TemplateCharSelectCharInputData
	{
		// Token: 0x060249C0 RID: 149952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60249C0")]
		[Address(RVA = "0x1F7D780", Offset = "0x1F7C380", VA = "0x181F7D780")]
		public AutoChessSquadCharSelectCharInputData()
		{
		}

		// Token: 0x04033145 RID: 209221
		[Token(Token = "0x4033145")]
		[FieldOffset(Offset = "0x18")]
		public string chessId;

		// Token: 0x04033146 RID: 209222
		[Token(Token = "0x4033146")]
		[FieldOffset(Offset = "0x20")]
		public string originChessId;

		// Token: 0x04033147 RID: 209223
		[Token(Token = "0x4033147")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
