using System;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using Vuplex.WebView.Internal;

namespace Vuplex.WebView
{
	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	public static class Web
	{
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000209 RID: 521 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000036")]
		public static ICookieManager CookieManager
		{
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x5BCA800", Offset = "0x5BC9400", VA = "0x185BCA800")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600020A RID: 522 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x17000037")]
		public static WebPluginType DefaultPluginType
		{
			[Token(Token = "0x600020A")]
			[Address(RVA = "0x5BCA8B0", Offset = "0x5BC94B0", VA = "0x185BCA8B0")]
			get
			{
				return WebPluginType.Android;
			}
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x5BC98E0", Offset = "0x5BC84E0", VA = "0x185BC98E0")]
		public static void ClearAllData()
		{
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x5BC9D50", Offset = "0x5BC8950", VA = "0x185BC9D50")]
		public static IWebView CreateWebView()
		{
			return null;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x5BC9C90", Offset = "0x5BC8890", VA = "0x185BC9C90")]
		public static IWebView CreateWebView(WebPluginType[] preferredPlugins)
		{
			return null;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x5BC9E00", Offset = "0x5BC8A00", VA = "0x185BC9E00")]
		public static void EnableRemoteDebugging()
		{
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x5BC9F90", Offset = "0x5BC8B90", VA = "0x185BC9F90")]
		public static void SetAutoplayEnabled(bool enabled)
		{
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x5BCA0D0", Offset = "0x5BC8CD0", VA = "0x185BCA0D0")]
		public static void SetCameraAndMicrophoneEnabled(bool enabled)
		{
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x5BCA210", Offset = "0x5BC8E10", VA = "0x185BCA210")]
		public static void SetIgnoreCertificateErrors(bool ignore)
		{
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x5BCA3C0", Offset = "0x5BC8FC0", VA = "0x185BCA3C0")]
		public static void SetStorageEnabled(bool enabled)
		{
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x5BCA500", Offset = "0x5BC9100", VA = "0x185BCA500")]
		public static void SetUserAgent(bool mobile)
		{
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x5BCA640", Offset = "0x5BC9240", VA = "0x185BCA640")]
		public static void SetUserAgent(string userAgent)
		{
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x5BCA350", Offset = "0x5BC8F50", VA = "0x185BCA350")]
		internal static void SetPluginFactory(WebPluginFactory pluginFactory)
		{
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x5BC9A70", Offset = "0x5BC8670", VA = "0x185BC9A70")]
		[Obsolete("Web.CreateMaterial() is now deprecated in v4. Please use IWebView.CreateMaterial() instead: https://developer.vuplex.com/webview/IWebView#CreateMaterial")]
		public static Task<Material> CreateMaterial()
		{
			return null;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x5BC9BD0", Offset = "0x5BC87D0", VA = "0x185BC9BD0")]
		[Obsolete("Web.CreateMaterial() is now deprecated in v4. Please use IWebView.CreateMaterial() instead: https://developer.vuplex.com/webview/IWebView#CreateMaterial")]
		public static void CreateMaterial(Action<Material> callback)
		{
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780")]
		[Obsolete("Web.CreateTexture() has been removed in v4 because IWebView instances now automatically create their own textures. For more details, please see this article: https://support.vuplex.com/articles/v4-changes#init", true)]
		public static Task<Texture2D> CreateTexture(int width, int height)
		{
			return null;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Obsolete("Web.CreateTexture() has been removed in v4 because IWebView instances now automatically create their own textures. For more details, please see this article: https://support.vuplex.com/articles/v4-changes#init", true)]
		public static void CreateTexture(float width, float height, Action<Texture2D> callback)
		{
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Obsolete("Web.CreateVideoMaterial() has been removed. Please use IWithFallbackVideo.CreateVideoMaterial() instead: https://developer.vuplex.com/webview/IWithFallbackVideo#CreateVideoMaterial", true)]
		public static void CreateVideoMaterial(Action<Material> callback)
		{
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Obsolete("Web.SetTouchScreenKeyboardEnabled() has been removed. Please use the NativeOnScreenKeyboardEnabled property of WebViewPrefab / CanvasWebViewPrefab or the IWithNativeOnScreenKeyboard interface instead: https://developer.vuplex.com/webview/WebViewPrefab#NativeOnScreenKeyboardEnabled", true)]
		public static void SetTouchScreenKeyboardEnabled(bool enabled)
		{
		}

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x0")]
		private static WebPluginFactory _pluginFactory;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		private const string CreateMaterialMessage = "Web.CreateMaterial() is now deprecated in v4. Please use IWebView.CreateMaterial() instead: https://developer.vuplex.com/webview/IWebView#CreateMaterial";

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		private const string CreateTextureMessage = "Web.CreateTexture() has been removed in v4 because IWebView instances now automatically create their own textures. For more details, please see this article: https://support.vuplex.com/articles/v4-changes#init";
	}
}
