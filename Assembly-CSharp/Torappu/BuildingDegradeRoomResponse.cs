using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000623 RID: 1571
	[Token(Token = "0x2000623")]
	public class BuildingDegradeRoomResponse : PlayerDeltaResponse
	{
		// Token: 0x06006251 RID: 25169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006251")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public BuildingDegradeRoomResponse()
		{
		}

		// Token: 0x04002DAC RID: 11692
		[Token(Token = "0x4002DAC")]
		[FieldOffset(Offset = "0x28")]
		public List<ItemBundle> payback;
	}
}
