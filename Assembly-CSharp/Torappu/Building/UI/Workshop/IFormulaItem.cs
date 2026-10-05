using System;
using Il2CppDummyDll;
using Torappu.UI;

namespace Torappu.Building.UI.Workshop
{
	// Token: 0x02001BFD RID: 7165
	[Token(Token = "0x2001BFD")]
	public interface IFormulaItem
	{
		// Token: 0x17001559 RID: 5465
		// (get) Token: 0x0600B295 RID: 45717
		[Token(Token = "0x17001559")]
		UIItemViewModel model { [Token(Token = "0x600B295")] get; }

		// Token: 0x1700155A RID: 5466
		// (get) Token: 0x0600B296 RID: 45718
		[Token(Token = "0x1700155A")]
		int storage { [Token(Token = "0x600B296")] get; }
	}
}
