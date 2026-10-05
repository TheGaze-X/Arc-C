using System;
using Il2CppDummyDll;

namespace Torappu.AVG
{
	// Token: 0x02001EE8 RID: 7912
	[Token(Token = "0x2001EE8")]
	public interface IAVGTextTranslater
	{
		// Token: 0x0600C458 RID: 50264
		[Token(Token = "0x600C458")]
		bool TryTranslate(string content, out string result);
	}
}
