using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B15 RID: 23317
	[Token(Token = "0x2005B15")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class QCShopLowPushMessage
	{
		// Token: 0x06021DE6 RID: 138726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DE6")]
		[Address(RVA = "0x1C5BF30", Offset = "0x1C5AB30", VA = "0x181C5BF30")]
		public static void HandleLowShopUnlock(List<QCShopLowUnlockPushMsg> msgList)
		{
		}

		// Token: 0x0402E66D RID: 190061
		[Token(Token = "0x402E66D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleLowShopUnlock;
	}
}
