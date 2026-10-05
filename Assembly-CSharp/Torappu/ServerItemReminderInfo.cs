using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020010AC RID: 4268
	[Token(Token = "0x20010AC")]
	[Serializable]
	public class ServerItemReminderInfo
	{
		// Token: 0x06006E36 RID: 28214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E36")]
		[Address(RVA = "0x2114F00", Offset = "0x2113B00", VA = "0x182114F00")]
		public ServerItemReminderInfo()
		{
		}

		// Token: 0x04005B75 RID: 23413
		[Token(Token = "0x4005B75")]
		[FieldOffset(Offset = "0x10")]
		public List<string> paidItemIdList;

		// Token: 0x04005B76 RID: 23414
		[Token(Token = "0x4005B76")]
		[FieldOffset(Offset = "0x18")]
		public ServerItemReminderMailData paidReminderMail;
	}
}
