using System;
using Il2CppDummyDll;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003DB3 RID: 15795
	[Token(Token = "0x2003DB3")]
	public interface ITemplateMissionViewModelPlugin : IHotfixable
	{
		// Token: 0x060188EF RID: 100591
		[Token(Token = "0x60188EF")]
		void SetContext(TemplateMissionViewModel viewModel);

		// Token: 0x060188F0 RID: 100592
		[Token(Token = "0x60188F0")]
		int GetShowClaimAllBtnNeedCount();

		// Token: 0x060188F1 RID: 100593
		[Token(Token = "0x60188F1")]
		bool CheckMissionShowAbleFlag(ITemplateMissionListItemViewModel item);

		// Token: 0x060188F2 RID: 100594
		[Token(Token = "0x60188F2")]
		bool Compare(ITemplateMissionListItemViewModel a, ITemplateMissionListItemViewModel b, out int result);
	}
}
