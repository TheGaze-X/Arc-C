using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A6F RID: 2671
	[Token(Token = "0x2000A6F")]
	public class PlayerBuildingTradingNext
	{
		// Token: 0x0600672C RID: 26412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600672C")]
		[Address(RVA = "0x1EEA3E0", Offset = "0x1EE8FE0", VA = "0x181EEA3E0")]
		public PlayerBuildingTradingNext()
		{
		}

		// Token: 0x040038BC RID: 14524
		[Token(Token = "0x40038BC")]
		[FieldOffset(Offset = "0x10")]
		public long order;

		// Token: 0x040038BD RID: 14525
		[Token(Token = "0x40038BD")]
		[FieldOffset(Offset = "0x18")]
		public double processPoint;

		// Token: 0x040038BE RID: 14526
		[Token(Token = "0x40038BE")]
		[FieldOffset(Offset = "0x20")]
		public double speed;

		// Token: 0x040038BF RID: 14527
		[Token(Token = "0x40038BF")]
		[FieldOffset(Offset = "0x28")]
		public int maxPoint;
	}
}
