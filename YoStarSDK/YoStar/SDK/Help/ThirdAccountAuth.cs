using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YoStar.SDK.UI;

namespace YoStar.SDK.Help
{
	// Token: 0x02000219 RID: 537
	[Token(Token = "0x2000219")]
	public class ThirdAccountAuth
	{
		// Token: 0x06000DDE RID: 3550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDE")]
		[Address(RVA = "0x5CAC3F0", Offset = "0x5CAAFF0", VA = "0x185CAC3F0")]
		public static ThirdAccountAuth Instance()
		{
			return null;
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDF")]
		[Address(RVA = "0x5CAB880", Offset = "0x5CAA480", VA = "0x185CAB880")]
		private string AssembleAuthURL(LoginPlatform platform)
		{
			return null;
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000DE0")]
		[Address(RVA = "0x5CABA70", Offset = "0x5CAA670", VA = "0x185CABA70")]
		public void AuthWithGooglePlatform([Optional] Action<ThirdAuthRet> action)
		{
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000DE1")]
		[Address(RVA = "0x5CAC5D0", Offset = "0x5CAB1D0", VA = "0x185CAC5D0")]
		private void OpenGoogleAuth(GoogleHelper googleAuth, SDKWebview webview, string clientID, string clientSecret, [Optional] Action<ThirdAuthRet> callback)
		{
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000DE2")]
		[Address(RVA = "0x5CABCD0", Offset = "0x5CAA8D0", VA = "0x185CABCD0")]
		public void AuthWithThirdPlatform(LoginPlatform platform, [Optional] Action<Dictionary<string, object>> action)
		{
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE3")]
		[Address(RVA = "0x5CAC140", Offset = "0x5CAAD40", VA = "0x185CAC140")]
		public static Dictionary<string, object> DealAuthInfo(string url)
		{
			return null;
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000DE4")]
		[Address(RVA = "0x5CAC810", Offset = "0x5CAB410", VA = "0x185CAC810")]
		public ThirdAccountAuth()
		{
		}

		// Token: 0x04000952 RID: 2386
		[Token(Token = "0x4000952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string url;

		// Token: 0x04000953 RID: 2387
		[Token(Token = "0x4000953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ThirdAccountAuth _instance;

		// Token: 0x04000954 RID: 2388
		[Token(Token = "0x4000954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly object lockObj;
	}
}
