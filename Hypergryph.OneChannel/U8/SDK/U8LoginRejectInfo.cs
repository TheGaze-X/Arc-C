using System;
using Il2CppDummyDll;

namespace U8.SDK
{
	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	public struct U8LoginRejectInfo
	{
		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x0")]
		public string error;

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x8")]
		public bool needCaptcha;

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x10")]
		public string captcha;

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x18")]
		public string captchaTips;
	}
}
