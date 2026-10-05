using System;
using Il2CppDummyDll;

namespace Torappu.Battle.Racing
{
	// Token: 0x0200297D RID: 10621
	[Token(Token = "0x200297D")]
	[Serializable]
	public struct RacingFinishRecord
	{
		// Token: 0x04013A29 RID: 80425
		[Token(Token = "0x4013A29")]
		[FieldOffset(Offset = "0x0")]
		public int time;

		// Token: 0x04013A2A RID: 80426
		[Token(Token = "0x4013A2A")]
		[FieldOffset(Offset = "0x4")]
		public int dist;
	}
}
