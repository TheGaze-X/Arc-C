using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003B4C RID: 15180
	[Token(Token = "0x2003B4C")]
	public struct SandboxV2CraftUnlockPushMsg
	{
		// Token: 0x0401CCAE RID: 117934
		[Token(Token = "0x401CCAE")]
		[FieldOffset(Offset = "0x0")]
		public string topicId;

		// Token: 0x0401CCAF RID: 117935
		[Token(Token = "0x401CCAF")]
		[FieldOffset(Offset = "0x8")]
		public List<string> items;
	}
}
