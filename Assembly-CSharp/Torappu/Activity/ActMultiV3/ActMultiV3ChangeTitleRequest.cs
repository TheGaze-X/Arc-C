using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006EE5 RID: 28389
	[Token(Token = "0x2006EE5")]
	public class ActMultiV3ChangeTitleRequest
	{
		// Token: 0x0602856B RID: 165227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602856B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3ChangeTitleRequest()
		{
		}

		// Token: 0x0403956D RID: 234861
		[Token(Token = "0x403956D")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403956E RID: 234862
		[Token(Token = "0x403956E")]
		[FieldOffset(Offset = "0x18")]
		public List<string> select;
	}
}
