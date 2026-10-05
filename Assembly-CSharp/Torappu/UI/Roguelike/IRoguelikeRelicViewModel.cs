using System;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051D5 RID: 20949
	[Token(Token = "0x20051D5")]
	public interface IRoguelikeRelicViewModel
	{
		// Token: 0x0601EF05 RID: 126725
		[Token(Token = "0x601EF05")]
		string GetItemId();

		// Token: 0x0601EF06 RID: 126726
		[Token(Token = "0x601EF06")]
		string GetId();

		// Token: 0x0601EF07 RID: 126727
		[Token(Token = "0x601EF07")]
		RoguelikeMenuRelicItemType GetRelicItemType();
	}
}
