using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003AE9 RID: 15081
	[Token(Token = "0x2003AE9")]
	public interface IPlayerStatus : IHotfixable
	{
		// Token: 0x06017C57 RID: 97367
		[Token(Token = "0x6017C57")]
		AvatarInfo GetAvatarInfo();

		// Token: 0x06017C58 RID: 97368
		[Token(Token = "0x6017C58")]
		string GetSecretarySkinId();

		// Token: 0x06017C59 RID: 97369
		[Token(Token = "0x6017C59")]
		bool GetSecretarySkinSp();
	}
}
