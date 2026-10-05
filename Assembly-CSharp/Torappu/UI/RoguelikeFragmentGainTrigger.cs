using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B19 RID: 15129
	[Token(Token = "0x2003B19")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RoguelikeFragmentGainTrigger
	{
		// Token: 0x06017D0D RID: 97549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D0D")]
		[Address(RVA = "0x1015860", Offset = "0x1014460", VA = "0x181015860")]
		private static void _HandleMessage(List<RoguelikeFragmentGainPushMsg> msgList)
		{
		}

		// Token: 0x06017D0E RID: 97550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D0E")]
		[Address(RVA = "0x1015780", Offset = "0x1014380", VA = "0x181015780")]
		public static void HandleMessage(List<RoguelikeFragmentGainPushMsg> msgList)
		{
		}

		// Token: 0x0401CC47 RID: 117831
		[Token(Token = "0x401CC47")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__HandleMessage;

		// Token: 0x0401CC48 RID: 117832
		[Token(Token = "0x401CC48")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
