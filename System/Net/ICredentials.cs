using System;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002B1 RID: 689
	[Token(Token = "0x20002B1")]
	public interface ICredentials
	{
		// Token: 0x0600134C RID: 4940
		[Token(Token = "0x600134C")]
		NetworkCredential GetCredential(Uri uri, string authType);
	}
}
