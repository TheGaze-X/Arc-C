using System;
using Il2CppDummyDll;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A63 RID: 27235
	[Token(Token = "0x2006A63")]
	public interface IStageMixStoryStorySetPlugin : IHotfixable
	{
		// Token: 0x06026EC9 RID: 159433
		[Token(Token = "0x6026EC9")]
		bool IsValid(StageStorylineStorySetViewModel model);

		// Token: 0x06026ECA RID: 159434
		[Token(Token = "0x6026ECA")]
		void Render(StageStorylineStorySetViewModel model);
	}
}
