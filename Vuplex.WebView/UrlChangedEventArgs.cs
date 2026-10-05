using System;
using Il2CppDummyDll;

namespace Vuplex.WebView
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200004D")]
	public class UrlChangedEventArgs : EventArgs
	{
		// Token: 0x06000207 RID: 519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x5BC8B40", Offset = "0x5BC7740", VA = "0x185BC8B40")]
		public UrlChangedEventArgs(string url)
		{
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x5BC8B00", Offset = "0x5BC7700", VA = "0x185BC8B00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x10")]
		public string Url;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x18")]
		[Obsolete("UrlChangedEventArgs.Title has been removed. Please use IWebView.Title or IWebView.TitleChanged instead: https://developer.vuplex.com/webview/IWebView#Title", true)]
		public string Title;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x20")]
		[Obsolete("UrlChangedEventArgs.Type has been removed.", true)]
		public string Type;
	}
}
