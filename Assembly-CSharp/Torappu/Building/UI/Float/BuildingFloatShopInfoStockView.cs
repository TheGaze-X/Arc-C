using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DF6 RID: 7670
	[Token(Token = "0x2001DF6")]
	public class BuildingFloatShopInfoStockView : MonoBehaviour
	{
		// Token: 0x0600BD71 RID: 48497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD71")]
		[Address(RVA = "0x33A1600", Offset = "0x33A0200", VA = "0x1833A1600")]
		public void Render(ShopStockInfoViewModel viewModel)
		{
		}

		// Token: 0x170016E7 RID: 5863
		// (set) Token: 0x0600BD72 RID: 48498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170016E7")]
		public float outputProgress
		{
			[Token(Token = "0x600BD72")]
			[Address(RVA = "0x33A19E0", Offset = "0x33A05E0", VA = "0x1833A19E0")]
			set
			{
			}
		}

		// Token: 0x0600BD73 RID: 48499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD73")]
		[Address(RVA = "0x33A1830", Offset = "0x33A0430", VA = "0x1833A1830")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600BD74 RID: 48500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD74")]
		[Address(RVA = "0x33A1970", Offset = "0x33A0570", VA = "0x1833A1970")]
		public BuildingFloatShopInfoStockView()
		{
		}

		// Token: 0x0400BDD3 RID: 48595
		[Token(Token = "0x400BDD3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0400BDD4 RID: 48596
		[Token(Token = "0x400BDD4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0400BDD5 RID: 48597
		[Token(Token = "0x400BDD5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelActive;

		// Token: 0x0400BDD6 RID: 48598
		[Token(Token = "0x400BDD6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _itemContainer;

		// Token: 0x0400BDD7 RID: 48599
		[Token(Token = "0x400BDD7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x0400BDD8 RID: 48600
		[Token(Token = "0x400BDD8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private FillProgressBar _progress;

		// Token: 0x0400BDD9 RID: 48601
		[Token(Token = "0x400BDD9")]
		[FieldOffset(Offset = "0x48")]
		private UIItemCard m_itemCard;

		// Token: 0x0400BDDA RID: 48602
		[Token(Token = "0x400BDDA")]
		[FieldOffset(Offset = "0x50")]
		private UIItemViewModel m_itemModel;

		// Token: 0x0400BDDB RID: 48603
		[Token(Token = "0x400BDDB")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x0400BDDC RID: 48604
		[Token(Token = "0x400BDDC")]
		[FieldOffset(Offset = "0x5C")]
		private int m_secsPerItem;
	}
}
