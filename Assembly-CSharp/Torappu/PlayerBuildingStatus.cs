using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A37 RID: 2615
	[Token(Token = "0x2000A37")]
	public class PlayerBuildingStatus
	{
		// Token: 0x060066F5 RID: 26357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066F5")]
		[Address(RVA = "0x1EF2030", Offset = "0x1EF0C30", VA = "0x181EF2030")]
		public PlayerBuildingStatus()
		{
		}

		// Token: 0x04003802 RID: 14338
		[Token(Token = "0x4003802")]
		[FieldOffset(Offset = "0x10")]
		public PlayerBuildingLabor labor;

		// Token: 0x04003803 RID: 14339
		[Token(Token = "0x4003803")]
		[FieldOffset(Offset = "0x18")]
		public PlayerBuildingWorkshopStatus workshop;
	}
}
