using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001090 RID: 4240
	[Token(Token = "0x2001090")]
	public class HandbookUnlockParam
	{
		// Token: 0x06006E1C RID: 28188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E1C")]
		[Address(RVA = "0x2105A80", Offset = "0x2104680", VA = "0x182105A80")]
		public HandbookUnlockParam()
		{
		}

		// Token: 0x04005A71 RID: 23153
		[Token(Token = "0x4005A71")]
		[FieldOffset(Offset = "0x10")]
		public DataUnlockType unlockType;

		// Token: 0x04005A72 RID: 23154
		[Token(Token = "0x4005A72")]
		[FieldOffset(Offset = "0x18")]
		public string unlockParam1;

		// Token: 0x04005A73 RID: 23155
		[Token(Token = "0x4005A73")]
		[FieldOffset(Offset = "0x20")]
		public string unlockParam2;

		// Token: 0x04005A74 RID: 23156
		[Token(Token = "0x4005A74")]
		[FieldOffset(Offset = "0x28")]
		public string unlockParam3;
	}
}
