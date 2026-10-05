using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200064F RID: 1615
	[Token(Token = "0x200064F")]
	public class BuildingWorkshopSynthesisResponse : PlayerDeltaResponse
	{
		// Token: 0x0600627D RID: 25213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600627D")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public BuildingWorkshopSynthesisResponse()
		{
		}

		// Token: 0x04002E03 RID: 11779
		[Token(Token = "0x4002E03")]
		[FieldOffset(Offset = "0x28")]
		public ItemBundle results;

		// Token: 0x04002E04 RID: 11780
		[Token(Token = "0x4002E04")]
		[FieldOffset(Offset = "0x30")]
		public List<ItemBundle> additional;

		// Token: 0x04002E05 RID: 11781
		[Token(Token = "0x4002E05")]
		[FieldOffset(Offset = "0x38")]
		public long recoverCost;
	}
}
