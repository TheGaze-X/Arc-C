using System;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005383 RID: 21379
	[Token(Token = "0x2005383")]
	public interface IRoguelikeScrollReportDisplayItemModel : IHotfixable
	{
		// Token: 0x0601F836 RID: 129078
		[Token(Token = "0x601F836")]
		EndingReportDisplayItem CreateDisplayItem(RoguelikeScrollReportEndingFrameViewModel frameViewModel);
	}
}
