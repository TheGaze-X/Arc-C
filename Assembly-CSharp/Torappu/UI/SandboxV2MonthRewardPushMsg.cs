using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003B3C RID: 15164
	[Token(Token = "0x2003B3C")]
	public class SandboxV2MonthRewardPushMsg
	{
		// Token: 0x06017D52 RID: 97618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D52")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2MonthRewardPushMsg()
		{
		}

		// Token: 0x0401CC88 RID: 117896
		[Token(Token = "0x401CC88")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x0401CC89 RID: 117897
		[Token(Token = "0x401CC89")]
		[FieldOffset(Offset = "0x18")]
		public List<ItemGet> rewards;
	}
}
