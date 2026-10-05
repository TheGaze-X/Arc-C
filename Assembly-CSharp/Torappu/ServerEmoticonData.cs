using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200100B RID: 4107
	[Token(Token = "0x200100B")]
	public class ServerEmoticonData : EmoticonData
	{
		// Token: 0x06006D61 RID: 28001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D61")]
		[Address(RVA = "0x2114DD0", Offset = "0x21139D0", VA = "0x182114DD0")]
		public ServerEmoticonData()
		{
		}

		// Token: 0x0400571B RID: 22299
		[Token(Token = "0x400571B")]
		[FieldOffset(Offset = "0x20")]
		public List<string> emoticonThemeUnlockList;
	}
}
