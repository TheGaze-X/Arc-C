using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x0200198C RID: 6540
	[Token(Token = "0x200198C")]
	public class DIYFurniturePanelSortItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600A410 RID: 42000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A410")]
		[Address(RVA = "0x31DB6A0", Offset = "0x31DA2A0", VA = "0x1831DB6A0")]
		public void Render(DIYSortMethodModel sortMethodModel, int selectedIndex)
		{
		}

		// Token: 0x0600A411 RID: 42001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A411")]
		[Address(RVA = "0x31DB610", Offset = "0x31DA210", VA = "0x1831DB610")]
		public void OnClicked()
		{
		}

		// Token: 0x0600A412 RID: 42002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A412")]
		[Address(RVA = "0x31DBAC0", Offset = "0x31DA6C0", VA = "0x1831DBAC0")]
		public DIYFurniturePanelSortItem()
		{
		}

		// Token: 0x04009B0B RID: 39691
		[Token(Token = "0x4009B0B")]
		[FieldOffset(Offset = "0x0")]
		private static Color BKG_COLOR_1;

		// Token: 0x04009B0C RID: 39692
		[Token(Token = "0x4009B0C")]
		[FieldOffset(Offset = "0x10")]
		private static Color BKG_COLOR_2;

		// Token: 0x04009B0D RID: 39693
		[Token(Token = "0x4009B0D")]
		[FieldOffset(Offset = "0x20")]
		private static Color ARROW_COLOR_ACTIVE;

		// Token: 0x04009B0E RID: 39694
		[Token(Token = "0x4009B0E")]
		[FieldOffset(Offset = "0x30")]
		private static Color ARROW_COLOR_INACTIVE;

		// Token: 0x04009B0F RID: 39695
		[Token(Token = "0x4009B0F")]
		[FieldOffset(Offset = "0x40")]
		private static Color TEXT_COLOR_SELECTED;

		// Token: 0x04009B10 RID: 39696
		[Token(Token = "0x4009B10")]
		[FieldOffset(Offset = "0x50")]
		private static Color TEXT_COLOR_NORMAL;

		// Token: 0x04009B11 RID: 39697
		[Token(Token = "0x4009B11")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _background;

		// Token: 0x04009B12 RID: 39698
		[Token(Token = "0x4009B12")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _sortMethodName;

		// Token: 0x04009B13 RID: 39699
		[Token(Token = "0x4009B13")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _imgAscending;

		// Token: 0x04009B14 RID: 39700
		[Token(Token = "0x4009B14")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _imgDescending;

		// Token: 0x04009B15 RID: 39701
		[Token(Token = "0x4009B15")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _selected;

		// Token: 0x04009B16 RID: 39702
		[Token(Token = "0x4009B16")]
		[FieldOffset(Offset = "0x40")]
		private int m_cachedIndex;

		// Token: 0x04009B17 RID: 39703
		[Token(Token = "0x4009B17")]
		[FieldOffset(Offset = "0x44")]
		private BuildingData.DiySortType m_cachedDiySortType;

		// Token: 0x04009B18 RID: 39704
		[Token(Token = "0x4009B18")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public Action<BuildingData.DiySortType, int> eventOnClicked;

		// Token: 0x04009B19 RID: 39705
		[Token(Token = "0x4009B19")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04009B1A RID: 39706
		[Token(Token = "0x4009B1A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnClicked;

		// Token: 0x04009B1B RID: 39707
		[Token(Token = "0x4009B1B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
