using System;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051AD RID: 20909
	[Token(Token = "0x20051AD")]
	public interface IRoguelikeChoiceHintModel : IHotfixable
	{
		// Token: 0x0601EE29 RID: 126505
		[Token(Token = "0x601EE29")]
		string DoGetChoiceHint(IRoguelikeChoiceHintContext context);
	}
}
