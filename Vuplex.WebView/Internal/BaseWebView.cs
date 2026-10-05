using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Vuplex.WebView.Internal
{
	// Token: 0x02000073 RID: 115
	[Token(Token = "0x2000073")]
	public abstract class BaseWebView : MonoBehaviour
	{
		// Token: 0x14000043 RID: 67
		// (add) Token: 0x06000341 RID: 833 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000342 RID: 834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000043")]
		public event EventHandler CloseRequested
		{
			[Token(Token = "0x6000341")]
			[Address(RVA = "0x5BAF1A0", Offset = "0x5BADDA0", VA = "0x185BAF1A0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000342")]
			[Address(RVA = "0x5BAFC80", Offset = "0x5BAE880", VA = "0x185BAFC80", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000044 RID: 68
		// (add) Token: 0x06000343 RID: 835 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000344 RID: 836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000044")]
		public event EventHandler<ConsoleMessageEventArgs> ConsoleMessageLogged
		{
			[Token(Token = "0x6000343")]
			[Address(RVA = "0x5BAF240", Offset = "0x5BADE40", VA = "0x185BAF240", Slot = "6")]
			add
			{
			}
			[Token(Token = "0x6000344")]
			[Address(RVA = "0x5BAFD20", Offset = "0x5BAE920", VA = "0x185BAFD20", Slot = "7")]
			remove
			{
			}
		}

		// Token: 0x14000045 RID: 69
		// (add) Token: 0x06000345 RID: 837 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000346 RID: 838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000045")]
		public event EventHandler<EventArgs<bool>> FocusChanged
		{
			[Token(Token = "0x6000345")]
			[Address(RVA = "0x5BAF380", Offset = "0x5BADF80", VA = "0x185BAF380", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000346")]
			[Address(RVA = "0x5BAFE20", Offset = "0x5BAEA20", VA = "0x185BAFE20", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000046 RID: 70
		// (add) Token: 0x06000347 RID: 839 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000348 RID: 840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000046")]
		public event EventHandler<FocusedInputFieldChangedEventArgs> FocusedInputFieldChanged
		{
			[Token(Token = "0x6000347")]
			[Address(RVA = "0x5BAF430", Offset = "0x5BAE030", VA = "0x185BAF430", Slot = "10")]
			add
			{
			}
			[Token(Token = "0x6000348")]
			[Address(RVA = "0x5BAFED0", Offset = "0x5BAEAD0", VA = "0x185BAFED0", Slot = "11")]
			remove
			{
			}
		}

		// Token: 0x14000047 RID: 71
		// (add) Token: 0x06000349 RID: 841 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600034A RID: 842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000047")]
		public event EventHandler<LoadFailedEventArgs> LoadFailed
		{
			[Token(Token = "0x6000349")]
			[Address(RVA = "0x5BAF570", Offset = "0x5BAE170", VA = "0x185BAF570", Slot = "12")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600034A")]
			[Address(RVA = "0x5BAFFD0", Offset = "0x5BAEBD0", VA = "0x185BAFFD0", Slot = "13")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000048 RID: 72
		// (add) Token: 0x0600034B RID: 843 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600034C RID: 844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000048")]
		public event EventHandler<ProgressChangedEventArgs> LoadProgressChanged
		{
			[Token(Token = "0x600034B")]
			[Address(RVA = "0x5BAF620", Offset = "0x5BAE220", VA = "0x185BAF620", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600034C")]
			[Address(RVA = "0x5BB0080", Offset = "0x5BAEC80", VA = "0x185BB0080", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000049 RID: 73
		// (add) Token: 0x0600034D RID: 845 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600034E RID: 846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000049")]
		public event EventHandler<EventArgs<string>> MessageEmitted
		{
			[Token(Token = "0x600034D")]
			[Address(RVA = "0x5BAF6D0", Offset = "0x5BAE2D0", VA = "0x185BAF6D0", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600034E")]
			[Address(RVA = "0x5BB0130", Offset = "0x5BAED30", VA = "0x185BB0130", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400004A RID: 74
		// (add) Token: 0x0600034F RID: 847 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000350 RID: 848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400004A")]
		public event EventHandler<TerminatedEventArgs> Terminated
		{
			[Token(Token = "0x600034F")]
			[Address(RVA = "0x5BAF910", Offset = "0x5BAE510", VA = "0x185BAF910", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000350")]
			[Address(RVA = "0x5BB0330", Offset = "0x5BAEF30", VA = "0x185BB0330", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400004B RID: 75
		// (add) Token: 0x06000351 RID: 849 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000352 RID: 850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400004B")]
		public event EventHandler<EventArgs<string>> TitleChanged
		{
			[Token(Token = "0x6000351")]
			[Address(RVA = "0x5BAF9C0", Offset = "0x5BAE5C0", VA = "0x185BAF9C0", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000352")]
			[Address(RVA = "0x5BB03E0", Offset = "0x5BAEFE0", VA = "0x185BB03E0", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400004C RID: 76
		// (add) Token: 0x06000353 RID: 851 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000354 RID: 852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400004C")]
		public event EventHandler<UrlChangedEventArgs> UrlChanged
		{
			[Token(Token = "0x6000353")]
			[Address(RVA = "0x5BAFA70", Offset = "0x5BAE670", VA = "0x185BAFA70", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000354")]
			[Address(RVA = "0x5BB0490", Offset = "0x5BAF090", VA = "0x185BB0490", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000355 RID: 853 RVA: 0x00002550 File Offset: 0x00000750
		// (set) Token: 0x06000356 RID: 854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000042")]
		public bool IsDisposed
		{
			[Token(Token = "0x6000355")]
			[Address(RVA = "0x6DF210", Offset = "0x6DDE10", VA = "0x1806DF210", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000356")]
			[Address(RVA = "0xC97C20", Offset = "0xC96820", VA = "0x180C97C20")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000357 RID: 855 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x17000043")]
		public bool IsInitialized
		{
			[Token(Token = "0x6000357")]
			[Address(RVA = "0x5BAFBD0", Offset = "0x5BAE7D0", VA = "0x185BAFBD0", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000358 RID: 856 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000044")]
		public List<string> PageLoadScripts
		{
			[Token(Token = "0x6000358")]
			[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000359 RID: 857 RVA: 0x00002580 File Offset: 0x00000780
		// (set) Token: 0x0600035A RID: 858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000045")]
		public Vector2Int Size
		{
			[Token(Token = "0x6000359")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(Vector2Int);
			}
			[Token(Token = "0x600035A")]
			[Address(RVA = "0x4A5BFE0", Offset = "0x4A5ABE0", VA = "0x184A5BFE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600035B RID: 859 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600035C RID: 860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000046")]
		public Texture2D Texture
		{
			[Token(Token = "0x600035B")]
			[Address(RVA = "0xEB4B70", Offset = "0xEB3770", VA = "0x180EB4B70", Slot = "28")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600035C")]
			[Address(RVA = "0x2203A80", Offset = "0x2202680", VA = "0x182203A80")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600035D RID: 861 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600035E RID: 862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000047")]
		public string Title
		{
			[Token(Token = "0x600035D")]
			[Address(RVA = "0xEB4B80", Offset = "0xEB3780", VA = "0x180EB4B80", Slot = "29")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600035E")]
			[Address(RVA = "0xEDF350", Offset = "0xEDDF50", VA = "0x180EDF350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600035F RID: 863 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000360 RID: 864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000048")]
		public string Url
		{
			[Token(Token = "0x600035F")]
			[Address(RVA = "0xEB4B50", Offset = "0xEB3750", VA = "0x180EB4B50", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000360")]
			[Address(RVA = "0xEDF340", Offset = "0xEDDF40", VA = "0x180EDF340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000361")]
		[Address(RVA = "0x5BA8530", Offset = "0x5BA7130", VA = "0x185BA8530", Slot = "31")]
		public virtual Task<bool> CanGoBack()
		{
			return null;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x5BA86D0", Offset = "0x5BA72D0", VA = "0x185BA86D0", Slot = "32")]
		public virtual Task<bool> CanGoForward()
		{
			return null;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000363")]
		[Address(RVA = "0x5BA8870", Offset = "0x5BA7470", VA = "0x185BA8870", Slot = "33")]
		public virtual Task<byte[]> CaptureScreenshot()
		{
			return null;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000364")]
		[Address(RVA = "0x5BA89C0", Offset = "0x5BA75C0", VA = "0x185BA89C0", Slot = "34")]
		public virtual void Click(int xInPixels, int yInPixels, bool preventStealingFocus = false)
		{
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000365")]
		[Address(RVA = "0x5BA8920", Offset = "0x5BA7520", VA = "0x185BA8920", Slot = "35")]
		public void Click(Vector2 normalizedPoint, bool preventStealingFocus = false)
		{
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000366")]
		[Address(RVA = "0x5BA8AB0", Offset = "0x5BA76B0", VA = "0x185BA8AB0", Slot = "36")]
		public virtual void Copy()
		{
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000367")]
		[Address(RVA = "0x5BA8B50", Offset = "0x5BA7750", VA = "0x185BA8B50", Slot = "37")]
		public virtual Material CreateMaterial()
		{
			return null;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x5BA8C00", Offset = "0x5BA7800", VA = "0x185BA8C00", Slot = "38")]
		public virtual void Cut()
		{
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000369")]
		[Address(RVA = "0x5BA8CA0", Offset = "0x5BA78A0", VA = "0x185BA8CA0", Slot = "39")]
		public virtual void Dispose()
		{
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x5BA8DF0", Offset = "0x5BA79F0", VA = "0x185BA8DF0", Slot = "40")]
		public Task<string> ExecuteJavaScript(string javaScript)
		{
			return null;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x5BA8EF0", Offset = "0x5BA7AF0", VA = "0x185BA8EF0", Slot = "41")]
		public virtual void ExecuteJavaScript(string javaScript, Action<string> callback)
		{
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x5BA9080", Offset = "0x5BA7C80", VA = "0x185BA9080", Slot = "42")]
		public virtual Task<byte[]> GetRawTextureData()
		{
			return null;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x5BA9140", Offset = "0x5BA7D40", VA = "0x185BA9140", Slot = "43")]
		public virtual void GoBack()
		{
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x5BA9200", Offset = "0x5BA7E00", VA = "0x185BA9200", Slot = "44")]
		public virtual void GoForward()
		{
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036F")]
		[Address(RVA = "0x5BAAC80", Offset = "0x5BA9880", VA = "0x185BAAC80", Slot = "45")]
		public virtual void LoadHtml(string html)
		{
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000370")]
		[Address(RVA = "0x5BAAFD0", Offset = "0x5BA9BD0", VA = "0x185BAAFD0", Slot = "46")]
		public virtual void LoadUrl(string url)
		{
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x5BAAD70", Offset = "0x5BA9970", VA = "0x185BAAD70", Slot = "47")]
		public virtual void LoadUrl(string url, Dictionary<string, string> additionalHttpHeaders)
		{
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00002598 File Offset: 0x00000798
		[Token(Token = "0x6000372")]
		[Address(RVA = "0x5BAB0D0", Offset = "0x5BA9CD0", VA = "0x185BAB0D0", Slot = "48")]
		public Vector2Int NormalizedToPoint(Vector2 normalizedPoint)
		{
			return default(Vector2Int);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x5BAB170", Offset = "0x5BA9D70", VA = "0x185BAB170", Slot = "49")]
		public virtual void Paste()
		{
		}

		// Token: 0x06000374 RID: 884 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x5BAB240", Offset = "0x5BA9E40", VA = "0x185BAB240", Slot = "50")]
		public Vector2 PointToNormalized(int xInPixels, int yInPixels)
		{
			return default(Vector2);
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x5BAB280", Offset = "0x5BA9E80", VA = "0x185BAB280", Slot = "51")]
		public virtual void PostMessage(string message)
		{
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000376")]
		[Address(RVA = "0x5BAB400", Offset = "0x5BAA000", VA = "0x185BAB400", Slot = "52")]
		public virtual void Reload()
		{
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x5BAB4C0", Offset = "0x5BAA0C0", VA = "0x185BAB4C0", Slot = "53")]
		public virtual void Resize(int width, int height)
		{
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x5BAB750", Offset = "0x5BAA350", VA = "0x185BAB750", Slot = "54")]
		public virtual void Scroll(int scrollDeltaXInPixels, int scrollDeltaYInPixels)
		{
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000379")]
		[Address(RVA = "0x5BAB830", Offset = "0x5BAA430", VA = "0x185BAB830", Slot = "55")]
		public void Scroll(Vector2 normalizedScrollDelta)
		{
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037A")]
		[Address(RVA = "0x5BAB600", Offset = "0x5BAA200", VA = "0x185BAB600", Slot = "56")]
		public virtual void Scroll(Vector2 normalizedScrollDelta, Vector2 normalizedPoint)
		{
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037B")]
		[Address(RVA = "0x5BAB8B0", Offset = "0x5BAA4B0", VA = "0x185BAB8B0", Slot = "57")]
		public virtual void SelectAll()
		{
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037C")]
		[Address(RVA = "0x5BAB920", Offset = "0x5BAA520", VA = "0x185BAB920", Slot = "58")]
		public virtual void SendKey(string key)
		{
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x5BABA10", Offset = "0x5BAA610", VA = "0x185BABA10")]
		public static void SetCameraAndMicrophoneEnabled(bool enabled)
		{
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x5BABAC0", Offset = "0x5BAA6C0", VA = "0x185BABAC0", Slot = "59")]
		public virtual void SetDefaultBackgroundEnabled(bool enabled)
		{
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x5BABB90", Offset = "0x5BAA790", VA = "0x185BABB90", Slot = "60")]
		public virtual void SetFocused(bool focused)
		{
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000380")]
		[Address(RVA = "0x5BABCD0", Offset = "0x5BAA8D0", VA = "0x185BABCD0", Slot = "61")]
		public virtual void SetRenderingEnabled(bool enabled)
		{
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000381")]
		[Address(RVA = "0x5BABDF0", Offset = "0x5BAA9F0", VA = "0x185BABDF0", Slot = "62")]
		public virtual void StopLoad()
		{
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000382")]
		[Address(RVA = "0x5BABEB0", Offset = "0x5BAAAB0", VA = "0x185BABEB0", Slot = "63")]
		public Task WaitForNextPageLoadToFinish()
		{
			return null;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000383")]
		[Address(RVA = "0x5BACDC0", Offset = "0x5BAB9C0", VA = "0x185BACDC0", Slot = "64")]
		public virtual void ZoomIn()
		{
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000384")]
		[Address(RVA = "0x5BACE80", Offset = "0x5BABA80", VA = "0x185BACE80", Slot = "65")]
		public virtual void ZoomOut()
		{
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000385 RID: 901 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x17000049")]
		protected virtual int _abnormallyLargeThreshold
		{
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x5BAFC00", Offset = "0x5BAE800", VA = "0x185BAFC00", Slot = "66")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000386 RID: 902 RVA: 0x000025E0 File Offset: 0x000007E0
		// (set) Token: 0x06000387 RID: 903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004A")]
		protected Rect _rect
		{
			[Token(Token = "0x6000386")]
			[Address(RVA = "0x5BAFC10", Offset = "0x5BAE810", VA = "0x185BAFC10")]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x6000387")]
			[Address(RVA = "0x5BB05F0", Offset = "0x5BAF1F0", VA = "0x185BB05F0")]
			set
			{
			}
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x5BACF40", Offset = "0x5BABB40", VA = "0x185BACF40")]
		protected void _assertNative2DModeEnabled()
		{
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x5BACFB0", Offset = "0x5BABBB0", VA = "0x185BACFB0")]
		protected void _assertPointIsWithinBounds(int xInPixels, int yInPixels)
		{
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x5BAD1C0", Offset = "0x5BABDC0", VA = "0x185BAD1C0")]
		protected void _assertSingletonEventHandlerUnset(object handler, string eventName)
		{
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x5BAD240", Offset = "0x5BABE40", VA = "0x185BAD240")]
		private void _assertSupportedGraphicsApi()
		{
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x5BAD420", Offset = "0x5BAC020", VA = "0x185BAD420")]
		private void _assertValidSize(int width, int height)
		{
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x5BAD4F0", Offset = "0x5BAC0F0", VA = "0x185BAD4F0")]
		protected void _assertValidState()
		{
		}

		// Token: 0x0600038E RID: 910 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x5BAE780", Offset = "0x5BAD380", VA = "0x185BAE780")]
		protected Vector2Int _normalizedToPointAssertValid(Vector2 normalizedPoint)
		{
			return default(Vector2Int);
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600038F")]
		[Address(RVA = "0x5BAD830", Offset = "0x5BAC430", VA = "0x185BAD830", Slot = "67")]
		protected virtual Material _createMaterial()
		{
			return null;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x5BAD840", Offset = "0x5BAC440", VA = "0x185BAD840", Slot = "68")]
		protected virtual Task<Texture2D> _createTexture(int width, int height)
		{
			return null;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x5BADB50", Offset = "0x5BAC750", VA = "0x185BADB50", Slot = "69")]
		protected virtual void _destroyNativeTexture(IntPtr nativeTexture)
		{
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x5BADC60", Offset = "0x5BAC860", VA = "0x185BADC60")]
		private Texture2D _getReadableTexture()
		{
			return null;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x5BADEE0", Offset = "0x5BACAE0", VA = "0x185BADEE0")]
		private static string _getRenderPipelineName()
		{
			return null;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x5BADF50", Offset = "0x5BACB50", VA = "0x185BADF50")]
		private Task<string> _getSelectedText()
		{
			return null;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "70")]
		protected virtual GraphicsDeviceType[] _getSupportedGraphicsApis()
		{
			return null;
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00002610 File Offset: 0x00000810
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x54B470", Offset = "0x54A070", VA = "0x18054B470", Slot = "71")]
		protected virtual TextureFormat _getTextureFormat()
		{
			return (TextureFormat)0;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x5BA92C0", Offset = "0x5BA7EC0", VA = "0x185BA92C0")]
		private void HandleCanGoBackResult(string message)
		{
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x5BA9520", Offset = "0x5BA8120", VA = "0x185BA9520")]
		private void HandleCanGoForwardResult(string message)
		{
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x5BA9780", Offset = "0x5BA8380", VA = "0x185BA9780")]
		private void HandleCloseRequested(string message)
		{
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x5BA9800", Offset = "0x5BA8400", VA = "0x185BA9800")]
		private void HandleFocusedInputFieldChanged(string typeString)
		{
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039B")]
		[Address(RVA = "0x5BA9980", Offset = "0x5BA8580", VA = "0x185BA9980")]
		protected void HandleInitFinished(string _)
		{
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x5BA99F0", Offset = "0x5BA85F0", VA = "0x185BA99F0")]
		private void HandleJavaScriptResult(string message)
		{
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x5BAE070", Offset = "0x5BACC70", VA = "0x185BAE070")]
		private void _handleJavaScriptResult(string resultCallbackId, string result)
		{
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x5BA9AF0", Offset = "0x5BA86F0", VA = "0x185BA9AF0")]
		private void HandleLoadFailed(string message)
		{
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x5BA9E00", Offset = "0x5BA8A00", VA = "0x185BA9E00")]
		private void HandleLoadFinished(string _)
		{
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x5BAA130", Offset = "0x5BA8D30", VA = "0x185BAA130")]
		private void HandleLoadStarted(string _)
		{
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x5BAA020", Offset = "0x5BA8C20", VA = "0x185BAA020")]
		private void HandleLoadProgressUpdate(string progressString)
		{
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x5BAA1F0", Offset = "0x5BA8DF0", VA = "0x185BAA1F0", Slot = "72")]
		protected virtual void HandleMessageEmitted(string serializedMessage)
		{
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x5BAA670", Offset = "0x5BA9270", VA = "0x185BAA670")]
		private void HandleTerminated(string typeString)
		{
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x5BAA830", Offset = "0x5BA9430", VA = "0x185BAA830", Slot = "73")]
		protected virtual void HandleTextureChanged(string message)
		{
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x5BAA9E0", Offset = "0x5BA95E0", VA = "0x185BAA9E0")]
		private void HandleTitleChanged(string title)
		{
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x5BAAA90", Offset = "0x5BA9690", VA = "0x185BAAA90")]
		private void HandleUrlChanged(string url)
		{
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x5BAE120", Offset = "0x5BACD20", VA = "0x185BAE120")]
		protected Task<Task> _initBase(int width, int height, bool createTexture = true, bool asyncInit = false)
		{
			return null;
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x5BAE260", Offset = "0x5BACE60", VA = "0x185BAE260")]
		protected Task<Task> _initInNative2DModeBase(Rect rect, bool asyncInit = false)
		{
			return null;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x5BAE380", Offset = "0x5BACF80", VA = "0x185BAE380")]
		private static void _logSystemInfoIfNeeded()
		{
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x45B3E10", Offset = "0x45B2A10", VA = "0x1845B3E10", Slot = "74")]
		protected virtual void OnLoadProgressChanged(ProgressChangedEventArgs eventArgs)
		{
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00002628 File Offset: 0x00000828
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x5BAE880", Offset = "0x5BAD480", VA = "0x185BAE880")]
		protected ConsoleMessageLevel _parseConsoleMessageLevel(string levelString)
		{
			return ConsoleMessageLevel.Debug;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x5BAE980", Offset = "0x5BAD580", VA = "0x185BAE980", Slot = "75")]
		protected virtual void _resize()
		{
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x5BAEA60", Offset = "0x5BAD660", VA = "0x185BAEA60", Slot = "76")]
		protected virtual void _setConsoleMessageEventsEnabled(bool enabled)
		{
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x5BAEB30", Offset = "0x5BAD730", VA = "0x185BAEB30", Slot = "77")]
		protected virtual void _setFocusedInputFieldEventsEnabled(bool enabled)
		{
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x5BAEC00", Offset = "0x5BAD800", VA = "0x185BAEC00")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void _staticInit()
		{
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x5BAED20", Offset = "0x5BAD920", VA = "0x185BAED20")]
		protected string _transformUrlIfNeeded(string originalUrl)
		{
			return null;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x5BAF0B0", Offset = "0x5BADCB0", VA = "0x185BAF0B0")]
		private void _warnIfAbnormallyLarge(int width, int height)
		{
		}

		// Token: 0x060003B2 RID: 946
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x5BABF60", Offset = "0x5BAAB60", VA = "0x185BABF60")]
		[PreserveSig]
		private static extern void WebView_canGoBack(IntPtr webViewPtr);

		// Token: 0x060003B3 RID: 947
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x5BABFE0", Offset = "0x5BAABE0", VA = "0x185BABFE0")]
		[PreserveSig]
		private static extern void WebView_canGoForward(IntPtr webViewPtr);

		// Token: 0x060003B4 RID: 948
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x5BAC060", Offset = "0x5BAAC60", VA = "0x185BAC060")]
		[PreserveSig]
		protected static extern void WebView_click(IntPtr webViewPtr, int x, int y);

		// Token: 0x060003B5 RID: 949
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x5BAC100", Offset = "0x5BAAD00", VA = "0x185BAC100")]
		[PreserveSig]
		protected static extern void WebView_destroyTexture(IntPtr texture, string graphicsApi);

		// Token: 0x060003B6 RID: 950
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x5BAC1A0", Offset = "0x5BAADA0", VA = "0x185BAC1A0")]
		[PreserveSig]
		private static extern void WebView_destroy(IntPtr webViewPtr);

		// Token: 0x060003B7 RID: 951
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x5BAC220", Offset = "0x5BAAE20", VA = "0x185BAC220")]
		[PreserveSig]
		private static extern void WebView_executeJavaScript(IntPtr webViewPtr, string javaScript, string resultCallbackId);

		// Token: 0x060003B8 RID: 952
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x5BAC2E0", Offset = "0x5BAAEE0", VA = "0x185BAC2E0")]
		[PreserveSig]
		private static extern void WebView_goBack(IntPtr webViewPtr);

		// Token: 0x060003B9 RID: 953
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x5BAC360", Offset = "0x5BAAF60", VA = "0x185BAC360")]
		[PreserveSig]
		private static extern void WebView_goForward(IntPtr webViewPtr);

		// Token: 0x060003BA RID: 954
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x5BAC850", Offset = "0x5BAB450", VA = "0x185BAC850")]
		[PreserveSig]
		private static extern void WebView_sendKey(IntPtr webViewPtr, string input);

		// Token: 0x060003BB RID: 955
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x5BAC3E0", Offset = "0x5BAAFE0", VA = "0x185BAC3E0")]
		[PreserveSig]
		private static extern void WebView_loadHtml(IntPtr webViewPtr, string html);

		// Token: 0x060003BC RID: 956
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x5BAC540", Offset = "0x5BAB140", VA = "0x185BAC540")]
		[PreserveSig]
		private static extern void WebView_loadUrl(IntPtr webViewPtr, string url);

		// Token: 0x060003BD RID: 957
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x5BAC480", Offset = "0x5BAB080", VA = "0x185BAC480")]
		[PreserveSig]
		private static extern void WebView_loadUrlWithHeaders(IntPtr webViewPtr, string url, string newlineDelimitedHttpHeaders);

		// Token: 0x060003BE RID: 958
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x5BAC5E0", Offset = "0x5BAB1E0", VA = "0x185BAC5E0")]
		[PreserveSig]
		private static extern void WebView_reload(IntPtr webViewPtr);

		// Token: 0x060003BF RID: 959
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x5BAC660", Offset = "0x5BAB260", VA = "0x185BAC660")]
		[PreserveSig]
		protected static extern void WebView_resize(IntPtr webViewPtr, int width, int height);

		// Token: 0x060003C0 RID: 960
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x5BAC7B0", Offset = "0x5BAB3B0", VA = "0x185BAC7B0")]
		[PreserveSig]
		private static extern void WebView_scroll(IntPtr webViewPtr, int deltaX, int deltaY);

		// Token: 0x060003C1 RID: 961
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x5BAC700", Offset = "0x5BAB300", VA = "0x185BAC700")]
		[PreserveSig]
		private static extern void WebView_scrollAtPoint(IntPtr webViewPtr, int deltaX, int deltaY, int pointerX, int pointerY);

		// Token: 0x060003C2 RID: 962
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x5BAC8F0", Offset = "0x5BAB4F0", VA = "0x185BAC8F0")]
		[PreserveSig]
		private static extern void WebView_setCameraAndMicrophoneEnabled(bool enabled);

		// Token: 0x060003C3 RID: 963
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x5BAC970", Offset = "0x5BAB570", VA = "0x185BAC970")]
		[PreserveSig]
		private static extern void WebView_setConsoleMessageEventsEnabled(IntPtr webViewPtr, bool enabled);

		// Token: 0x060003C4 RID: 964
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x5BACA00", Offset = "0x5BAB600", VA = "0x185BACA00")]
		[PreserveSig]
		private static extern void WebView_setDefaultBackgroundEnabled(IntPtr webViewPtr, bool enabled);

		// Token: 0x060003C5 RID: 965
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x5BACB20", Offset = "0x5BAB720", VA = "0x185BACB20")]
		[PreserveSig]
		private static extern void WebView_setFocused(IntPtr webViewPtr, bool focused);

		// Token: 0x060003C6 RID: 966
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x5BACA90", Offset = "0x5BAB690", VA = "0x185BACA90")]
		[PreserveSig]
		private static extern void WebView_setFocusedInputFieldEventsEnabled(IntPtr webViewPtr, bool enabled);

		// Token: 0x060003C7 RID: 967
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x5BACBB0", Offset = "0x5BAB7B0", VA = "0x185BACBB0")]
		[PreserveSig]
		private static extern void WebView_setRenderingEnabled(IntPtr webViewPtr, bool enabled);

		// Token: 0x060003C8 RID: 968
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x5BACC40", Offset = "0x5BAB840", VA = "0x185BACC40")]
		[PreserveSig]
		private static extern void WebView_stopLoad(IntPtr webViewPtr);

		// Token: 0x060003C9 RID: 969
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x5BACCC0", Offset = "0x5BAB8C0", VA = "0x185BACCC0")]
		[PreserveSig]
		private static extern void WebView_zoomIn(IntPtr webViewPtr);

		// Token: 0x060003CA RID: 970
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x5BACD40", Offset = "0x5BAB940", VA = "0x185BACD40")]
		[PreserveSig]
		private static extern void WebView_zoomOut(IntPtr webViewPtr);

		// Token: 0x060003CB RID: 971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "78")]
		[Obsolete("IWebView.Blur() has been removed. Please use SetFocused(false) instead: https://developer.vuplex.com/webview/IWebView#SetFocused", true)]
		public void Blur()
		{
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "79")]
		[Obsolete("The callback-based CanGoBack(Action) version of this method has been removed. Please switch to the Task-based CanGoBack() version instead. If you prefer using a callback instead of awaiting the Task, you can still use a callback like this: CanGoBack().ContinueWith(result => {...})", true)]
		public void CanGoBack(Action<bool> callback)
		{
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "80")]
		[Obsolete("The callback-based CanGoForward(Action) version of this method has been removed. Please switch to the Task-based CanGoForward() version instead. If you prefer using a callback instead of awaiting the Task, you can still use a callback like this: CanGoForward().ContinueWith(result => {...})", true)]
		public void CanGoForward(Action<bool> callback)
		{
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "81")]
		[Obsolete("The callback-based CaptureScreenshot(Action) version of this method has been removed. Please switch to the Task-based CaptureScreenshot() version instead. If you prefer using a callback instead of awaiting the Task, you can still use a callback like this: CaptureScreenshot().ContinueWith(result => {...})", true)]
		public void CaptureScreenshot(Action<byte[]> callback)
		{
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "82")]
		[Obsolete("DisableViewUpdates() has been removed. Please use SetRenderingEnabled(false) instead: https://developer.vuplex.com/webview/IWebView#SetRenderingEnabled", true)]
		public void DisableViewUpdates()
		{
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "83")]
		[Obsolete("EnableViewUpdates() has been removed. Please use SetRenderingEnabled(true) instead: https://developer.vuplex.com/webview/IWebView#SetRenderingEnabled", true)]
		public void EnableViewUpdates()
		{
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "84")]
		[Obsolete("IWebView.Focus() has been removed. Please use SetFocused(false) instead: https://developer.vuplex.com/webview/IWebView#SetFocused", true)]
		public void Focus()
		{
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "85")]
		[Obsolete("The callback-based GetRawTextureData(Action) version of this method has been removed. Please switch to the Task-based GetRawTextureData() version instead. If you prefer using a callback instead of awaiting the Task, you can still use a callback like this: GetRawTextureData().ContinueWith(result => {...})", true)]
		public void GetRawTextureData(Action<byte[]> callback)
		{
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x5BA9AA0", Offset = "0x5BA86A0", VA = "0x185BA9AA0", Slot = "86")]
		[Obsolete("IWebView.HandleKeyboardInput() has been renamed to IWebView.SendKey(). Please switch to SendKey().")]
		public void HandleKeyboardInput(string key)
		{
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "87")]
		[Obsolete("IWebView.Init(Texture2D, float, float) has been removed in v4. Please switch to IWebView.Init(int, int) and await the Task it returns. For more details, please see this article: https://support.vuplex.com/articles/v4-changes#init", true)]
		public void Init(Texture2D texture, float width, float height)
		{
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "88")]
		[Obsolete("IWebView.Init(Texture2D, float, float, Texture2D) has been removed in v4. Please switch to IWebView.Init(int, int) and await the Task it returns. For more details, please see this article: https://support.vuplex.com/articles/v4-changes#init", true)]
		public void Init(Texture2D texture, float width, float height, Texture2D videoTexture)
		{
		}

		// Token: 0x1400004D RID: 77
		// (add) Token: 0x060003D6 RID: 982 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060003D7 RID: 983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400004D")]
		[Obsolete("IWebView.PageLoadFailed is now deprecated. Please use IWebView.LoadFailed instead: https://developer.vuplex.com/webview/IWebView#LoadFailed")]
		public event EventHandler PageLoadFailed
		{
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x5BAF780", Offset = "0x5BAE380", VA = "0x185BAF780", Slot = "89")]
			add
			{
			}
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x5BB01E0", Offset = "0x5BAEDE0", VA = "0x185BB01E0", Slot = "90")]
			remove
			{
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x1700004B")]
		[Obsolete("IWebView.Resolution has been removed in v4. Please use WebViewPrefab.Resolution or CanvasWebViewPrefab.Resolution instead. For more details, please see this article: https://support.vuplex.com/articles/v4-changes#resolution", true)]
		public float Resolution
		{
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x55476E0", Offset = "0x55462E0", VA = "0x1855476E0", Slot = "91")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "92")]
		[Obsolete("IWebView.SetResolution() has been removed in v4. Please set the WebViewPrefab.Resolution or CanvasWebViewPrefab.Resolution property instead. For more details, please see this article: https://support.vuplex.com/articles/v4-changes#resolution", true)]
		public void SetResolution(float pixelsPerUnityUnit)
		{
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x1700004C")]
		[Obsolete("IWebView.SizeInPixels is now deprecated. Please use IWebView.Size instead: https://developer.vuplex.com/webview/IWebView#Size")]
		public Vector2 SizeInPixels
		{
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x5BAFBE0", Offset = "0x5BAE7E0", VA = "0x185BAFBE0", Slot = "93")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1400004E RID: 78
		// (add) Token: 0x060003DB RID: 987 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060003DC RID: 988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400004E")]
		[Obsolete("IWebView.VideoRectChanged has been removed. Please use IWithFallbackVideo.VideoRectChanged instead: https://developer.vuplex.com/webview/IWithFallbackVideo#VideoRectChanged", true)]
		public event EventHandler<EventArgs<Rect>> VideoRectChanged
		{
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x5BAFB20", Offset = "0x5BAE720", VA = "0x185BAFB20", Slot = "94")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x5BB0540", Offset = "0x5BAF140", VA = "0x185BB0540", Slot = "95")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060003DD RID: 989 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700004D")]
		[Obsolete("IWebView.VideoTexture has been removed. Please use IWithFallbackVideo.VideoTexture instead: https://developer.vuplex.com/webview/IWithFallbackVideo#VideoTexture", true)]
		public Texture2D VideoTexture
		{
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x22F8830", Offset = "0x22F7430", VA = "0x1822F8830", Slot = "96")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x5BAD9A0", Offset = "0x5BAC5A0", VA = "0x185BAD9A0")]
		protected BaseWebView()
		{
		}

		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private EventHandler<ConsoleMessageEventArgs> _consoleMessageLogged;

		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		protected IntPtr _currentNativeTexture;

		// Token: 0x040001A1 RID: 417
		[Token(Token = "0x40001A1")]
		protected const string _dllName = "VuplexWebViewWindows";

		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private EventHandler<FocusedInputFieldChangedEventArgs> _focusedInputFieldChanged;

		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		protected BaseWebView.InitState _initState;

		// Token: 0x040001A4 RID: 420
		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private TaskCompletionSource<bool> _initTaskSource;

		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Material _materialForBlitting;

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected bool _native2DModeEnabled;

		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		protected Vector2Int _native2DPosition;

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		protected IntPtr _nativeWebViewPtr;

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private TaskCompletionSource<bool> _pageLoadFinishedTaskSource;

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private List<Action<bool>> _pendingCanGoBackCallbacks;

		// Token: 0x040001AB RID: 427
		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private List<Action<bool>> _pendingCanGoForwardCallbacks;

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		protected Dictionary<string, Action<string>> _pendingJavaScriptResultCallbacks;

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected bool _renderingEnabled;

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string[] STANDARD_URI_SCHEMES;

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Regex _streamingAssetsUrlRegex;

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
		protected bool _visible;

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Dictionary<EventHandler, EventHandler<LoadFailedEventArgs>> _legacyPageLoadFailedHandlerMap;

		// Token: 0x02000074 RID: 116
		[Token(Token = "0x2000074")]
		protected enum InitState
		{
			// Token: 0x040001B6 RID: 438
			[Token(Token = "0x40001B6")]
			Uninitialized,
			// Token: 0x040001B7 RID: 439
			[Token(Token = "0x40001B7")]
			InProgress,
			// Token: 0x040001B8 RID: 440
			[Token(Token = "0x40001B8")]
			Initialized
		}
	}
}
