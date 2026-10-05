using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003873 RID: 14451
	[Token(Token = "0x2003873")]
	public class PlayerSyncStatusViewModel
	{
		// Token: 0x06016E34 RID: 93748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016E34")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerSyncStatusViewModel()
		{
		}

		// Token: 0x0401B9E5 RID: 113125
		[Token(Token = "0x401B9E5")]
		[FieldOffset(Offset = "0x10")]
		public long ts;

		// Token: 0x0401B9E6 RID: 113126
		[Token(Token = "0x401B9E6")]
		[FieldOffset(Offset = "0x18")]
		public PlayerSyncGoodPurchaseResult goodPurchaseResult;

		// Token: 0x0401B9E7 RID: 113127
		[Token(Token = "0x401B9E7")]
		[FieldOffset(Offset = "0x20")]
		public PlayerCheckForbiddenResult forbiddenResult;

		// Token: 0x0401B9E8 RID: 113128
		[Token(Token = "0x401B9E8")]
		[FieldOffset(Offset = "0x28")]
		public string announcementVersion;

		// Token: 0x0401B9E9 RID: 113129
		[Token(Token = "0x401B9E9")]
		[FieldOffset(Offset = "0x30")]
		public string announcementPopUpVersion;
	}
}
