using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x02007148 RID: 29000
	[Token(Token = "0x2007148")]
	public class Act9D0ReadNewsRequest
	{
		// Token: 0x060292B7 RID: 168631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292B7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act9D0ReadNewsRequest()
		{
		}

		// Token: 0x0403ACAC RID: 240812
		[Token(Token = "0x403ACAC")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403ACAD RID: 240813
		[Token(Token = "0x403ACAD")]
		[FieldOffset(Offset = "0x18")]
		public string[] newsIds;
	}
}
