using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200072F RID: 1839
	[Token(Token = "0x200072F")]
	public class SetStarFriendListResponse : PlayerDeltaResponse
	{
		// Token: 0x0600639A RID: 25498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600639A")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public SetStarFriendListResponse()
		{
		}

		// Token: 0x04002F9C RID: 12188
		[Token(Token = "0x4002F9C")]
		[FieldOffset(Offset = "0x28")]
		public SetStarFriendListResponse.Result result;

		// Token: 0x04002F9D RID: 12189
		[Token(Token = "0x4002F9D")]
		[FieldOffset(Offset = "0x30")]
		public List<string> newIdList;

		// Token: 0x02000730 RID: 1840
		[Token(Token = "0x2000730")]
		public enum Result
		{
			// Token: 0x04002F9F RID: 12191
			[Token(Token = "0x4002F9F")]
			SUCC,
			// Token: 0x04002FA0 RID: 12192
			[Token(Token = "0x4002FA0")]
			FAIL
		}
	}
}
