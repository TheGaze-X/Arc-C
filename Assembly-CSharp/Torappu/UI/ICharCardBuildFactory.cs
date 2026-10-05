using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x0200359F RID: 13727
	[Token(Token = "0x200359F")]
	public interface ICharCardBuildFactory<TChar> : IHotfixable where TChar : class, ICharacterCardViewModel, new()
	{
		// Token: 0x1700342B RID: 13355
		// (get) Token: 0x06015D4F RID: 89423
		[Token(Token = "0x1700342B")]
		bool isEmpty { [Token(Token = "0x6015D4F")] get; }

		// Token: 0x06015D50 RID: 89424
		[Token(Token = "0x6015D50")]
		void BuildTo(TChar targetChar);

		// Token: 0x06015D51 RID: 89425
		[Token(Token = "0x6015D51")]
		TChar BuildNew();
	}
}
