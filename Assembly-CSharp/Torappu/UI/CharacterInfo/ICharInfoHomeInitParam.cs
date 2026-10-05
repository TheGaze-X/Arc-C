using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005EBB RID: 24251
	[Token(Token = "0x2005EBB")]
	public interface ICharInfoHomeInitParam
	{
		// Token: 0x060231DB RID: 143835
		[Token(Token = "0x60231DB")]
		int GetCharInstId();

		// Token: 0x060231DC RID: 143836
		[Token(Token = "0x60231DC")]
		List<int> GetCharList();

		// Token: 0x060231DD RID: 143837
		[Token(Token = "0x60231DD")]
		bool IsFromHandbook();

		// Token: 0x060231DE RID: 143838
		[Token(Token = "0x60231DE")]
		bool IsEmpty();
	}
}
