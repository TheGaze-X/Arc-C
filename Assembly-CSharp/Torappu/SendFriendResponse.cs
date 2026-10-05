using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000720 RID: 1824
	[Token(Token = "0x2000720")]
	public class SendFriendResponse : PlayerDeltaResponse
	{
		// Token: 0x0600638B RID: 25483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600638B")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public SendFriendResponse()
		{
		}

		// Token: 0x04002F82 RID: 12162
		[Token(Token = "0x4002F82")]
		[FieldOffset(Offset = "0x28")]
		public int result;
	}
}
