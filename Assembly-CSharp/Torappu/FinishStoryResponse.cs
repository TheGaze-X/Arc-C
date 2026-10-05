using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000714 RID: 1812
	[Token(Token = "0x2000714")]
	public class FinishStoryResponse : PlayerDeltaResponse
	{
		// Token: 0x06006385 RID: 25477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006385")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public FinishStoryResponse()
		{
		}

		// Token: 0x04002F55 RID: 12117
		[Token(Token = "0x4002F55")]
		[FieldOffset(Offset = "0x28")]
		public ItemBundle[] items;
	}
}
