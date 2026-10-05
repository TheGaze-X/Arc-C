using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001301 RID: 4865
	[Token(Token = "0x2001301")]
	public class SandboxPermTable
	{
		// Token: 0x0600727F RID: 29311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600727F")]
		[Address(RVA = "0x220E2B0", Offset = "0x220CEB0", VA = "0x18220E2B0")]
		public SandboxPermTable()
		{
		}

		// Token: 0x04006BC8 RID: 27592
		[Token(Token = "0x4006BC8")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, SandboxPermBasicData> basicInfo;

		// Token: 0x04006BC9 RID: 27593
		[Token(Token = "0x4006BC9")]
		[FieldOffset(Offset = "0x18")]
		public SandboxPermDetailData detail;

		// Token: 0x04006BCA RID: 27594
		[Token(Token = "0x4006BCA")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, SandboxPermItemData> itemData;
	}
}
