using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E95 RID: 28309
	[Token(Token = "0x2006E95")]
	public class VecBreakV2SeasonRecordResponse : PlayerDeltaResponse
	{
		// Token: 0x060284AF RID: 165039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60284AF")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public VecBreakV2SeasonRecordResponse()
		{
		}

		// Token: 0x04039435 RID: 234549
		[Token(Token = "0x4039435")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, VecBreakV2SeasonAchvInfo> seasons;
	}
}
