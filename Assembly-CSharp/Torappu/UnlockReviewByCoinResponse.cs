using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008BF RID: 2239
	[Token(Token = "0x20008BF")]
	public class UnlockReviewByCoinResponse : PlayerDeltaResponse
	{
		// Token: 0x06006571 RID: 25969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006571")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public UnlockReviewByCoinResponse()
		{
		}

		// Token: 0x040032B1 RID: 12977
		[Token(Token = "0x40032B1")]
		[FieldOffset(Offset = "0x28")]
		public long unlockTs;
	}
}
