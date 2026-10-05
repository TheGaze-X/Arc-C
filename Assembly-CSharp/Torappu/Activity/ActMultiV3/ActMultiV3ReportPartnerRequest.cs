using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006EBB RID: 28347
	[Token(Token = "0x2006EBB")]
	public class ActMultiV3ReportPartnerRequest
	{
		// Token: 0x06028534 RID: 165172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028534")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3ReportPartnerRequest()
		{
		}

		// Token: 0x04039500 RID: 234752
		[Token(Token = "0x4039500")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x04039501 RID: 234753
		[Token(Token = "0x4039501")]
		[FieldOffset(Offset = "0x18")]
		public List<string> reasons;
	}
}
