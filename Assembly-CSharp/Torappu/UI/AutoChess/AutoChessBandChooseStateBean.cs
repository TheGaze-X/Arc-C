using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006297 RID: 25239
	[Token(Token = "0x2006297")]
	public class AutoChessBandChooseStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602464D RID: 149069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602464D")]
		[Address(RVA = "0x1F25020", Offset = "0x1F23C20", VA = "0x181F25020")]
		public AutoChessBandChooseStateBean()
		{
		}

		// Token: 0x04032A11 RID: 207377
		[Token(Token = "0x4032A11")]
		[FieldOffset(Offset = "0x10")]
		public AutoChessBandChooseProperty property;

		// Token: 0x04032A12 RID: 207378
		[Token(Token = "0x4032A12")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
