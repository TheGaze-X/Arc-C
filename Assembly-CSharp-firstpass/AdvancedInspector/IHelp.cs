using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	public interface IHelp
	{
		// Token: 0x0600029F RID: 671
		[Token(Token = "0x600029F")]
		IList<HelpItem> GetHelp(object[] instances, object[] values);
	}
}
