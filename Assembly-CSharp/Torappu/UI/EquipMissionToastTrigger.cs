using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003B7E RID: 15230
	[Token(Token = "0x2003B7E")]
	public static class EquipMissionToastTrigger
	{
		// Token: 0x06017E13 RID: 97811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E13")]
		[Address(RVA = "0x1011E90", Offset = "0x1010A90", VA = "0x181011E90")]
		public static void HandleMessage(List<EquipMissionPayload> msgList)
		{
		}

		// Token: 0x06017E14 RID: 97812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E14")]
		[Address(RVA = "0x1012040", Offset = "0x1010C40", VA = "0x181012040")]
		private static void _ShowToast(List<string> idList)
		{
		}

		// Token: 0x0401CDB8 RID: 118200
		[Token(Token = "0x401CDB8")]
		private const float SHOW_DELAY = 0.8f;
	}
}
