using System;
using Il2CppDummyDll;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CCE RID: 27854
	[Token(Token = "0x2006CCE")]
	public interface TemplateActivityMissionPlugin : IHotfixable
	{
		// Token: 0x06027BC3 RID: 162755
		[Token(Token = "0x6027BC3")]
		void ApplyDataBundle(TemplateMissionViewModel missionData);

		// Token: 0x06027BC4 RID: 162756
		[Token(Token = "0x6027BC4")]
		void RenderCoro(Action commonRender);

		// Token: 0x06027BC5 RID: 162757
		[Token(Token = "0x6027BC5")]
		bool IsAvailClick();
	}
}
