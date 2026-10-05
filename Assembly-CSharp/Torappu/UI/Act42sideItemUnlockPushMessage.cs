using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x0200345C RID: 13404
	[Token(Token = "0x200345C")]
	public struct Act42sideItemUnlockPushMessage
	{
		// Token: 0x04019A15 RID: 104981
		[Token(Token = "0x4019A15")]
		[FieldOffset(Offset = "0x0")]
		public string actId;

		// Token: 0x04019A16 RID: 104982
		[Token(Token = "0x4019A16")]
		[FieldOffset(Offset = "0x8")]
		public List<string> unlockList;
	}
}
