using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020007A4 RID: 1956
	[Token(Token = "0x20007A4")]
	public class ListMailBoxRequest : ListMailBoxCommonRequest
	{
		// Token: 0x06006424 RID: 25636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006424")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ListMailBoxRequest()
		{
		}

		// Token: 0x04003089 RID: 12425
		[Token(Token = "0x4003089")]
		[FieldOffset(Offset = "0x18")]
		public List<long> sysMailIdList;

		// Token: 0x0400308A RID: 12426
		[Token(Token = "0x400308A")]
		[FieldOffset(Offset = "0x20")]
		public List<string> surveyMailIdList;
	}
}
