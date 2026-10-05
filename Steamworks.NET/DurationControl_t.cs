using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000E6 RID: 230
	[Token(Token = "0x20000E6")]
	[CallbackIdentity(167)]
	public struct DurationControl_t
	{
		// Token: 0x040002C5 RID: 709
		[Token(Token = "0x40002C5")]
		public const int k_iCallback = 167;

		// Token: 0x040002C6 RID: 710
		[Token(Token = "0x40002C6")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x040002C7 RID: 711
		[Token(Token = "0x40002C7")]
		[FieldOffset(Offset = "0x4")]
		public AppId_t m_appid;

		// Token: 0x040002C8 RID: 712
		[Token(Token = "0x40002C8")]
		[FieldOffset(Offset = "0x8")]
		public bool m_bApplicable;

		// Token: 0x040002C9 RID: 713
		[Token(Token = "0x40002C9")]
		[FieldOffset(Offset = "0xC")]
		public int m_csecsLast5h;

		// Token: 0x040002CA RID: 714
		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x10")]
		public EDurationControlProgress m_progress;

		// Token: 0x040002CB RID: 715
		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x14")]
		public EDurationControlNotification m_notification;

		// Token: 0x040002CC RID: 716
		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x18")]
		public int m_csecsToday;

		// Token: 0x040002CD RID: 717
		[Token(Token = "0x40002CD")]
		[FieldOffset(Offset = "0x1C")]
		public int m_csecsRemaining;
	}
}
