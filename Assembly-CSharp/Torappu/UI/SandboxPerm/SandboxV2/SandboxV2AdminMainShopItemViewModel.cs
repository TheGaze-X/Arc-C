using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040E6 RID: 16614
	[Token(Token = "0x20040E6")]
	public class SandboxV2AdminMainShopItemViewModel : IComparable, IHotfixable
	{
		// Token: 0x06019B2F RID: 105263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B2F")]
		[Address(RVA = "0x1283BE0", Offset = "0x12827E0", VA = "0x181283BE0")]
		public SandboxV2AdminMainShopItemViewModel(int index, string topicId, SandboxV2ShopGoodData goodData, SandboxPermItemData itemData, PlayerSandboxV2.Shop.ShopSlotData playerData, SandboxV2BasicConst constData)
		{
		}

		// Token: 0x06019B30 RID: 105264 RVA: 0x0009F198 File Offset: 0x0009D398
		[Token(Token = "0x6019B30")]
		[Address(RVA = "0x1283AA0", Offset = "0x12826A0", VA = "0x181283AA0", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x04020251 RID: 131665
		[Token(Token = "0x4020251")]
		[FieldOffset(Offset = "0x10")]
		public int index;

		// Token: 0x04020252 RID: 131666
		[Token(Token = "0x4020252")]
		[FieldOffset(Offset = "0x18")]
		public string goodId;

		// Token: 0x04020253 RID: 131667
		[Token(Token = "0x4020253")]
		[FieldOffset(Offset = "0x20")]
		public string itemId;

		// Token: 0x04020254 RID: 131668
		[Token(Token = "0x4020254")]
		[FieldOffset(Offset = "0x28")]
		public string itemName;

		// Token: 0x04020255 RID: 131669
		[Token(Token = "0x4020255")]
		[FieldOffset(Offset = "0x30")]
		public int itemCount;

		// Token: 0x04020256 RID: 131670
		[Token(Token = "0x4020256")]
		[FieldOffset(Offset = "0x34")]
		public SandboxV2CoinType coinType;

		// Token: 0x04020257 RID: 131671
		[Token(Token = "0x4020257")]
		[FieldOffset(Offset = "0x38")]
		public int originPrice;

		// Token: 0x04020258 RID: 131672
		[Token(Token = "0x4020258")]
		[FieldOffset(Offset = "0x3C")]
		public int currPrice;

		// Token: 0x04020259 RID: 131673
		[Token(Token = "0x4020259")]
		[FieldOffset(Offset = "0x40")]
		public bool isDiscount;

		// Token: 0x0402025A RID: 131674
		[Token(Token = "0x402025A")]
		[FieldOffset(Offset = "0x44")]
		public int stock;

		// Token: 0x0402025B RID: 131675
		[Token(Token = "0x402025B")]
		[FieldOffset(Offset = "0x48")]
		public bool isSoldOut;

		// Token: 0x0402025C RID: 131676
		[Token(Token = "0x402025C")]
		[FieldOffset(Offset = "0x50")]
		public string goldItemId;

		// Token: 0x0402025D RID: 131677
		[Token(Token = "0x402025D")]
		[FieldOffset(Offset = "0x58")]
		public string dimensionCoinItemId;

		// Token: 0x0402025E RID: 131678
		[Token(Token = "0x402025E")]
		[FieldOffset(Offset = "0x60")]
		public string topicId;

		// Token: 0x0402025F RID: 131679
		[Token(Token = "0x402025F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04020260 RID: 131680
		[Token(Token = "0x4020260")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CompareTo;
	}
}
