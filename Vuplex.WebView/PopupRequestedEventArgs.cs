using System;
using Il2CppDummyDll;

namespace Vuplex.WebView
{
	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000041")]
	public class PopupRequestedEventArgs : EventArgs
	{
		// Token: 0x060001FC RID: 508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x5BBA530", Offset = "0x5BB9130", VA = "0x185BBA530")]
		public PopupRequestedEventArgs(string url, IWebView webView)
		{
		}

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x10")]
		public readonly string Url;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x18")]
		public readonly IWebView WebView;
	}
}
