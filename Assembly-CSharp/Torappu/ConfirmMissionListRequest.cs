using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020007CD RID: 1997
	[Token(Token = "0x20007CD")]
	public class ConfirmMissionListRequest
	{
		// Token: 0x0600644E RID: 25678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600644E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ConfirmMissionListRequest()
		{
		}

		// Token: 0x040030D9 RID: 12505
		[Token(Token = "0x40030D9")]
		[FieldOffset(Offset = "0x10")]
		public List<string> missionIds;
	}
}
