using System;
using Il2CppDummyDll;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CFC RID: 27900
	[Token(Token = "0x2006CFC")]
	public interface TemplateActivityMissionViewModelPlugin
	{
		// Token: 0x06027C70 RID: 162928
		[Token(Token = "0x6027C70")]
		void SetContext(TemplateActivityMissionGroupViewModel viewModel);

		// Token: 0x06027C71 RID: 162929
		[Token(Token = "0x6027C71")]
		bool CheckMissionShowAbleFlag(int missionIndex);

		// Token: 0x06027C72 RID: 162930
		[Token(Token = "0x6027C72")]
		bool Compare(TemplateMissionViewModel a, TemplateMissionViewModel b, out int result);
	}
}
