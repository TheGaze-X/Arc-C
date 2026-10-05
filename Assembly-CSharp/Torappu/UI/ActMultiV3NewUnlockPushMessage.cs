using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003476 RID: 13430
	[Token(Token = "0x2003476")]
	public class ActMultiV3NewUnlockPushMessage
	{
		// Token: 0x060156F0 RID: 87792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60156F0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3NewUnlockPushMessage()
		{
		}

		// Token: 0x04019A95 RID: 105109
		[Token(Token = "0x4019A95")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x04019A96 RID: 105110
		[Token(Token = "0x4019A96")]
		[FieldOffset(Offset = "0x18")]
		public bool mentor;

		// Token: 0x04019A97 RID: 105111
		[Token(Token = "0x4019A97")]
		[FieldOffset(Offset = "0x19")]
		public bool reverse;

		// Token: 0x04019A98 RID: 105112
		[Token(Token = "0x4019A98")]
		[FieldOffset(Offset = "0x1A")]
		public bool buffCoin;

		// Token: 0x04019A99 RID: 105113
		[Token(Token = "0x4019A99")]
		[FieldOffset(Offset = "0x20")]
		public List<string> modeList;
	}
}
