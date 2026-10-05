using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x02002226 RID: 8742
	[Token(Token = "0x2002226")]
	public interface IBuffSource
	{
		// Token: 0x0600DC05 RID: 56325
		[Token(Token = "0x600DC05")]
		void GatherBuffs(List<BuffData> results);
	}
}
