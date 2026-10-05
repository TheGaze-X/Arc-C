using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI
{
	// Token: 0x02001B0F RID: 6927
	[Token(Token = "0x2001B0F")]
	public class StationSelectRoomStatusModel
	{
		// Token: 0x0600AE90 RID: 44688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE90")]
		[Address(RVA = "0x329E150", Offset = "0x329CD50", VA = "0x18329E150")]
		public void LoadData(RoomSlotModel roomSlotModel)
		{
		}

		// Token: 0x0600AE91 RID: 44689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE91")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StationSelectRoomStatusModel()
		{
		}

		// Token: 0x0400A75B RID: 42843
		[Token(Token = "0x400A75B")]
		[FieldOffset(Offset = "0x10")]
		public string selectedSlotId;
	}
}
