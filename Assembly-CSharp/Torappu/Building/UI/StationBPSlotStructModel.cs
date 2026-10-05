using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI
{
	// Token: 0x02001B0E RID: 6926
	[Token(Token = "0x2001B0E")]
	public struct StationBPSlotStructModel
	{
		// Token: 0x0400A755 RID: 42837
		[Token(Token = "0x400A755")]
		[FieldOffset(Offset = "0x0")]
		public string slotId;

		// Token: 0x0400A756 RID: 42838
		[Token(Token = "0x400A756")]
		[FieldOffset(Offset = "0x8")]
		public BuildingData.RoomType roomId;

		// Token: 0x0400A757 RID: 42839
		[Token(Token = "0x400A757")]
		[FieldOffset(Offset = "0xC")]
		public GridPosition offset;

		// Token: 0x0400A758 RID: 42840
		[Token(Token = "0x400A758")]
		[FieldOffset(Offset = "0x14")]
		public GridPosition size;

		// Token: 0x0400A759 RID: 42841
		[Token(Token = "0x400A759")]
		[FieldOffset(Offset = "0x1C")]
		public bool isUnlocked;

		// Token: 0x0400A75A RID: 42842
		[Token(Token = "0x400A75A")]
		[FieldOffset(Offset = "0x1D")]
		public bool isSelected;
	}
}
