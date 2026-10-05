using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200625B RID: 25179
	[Token(Token = "0x200625B")]
	public class AutoChessGetFriendAssistListRequest
	{
		// Token: 0x06024566 RID: 148838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024566")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AutoChessGetFriendAssistListRequest()
		{
		}

		// Token: 0x04032887 RID: 206983
		[Token(Token = "0x4032887")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04032888 RID: 206984
		[Token(Token = "0x4032888")]
		[FieldOffset(Offset = "0x18")]
		public string charId;
	}
}
