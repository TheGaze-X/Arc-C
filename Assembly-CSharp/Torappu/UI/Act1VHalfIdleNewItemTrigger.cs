using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003437 RID: 13367
	[Token(Token = "0x2003437")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class Act1VHalfIdleNewItemTrigger
	{
		// Token: 0x0601564E RID: 87630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601564E")]
		[Address(RVA = "0xDDB880", Offset = "0xDDA480", VA = "0x180DDB880")]
		public static void HandleMessage(List<Act1VHalfIdleNewItemPushMsg> msgList)
		{
		}

		// Token: 0x0401999B RID: 104859
		[Token(Token = "0x401999B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
