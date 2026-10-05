using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000622 RID: 1570
	[Token(Token = "0x2000622")]
	public class BuildingDegradeRoomRequest : BuildingRequest
	{
		// Token: 0x06006250 RID: 25168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006250")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingDegradeRoomRequest()
		{
		}

		// Token: 0x04002DAA RID: 11690
		[Token(Token = "0x4002DAA")]
		[FieldOffset(Offset = "0x10")]
		public string roomSlotId;

		// Token: 0x04002DAB RID: 11691
		[Token(Token = "0x4002DAB")]
		[FieldOffset(Offset = "0x18")]
		public int targetLevel;
	}
}
