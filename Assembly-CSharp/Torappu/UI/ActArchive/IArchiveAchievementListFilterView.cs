using System;
using Il2CppDummyDll;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AE3 RID: 27363
	[Token(Token = "0x2006AE3")]
	public interface IArchiveAchievementListFilterView : IHotfixable
	{
		// Token: 0x17005C81 RID: 23681
		// (set) Token: 0x06027228 RID: 160296
		[Token(Token = "0x17005C81")]
		Action<ArchiveAchievementListFilterViewModel.FilterType, string> onSelectionChange { [Token(Token = "0x6027228")] set; }

		// Token: 0x06027229 RID: 160297
		[Token(Token = "0x6027229")]
		void Render(ArchiveAchievementModel viewModel);
	}
}
