using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FF3 RID: 4083
	[Token(Token = "0x2000FF3")]
	public class HomeBackgroundLimitInfoData
	{
		// Token: 0x06006D4C RID: 27980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D4C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HomeBackgroundLimitInfoData()
		{
		}

		// Token: 0x04005696 RID: 22166
		[Token(Token = "0x4005696")]
		[FieldOffset(Offset = "0x10")]
		public string limitInfoId;

		// Token: 0x04005697 RID: 22167
		[Token(Token = "0x4005697")]
		[FieldOffset(Offset = "0x18")]
		public long startTime;

		// Token: 0x04005698 RID: 22168
		[Token(Token = "0x4005698")]
		[FieldOffset(Offset = "0x20")]
		public long endTime;

		// Token: 0x04005699 RID: 22169
		[Token(Token = "0x4005699")]
		[FieldOffset(Offset = "0x28")]
		public string invalidObtainDesc;

		// Token: 0x0400569A RID: 22170
		[Token(Token = "0x400569A")]
		[FieldOffset(Offset = "0x30")]
		public bool displayAfterEndTime;
	}
}
