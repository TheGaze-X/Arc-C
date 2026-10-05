using System;
using Il2CppDummyDll;

namespace Vuplex.WebView
{
	// Token: 0x02000057 RID: 87
	[Token(Token = "0x2000057")]
	public struct WebViewOptions
	{
		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x0")]
		public bool clickWithoutStealingFocus;

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x1")]
		public bool disableVideo;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x8")]
		public WebPluginType[] preferredPlugins;
	}
}
