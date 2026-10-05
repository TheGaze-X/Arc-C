using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AD8 RID: 23256
	[Token(Token = "0x2005AD8")]
	public abstract class ShopGPCommonItemViewModel : IHotfixable
	{
		// Token: 0x06021CEA RID: 138474
		[Token(Token = "0x6021CEA")]
		public abstract NormalGPItem ReturnCommonItem();

		// Token: 0x06021CEB RID: 138475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021CEB")]
		[Address(RVA = "0x1C4BAA0", Offset = "0x1C4A6A0", VA = "0x181C4BAA0", Slot = "5")]
		public virtual PlayerGoodItemData ReturnPlayerInfo()
		{
			return null;
		}

		// Token: 0x06021CEC RID: 138476 RVA: 0x000BB4D0 File Offset: 0x000B96D0
		[Token(Token = "0x6021CEC")]
		[Address(RVA = "0x1C4BA20", Offset = "0x1C4A620", VA = "0x181C4BA20")]
		public ShopCashInfo GetCashInfo()
		{
			return default(ShopCashInfo);
		}

		// Token: 0x06021CED RID: 138477 RVA: 0x000BB4E8 File Offset: 0x000B96E8
		[Token(Token = "0x6021CED")]
		[Address(RVA = "0x1C4BB30", Offset = "0x1C4A730", VA = "0x181C4BB30")]
		public bool TryLoadCashInfo(string goodId, int priceInData, ShopCurrencyUnit unit)
		{
			return default(bool);
		}

		// Token: 0x06021CEE RID: 138478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CEE")]
		[Address(RVA = "0x1C4BC70", Offset = "0x1C4A870", VA = "0x181C4BC70")]
		protected ShopGPCommonItemViewModel()
		{
		}

		// Token: 0x0402E48A RID: 189578
		[Token(Token = "0x402E48A")]
		[FieldOffset(Offset = "0x10")]
		private ShopCashInfo m_cashInfo;

		// Token: 0x0402E48B RID: 189579
		[Token(Token = "0x402E48B")]
		[FieldOffset(Offset = "0x20")]
		public GPType type;

		// Token: 0x0402E48C RID: 189580
		[Token(Token = "0x402E48C")]
		[FieldOffset(Offset = "0x24")]
		public int priority;

		// Token: 0x0402E48D RID: 189581
		[Token(Token = "0x402E48D")]
		[FieldOffset(Offset = "0x28")]
		public bool isAvail;

		// Token: 0x0402E48E RID: 189582
		[Token(Token = "0x402E48E")]
		[FieldOffset(Offset = "0x29")]
		public bool canUseTicket;

		// Token: 0x0402E48F RID: 189583
		[Token(Token = "0x402E48F")]
		[FieldOffset(Offset = "0x30")]
		public string ticketItemId;

		// Token: 0x0402E490 RID: 189584
		[Token(Token = "0x402E490")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ReturnPlayerInfo;

		// Token: 0x0402E491 RID: 189585
		[Token(Token = "0x402E491")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCashInfo;

		// Token: 0x0402E492 RID: 189586
		[Token(Token = "0x402E492")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TryLoadCashInfo;

		// Token: 0x0402E493 RID: 189587
		[Token(Token = "0x402E493")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
