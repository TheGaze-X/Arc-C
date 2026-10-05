using System;
using Il2CppDummyDll;

namespace Torappu.UI.Stage
{
	// Token: 0x020068DA RID: 26842
	[Token(Token = "0x20068DA")]
	public interface IActivityCustomZoneStageButtonPlugin : IHotfixable
	{
		// Token: 0x06026755 RID: 157525
		[Token(Token = "0x6026755")]
		void Render(ActivityCustomZoneMapViewModel zoneModel, StageViewModel stageViewModel, bool isSelected, bool isFastMode);
	}
}
