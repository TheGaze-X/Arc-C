using System;
using Il2CppDummyDll;

namespace Torappu.ObjectPool
{
	// Token: 0x02001484 RID: 5252
	[Token(Token = "0x2001484")]
	public struct GameObjectPoolStats
	{
		// Token: 0x040077BC RID: 30652
		[Token(Token = "0x40077BC")]
		[FieldOffset(Offset = "0x0")]
		public int usingCount;

		// Token: 0x040077BD RID: 30653
		[Token(Token = "0x40077BD")]
		[FieldOffset(Offset = "0x4")]
		public int unusedCount;

		// Token: 0x040077BE RID: 30654
		[Token(Token = "0x40077BE")]
		[FieldOffset(Offset = "0x8")]
		public int totalCount;

		// Token: 0x040077BF RID: 30655
		[Token(Token = "0x40077BF")]
		[FieldOffset(Offset = "0xC")]
		public int preloadSize;

		// Token: 0x040077C0 RID: 30656
		[Token(Token = "0x40077C0")]
		[FieldOffset(Offset = "0x10")]
		public int maxCapacity;

		// Token: 0x040077C1 RID: 30657
		[Token(Token = "0x40077C1")]
		[FieldOffset(Offset = "0x14")]
		public float lastAllocateAt;

		// Token: 0x040077C2 RID: 30658
		[Token(Token = "0x40077C2")]
		[FieldOffset(Offset = "0x18")]
		public float lastRecycleAt;
	}
}
