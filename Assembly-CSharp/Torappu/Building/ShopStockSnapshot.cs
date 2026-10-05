using System;
using Il2CppDummyDll;

namespace Torappu.Building
{
	// Token: 0x02001815 RID: 6165
	[Token(Token = "0x2001815")]
	public struct ShopStockSnapshot
	{
		// Token: 0x17001134 RID: 4404
		// (get) Token: 0x06009C09 RID: 39945 RVA: 0x0003CCC0 File Offset: 0x0003AEC0
		[Token(Token = "0x17001134")]
		public int remainSecsForProgress
		{
			[Token(Token = "0x6009C09")]
			[Address(RVA = "0x3188690", Offset = "0x3187290", VA = "0x183188690")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001135 RID: 4405
		// (get) Token: 0x06009C0A RID: 39946 RVA: 0x0003CCD8 File Offset: 0x0003AED8
		[Token(Token = "0x17001135")]
		public bool isEmpty
		{
			[Token(Token = "0x6009C0A")]
			[Address(RVA = "0x31885D0", Offset = "0x31871D0", VA = "0x1831885D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x040092CE RID: 37582
		[Token(Token = "0x40092CE")]
		[FieldOffset(Offset = "0x0")]
		public static ShopStockSnapshot DEFAULT;

		// Token: 0x040092CF RID: 37583
		[Token(Token = "0x40092CF")]
		[FieldOffset(Offset = "0x0")]
		public DateTime time;

		// Token: 0x040092D0 RID: 37584
		[Token(Token = "0x40092D0")]
		[FieldOffset(Offset = "0x8")]
		public string itemId;

		// Token: 0x040092D1 RID: 37585
		[Token(Token = "0x40092D1")]
		[FieldOffset(Offset = "0x10")]
		public string formulaId;

		// Token: 0x040092D2 RID: 37586
		[Token(Token = "0x40092D2")]
		[FieldOffset(Offset = "0x18")]
		public int remainCount;

		// Token: 0x040092D3 RID: 37587
		[Token(Token = "0x40092D3")]
		[FieldOffset(Offset = "0x20")]
		public double baseRemainPoint;

		// Token: 0x040092D4 RID: 37588
		[Token(Token = "0x40092D4")]
		[FieldOffset(Offset = "0x28")]
		public int additionOutput;

		// Token: 0x040092D5 RID: 37589
		[Token(Token = "0x40092D5")]
		[FieldOffset(Offset = "0x2C")]
		public int nextRemainSecs;

		// Token: 0x040092D6 RID: 37590
		[Token(Token = "0x40092D6")]
		[FieldOffset(Offset = "0x30")]
		public int totalRemainSecs;
	}
}
