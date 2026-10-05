using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020010DD RID: 4317
	[Token(Token = "0x20010DD")]
	public class LongTermCheckInConstData
	{
		// Token: 0x06006E81 RID: 28289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E81")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LongTermCheckInConstData()
		{
		}

		// Token: 0x04005C7F RID: 23679
		[Token(Token = "0x4005C7F")]
		[FieldOffset(Offset = "0x10")]
		public long startTs;

		// Token: 0x04005C80 RID: 23680
		[Token(Token = "0x4005C80")]
		[FieldOffset(Offset = "0x18")]
		public string detailTitle;

		// Token: 0x04005C81 RID: 23681
		[Token(Token = "0x4005C81")]
		[FieldOffset(Offset = "0x20")]
		public string detailDesc;
	}
}
