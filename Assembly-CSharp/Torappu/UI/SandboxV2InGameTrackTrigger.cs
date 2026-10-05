using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B58 RID: 15192
	[Token(Token = "0x2003B58")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class SandboxV2InGameTrackTrigger
	{
		// Token: 0x06017D7F RID: 97663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D7F")]
		[Address(RVA = "0x1017BD0", Offset = "0x10167D0", VA = "0x181017BD0")]
		public static void HandleMessage(List<SandboxV2TrackPushMsg> msgList)
		{
		}

		// Token: 0x0401CCD2 RID: 117970
		[Token(Token = "0x401CCD2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
