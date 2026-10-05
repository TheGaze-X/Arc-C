using System;
using Il2CppDummyDll;

namespace YoStar.SDK
{
	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000062")]
	public class LoginRet
	{
		// Token: 0x0600023D RID: 573 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LoginRet()
		{
		}

		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x10")]
		public int R_CODE;

		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x18")]
		public string R_MSG;

		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x20")]
		public string LOGIN_UID;

		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x28")]
		public string LOGIN_UID_2;

		// Token: 0x040001C9 RID: 457
		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x30")]
		public string LOGIN_TOKEN;

		// Token: 0x040001CA RID: 458
		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x38")]
		public string LOGIN_NAME;

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x40")]
		public LoginPlatform LOGIN_PLATFORM;

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x48")]
		public string FACEBOOK_NAME;

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x50")]
		public string TWITTER_NAME;

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x58")]
		public string YOSTAR_NAME;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x60")]
		public string GOOGLE_EMAIL;

		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x68")]
		public string APPLE_ID;

		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x70")]
		public string APPLE_ID_HK;

		// Token: 0x040001D2 RID: 466
		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x78")]
		public string APPLE_ID_JP;

		// Token: 0x040001D3 RID: 467
		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x80")]
		public string AMAZON_NAME;

		// Token: 0x040001D4 RID: 468
		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x88")]
		public string STEAM_NAME;

		// Token: 0x040001D5 RID: 469
		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0x90")]
		public string MIGRATION_CODE;
	}
}
