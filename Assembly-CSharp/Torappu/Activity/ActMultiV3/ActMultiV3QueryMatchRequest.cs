using System;
using Il2CppDummyDll;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006EE2 RID: 28386
	[Token(Token = "0x2006EE2")]
	public class ActMultiV3QueryMatchRequest
	{
		// Token: 0x06028569 RID: 165225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028569")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3QueryMatchRequest()
		{
		}

		// Token: 0x04039565 RID: 234853
		[Token(Token = "0x4039565")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x04039566 RID: 234854
		[Token(Token = "0x4039566")]
		[FieldOffset(Offset = "0x18")]
		public int needLeave;
	}
}
