using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B55 RID: 15189
	[Token(Token = "0x2003B55")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class TutorialOnly_SandboxV2DungeonGuideStartTrigger
	{
		// Token: 0x06017D7D RID: 97661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D7D")]
		[Address(RVA = "0x1021A60", Offset = "0x1020660", VA = "0x181021A60")]
		private static void _HandleMessage(List<SandboxV2DungeonGuideStartMsg> msgList)
		{
		}

		// Token: 0x06017D7E RID: 97662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D7E")]
		[Address(RVA = "0x1021940", Offset = "0x1020540", VA = "0x181021940")]
		public static void HandleMessage(List<SandboxV2DungeonGuideStartMsg> msgList)
		{
		}

		// Token: 0x0401CCC0 RID: 117952
		[Token(Token = "0x401CCC0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__HandleMessage;

		// Token: 0x0401CCC1 RID: 117953
		[Token(Token = "0x401CCC1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
