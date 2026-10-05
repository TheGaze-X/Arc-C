using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003936 RID: 14646
	[Token(Token = "0x2003936")]
	public class UIGainItemFloatPanel : MonoBehaviour
	{
		// Token: 0x1700374B RID: 14155
		// (get) Token: 0x06017257 RID: 94807 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06017258 RID: 94808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700374B")]
		public Action onHideRequested
		{
			[Token(Token = "0x6017257")]
			[Address(RVA = "0xF93800", Offset = "0xF92400", VA = "0x180F93800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6017258")]
			[Address(RVA = "0xF93850", Offset = "0xF92450", VA = "0x180F93850")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700374C RID: 14156
		// (get) Token: 0x06017259 RID: 94809 RVA: 0x00095028 File Offset: 0x00093228
		// (set) Token: 0x0601725A RID: 94810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700374C")]
		private bool isRenderingFinished
		{
			[Token(Token = "0x6017259")]
			[Address(RVA = "0xF93760", Offset = "0xF92360", VA = "0x180F93760")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601725A")]
			[Address(RVA = "0xF93810", Offset = "0xF92410", VA = "0x180F93810")]
			set
			{
			}
		}

		// Token: 0x1700374D RID: 14157
		// (get) Token: 0x0601725B RID: 94811 RVA: 0x00095040 File Offset: 0x00093240
		[Token(Token = "0x1700374D")]
		private int maxItemCntForEffect
		{
			[Token(Token = "0x601725B")]
			[Address(RVA = "0xF937D0", Offset = "0xF923D0", VA = "0x180F937D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700374E RID: 14158
		// (get) Token: 0x0601725C RID: 94812 RVA: 0x00095058 File Offset: 0x00093258
		[Token(Token = "0x1700374E")]
		private int maxItemCntForAnimation
		{
			[Token(Token = "0x601725C")]
			[Address(RVA = "0xF937A0", Offset = "0xF923A0", VA = "0x180F937A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601725D RID: 94813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601725D")]
		[Address(RVA = "0xF92A30", Offset = "0xF91630", VA = "0x180F92A30")]
		public void EventOnConfirmClicked()
		{
		}

		// Token: 0x0601725E RID: 94814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601725E")]
		[Address(RVA = "0xF92A30", Offset = "0xF91630", VA = "0x180F92A30")]
		public void EventOnBlankClicked()
		{
		}

		// Token: 0x0601725F RID: 94815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601725F")]
		[Address(RVA = "0xF92A70", Offset = "0xF91670", VA = "0x180F92A70")]
		public void EventOnMaskClicked()
		{
		}

		// Token: 0x06017260 RID: 94816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017260")]
		[Address(RVA = "0xF92F30", Offset = "0xF91B30", VA = "0x180F92F30")]
		protected void Start()
		{
		}

		// Token: 0x06017261 RID: 94817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017261")]
		[Address(RVA = "0xF92C40", Offset = "0xF91840", VA = "0x180F92C40")]
		protected void OnEnable()
		{
		}

		// Token: 0x06017262 RID: 94818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017262")]
		[Address(RVA = "0xF92EB0", Offset = "0xF91AB0", VA = "0x180F92EB0")]
		public IEnumerator ShowCoroutine()
		{
			return null;
		}

		// Token: 0x06017263 RID: 94819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017263")]
		[Address(RVA = "0xF92A30", Offset = "0xF91630", VA = "0x180F92A30")]
		public void RequestHide()
		{
		}

		// Token: 0x06017264 RID: 94820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017264")]
		[Address(RVA = "0xF92BC0", Offset = "0xF917C0", VA = "0x180F92BC0")]
		public IEnumerator HideCoroutine()
		{
			return null;
		}

		// Token: 0x06017265 RID: 94821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017265")]
		[Address(RVA = "0xF92C60", Offset = "0xF91860", VA = "0x180F92C60")]
		public void Render(IList<UIItemViewModel> itemModels, UIGainItemFloatPanel.Style style)
		{
		}

		// Token: 0x06017266 RID: 94822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017266")]
		[Address(RVA = "0xF93060", Offset = "0xF91C60", VA = "0x180F93060")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06017267 RID: 94823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017267")]
		[Address(RVA = "0xF93500", Offset = "0xF92100", VA = "0x180F93500")]
		private void _UpdateAutoLayouts()
		{
		}

		// Token: 0x06017268 RID: 94824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017268")]
		[Address(RVA = "0xF93630", Offset = "0xF92230", VA = "0x180F93630")]
		private IEnumerator _UpdateLayoutCoroutine()
		{
			return null;
		}

		// Token: 0x06017269 RID: 94825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017269")]
		[Address(RVA = "0xF93160", Offset = "0xF91D60", VA = "0x180F93160")]
		private void _OnItemListRenderFinished()
		{
		}

		// Token: 0x0601726A RID: 94826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601726A")]
		[Address(RVA = "0xF93190", Offset = "0xF91D90", VA = "0x180F93190")]
		private void _SetItemsModels(IList<UIItemViewModel> itemModels)
		{
		}

		// Token: 0x0601726B RID: 94827 RVA: 0x00095070 File Offset: 0x00093270
		[Token(Token = "0x601726B")]
		[Address(RVA = "0xF93000", Offset = "0xF91C00", VA = "0x180F93000")]
		private int _CompareItemModelWithSortId(UIItemViewModel lhs, UIItemViewModel rhs)
		{
			return 0;
		}

		// Token: 0x0601726C RID: 94828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601726C")]
		[Address(RVA = "0xF93440", Offset = "0xF92040", VA = "0x180F93440")]
		private void _SetStyle(UIGainItemFloatPanel.Style style)
		{
		}

		// Token: 0x0601726D RID: 94829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601726D")]
		[Address(RVA = "0xF936B0", Offset = "0xF922B0", VA = "0x180F936B0")]
		public UIGainItemFloatPanel()
		{
		}

		// Token: 0x0401BF0D RID: 114445
		[Token(Token = "0x401BF0D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _titleText;

		// Token: 0x0401BF0E RID: 114446
		[Token(Token = "0x401BF0E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIBlurFloatPanel _backImage;

		// Token: 0x0401BF0F RID: 114447
		[Token(Token = "0x401BF0F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _itemGridLayout;

		// Token: 0x0401BF10 RID: 114448
		[Token(Token = "0x401BF10")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _itemScaleFactor;

		// Token: 0x0401BF11 RID: 114449
		[Token(Token = "0x401BF11")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform[] _autoLayouts;

		// Token: 0x0401BF12 RID: 114450
		[Token(Token = "0x401BF12")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ScrollRect _itemScroll;

		// Token: 0x0401BF13 RID: 114451
		[Token(Token = "0x401BF13")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GridLayoutGroup _gridLayoutGroup;

		// Token: 0x0401BF14 RID: 114452
		[Token(Token = "0x401BF14")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private VerticalLayoutGroup _verticalLayoutGroup;

		// Token: 0x0401BF15 RID: 114453
		[Token(Token = "0x401BF15")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _topMask;

		// Token: 0x0401BF16 RID: 114454
		[Token(Token = "0x401BF16")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Details")]
		private Transform _effectHolder;

		// Token: 0x0401BF17 RID: 114455
		[Token(Token = "0x401BF17")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Details")]
		private float _delayToShowEachItem;

		// Token: 0x0401BF18 RID: 114456
		[Token(Token = "0x401BF18")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		[Group("Details")]
		private int _maxRowForEffect;

		// Token: 0x0401BF19 RID: 114457
		[Token(Token = "0x401BF19")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Details")]
		private int _maxRowForAnimation;

		// Token: 0x0401BF1A RID: 114458
		[Token(Token = "0x401BF1A")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		[Group("Details")]
		private int _topPaddingSingleRow;

		// Token: 0x0401BF1B RID: 114459
		[Token(Token = "0x401BF1B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Details")]
		private int _topPaddingMultiRows;

		// Token: 0x0401BF1C RID: 114460
		[Token(Token = "0x401BF1C")]
		[FieldOffset(Offset = "0x80")]
		private List<UIItemViewModel> m_itemModels;

		// Token: 0x0401BF1D RID: 114461
		[Token(Token = "0x401BF1D")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x0401BF1E RID: 114462
		[Token(Token = "0x401BF1E")]
		[FieldOffset(Offset = "0x89")]
		private bool m_isLayoutUpdating;

		// Token: 0x0401BF1F RID: 114463
		[Token(Token = "0x401BF1F")]
		[FieldOffset(Offset = "0x90")]
		private UIGainItemFloatPanel.ItemAdapter m_itemAdapter;

		// Token: 0x02003937 RID: 14647
		[Token(Token = "0x2003937")]
		public enum Style
		{
			// Token: 0x0401BF22 RID: 114466
			[Token(Token = "0x401BF22")]
			DEFAULT,
			// Token: 0x0401BF23 RID: 114467
			[Token(Token = "0x401BF23")]
			DAILY_SUPPLY
		}

		// Token: 0x02003938 RID: 14648
		[Token(Token = "0x2003938")]
		private class ItemAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601726E RID: 94830 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601726E")]
			[Address(RVA = "0xF88B90", Offset = "0xF87790", VA = "0x180F88B90")]
			public ItemAdapter(UIGainItemFloatPanel closure)
			{
			}

			// Token: 0x1700374F RID: 14159
			// (get) Token: 0x0601726F RID: 94831 RVA: 0x00095088 File Offset: 0x00093288
			[Token(Token = "0x1700374F")]
			public override int count
			{
				[Token(Token = "0x601726F")]
				[Address(RVA = "0xF88C10", Offset = "0xF87810", VA = "0x180F88C10", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06017270 RID: 94832 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017270")]
			[Address(RVA = "0xF882F0", Offset = "0xF86EF0", VA = "0x180F882F0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06017271 RID: 94833 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017271")]
			[Address(RVA = "0xF88160", Offset = "0xF86D60", VA = "0x180F88160")]
			public void OnMaskClicked()
			{
			}

			// Token: 0x06017272 RID: 94834 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017272")]
			[Address(RVA = "0xF880B0", Offset = "0xF86CB0", VA = "0x180F880B0")]
			public void OnHide()
			{
			}

			// Token: 0x06017273 RID: 94835 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017273")]
			[Address(RVA = "0xF88250", Offset = "0xF86E50", VA = "0x180F88250", Slot = "7")]
			protected override void RecycleViews(List<GameObject> views)
			{
			}

			// Token: 0x06017274 RID: 94836 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017274")]
			[Address(RVA = "0xF88AF0", Offset = "0xF876F0", VA = "0x180F88AF0")]
			private void _OnItemCardRenderFinished()
			{
			}

			// Token: 0x06017275 RID: 94837 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017275")]
			[Address(RVA = "0xF88980", Offset = "0xF87580", VA = "0x180F88980")]
			private void _ForeachItemCard(Action<UIGainItemCard> callback)
			{
			}

			// Token: 0x06017278 RID: 94840 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017278")]
			[Address(RVA = "0xF88970", Offset = "0xF87570", VA = "0x180F88970")]
			private void <>xLuaBaseProxy_RecycleViews(List<GameObject> P0)
			{
			}

			// Token: 0x0401BF24 RID: 114468
			[Token(Token = "0x401BF24")]
			[FieldOffset(Offset = "0x20")]
			private UIGainItemFloatPanel m_closure;

			// Token: 0x0401BF25 RID: 114469
			[Token(Token = "0x401BF25")]
			[FieldOffset(Offset = "0x28")]
			private bool m_isItemsRendering;

			// Token: 0x0401BF26 RID: 114470
			[Token(Token = "0x401BF26")]
			[FieldOffset(Offset = "0x2C")]
			private int m_pendingItemCntToRender;

			// Token: 0x0401BF27 RID: 114471
			[Token(Token = "0x401BF27")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401BF28 RID: 114472
			[Token(Token = "0x401BF28")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401BF29 RID: 114473
			[Token(Token = "0x401BF29")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0401BF2A RID: 114474
			[Token(Token = "0x401BF2A")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnMaskClicked;

			// Token: 0x0401BF2B RID: 114475
			[Token(Token = "0x401BF2B")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnHide;

			// Token: 0x0401BF2C RID: 114476
			[Token(Token = "0x401BF2C")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_RecycleViews;

			// Token: 0x0401BF2D RID: 114477
			[Token(Token = "0x401BF2D")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__OnItemCardRenderFinished;

			// Token: 0x0401BF2E RID: 114478
			[Token(Token = "0x401BF2E")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__ForeachItemCard;
		}
	}
}
