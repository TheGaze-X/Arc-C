using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B23 RID: 15139
	[Token(Token = "0x2003B23")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RoguelikeLeaveSkyZoneTrigger
	{
		// Token: 0x06017D1C RID: 97564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D1C")]
		[Address(RVA = "0x10167E0", Offset = "0x10153E0", VA = "0x1810167E0")]
		private static void _HandleMessage(List<RoguelikeLeaveSkyZonePushMsg> msgList)
		{
		}

		// Token: 0x06017D1D RID: 97565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D1D")]
		[Address(RVA = "0x1016700", Offset = "0x1015300", VA = "0x181016700")]
		public static void HandleMessage(List<RoguelikeLeaveSkyZonePushMsg> msgList)
		{
		}

		// Token: 0x0401CC55 RID: 117845
		[Token(Token = "0x401CC55")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__HandleMessage;

		// Token: 0x0401CC56 RID: 117846
		[Token(Token = "0x401CC56")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
