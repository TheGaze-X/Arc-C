using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001007 RID: 4103
	[Token(Token = "0x2001007")]
	public class MailArchiveData
	{
		// Token: 0x06006D5E RID: 27998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D5E")]
		[Address(RVA = "0x2107140", Offset = "0x2105D40", VA = "0x182107140")]
		public MailArchiveData()
		{
		}

		// Token: 0x0400570D RID: 22285
		[Token(Token = "0x400570D")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, MailArchiveItemData> mailArchiveInfoDict;

		// Token: 0x0400570E RID: 22286
		[Token(Token = "0x400570E")]
		[FieldOffset(Offset = "0x18")]
		public MailArchiveConstData constData;
	}
}
