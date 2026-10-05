using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1mainss
{
	// Token: 0x02007841 RID: 30785
	[Token(Token = "0x2007841")]
	public class Act1MainSSGetInfRewardResponse : PlayerDeltaResponse
	{
		// Token: 0x0602B2D5 RID: 176853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2D5")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public Act1MainSSGetInfRewardResponse()
		{
		}

		// Token: 0x0403E6A6 RID: 255654
		[Token(Token = "0x403E6A6")]
		[FieldOffset(Offset = "0x28")]
		public List<ItemGet> reward;
	}
}
