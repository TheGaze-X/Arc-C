using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Workshop
{
	// Token: 0x02001BE6 RID: 7142
	[Token(Token = "0x2001BE6")]
	public class BuildingWorkshopFormulaView : DataBinder<BuildingWorkshopFormulaProperty>
	{
		// Token: 0x1700154B RID: 5451
		// (get) Token: 0x0600B224 RID: 45604 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B223 RID: 45603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700154B")]
		public Action<IWorkshopFormula> formulaClickAction
		{
			[Token(Token = "0x600B224")]
			[Address(RVA = "0x32BF8B0", Offset = "0x32BE4B0", VA = "0x1832BF8B0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x600B223")]
			[Address(RVA = "0x32BF910", Offset = "0x32BE510", VA = "0x1832BF910")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600B225 RID: 45605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B225")]
		[Address(RVA = "0x32BE9C0", Offset = "0x32BD5C0", VA = "0x1832BE9C0", Slot = "7")]
		public override void OnValueChanged(BuildingWorkshopFormulaProperty property)
		{
		}

		// Token: 0x0600B226 RID: 45606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B226")]
		[Address(RVA = "0x32BECB0", Offset = "0x32BD8B0", VA = "0x1832BECB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600B227 RID: 45607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B227")]
		[Address(RVA = "0x32BF6B0", Offset = "0x32BE2B0", VA = "0x1832BF6B0")]
		private void _RenderTabs(BuildingWorkshopFormulaViewModel viewModel)
		{
		}

		// Token: 0x0600B228 RID: 45608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B228")]
		[Address(RVA = "0x32BF2A0", Offset = "0x32BDEA0", VA = "0x1832BF2A0")]
		private void _RenderBar(BuildingWorkshopFormulaViewModel viewModel)
		{
		}

		// Token: 0x0600B229 RID: 45609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B229")]
		[Address(RVA = "0x32BF540", Offset = "0x32BE140", VA = "0x1832BF540")]
		private void _RenderFormulaItems(BuildingWorkshopFormulaViewModel viewModel)
		{
		}

		// Token: 0x0600B22A RID: 45610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B22A")]
		[Address(RVA = "0x32BF180", Offset = "0x32BDD80", VA = "0x1832BF180")]
		private void _OnFormulaClicked(IWorkshopFormula formula)
		{
		}

		// Token: 0x0600B22B RID: 45611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B22B")]
		[Address(RVA = "0x32BF780", Offset = "0x32BE380", VA = "0x1832BF780")]
		public BuildingWorkshopFormulaView()
		{
		}

		// Token: 0x0400ACD3 RID: 44243
		[Token(Token = "0x400ACD3")]
		private const float DURATION_FADE = 0.2f;

		// Token: 0x0400ACD4 RID: 44244
		[Token(Token = "0x400ACD4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuildingWorkshopFormulaAdapter _adapter;

		// Token: 0x0400ACD5 RID: 44245
		[Token(Token = "0x400ACD5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle[] _tabButtons;

		// Token: 0x0400ACD6 RID: 44246
		[Token(Token = "0x400ACD6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ThreeStateToggle _raritySortToggle;

		// Token: 0x0400ACD7 RID: 44247
		[Token(Token = "0x400ACD7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ThreeStateToggle _priceSortToggle;

		// Token: 0x0400ACD8 RID: 44248
		[Token(Token = "0x400ACD8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ThreeStateToggle _idSortToggle;

		// Token: 0x0400ACD9 RID: 44249
		[Token(Token = "0x400ACD9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _emptyFurniturePanel;

		// Token: 0x0400ACDA RID: 44250
		[Token(Token = "0x400ACDA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _canvasGroupBar;

		// Token: 0x0400ACDB RID: 44251
		[Token(Token = "0x400ACDB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _canvasGroupRarityFilter;

		// Token: 0x0400ACDC RID: 44252
		[Token(Token = "0x400ACDC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TwoStateToggle _rarityFilterToggle;

		// Token: 0x0400ACDD RID: 44253
		[Token(Token = "0x400ACDD")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SimpleLayoutContent _layoutContentRarityFilter;

		// Token: 0x0400ACDE RID: 44254
		[Token(Token = "0x400ACDE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textCurRarity;

		// Token: 0x0400ACDF RID: 44255
		[Token(Token = "0x400ACDF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _colorBarCurRarity;

		// Token: 0x0400ACE0 RID: 44256
		[Token(Token = "0x400ACE0")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0400ACE1 RID: 44257
		[Token(Token = "0x400ACE1")]
		[FieldOffset(Offset = "0x88")]
		private FadeSwitchTween m_barSwitchTween;

		// Token: 0x0400ACE2 RID: 44258
		[Token(Token = "0x400ACE2")]
		[FieldOffset(Offset = "0x90")]
		private FadeSwitchTween m_rarityFilterSwitchTween;

		// Token: 0x0400ACE3 RID: 44259
		[Token(Token = "0x400ACE3")]
		[FieldOffset(Offset = "0x98")]
		private BuildingWorkshopFormulaView.WorkshopFilterListAdapter m_filterListAdapter;

		// Token: 0x0400ACE4 RID: 44260
		[Token(Token = "0x400ACE4")]
		[FieldOffset(Offset = "0xA0")]
		private WorkshopFormulaSorter m_sorter;

		// Token: 0x0400ACE5 RID: 44261
		[Token(Token = "0x400ACE5")]
		[FieldOffset(Offset = "0xA8")]
		private Func<IWorkshopFormula, IWorkshopFormula, int> m_currentSortFunc;

		// Token: 0x0400ACE6 RID: 44262
		[Token(Token = "0x400ACE6")]
		[FieldOffset(Offset = "0xB0")]
		private BuildingWorkshopFormulaViewModel m_viewModel;

		// Token: 0x0400ACE7 RID: 44263
		[Token(Token = "0x400ACE7")]
		[FieldOffset(Offset = "0xB8")]
		private BuildingWorkshopFilterIndex m_prefFilterIndex;

		// Token: 0x0400ACE9 RID: 44265
		[Token(Token = "0x400ACE9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_formulaClickAction;

		// Token: 0x0400ACEA RID: 44266
		[Token(Token = "0x400ACEA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_formulaClickAction;

		// Token: 0x0400ACEB RID: 44267
		[Token(Token = "0x400ACEB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400ACEC RID: 44268
		[Token(Token = "0x400ACEC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400ACED RID: 44269
		[Token(Token = "0x400ACED")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderTabs;

		// Token: 0x0400ACEE RID: 44270
		[Token(Token = "0x400ACEE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderBar;

		// Token: 0x0400ACEF RID: 44271
		[Token(Token = "0x400ACEF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderFormulaItems;

		// Token: 0x0400ACF0 RID: 44272
		[Token(Token = "0x400ACF0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnFormulaClicked;

		// Token: 0x0400ACF1 RID: 44273
		[Token(Token = "0x400ACF1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001BE7 RID: 7143
		[Token(Token = "0x2001BE7")]
		private class WorkshopFilterListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0600B22D RID: 45613 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B22D")]
			[Address(RVA = "0x32D24D0", Offset = "0x32D10D0", VA = "0x1832D24D0")]
			public WorkshopFilterListAdapter(BuildingWorkshopFormulaView closure)
			{
			}

			// Token: 0x1700154C RID: 5452
			// (get) Token: 0x0600B22E RID: 45614 RVA: 0x00043FC8 File Offset: 0x000421C8
			[Token(Token = "0x1700154C")]
			public override int count
			{
				[Token(Token = "0x600B22E")]
				[Address(RVA = "0x32D2550", Offset = "0x32D1150", VA = "0x1832D2550", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600B22F RID: 45615 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B22F")]
			[Address(RVA = "0x32D2190", Offset = "0x32D0D90", VA = "0x1832D2190", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0400ACF2 RID: 44274
			[Token(Token = "0x400ACF2")]
			[FieldOffset(Offset = "0x20")]
			private BuildingWorkshopFormulaView m_closure;

			// Token: 0x0400ACF3 RID: 44275
			[Token(Token = "0x400ACF3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400ACF4 RID: 44276
			[Token(Token = "0x400ACF4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0400ACF5 RID: 44277
			[Token(Token = "0x400ACF5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
