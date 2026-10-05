using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001045 RID: 4165
	[Token(Token = "0x2001045")]
	public class BattleEquipPack
	{
		// Token: 0x06006DAD RID: 28077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DAD")]
		[Address(RVA = "0x20FEDE0", Offset = "0x20FD9E0", VA = "0x1820FEDE0")]
		public BattleEquipPack()
		{
		}

		// Token: 0x0400588C RID: 22668
		[Token(Token = "0x400588C")]
		[FieldOffset(Offset = "0x10")]
		public List<BattleEquipPerLevelPack> phases;
	}
}
