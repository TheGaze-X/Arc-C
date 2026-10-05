using System;
using Il2CppDummyDll;

namespace Hypergryph.SDK
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	public interface IUniWebview
	{
		// Token: 0x06000001 RID: 1
		[Token(Token = "0x6000001")]
		void init(string env);

		// Token: 0x06000002 RID: 2
		[Token(Token = "0x6000002")]
		void startWebSupport();

		// Token: 0x06000003 RID: 3
		[Token(Token = "0x6000003")]
		void stopWebSupport();

		// Token: 0x06000004 RID: 4
		[Token(Token = "0x6000004")]
		void isNew(string type);

		// Token: 0x06000005 RID: 5
		[Token(Token = "0x6000005")]
		void isNew(string type, string urlParams);

		// Token: 0x06000006 RID: 6
		[Token(Token = "0x6000006")]
		void isNewByCache(string type);

		// Token: 0x06000007 RID: 7
		[Token(Token = "0x6000007")]
		void loadWebview(string type, string userData);

		// Token: 0x06000008 RID: 8
		[Token(Token = "0x6000008")]
		void loadWebview(string type, string userData, string urlParams);

		// Token: 0x06000009 RID: 9
		[Token(Token = "0x6000009")]
		void closeWebview();

		// Token: 0x0600000A RID: 10
		[Token(Token = "0x600000A")]
		void toastInsideWebview(int level, string message);

		// Token: 0x0600000B RID: 11
		[Token(Token = "0x600000B")]
		void preloadWebview(string type);

		// Token: 0x0600000C RID: 12
		[Token(Token = "0x600000C")]
		bool checkPreloadStatus();

		// Token: 0x0600000D RID: 13
		[Token(Token = "0x600000D")]
		void loadMiniWebview(string url, string userData, string customStyle);
	}
}
