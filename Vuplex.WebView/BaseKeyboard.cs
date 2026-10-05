using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using Vuplex.WebView.Internal;

namespace Vuplex.WebView
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	public abstract class BaseKeyboard : MonoBehaviour
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000001")]
		public event EventHandler<EventArgs<string>> KeyPressed
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x5BA43D0", Offset = "0x5BA2FD0", VA = "0x185BA43D0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x5BA45D0", Offset = "0x5BA31D0", VA = "0x185BA45D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000002")]
		public event EventHandler Initialized
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x5BA4280", Offset = "0x5BA2E80", VA = "0x185BA4280")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x5BA4480", Offset = "0x5BA3080", VA = "0x185BA4480")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x5BA3770", Offset = "0x5BA2370", VA = "0x185BA3770")]
		public Task WaitUntilInitialized()
		{
			return null;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000001")]
		internal BaseWebViewPrefab BaseWebViewPrefab
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x5BA3CC0", Offset = "0x5BA28C0", VA = "0x185BA3CC0")]
		protected void _init()
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x5BA3680", Offset = "0x5BA2280", VA = "0x185BA3680")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x5BA3700", Offset = "0x5BA2300", VA = "0x185BA3700")]
		private void OnDisable()
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x5BA3940", Offset = "0x5BA2540", VA = "0x185BA3940")]
		private void WebView_MessageEmitted(object sender, EventArgs<string> e)
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x5BA3B90", Offset = "0x5BA2790", VA = "0x185BA3B90")]
		private string _getKeyboardLanguage()
		{
			return null;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x5BA3D60", Offset = "0x5BA2960", VA = "0x185BA3D60")]
		private void _sendKeyboardLanguageMessage()
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x5BA3F40", Offset = "0x5BA2B40", VA = "0x185BA3F40")]
		protected static void _setLayerRecursively(GameObject gameObject, int layer)
		{
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000003")]
		[Obsolete("Keyboard.InputReceived was removed in v4.3 because WebViewPrefab and CanvasWebViewPrefab now automatically handle keyboard input by default. Please remove your code that references Keyboard.InputReceived, and keyboard support will still work. For more info, including details about how you can still access keyboard input programmatically, please see this article: https://support.vuplex.com/articles/keyboard", true)]
		public event EventHandler<EventArgs<string>> InputReceived
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x5BA4320", Offset = "0x5BA2F20", VA = "0x185BA4320")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x5BA4520", Offset = "0x5BA3120", VA = "0x185BA4520")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		protected BaseKeyboard()
		{
		}

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("If you want to load a customized version of the Keyboard UI, you can do so by setting this field. For example, you could load a customized Keyboard UI from StreamingAssets by using a URL like \"streaming-assets://keyboard/index.html\".")]
		[Label("Custom Keyboard URL (optional)")]
		public string CustomKeyboardUrl;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x30")]
		private bool _isInitialized;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x38")]
		[HideInInspector]
		[SerializeField]
		protected BaseWebViewPrefab _webViewPrefab;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x0")]
		protected static readonly WebViewOptions _webViewOptions;
	}
}
