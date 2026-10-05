using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000A3B RID: 2619
	[Token(Token = "0x2000A3B")]
	public class PlayerBuildingRoomSlot
	{
		// Token: 0x060066FA RID: 26362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066FA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerBuildingRoomSlot()
		{
		}

		// Token: 0x04003810 RID: 14352
		[Token(Token = "0x4003810")]
		[FieldOffset(Offset = "0x10")]
		public int level;

		// Token: 0x04003811 RID: 14353
		[Token(Token = "0x4003811")]
		[FieldOffset(Offset = "0x14")]
		public PlayerRoomSlotState state;

		// Token: 0x04003812 RID: 14354
		[Token(Token = "0x4003812")]
		[FieldOffset(Offset = "0x18")]
		[JsonConverter(typeof(StringEnumConverter))]
		public BuildingData.RoomType roomId;

		// Token: 0x04003813 RID: 14355
		[Token(Token = "0x4003813")]
		[FieldOffset(Offset = "0x20")]
		public int[] charInstIds;

		// Token: 0x04003814 RID: 14356
		[Token(Token = "0x4003814")]
		[FieldOffset(Offset = "0x28")]
		public DateTime completeConstructTime;
	}
}
