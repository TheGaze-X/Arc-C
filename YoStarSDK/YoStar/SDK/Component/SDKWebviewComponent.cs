using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YoStar.SDK.UI;
using YoStar.SDK.Util;

namespace YoStar.SDK.Component
{
	// Token: 0x0200027B RID: 635
	[Token(Token = "0x200027B")]
	public class SDKWebviewComponent
	{
		// Token: 0x06000F47 RID: 3911 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F47")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private SDKWebviewComponent()
		{
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000F48 RID: 3912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C4")]
		public static SDKWebviewComponent Instance
		{
			[Token(Token = "0x6000F48")]
			[Address(RVA = "0x5CBF880", Offset = "0x5CBE480", VA = "0x185CBF880")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F49")]
		[Address(RVA = "0x5CBF690", Offset = "0x5CBE290", VA = "0x185CBF690")]
		public void Show(bool hiddenNavigation, string title, string webUrl)
		{
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F4A")]
		[Address(RVA = "0x5CBF370", Offset = "0x5CBDF70", VA = "0x185CBF370")]
		public void LoadHtml(string html, bool hideToolbar = false, string title = "", [Optional] SDKWebview sdkWebview, bool isStandardHtml = false)
		{
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F4B")]
		[Address(RVA = "0x5CBF4F0", Offset = "0x5CBE0F0", VA = "0x185CBF4F0")]
		public void LoadUrl(string url, bool hideToolbar = false, string title = "", [Optional] SDKWebview sdkWebview, [Optional] WebViewUtils.ChangeCallback jsCallback)
		{
		}

		// Token: 0x04000C68 RID: 3176
		[Token(Token = "0x4000C68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static SDKWebviewComponent instance;

		// Token: 0x04000C69 RID: 3177
		[Token(Token = "0x4000C69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly object lockObject;
	}
}
