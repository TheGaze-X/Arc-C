using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003A4B RID: 14923
	[Token(Token = "0x2003A4B")]
	public class CrisisV2UnlockDailyRunePushMsg
	{
		// Token: 0x06017987 RID: 96647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017987")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisV2UnlockDailyRunePushMsg()
		{
		}

		// Token: 0x0401C794 RID: 116628
		[Token(Token = "0x401C794")]
		[FieldOffset(Offset = "0x10")]
		public string seasonId;

		// Token: 0x0401C795 RID: 116629
		[Token(Token = "0x401C795")]
		[FieldOffset(Offset = "0x18")]
		public string pMapId;

		// Token: 0x0401C796 RID: 116630
		[Token(Token = "0x401C796")]
		[FieldOffset(Offset = "0x20")]
		public string tMapId;

		// Token: 0x0401C797 RID: 116631
		[Token(Token = "0x401C797")]
		[FieldOffset(Offset = "0x28")]
		public string[] slotIds;
	}
}
