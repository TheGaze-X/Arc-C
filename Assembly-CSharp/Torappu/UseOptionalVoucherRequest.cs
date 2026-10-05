using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000793 RID: 1939
	[Token(Token = "0x2000793")]
	public class UseOptionalVoucherRequest
	{
		// Token: 0x06006413 RID: 25619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006413")]
		[Address(RVA = "0x1F04820", Offset = "0x1F03420", VA = "0x181F04820")]
		public UseOptionalVoucherRequest()
		{
		}

		// Token: 0x04003064 RID: 12388
		[Token(Token = "0x4003064")]
		[FieldOffset(Offset = "0x10")]
		public string instId;

		// Token: 0x04003065 RID: 12389
		[Token(Token = "0x4003065")]
		[FieldOffset(Offset = "0x18")]
		public string itemId;

		// Token: 0x04003066 RID: 12390
		[Token(Token = "0x4003066")]
		[FieldOffset(Offset = "0x20")]
		public List<OptionalChoiceItem> choices;

		// Token: 0x04003067 RID: 12391
		[Token(Token = "0x4003067")]
		[FieldOffset(Offset = "0x28")]
		public int voucherCount;
	}
}
