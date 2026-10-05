using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C4E RID: 3150
	[Token(Token = "0x2000C4E")]
	public class ActArchiveTrapItemData
	{
		// Token: 0x06006932 RID: 26930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006932")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActArchiveTrapItemData()
		{
		}

		// Token: 0x0400402D RID: 16429
		[Token(Token = "0x400402D")]
		[FieldOffset(Offset = "0x10")]
		public string trapId;

		// Token: 0x0400402E RID: 16430
		[Token(Token = "0x400402E")]
		[FieldOffset(Offset = "0x18")]
		public int trapSortId;

		// Token: 0x0400402F RID: 16431
		[Token(Token = "0x400402F")]
		[FieldOffset(Offset = "0x20")]
		public string orderId;

		// Token: 0x04004030 RID: 16432
		[Token(Token = "0x4004030")]
		[FieldOffset(Offset = "0x28")]
		public string enrollId;
	}
}
