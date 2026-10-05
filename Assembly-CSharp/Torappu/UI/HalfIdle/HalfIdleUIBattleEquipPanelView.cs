using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HalfIdle
{
	// Token: 0x0200674D RID: 26445
	[Token(Token = "0x200674D")]
	public class HalfIdleUIBattleEquipPanelView : DataBinder<HalfIdleUIBattleEquipPanelProperty>
	{
		// Token: 0x06025F35 RID: 155445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F35")]
		[Address(RVA = "0x20F3840", Offset = "0x20F2440", VA = "0x1820F3840", Slot = "7")]
		public override void OnValueChanged(HalfIdleUIBattleEquipPanelProperty property)
		{
		}

		// Token: 0x06025F36 RID: 155446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F36")]
		[Address(RVA = "0x20F3DB0", Offset = "0x20F29B0", VA = "0x1820F3DB0")]
		private void _Render(HalfIdleUIBattleEquipPanelViewModel vm)
		{
		}

		// Token: 0x06025F37 RID: 155447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F37")]
		[Address(RVA = "0x20F3940", Offset = "0x20F2540", VA = "0x1820F3940")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025F38 RID: 155448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F38")]
		[Address(RVA = "0x20F4620", Offset = "0x20F3220", VA = "0x1820F4620")]
		private void _ResetFoldTween(bool isShow)
		{
		}

		// Token: 0x06025F39 RID: 155449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F39")]
		[Address(RVA = "0x20F46D0", Offset = "0x20F32D0", VA = "0x1820F46D0")]
		private void _TryRaiseAVGSignalEquipGain()
		{
		}

		// Token: 0x06025F3A RID: 155450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F3A")]
		[Address(RVA = "0x20F3730", Offset = "0x20F2330", VA = "0x1820F3730")]
		public void EventOnClick()
		{
		}

		// Token: 0x06025F3B RID: 155451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F3B")]
		[Address(RVA = "0x20F37C0", Offset = "0x20F23C0", VA = "0x1820F37C0")]
		public void EventOnToggle()
		{
		}

		// Token: 0x06025F3C RID: 155452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F3C")]
		[Address(RVA = "0x20F4820", Offset = "0x20F3420", VA = "0x1820F4820")]
		public HalfIdleUIBattleEquipPanelView()
		{
		}

		// Token: 0x040355F1 RID: 218609
		[Token(Token = "0x40355F1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _detailViewRoot;

		// Token: 0x040355F2 RID: 218610
		[Token(Token = "0x40355F2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _sidebarCanvasGroup;

		// Token: 0x040355F3 RID: 218611
		[Token(Token = "0x40355F3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _unfoldAnim;

		// Token: 0x040355F4 RID: 218612
		[Token(Token = "0x40355F4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _foldAnim;

		// Token: 0x040355F5 RID: 218613
		[Token(Token = "0x40355F5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _autoUpgradeToggleAnim;

		// Token: 0x040355F6 RID: 218614
		[Token(Token = "0x40355F6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIButton _autoUpgradeToggle;

		// Token: 0x040355F7 RID: 218615
		[Token(Token = "0x40355F7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _foldCanvasGroup;

		// Token: 0x040355F8 RID: 218616
		[Token(Token = "0x40355F8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _disableAlpha;

		// Token: 0x040355F9 RID: 218617
		[Token(Token = "0x40355F9")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _enabledAlpha;

		// Token: 0x040355FA RID: 218618
		[Token(Token = "0x40355FA")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _selectedListTitleText;

		// Token: 0x040355FB RID: 218619
		[Token(Token = "0x40355FB")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private List<EquipTypeTextId> _equipTitleTextIds;

		// Token: 0x040355FC RID: 218620
		[Token(Token = "0x40355FC")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Current Equip")]
		private List<EquipTypeTextId> _equipEmptyDescTextIds;

		// Token: 0x040355FD RID: 218621
		[Token(Token = "0x40355FD")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Current Equip")]
		private GameObject _emptyMode;

		// Token: 0x040355FE RID: 218622
		[Token(Token = "0x40355FE")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Current Equip")]
		private Image _emptyEquipIcon;

		// Token: 0x040355FF RID: 218623
		[Token(Token = "0x40355FF")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Current Equip")]
		private Text _emptyEquipDescText;

		// Token: 0x04035600 RID: 218624
		[Token(Token = "0x4035600")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Current Equip")]
		private GameObject _filledMode;

		// Token: 0x04035601 RID: 218625
		[Token(Token = "0x4035601")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Current Equip")]
		private HalfIdleUIBattleEquipIconView _currentEquipIcon;

		// Token: 0x04035602 RID: 218626
		[Token(Token = "0x4035602")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Current Equip")]
		private Text _currentEquipDescText;

		// Token: 0x04035603 RID: 218627
		[Token(Token = "0x4035603")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Thumbnails")]
		private SimpleLayoutContent _equipThumbnailList;

		// Token: 0x04035604 RID: 218628
		[Token(Token = "0x4035604")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Equip Bag")]
		private HalfIdleUIBattleEquipListView[] _equipListView;

		// Token: 0x04035605 RID: 218629
		[Token(Token = "0x4035605")]
		[FieldOffset(Offset = "0xD0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04035606 RID: 218630
		[Token(Token = "0x4035606")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_inited;

		// Token: 0x04035607 RID: 218631
		[Token(Token = "0x4035607")]
		[FieldOffset(Offset = "0xE1")]
		private bool m_cachedIsUnfolded;

		// Token: 0x04035608 RID: 218632
		[Token(Token = "0x4035608")]
		[FieldOffset(Offset = "0xE4")]
		private Act1VHalfIdleEquipType m_cachedSelectedEquipType;

		// Token: 0x04035609 RID: 218633
		[Token(Token = "0x4035609")]
		[FieldOffset(Offset = "0xE8")]
		private UISwitchTween m_foldToggleTween;

		// Token: 0x0403560A RID: 218634
		[Token(Token = "0x403560A")]
		[FieldOffset(Offset = "0xF0")]
		private UISwitchTween m_autoUpgradeToggleTween;

		// Token: 0x0403560B RID: 218635
		[Token(Token = "0x403560B")]
		[FieldOffset(Offset = "0xF8")]
		private HalfIdleUIBattleEquipPanelView.Adapter m_equipThumbnailListAdapter;

		// Token: 0x0403560C RID: 218636
		[Token(Token = "0x403560C")]
		[FieldOffset(Offset = "0x100")]
		private int m_cachedSlotCount;

		// Token: 0x0403560D RID: 218637
		[Token(Token = "0x403560D")]
		[FieldOffset(Offset = "0x108")]
		private List<HalfIdleUIBattleEquipThumbnailViewModel> m_cachedEquipThumbnailViewModelList;

		// Token: 0x0403560E RID: 218638
		[Token(Token = "0x403560E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403560F RID: 218639
		[Token(Token = "0x403560F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x04035610 RID: 218640
		[Token(Token = "0x4035610")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04035611 RID: 218641
		[Token(Token = "0x4035611")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ResetFoldTween;

		// Token: 0x04035612 RID: 218642
		[Token(Token = "0x4035612")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryRaiseAVGSignalEquipGain;

		// Token: 0x04035613 RID: 218643
		[Token(Token = "0x4035613")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x04035614 RID: 218644
		[Token(Token = "0x4035614")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnToggle;

		// Token: 0x04035615 RID: 218645
		[Token(Token = "0x4035615")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200674E RID: 26446
		[Token(Token = "0x200674E")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06025F40 RID: 155456 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025F40")]
			[Address(RVA = "0x20EE620", Offset = "0x20ED220", VA = "0x1820EE620")]
			public Adapter(HalfIdleUIBattleEquipPanelView closure)
			{
			}

			// Token: 0x170059D3 RID: 22995
			// (get) Token: 0x06025F41 RID: 155457 RVA: 0x000C98A0 File Offset: 0x000C7AA0
			[Token(Token = "0x170059D3")]
			public override int count
			{
				[Token(Token = "0x6025F41")]
				[Address(RVA = "0x20EE7B0", Offset = "0x20ED3B0", VA = "0x1820EE7B0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06025F42 RID: 155458 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6025F42")]
			[Address(RVA = "0x20EDF50", Offset = "0x20ECB50", VA = "0x1820EDF50", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06025F43 RID: 155459 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025F43")]
			[Address(RVA = "0x20EDB70", Offset = "0x20EC770", VA = "0x1820EDB70")]
			public void RegisterTutorialGO(int index)
			{
			}

			// Token: 0x04035616 RID: 218646
			[Token(Token = "0x4035616")]
			[FieldOffset(Offset = "0x20")]
			private HalfIdleUIBattleEquipPanelView m_closure;

			// Token: 0x04035617 RID: 218647
			[Token(Token = "0x4035617")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04035618 RID: 218648
			[Token(Token = "0x4035618")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04035619 RID: 218649
			[Token(Token = "0x4035619")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403561A RID: 218650
			[Token(Token = "0x403561A")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RegisterTutorialGO;
		}
	}
}
