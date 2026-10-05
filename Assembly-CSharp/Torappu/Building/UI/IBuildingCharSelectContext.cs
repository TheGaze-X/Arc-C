using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Building.UI
{
	// Token: 0x02001AF7 RID: 6903
	[Token(Token = "0x2001AF7")]
	public interface IBuildingCharSelectContext
	{
		// Token: 0x1700149F RID: 5279
		// (get) Token: 0x0600AE64 RID: 44644
		[Token(Token = "0x1700149F")]
		bool usePluginWorkingPanel { [Token(Token = "0x600AE64")] get; }

		// Token: 0x170014A0 RID: 5280
		// (get) Token: 0x0600AE65 RID: 44645
		[Token(Token = "0x170014A0")]
		bool usePluginDormLockPanel { [Token(Token = "0x600AE65")] get; }

		// Token: 0x0600AE66 RID: 44646
		[Token(Token = "0x600AE66")]
		List<int> GetTempListForExclusiveInstIds();

		// Token: 0x0600AE67 RID: 44647
		[Token(Token = "0x600AE67")]
		BuildingData.RoomType GetCurrentRoomType();

		// Token: 0x0600AE68 RID: 44648
		[Token(Token = "0x600AE68")]
		bool CheckIfCharValid(int instId);
	}
}
