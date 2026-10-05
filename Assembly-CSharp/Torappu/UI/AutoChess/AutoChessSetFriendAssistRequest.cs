using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200625D RID: 25181
	[Token(Token = "0x200625D")]
	public class AutoChessSetFriendAssistRequest
	{
		// Token: 0x06024568 RID: 148840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024568")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AutoChessSetFriendAssistRequest()
		{
		}

		// Token: 0x0403288A RID: 206986
		[Token(Token = "0x403288A")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0403288B RID: 206987
		[Token(Token = "0x403288B")]
		[FieldOffset(Offset = "0x18")]
		public string assistChessId;

		// Token: 0x0403288C RID: 206988
		[Token(Token = "0x403288C")]
		[FieldOffset(Offset = "0x20")]
		public string assistUid;
	}
}
