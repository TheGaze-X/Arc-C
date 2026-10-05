using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003450 RID: 13392
	[Token(Token = "0x2003450")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class Act29sideUnlockTokenTrigger
	{
		// Token: 0x06015671 RID: 87665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015671")]
		[Address(RVA = "0xDDCD60", Offset = "0xDDB960", VA = "0x180DDCD60")]
		public static void HandleMessage(List<Act29sideUnlockTokenPushMessage> msgList)
		{
		}

		// Token: 0x06015672 RID: 87666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015672")]
		[Address(RVA = "0xDDCFA0", Offset = "0xDDBBA0", VA = "0x180DDCFA0")]
		private static void _ShowToast()
		{
		}

		// Token: 0x040199E2 RID: 104930
		[Token(Token = "0x40199E2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleMessage;

		// Token: 0x040199E3 RID: 104931
		[Token(Token = "0x40199E3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ShowToast;
	}
}
