using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x02002233 RID: 8755
	[Token(Token = "0x2002233")]
	public interface ICardModifier : IHotfixable
	{
		// Token: 0x0600DC19 RID: 56345
		[Token(Token = "0x600DC19")]
		void OnTick(Deck.Card card, FP deltaTime);
	}
}
