using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x0200733F RID: 29503
	[Token(Token = "0x200733F")]
	public class Act42D0RecvMilestoneRequest
	{
		// Token: 0x06029BAD RID: 170925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029BAD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act42D0RecvMilestoneRequest()
		{
		}

		// Token: 0x0403BBB0 RID: 244656
		[Token(Token = "0x403BBB0")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0403BBB1 RID: 244657
		[Token(Token = "0x403BBB1")]
		[FieldOffset(Offset = "0x18")]
		public List<string> milestones;
	}
}
