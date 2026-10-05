using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x02001947 RID: 6471
	[Token(Token = "0x2001947")]
	public class DIYShopGroupItemView : MonoBehaviour
	{
		// Token: 0x0600A2B3 RID: 41651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2B3")]
		[Address(RVA = "0x31C3040", Offset = "0x31C1C40", VA = "0x1831C3040")]
		private void _OnFurnitureSelected(DIYShopItemViewData data, ShopFurnitureItemView view)
		{
		}

		// Token: 0x0600A2B4 RID: 41652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2B4")]
		[Address(RVA = "0x31C2170", Offset = "0x31C0D70", VA = "0x1831C2170")]
		public void Setup(DIYShopGroupItemModel model, [Optional] Predicate<IDIYShopItem> filter, [Optional] Comparison<IDIYShopItem> sorter)
		{
		}

		// Token: 0x0600A2B5 RID: 41653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2B5")]
		[Address(RVA = "0x31C1E20", Offset = "0x31C0A20", VA = "0x1831C1E20")]
		public void Refresh()
		{
		}

		// Token: 0x0600A2B6 RID: 41654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2B6")]
		[Address(RVA = "0x31C3070", Offset = "0x31C1C70", VA = "0x1831C3070")]
		private void _UpdateLayout()
		{
		}

		// Token: 0x0600A2B7 RID: 41655 RVA: 0x0003F498 File Offset: 0x0003D698
		[Token(Token = "0x600A2B7")]
		[Address(RVA = "0x31C2FD0", Offset = "0x31C1BD0", VA = "0x1831C2FD0")]
		private static int _GetFurnitureTotalCount(string furnitureId, IFurnitureStorage storage)
		{
			return 0;
		}

		// Token: 0x0600A2B8 RID: 41656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2B8")]
		[Address(RVA = "0x31C3190", Offset = "0x31C1D90", VA = "0x1831C3190")]
		public DIYShopGroupItemView()
		{
		}

		// Token: 0x04009922 RID: 39202
		[Token(Token = "0x4009922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _groupNameLabel;

		// Token: 0x04009923 RID: 39203
		[Token(Token = "0x4009923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _furnitureViewProto;

		// Token: 0x04009924 RID: 39204
		[Token(Token = "0x4009924")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _furnitureListContainer;

		// Token: 0x04009925 RID: 39205
		[Token(Token = "0x4009925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _marginSize;

		// Token: 0x04009926 RID: 39206
		[Token(Token = "0x4009926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private DIYShopGroupItemModel m_model;

		// Token: 0x04009927 RID: 39207
		[Token(Token = "0x4009927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<DIYShopItemViewData> m_furnitureDataList;

		// Token: 0x04009928 RID: 39208
		[Token(Token = "0x4009928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<ShopFurnitureItemView> m_furnitureViewList;
	}
}
