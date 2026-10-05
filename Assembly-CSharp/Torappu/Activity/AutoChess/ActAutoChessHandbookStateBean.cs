using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x020070F8 RID: 28920
	[Token(Token = "0x20070F8")]
	public class ActAutoChessHandbookStateBean : IStateBean, IHotfixable
	{
		// Token: 0x060291C2 RID: 168386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291C2")]
		[Address(RVA = "0x2485BE0", Offset = "0x24847E0", VA = "0x182485BE0")]
		public ActAutoChessHandbookStateBean()
		{
		}

		// Token: 0x0403AAF3 RID: 240371
		[Token(Token = "0x403AAF3")]
		[FieldOffset(Offset = "0x10")]
		public ActAutoChessHandbookProperty property;

		// Token: 0x0403AAF4 RID: 240372
		[Token(Token = "0x403AAF4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
