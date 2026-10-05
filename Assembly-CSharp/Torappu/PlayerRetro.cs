using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A46 RID: 2630
	[Token(Token = "0x2000A46")]
	public class PlayerRetro
	{
		// Token: 0x06006705 RID: 26373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006705")]
		[Address(RVA = "0x1EFC520", Offset = "0x1EFB120", VA = "0x181EFC520")]
		public PlayerRetro()
		{
		}

		// Token: 0x0400382C RID: 14380
		[Token(Token = "0x400382C")]
		[FieldOffset(Offset = "0x10")]
		public int coin;

		// Token: 0x0400382D RID: 14381
		[Token(Token = "0x400382D")]
		[FieldOffset(Offset = "0x14")]
		public bool supplement;

		// Token: 0x0400382E RID: 14382
		[Token(Token = "0x400382E")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, PlayerRetroBlock> block;

		// Token: 0x0400382F RID: 14383
		[Token(Token = "0x400382F")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, Dictionary<string, bool>> trail;

		// Token: 0x04003830 RID: 14384
		[Token(Token = "0x4003830")]
		[FieldOffset(Offset = "0x28")]
		public List<string> rewardPerm;
	}
}
