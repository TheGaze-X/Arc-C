using System;
using Il2CppDummyDll;

namespace Vuplex.WebView
{
	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	public interface IWithCursorType
	{
		// Token: 0x14000029 RID: 41
		// (add) Token: 0x06000145 RID: 325
		// (remove) Token: 0x06000146 RID: 326
		[Token(Token = "0x14000029")]
		event EventHandler<EventArgs<string>> CursorTypeChanged;
	}
}
