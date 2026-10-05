using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.AVG
{
	// Token: 0x02001E51 RID: 7761
	[Token(Token = "0x2001E51")]
	public interface IAVGStateFilterProvider : IHotfixable
	{
		// Token: 0x0600BFED RID: 49133
		[Token(Token = "0x600BFED")]
		IEnumerable<IAVGCommandStateFilter> GetStateFilters();
	}
}
