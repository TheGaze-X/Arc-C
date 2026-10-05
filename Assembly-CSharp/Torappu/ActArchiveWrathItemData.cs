using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C50 RID: 3152
	[Token(Token = "0x2000C50")]
	public class ActArchiveWrathItemData
	{
		// Token: 0x06006934 RID: 26932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006934")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActArchiveWrathItemData()
		{
		}

		// Token: 0x04004032 RID: 16434
		[Token(Token = "0x4004032")]
		[FieldOffset(Offset = "0x10")]
		public string wrathId;

		// Token: 0x04004033 RID: 16435
		[Token(Token = "0x4004033")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04004034 RID: 16436
		[Token(Token = "0x4004034")]
		[FieldOffset(Offset = "0x20")]
		public string picTitleId;

		// Token: 0x04004035 RID: 16437
		[Token(Token = "0x4004035")]
		[FieldOffset(Offset = "0x28")]
		public string picSmallInactiveId;

		// Token: 0x04004036 RID: 16438
		[Token(Token = "0x4004036")]
		[FieldOffset(Offset = "0x30")]
		public string picSmallActiveId;

		// Token: 0x04004037 RID: 16439
		[Token(Token = "0x4004037")]
		[FieldOffset(Offset = "0x38")]
		public string picBigActiveId;

		// Token: 0x04004038 RID: 16440
		[Token(Token = "0x4004038")]
		[FieldOffset(Offset = "0x40")]
		public string picBigInactiveId;

		// Token: 0x04004039 RID: 16441
		[Token(Token = "0x4004039")]
		[FieldOffset(Offset = "0x48")]
		public string enrollId;

		// Token: 0x0400403A RID: 16442
		[Token(Token = "0x400403A")]
		[FieldOffset(Offset = "0x50")]
		public bool isSp;
	}
}
