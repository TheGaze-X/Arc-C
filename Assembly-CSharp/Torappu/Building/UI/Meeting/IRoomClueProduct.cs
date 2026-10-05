using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D0E RID: 7438
	[Token(Token = "0x2001D0E")]
	public interface IRoomClueProduct : IHotfixable
	{
		// Token: 0x17001612 RID: 5650
		// (get) Token: 0x0600B798 RID: 47000
		[Token(Token = "0x17001612")]
		IMeetingClue clue { [Token(Token = "0x600B798")] get; }

		// Token: 0x17001613 RID: 5651
		// (get) Token: 0x0600B799 RID: 47001
		[Token(Token = "0x17001613")]
		int creditPerClue { [Token(Token = "0x600B799")] get; }
	}
}
