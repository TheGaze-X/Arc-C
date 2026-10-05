using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace Vuplex.WebView
{
	// Token: 0x0200003B RID: 59
	[Token(Token = "0x200003B")]
	internal class MockWebView : MonoBehaviour, IWebView
	{
		// Token: 0x1400002F RID: 47
		// (add) Token: 0x06000195 RID: 405 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000196 RID: 406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400002F")]
		public event EventHandler CloseRequested
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x5BB92D0", Offset = "0x5BB7ED0", VA = "0x185BB92D0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x5BB9B10", Offset = "0x5BB8710", VA = "0x185BB9B10", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000030 RID: 48
		// (add) Token: 0x06000197 RID: 407 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000198 RID: 408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000030")]
		public event EventHandler<ConsoleMessageEventArgs> ConsoleMessageLogged
		{
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x5BB9370", Offset = "0x5BB7F70", VA = "0x185BB9370", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x5BB9BB0", Offset = "0x5BB87B0", VA = "0x185BB9BB0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000031 RID: 49
		// (add) Token: 0x06000199 RID: 409 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600019A RID: 410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000031")]
		public event EventHandler<EventArgs<bool>> FocusChanged
		{
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x5BB9420", Offset = "0x5BB8020", VA = "0x185BB9420", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x5BB9C60", Offset = "0x5BB8860", VA = "0x185BB9C60", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000032 RID: 50
		// (add) Token: 0x0600019B RID: 411 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600019C RID: 412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000032")]
		public event EventHandler<FocusedInputFieldChangedEventArgs> FocusedInputFieldChanged
		{
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x5BB94D0", Offset = "0x5BB80D0", VA = "0x185BB94D0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x5BB9D10", Offset = "0x5BB8910", VA = "0x185BB9D10", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000033 RID: 51
		// (add) Token: 0x0600019D RID: 413 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600019E RID: 414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000033")]
		public event EventHandler<LoadFailedEventArgs> LoadFailed
		{
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x5BB9580", Offset = "0x5BB8180", VA = "0x185BB9580", Slot = "12")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x5BB9DC0", Offset = "0x5BB89C0", VA = "0x185BB9DC0", Slot = "13")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000034 RID: 52
		// (add) Token: 0x0600019F RID: 415 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060001A0 RID: 416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000034")]
		public event EventHandler<ProgressChangedEventArgs> LoadProgressChanged
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x5BB9630", Offset = "0x5BB8230", VA = "0x185BB9630", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x5BB9E70", Offset = "0x5BB8A70", VA = "0x185BB9E70", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000035 RID: 53
		// (add) Token: 0x060001A1 RID: 417 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060001A2 RID: 418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000035")]
		public event EventHandler<EventArgs<string>> MessageEmitted
		{
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x5BB96E0", Offset = "0x5BB82E0", VA = "0x185BB96E0", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x5BB9F20", Offset = "0x5BB8B20", VA = "0x185BB9F20", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000036 RID: 54
		// (add) Token: 0x060001A3 RID: 419 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060001A4 RID: 420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000036")]
		public event EventHandler<TerminatedEventArgs> Terminated
		{
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x5BB9830", Offset = "0x5BB8430", VA = "0x185BB9830", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x5BBA070", Offset = "0x5BB8C70", VA = "0x185BBA070", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000037 RID: 55
		// (add) Token: 0x060001A5 RID: 421 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060001A6 RID: 422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000037")]
		public event EventHandler<EventArgs<string>> TitleChanged
		{
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x5BB98E0", Offset = "0x5BB84E0", VA = "0x185BB98E0", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x5BBA120", Offset = "0x5BB8D20", VA = "0x185BBA120", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000038 RID: 56
		// (add) Token: 0x060001A7 RID: 423 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060001A8 RID: 424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000038")]
		public event EventHandler<UrlChangedEventArgs> UrlChanged
		{
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x5BB9990", Offset = "0x5BB8590", VA = "0x185BB9990", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x5BBA1D0", Offset = "0x5BB8DD0", VA = "0x185BBA1D0", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00002358 File Offset: 0x00000558
		// (set) Token: 0x060001AA RID: 426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002B")]
		public bool IsDisposed
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0xE31BB0", Offset = "0xE307B0", VA = "0x180E31BB0", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x4BA2FE0", Offset = "0x4BA1BE0", VA = "0x184BA2FE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00002370 File Offset: 0x00000570
		// (set) Token: 0x060001AC RID: 428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002C")]
		public bool IsInitialized
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0xE31BA0", Offset = "0xE307A0", VA = "0x180E31BA0", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x4E196D0", Offset = "0x4E182D0", VA = "0x184E196D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700002D")]
		public List<string> PageLoadScripts
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0xEB4B70", Offset = "0xEB3770", VA = "0x180EB4B70", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x1700002E")]
		public WebPluginType PluginType
		{
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x1820C10", Offset = "0x181F810", VA = "0x181820C10", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return WebPluginType.Android;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060001AF RID: 431 RVA: 0x000023A0 File Offset: 0x000005A0
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002F")]
		public Vector2Int Size
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x5BA3590", Offset = "0x5BA2190", VA = "0x185BA3590", Slot = "28")]
			[CompilerGenerated]
			get
			{
				return default(Vector2Int);
			}
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x5BBA330", Offset = "0x5BB8F30", VA = "0x185BBA330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000030")]
		public Texture2D Texture
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0xEB4B60", Offset = "0xEB3760", VA = "0x180EB4B60", Slot = "29")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x168B8E0", Offset = "0x168A4E0", VA = "0x18168B8E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000031")]
		public string Title
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x789270", Offset = "0x787E70", VA = "0x180789270", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x1FC11F0", Offset = "0x1FBFDF0", VA = "0x181FC11F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000032")]
		public string Url
		{
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0xF93800", Offset = "0xF92400", VA = "0x180F93800", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0xF93850", Offset = "0xF92450", VA = "0x180F93850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x5BB64E0", Offset = "0x5BB50E0", VA = "0x185BB64E0", Slot = "32")]
		public Task<bool> CanGoBack()
		{
			return null;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x5BB6590", Offset = "0x5BB5190", VA = "0x185BB6590", Slot = "33")]
		public Task<bool> CanGoForward()
		{
			return null;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x5BB6640", Offset = "0x5BB5240", VA = "0x185BB6640", Slot = "34")]
		public Task<byte[]> CaptureScreenshot()
		{
			return null;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x5BB6830", Offset = "0x5BB5430", VA = "0x185BB6830", Slot = "35")]
		public void Click(int xInPixels, int yInPixels, bool preventStealingFocus = false)
		{
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x5BB6710", Offset = "0x5BB5310", VA = "0x185BB6710", Slot = "36")]
		public void Click(Vector2 point, bool preventStealingFocus = false)
		{
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x5BB6B20", Offset = "0x5BB5720", VA = "0x185BB6B20", Slot = "37")]
		public void Copy()
		{
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x5BB6B90", Offset = "0x5BB5790", VA = "0x185BB6B90", Slot = "38")]
		public Material CreateMaterial()
		{
			return null;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x5BB6D60", Offset = "0x5BB5960", VA = "0x185BB6D60", Slot = "39")]
		public void Cut()
		{
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x5BB6DD0", Offset = "0x5BB59D0", VA = "0x185BB6DD0")]
		public static Task<bool> DeleteCookies(string url, [Optional] string cookieName)
		{
			return null;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x5BB70C0", Offset = "0x5BB5CC0", VA = "0x185BB70C0", Slot = "40")]
		public void Dispose()
		{
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x5BB72C0", Offset = "0x5BB5EC0", VA = "0x185BB72C0", Slot = "41")]
		public Task<string> ExecuteJavaScript(string javaScript)
		{
			return null;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x5BB71A0", Offset = "0x5BB5DA0", VA = "0x185BB71A0", Slot = "42")]
		public void ExecuteJavaScript(string javaScript, Action<string> callback)
		{
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x5BB7480", Offset = "0x5BB6080", VA = "0x185BB7480")]
		public static Task<Cookie[]> GetCookies(string url, [Optional] string cookieName)
		{
			return null;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x5BB77D0", Offset = "0x5BB63D0", VA = "0x185BB77D0", Slot = "43")]
		public Task<byte[]> GetRawTextureData()
		{
			return null;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x5BB78A0", Offset = "0x5BB64A0", VA = "0x185BB78A0", Slot = "44")]
		public void GoBack()
		{
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x5BB7910", Offset = "0x5BB6510", VA = "0x185BB7910", Slot = "45")]
		public void GoForward()
		{
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x5BB7A10", Offset = "0x5BB6610", VA = "0x185BB7A10", Slot = "46")]
		public Task Init(int width, int height)
		{
			return null;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x5BB6250", Offset = "0x5BB4E50", VA = "0x185BB6250")]
		public static MockWebView Instantiate()
		{
			return null;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x5BB7BF0", Offset = "0x5BB67F0", VA = "0x185BB7BF0", Slot = "87")]
		public virtual void LoadHtml(string html)
		{
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x5BB7D10", Offset = "0x5BB6910", VA = "0x185BB7D10", Slot = "88")]
		public virtual void LoadUrl(string url)
		{
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x5BB7D60", Offset = "0x5BB6960", VA = "0x185BB7D60", Slot = "89")]
		public virtual void LoadUrl(string url, Dictionary<string, string> additionalHttpHeaders)
		{
		}

		// Token: 0x060001CC RID: 460 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x5BB7E30", Offset = "0x5BB6A30", VA = "0x185BB7E30", Slot = "50")]
		public Vector2Int NormalizedToPoint(Vector2 normalizedPoint)
		{
			return default(Vector2Int);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x5BB7ED0", Offset = "0x5BB6AD0", VA = "0x185BB7ED0", Slot = "51")]
		public void Paste()
		{
		}

		// Token: 0x060001CE RID: 462 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x5BB7F40", Offset = "0x5BB6B40", VA = "0x185BB7F40", Slot = "52")]
		public Vector2 PointToNormalized(int xInPixels, int yInPixels)
		{
			return default(Vector2);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x5BB7F80", Offset = "0x5BB6B80", VA = "0x185BB7F80", Slot = "53")]
		public void PostMessage(string data)
		{
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x5BB8010", Offset = "0x5BB6C10", VA = "0x185BB8010", Slot = "54")]
		public void Reload()
		{
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x5BB8080", Offset = "0x5BB6C80", VA = "0x185BB8080", Slot = "55")]
		public void Resize(int width, int height)
		{
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x5BB8330", Offset = "0x5BB6F30", VA = "0x185BB8330", Slot = "56")]
		public void Scroll(int scrollDeltaX, int scrollDeltaY)
		{
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x5BB86C0", Offset = "0x5BB72C0", VA = "0x185BB86C0", Slot = "57")]
		public void Scroll(Vector2 delta)
		{
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x5BB8400", Offset = "0x5BB7000", VA = "0x185BB8400", Slot = "58")]
		public void Scroll(Vector2 delta, Vector2 point)
		{
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x5BB8770", Offset = "0x5BB7370", VA = "0x185BB8770", Slot = "59")]
		public void SelectAll()
		{
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x5BB7980", Offset = "0x5BB6580", VA = "0x185BB7980", Slot = "60")]
		public void SendKey(string input)
		{
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x5BB87E0", Offset = "0x5BB73E0", VA = "0x185BB87E0")]
		public static Task<bool> SetCookie(Cookie cookie)
		{
			return null;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x5BB89A0", Offset = "0x5BB75A0", VA = "0x185BB89A0", Slot = "61")]
		public void SetDefaultBackgroundEnabled(bool enabled)
		{
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x5BB8A40", Offset = "0x5BB7640", VA = "0x185BB8A40", Slot = "62")]
		public void SetFocused(bool focused)
		{
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x5BB8B60", Offset = "0x5BB7760", VA = "0x185BB8B60", Slot = "63")]
		public void SetRenderingEnabled(bool enabled)
		{
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x5BB8C00", Offset = "0x5BB7800", VA = "0x185BB8C00", Slot = "64")]
		public void StopLoad()
		{
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x5BB8C70", Offset = "0x5BB7870", VA = "0x185BB8C70", Slot = "65")]
		public Task WaitForNextPageLoadToFinish()
		{
			return null;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x5BB8D20", Offset = "0x5BB7920", VA = "0x185BB8D20", Slot = "66")]
		public void ZoomIn()
		{
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x5BB8D90", Offset = "0x5BB7990", VA = "0x185BB8D90", Slot = "67")]
		public void ZoomOut()
		{
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x5BB8E00", Offset = "0x5BB7A00", VA = "0x185BB8E00")]
		private void _assertValidNormalizedPoint(Vector2 normalizedPoint)
		{
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x5BB9010", Offset = "0x5BB7C10", VA = "0x185BB9010")]
		private void _handlePageLoad(string url)
		{
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x5BB9210", Offset = "0x5BB7E10", VA = "0x185BB9210")]
		private static void _log(string message)
		{
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x5BB9260", Offset = "0x5BB7E60", VA = "0x185BB9260")]
		private string _truncateIfNeeded(string str)
		{
			return null;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "68")]
		[Obsolete("IWebView.Blur() has been removed. Please use SetFocused(false) instead: https://developer.vuplex.com/webview/IWebView#SetFocused", true)]
		public void Blur()
		{
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "69")]
		[Obsolete("The callback-based CanGoBack(Action) version of this method has been removed. Please switch to the Task-based CanGoBack() version instead. If you prefer using a callback instead of awaiting the Task, you can still use a callback like this: CanGoBack().ContinueWith(result => {...})", true)]
		public void CanGoBack(Action<bool> callback)
		{
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "70")]
		[Obsolete("The callback-based CanGoForward(Action) version of this method has been removed. Please switch to the Task-based CanGoForward() version instead. If you prefer using a callback instead of awaiting the Task, you can still use a callback like this: CanGoForward().ContinueWith(result => {...})", true)]
		public void CanGoForward(Action<bool> callback)
		{
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "71")]
		[Obsolete("The callback-based CaptureScreenshot(Action) version of this method has been removed. Please switch to the Task-based CaptureScreenshot() version instead. If you prefer using a callback instead of awaiting the Task, you can still use a callback like this: CaptureScreenshot().ContinueWith(result => {...})", true)]
		public void CaptureScreenshot(Action<byte[]> callback)
		{
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "72")]
		[Obsolete("DisableViewUpdates() has been removed. Please use SetRenderingEnabled(false) instead: https://developer.vuplex.com/webview/IWebView#SetRenderingEnabled", true)]
		public void DisableViewUpdates()
		{
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "73")]
		[Obsolete("EnableViewUpdates() has been removed. Please use SetRenderingEnabled(true) instead: https://developer.vuplex.com/webview/IWebView#SetRenderingEnabled", true)]
		public void EnableViewUpdates()
		{
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "74")]
		[Obsolete("IWebView.Focus() has been removed. Please use SetFocused(false) instead: https://developer.vuplex.com/webview/IWebView#SetFocused", true)]
		public void Focus()
		{
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "75")]
		[Obsolete("The callback-based GetRawTextureData(Action) version of this method has been removed. Please switch to the Task-based GetRawTextureData() version instead. If you prefer using a callback instead of awaiting the Task, you can still use a callback like this: GetRawTextureData().ContinueWith(result => {...})", true)]
		public void GetRawTextureData(Action<byte[]> callback)
		{
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x5BB7980", Offset = "0x5BB6580", VA = "0x185BB7980", Slot = "76")]
		[Obsolete("IWebView.HandleKeyboardInput() has been renamed to IWebView.SendKey(). Please switch to SendKey().")]
		public void HandleKeyboardInput(string key)
		{
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "77")]
		[Obsolete("IWebView.Init(Texture2D, float, float) has been removed in v4. Please switch to IWebView.Init(int, int) and await the Task it returns. For more details, please see this article: https://support.vuplex.com/articles/v4-changes#init", true)]
		public void Init(Texture2D texture, float width, float height)
		{
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "78")]
		[Obsolete("IWebView.Init(Texture2D, float, float, Texture2D) has been removed in v4. Please switch to IWebView.Init(int, int) and await the Task it returns. For more details, please see this article: https://support.vuplex.com/articles/v4-changes#init", true)]
		public void Init(Texture2D texture, float width, float height, Texture2D videoTexture)
		{
		}

		// Token: 0x14000039 RID: 57
		// (add) Token: 0x060001EE RID: 494 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060001EF RID: 495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000039")]
		[Obsolete("IWebView.PageLoadFailed is now deprecated. Please use IWebView.LoadFailed instead: https://developer.vuplex.com/webview/IWebView#LoadFailed")]
		public event EventHandler PageLoadFailed
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x5BB9790", Offset = "0x5BB8390", VA = "0x185BB9790", Slot = "79")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x5BB9FD0", Offset = "0x5BB8BD0", VA = "0x185BB9FD0", Slot = "80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x17000033")]
		[Obsolete("IWebView.Resolution has been removed in v4. Please use WebViewPrefab.Resolution or CanvasWebViewPrefab.Resolution instead. For more details, please see this article: https://support.vuplex.com/articles/v4-changes#resolution", true)]
		public float Resolution
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x27289B0", Offset = "0x27275B0", VA = "0x1827289B0", Slot = "81")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "82")]
		[Obsolete("IWebView.SetResolution() has been removed in v4. Please set the WebViewPrefab.Resolution or CanvasWebViewPrefab.Resolution property instead. For more details, please see this article: https://support.vuplex.com/articles/v4-changes#resolution", true)]
		public void SetResolution(float pixelsPerUnityUnit)
		{
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x17000034")]
		[Obsolete("IWebView.SizeInPixels is now deprecated. Please use IWebView.Size instead: https://developer.vuplex.com/webview/IWebView#Size")]
		public Vector2 SizeInPixels
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x5BB9AF0", Offset = "0x5BB86F0", VA = "0x185BB9AF0", Slot = "83")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1400003A RID: 58
		// (add) Token: 0x060001F3 RID: 499 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060001F4 RID: 500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400003A")]
		[Obsolete("IWebView.VideoRectChanged has been removed. Please use IWithFallbackVideo.VideoRectChanged instead: https://developer.vuplex.com/webview/IWithFallbackVideo#VideoRectChanged", true)]
		public event EventHandler<EventArgs<Rect>> VideoRectChanged
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x5BB9A40", Offset = "0x5BB8640", VA = "0x185BB9A40", Slot = "84")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x5BBA280", Offset = "0x5BB8E80", VA = "0x185BBA280", Slot = "85")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000035")]
		[Obsolete("IWebView.VideoTexture has been removed. Please use IWithFallbackVideo.VideoTexture instead: https://developer.vuplex.com/webview/IWithFallbackVideo#VideoTexture", true)]
		public Texture2D VideoTexture
		{
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0xF0A850", Offset = "0xF09450", VA = "0x180F0A850", Slot = "86")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x5BB8EF0", Offset = "0x5BB7AF0", VA = "0x185BB8EF0")]
		public MockWebView()
		{
		}

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Rect _moreDetailsClickRect;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private TaskCompletionSource<bool> _pageLoadFinishedTaskSource;
	}
}
