using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace Vuplex.WebView
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	public interface IWebView
	{
		// Token: 0x1400001B RID: 27
		// (add) Token: 0x060000EE RID: 238
		// (remove) Token: 0x060000EF RID: 239
		[Token(Token = "0x1400001B")]
		event EventHandler CloseRequested;

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x060000F0 RID: 240
		// (remove) Token: 0x060000F1 RID: 241
		[Token(Token = "0x1400001C")]
		event EventHandler<ConsoleMessageEventArgs> ConsoleMessageLogged;

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x060000F2 RID: 242
		// (remove) Token: 0x060000F3 RID: 243
		[Token(Token = "0x1400001D")]
		event EventHandler<EventArgs<bool>> FocusChanged;

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x060000F4 RID: 244
		// (remove) Token: 0x060000F5 RID: 245
		[Token(Token = "0x1400001E")]
		event EventHandler<FocusedInputFieldChangedEventArgs> FocusedInputFieldChanged;

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x060000F6 RID: 246
		// (remove) Token: 0x060000F7 RID: 247
		[Token(Token = "0x1400001F")]
		event EventHandler<LoadFailedEventArgs> LoadFailed;

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x060000F8 RID: 248
		// (remove) Token: 0x060000F9 RID: 249
		[Token(Token = "0x14000020")]
		event EventHandler<ProgressChangedEventArgs> LoadProgressChanged;

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x060000FA RID: 250
		// (remove) Token: 0x060000FB RID: 251
		[Token(Token = "0x14000021")]
		event EventHandler<EventArgs<string>> MessageEmitted;

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x060000FC RID: 252
		// (remove) Token: 0x060000FD RID: 253
		[Token(Token = "0x14000022")]
		event EventHandler<TerminatedEventArgs> Terminated;

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x060000FE RID: 254
		// (remove) Token: 0x060000FF RID: 255
		[Token(Token = "0x14000023")]
		event EventHandler<EventArgs<string>> TitleChanged;

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x06000100 RID: 256
		// (remove) Token: 0x06000101 RID: 257
		[Token(Token = "0x14000024")]
		event EventHandler<UrlChangedEventArgs> UrlChanged;

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000102 RID: 258
		[Token(Token = "0x17000015")]
		bool IsDisposed { [Token(Token = "0x6000102")] get; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000103 RID: 259
		[Token(Token = "0x17000016")]
		bool IsInitialized { [Token(Token = "0x6000103")] get; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000104 RID: 260
		[Token(Token = "0x17000017")]
		List<string> PageLoadScripts { [Token(Token = "0x6000104")] get; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000105 RID: 261
		[Token(Token = "0x17000018")]
		WebPluginType PluginType { [Token(Token = "0x6000105")] get; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000106 RID: 262
		[Token(Token = "0x17000019")]
		Vector2Int Size { [Token(Token = "0x6000106")] get; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000107 RID: 263
		[Token(Token = "0x1700001A")]
		Texture2D Texture { [Token(Token = "0x6000107")] get; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000108 RID: 264
		[Token(Token = "0x1700001B")]
		string Title { [Token(Token = "0x6000108")] get; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000109 RID: 265
		[Token(Token = "0x1700001C")]
		string Url { [Token(Token = "0x6000109")] get; }

		// Token: 0x0600010A RID: 266
		[Token(Token = "0x600010A")]
		Task<bool> CanGoBack();

		// Token: 0x0600010B RID: 267
		[Token(Token = "0x600010B")]
		Task<bool> CanGoForward();

		// Token: 0x0600010C RID: 268
		[Token(Token = "0x600010C")]
		Task<byte[]> CaptureScreenshot();

		// Token: 0x0600010D RID: 269
		[Token(Token = "0x600010D")]
		void Click(int xInPixels, int yInPixels, bool preventStealingFocus = false);

		// Token: 0x0600010E RID: 270
		[Token(Token = "0x600010E")]
		void Click(Vector2 normalizedPoint, bool preventStealingFocus = false);

		// Token: 0x0600010F RID: 271
		[Token(Token = "0x600010F")]
		void Copy();

		// Token: 0x06000110 RID: 272
		[Token(Token = "0x6000110")]
		Material CreateMaterial();

		// Token: 0x06000111 RID: 273
		[Token(Token = "0x6000111")]
		void Cut();

		// Token: 0x06000112 RID: 274
		[Token(Token = "0x6000112")]
		void Dispose();

		// Token: 0x06000113 RID: 275
		[Token(Token = "0x6000113")]
		Task<string> ExecuteJavaScript(string javaScript);

		// Token: 0x06000114 RID: 276
		[Token(Token = "0x6000114")]
		void ExecuteJavaScript(string javaScript, Action<string> callback);

		// Token: 0x06000115 RID: 277
		[Token(Token = "0x6000115")]
		Task<byte[]> GetRawTextureData();

		// Token: 0x06000116 RID: 278
		[Token(Token = "0x6000116")]
		void GoBack();

		// Token: 0x06000117 RID: 279
		[Token(Token = "0x6000117")]
		void GoForward();

		// Token: 0x06000118 RID: 280
		[Token(Token = "0x6000118")]
		Task Init(int width, int height);

		// Token: 0x06000119 RID: 281
		[Token(Token = "0x6000119")]
		void LoadHtml(string html);

		// Token: 0x0600011A RID: 282
		[Token(Token = "0x600011A")]
		void LoadUrl(string url);

		// Token: 0x0600011B RID: 283
		[Token(Token = "0x600011B")]
		void LoadUrl(string url, Dictionary<string, string> additionalHttpHeaders);

		// Token: 0x0600011C RID: 284
		[Token(Token = "0x600011C")]
		Vector2Int NormalizedToPoint(Vector2 normalizedPoint);

		// Token: 0x0600011D RID: 285
		[Token(Token = "0x600011D")]
		void Paste();

		// Token: 0x0600011E RID: 286
		[Token(Token = "0x600011E")]
		Vector2 PointToNormalized(int xInPixels, int yInPixels);

		// Token: 0x0600011F RID: 287
		[Token(Token = "0x600011F")]
		void PostMessage(string data);

		// Token: 0x06000120 RID: 288
		[Token(Token = "0x6000120")]
		void Reload();

		// Token: 0x06000121 RID: 289
		[Token(Token = "0x6000121")]
		void Resize(int width, int height);

		// Token: 0x06000122 RID: 290
		[Token(Token = "0x6000122")]
		void Scroll(int scrollDeltaXInPixels, int scrollDeltaYInPixels);

		// Token: 0x06000123 RID: 291
		[Token(Token = "0x6000123")]
		void Scroll(Vector2 normalizedScrollDelta);

		// Token: 0x06000124 RID: 292
		[Token(Token = "0x6000124")]
		void Scroll(Vector2 normalizedScrollDelta, Vector2 normalizedPoint);

		// Token: 0x06000125 RID: 293
		[Token(Token = "0x6000125")]
		void SelectAll();

		// Token: 0x06000126 RID: 294
		[Token(Token = "0x6000126")]
		void SendKey(string key);

		// Token: 0x06000127 RID: 295
		[Token(Token = "0x6000127")]
		void SetDefaultBackgroundEnabled(bool enabled);

		// Token: 0x06000128 RID: 296
		[Token(Token = "0x6000128")]
		void SetFocused(bool focused);

		// Token: 0x06000129 RID: 297
		[Token(Token = "0x6000129")]
		void SetRenderingEnabled(bool enabled);

		// Token: 0x0600012A RID: 298
		[Token(Token = "0x600012A")]
		void StopLoad();

		// Token: 0x0600012B RID: 299
		[Token(Token = "0x600012B")]
		Task WaitForNextPageLoadToFinish();

		// Token: 0x0600012C RID: 300
		[Token(Token = "0x600012C")]
		void ZoomIn();

		// Token: 0x0600012D RID: 301
		[Token(Token = "0x600012D")]
		void ZoomOut();

		// Token: 0x0600012E RID: 302
		[Token(Token = "0x600012E")]
		[Obsolete("IWebView.Blur() has been removed. Please use SetFocused(false) instead: https://developer.vuplex.com/webview/IWebView#SetFocused", true)]
		void Blur();

		// Token: 0x0600012F RID: 303
		[Token(Token = "0x600012F")]
		[Obsolete("The callback-based CanGoBack(Action) version of this method has been removed. Please switch to the Task-based CanGoBack() version instead. If you prefer using a callback instead of awaiting the Task, you can still use a callback like this: CanGoBack().ContinueWith(result => {...})", true)]
		void CanGoBack(Action<bool> callback);

		// Token: 0x06000130 RID: 304
		[Token(Token = "0x6000130")]
		[Obsolete("The callback-based CanGoForward(Action) version of this method has been removed. Please switch to the Task-based CanGoForward() version instead. If you prefer using a callback instead of awaiting the Task, you can still use a callback like this: CanGoForward().ContinueWith(result => {...})", true)]
		void CanGoForward(Action<bool> callback);

		// Token: 0x06000131 RID: 305
		[Token(Token = "0x6000131")]
		[Obsolete("The callback-based CaptureScreenshot(Action) version of this method has been removed. Please switch to the Task-based CaptureScreenshot() version instead. If you prefer using a callback instead of awaiting the Task, you can still use a callback like this: CaptureScreenshot().ContinueWith(result => {...})", true)]
		void CaptureScreenshot(Action<byte[]> callback);

		// Token: 0x06000132 RID: 306
		[Token(Token = "0x6000132")]
		[Obsolete("DisableViewUpdates() has been removed. Please use SetRenderingEnabled(false) instead: https://developer.vuplex.com/webview/IWebView#SetRenderingEnabled", true)]
		void DisableViewUpdates();

		// Token: 0x06000133 RID: 307
		[Token(Token = "0x6000133")]
		[Obsolete("EnableViewUpdates() has been removed. Please use SetRenderingEnabled(true) instead: https://developer.vuplex.com/webview/IWebView#SetRenderingEnabled", true)]
		void EnableViewUpdates();

		// Token: 0x06000134 RID: 308
		[Token(Token = "0x6000134")]
		[Obsolete("IWebView.Focus() has been removed. Please use SetFocused(false) instead: https://developer.vuplex.com/webview/IWebView#SetFocused", true)]
		void Focus();

		// Token: 0x06000135 RID: 309
		[Token(Token = "0x6000135")]
		[Obsolete("The callback-based GetRawTextureData(Action) version of this method has been removed. Please switch to the Task-based GetRawTextureData() version instead. If you prefer using a callback instead of awaiting the Task, you can still use a callback like this: GetRawTextureData().ContinueWith(result => {...})", true)]
		void GetRawTextureData(Action<byte[]> callback);

		// Token: 0x06000136 RID: 310
		[Token(Token = "0x6000136")]
		[Obsolete("IWebView.HandleKeyboardInput() has been renamed to IWebView.SendKey(). Please switch to SendKey().")]
		void HandleKeyboardInput(string key);

		// Token: 0x06000137 RID: 311
		[Token(Token = "0x6000137")]
		[Obsolete("IWebView.Init(Texture2D, float, float) has been removed in v4. Please switch to IWebView.Init(int, int) and await the Task it returns. For more details, please see this article: https://support.vuplex.com/articles/v4-changes#init", true)]
		void Init(Texture2D texture, float width, float height);

		// Token: 0x06000138 RID: 312
		[Token(Token = "0x6000138")]
		[Obsolete("IWebView.Init(Texture2D, float, float, Texture2D) has been removed in v4. Please switch to IWebView.Init(int, int) and await the Task it returns. For more details, please see this article: https://support.vuplex.com/articles/v4-changes#init", true)]
		void Init(Texture2D texture, float width, float height, Texture2D videoTexture);

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x06000139 RID: 313
		// (remove) Token: 0x0600013A RID: 314
		[Token(Token = "0x14000025")]
		[Obsolete("IWebView.PageLoadFailed is now deprecated. Please use IWebView.LoadFailed instead: https://developer.vuplex.com/webview/IWebView#LoadFailed")]
		event EventHandler PageLoadFailed;

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600013B RID: 315
		[Token(Token = "0x1700001D")]
		[Obsolete("IWebView.Resolution has been removed in v4. Please use WebViewPrefab.Resolution or CanvasWebViewPrefab.Resolution instead. For more details, please see this article: https://support.vuplex.com/articles/v4-changes#resolution", true)]
		float Resolution { [Token(Token = "0x600013B")] get; }

		// Token: 0x0600013C RID: 316
		[Token(Token = "0x600013C")]
		[Obsolete("IWebView.SetResolution() has been removed in v4. Please set the WebViewPrefab.Resolution or CanvasWebViewPrefab.Resolution property instead. For more details, please see this article: https://support.vuplex.com/articles/v4-changes#resolution", true)]
		void SetResolution(float pixelsPerUnityUnit);

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600013D RID: 317
		[Token(Token = "0x1700001E")]
		[Obsolete("IWebView.SizeInPixels is now deprecated. Please use IWebView.Size instead: https://developer.vuplex.com/webview/IWebView#Size")]
		Vector2 SizeInPixels { [Token(Token = "0x600013D")] get; }

		// Token: 0x14000026 RID: 38
		// (add) Token: 0x0600013E RID: 318
		// (remove) Token: 0x0600013F RID: 319
		[Token(Token = "0x14000026")]
		[Obsolete("IWebView.VideoRectChanged has been removed. Please use IWithFallbackVideo.VideoRectChanged instead: https://developer.vuplex.com/webview/IWithFallbackVideo#VideoRectChanged", true)]
		event EventHandler<EventArgs<Rect>> VideoRectChanged;

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000140 RID: 320
		[Token(Token = "0x1700001F")]
		[Obsolete("IWebView.VideoTexture has been removed. Please use IWithFallbackVideo.VideoTexture instead: https://developer.vuplex.com/webview/IWithFallbackVideo#VideoTexture", true)]
		Texture2D VideoTexture { [Token(Token = "0x6000140")] get; }
	}
}
