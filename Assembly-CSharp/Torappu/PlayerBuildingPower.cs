using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A54 RID: 2644
	[Token(Token = "0x2000A54")]
	public class PlayerBuildingPower
	{
		// Token: 0x06006713 RID: 26387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006713")]
		[Address(RVA = "0x1EF1B10", Offset = "0x1EF0710", VA = "0x181EF1B10")]
		public PlayerBuildingPower()
		{
		}

		// Token: 0x04003858 RID: 14424
		[Token(Token = "0x4003858")]
		[FieldOffset(Offset = "0x10")]
		public PlayerBuildingPowerBuff buff;

		// Token: 0x04003859 RID: 14425
		[Token(Token = "0x4003859")]
		[FieldOffset(Offset = "0x18")]
		public List<List<int>> presetQueue;
	}
}
