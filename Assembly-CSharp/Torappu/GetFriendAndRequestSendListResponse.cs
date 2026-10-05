using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000744 RID: 1860
	[Token(Token = "0x2000744")]
	public class GetFriendAndRequestSendListResponse
	{
		// Token: 0x060063AE RID: 25518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063AE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GetFriendAndRequestSendListResponse()
		{
		}

		// Token: 0x04002FB6 RID: 12214
		[Token(Token = "0x4002FB6")]
		[FieldOffset(Offset = "0x10")]
		public List<FriendSimpleInfo> friendsList;

		// Token: 0x04002FB7 RID: 12215
		[Token(Token = "0x4002FB7")]
		[FieldOffset(Offset = "0x18")]
		public List<string> requestSendIdList;
	}
}
