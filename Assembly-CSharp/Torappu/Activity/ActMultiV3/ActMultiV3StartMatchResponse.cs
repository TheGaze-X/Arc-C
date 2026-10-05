using System;
using Il2CppDummyDll;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006EE0 RID: 28384
	[Token(Token = "0x2006EE0")]
	public class ActMultiV3StartMatchResponse : PlayerDeltaResponse
	{
		// Token: 0x06028568 RID: 165224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028568")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ActMultiV3StartMatchResponse()
		{
		}

		// Token: 0x0403955F RID: 234847
		[Token(Token = "0x403955F")]
		[FieldOffset(Offset = "0x28")]
		public ActMultiV3StartMatchResponse.StartMatchResultType result;

		// Token: 0x02006EE1 RID: 28385
		[Token(Token = "0x2006EE1")]
		public enum StartMatchResultType
		{
			// Token: 0x04039561 RID: 234849
			[Token(Token = "0x4039561")]
			OK,
			// Token: 0x04039562 RID: 234850
			[Token(Token = "0x4039562")]
			TOO_FAST,
			// Token: 0x04039563 RID: 234851
			[Token(Token = "0x4039563")]
			BAN,
			// Token: 0x04039564 RID: 234852
			[Token(Token = "0x4039564")]
			SERVER_OVERLOAD
		}
	}
}
