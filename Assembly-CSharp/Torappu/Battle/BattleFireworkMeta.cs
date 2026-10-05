using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x020020A9 RID: 8361
	[Token(Token = "0x20020A9")]
	public struct BattleFireworkMeta
	{
		// Token: 0x0400D924 RID: 55588
		[Token(Token = "0x400D924")]
		[FieldOffset(Offset = "0x0")]
		public string animalId;

		// Token: 0x0400D925 RID: 55589
		[Token(Token = "0x400D925")]
		[FieldOffset(Offset = "0x8")]
		public List<FireworkData.PlateSlotData> slotList;
	}
}
