using System;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike.TotemBuff
{
	// Token: 0x02005562 RID: 21858
	[Token(Token = "0x2005562")]
	public interface IRoguelikeTotemBuffViewModel : IHotfixable
	{
		// Token: 0x0602020B RID: 131595
		[Token(Token = "0x602020B")]
		void LoadData(string topicId, bool isOpenDirectFromDungeon);

		// Token: 0x0602020C RID: 131596
		[Token(Token = "0x602020C")]
		bool CheckIfShowMenuBottomBar();
	}
}
