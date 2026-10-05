using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using Vuplex.WebView.Internal;

namespace Vuplex.WebView
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public abstract class BaseWebViewPrefab : MonoBehaviour
	{
		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000004")]
		public virtual event EventHandler<ClickedEventArgs> Clicked
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x5BA7920", Offset = "0x5BA6520", VA = "0x185BA7920", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x5BA7EB0", Offset = "0x5BA6AB0", VA = "0x185BA7EB0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000005")]
		public event EventHandler Initialized
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x5BA79D0", Offset = "0x5BA65D0", VA = "0x185BA79D0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x5BA7F60", Offset = "0x5BA6B60", VA = "0x185BA7F60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000006")]
		public event EventHandler PointerEntered
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x5BA7A70", Offset = "0x5BA6670", VA = "0x185BA7A70")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x5BA8000", Offset = "0x5BA6C00", VA = "0x185BA8000")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000007")]
		public event EventHandler PointerExited
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x5BA7B10", Offset = "0x5BA6710", VA = "0x185BA7B10")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x5BA80A0", Offset = "0x5BA6CA0", VA = "0x185BA80A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000008")]
		public virtual event EventHandler<ScrolledEventArgs> Scrolled
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x5BA7BB0", Offset = "0x5BA67B0", VA = "0x185BA7BB0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x5BA8140", Offset = "0x5BA6D40", VA = "0x185BA8140", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000002")]
		public Material Material
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x5BA7C70", Offset = "0x5BA6870", VA = "0x185BA7C70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x5BA8200", Offset = "0x5BA6E00", VA = "0x185BA8200")]
			set
			{
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002058 File Offset: 0x00000258
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000003")]
		public virtual bool Visible
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x371A210", Offset = "0x3718E10", VA = "0x18371A210", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x5BA8260", Offset = "0x5BA6E60", VA = "0x185BA8260", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000004")]
		public IWebView WebView
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x5BA7CC0", Offset = "0x5BA68C0", VA = "0x185BA7CC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x5BA82B0", Offset = "0x5BA6EB0", VA = "0x185BA82B0")]
			private set
			{
			}
		}

		// Token: 0x06000029 RID: 41
		[Token(Token = "0x6000029")]
		public abstract Vector2 BrowserToScreenPoint(int xInPixels, int yInPixels);

		// Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x5BA4680", Offset = "0x5BA3280", VA = "0x185BA4680")]
		public void Destroy()
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x5BA54E0", Offset = "0x5BA40E0", VA = "0x185BA54E0")]
		public void SetOptionsForInitialization(WebViewOptions options)
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x5BA5570", Offset = "0x5BA4170", VA = "0x185BA5570")]
		public void SetPointerInputDetector(IPointerInputDetector pointerInputDetector)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x5BA5610", Offset = "0x5BA4210", VA = "0x185BA5610")]
		public void SetRenderBlackAsTransparent(bool enabled)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x5BA5640", Offset = "0x5BA4240", VA = "0x185BA5640")]
		public void SetWebViewForInitialization(IWebView webView)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x5BA5890", Offset = "0x5BA4490", VA = "0x185BA5890")]
		public Task WaitUntilInitialized()
		{
			return null;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00002070 File Offset: 0x00000270
		[Token(Token = "0x17000005")]
		private int _heightInPixels
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x5BA7D80", Offset = "0x5BA6980", VA = "0x185BA7D80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000006")]
		private IPointerInputDetector _pointerInputDetector
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x5BA7DA0", Offset = "0x5BA69A0", VA = "0x185BA7DA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x5BA8400", Offset = "0x5BA7000", VA = "0x185BA8400")]
			set
			{
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000007")]
		protected ViewportMaterialView _view
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x5BA7DE0", Offset = "0x5BA69E0", VA = "0x185BA7DE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00002088 File Offset: 0x00000288
		[Token(Token = "0x17000008")]
		private int _widthInPixels
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x5BA7E90", Offset = "0x5BA6A90", VA = "0x185BA7E90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x5BA5CD0", Offset = "0x5BA48D0", VA = "0x185BA5CD0")]
		private void _attachOrDetachPointerInputDetector(IPointerInputDetector detector, bool attach)
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x5BA6230", Offset = "0x5BA4E30", VA = "0x185BA6230")]
		private void _attachWebViewEventHandlers(IWebView webView)
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void _disableHoveringIfNeeded(bool preferNative2DMode)
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x5BA64B0", Offset = "0x5BA50B0", VA = "0x185BA64B0")]
		private void _enableConsoleMessagesIfNeeded(IWebView webView)
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x5BA65F0", Offset = "0x5BA51F0", VA = "0x185BA65F0")]
		private void _enableNativeOnScreenKeyboardIfNeeded(IWebView webView)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x5BA66B0", Offset = "0x5BA52B0", VA = "0x185BA66B0")]
		private void _enableOrDisableKeyboardIfNeeded()
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x5BA6700", Offset = "0x5BA5300", VA = "0x185BA6700")]
		private void _enableRemoteDebuggingIfNeeded()
		{
		}

		// Token: 0x0600003C RID: 60
		[Token(Token = "0x600003C")]
		protected abstract float _getResolution();

		// Token: 0x0600003D RID: 61
		[Token(Token = "0x600003D")]
		protected abstract bool _getNativeOnScreenKeyboardEnabled();

		// Token: 0x0600003E RID: 62
		[Token(Token = "0x600003E")]
		protected abstract float _getScrollingSensitivity();

		// Token: 0x0600003F RID: 63 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x5BA6950", Offset = "0x5BA5550", VA = "0x185BA6950")]
		private IWithTouch _getTouchIfSupported()
		{
			return null;
		}

		// Token: 0x06000040 RID: 64
		[Token(Token = "0x6000040")]
		protected abstract ViewportMaterialView _getView();

		// Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x5BA69F0", Offset = "0x5BA55F0", VA = "0x185BA69F0")]
		private void _handleTrialExpired()
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x5BA6AC0", Offset = "0x5BA56C0", VA = "0x185BA6AC0")]
		protected Task _initBase(Rect rect, bool preferNative2DMode = false)
		{
			return null;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x5BA6D30", Offset = "0x5BA5930", VA = "0x185BA6D30")]
		private void _initViews(IWebView webView)
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x5BA6FE0", Offset = "0x5BA5BE0", VA = "0x185BA6FE0")]
		private Task<IWebView> _initWebView(Rect rect, bool preferNative2DMode)
		{
			return null;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x5BA6BD0", Offset = "0x5BA57D0", VA = "0x185BA6BD0")]
		private void _initPointerInputDetector(IWebView webView)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x5BA46E0", Offset = "0x5BA32E0", VA = "0x185BA46E0")]
		private void InputDetector_BeganDrag(object sender, EventArgs<Vector2> eventArgs)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x5BA4710", Offset = "0x5BA3310", VA = "0x185BA4710")]
		private void InputDetector_Dragged(object sender, EventArgs<Vector2> eventArgs)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x5BA49F0", Offset = "0x5BA35F0", VA = "0x185BA49F0", Slot = "15")]
		protected virtual void InputDetector_PointerDown(object sender, PointerEventArgs eventArgs)
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x5BA4C40", Offset = "0x5BA3840", VA = "0x185BA4C40")]
		private void InputDetector_PointerEntered(object sender, EventArgs eventArgs)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x5BA4CC0", Offset = "0x5BA38C0", VA = "0x185BA4CC0")]
		private void InputDetector_PointerExited(object sender, EventArgs<Vector2> eventArgs)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x5BA4DB0", Offset = "0x5BA39B0", VA = "0x185BA4DB0")]
		private void InputDetector_PointerMoved(object sender, EventArgs<Vector2> eventArgs)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x5BA4E30", Offset = "0x5BA3A30", VA = "0x185BA4E30", Slot = "16")]
		protected virtual void InputDetector_PointerUp(object sender, PointerEventArgs eventArgs)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x5BA51C0", Offset = "0x5BA3DC0", VA = "0x185BA51C0")]
		private void InputDetector_Scrolled(object sender, ScrolledEventArgs eventArgs)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x5BA7110", Offset = "0x5BA5D10", VA = "0x185BA7110")]
		private void _movePointerIfNeeded(Vector2 point, bool pointerLeave = false)
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000020A0 File Offset: 0x000002A0
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x5BA71E0", Offset = "0x5BA5DE0", VA = "0x185BA71E0")]
		private bool _native2DModeEnabled(IWebView webView)
		{
			return default(bool);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x5BA5260", Offset = "0x5BA3E60", VA = "0x185BA5260", Slot = "17")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x5BA7260", Offset = "0x5BA5E60", VA = "0x185BA7260")]
		protected void _resizeWebViewIfNeeded()
		{
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x5BA7420", Offset = "0x5BA6020", VA = "0x185BA7420")]
		private void _scrollIfNeeded(Vector2 scrollDelta, Vector2 point)
		{
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x5BA7610", Offset = "0x5BA6210", VA = "0x185BA7610")]
		private void _throwExceptionIfInitialized()
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x5BA5800", Offset = "0x5BA4400", VA = "0x185BA5800", Slot = "18")]
		protected virtual void Update()
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x5BA7680", Offset = "0x5BA6280", VA = "0x185BA7680")]
		private void _updatePixelDensityIfNeeded(IWebView webView)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x5BA7870", Offset = "0x5BA6470", VA = "0x185BA7870")]
		private void _updateResolutionIfNeeded()
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x5BA59F0", Offset = "0x5BA45F0", VA = "0x185BA59F0")]
		private void WebView_ConsoleMessageLogged(object sender, ConsoleMessageEventArgs eventArgs)
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x5BA5B00", Offset = "0x5BA4700", VA = "0x185BA5B00")]
		private void WebView_FallbackVideoRectChanged(object sender, EventArgs<Rect> eventArgs)
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x5BA5B70", Offset = "0x5BA4770", VA = "0x185BA5B70")]
		private void WebView_TextureChanged(object sender, EventArgs<Texture2D> eventArgs)
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600005A RID: 90 RVA: 0x000020B8 File Offset: 0x000002B8
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000009")]
		[Obsolete("The WebViewPrefab.DragToScrollThreshold property has been removed. Please use DragThreshold instead: https://developer.vuplex.com/webview/WebViewPrefab#DragThreshold", true)]
		public float DragToScrollThreshold
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x5BA7C60", Offset = "0x5BA6860", VA = "0x185BA7C60")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x5BA81F0", Offset = "0x5BA6DF0", VA = "0x185BA81F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Obsolete("WebViewPrefab.SetCutoutRect() has been replaced with WebViewPrefab.SetRenderBlackAsTransparent(). Please call SetRenderBlackAsTransparent(true) on the WebViewPrefab instance instead.", true)]
		public void SetCutoutRect(Rect rect)
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x5BA6480", Offset = "0x5BA5080", VA = "0x185BA6480")]
		protected BaseWebViewPrefab()
		{
		}

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x40")]
		public bool ClickingEnabled;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x41")]
		[Label("Cursor Icons Enabled (Windows & macOS only)")]
		[Tooltip("(Windows and macOS only) Sets whether the mouse cursor icon is automatically updated based on interaction with the web page. For example, hovering over a link causes the mouse cursor icon to turn into a pointer hand.")]
		public bool CursorIconsEnabled;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("Determines how the prefab handles drag interactions. Note that This property is ignored when running in Native 2D Mode.")]
		public DragMode DragMode;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x48")]
		[Label("Drag Threshold (px)")]
		[Tooltip("Determines the threshold (in web pixels) for triggering a drag.")]
		public float DragThreshold;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x4C")]
		public bool HoveringEnabled;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("You can set this to the URL that you want to load, or you can leave it blank if you'd rather add a script to load content programmatically with IWebView.LoadUrl() or LoadHtml().")]
		[Label("Initial URL (optional)")]
		[HideInInspector]
		public string InitialUrl;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x58")]
		[Tooltip("Determines whether the webview automatically receives keyboard input from the native keyboard and the Keyboard prefab.")]
		public bool KeyboardEnabled;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x59")]
		[Tooltip("Determines whether JavaScript console messages are printed to the Unity logs.")]
		public bool LogConsoleMessages;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x5C")]
		[Label("Pixel Density (Windows & macOS only)")]
		[Tooltip("(Windows and macOS only) Sets the webview's pixel density.")]
		public float PixelDensity;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x60")]
		[Tooltip("Determines whether remote debugging is enabled.")]
		[Header("Debugging")]
		public bool RemoteDebuggingEnabled;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x61")]
		public bool ScrollingEnabled;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x64")]
		private float _appliedResolution;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x68")]
		[HideInInspector]
		[SerializeField]
		private ViewportMaterialView _cachedView;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x70")]
		private IWebView _cachedWebView;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x78")]
		private bool _consoleMessageLoggedHandlerAttached;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x79")]
		private bool _dragThresholdReached;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x7A")]
		private bool _dragToScrollClickIsPending;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x7B")]
		private bool _hasOverriddenCursorIcon;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x7C")]
		private bool _keyboardHasBeenEnabled;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x7D")]
		private bool _loggedDragWarning;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x0")]
		private static bool _loggedHoverWarning;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x80")]
		protected WebViewOptions _options;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[HideInInspector]
		private MonoBehaviour _pointerInputDetectorMonoBehaviour;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x98")]
		private bool _pointerIsDown;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x9C")]
		private Vector2 _pointerDownNormalizedPoint;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0xA4")]
		private Vector2 _previousNormalizedDragPoint;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0xAC")]
		private Vector2 _previousMovePointerPoint;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x1")]
		private static bool _remoteDebuggingEnabled;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0xB4")]
		protected Vector2 _sizeInUnityUnits;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0xC0")]
		private Material _viewMaterial;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0xC8")]
		private bool _visible;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0xD0")]
		protected IWebView _webViewForInitialization;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[HideInInspector]
		private GameObject _webViewGameObject;
	}
}
