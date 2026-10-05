using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006325 RID: 25381
	[Token(Token = "0x2006325")]
	public interface IAutoChessShopQuickAssistListItemViewModel : IHotfixable
	{
		// Token: 0x06024997 RID: 149911
		[Token(Token = "0x6024997")]
		AutoChessShopQuickAssistListItemViewType GetViewType();

		// Token: 0x06024998 RID: 149912
		[Token(Token = "0x6024998")]
		AutoChessShopQuickAssistItemViewModel GetItemViewModel();
	}
}
