using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C45 RID: 3141
	[Token(Token = "0x2000C45")]
	public class ActArchiveRelicItemData
	{
		// Token: 0x06006925 RID: 26917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006925")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActArchiveRelicItemData()
		{
		}

		// Token: 0x04004010 RID: 16400
		[Token(Token = "0x4004010")]
		[FieldOffset(Offset = "0x10")]
		public string relicId;

		// Token: 0x04004011 RID: 16401
		[Token(Token = "0x4004011")]
		[FieldOffset(Offset = "0x18")]
		public int relicSortId;

		// Token: 0x04004012 RID: 16402
		[Token(Token = "0x4004012")]
		[FieldOffset(Offset = "0x1C")]
		public int relicGroupId;

		// Token: 0x04004013 RID: 16403
		[Token(Token = "0x4004013")]
		[FieldOffset(Offset = "0x20")]
		public string orderId;

		// Token: 0x04004014 RID: 16404
		[Token(Token = "0x4004014")]
		[FieldOffset(Offset = "0x28")]
		public bool isSpRelic;

		// Token: 0x04004015 RID: 16405
		[Token(Token = "0x4004015")]
		[FieldOffset(Offset = "0x30")]
		public string enrollId;
	}
}
