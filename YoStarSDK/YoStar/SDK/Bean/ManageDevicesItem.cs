using System;
using Il2CppDummyDll;

namespace YoStar.SDK.Bean
{
	// Token: 0x020002B2 RID: 690
	[Token(Token = "0x20002B2")]
	public class ManageDevicesItem
	{
		// Token: 0x06000FD8 RID: 4056 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000FD8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ManageDevicesItem()
		{
		}

		// Token: 0x04000D05 RID: 3333
		[Token(Token = "0x4000D05")]
		[FieldOffset(Offset = "0x10")]
		public string ID;

		// Token: 0x04000D06 RID: 3334
		[Token(Token = "0x4000D06")]
		[FieldOffset(Offset = "0x18")]
		public string DeviceType;

		// Token: 0x04000D07 RID: 3335
		[Token(Token = "0x4000D07")]
		[FieldOffset(Offset = "0x20")]
		public string DeviceModel;

		// Token: 0x04000D08 RID: 3336
		[Token(Token = "0x4000D08")]
		[FieldOffset(Offset = "0x28")]
		public string DeviceName;

		// Token: 0x04000D09 RID: 3337
		[Token(Token = "0x4000D09")]
		[FieldOffset(Offset = "0x30")]
		public string DeviceID;

		// Token: 0x04000D0A RID: 3338
		[Token(Token = "0x4000D0A")]
		[FieldOffset(Offset = "0x38")]
		public long LastLoginAt;
	}
}
