using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x0200014A RID: 330
	[Token(Token = "0x200014A")]
	public interface ITwoStateSwitcher : IHotfixable
	{
		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060007CF RID: 1999
		// (set) Token: 0x060007D0 RID: 2000
		[Token(Token = "0x170000A9")]
		bool isClickable { [Token(Token = "0x60007CF")] get; [Token(Token = "0x60007D0")] set; }

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060007D1 RID: 2001
		[Token(Token = "0x170000AA")]
		bool setWithAwake { [Token(Token = "0x60007D1")] get; }

		// Token: 0x060007D2 RID: 2002
		[Token(Token = "0x60007D2")]
		void ResetButton(bool isClickable);
	}
}
