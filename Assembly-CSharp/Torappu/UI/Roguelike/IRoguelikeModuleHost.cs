using System;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005367 RID: 21351
	[Token(Token = "0x2005367")]
	public interface IRoguelikeModuleHost
	{
		// Token: 0x0601F797 RID: 128919
		[Token(Token = "0x601F797")]
		long GetBGMInstId();

		// Token: 0x170049D4 RID: 18900
		// (get) Token: 0x0601F798 RID: 128920
		[Token(Token = "0x170049D4")]
		string topicId { [Token(Token = "0x601F798")] get; }

		// Token: 0x0601F799 RID: 128921
		[Token(Token = "0x601F799")]
		RoguelikeDungeonPage GetPage();

		// Token: 0x0601F79A RID: 128922
		[Token(Token = "0x601F79A")]
		RoguelikeDungeonController GetController();
	}
}
