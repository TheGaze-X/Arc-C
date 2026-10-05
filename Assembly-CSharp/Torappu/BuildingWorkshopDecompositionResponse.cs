using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000651 RID: 1617
	[Token(Token = "0x2000651")]
	public class BuildingWorkshopDecompositionResponse : PlayerDeltaResponse
	{
		// Token: 0x0600627F RID: 25215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600627F")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public BuildingWorkshopDecompositionResponse()
		{
		}

		// Token: 0x04002E08 RID: 11784
		[Token(Token = "0x4002E08")]
		[FieldOffset(Offset = "0x28")]
		public ItemBundle results;
	}
}
