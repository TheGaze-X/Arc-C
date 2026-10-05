using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000721 RID: 1825
	[Token(Token = "0x2000721")]
	public class ProcessFriendRequest
	{
		// Token: 0x0600638C RID: 25484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600638C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ProcessFriendRequest()
		{
		}

		// Token: 0x04002F83 RID: 12163
		[Token(Token = "0x4002F83")]
		[FieldOffset(Offset = "0x10")]
		public string friendId;

		// Token: 0x04002F84 RID: 12164
		[Token(Token = "0x4002F84")]
		[FieldOffset(Offset = "0x18")]
		public FriendDealEnum action;
	}
}
