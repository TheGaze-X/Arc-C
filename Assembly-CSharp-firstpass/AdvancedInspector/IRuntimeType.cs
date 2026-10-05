using System;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	public interface IRuntimeType
	{
		// Token: 0x060002B1 RID: 689
		[Token(Token = "0x60002B1")]
		Type GetType(object[] instances, object[] values);
	}
}
