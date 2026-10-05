using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI
{
	// Token: 0x02001B08 RID: 6920
	[Token(Token = "0x2001B08")]
	public interface IBasicRoomGroupModel : IHotfixable
	{
		// Token: 0x0600AE83 RID: 44675
		[Token(Token = "0x600AE83")]
		string GetSelectedSlotId();

		// Token: 0x0600AE84 RID: 44676
		[Token(Token = "0x600AE84")]
		int GetRoomNum();

		// Token: 0x0600AE85 RID: 44677
		[Token(Token = "0x600AE85")]
		BasicRoomInfoModel GetRoomInfo(int index);
	}
}
