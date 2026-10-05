using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AOT;
using Il2CppDummyDll;
using UnityEngine;
using Vuplex.WebView.Internal;

namespace Vuplex.WebView
{
	// Token: 0x02000065 RID: 101
	[Token(Token = "0x2000065")]
	public abstract class StandaloneWebView : BaseWebView, IWithAuth, IWithCursorType, IWithDeepLinking, IWithDownloads, IWithFileSelection, IWithIme, IWithKeyDownAndUp, IWithMovablePointer, IWithMutableAudio, IWithNativeJavaScriptDialogs, IWithPdfCreation, IWithPixelDensity, IWithPointerDownAndUp, IWithPopups, IWithSettableUserAgent, IWithTouch
	{
		// Token: 0x1400003B RID: 59
		// (add) Token: 0x06000269 RID: 617 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600026A RID: 618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400003B")]
		public event EventHandler<AuthRequestedEventArgs> AuthRequested
		{
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x5BC3670", Offset = "0x5BC2270", VA = "0x185BC3670", Slot = "97")]
			add
			{
			}
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x5BC3D30", Offset = "0x5BC2930", VA = "0x185BC3D30", Slot = "98")]
			remove
			{
			}
		}

		// Token: 0x1400003C RID: 60
		// (add) Token: 0x0600026B RID: 619 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600026C RID: 620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400003C")]
		public event EventHandler<StandaloneClientCertificateRequestedEventArgs> ClientCertificateRequested
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x5BC3770", Offset = "0x5BC2370", VA = "0x185BC3770")]
			add
			{
			}
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x5BC3DD0", Offset = "0x5BC29D0", VA = "0x185BC3DD0")]
			remove
			{
			}
		}

