using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x02002234 RID: 8756
	[Token(Token = "0x2002234")]
	public interface ICardMiscModifierTalent : IHotfixable
	{
		// Token: 0x0600DC1A RID: 56346
		[Token(Token = "0x600DC1A")]
		bool CreateDeckRuntimeMiscModifier(Deck.Card sourceCard, out Deck.Card.MiscSettingModifier modifier);
	}
}
