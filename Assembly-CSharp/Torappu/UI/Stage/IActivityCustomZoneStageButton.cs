using System;
using Il2CppDummyDll;

namespace Torappu.UI.Stage
{
	// Token: 0x020068D9 RID: 26841
	[Token(Token = "0x20068D9")]
	public interface IActivityCustomZoneStageButton : IHotfixable
	{
		// Token: 0x17005AD5 RID: 23253
		// (get) Token: 0x06026752 RID: 157522
		// (set) Token: 0x06026753 RID: 157523
		[Token(Token = "0x17005AD5")]
		string stageId { [Token(Token = "0x6026752")] get; [Token(Token = "0x6026753")] set; }

		// Token: 0x06026754 RID: 157524
		[Token(Token = "0x6026754")]
		void Render(ActivityCustomZoneMapViewModel zoneModel, StageViewModel stageViewModel, bool isSelected, bool isFastMode);
	}
}
