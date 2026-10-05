using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008C1 RID: 2241
	[Token(Token = "0x20008C1")]
	public class ReadStoryResponse : PlayerDeltaResponse
	{
		// Token: 0x06006573 RID: 25971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006573")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ReadStoryResponse()
		{
		}

		// Token: 0x040032B3 RID: 12979
		[Token(Token = "0x40032B3")]
		[FieldOffset(Offset = "0x28")]
		public int readCount;
	}
}
