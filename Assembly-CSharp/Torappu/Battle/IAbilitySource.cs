using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x02002224 RID: 8740
	[Token(Token = "0x2002224")]
	public interface IAbilitySource
	{
		// Token: 0x0600DC03 RID: 56323
		[Token(Token = "0x600DC03")]
		void GatherAbilities(string hostId, string tmplId, List<string> abilities);
	}
}
