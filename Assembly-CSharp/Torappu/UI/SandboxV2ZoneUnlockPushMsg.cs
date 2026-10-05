using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003B48 RID: 15176
	[Token(Token = "0x2003B48")]
	public class SandboxV2ZoneUnlockPushMsg
	{
		// Token: 0x06017D6B RID: 97643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D6B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2ZoneUnlockPushMsg()
		{
		}

		// Token: 0x0401CCA5 RID: 117925
		[Token(Token = "0x401CCA5")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x0401CCA6 RID: 117926
		[Token(Token = "0x401CCA6")]
		[FieldOffset(Offset = "0x18")]
		public string zoneId;
	}
}
