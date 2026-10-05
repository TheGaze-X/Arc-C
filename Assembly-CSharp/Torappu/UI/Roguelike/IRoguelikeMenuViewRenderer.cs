using System;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005342 RID: 21314
	[Token(Token = "0x2005342")]
	public interface IRoguelikeMenuViewRenderer : IHotfixable
	{
		// Token: 0x0601F6EE RID: 128750
		[Token(Token = "0x601F6EE")]
		void Update();

		// Token: 0x0601F6EF RID: 128751
		[Token(Token = "0x601F6EF")]
		void Render(bool fastMode);
	}
}
