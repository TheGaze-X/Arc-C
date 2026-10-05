using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000AB0 RID: 2736
	[Token(Token = "0x2000AB0")]
	public class PlayerNodeDetailContent
	{
		// Token: 0x0600676E RID: 26478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600676E")]
		[Address(RVA = "0x1EFBF50", Offset = "0x1EFAB50", VA = "0x181EFBF50")]
		public PlayerNodeDetailContent()
		{
		}

		// Token: 0x040039B0 RID: 14768
		[Token(Token = "0x40039B0")]
		[FieldOffset(Offset = "0x10")]
		public string scene;

		// Token: 0x040039B1 RID: 14769
		[Token(Token = "0x40039B1")]
		[FieldOffset(Offset = "0x18")]
		public PlayerNodeDetailContent.BattleShop battleShop;

		// Token: 0x040039B2 RID: 14770
		[Token(Token = "0x40039B2")]
		[FieldOffset(Offset = "0x20")]
		public List<string> wish;

		// Token: 0x040039B3 RID: 14771
		[Token(Token = "0x40039B3")]
		[FieldOffset(Offset = "0x28")]
		public List<string> battle;

		// Token: 0x040039B4 RID: 14772
		[Token(Token = "0x40039B4")]
		[FieldOffset(Offset = "0x30")]
		public bool hasShopBoss;

		// Token: 0x02000AB1 RID: 2737
		[Token(Token = "0x2000AB1")]
		public class BattleShop
		{
			// Token: 0x0600676F RID: 26479 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600676F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BattleShop()
			{
			}

			// Token: 0x040039B5 RID: 14773
			[Token(Token = "0x40039B5")]
			[FieldOffset(Offset = "0x10")]
			public bool hasShopBoss;

			// Token: 0x040039B6 RID: 14774
			[Token(Token = "0x40039B6")]
			[FieldOffset(Offset = "0x18")]
			public List<string> goods;
		}
	}
}
