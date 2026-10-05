using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E4B RID: 3659
	[Token(Token = "0x2000E4B")]
	public class ActMultiV3WeeklyPhotoRewardData
	{
		// Token: 0x06006B19 RID: 27417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B19")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3WeeklyPhotoRewardData()
		{
		}

		// Token: 0x04004C34 RID: 19508
		[Token(Token = "0x4004C34")]
		[FieldOffset(Offset = "0x10")]
		public int order;

		// Token: 0x04004C35 RID: 19509
		[Token(Token = "0x4004C35")]
		[FieldOffset(Offset = "0x18")]
		public string titleDesc;

		// Token: 0x04004C36 RID: 19510
		[Token(Token = "0x4004C36")]
		[FieldOffset(Offset = "0x20")]
		public long unlockTime;

		// Token: 0x04004C37 RID: 19511
		[Token(Token = "0x4004C37")]
		[FieldOffset(Offset = "0x28")]
		public List<ItemBundle> rewards;
	}
}
