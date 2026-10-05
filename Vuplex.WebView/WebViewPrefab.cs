using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;
using Vuplex.WebView.Internal;

namespace Vuplex.WebView
{
	// Token: 0x02000058 RID: 88
	[Token(Token = "0x2000058")]
	[HelpURL("https://developer.vuplex.com/webview/WebViewPrefab")]
	public class WebViewPrefab : BaseWebViewPrefab
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600022D RID: 557 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000038")]
		public Collider Collider
		{
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x5BC9830", Offset = "0x5BC8430", VA = "0x185BC9830")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x5BC8BB0", Offset = "0x5BC77B0", VA = "0x185BC8BB0", Slot = "10")]
		public override Vector2 BrowserToScreenPoint(int xInPixels, int yInPixels)
		{
			return default(Vector2);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x5BC8E90", Offset = "0x5BC7A90", VA = "0x185BC8E90")]
		public static WebViewPrefab Instantiate(float width, float height)
		{
			return null;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x5BC8FA0", Offset = "0x5BC7BA0", VA = "0x185BC8FA0")]
		public static WebViewPrefab Instantiate(float width, float height, WebViewOptions options)
		{
			return null;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x5BC8EB0", Offset = "0x5BC7AB0", VA = "0x185BC8EB0")]
		public static WebViewPrefab Instantiate(IWebView webView)
		{
			return null;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x5BC90C0", Offset = "0x5BC7CC0", VA = "0x185BC90C0")]
		public void Resize(float width, float height)
		{
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x5BC8E10", Offset = "0x5BC7A10", VA = "0x185BC8E10")]
		public Vector2 WorldToNormalized(Vector3 worldPoint)
		{
			return default(Vector2);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x5BC9400", Offset = "0x5BC8000", VA = "0x185BC9400", Slot = "11")]
		protected override float _getResolution()
		{
			return 0f;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x55E40E0", Offset = "0x55E2CE0", VA = "0x1855E40E0", Slot = "13")]
		protected override float _getScrollingSensitivity()
		{
			return 0f;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x3739000", Offset = "0x3737C00", VA = "0x183739000", Slot = "12")]
		protected override bool _getNativeOnScreenKeyboardEnabled()
		{
			return default(bool);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x5BC9480", Offset = "0x5BC8080", VA = "0x185BC9480", Slot = "14")]
		protected override ViewportMaterialView _getView()
		{
			return null;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x5BC92C0", Offset = "0x5BC7EC0", VA = "0x185BC92C0")]
		private void _initWebViewPrefab()
		{
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x5BC9500", Offset = "0x5BC8100", VA = "0x185BC9500")]
		private void _resetLocalScale()
		{
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x5BC9730", Offset = "0x5BC8330", VA = "0x185BC9730")]
		private void _setViewSize(float width, float height)
		{
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x5BC92C0", Offset = "0x5BC7EC0", VA = "0x185BC92C0")]
		private void Start()
		{
		}

		// Token: 0x0600023C RID: 572 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x5BC8E10", Offset = "0x5BC7A10", VA = "0x185BC8E10")]
		[Obsolete("WebViewPrefab.ConvertToScreenPoint() has been renamed to WebViewPrefab.WorldToNormalized(). Please switch to WorldToNormalized().")]
		public Vector2 ConvertToScreenPoint(Vector3 worldPoint)
		{
			return default(Vector2);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Obsolete("WebViewPrefab.Init() has been removed. The WebViewPrefab script now initializes itself automatically, so Init() no longer needs to be called.", true)]
		public void Init()
		{
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Obsolete("WebViewPrefab.Init() has been removed. The WebViewPrefab script now initializes itself automatically, so Init() no longer needs to be called.", true)]
		public void Init(float width, float height)
		{
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Obsolete("WebViewPrefab.Init() has been removed. The WebViewPrefab script now initializes itself automatically, so Init() no longer needs to be called.", true)]
		public void Init(float width, float height, WebViewOptions options)
		{
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Obsolete("WebViewPrefab.Init() has been removed. The WebViewPrefab script now initializes itself automatically, so Init() no longer needs to be called. Please use WebViewPrefab.SetWebViewForInitialization(IWebView) instead.", true)]
		public void Init(IWebView webView)
		{
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000241 RID: 577 RVA: 0x000024C0 File Offset: 0x000006C0
		// (set) Token: 0x06000242 RID: 578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000039")]
		[Obsolete("WebViewPrefab.InitialResolution is now deprecated. Please use WebViewPrefab.Resolution instead.")]
		public float InitialResolution
		{
			[Token(Token = "0x6000241")]
			[Address(RVA = "0x5BB2B50", Offset = "0x5BB1750", VA = "0x185BB2B50")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x5BB2E40", Offset = "0x5BB1A40", VA = "0x185BB2E40")]
			set
			{
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x5BC9360", Offset = "0x5BC7F60", VA = "0x185BC9360")]
		public WebViewPrefab()
		{
		}

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0xE8")]
		[Label("Native On-Screen Keyboard (Android, iOS, & visionOS only)")]
		[Tooltip("Determines whether the operating system's native on-screen keyboard is automatically shown when a text input in the webview is focused. The native on-screen keyboard is only supported for the following packages:\n• 3D WebView for Android (non-Gecko)\n• 3D WebView for iOS\n• 3D WebView for visionOS")]
		[Header("Platform-specific")]
		public bool NativeOnScreenKeyboardEnabled;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0xEC")]
		[FormerlySerializedAs("InitialResolution")]
		[HideInInspector]
		[Tooltip("You can change this to make web content appear larger or smaller.")]
		[Label("Resolution (px / Unity unit)")]
		public float Resolution;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0xF0")]
		[HideInInspector]
		public float ScrollingSensitivity;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0xF4")]
		private Vector2 _sizeForInitialization;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x100")]
		[HideInInspector]
		[SerializeField]
		protected Transform _viewResizer;

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x0")]
		[Obsolete("The static WebViewPrefab.ScrollSensitivity property has been removed. Please use the ScrollingSensitivity instance property instead: https://developer.vuplex.com/webview/WebViewPrefab#ScrollingSensitivity", true)]
		public static float ScrollSensitivity;
	}
}
