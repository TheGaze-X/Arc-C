using System;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x02000063 RID: 99
	[Token(Token = "0x2000063")]
	public interface IExpandable
	{
		// Token: 0x0600029C RID: 668
		[Token(Token = "0x600029C")]
		bool IsExpandable(object[] instances, object[] values);

		// Token: 0x0600029D RID: 669
		[Token(Token = "0x600029D")]
		bool IsExpanded(object[] instances, object[] values);

		// Token: 0x0600029E RID: 670
		[Token(Token = "0x600029E")]
		bool IsAlwaysExpanded(object[] instances, object[] values);
	}
}
