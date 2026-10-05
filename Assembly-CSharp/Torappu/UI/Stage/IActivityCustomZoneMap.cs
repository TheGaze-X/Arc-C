using System;
using Il2CppDummyDll;

namespace Torappu.UI.Stage
{
	// Token: 0x020068D3 RID: 26835
	[Token(Token = "0x20068D3")]
	public interface IActivityCustomZoneMap : IHotfixable
	{
		// Token: 0x06026740 RID: 157504
		[Token(Token = "0x6026740")]
		void Render(ActivityCustomZoneMapViewModel model, bool isFastMode);

		// Token: 0x17005AD2 RID: 23250
		// (get) Token: 0x06026741 RID: 157505
		[Token(Token = "0x17005AD2")]
		ActivityCustomZoneStageButton[] stageButtons { [Token(Token = "0x6026741")] get; }
	}
}
