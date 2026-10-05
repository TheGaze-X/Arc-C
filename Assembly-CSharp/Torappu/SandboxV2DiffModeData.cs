using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012A9 RID: 4777
	[Token(Token = "0x20012A9")]
	public class SandboxV2DiffModeData
	{
		// Token: 0x06007225 RID: 29221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007225")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2DiffModeData()
		{
		}

		// Token: 0x04006936 RID: 26934
		[Token(Token = "0x4006936")]
		[FieldOffset(Offset = "0x10")]
		public string title;

		// Token: 0x04006937 RID: 26935
		[Token(Token = "0x4006937")]
		[FieldOffset(Offset = "0x18")]
		public string desc;

		// Token: 0x04006938 RID: 26936
		[Token(Token = "0x4006938")]
		[FieldOffset(Offset = "0x20")]
		public List<string> buffList;

		// Token: 0x04006939 RID: 26937
		[Token(Token = "0x4006939")]
		[FieldOffset(Offset = "0x28")]
		public string detailList;

		// Token: 0x0400693A RID: 26938
		[Token(Token = "0x400693A")]
		[FieldOffset(Offset = "0x30")]
		public int sortId;
	}
}
