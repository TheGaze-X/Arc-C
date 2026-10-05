using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x020021EC RID: 8684
	[Token(Token = "0x20021EC")]
	public interface IDeckSelector
	{
		// Token: 0x0600D951 RID: 55633
		[Token(Token = "0x600D951")]
		bool Verify(Deck.Card candidateCard, Deck.Card sourceCard);
	}
}
