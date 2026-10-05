using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000739 RID: 1849
	[Token(Token = "0x2000739")]
	public class ChangeNameCardMiscRequest
	{
		// Token: 0x060063A3 RID: 25507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063A3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ChangeNameCardMiscRequest()
		{
		}

		// Token: 0x04002FA8 RID: 12200
		[Token(Token = "0x4002FA8")]
		[FieldOffset(Offset = "0x10")]
		public ChangeMiscType type;

		// Token: 0x04002FA9 RID: 12201
		[Token(Token = "0x4002FA9")]
		[FieldOffset(Offset = "0x18")]
		public PlayerNameCardMisc misc;
	}
}
