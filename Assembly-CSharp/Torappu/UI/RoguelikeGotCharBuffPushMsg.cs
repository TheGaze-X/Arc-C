using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003B09 RID: 15113
	[Token(Token = "0x2003B09")]
	public class RoguelikeGotCharBuffPushMsg
	{
		// Token: 0x06017CE8 RID: 97512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017CE8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeGotCharBuffPushMsg()
		{
		}

		// Token: 0x0401CC1C RID: 117788
		[Token(Token = "0x401CC1C")]
		[FieldOffset(Offset = "0x10")]
		public List<string> charList;

		// Token: 0x0401CC1D RID: 117789
		[Token(Token = "0x401CC1D")]
		[FieldOffset(Offset = "0x18")]
		public string buffId;
	}
}
