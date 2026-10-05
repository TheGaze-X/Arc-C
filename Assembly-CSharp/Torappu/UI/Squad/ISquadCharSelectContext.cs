using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Squad
{
	// Token: 0x02003DCF RID: 15823
	[Token(Token = "0x2003DCF")]
	public interface ISquadCharSelectContext
	{
		// Token: 0x060189D0 RID: 100816
		[Token(Token = "0x60189D0")]
		List<int> GetTempListForExclusiveInstIds();

		// Token: 0x060189D1 RID: 100817
		[Token(Token = "0x60189D1")]
		SquadGroupViewModel GetSquadGroupViewModel();
	}
}
