using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x020073D7 RID: 29655
	[Token(Token = "0x20073D7")]
	public class Act3D0GachaRequest
	{
		// Token: 0x06029E39 RID: 171577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E39")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act3D0GachaRequest()
		{
		}

		// Token: 0x0403C093 RID: 245907
		[Token(Token = "0x403C093")]
		[FieldOffset(Offset = "0x10")]
		public int count;

		// Token: 0x0403C094 RID: 245908
		[Token(Token = "0x403C094")]
		[FieldOffset(Offset = "0x18")]
		public string poolId;

		// Token: 0x0403C095 RID: 245909
		[Token(Token = "0x403C095")]
		[FieldOffset(Offset = "0x20")]
		public string activityId;
	}
}
