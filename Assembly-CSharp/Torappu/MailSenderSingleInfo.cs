using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001009 RID: 4105
	[Token(Token = "0x2001009")]
	public class MailSenderSingleInfo
	{
		// Token: 0x06006D60 RID: 28000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D60")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MailSenderSingleInfo()
		{
		}

		// Token: 0x04005710 RID: 22288
		[Token(Token = "0x4005710")]
		[FieldOffset(Offset = "0x10")]
		public string senderId;

		// Token: 0x04005711 RID: 22289
		[Token(Token = "0x4005711")]
		[FieldOffset(Offset = "0x18")]
		public string senderName;

		// Token: 0x04005712 RID: 22290
		[Token(Token = "0x4005712")]
		[FieldOffset(Offset = "0x20")]
		public string avatarId;
	}
}
