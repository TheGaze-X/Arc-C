using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x0200271C RID: 10012
	[Token(Token = "0x200271C")]
	public class ShopData
	{
		// Token: 0x06010476 RID: 66678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010476")]
		[Address(RVA = "0x80B440", Offset = "0x80A040", VA = "0x18080B440")]
		public ShopData()
		{
		}

		// Token: 0x04012313 RID: 74515
		[Token(Token = "0x4012313")]
		[FieldOffset(Offset = "0x10")]
		public int level;

		// Token: 0x04012314 RID: 74516
		[Token(Token = "0x4012314")]
		[FieldOffset(Offset = "0x14")]
		public int currentCoin;

		// Token: 0x04012315 RID: 74517
		[Token(Token = "0x4012315")]
		[FieldOffset(Offset = "0x18")]
		public int upgradePrice;

		// Token: 0x04012316 RID: 74518
		[Token(Token = "0x4012316")]
		[FieldOffset(Offset = "0x1C")]
		public int refreshPrice;

		// Token: 0x04012317 RID: 74519
		[Token(Token = "0x4012317")]
		[FieldOffset(Offset = "0x20")]
		public AutoChessBattleShopGoodsType goodsType;

		// Token: 0x04012318 RID: 74520
		[Token(Token = "0x4012318")]
		[FieldOffset(Offset = "0x24")]
		public int freeRefreshCnt;

		// Token: 0x04012319 RID: 74521
		[Token(Token = "0x4012319")]
		[FieldOffset(Offset = "0x28")]
		public bool specialRefresh;

		// Token: 0x0401231A RID: 74522
		[Token(Token = "0x401231A")]
		[FieldOffset(Offset = "0x30")]
		public List<ChessGoods> chessGoods;

		// Token: 0x0401231B RID: 74523
		[Token(Token = "0x401231B")]
		[FieldOffset(Offset = "0x38")]
		public int refreshSeq;
	}
}
