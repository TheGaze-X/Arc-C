using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000750 RID: 1872
	[Token(Token = "0x2000750")]
	public class FinishNormalGachaResponse : PlayerDeltaResponse
	{
		// Token: 0x060063BA RID: 25530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063BA")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public FinishNormalGachaResponse()
		{
		}

		// Token: 0x04002FC1 RID: 12225
		[Token(Token = "0x4002FC1")]
		[FieldOffset(Offset = "0x28")]
		public int result;

		// Token: 0x04002FC2 RID: 12226
		[Token(Token = "0x4002FC2")]
		[FieldOffset(Offset = "0x30")]
		public GachaResult charGet;
	}
}
