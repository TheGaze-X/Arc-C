using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020010AD RID: 4269
	[Token(Token = "0x20010AD")]
	[Serializable]
	public class ServerItemReminderMailData
	{
		// Token: 0x06006E37 RID: 28215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E37")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ServerItemReminderMailData()
		{
		}

		// Token: 0x04005B77 RID: 23415
		[Token(Token = "0x4005B77")]
		[FieldOffset(Offset = "0x10")]
		public string sender;

		// Token: 0x04005B78 RID: 23416
		[Token(Token = "0x4005B78")]
		[FieldOffset(Offset = "0x18")]
		public string title;

		// Token: 0x04005B79 RID: 23417
		[Token(Token = "0x4005B79")]
		[FieldOffset(Offset = "0x20")]
		public string content;
	}
}
