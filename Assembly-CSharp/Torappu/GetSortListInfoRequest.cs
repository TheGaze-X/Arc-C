using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000724 RID: 1828
	[Token(Token = "0x2000724")]
	public class GetSortListInfoRequest
	{
		// Token: 0x0600638F RID: 25487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600638F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GetSortListInfoRequest()
		{
		}

		// Token: 0x04002F8A RID: 12170
		[Token(Token = "0x4002F8A")]
		[FieldOffset(Offset = "0x10")]
		public FriendServiceType type;

		// Token: 0x04002F8B RID: 12171
		[Token(Token = "0x4002F8B")]
		[FieldOffset(Offset = "0x18")]
		public List<string> sortKeyList;

		// Token: 0x04002F8C RID: 12172
		[Token(Token = "0x4002F8C")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, string> param;
	}
}
