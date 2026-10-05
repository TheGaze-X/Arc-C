using System;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	public interface ISpacing
	{
		// Token: 0x060002B2 RID: 690
		[Token(Token = "0x60002B2")]
		int GetAfter(object[] instances, object[] values);

		// Token: 0x060002B3 RID: 691
		[Token(Token = "0x60002B3")]
		int GetBefore(object[] instances, object[] values);
	}
}
