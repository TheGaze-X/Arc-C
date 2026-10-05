using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003B18 RID: 15128
	[Token(Token = "0x2003B18")]
	public class RoguelikeFragmentGainPushMsg
	{
		// Token: 0x06017D0C RID: 97548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D0C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeFragmentGainPushMsg()
		{
		}

		// Token: 0x0401CC46 RID: 117830
		[Token(Token = "0x401CC46")]
		[FieldOffset(Offset = "0x10")]
		public List<RoguelikeFragmentGainItem> fragmentList;
	}
}
