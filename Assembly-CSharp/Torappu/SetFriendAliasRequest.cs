using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000731 RID: 1841
	[Token(Token = "0x2000731")]
	public class SetFriendAliasRequest
	{
		// Token: 0x0600639B RID: 25499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600639B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SetFriendAliasRequest()
		{
		}

		// Token: 0x04002FA1 RID: 12193
		[Token(Token = "0x4002FA1")]
		[FieldOffset(Offset = "0x10")]
		public string friendId;

		// Token: 0x04002FA2 RID: 12194
		[Token(Token = "0x4002FA2")]
		[FieldOffset(Offset = "0x18")]
		public string alias;
	}
}
