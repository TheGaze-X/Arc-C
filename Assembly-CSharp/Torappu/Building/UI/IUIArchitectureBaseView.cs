using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI
{
	// Token: 0x02001B58 RID: 7000
	[Token(Token = "0x2001B58")]
	public interface IUIArchitectureBaseView
	{
		// Token: 0x170014D6 RID: 5334
		// (get) Token: 0x0600AFCB RID: 45003
		[Token(Token = "0x170014D6")]
		bool isShowing { [Token(Token = "0x600AFCB")] get; }

		// Token: 0x0600AFCC RID: 45004
		[Token(Token = "0x600AFCC")]
		void CancelView();
	}
}