		// Token: 0x1400003D RID: 61
		// (add) Token: 0x0600026D RID: 621 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600026E RID: 622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400003D")]
		public event EventHandler<EventArgs<string>> CursorTypeChanged
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x5BC3870", Offset = "0x5BC2470", VA = "0x185BC3870", Slot = "99")]
			add
			{
			}
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x5BC3E70", Offset = "0x5BC2A70", VA = "0x185BC3E70", Slot = "100")]
			remove
			{
			}
		}

		// Token: 0x1400003E RID: 62
		// (add) Token: 0x0600026F RID: 623 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000270 RID: 624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400003E")]
		public event EventHandler<DownloadChangedEventArgs> DownloadProgressChanged
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x5BC3970", Offset = "0x5BC2570", VA = "0x185BC3970", Slot = "103")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x5BC3FA0", Offset = "0x5BC2BA0", VA = "0x185BC3FA0", Slot = "104")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400003F RID: 63
		// (add) Token: 0x06000271 RID: 625 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000272 RID: 626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400003F")]
		public event EventHandler<FileSelectionEventArgs> FileSelectionRequested
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x5BC3A20", Offset = "0x5BC2620", VA = "0x185BC3A20", Slot = "105")]
			add
			{
			}
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x5BC4050", Offset = "0x5BC2C50", VA = "0x185BC4050", Slot = "106")]
			remove
			{
			}
		}

		// Token: 0x14000040 RID: 64
		// (add) Token: 0x06000273 RID: 627 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000274 RID: 628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000040")]
		public event EventHandler<EventArgs<Vector2Int>> ImeInputFieldPositionChanged
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x5BC3B20", Offset = "0x5BC2720", VA = "0x185BC3B20", Slot = "107")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x5BC40F0", Offset = "0x5BC2CF0", VA = "0x185BC40F0", Slot = "108")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000041 RID: 65
		// (add) Token: 0x06000275 RID: 629 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000276 RID: 630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000041")]
		public event EventHandler<PopupRequestedEventArgs> PopupRequested
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x5BC3BD0", Offset = "0x5BC27D0", VA = "0x185BC3BD0", Slot = "125")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x5BC41A0", Offset = "0x5BC2DA0", VA = "0x185BC41A0", Slot = "126")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000277 RID: 631 RVA: 0x000024D8 File Offset: 0x000006D8
		// (set) Token: 0x06000278 RID: 632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003C")]
		public float PixelDensity
		{
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x5B8F070", Offset = "0x5B8DC70", VA = "0x185B8F070", Slot = "118")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x5B8F3D0", Offset = "0x5B8DFD0", VA = "0x185B8F3D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x5BBB930", Offset = "0x5BBA530", VA = "0x185BBB930", Slot = "109")]
		public void CancelImeComposition()
		{
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x5BA8530", Offset = "0x5BA7130", VA = "0x185BA8530", Slot = "31")]
		public override Task<bool> CanGoBack()
		{
			return null;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x5BA86D0", Offset = "0x5BA72D0", VA = "0x185BA86D0", Slot = "32")]
		public override Task<bool> CanGoForward()
		{
			return null;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x5BA8870", Offset = "0x5BA7470", VA = "0x185BA8870", Slot = "33")]
		public override Task<byte[]> CaptureScreenshot()
		{
			return null;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x5BBB9F0", Offset = "0x5BBA5F0", VA = "0x185BBB9F0")]
		public static void ClearAllData()
		{
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x5BBBAF0", Offset = "0x5BBA6F0", VA = "0x185BBBAF0", Slot = "36")]
		public override void Copy()
		{
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x5BBBBB0", Offset = "0x5BBA7B0", VA = "0x185BBBBB0", Slot = "117")]
		public Task<string> CreatePdf()
		{
			return null;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x5BBBBC0", Offset = "0x5BBA7C0", VA = "0x185BBBBC0")]
		public Task<string> CreatePdf(StandalonePdfOptions pdfOptions)
		{
			return null;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x5BBBDF0", Offset = "0x5BBA9F0", VA = "0x185BBBDF0", Slot = "38")]
		public override void Cut()
		{
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x5BBBEB0", Offset = "0x5BBAAB0", VA = "0x185BBBEB0")]
		public static Task<bool> DeleteAllCookies()
		{
			return null;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x5BBBF00", Offset = "0x5BBAB00", VA = "0x185BBBF00")]
		public static Task<bool> DeleteCookies(string url, [Optional] string cookieName)
		{
			return null;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x5BBC140", Offset = "0x5BBAD40", VA = "0x185BBC140")]
		public static void EnableRemoteDebugging(int portNumber)
		{
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x5BA8EF0", Offset = "0x5BA7AF0", VA = "0x185BA8EF0", Slot = "41")]
		public override void ExecuteJavaScript(string javaScript, Action<string> callback)
		{
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x5BBC4E0", Offset = "0x5BBB0E0", VA = "0x185BBC4E0", Slot = "110")]
		public void FinishImeComposition(string text)
		{
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x5BBC7D0", Offset = "0x5BBB3D0", VA = "0x185BBC7D0")]
		public static Task<Cookie[]> GetCookies(string url, [Optional] string cookieName)
		{
			return null;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x5BA9080", Offset = "0x5BA7C80", VA = "0x185BA9080", Slot = "42")]
		public override Task<byte[]> GetRawTextureData()
		{
			return null;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x5BBCB10", Offset = "0x5BBB710", VA = "0x185BBCB10")]
		public static void GloballySetUserAgent(string userAgent)
		{
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x5BBCBD0", Offset = "0x5BBB7D0", VA = "0x185BBCBD0")]
		public static void GloballySetUserAgent(bool mobile)
		{
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x5BA9140", Offset = "0x5BA7D40", VA = "0x185BA9140", Slot = "43")]
		public override void GoBack()
		{
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x5BA9200", Offset = "0x5BA7E00", VA = "0x185BA9200", Slot = "44")]
		public override void GoForward()
		{
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x5BBD750", Offset = "0x5BBC350", VA = "0x185BBD750", Slot = "130")]
		public Task Init(int width, int height)
		{
			return null;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x5BBD850", Offset = "0x5BBC450", VA = "0x185BBD850", Slot = "112")]
		public void KeyDown(string key, KeyModifier modifiers)
		{
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x5BBD950", Offset = "0x5BBC550", VA = "0x185BBD950", Slot = "113")]
		public void KeyUp(string key, KeyModifier modifiers)
		{
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x5BAAC80", Offset = "0x5BA9880", VA = "0x185BAAC80", Slot = "45")]
		public override void LoadHtml(string html)
		{
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x5BAAFD0", Offset = "0x5BA9BD0", VA = "0x185BAAFD0", Slot = "46")]
		public override void LoadUrl(string url)
		{
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x5BBDA50", Offset = "0x5BBC650", VA = "0x185BBDA50", Slot = "47")]
		public override void LoadUrl(string url, Dictionary<string, string> additionalHttpHeaders)
		{
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x5BBDC20", Offset = "0x5BBC820", VA = "0x185BBDC20", Slot = "114")]
		public void MovePointer(Vector2 normalizedPoint, bool pointerLeave = false)
		{
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x5BBDD30", Offset = "0x5BBC930", VA = "0x185BBDD30", Slot = "49")]
		public override void Paste()
		{
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x5BBDDF0", Offset = "0x5BBC9F0", VA = "0x185BBDDF0", Slot = "120")]
		public void PointerDown(Vector2 point)
		{
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x5BBDE20", Offset = "0x5BBCA20", VA = "0x185BBDE20", Slot = "121")]
		public void PointerDown(Vector2 point, PointerOptions options)
		{
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x5BBDF60", Offset = "0x5BBCB60", VA = "0x185BBDF60", Slot = "122")]
		public void PointerUp(Vector2 point)
		{
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x5BBDEC0", Offset = "0x5BBCAC0", VA = "0x185BBDEC0", Slot = "123")]
		public void PointerUp(Vector2 point, PointerOptions options)
		{
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x5BBDF80", Offset = "0x5BBCB80", VA = "0x185BBDF80", Slot = "57")]
		public override void SelectAll()
		{
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x5BBE040", Offset = "0x5BBCC40", VA = "0x185BBE040")]
		public void SendDevToolsMessage(string messageJson)
		{
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x5BBBFB0", Offset = "0x5BBABB0", VA = "0x185BBBFB0", Slot = "129")]
		public void SendTouchEvent(TouchEvent touchEvent)
		{
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x5BBE130", Offset = "0x5BBCD30", VA = "0x185BBE130")]
		public static void SetAcceleratedPaintEnabled(bool enabled)
		{
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x5BBE280", Offset = "0x5BBCE80", VA = "0x185BBE280", Slot = "115")]
		public void SetAudioMuted(bool muted)
		{
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x5BBE350", Offset = "0x5BBCF50", VA = "0x185BBE350")]
		public static void SetAutoplayEnabled(bool enabled)
		{
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x5BBE430", Offset = "0x5BBD030", VA = "0x185BBE430")]
		public static void SetCachePath(string absoluteFilePath)
		{
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x5BBE4C0", Offset = "0x5BBD0C0", VA = "0x185BBE4C0")]
		public new static void SetCameraAndMicrophoneEnabled(bool enabled)
		{
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x5BBE5A0", Offset = "0x5BBD1A0", VA = "0x185BBE5A0")]
		public static void SetChromiumLogLevel(ChromiumLogLevel level)
		{
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x5BBE680", Offset = "0x5BBD280", VA = "0x185BBE680")]
		public static void SetChromiumLogPath(string absoluteFilePath)
		{
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x5BBE780", Offset = "0x5BBD380", VA = "0x185BBE780")]
		public static void SetCommandLineArguments(string args)
		{
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x5BBE940", Offset = "0x5BBD540", VA = "0x185BBE940")]
		public static Task<bool> SetCookie(Cookie cookie)
		{
			return null;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x5BBEC50", Offset = "0x5BBD850", VA = "0x185BBEC50", Slot = "101")]
		public void SetDeepLinkingEnabled(bool enabled)
		{
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x5BBED20", Offset = "0x5BBD920", VA = "0x185BBED20", Slot = "102")]
		public void SetDownloadsEnabled(bool enabled)
		{
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x5BBEE90", Offset = "0x5BBDA90", VA = "0x185BBEE90")]
		public static void SetIgnoreCertificateErrors(bool ignore)
		{
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x5BBEF70", Offset = "0x5BBDB70", VA = "0x185BBEF70", Slot = "111")]
		public void SetImeComposition(string text)
		{
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x5BBF060", Offset = "0x5BBDC60", VA = "0x185BBF060")]
		public void SetNativeFileDialogEnabled(bool enabled)
		{
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x5BBF130", Offset = "0x5BBDD30", VA = "0x185BBF130", Slot = "116")]
		public void SetNativeJavaScriptDialogsEnabled(bool enabled)
		{
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x5BBF200", Offset = "0x5BBDE00", VA = "0x185BBF200", Slot = "119")]
		public void SetPixelDensity(float pixelDensity)
		{
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x5BBF2F0", Offset = "0x5BBDEF0", VA = "0x185BBF2F0", Slot = "124")]
		public void SetPopupMode(PopupMode popupMode)
		{
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x5BBF3C0", Offset = "0x5BBDFC0", VA = "0x185BBF3C0")]
		public static void SetScreenSharingEnabled(bool enabled)
		{
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x5BBF4A0", Offset = "0x5BBE0A0", VA = "0x185BBF4A0")]
		public static void SetStorageEnabled(bool enabled)
		{
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x5BBF580", Offset = "0x5BBE180", VA = "0x185BBF580")]
		public static void SetTargetFrameRate(uint targetFrameRate)
		{
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x5BBF660", Offset = "0x5BBE260", VA = "0x185BBF660", Slot = "128")]
		public void SetUserAgent(string userAgent)
		{
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x5BBF750", Offset = "0x5BBE350", VA = "0x185BBF750", Slot = "127")]
		public void SetUserAgent(bool mobile)
		{
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x5BBF820", Offset = "0x5BBE420", VA = "0x185BBF820")]
		public void SetZoomLevel(float zoomLevel)
		{
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x5BBF8F0", Offset = "0x5BBE4F0", VA = "0x185BBF8F0")]
		public static Task TerminateBrowserProcess()
		{
			return null;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x5BACDC0", Offset = "0x5BAB9C0", VA = "0x185BACDC0", Slot = "64")]
		public override void ZoomIn()
		{
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x5BACE80", Offset = "0x5BABA80", VA = "0x185BACE80", Slot = "65")]
		public override void ZoomOut()
		{
		}

		// Token: 0x14000042 RID: 66
		// (add) Token: 0x060002B6 RID: 694 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060002B7 RID: 695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000042")]
		private event EventHandler<EventArgs<string>> _cursorTypeChanged
		{
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x5BC3C80", Offset = "0x5BC2880", VA = "0x185BC3C80")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x5BC4250", Offset = "0x5BC2E50", VA = "0x185BC4250")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x5BC23A0", Offset = "0x5BC0FA0", VA = "0x185BC23A0")]
		private static Task<bool> _deleteCookies([Optional] string url, [Optional] string cookieName)
		{
			return null;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x5BC25C0", Offset = "0x5BC11C0", VA = "0x185BC25C0")]
		private static string _getCachePath()
		{
			return null;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x5BBCC80", Offset = "0x5BBB880", VA = "0x185BBCC80")]
		private void HandleAuthRequested(string host)
		{
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x5BBCE70", Offset = "0x5BBBA70", VA = "0x185BBCE70")]
		private void HandleClientCertificateRequested(string serializedMessage)
		{
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x5BBCF80", Offset = "0x5BBBB80", VA = "0x185BBCF80")]
		private void HandleCursorTypeChanged(string type)
		{
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x5BBD020", Offset = "0x5BBBC20", VA = "0x185BBD020")]
		private void HandleDownloadProgressChanged(string serializedMessage)
		{
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x5BBD080", Offset = "0x5BBBC80", VA = "0x185BBD080")]
		private void HandleFileSelectionRequested(string serializedMessage)
		{
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x5BC2690", Offset = "0x5BC1290", VA = "0x185BC2690")]
		[MonoPInvokeCallback(typeof(Action<string, string>))]
		private static void _handleGetCookiesResult(string resultCallbackId, string serializedCookies)
		{
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x5BBD220", Offset = "0x5BBBE20", VA = "0x185BBD220")]
		private void HandleImeInputFieldPositionChanged(string message)
		{
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x5BBD350", Offset = "0x5BBBF50", VA = "0x185BBD350")]
		private void HandlePdfCreated(string message)
		{
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x5BBD500", Offset = "0x5BBC100", VA = "0x185BBD500")]
		private void HandlePopup(string message)
		{
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x5BC27F0", Offset = "0x5BC13F0", VA = "0x185BC27F0")]
		[MonoPInvokeCallback(typeof(Action<string, bool>))]
		private static void _handleModifyCookiesResult(string resultCallbackId, bool success)
		{
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x5BC28D0", Offset = "0x5BC14D0", VA = "0x185BC28D0")]
		[MonoPInvokeCallback(typeof(Action))]
		private static void _handleTerminationFinished()
		{
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x5BC29A0", Offset = "0x5BC15A0", VA = "0x185BC29A0")]
		private Task _initPopup(int width, int height, float pixelDensity, string popupId)
		{
			return null;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x5BC2AD0", Offset = "0x5BC16D0", VA = "0x185BC2AD0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void _initializePlugin()
		{
		}

		// Token: 0x060002C7 RID: 711
		[Token(Token = "0x60002C7")]
		protected abstract StandaloneWebView _instantiate();

		// Token: 0x060002C8 RID: 712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x5BC2ED0", Offset = "0x5BC1AD0", VA = "0x185BC2ED0")]
		[MonoPInvokeCallback(typeof(Action<string>))]
		private static void _logInfo(string message)
		{
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x5BC2EE0", Offset = "0x5BC1AE0", VA = "0x185BC2EE0")]
		[MonoPInvokeCallback(typeof(Action<string>))]
		private static void _logWarning(string message)
		{
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x5BC2EC0", Offset = "0x5BC1AC0", VA = "0x185BC2EC0")]
		[MonoPInvokeCallback(typeof(Action<string>))]
		private static void _logError(string message)
		{
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x5BC3140", Offset = "0x5BC1D40", VA = "0x185BC3140", Slot = "75")]
		protected override void _resize()
		{
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x5BC3390", Offset = "0x5BC1F90", VA = "0x185BC3390")]
		private static void _throwAlreadyInitializedException(string methodName)
		{
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x5BC2EF0", Offset = "0x5BC1AF0", VA = "0x185BC2EF0")]
		private void _pointerDown(Vector2 normalizedPoint, MouseButton mouseButton, int clickCount, bool preventStealingFocus)
		{
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x5BC3020", Offset = "0x5BC1C20", VA = "0x185BC3020")]
		private void _pointerUp(Vector2 normalizedPoint, MouseButton mouseButton, int clickCount)
		{
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x5BC3240", Offset = "0x5BC1E40", VA = "0x185BC3240")]
		private static void _setCachePath(string cachePath, string methodName)
		{
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x5BC3560", Offset = "0x5BC2160", VA = "0x185BC3560")]
		[MonoPInvokeCallback(typeof(Action<string, string, string>))]
		private static void _unitySendMessage(string gameObjectName, string methodName, string message)
		{
		}

		// Token: 0x060002D1 RID: 721
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x5BBFF30", Offset = "0x5BBEB30", VA = "0x185BBFF30")]
		[PreserveSig]
		private static extern bool WebView_browserProcessIsRunning();

		// Token: 0x060002D2 RID: 722
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x5BBFFA0", Offset = "0x5BBEBA0", VA = "0x185BBFFA0")]
		[PreserveSig]
		private static extern void WebView_cancelAuth(IntPtr webViewPtr);

		// Token: 0x060002D3 RID: 723
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x5BC0020", Offset = "0x5BBEC20", VA = "0x185BC0020")]
		[PreserveSig]
		private static extern void WebView_cancelFileSelection(IntPtr webViewPtr);

		// Token: 0x060002D4 RID: 724
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x5BC00A0", Offset = "0x5BBECA0", VA = "0x185BC00A0")]
		[PreserveSig]
		private static extern void WebView_cancelImeComposition(IntPtr webViewPtr);

		// Token: 0x060002D5 RID: 725
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x5BC0120", Offset = "0x5BBED20", VA = "0x185BC0120")]
		[PreserveSig]
		private static extern void WebView_continueAuth(IntPtr webViewPtr, string username, string password);

		// Token: 0x060002D6 RID: 726
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x5BC01E0", Offset = "0x5BBEDE0", VA = "0x185BC01E0")]
		[PreserveSig]
		private static extern void WebView_continueFileSelection(IntPtr webViewPtr, string serializedFilePaths);

		// Token: 0x060002D7 RID: 727
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x5BC0280", Offset = "0x5BBEE80", VA = "0x185BC0280")]
		[PreserveSig]
		private static extern void WebView_copy(IntPtr webViewPtr);

		// Token: 0x060002D8 RID: 728
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x5BC0300", Offset = "0x5BBEF00", VA = "0x185BC0300")]
		[PreserveSig]
		private static extern void WebView_createPdf(IntPtr webViewPtr, string resultCallbackId, string filePath, string options);

		// Token: 0x060002D9 RID: 729
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x5BC03E0", Offset = "0x5BBEFE0", VA = "0x185BC03E0")]
		[PreserveSig]
		private static extern void WebView_cut(IntPtr webViewPtr);

		// Token: 0x060002DA RID: 730
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x5BC0460", Offset = "0x5BBF060", VA = "0x185BC0460")]
		[PreserveSig]
		private static extern void WebView_deleteCookies(string url, string cookieName, string resultCallbackId);

		// Token: 0x060002DB RID: 731
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x5BC0530", Offset = "0x5BBF130", VA = "0x185BC0530")]
		[PreserveSig]
		private static extern bool WebView_enableRemoteDebugging(int portNumber);

		// Token: 0x060002DC RID: 732
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x5BC05B0", Offset = "0x5BBF1B0", VA = "0x185BC05B0")]
		[PreserveSig]
		private static extern void WebView_finishImeComposition(IntPtr webViewPtr, string text);

		// Token: 0x060002DD RID: 733
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x5BC0650", Offset = "0x5BBF250", VA = "0x185BC0650")]
		[PreserveSig]
		private static extern void WebView_getCookies(string url, string cookieName, string resultCallbackId);

		// Token: 0x060002DE RID: 734
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x5BC07A0", Offset = "0x5BBF3A0", VA = "0x185BC07A0")]
		[PreserveSig]
		private static extern void WebView_globallySetUserAgent(string userAgent);

		// Token: 0x060002DF RID: 735
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x5BC0720", Offset = "0x5BBF320", VA = "0x185BC0720")]
		[PreserveSig]
		private static extern void WebView_globallySetUserAgentToMobile(bool mobile);

		// Token: 0x060002E0 RID: 736
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x5BC0830", Offset = "0x5BBF430", VA = "0x185BC0830")]
		[PreserveSig]
		private static extern void WebView_initializePlugin(IntPtr terminationFinishedCallback, IntPtr logInfoFunction, IntPtr logWarningFunction, IntPtr logErrorFunction, IntPtr unitySendMessageFunction, IntPtr getCookiesCallback, IntPtr modifyCookiesCallback);

		// Token: 0x060002E1 RID: 737
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x5BC0900", Offset = "0x5BBF500", VA = "0x185BC0900")]
		[PreserveSig]
		private static extern void WebView_keyDown(IntPtr webViewPtr, string key, int modifiers);

		// Token: 0x060002E2 RID: 738
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x5BC09B0", Offset = "0x5BBF5B0", VA = "0x185BC09B0")]
		[PreserveSig]
		private static extern void WebView_keyUp(IntPtr webViewPtr, string key, int modifiers);

		// Token: 0x060002E3 RID: 739
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x5BC0A60", Offset = "0x5BBF660", VA = "0x185BC0A60")]
		[PreserveSig]
		private static extern void WebView_movePointer(IntPtr webViewPtr, int x, int y, bool pointerLeave);

		// Token: 0x060002E4 RID: 740
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x5BC0B10", Offset = "0x5BBF710", VA = "0x185BC0B10")]
		[PreserveSig]
		private static extern IntPtr WebView_new(string gameObjectName, int width, int height, float pixelDensity, string popupBrowserId);

		// Token: 0x060002E5 RID: 741
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x5BC0C00", Offset = "0x5BBF800", VA = "0x185BC0C00")]
		[PreserveSig]
		private static extern void WebView_paste(IntPtr webViewPtr);

		// Token: 0x060002E6 RID: 742
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x5BC0C80", Offset = "0x5BBF880", VA = "0x185BC0C80")]
		[PreserveSig]
		private static extern void WebView_pointerDown(IntPtr webViewPtr, int x, int y, int mouseButton, int clickCount, bool preventStealingFocus);

		// Token: 0x060002E7 RID: 743
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x5BC0D40", Offset = "0x5BBF940", VA = "0x185BC0D40")]
		[PreserveSig]
		private static extern void WebView_pointerUp(IntPtr webViewPtr, int x, int y, int mouseButton, int clickCount);

		// Token: 0x060002E8 RID: 744
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x5BC0DF0", Offset = "0x5BBF9F0", VA = "0x185BC0DF0")]
		[PreserveSig]
		protected static extern void WebView_resizeWithPixelDensity(IntPtr webViewPtr, int width, int height, float pixelDensity);

		// Token: 0x060002E9 RID: 745
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x5BC0EA0", Offset = "0x5BBFAA0", VA = "0x185BC0EA0")]
		[PreserveSig]
		private static extern void WebView_selectAll(IntPtr webViewPtr);

		// Token: 0x060002EA RID: 746
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x5BC0F20", Offset = "0x5BBFB20", VA = "0x185BC0F20")]
		[PreserveSig]
		private static extern void WebView_selectClientCertificate(IntPtr webViewPtr, int certificateID);

		// Token: 0x060002EB RID: 747
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x5BC0FB0", Offset = "0x5BBFBB0", VA = "0x185BC0FB0")]
		[PreserveSig]
		private static extern void WebView_sendDevToolsMessage(IntPtr webViewPtr, string messageJson);

		// Token: 0x060002EC RID: 748
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x5BC1050", Offset = "0x5BBFC50", VA = "0x185BC1050")]
		[PreserveSig]
		private static extern void WebView_sendTouchEvent(IntPtr webViewPtr, int touchID, int type, float pointX, float pointY, float radiusX, float radiusY, float rotationAngle, float pressure);

		// Token: 0x060002ED RID: 749
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x5BC1150", Offset = "0x5BBFD50", VA = "0x185BC1150")]
		[PreserveSig]
		private static extern bool WebView_setAcceleratedPaintEnabled(bool enabled);

		// Token: 0x060002EE RID: 750
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x5BC11D0", Offset = "0x5BBFDD0", VA = "0x185BC11D0")]
		[PreserveSig]
		private static extern void WebView_setAudioMuted(IntPtr webViewPtr, bool muted);

		// Token: 0x060002EF RID: 751
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x5BC1260", Offset = "0x5BBFE60", VA = "0x185BC1260")]
		[PreserveSig]
		private static extern void WebView_setAuthEnabled(IntPtr webViewPtr, bool enabled);

		// Token: 0x060002F0 RID: 752
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x5BC12F0", Offset = "0x5BBFEF0", VA = "0x185BC12F0")]
		[PreserveSig]
		private static extern bool WebView_setAutoplayEnabled(bool enabled);

		// Token: 0x060002F1 RID: 753
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x5BC1370", Offset = "0x5BBFF70", VA = "0x185BC1370")]
		[PreserveSig]
		private static extern bool WebView_setCachePath(string cachePath);

		// Token: 0x060002F2 RID: 754
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x5BC1410", Offset = "0x5BC0010", VA = "0x185BC1410")]
		[PreserveSig]
		private static extern bool WebView_setCameraAndMicrophoneEnabled(bool enabled);

		// Token: 0x060002F3 RID: 755
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x5BC1490", Offset = "0x5BC0090", VA = "0x185BC1490")]
		[PreserveSig]
		private static extern bool WebView_setChromiumLogLevel(int level);

		// Token: 0x060002F4 RID: 756
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x5BC1510", Offset = "0x5BC0110", VA = "0x185BC1510")]
		[PreserveSig]
		private static extern bool WebView_setChromiumLogPath(string logPath);

		// Token: 0x060002F5 RID: 757
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x5BC15B0", Offset = "0x5BC01B0", VA = "0x185BC15B0")]
		[PreserveSig]
		private static extern void WebView_setClientCertificateSelectionEnabled(IntPtr webViewPtr, bool enabled);

		// Token: 0x060002F6 RID: 758
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x5BC1640", Offset = "0x5BC0240", VA = "0x185BC1640")]
		[PreserveSig]
		private static extern bool WebView_setCommandLineArguments(string args);

		// Token: 0x060002F7 RID: 759
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x5BC16E0", Offset = "0x5BC02E0", VA = "0x185BC16E0")]
		[PreserveSig]
		private static extern void WebView_setCookie(string serializedCookie, string resultCallbackId);

		// Token: 0x060002F8 RID: 760
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x5BC1790", Offset = "0x5BC0390", VA = "0x185BC1790")]
		[PreserveSig]
		private static extern void WebView_setCursorTypeEventsEnabled(IntPtr webViewPtr, bool enabled);

		// Token: 0x060002F9 RID: 761
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x5BC1820", Offset = "0x5BC0420", VA = "0x185BC1820")]
		[PreserveSig]
		private static extern void WebView_setDeepLinkingEnabled(IntPtr webViewPtr, bool enabled);

		// Token: 0x060002FA RID: 762
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x5BC18B0", Offset = "0x5BC04B0", VA = "0x185BC18B0")]
		[PreserveSig]
		private static extern void WebView_setDownloadsEnabled(IntPtr webViewPtr, string downloadsDirectoryPath);

		// Token: 0x060002FB RID: 763
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x5BC1950", Offset = "0x5BC0550", VA = "0x185BC1950")]
		[PreserveSig]
		private static extern void WebView_setFileSelectionEnabled(IntPtr webViewPtr, bool enabled);

		// Token: 0x060002FC RID: 764
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x5BC19E0", Offset = "0x5BC05E0", VA = "0x185BC19E0")]
		[PreserveSig]
		private static extern bool WebView_setIgnoreCertificateErrors(bool ignore);

		// Token: 0x060002FD RID: 765
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x5BC1A60", Offset = "0x5BC0660", VA = "0x185BC1A60")]
		[PreserveSig]
		private static extern void WebView_setImeComposition(IntPtr webViewPtr, string text);

		// Token: 0x060002FE RID: 766
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x5BC1B00", Offset = "0x5BC0700", VA = "0x185BC1B00")]
		[PreserveSig]
		private static extern void WebView_setNativeFileDialogEnabled(IntPtr webViewPtr, bool enabled);

		// Token: 0x060002FF RID: 767
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x5BC1B90", Offset = "0x5BC0790", VA = "0x185BC1B90")]
		[PreserveSig]
		private static extern void WebView_setNativeJavaScriptDialogsEnabled(IntPtr webViewPtr, bool enabled);

		// Token: 0x06000300 RID: 768
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x5BC1C20", Offset = "0x5BC0820", VA = "0x185BC1C20")]
		[PreserveSig]
		private static extern void WebView_setPopupMode(IntPtr webViewPtr, int popupMode);

		// Token: 0x06000301 RID: 769
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x5BC1CB0", Offset = "0x5BC08B0", VA = "0x185BC1CB0")]
		[PreserveSig]
		private static extern bool WebView_setScreenSharingEnabled(bool enabled);

		// Token: 0x06000302 RID: 770
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x5BC1D30", Offset = "0x5BC0930", VA = "0x185BC1D30")]
		[PreserveSig]
		private static extern bool WebView_setStorageEnabled(bool enabled);

		// Token: 0x06000303 RID: 771
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x5BC1DB0", Offset = "0x5BC09B0", VA = "0x185BC1DB0")]
		[PreserveSig]
		private static extern bool WebView_setTargetFrameRate(uint targetFrameRate);

		// Token: 0x06000304 RID: 772
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x5BC1EC0", Offset = "0x5BC0AC0", VA = "0x185BC1EC0")]
		[PreserveSig]
		private static extern void WebView_setUserAgent(IntPtr webViewPtr, string userAgent);

		// Token: 0x06000305 RID: 773
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x5BC1E30", Offset = "0x5BC0A30", VA = "0x185BC1E30")]
		[PreserveSig]
		private static extern void WebView_setUserAgentToMobile(IntPtr webViewPtr, bool mobile);

		// Token: 0x06000306 RID: 774
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x5BC1F60", Offset = "0x5BC0B60", VA = "0x185BC1F60")]
		[PreserveSig]
		private static extern void WebView_setZoomLevel(IntPtr webViewPtr, float zoomLevel);

		// Token: 0x06000307 RID: 775
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x5BC1FF0", Offset = "0x5BC0BF0", VA = "0x185BC1FF0")]
		[PreserveSig]
		private static extern bool WebView_terminateBrowserProcess();

		// Token: 0x06000308 RID: 776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x5BBBFB0", Offset = "0x5BBABB0", VA = "0x185BBBFB0")]
		[Obsolete("StandaloneWebView.DispatchTouchEvent() has been renamed to SendTouchEvent(). Please switch to using IWithTouch.SendTouchEvent(): https://developer.vuplex.com/webview/IWithTouch")]
		public void DispatchTouchEvent(TouchEvent touchEvent)
		{
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x5BBC5D0", Offset = "0x5BBB1D0", VA = "0x185BBC5D0")]
		[Obsolete("StandaloneWebView.GetCookie() is now deprecated. Please switch to using Web.CookieManager.GetCookies(): https://developer.vuplex.com/webview/CookieManager#GetCookies")]
		public static void GetCookie(string url, string cookieName, Action<Cookie> callback)
		{
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x5BBC6C0", Offset = "0x5BBB2C0", VA = "0x185BBC6C0")]
		[Obsolete("StandaloneWebView.GetCookie() is now deprecated. Please switch to Web.CookieManager.GetCookies(): https://developer.vuplex.com/webview/CookieManager#GetCookies")]
		public static Task<Cookie> GetCookie(string url, string cookieName)
		{
			return null;
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x5BBCA50", Offset = "0x5BBB650", VA = "0x185BBCA50")]
		[Obsolete("StandaloneWebView.GetCookies(url, callback) is now deprecated. Please switch to Web.CookieManager.GetCookies(): https://developer.vuplex.com/webview/CookieManager#GetCookies")]
		public static void GetCookies(string url, Action<Cookie[]> callback)
		{
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x5BBE230", Offset = "0x5BBCE30", VA = "0x185BBE230")]
		[Obsolete("StandaloneWebView.SetAudioAndVideoCaptureEnabled() is now deprecated. Please switch to Web.SetCameraAndMicrophoneEnabled(): https://developer.vuplex.com/webview/Web#SetCameraAndMicrophoneEnabled")]
		public static void SetAudioAndVideoCaptureEnabled(bool enabled)
		{
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x5BBE880", Offset = "0x5BBD480", VA = "0x185BBE880")]
		[Obsolete("StandaloneWebView.SetCookie(cookie, callback) is now deprecated. Please switch to Web.CookieManager.SetCookie(): https://developer.vuplex.com/webview/CookieManager#SetCookie")]
		public static void SetCookie(Cookie cookie, Action<bool> callback)
		{
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x5BBF130", Offset = "0x5BBDD30", VA = "0x185BBF130")]
		[Obsolete("StandaloneWebView.SetNativeScriptDialogEnabled() is now deprecated. Please switch to IWithNativeJavaScriptDialogs.SetNativeJavaScriptDialogsEnabled(): https://developer.vuplex.com/webview/IWithNativeJavaScriptDialogs")]
		public void SetNativeScriptDialogEnabled(bool enabled)
		{
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x5BBFAE0", Offset = "0x5BBE6E0", VA = "0x185BBFAE0")]
		[Obsolete("StandaloneWebView.TerminatePlugin() has been replaced with StandaloneWebView.TerminateBrowserProcess(). Please switch to TerminateBrowserProcess().")]
		public static void TerminatePlugin()
		{
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x5BC2170", Offset = "0x5BC0D70", VA = "0x185BC2170")]
		protected StandaloneWebView()
		{
		}

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static bool _acceleratedPaintEnabled;

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private EventHandler<AuthRequestedEventArgs> _authRequestedHandler;

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string _cachePathOverride;

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private EventHandler<StandaloneClientCertificateRequestedEventArgs> _clientCertificateRequestedHandler;

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private EventHandler<FileSelectionEventArgs> _fileSelectionHandler;

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Dictionary<string, TaskCompletionSource<string>> _pendingCreatePdfTaskSources;

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Dictionary<string, Action<Cookie[]>> _pendingGetCookiesResultCallbacks;

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Dictionary<string, Action<bool>> _pendingModifyCookiesResultCallbacks;

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		private const string WEBVIEW_DATA_SUBDIRECTORY_NAME = "Vuplex.WebView";

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static TaskCompletionSource<bool> _terminationTaskSource;
	}
}
