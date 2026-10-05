using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C99 RID: 23705
	[Token(Token = "0x2005C99")]
	public class ClimbTowerSweepRequest
	{
		// Token: 0x06022517 RID: 140567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022517")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ClimbTowerSweepRequest()
		{
		}

		// Token: 0x0402F1EC RID: 193004
		[Token(Token = "0x402F1EC")]
		[FieldOffset(Offset = "0x10")]
		public string tower;

		// Token: 0x0402F1ED RID: 193005
		[Token(Token = "0x402F1ED")]
		[FieldOffset(Offset = "0x18")]
		public bool isHard;

		// Token: 0x0402F1EE RID: 193006
		[Token(Token = "0x402F1EE")]
		[FieldOffset(Offset = "0x20")]
		public string itemId;

		// Token: 0x0402F1EF RID: 193007
		[Token(Token = "0x402F1EF")]
		[FieldOffset(Offset = "0x28")]
		public List<int> instIds;
	}
}
