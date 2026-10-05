using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B1F RID: 15135
	[Token(Token = "0x2003B1F")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RoguelikeTravelLeaveTrigger
	{
		// Token: 0x06017D16 RID: 97558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D16")]
		[Address(RVA = "0x1016EA0", Offset = "0x1015AA0", VA = "0x181016EA0")]
		private static void _HandleMessage(List<RoguelikeTravelLeavePushMsg> msgList)
		{
		}

		// Token: 0x06017D17 RID: 97559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D17")]
		[Address(RVA = "0x1016DC0", Offset = "0x10159C0", VA = "0x181016DC0")]
		public static void HandleMessage(List<RoguelikeTravelLeavePushMsg> msgList)
		{
		}

		// Token: 0x0401CC50 RID: 117840
		[Token(Token = "0x401CC50")]
		[FieldOffset(Offset = "0x0")]
		private static StringBuilder s_stringBuilder;

		// Token: 0x0401CC51 RID: 117841
		[Token(Token = "0x401CC51")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__HandleMessage;

		// Token: 0x0401CC52 RID: 117842
		[Token(Token = "0x401CC52")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
