using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003637 RID: 13879
	[Token(Token = "0x2003637")]
	public interface IUIPageRouter
	{
		// Token: 0x06016193 RID: 90515
		[Token(Token = "0x6016193")]
		IEnumerable<IUIPageConfig> EnumPages();

		// Token: 0x06016194 RID: 90516
		[Token(Token = "0x6016194")]
		IUIPageConfig GetPageByName(string name);
	}
}
