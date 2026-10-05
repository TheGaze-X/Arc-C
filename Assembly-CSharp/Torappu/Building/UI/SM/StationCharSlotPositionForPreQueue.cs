using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001CAF RID: 7343
	[Token(Token = "0x2001CAF")]
	public class StationCharSlotPositionForPreQueue
	{
		// Token: 0x0600B5F5 RID: 46581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5F5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StationCharSlotPositionForPreQueue()
		{
		}

		// Token: 0x0400B2AF RID: 45743
		[Token(Token = "0x400B2AF")]
		[FieldOffset(Offset = "0x10")]
		public string roomSlotId;

		// Token: 0x0400B2B0 RID: 45744
		[Token(Token = "0x400B2B0")]
		[FieldOffset(Offset = "0x18")]
		public int preQueueIndex;
	}
}
