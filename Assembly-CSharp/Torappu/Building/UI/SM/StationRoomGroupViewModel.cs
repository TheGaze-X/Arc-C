using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001CAB RID: 7339
	[Token(Token = "0x2001CAB")]
	public class StationRoomGroupViewModel
	{
		// Token: 0x0600B5ED RID: 46573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5ED")]
		[Address(RVA = "0x331AB90", Offset = "0x3319790", VA = "0x18331AB90")]
		public StationRoomGroupViewModel()
		{
		}

		// Token: 0x0400B28E RID: 45710
		[Token(Token = "0x400B28E")]
		[FieldOffset(Offset = "0x10")]
		public BuildingData.RoomType roomType;

		// Token: 0x0400B28F RID: 45711
		[Token(Token = "0x400B28F")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x0400B290 RID: 45712
		[Token(Token = "0x400B290")]
		[FieldOffset(Offset = "0x20")]
		public string selectedSlotId;

		// Token: 0x0400B291 RID: 45713
		[Token(Token = "0x400B291")]
		[FieldOffset(Offset = "0x28")]
		public string animSlotId;

		// Token: 0x0400B292 RID: 45714
		[Token(Token = "0x400B292")]
		[FieldOffset(Offset = "0x30")]
		public int sortId;

		// Token: 0x0400B293 RID: 45715
		[Token(Token = "0x400B293")]
		[FieldOffset(Offset = "0x34")]
		public bool isEditDormLock;

		// Token: 0x0400B294 RID: 45716
		[Token(Token = "0x400B294")]
		[FieldOffset(Offset = "0x38")]
		public List<StationRoomStructModel> rooms;
	}
}
