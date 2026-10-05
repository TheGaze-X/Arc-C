using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200131E RID: 4894
	[Token(Token = "0x200131E")]
	public class ShopGPTabDisplayData
	{
		// Token: 0x06007298 RID: 29336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007298")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ShopGPTabDisplayData()
		{
		}

		// Token: 0x04006C6D RID: 27757
		[Token(Token = "0x4006C6D")]
		[FieldOffset(Offset = "0x10")]
		public string tabId;

		// Token: 0x04006C6E RID: 27758
		[Token(Token = "0x4006C6E")]
		[FieldOffset(Offset = "0x18")]
		public string tabName;

		// Token: 0x04006C6F RID: 27759
		[Token(Token = "0x4006C6F")]
		[FieldOffset(Offset = "0x20")]
		public ShopGPTabType tabType;

		// Token: 0x04006C70 RID: 27760
		[Token(Token = "0x4006C70")]
		[FieldOffset(Offset = "0x24")]
		public int recomDisplayNum;

		// Token: 0x04006C71 RID: 27761
		[Token(Token = "0x4006C71")]
		[FieldOffset(Offset = "0x28")]
		public string tabPicId;

		// Token: 0x04006C72 RID: 27762
		[Token(Token = "0x4006C72")]
		[FieldOffset(Offset = "0x30")]
		public string tabPicOnColor;

		// Token: 0x04006C73 RID: 27763
		[Token(Token = "0x4006C73")]
		[FieldOffset(Offset = "0x38")]
		public string tabPicOffColor;

		// Token: 0x04006C74 RID: 27764
		[Token(Token = "0x4006C74")]
		[FieldOffset(Offset = "0x40")]
		public int sortId;

		// Token: 0x04006C75 RID: 27765
		[Token(Token = "0x4006C75")]
		[FieldOffset(Offset = "0x48")]
		public long tabStartTime;

		// Token: 0x04006C76 RID: 27766
		[Token(Token = "0x4006C76")]
		[FieldOffset(Offset = "0x50")]
		public long tabEndTime;

		// Token: 0x04006C77 RID: 27767
		[Token(Token = "0x4006C77")]
		[FieldOffset(Offset = "0x58")]
		public string markerPicId;
	}
}
