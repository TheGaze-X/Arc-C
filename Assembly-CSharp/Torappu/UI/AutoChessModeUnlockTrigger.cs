using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003491 RID: 13457
	[Token(Token = "0x2003491")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class AutoChessModeUnlockTrigger
	{
		// Token: 0x0601574C RID: 87884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601574C")]
		[Address(RVA = "0xDE6670", Offset = "0xDE5270", VA = "0x180DE6670")]
		public static void HandleMessage(List<AutoChessModeUnlockPushMsg> msgList)
		{
		}

		// Token: 0x04019AFA RID: 105210
		[Token(Token = "0x4019AFA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
