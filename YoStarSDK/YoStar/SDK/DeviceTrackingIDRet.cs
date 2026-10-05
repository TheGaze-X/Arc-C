using System;
using Il2CppDummyDll;

namespace YoStar.SDK
{
	// Token: 0x0200006E RID: 110
	[Token(Token = "0x200006E")]
	public class DeviceTrackingIDRet
	{
		// Token: 0x06000249 RID: 585 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DeviceTrackingIDRet()
		{
		}

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x10")]
		public int R_CODE;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x18")]
		public string R_MSG;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x20")]
		public string DATA;
	}
}
