using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005A6D RID: 23149
	[Token(Token = "0x2005A6D")]
	public class SkinShopBlindboxSkinListItemViewModel : IHotfixable
	{
		// Token: 0x06021AE9 RID: 137961 RVA: 0x000BB140 File Offset: 0x000B9340
		[Token(Token = "0x6021AE9")]
		[Address(RVA = "0x1C29310", Offset = "0x1C27F10", VA = "0x181C29310")]
		public int CompareTo(SkinShopBlindboxSkinListItemViewModel other)
		{
			return 0;
		}

		// Token: 0x06021AEA RID: 137962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021AEA")]
		[Address(RVA = "0x1C293C0", Offset = "0x1C27FC0", VA = "0x181C293C0")]
		public SkinShopBlindboxSkinListItemViewModel()
		{
		}

		// Token: 0x0402E0E1 RID: 188641
		[Token(Token = "0x402E0E1")]
		[FieldOffset(Offset = "0x10")]
		public string skinId;

		// Token: 0x0402E0E2 RID: 188642
		[Token(Token = "0x402E0E2")]
		[FieldOffset(Offset = "0x18")]
		public string skinName;

		// Token: 0x0402E0E3 RID: 188643
		[Token(Token = "0x402E0E3")]
		[FieldOffset(Offset = "0x20")]
		public string charId;

		// Token: 0x0402E0E4 RID: 188644
		[Token(Token = "0x402E0E4")]
		[FieldOffset(Offset = "0x28")]
		public string charName;

		// Token: 0x0402E0E5 RID: 188645
		[Token(Token = "0x402E0E5")]
		[FieldOffset(Offset = "0x30")]
		public string descriptionStr;

		// Token: 0x0402E0E6 RID: 188646
		[Token(Token = "0x402E0E6")]
		[FieldOffset(Offset = "0x38")]
		public int sortId;

		// Token: 0x0402E0E7 RID: 188647
		[Token(Token = "0x402E0E7")]
		[FieldOffset(Offset = "0x3C")]
		public SkinObtainApproachType obtainApproachType;

		// Token: 0x0402E0E8 RID: 188648
		[Token(Token = "0x402E0E8")]
		[FieldOffset(Offset = "0x40")]
		public int price;

		// Token: 0x0402E0E9 RID: 188649
		[Token(Token = "0x402E0E9")]
		[FieldOffset(Offset = "0x44")]
		public bool isAchieved;

		// Token: 0x0402E0EA RID: 188650
		[Token(Token = "0x402E0EA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0402E0EB RID: 188651
		[Token(Token = "0x402E0EB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
