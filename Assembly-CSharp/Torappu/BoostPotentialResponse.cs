using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x020006B8 RID: 1720
	[Token(Token = "0x20006B8")]
	public class BoostPotentialResponse : PlayerDeltaResponse
	{
		// Token: 0x06006301 RID: 25345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006301")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public BoostPotentialResponse()
		{
		}

		// Token: 0x04002EA7 RID: 11943
		[Token(Token = "0x4002EA7")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("result")]
		public int resultOneSuc;
	}
}
