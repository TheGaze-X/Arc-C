using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Vuplex.WebView.Internal;

namespace Vuplex.WebView
{
	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	internal class WindowsWebPlugin : StandaloneWebPlugin, IWebPlugin
	{
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600032B RID: 811 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700003D")]
		public static WindowsWebPlugin Instance
		{
			[Token(Token = "0x600032B")]
			[Address(RVA = "0x5BCAA90", Offset = "0x5BC9690", VA = "0x185BCAA90")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600032C RID: 812 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x1700003E")]
		public WebPluginType Type
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return WebPluginType.Android;
			}
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x5BCA960", Offset = "0x5BC9560", VA = "0x185BCA960", Slot = "26")]
		public virtual IWebView CreateWebView()
		{
			return null;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x5BCA9D0", Offset = "0x5BC95D0", VA = "0x185BCA9D0")]
		public WindowsWebPlugin()
		{
		}

		// Token: 0x0400018B RID: 395
		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x0")]
		private static WindowsWebPlugin _instance;
	}
}
