using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B1B RID: 15131
	[Token(Token = "0x2003B1B")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RoguelikeFragmentBagWeightWorseTrigger
	{
		// Token: 0x06017D10 RID: 97552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D10")]
		[Address(RVA = "0x1015600", Offset = "0x1014200", VA = "0x181015600")]
		private static void _HandleMessage(List<RoguelikeFragmentBagWeightWorsePushMsg> msgList)
		{
		}

		// Token: 0x06017D11 RID: 97553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D11")]
		[Address(RVA = "0x1015520", Offset = "0x1014120", VA = "0x181015520")]
		public static void HandleMessage(List<RoguelikeFragmentBagWeightWorsePushMsg> msgList)
		{
		}

		// Token: 0x0401CC49 RID: 117833
		[Token(Token = "0x401CC49")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__HandleMessage;

		// Token: 0x0401CC4A RID: 117834
		[Token(Token = "0x401CC4A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
