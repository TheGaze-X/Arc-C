using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;

namespace Torappu.Battle
{
	// Token: 0x02002225 RID: 8741
	[Token(Token = "0x2002225")]
	public interface IActionNodeSource
	{
		// Token: 0x0600DC04 RID: 56324
		[Token(Token = "0x600DC04")]
		void GatherActionNodes(List<ActionNode> results);
	}
}
