using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Vuplex.WebView
{
	// Token: 0x02000071 RID: 113
	[Token(Token = "0x2000071")]
	public class WindowsWebView : StandaloneWebView, IWebView
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600032F RID: 815 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x1700003F")]
		public WebPluginType PluginType
		{
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x5BCB120", Offset = "0x5BC9D20", VA = "0x185BCB120", Slot = "155")]
			[CompilerGenerated]
			get
			{
				return WebPluginType.Android;
			}
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x5BCABE0", Offset = "0x5BC97E0", VA = "0x185BCABE0", Slot = "39")]
		public override void Dispose()
		{
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x5BCA960", Offset = "0x5BC9560", VA = "0x185BCA960")]
		public static WindowsWebView Instantiate()
		{
			return null;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x5BCB030", Offset = "0x5BC9C30", VA = "0x185BCB030", Slot = "70")]
		protected override GraphicsDeviceType[] _getSupportedGraphicsApis()
		{
			return null;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00002520 File Offset: 0x00000720
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x4CC3770", Offset = "0x4CC2370", VA = "0x184CC3770", Slot = "71")]
		protected override TextureFormat _getTextureFormat()
		{
			return (TextureFormat)0;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x5BCA960", Offset = "0x5BC9560", VA = "0x185BCA960", Slot = "131")]
		protected override StandaloneWebView _instantiate()
		{
			return null;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x5BCADA0", Offset = "0x5BC99A0", VA = "0x185BCADA0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x5BCB0A0", Offset = "0x5BC9CA0", VA = "0x185BCB0A0")]
		private IEnumerator _renderPluginOncePerFrame()
		{
			return null;
		}

		// Token: 0x06000337 RID: 823
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x5BCAE20", Offset = "0x5BC9A20", VA = "0x185BCAE20")]
		[PreserveSig]
		private static extern int WebView_depositPointer(IntPtr pointer);

		// Token: 0x06000338 RID: 824
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x5BCAEA0", Offset = "0x5BC9AA0", VA = "0x185BCAEA0")]
		[PreserveSig]
		private static extern IntPtr WebView_getRenderFunction();

		// Token: 0x06000339 RID: 825
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x5BCAF10", Offset = "0x5BC9B10", VA = "0x185BCAF10")]
		[PreserveSig]
		private static extern void WebView_removePointer(IntPtr pointer);

		// Token: 0x0600033A RID: 826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x5BCAF90", Offset = "0x5BC9B90", VA = "0x185BCAF90")]
		public WindowsWebView()
		{
		}

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private readonly WaitForEndOfFrame _waitForEndOfFrame;
	}
}
