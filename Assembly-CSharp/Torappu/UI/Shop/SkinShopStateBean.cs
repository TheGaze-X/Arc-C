using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B65 RID: 23397
	[Token(Token = "0x2005B65")]
	public class SkinShopStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x17004F7D RID: 20349
		// (get) Token: 0x06021F6D RID: 139117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F7D")]
		public List<SkinShopViewModel> skinList
		{
			[Token(Token = "0x6021F6D")]
			[Address(RVA = "0x1C80430", Offset = "0x1C7F030", VA = "0x181C80430")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004F7E RID: 20350
		// (get) Token: 0x06021F6E RID: 139118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F7E")]
		public List<SkinShopBlindBoxViewModel> blindboxList
		{
			[Token(Token = "0x6021F6E")]
			[Address(RVA = "0x1C803D0", Offset = "0x1C7EFD0", VA = "0x181C803D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06021F6F RID: 139119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021F6F")]
		[Address(RVA = "0x1C7FD30", Offset = "0x1C7E930", VA = "0x181C7FD30")]
		public List<ISkinShopItemViewModel> GetSkinShopItemListOrdered()
		{
			return null;
		}

		// Token: 0x06021F70 RID: 139120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F70")]
		[Address(RVA = "0x1C7F7F0", Offset = "0x1C7E3F0", VA = "0x181C7F7F0")]
		public void ApplyData(List<ShopSkinItemViewModel> skinList, List<ShopBlindboxItemViewModel> blindboxList)
		{
		}

		// Token: 0x06021F71 RID: 139121 RVA: 0x000BBF20 File Offset: 0x000BA120
		[Token(Token = "0x6021F71")]
		[Address(RVA = "0x1C7FF50", Offset = "0x1C7EB50", VA = "0x181C7FF50")]
		public bool TryGetSkinIdByGoodId(string goodId, out string skinId)
		{
			return default(bool);
		}

		// Token: 0x06021F72 RID: 139122 RVA: 0x000BBF38 File Offset: 0x000BA138
		[Token(Token = "0x6021F72")]
		[Address(RVA = "0x1C7FD90", Offset = "0x1C7E990", VA = "0x181C7FD90")]
		public bool TryGetBlindboxByGoodId(string goodId, out SkinShopBlindBoxViewModel result)
		{
			return default(bool);
		}

		// Token: 0x06021F73 RID: 139123 RVA: 0x000BBF50 File Offset: 0x000BA150
		[Token(Token = "0x6021F73")]
		[Address(RVA = "0x1C80000", Offset = "0x1C7EC00", VA = "0x181C80000")]
		private int _CompareShopItemViewModel(ISkinShopItemViewModel l, ISkinShopItemViewModel r)
		{
			return 0;
		}

		// Token: 0x06021F74 RID: 139124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F74")]
		[Address(RVA = "0x1C80230", Offset = "0x1C7EE30", VA = "0x181C80230")]
		public SkinShopStateBean()
		{
		}

		// Token: 0x0402E8A5 RID: 190629
		[Token(Token = "0x402E8A5")]
		[FieldOffset(Offset = "0x18")]
		private List<SkinShopViewModel> m_skinList;

		// Token: 0x0402E8A6 RID: 190630
		[Token(Token = "0x402E8A6")]
		[FieldOffset(Offset = "0x20")]
		private List<SkinShopBlindBoxViewModel> m_blindboxList;

		// Token: 0x0402E8A7 RID: 190631
		[Token(Token = "0x402E8A7")]
		[FieldOffset(Offset = "0x28")]
		private List<ISkinShopItemViewModel> m_itemList;

		// Token: 0x0402E8A8 RID: 190632
		[Token(Token = "0x402E8A8")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, string> m_goodIdToSkinId;

		// Token: 0x0402E8A9 RID: 190633
		[Token(Token = "0x402E8A9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_skinList;

		// Token: 0x0402E8AA RID: 190634
		[Token(Token = "0x402E8AA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_blindboxList;

		// Token: 0x0402E8AB RID: 190635
		[Token(Token = "0x402E8AB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetSkinShopItemListOrdered;

		// Token: 0x0402E8AC RID: 190636
		[Token(Token = "0x402E8AC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0402E8AD RID: 190637
		[Token(Token = "0x402E8AD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TryGetSkinIdByGoodId;

		// Token: 0x0402E8AE RID: 190638
		[Token(Token = "0x402E8AE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TryGetBlindboxByGoodId;

		// Token: 0x0402E8AF RID: 190639
		[Token(Token = "0x402E8AF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CompareShopItemViewModel;

		// Token: 0x0402E8B0 RID: 190640
		[Token(Token = "0x402E8B0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
