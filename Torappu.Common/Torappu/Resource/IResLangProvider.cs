using System;
using Il2CppDummyDll;

namespace Torappu.Resource
{
	// Token: 0x020001D8 RID: 472
	[Token(Token = "0x20001D8")]
	public interface IResLangProvider
	{
		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000B1D RID: 2845
		[Token(Token = "0x170000FE")]
		bool hasResLang { [Token(Token = "0x6000B1D")] get; }

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000B1E RID: 2846
		[Token(Token = "0x170000FF")]
		ResourceOptions.ResLanguage resLang { [Token(Token = "0x6000B1E")] get; }
	}
}
