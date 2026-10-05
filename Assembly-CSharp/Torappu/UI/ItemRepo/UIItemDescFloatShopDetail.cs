using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E43 RID: 24131
	[Token(Token = "0x2005E43")]
	public class UIItemDescFloatShopDetail : MonoBehaviour, IHotfixable
	{
		// Token: 0x170052DD RID: 21213
		// (get) Token: 0x06022F60 RID: 143200 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022F61 RID: 143201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170052DD")]
		public Action<ItemData.ShopRelateInfo> onShopClicked
		{
			[Token(Token = "0x6022F60")]
			[Address(RVA = "0x1D8E8A0", Offset = "0x1D8D4A0", VA = "0x181D8E8A0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022F61")]
			[Address(RVA = "0x1D8E900", Offset = "0x1D8D500", VA = "0x181D8E900")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06022F62 RID: 143202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F62")]
		[Address(RVA = "0x1D8E700", Offset = "0x1D8D300", VA = "0x181D8E700")]
		public void Render(ItemData.ShopRelateInfo shopData, string shopName, bool isEnable)
		{
		}

		// Token: 0x06022F63 RID: 143203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F63")]
		[Address(RVA = "0x1D8E5F0", Offset = "0x1D8D1F0", VA = "0x181D8E5F0")]
		public void EventOnBtnClicked()
		{
		}

		// Token: 0x06022F64 RID: 143204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F64")]
		[Address(RVA = "0x1D8E840", Offset = "0x1D8D440", VA = "0x181D8E840")]
		public UIItemDescFloatShopDetail()
		{
		}

		// Token: 0x040302B7 RID: 197303
		[Token(Token = "0x40302B7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textShopName;

		// Token: 0x040302B8 RID: 197304
		[Token(Token = "0x40302B8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelLockedBtn;

		// Token: 0x040302B9 RID: 197305
		[Token(Token = "0x40302B9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelGotoBtn;

		// Token: 0x040302BA RID: 197306
		[Token(Token = "0x40302BA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _btnGoto;

		// Token: 0x040302BB RID: 197307
		[Token(Token = "0x40302BB")]
		[FieldOffset(Offset = "0x38")]
		private ItemData.ShopRelateInfo m_cachedShopData;

		// Token: 0x040302BD RID: 197309
		[Token(Token = "0x40302BD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onShopClicked;

		// Token: 0x040302BE RID: 197310
		[Token(Token = "0x40302BE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onShopClicked;

		// Token: 0x040302BF RID: 197311
		[Token(Token = "0x40302BF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040302C0 RID: 197312
		[Token(Token = "0x40302C0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnBtnClicked;

		// Token: 0x040302C1 RID: 197313
		[Token(Token = "0x40302C1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
