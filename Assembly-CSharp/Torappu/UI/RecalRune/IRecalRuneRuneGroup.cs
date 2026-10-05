using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.RecalRune
{
	// Token: 0x02004799 RID: 18329
	[Token(Token = "0x2004799")]
	public interface IRecalRuneRuneGroup : IHotfixable
	{
		// Token: 0x0601BC49 RID: 113737
		[Token(Token = "0x601BC49")]
		bool IsEssential();

		// Token: 0x0601BC4A RID: 113738
		[Token(Token = "0x601BC4A")]
		List<RecalRuneStageRuneItemViewModel> GetGroupItems();
	}
}
