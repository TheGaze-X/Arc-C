using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A4B RID: 2635
	[Token(Token = "0x2000A4B")]
	public class PlayerEquipment
	{
		// Token: 0x0600670A RID: 26378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600670A")]
		[Address(RVA = "0x1EFA010", Offset = "0x1EF8C10", VA = "0x181EFA010")]
		public PlayerEquipment()
		{
		}

		// Token: 0x04003837 RID: 14391
		[Token(Token = "0x4003837")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, PlayerEquipMission> missions;
	}
}
