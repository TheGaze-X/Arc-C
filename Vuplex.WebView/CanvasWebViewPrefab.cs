using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;
using Vuplex.WebView.Internal;

namespace Vuplex.WebView
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	[HelpURL("https://developer.vuplex.com/webview/CanvasWebViewPrefab")]
	public class CanvasWebViewPrefab : BaseWebViewPrefab
	{
		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000073 RID: 115 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000074 RID: 116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000009")]
		public override event EventHandler<ClickedEventArgs> Clicked
		{
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x5BB2890", Offset = "0x5BB1490", VA = "0x185BB2890", Slot = "4")]
			add
			{
			}
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x5BA7EB0", Offset = "0x5BA6AB0", VA = "0x185BA7EB0", Slot = "5")]
			remove
			{
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000075 RID: 117 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000076 RID: 118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000A")]
		public override event EventHandler<ScrolledEventArgs> Scrolled
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x5BB29F0", Offset = "0x5BB15F0", VA = "0x185BB29F0", Slot = "6")]
			add
			{
			}
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x5BA8140", Offset = "0x5BA6D40", VA = "0x185BA8140", Slot = "7")]
			remove
			{
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00002148 File Offset: 0x00000348
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000C")]
		public override bool Visible
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x5BB2B60", Offset = "0x5BB1760", VA = "0x185BB2B60", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x5BB2E50", Offset = "0x5BB1A50", VA = "0x185BB2E50", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x5BB10F0", Offset = "0x5BAFCF0", VA = "0x185BB10F0", Slot = "10")]
		public override Vector2 BrowserToScreenPoint(int xInPixels, int yInPixels)
		{
			return default(Vector2);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x5BB1360", Offset = "0x5BAFF60", VA = "0x185BB1360")]
		public static CanvasWebViewPrefab Instantiate()
		{
			return null;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x5BB1470", Offset = "0x5BB0070", VA = "0x185BB1470")]
		public static CanvasWebViewPrefab Instantiate(WebViewOptions options)
		{
			return null;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x5BB1380", Offset = "0x5BAFF80", VA = "0x185BB1380")]
		public static CanvasWebViewPrefab Instantiate(IWebView webView)
		{
			return null;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700000D")]
		private Canvas _canvas
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x5BB2C10", Offset = "0x5BB1810", VA = "0x185BB2C10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x1700000E")]
		private bool _native2DModeActive
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x5BB2D30", Offset = "0x5BB1930", VA = "0x185BB2D30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700000F")]
		private RectTransform _rectTransform
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x5BB2D90", Offset = "0x5BB1990", VA = "0x185BB2D90")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x5BB18B0", Offset = "0x5BB04B0", VA = "0x185BB18B0")]
		private bool _canNative2DModeBeEnabled(bool logWarnings = false)
		{
			return default(bool);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x5BB1A40", Offset = "0x5BB0640", VA = "0x185BB1A40")]
		private Rect _getRectForInitialization(bool preferNative2DMode)
		{
			return default(Rect);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x5BB1AB0", Offset = "0x5BB06B0", VA = "0x185BB1AB0", Slot = "11")]
		protected override float _getResolution()
		{
			return 0f;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x5BB19D0", Offset = "0x5BB05D0", VA = "0x185BB19D0")]
		private IWithNative2DMode _getNative2DWebViewIfActive()
		{
			return null;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x5B79540", Offset = "0x5B78140", VA = "0x185B79540", Slot = "12")]
		protected override bool _getNativeOnScreenKeyboardEnabled()
		{
			return default(bool);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x55E40E0", Offset = "0x55E2CE0", VA = "0x1855E40E0", Slot = "13")]
		protected override float _getScrollingSensitivity()
		{
			return 0f;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x5BB1B30", Offset = "0x5BB0730", VA = "0x185BB1B30")]
		private Rect _getScreenSpaceRect()
		{
			return default(Rect);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x5BB1F80", Offset = "0x5BB0B80", VA = "0x185BB1F80")]
		private float _getScreenSpaceScaleFactor()
		{
			return 0f;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x5BB20D0", Offset = "0x5BB0CD0", VA = "0x185BB20D0", Slot = "14")]
		protected override ViewportMaterialView _getView()
		{
			return null;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x5BB16B0", Offset = "0x5BB02B0", VA = "0x185BB16B0")]
		private void _initCanvasPrefab()
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x5BB2180", Offset = "0x5BB0D80", VA = "0x185BB2180")]
		private void _logErrorIfNative2DModeEnabledChanged()
		{
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x5BB21E0", Offset = "0x5BB0DE0", VA = "0x185BB21E0")]
		private bool _logErrorIfSizeIsInvalid(Vector2 size)
		{
			return default(bool);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x5BB2470", Offset = "0x5BB1070", VA = "0x185BB2470")]
		private void _logEventCameraWarningIfNeeded()
		{
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x5BB2550", Offset = "0x5BB1150", VA = "0x185BB2550")]
		private void _logNative2DModeWarning(string message)
		{
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x5BB25A0", Offset = "0x5BB11A0", VA = "0x185BB25A0")]
		private void _logNative2DRecommendationIfNeeded(object sender, EventArgs eventArgs)
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x5BB1570", Offset = "0x5BB0170", VA = "0x185BB1570")]
		private void OnDisable()
		{
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x5BB1610", Offset = "0x5BB0210", VA = "0x185BB1610")]
		private void OnEnable()
		{
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x5BB2640", Offset = "0x5BB1240", VA = "0x185BB2640")]
		private bool _resizeNative2DWebViewIfNeeded()
		{
			return default(bool);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x5BB2860", Offset = "0x5BB1460", VA = "0x185BB2860")]
		private bool _sizeIsInvalid(Vector2 size)
		{
			return default(bool);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x5BB16B0", Offset = "0x5BB02B0", VA = "0x185BB16B0")]
		private void Start()
		{
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x5BB1750", Offset = "0x5BB0350", VA = "0x185BB1750", Slot = "18")]
		protected override void Update()
		{
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Obsolete("CanvasWebViewPrefab.Init() has been removed. The CanvasWebViewPrefab script now initializes itself automatically, so Init() no longer needs to be called.", true)]
		public void Init()
		{
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Obsolete("CanvasWebViewPrefab.Init() has been removed. The CanvasWebViewPrefab script now initializes itself automatically, so Init() no longer needs to be called.", true)]
		public void Init(WebViewOptions options)
		{
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Obsolete("CanvasWebViewPrefab.Init() has been removed. The CanvasWebViewPrefab script now initializes itself automatically, so Init() no longer needs to be called. Please use CanvasWebViewPrefab.SetWebViewForInitialization(IWebView) instead.", true)]
		public void Init(IWebView webView)
		{
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00002280 File Offset: 0x00000480
		// (set) Token: 0x06000099 RID: 153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000010")]
		[Obsolete("CanvasWebViewPrefab.InitialResolution is now deprecated. Please use CanvasWebViewPrefab.Resolution instead.")]
		public float InitialResolution
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x5BB2B50", Offset = "0x5BB1750", VA = "0x185BB2B50")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x5BB2E40", Offset = "0x5BB1A40", VA = "0x185BB2E40")]
			set
			{
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x5BB1980", Offset = "0x5BB0580", VA = "0x185BB1980")]
		public CanvasWebViewPrefab()
		{
		}

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0xE8")]
		[Label("Native 2D Mode (Android, iOS, WebGL, & UWP only)")]
		[Tooltip("Native 2D Mode positions a native 2D webview in front of the Unity game view instead of rendering web content as a texture in the Unity scene. Native 2D Mode provides better performance on iOS and UWP, because the default mode of rendering web content to a texture is slower. \n\nImportant notes:\n• Native 2D Mode is only supported for Android (non-Gecko), iOS, WebGL, and UWP. For the other 3D WebView packages, the default render mode is used instead.\n• Native 2D Mode requires that the canvas's render mode be set to \"Screen Space - Overlay\".")]
		[HideInInspector]
		[Header("Platform-specific")]
		public bool Native2DModeEnabled;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0xE9")]
		[Label("Native On-Screen Keyboard (Android, iOS, & visionOS only)")]
		[Tooltip("Determines whether the operating system's native on-screen keyboard is automatically shown when a text input in the webview is focused. The native on-screen keyboard is only supported for the following packages:\n• 3D WebView for Android (non-Gecko)\n• 3D WebView for iOS\n• 3D WebView for visionOS")]
		public bool NativeOnScreenKeyboardEnabled;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0xEC")]
		[Tooltip("You can change this to make web content appear larger or smaller. Note that This property is ignored when running in Native 2D Mode.")]
		[HideInInspector]
		[Label("Resolution (px / Unity unit)")]
		[FormerlySerializedAs("InitialResolution")]
		public float Resolution;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0xF0")]
		[HideInInspector]
		[Tooltip("Determines the scroll sensitivity. Note that This property is ignored when running in Native 2D Mode.")]
		public float ScrollingSensitivity;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0xF8")]
		private RectTransform _cachedRectTransform;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x100")]
		private CachingGetter<Canvas> _canvasGetter;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x108")]
		private bool _native2DModeEnabledAtInitialization;
	}
}
