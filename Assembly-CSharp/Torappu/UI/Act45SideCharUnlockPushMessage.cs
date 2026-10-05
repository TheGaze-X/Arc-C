using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003464 RID: 13412
	[Token(Token = "0x2003464")]
	public struct Act45SideCharUnlockPushMessage
	{
		// Token: 0x04019A25 RID: 104997
		[Token(Token = "0x4019A25")]
		[FieldOffset(Offset = "0x0")]
		public string actId;

		// Token: 0x04019A26 RID: 104998
		[Token(Token = "0x4019A26")]
		[FieldOffset(Offset = "0x8")]
		public List<string> charList;
	}
}
