using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020007A7 RID: 1959
	[Token(Token = "0x20007A7")]
	public class MailMetaInfo
	{
		// Token: 0x06006425 RID: 25637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006425")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MailMetaInfo()
		{
		}

		// Token: 0x04003092 RID: 12434
		[Token(Token = "0x4003092")]
		[FieldOffset(Offset = "0x10")]
		public long mailId;

		// Token: 0x04003093 RID: 12435
		[Token(Token = "0x4003093")]
		[FieldOffset(Offset = "0x18")]
		public string surveyMailId;

		// Token: 0x04003094 RID: 12436
		[Token(Token = "0x4003094")]
		[FieldOffset(Offset = "0x20")]
		public MailState state;

		// Token: 0x04003095 RID: 12437
		[Token(Token = "0x4003095")]
		[FieldOffset(Offset = "0x28")]
		public DateTime createTime;

		// Token: 0x04003096 RID: 12438
		[Token(Token = "0x4003096")]
		[FieldOffset(Offset = "0x30")]
		public bool hasItem;

		// Token: 0x04003097 RID: 12439
		[Token(Token = "0x4003097")]
		[FieldOffset(Offset = "0x34")]
		public MailFromInfo type;
	}
}
