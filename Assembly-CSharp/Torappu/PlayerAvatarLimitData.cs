using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FEC RID: 4076
	[Token(Token = "0x2000FEC")]
	public class PlayerAvatarLimitData
	{
		// Token: 0x06006D43 RID: 27971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D43")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerAvatarLimitData()
		{
		}

		// Token: 0x04005677 RID: 22135
		[Token(Token = "0x4005677")]
		[FieldOffset(Offset = "0x10")]
		public string avatarId;

		// Token: 0x04005678 RID: 22136
		[Token(Token = "0x4005678")]
		[FieldOffset(Offset = "0x18")]
		public long descShowTs;

		// Token: 0x04005679 RID: 22137
		[Token(Token = "0x4005679")]
		[FieldOffset(Offset = "0x20")]
		public long descHideTs;
	}
}
