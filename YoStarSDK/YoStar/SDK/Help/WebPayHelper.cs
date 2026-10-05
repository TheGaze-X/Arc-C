using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using YoStar.SDK.Component;
using YoStar.SDK.UI;

namespace YoStar.SDK.Help
{
	// Token: 0x0200021F RID: 543
	[Token(Token = "0x200021F")]
	public class WebPayHelper : BaseComponent
	{
		// Token: 0x06000DF2 RID: 3570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DF2")]
		[Address(RVA = "0x5CB6290", Offset = "0x5CB4E90", VA = "0x185CB6290")]
		public static WebPayHelper getInstance()
		{
			return null;
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000DF3")]
		[Address(RVA = "0x5CB5F60", Offset = "0x5CB4B60", VA = "0x185CB5F60")]
		public void Pay(string url, string extraData, Dictionary<string, object> eventParam, PayType payType)
		{
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000DF4")]
		[Address(RVA = "0x5CB61A0", Offset = "0x5CB4DA0", VA = "0x185CB61A0")]
		public void WebViewCloseCallBack(SDKWebview webview, string value)
		{
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000DF5")]
		[Address(RVA = "0x5CB57C0", Offset = "0x5CB43C0", VA = "0x185CB57C0")]
		public void GetUrlChangeCallBack(SDKWebview sdkWebview, string url)
		{
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000DF6")]
		[Address(RVA = "0x5CB5EA0", Offset = "0x5CB4AA0", VA = "0x185CB5EA0")]
		public void OrderDetail(string orderId)
		{
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000DF7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public WebPayHelper()
		{
		}

		// Token: 0x04000960 RID: 2400
		[Token(Token = "0x4000960")]
		[FieldOffset(Offset = "0x0")]
		private static WebPayHelper mInstance;

		// Token: 0x04000961 RID: 2401
		[Token(Token = "0x4000961")]
		[FieldOffset(Offset = "0x8")]
		private static object lockObj;

		// Token: 0x04000962 RID: 2402
		[Token(Token = "0x4000962")]
		[FieldOffset(Offset = "0x10")]
		private string extraData;

		// Token: 0x04000963 RID: 2403
		[Token(Token = "0x4000963")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, object> eventParam;

		// Token: 0x04000964 RID: 2404
		[Token(Token = "0x4000964")]
		[FieldOffset(Offset = "0x20")]
		private PayType payType;
	}
}
