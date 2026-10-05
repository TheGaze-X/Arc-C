using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x02000866 RID: 2150
	[Token(Token = "0x2000866")]
	public class ShopSkinItemViewModel : IHotfixable
	{
		// Token: 0x06006500 RID: 25856 RVA: 0x00030648 File Offset: 0x0002E848
		[Token(Token = "0x6006500")]
		[Address(RVA = "0x1F016D0", Offset = "0x1F002D0", VA = "0x181F016D0")]
		public ShopCashInfo GetCashInfo()
		{
			return default(ShopCashInfo);
		}

		// Token: 0x06006501 RID: 25857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006501")]
		[Address(RVA = "0x1F017C0", Offset = "0x1F003C0", VA = "0x181F017C0")]
		public ShopSkinItemViewModel()
		{
		}

		// Token: 0x0400318C RID: 12684
		[Token(Token = "0x400318C")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x0400318D RID: 12685
		[Token(Token = "0x400318D")]
		[FieldOffset(Offset = "0x18")]
		public int slotId;

		// Token: 0x0400318E RID: 12686
		[Token(Token = "0x400318E")]
		[FieldOffset(Offset = "0x20")]
		public string skinId;

		// Token: 0x0400318F RID: 12687
		[Token(Token = "0x400318F")]
		[FieldOffset(Offset = "0x28")]
		public int originPrice;

		// Token: 0x04003190 RID: 12688
		[Token(Token = "0x4003190")]
		[FieldOffset(Offset = "0x2C")]
		public int price;

		// Token: 0x04003191 RID: 12689
		[Token(Token = "0x4003191")]
		[FieldOffset(Offset = "0x30")]
		public float discount;

		// Token: 0x04003192 RID: 12690
		[Token(Token = "0x4003192")]
		[FieldOffset(Offset = "0x38")]
		public string skinName;

		// Token: 0x04003193 RID: 12691
		[Token(Token = "0x4003193")]
		[FieldOffset(Offset = "0x40")]
		public ShopCurrencyUnit currencyUnit;

		// Token: 0x04003194 RID: 12692
		[Token(Token = "0x4003194")]
		[FieldOffset(Offset = "0x48")]
		public long startDateTime;

		// Token: 0x04003195 RID: 12693
		[Token(Token = "0x4003195")]
		[FieldOffset(Offset = "0x50")]
		public long endDateTime;

		// Token: 0x04003196 RID: 12694
		[Token(Token = "0x4003196")]
		[FieldOffset(Offset = "0x58")]
		public bool isRedeem;

		// Token: 0x04003197 RID: 12695
		[Token(Token = "0x4003197")]
		[FieldOffset(Offset = "0x60")]
		public string giftAvatarId;

		// Token: 0x04003198 RID: 12696
		[Token(Token = "0x4003198")]
		[FieldOffset(Offset = "0x68")]
		public string giftDesc;

		// Token: 0x04003199 RID: 12697
		[Token(Token = "0x4003199")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCashInfo;

		// Token: 0x0400319A RID: 12698
		[Token(Token = "0x400319A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
