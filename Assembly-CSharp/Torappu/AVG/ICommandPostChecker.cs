using System;
using Il2CppDummyDll;

namespace Torappu.AVG
{
	// Token: 0x02001E71 RID: 7793
	[Token(Token = "0x2001E71")]
	public interface ICommandPostChecker : IHotfixable
	{
		// Token: 0x17001738 RID: 5944
		// (get) Token: 0x0600C12B RID: 49451
		[Token(Token = "0x17001738")]
		string cmdName { [Token(Token = "0x600C12B")] get; }

		// Token: 0x0600C12C RID: 49452
		[Token(Token = "0x600C12C")]
		void PostCheck(bool isTutorial, Command command);

		// Token: 0x0600C12D RID: 49453
		[Token(Token = "0x600C12D")]
		void OnCommandFinished(bool isTutorial, Command command);

		// Token: 0x0600C12E RID: 49454
		[Token(Token = "0x600C12E")]
		void OnStorySkipped(bool isTutorial);
	}
}
