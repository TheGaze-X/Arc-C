using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x020035AE RID: 13742
	[Token(Token = "0x20035AE")]
	public interface ICharCardViewModelParser : ICommonSquadChar, ICharacterCardViewModel, IHotfixable, IComparableChar
	{
		// Token: 0x06015DEB RID: 89579
		[Token(Token = "0x6015DEB")]
		CharacterCardViewModel ParseToCharCardViewModel();

		// Token: 0x06015DEC RID: 89580
		[Token(Token = "0x6015DEC")]
		void ParseFromCharCardViewModel(CharacterCardViewModel characterCardViewModel);
	}
}
