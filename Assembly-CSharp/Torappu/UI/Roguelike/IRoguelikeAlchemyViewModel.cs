using System;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200519B RID: 20891
	[Token(Token = "0x200519B")]
	public interface IRoguelikeAlchemyViewModel : IHotfixable
	{
		// Token: 0x0601EDCA RID: 126410
		[Token(Token = "0x601EDCA")]
		void LoadData(string topicId);

		// Token: 0x0601EDCB RID: 126411
		[Token(Token = "0x601EDCB")]
		bool CheckIfShowMenuStatusBar();

		// Token: 0x0601EDCC RID: 126412
		[Token(Token = "0x601EDCC")]
		bool CheckIfShowMenuBottomBar();
	}
}
