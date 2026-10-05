using System;
using Il2CppDummyDll;

namespace Vuplex.WebView
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	public interface IWithPopups
	{
		// Token: 0x0600016F RID: 367
		[Token(Token = "0x600016F")]
		void SetPopupMode(PopupMode popupMode);

		// Token: 0x1400002E RID: 46
		// (add) Token: 0x06000170 RID: 368
		// (remove) Token: 0x06000171 RID: 369
		[Token(Token = "0x1400002E")]
		event EventHandler<PopupRequestedEventArgs> PopupRequested;
	}
}
