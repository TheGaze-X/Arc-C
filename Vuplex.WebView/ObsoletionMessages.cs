using System;
using Il2CppDummyDll;

namespace Vuplex.WebView
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	internal static class ObsoletionMessages
	{
		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		public const string Blur = "IWebView.Blur() has been removed. Please use SetFocused(false) instead: https://developer.vuplex.com/webview/IWebView#SetFocused";

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		public const string CanGoBack = "The callback-based CanGoBack(Action) version of this method has been removed. Please switch to the Task-based CanGoBack() version instead. If you prefer using a callback instead of awaiting the Task, you can still use a callback like this: CanGoBack().ContinueWith(result => {...})";

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		public const string CanGoForward = "The callback-based CanGoForward(Action) version of this method has been removed. Please switch to the Task-based CanGoForward() version instead. If you prefer using a callback instead of awaiting the Task, you can still use a callback like this: CanGoForward().ContinueWith(result => {...})";

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		public const string CaptureScreenshot = "The callback-based CaptureScreenshot(Action) version of this method has been removed. Please switch to the Task-based CaptureScreenshot() version instead. If you prefer using a callback instead of awaiting the Task, you can still use a callback like this: CaptureScreenshot().ContinueWith(result => {...})";

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		public const string DisableViewUpdates = "DisableViewUpdates() has been removed. Please use SetRenderingEnabled(false) instead: https://developer.vuplex.com/webview/IWebView#SetRenderingEnabled";

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		public const string EnableViewUpdates = "EnableViewUpdates() has been removed. Please use SetRenderingEnabled(true) instead: https://developer.vuplex.com/webview/IWebView#SetRenderingEnabled";

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		public const string Focus = "IWebView.Focus() has been removed. Please use SetFocused(false) instead: https://developer.vuplex.com/webview/IWebView#SetFocused";

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		public const string GetRawTextureData = "The callback-based GetRawTextureData(Action) version of this method has been removed. Please switch to the Task-based GetRawTextureData() version instead. If you prefer using a callback instead of awaiting the Task, you can still use a callback like this: GetRawTextureData().ContinueWith(result => {...})";

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		public const string HandleKeyboardInput = "IWebView.HandleKeyboardInput() has been renamed to IWebView.SendKey(). Please switch to SendKey().";

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		public const string Init = "IWebView.Init(Texture2D, float, float) has been removed in v4. Please switch to IWebView.Init(int, int) and await the Task it returns. For more details, please see this article: https://support.vuplex.com/articles/v4-changes#init";

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		public const string Init2 = "IWebView.Init(Texture2D, float, float, Texture2D) has been removed in v4. Please switch to IWebView.Init(int, int) and await the Task it returns. For more details, please see this article: https://support.vuplex.com/articles/v4-changes#init";

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		public const string PageLoadFailed = "IWebView.PageLoadFailed is now deprecated. Please use IWebView.LoadFailed instead: https://developer.vuplex.com/webview/IWebView#LoadFailed";

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		public const string Resolution = "IWebView.Resolution has been removed in v4. Please use WebViewPrefab.Resolution or CanvasWebViewPrefab.Resolution instead. For more details, please see this article: https://support.vuplex.com/articles/v4-changes#resolution";

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		public const string SetResolution = "IWebView.SetResolution() has been removed in v4. Please set the WebViewPrefab.Resolution or CanvasWebViewPrefab.Resolution property instead. For more details, please see this article: https://support.vuplex.com/articles/v4-changes#resolution";

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		public const string SizeInPixels = "IWebView.SizeInPixels is now deprecated. Please use IWebView.Size instead: https://developer.vuplex.com/webview/IWebView#Size";

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		public const string VideoRectChanged = "IWebView.VideoRectChanged has been removed. Please use IWithFallbackVideo.VideoRectChanged instead: https://developer.vuplex.com/webview/IWithFallbackVideo#VideoRectChanged";

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		public const string VideoTexture = "IWebView.VideoTexture has been removed. Please use IWithFallbackVideo.VideoTexture instead: https://developer.vuplex.com/webview/IWithFallbackVideo#VideoTexture";
	}
}
