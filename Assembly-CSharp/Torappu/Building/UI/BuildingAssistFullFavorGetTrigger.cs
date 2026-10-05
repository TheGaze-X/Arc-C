using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B95 RID: 7061
	[Token(Token = "0x2001B95")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class BuildingAssistFullFavorGetTrigger
	{
		// Token: 0x0600B07B RID: 45179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B07B")]
		[Address(RVA = "0x32A0FB0", Offset = "0x329FBB0", VA = "0x1832A0FB0")]
		public static void HandleMessage(List<BuildingAssistFullFavorPushMsg> msgList)
		{
		}

		// Token: 0x0400AAE5 RID: 43749
		[Token(Token = "0x400AAE5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
