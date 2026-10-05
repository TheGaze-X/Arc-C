using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020007A1 RID: 1953
	[Token(Token = "0x20007A1")]
	public class LoginRequest
	{
		// Token: 0x06006421 RID: 25633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006421")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LoginRequest()
		{
		}

		// Token: 0x04003079 RID: 12409
		[Token(Token = "0x4003079")]
		[FieldOffset(Offset = "0x10")]
		public string uid;

		// Token: 0x0400307A RID: 12410
		[Token(Token = "0x400307A")]
		[FieldOffset(Offset = "0x18")]
		public string token;

		// Token: 0x0400307B RID: 12411
		[Token(Token = "0x400307B")]
		[FieldOffset(Offset = "0x20")]
		public string assetsVersion;

		// Token: 0x0400307C RID: 12412
		[Token(Token = "0x400307C")]
		[FieldOffset(Offset = "0x28")]
		public string clientVersion;

		// Token: 0x0400307D RID: 12413
		[Token(Token = "0x400307D")]
		[FieldOffset(Offset = "0x30")]
		public PlatformKey platform;

		// Token: 0x0400307E RID: 12414
		[Token(Token = "0x400307E")]
		[FieldOffset(Offset = "0x38")]
		public string deviceId;

		// Token: 0x0400307F RID: 12415
		[Token(Token = "0x400307F")]
		[FieldOffset(Offset = "0x40")]
		public string deviceId2;

		// Token: 0x04003080 RID: 12416
		[Token(Token = "0x4003080")]
		[FieldOffset(Offset = "0x48")]
		public string deviceId3;

		// Token: 0x04003081 RID: 12417
		[Token(Token = "0x4003081")]
		[FieldOffset(Offset = "0x50")]
		public string networkVersion;

		// Token: 0x04003082 RID: 12418
		[Token(Token = "0x4003082")]
		[FieldOffset(Offset = "0x58")]
		public string udtVersion;
	}
}
