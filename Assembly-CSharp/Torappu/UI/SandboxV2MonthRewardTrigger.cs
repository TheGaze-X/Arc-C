using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B3D RID: 15165
	[Token(Token = "0x2003B3D")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class SandboxV2MonthRewardTrigger
	{
		// Token: 0x06017D53 RID: 97619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D53")]
		[Address(RVA = "0x1017DF0", Offset = "0x10169F0", VA = "0x181017DF0")]
		private static void _HandleMessage(List<SandboxV2MonthRewardPushMsg> msgList)
		{
		}

		// Token: 0x06017D54 RID: 97620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D54")]
		[Address(RVA = "0x1017D30", Offset = "0x1016930", VA = "0x181017D30")]
		public static void HandleMessage(List<SandboxV2MonthRewardPushMsg> msgList)
		{
		}

		// Token: 0x0401CC8A RID: 117898
		[Token(Token = "0x401CC8A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__HandleMessage;

		// Token: 0x0401CC8B RID: 117899
		[Token(Token = "0x401CC8B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
