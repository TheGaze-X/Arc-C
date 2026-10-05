using System;
using Il2CppDummyDll;

namespace YoStar.SDK
{
	// Token: 0x02000061 RID: 97
	[Token(Token = "0x2000061")]
	public class InitRet
	{
		// Token: 0x0600023C RID: 572 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public InitRet()
		{
		}

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x10")]
		public int R_CODE;

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x18")]
		public string R_MSG;

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x20")]
		public string SDK_PID;

		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x28")]
		public string LOGIN_UID;

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x30")]
		public string LOGIN_UID_2;

		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x38")]
		public string LOGIN_NAME;

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x40")]
		public LoginPlatform LOGIN_PLATFORM;

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x44")]
		public bool SHOW_LOG;
	}
}
