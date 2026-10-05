using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007217 RID: 29207
	[Token(Token = "0x2007217")]
	public class Act5D1GetDetailRequest
	{
		// Token: 0x06029692 RID: 169618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029692")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act5D1GetDetailRequest()
		{
		}

		// Token: 0x0403B22F RID: 242223
		[Token(Token = "0x403B22F")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403B230 RID: 242224
		[Token(Token = "0x403B230")]
		[FieldOffset(Offset = "0x18")]
		public List<string> keys;
	}
}
