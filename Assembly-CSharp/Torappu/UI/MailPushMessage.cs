using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003ABC RID: 15036
	[Token(Token = "0x2003ABC")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class MailPushMessage
	{
		// Token: 0x06017BB3 RID: 97203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017BB3")]
		[Address(RVA = "0xFFDF90", Offset = "0xFFCB90", VA = "0x180FFDF90")]
		public static void HandleArchiveUnlock(List<MailArchiveUnlockPushMsg> msgList)
		{
		}

		// Token: 0x0401CA54 RID: 117332
		[Token(Token = "0x401CA54")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleArchiveUnlock;

		// Token: 0x02003ABD RID: 15037
		[Token(Token = "0x2003ABD")]
		private class MailArchiveUnlockMessage : UINotificationTasks.DefaultMainUITask.ICall
		{
			// Token: 0x06017BB4 RID: 97204 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017BB4")]
			[Address(RVA = "0xFFDF10", Offset = "0xFFCB10", VA = "0x180FFDF10", Slot = "4")]
			public void Call()
			{
			}

			// Token: 0x06017BB5 RID: 97205 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017BB5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MailArchiveUnlockMessage()
			{
			}

			// Token: 0x0401CA55 RID: 117333
			[Token(Token = "0x401CA55")]
			[FieldOffset(Offset = "0x10")]
			public List<MailArchiveUnlockPushMsg> msgList;
		}
	}
}
