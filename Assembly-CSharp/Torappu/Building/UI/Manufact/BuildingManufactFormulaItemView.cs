using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Manufact
{
	// Token: 0x02001D9F RID: 7583
	[Token(Token = "0x2001D9F")]
	public class BuildingManufactFormulaItemView : MonoBehaviour
	{
		// Token: 0x0600BB0F RID: 47887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB0F")]
		[Address(RVA = "0x336B1A0", Offset = "0x3369DA0", VA = "0x18336B1A0")]
		public void Render(MFormulaViewModel viewModel, bool isSelected)
		{
		}

		// Token: 0x0600BB10 RID: 47888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB10")]
		[Address(RVA = "0x336B4D0", Offset = "0x336A0D0", VA = "0x18336B4D0")]
		private void _Init(MFormulaViewModel viewModel)
		{
		}

		// Token: 0x0600BB11 RID: 47889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB11")]
		[Address(RVA = "0x336B790", Offset = "0x336A390", VA = "0x18336B790")]
		private void _OnFormulaClicked()
		{
		}

		// Token: 0x0600BB12 RID: 47890 RVA: 0x00045E28 File Offset: 0x00044028
		[Token(Token = "0x600BB12")]
		[Address(RVA = "0x336B7B0", Offset = "0x336A3B0", VA = "0x18336B7B0")]
		private bool _OnFormulaLongPressed()
		{
			return default(bool);
		}

		// Token: 0x0600BB13 RID: 47891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB13")]
		[Address(RVA = "0x336B810", Offset = "0x336A410", VA = "0x18336B810")]
		public BuildingManufactFormulaItemView()
		{
		}

		// Token: 0x0400BA63 RID: 47715
		[Token(Token = "0x400BA63")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _itemContainer;

		// Token: 0x0400BA64 RID: 47716
		[Token(Token = "0x400BA64")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _targetScale;

		// Token: 0x0400BA65 RID: 47717
		[Token(Token = "0x400BA65")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _costContainer;

		// Token: 0x0400BA66 RID: 47718
		[Token(Token = "0x400BA66")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelClickSpot;

		// Token: 0x0400BA67 RID: 47719
		[Token(Token = "0x400BA67")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0400BA68 RID: 47720
		[Token(Token = "0x400BA68")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0400BA69 RID: 47721
		[Token(Token = "0x400BA69")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIBicolorText _textTime;

		// Token: 0x0400BA6A RID: 47722
		[Token(Token = "0x400BA6A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textUnlockCond;

		// Token: 0x0400BA6B RID: 47723
		[Token(Token = "0x400BA6B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UILongPressButton _btnFormula;

		// Token: 0x0400BA6C RID: 47724
		[Token(Token = "0x400BA6C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textWeight;

		// Token: 0x0400BA6D RID: 47725
		[Token(Token = "0x400BA6D")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public Action<MFormulaViewModel> onFormulaClicked;

		// Token: 0x0400BA6E RID: 47726
		[Token(Token = "0x400BA6E")]
		[FieldOffset(Offset = "0x70")]
		private MFormulaViewModel m_cachedFormula;

		// Token: 0x0400BA6F RID: 47727
		[Token(Token = "0x400BA6F")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isSelected;

		// Token: 0x0400BA70 RID: 47728
		[Token(Token = "0x400BA70")]
		[FieldOffset(Offset = "0x79")]
		private bool m_isInited;

		// Token: 0x0400BA71 RID: 47729
		[Token(Token = "0x400BA71")]
		[FieldOffset(Offset = "0x80")]
		private BuildingManufactFormulaItemView.CostAdapter m_costAdapter;

		// Token: 0x0400BA72 RID: 47730
		[Token(Token = "0x400BA72")]
		[FieldOffset(Offset = "0x88")]
		private UIItemCard m_targetItemCard;

		// Token: 0x0400BA73 RID: 47731
		[Token(Token = "0x400BA73")]
		[FieldOffset(Offset = "0x90")]
		private UIItemViewModel m_targetItemModel;

		// Token: 0x02001DA0 RID: 7584
		[Token(Token = "0x2001DA0")]
		private class CostAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0600BB14 RID: 47892 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BB14")]
			[Address(RVA = "0x3372270", Offset = "0x3370E70", VA = "0x183372270")]
			public CostAdapter(BuildingManufactFormulaItemView closure)
			{
			}

			// Token: 0x170016A4 RID: 5796
			// (get) Token: 0x0600BB15 RID: 47893 RVA: 0x00045E40 File Offset: 0x00044040
			[Token(Token = "0x170016A4")]
			public override int count
			{
				[Token(Token = "0x600BB15")]
				[Address(RVA = "0x33722F0", Offset = "0x3370EF0", VA = "0x1833722F0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600BB16 RID: 47894 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600BB16")]
			[Address(RVA = "0x3371F30", Offset = "0x3370B30", VA = "0x183371F30", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0400BA74 RID: 47732
			[Token(Token = "0x400BA74")]
			[FieldOffset(Offset = "0x20")]
			private BuildingManufactFormulaItemView m_closure;

			// Token: 0x0400BA75 RID: 47733
			[Token(Token = "0x400BA75")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400BA76 RID: 47734
			[Token(Token = "0x400BA76")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0400BA77 RID: 47735
			[Token(Token = "0x400BA77")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
