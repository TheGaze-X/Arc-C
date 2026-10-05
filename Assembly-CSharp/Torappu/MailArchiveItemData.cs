using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001005 RID: 4101
	[Token(Token = "0x2001005")]
	public class MailArchiveItemData
	{
		// Token: 0x06006D5C RID: 27996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D5C")]
		[Address(RVA = "0x21071D0", Offset = "0x2105DD0", VA = "0x1821071D0")]
		public MailArchiveItemData()
		{
		}

		// Token: 0x04005702 RID: 22274
		[Token(Token = "0x4005702")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04005703 RID: 22275
		[Token(Token = "0x4005703")]
		[FieldOffset(Offset = "0x18")]
		public MailArchiveItemType type;

		// Token: 0x04005704 RID: 22276
		[Token(Token = "0x4005704")]
		[FieldOffset(Offset = "0x1C")]
		public int sortId;

		// Token: 0x04005705 RID: 22277
		[Token(Token = "0x4005705")]
		[FieldOffset(Offset = "0x20")]
		public long displayReceiveTs;

		// Token: 0x04005706 RID: 22278
		[Token(Token = "0x4005706")]
		[FieldOffset(Offset = "0x28")]
		public int year;

		// Token: 0x04005707 RID: 22279
		[Token(Token = "0x4005707")]
		[FieldOffset(Offset = "0x2C")]
		public int dateDelta;

		// Token: 0x04005708 RID: 22280
		[Token(Token = "0x4005708")]
		[FieldOffset(Offset = "0x30")]
		public string senderId;

		// Token: 0x04005709 RID: 22281
		[Token(Token = "0x4005709")]
		[FieldOffset(Offset = "0x38")]
		public string title;

		// Token: 0x0400570A RID: 22282
		[Token(Token = "0x400570A")]
		[FieldOffset(Offset = "0x40")]
		public string content;

		// Token: 0x0400570B RID: 22283
		[Token(Token = "0x400570B")]
		[FieldOffset(Offset = "0x48")]
		public List<ItemBundle> rewardList;
	}
}
