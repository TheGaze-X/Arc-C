using System;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x0200006D RID: 109
	[Token(Token = "0x200006D")]
	public interface IRuntimeAttribute<T> : IRuntimeAttribute
	{
		// Token: 0x060002AB RID: 683
		[Token(Token = "0x60002AB")]
		T Invoke(int index, object instance, object value);
	}
}
