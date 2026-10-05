using System;
using Il2CppDummyDll;

namespace Sirenix.Utilities
{
	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000068")]
	public interface IGlobalConfigEvents
	{
		// Token: 0x060002AD RID: 685
		[Token(Token = "0x60002AD")]
		void OnConfigAutoCreated();

		// Token: 0x060002AE RID: 686
		[Token(Token = "0x60002AE")]
		void OnConfigInstanceFirstAccessed();
	}
}
