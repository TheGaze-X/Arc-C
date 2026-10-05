using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006EA8 RID: 28328
	[Token(Token = "0x2006EA8")]
	public class VecBreakV2ChangeBuffRequest
	{
		// Token: 0x060284CE RID: 165070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60284CE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public VecBreakV2ChangeBuffRequest()
		{
		}

		// Token: 0x04039466 RID: 234598
		[Token(Token = "0x4039466")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x04039467 RID: 234599
		[Token(Token = "0x4039467")]
		[FieldOffset(Offset = "0x18")]
		public List<string> buffList;
	}
}
