using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E02 RID: 3586
	[Token(Token = "0x2000E02")]
	public class ActivityEnemyDuelNpcSelectorGroupData
	{
		// Token: 0x06006AD3 RID: 27347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AD3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActivityEnemyDuelNpcSelectorGroupData()
		{
		}

		// Token: 0x04004A7E RID: 19070
		[Token(Token = "0x4004A7E")]
		[FieldOffset(Offset = "0x10")]
		public string npcId;

		// Token: 0x04004A7F RID: 19071
		[Token(Token = "0x4004A7F")]
		[FieldOffset(Offset = "0x18")]
		public List<ActivityEnemyDuelNpcSelectorData> data;
	}
}
