using System;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005217 RID: 21015
	[Token(Token = "0x2005217")]
	public interface IRoguelikeZoneRewardDialogConfig : IHotfixable
	{
		// Token: 0x1700486F RID: 18543
		// (get) Token: 0x0601F033 RID: 127027
		[Token(Token = "0x1700486F")]
		RoguelikeGameItemType showItemType { [Token(Token = "0x601F033")] get; }

		// Token: 0x17004870 RID: 18544
		// (get) Token: 0x0601F034 RID: 127028
		[Token(Token = "0x17004870")]
		DialogType dialogType { [Token(Token = "0x601F034")] get; }

		// Token: 0x17004871 RID: 18545
		// (get) Token: 0x0601F035 RID: 127029
		[Token(Token = "0x17004871")]
		int weight { [Token(Token = "0x601F035")] get; }

		// Token: 0x0601F036 RID: 127030
		[Token(Token = "0x601F036")]
		string GetDialogPath(string topicId);
	}
}
