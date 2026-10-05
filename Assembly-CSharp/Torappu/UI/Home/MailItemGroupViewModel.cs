using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Home
{
	// Token: 0x02004BAD RID: 19373
	[Token(Token = "0x2004BAD")]
	public class MailItemGroupViewModel
	{
		// Token: 0x0601D20D RID: 119309 RVA: 0x000AA9B8 File Offset: 0x000A8BB8
		[Token(Token = "0x601D20D")]
		[Address(RVA = "0x16AAC50", Offset = "0x16A9850", VA = "0x1816AAC50")]
		public int CalcUnreadMailCount()
		{
			return 0;
		}

		// Token: 0x0601D20E RID: 119310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D20E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MailItemGroupViewModel()
		{
		}

		// Token: 0x04026391 RID: 156561
		[Token(Token = "0x4026391")]
		[FieldOffset(Offset = "0x10")]
		public int dataIndex;

		// Token: 0x04026392 RID: 156562
		[Token(Token = "0x4026392")]
		[FieldOffset(Offset = "0x18")]
		public List<MailItemViewModel> mails;

		// Token: 0x04026393 RID: 156563
		[Token(Token = "0x4026393")]
		[FieldOffset(Offset = "0x20")]
		public List<MailMetaInfo> metaList;

		// Token: 0x04026394 RID: 156564
		[Token(Token = "0x4026394")]
		[FieldOffset(Offset = "0x28")]
		public int sequenceNum;
	}
}
