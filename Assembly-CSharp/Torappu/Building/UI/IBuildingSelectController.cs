using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Building.UI.StationSelect;

namespace Torappu.Building.UI
{
	// Token: 0x02001BAD RID: 7085
	[Token(Token = "0x2001BAD")]
	public interface IBuildingSelectController
	{
		// Token: 0x0600B0A7 RID: 45223
		[Token(Token = "0x600B0A7")]
		List<int> GetTempListForExclusiveInstIds();

		// Token: 0x0600B0A8 RID: 45224
		[Token(Token = "0x600B0A8")]
		StationCharViewModel GetCharSelectMutuallyExclusiveInfo(int instId, StationSelectStateBean stationSelectBean);

		// Token: 0x0600B0A9 RID: 45225
		[Token(Token = "0x600B0A9")]
		bool CheckIfCharValid(int instId);
	}
}
