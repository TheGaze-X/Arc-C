using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040E7 RID: 16615
	[Token(Token = "0x20040E7")]
	public class SandboxV2AdminMainShopViewModel : IHotfixable
	{
		// Token: 0x06019B31 RID: 105265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B31")]
		[Address(RVA = "0x1285E80", Offset = "0x1284A80", VA = "0x181285E80")]
		public void LoadData(string topicId)
		{
		}

		// Token: 0x06019B32 RID: 105266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B32")]
		[Address(RVA = "0x1286650", Offset = "0x1285250", VA = "0x181286650")]
		public void RefreshDialogDesc(bool isAfterBuy)
		{
		}

		// Token: 0x06019B33 RID: 105267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019B33")]
		[Address(RVA = "0x1285DA0", Offset = "0x12849A0", VA = "0x181285DA0")]
		public SandboxV2AdminMainShopItemViewModel GetItemModel(int index)
		{
			return null;
		}

		// Token: 0x06019B34 RID: 105268 RVA: 0x0009F1B0 File Offset: 0x0009D3B0
		[Token(Token = "0x6019B34")]
		[Address(RVA = "0x1285C90", Offset = "0x1284890", VA = "0x181285C90")]
		public static bool CheckShopActive(string topicId)
		{
			return default(bool);
		}

		// Token: 0x06019B35 RID: 105269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B35")]
		[Address(RVA = "0x1286940", Offset = "0x1285540", VA = "0x181286940")]
		public SandboxV2AdminMainShopViewModel()
		{
		}

		// Token: 0x04020261 RID: 131681
		[Token(Token = "0x4020261")]
		[FieldOffset(Offset = "0x10")]
		public List<SandboxV2AdminMainShopItemViewModel> itemList;

		// Token: 0x04020262 RID: 131682
		[Token(Token = "0x4020262")]
		[FieldOffset(Offset = "0x18")]
		public bool hasGoldItem;

		// Token: 0x04020263 RID: 131683
		[Token(Token = "0x4020263")]
		[FieldOffset(Offset = "0x20")]
		public string goldItemId;

		// Token: 0x04020264 RID: 131684
		[Token(Token = "0x4020264")]
		[FieldOffset(Offset = "0x28")]
		public int goldCount;

		// Token: 0x04020265 RID: 131685
		[Token(Token = "0x4020265")]
		[FieldOffset(Offset = "0x2C")]
		public bool hasDimensionCoinItem;

		// Token: 0x04020266 RID: 131686
		[Token(Token = "0x4020266")]
		[FieldOffset(Offset = "0x30")]
		public string dimensionCoinItemId;

		// Token: 0x04020267 RID: 131687
		[Token(Token = "0x4020267")]
		[FieldOffset(Offset = "0x38")]
		public int dimensionCoinCount;

		// Token: 0x04020268 RID: 131688
		[Token(Token = "0x4020268")]
		[FieldOffset(Offset = "0x3C")]
		public int refreshRemain;

		// Token: 0x04020269 RID: 131689
		[Token(Token = "0x4020269")]
		[FieldOffset(Offset = "0x40")]
		public string npcName;

		// Token: 0x0402026A RID: 131690
		[Token(Token = "0x402026A")]
		[FieldOffset(Offset = "0x48")]
		public string dialogDesc;

		// Token: 0x0402026B RID: 131691
		[Token(Token = "0x402026B")]
		[FieldOffset(Offset = "0x50")]
		public string topicId;

		// Token: 0x0402026C RID: 131692
		[Token(Token = "0x402026C")]
		[FieldOffset(Offset = "0x58")]
		private SandboxV2ShopDialogData m_dialogData;

		// Token: 0x0402026D RID: 131693
		[Token(Token = "0x402026D")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isAllSoldOut;

		// Token: 0x0402026E RID: 131694
		[Token(Token = "0x402026E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402026F RID: 131695
		[Token(Token = "0x402026F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshDialogDesc;

		// Token: 0x04020270 RID: 131696
		[Token(Token = "0x4020270")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetItemModel;

		// Token: 0x04020271 RID: 131697
		[Token(Token = "0x4020271")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckShopActive;

		// Token: 0x04020272 RID: 131698
		[Token(Token = "0x4020272")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
