using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004040 RID: 16448
	[Token(Token = "0x2004040")]
	public interface SandboxV2SelectPluginLogic : IHotfixable
	{
		// Token: 0x06019736 RID: 104246
		[Token(Token = "0x6019736")]
		void OnEnsure(SandboxV2CharListProperty property, Action onEnsure, Action dismissAction);

		// Token: 0x06019737 RID: 104247
		[Token(Token = "0x6019737")]
		void HandlerClick(int instId, SandboxV2CharListProperty property);

		// Token: 0x06019738 RID: 104248
		[Token(Token = "0x6019738")]
		bool ShuffleChar(SandboxV2CharViewModel viewModel, SandboxV2ShuffleViewModel shuffleViewModel);

		// Token: 0x06019739 RID: 104249
		[Token(Token = "0x6019739")]
		bool IfShowIndex();

		// Token: 0x0601973A RID: 104250
		[Token(Token = "0x601973A")]
		int SortRule(SandboxV2CharViewModel obj1, SandboxV2CharViewModel obj2);

		// Token: 0x0601973B RID: 104251
		[Token(Token = "0x601973B")]
		bool IfFetchPlayerChar();

		// Token: 0x0601973C RID: 104252
		[Token(Token = "0x601973C")]
		void InitShuffleViewModel(SandboxV2ShuffleViewModel shuffleViewModel);
	}
}
