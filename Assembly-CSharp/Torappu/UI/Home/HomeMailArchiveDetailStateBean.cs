using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B18 RID: 19224
	[Token(Token = "0x2004B18")]
	public class HomeMailArchiveDetailStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601CE90 RID: 118416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE90")]
		[Address(RVA = "0x1657440", Offset = "0x1656040", VA = "0x181657440")]
		public HomeMailArchiveDetailStateBean()
		{
		}

		// Token: 0x04025EEB RID: 155371
		[Token(Token = "0x4025EEB")]
		[FieldOffset(Offset = "0x10")]
		public HomeMailArchiveDetailProperty property;

		// Token: 0x04025EEC RID: 155372
		[Token(Token = "0x4025EEC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
