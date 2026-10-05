using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Carving
{
	// Token: 0x020060A0 RID: 24736
	[Token(Token = "0x20060A0")]
	public class CarvingChallengeUnlockPushMsg
	{
		// Token: 0x06023CA5 RID: 146597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023CA5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CarvingChallengeUnlockPushMsg()
		{
		}

		// Token: 0x04031A04 RID: 203268
		[Token(Token = "0x4031A04")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04031A05 RID: 203269
		[Token(Token = "0x4031A05")]
		[FieldOffset(Offset = "0x18")]
		public List<string> unlock;
	}
}
