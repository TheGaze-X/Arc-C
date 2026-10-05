using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007219 RID: 29209
	[Token(Token = "0x2007219")]
	public class Act5D1BuyRuneRequest
	{
		// Token: 0x06029694 RID: 169620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029694")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act5D1BuyRuneRequest()
		{
		}

		// Token: 0x0403B232 RID: 242226
		[Token(Token = "0x403B232")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x0403B233 RID: 242227
		[Token(Token = "0x403B233")]
		[FieldOffset(Offset = "0x18")]
		public string runeId;

		// Token: 0x0403B234 RID: 242228
		[Token(Token = "0x403B234")]
		[FieldOffset(Offset = "0x20")]
		public string activityId;
	}
}
