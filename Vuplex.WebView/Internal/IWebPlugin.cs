using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Vuplex.WebView.Internal
{
	// Token: 0x02000086 RID: 134
	[Token(Token = "0x2000086")]
	public interface IWebPlugin
	{
		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600040F RID: 1039
		[Token(Token = "0x17000054")]
		ICookieManager CookieManager { [Token(Token = "0x600040F")] get; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000410 RID: 1040
		[Token(Token = "0x17000055")]
		WebPluginType Type { [Token(Token = "0x6000410")] get; }

		// Token: 0x06000411 RID: 1041
		[Token(Token = "0x6000411")]
		void ClearAllData();

		// Token: 0x06000412 RID: 1042
		[Token(Token = "0x6000412")]
		void CreateMaterial(Action<Material> callback);

		// Token: 0x06000413 RID: 1043
		[Token(Token = "0x6000413")]
		IWebView CreateWebView();

		// Token: 0x06000414 RID: 1044
		[Token(Token = "0x6000414")]
		void EnableRemoteDebugging();

		// Token: 0x06000415 RID: 1045
		[Token(Token = "0x6000415")]
		void SetAutoplayEnabled(bool enabled);

		// Token: 0x06000416 RID: 1046
		[Token(Token = "0x6000416")]
		void SetCameraAndMicrophoneEnabled(bool enabled);

		// Token: 0x06000417 RID: 1047
		[Token(Token = "0x6000417")]
		void SetIgnoreCertificateErrors(bool ignore);

		// Token: 0x06000418 RID: 1048
		[Token(Token = "0x6000418")]
		void SetStorageEnabled(bool enabled);

		// Token: 0x06000419 RID: 1049
		[Token(Token = "0x6000419")]
		void SetUserAgent(bool mobile);

		// Token: 0x0600041A RID: 1050
		[Token(Token = "0x600041A")]
		void SetUserAgent(string userAgent);
	}
}
