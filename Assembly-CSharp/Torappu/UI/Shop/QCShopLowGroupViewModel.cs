using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B13 RID: 23315
	[Token(Token = "0x2005B13")]
	public class QCShopLowGroupViewModel
	{
		// Token: 0x06021DE2 RID: 138722 RVA: 0x000BB788 File Offset: 0x000B9988
		[Token(Token = "0x6021DE2")]
		[Address(RVA = "0x1C5B700", Offset = "0x1C5A300", VA = "0x181C5B700")]
		public float GetUnlockProgress()
		{
			return 0f;
		}

		// Token: 0x06021DE3 RID: 138723 RVA: 0x000BB7A0 File Offset: 0x000B99A0
		[Token(Token = "0x6021DE3")]
		[Address(RVA = "0x1C5B680", Offset = "0x1C5A280", VA = "0x181C5B680")]
		public int GetRemainingCostToUnlock()
		{
			return 0;
		}

		// Token: 0x06021DE4 RID: 138724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DE4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public QCShopLowGroupViewModel()
		{
		}

		// Token: 0x0402E666 RID: 190054
		[Token(Token = "0x402E666")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x0402E667 RID: 190055
		[Token(Token = "0x402E667")]
		[FieldOffset(Offset = "0x18")]
		public bool isLocked;

		// Token: 0x0402E668 RID: 190056
		[Token(Token = "0x402E668")]
		[FieldOffset(Offset = "0x1C")]
		public int lggThreshold;

		// Token: 0x0402E669 RID: 190057
		[Token(Token = "0x402E669")]
		[FieldOffset(Offset = "0x20")]
		public int lggCostTotal;

		// Token: 0x0402E66A RID: 190058
		[Token(Token = "0x402E66A")]
		[FieldOffset(Offset = "0x24")]
		public int lowShopType;

		// Token: 0x0402E66B RID: 190059
		[Token(Token = "0x402E66B")]
		[FieldOffset(Offset = "0x28")]
		public List<QCCommonObj> objList;
	}
}
