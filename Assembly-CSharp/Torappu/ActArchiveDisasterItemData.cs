using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C33 RID: 3123
	[Token(Token = "0x2000C33")]
	public class ActArchiveDisasterItemData
	{
		// Token: 0x06006911 RID: 26897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006911")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActArchiveDisasterItemData()
		{
		}

		// Token: 0x04003FDA RID: 16346
		[Token(Token = "0x4003FDA")]
		[FieldOffset(Offset = "0x10")]
		public string disasterId;

		// Token: 0x04003FDB RID: 16347
		[Token(Token = "0x4003FDB")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04003FDC RID: 16348
		[Token(Token = "0x4003FDC")]
		[FieldOffset(Offset = "0x20")]
		public string enrollConditionId;

		// Token: 0x04003FDD RID: 16349
		[Token(Token = "0x4003FDD")]
		[FieldOffset(Offset = "0x28")]
		public string picSmallId;

		// Token: 0x04003FDE RID: 16350
		[Token(Token = "0x4003FDE")]
		[FieldOffset(Offset = "0x30")]
		public string picBigActiveId;

		// Token: 0x04003FDF RID: 16351
		[Token(Token = "0x4003FDF")]
		[FieldOffset(Offset = "0x38")]
		public string picBigInactiveId;
	}
}
