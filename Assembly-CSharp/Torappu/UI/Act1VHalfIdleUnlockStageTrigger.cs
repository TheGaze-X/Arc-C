using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003439 RID: 13369
	[Token(Token = "0x2003439")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class Act1VHalfIdleUnlockStageTrigger
	{
		// Token: 0x0601564F RID: 87631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601564F")]
		[Address(RVA = "0xDDBD60", Offset = "0xDDA960", VA = "0x180DDBD60")]
		public static void HandleMessage(List<Act1VHalfIdleUnlockStagePushMsg> msgList)
		{
		}

		// Token: 0x0401999E RID: 104862
		[Token(Token = "0x401999E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
