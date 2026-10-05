using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003714 RID: 14100
	[Token(Token = "0x2003714")]
	public static class ItemDestroyedTrigger
	{
		// Token: 0x06016613 RID: 91667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016613")]
		[Address(RVA = "0xEC2E30", Offset = "0xEC1A30", VA = "0x180EC2E30")]
		public static void HandleMessage(List<ItemDestroyedPushMsg> msgList)
		{
		}

		// Token: 0x06016614 RID: 91668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016614")]
		[Address(RVA = "0xEC3070", Offset = "0xEC1C70", VA = "0x180EC3070")]
		private static void _ShowToast(string itemId)
		{
		}
	}
}
