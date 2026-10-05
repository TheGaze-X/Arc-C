using System;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005249 RID: 21065
	[Token(Token = "0x2005249")]
	public interface IRoguelikeFocusNodePlugin : IHotfixable
	{
		// Token: 0x0601F13F RID: 127295
		[Token(Token = "0x601F13F")]
		void Render(RoguelikeDungeonNode node);
	}
}
