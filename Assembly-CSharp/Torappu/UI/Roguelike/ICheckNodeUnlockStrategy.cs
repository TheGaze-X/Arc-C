using System;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005241 RID: 21057
	[Token(Token = "0x2005241")]
	public interface ICheckNodeUnlockStrategy
	{
		// Token: 0x170048AB RID: 18603
		// (get) Token: 0x0601F12B RID: 127275
		[Token(Token = "0x170048AB")]
		int priority { [Token(Token = "0x601F12B")] get; }

		// Token: 0x0601F12C RID: 127276
		[Token(Token = "0x601F12C")]
		bool CanHandle(string topicId, RoguelikeTopicDetail detail);

		// Token: 0x0601F12D RID: 127277
		[Token(Token = "0x601F12D")]
		void Execute(string topicId, UIPage page, Action onSuccess);
	}
}
