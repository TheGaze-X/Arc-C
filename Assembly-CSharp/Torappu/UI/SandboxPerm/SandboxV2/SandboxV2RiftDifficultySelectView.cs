using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200438D RID: 17293
	[Token(Token = "0x200438D")]
	public class SandboxV2RiftDifficultySelectView : DataBinder<SandboxV2RiftDifficultySelectProperty>
	{
		// Token: 0x0601A8D9 RID: 108761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8D9")]
		[Address(RVA = "0x13B3010", Offset = "0x13B1C10", VA = "0x1813B3010")]
		public void Update()
		{
		}

		// Token: 0x0601A8DA RID: 108762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8DA")]
		[Address(RVA = "0x13B2E70", Offset = "0x13B1A70", VA = "0x1813B2E70", Slot = "7")]
		public override void OnValueChanged(SandboxV2RiftDifficultySelectProperty property)
		{
		}

		// Token: 0x0601A8DB RID: 108763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8DB")]
		[Address(RVA = "0x13B3920", Offset = "0x13B2520", VA = "0x1813B3920")]
		private void _RenderByPagerIndexWhenStable(int selectLevel)
		{
		}

		// Token: 0x0601A8DC RID: 108764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8DC")]
		[Address(RVA = "0x13B3860", Offset = "0x13B2460", VA = "0x1813B3860")]
		private void _RenderByPagerIndexWhenChanged(int selectLevel, int maxLevel)
		{
		}

		// Token: 0x0601A8DD RID: 108765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8DD")]
		[Address(RVA = "0x13B30E0", Offset = "0x13B1CE0", VA = "0x1813B30E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A8DE RID: 108766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8DE")]
		[Address(RVA = "0x13B35A0", Offset = "0x13B21A0", VA = "0x1813B35A0")]
		private void _OnDifficultyItemClicked(int index)
		{
		}

		// Token: 0x0601A8DF RID: 108767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8DF")]
		[Address(RVA = "0x13B36B0", Offset = "0x13B22B0", VA = "0x1813B36B0")]
		private void _OnScrollPagerStateChanged(InertiaScrollViewPager.State state)
		{
		}

		// Token: 0x0601A8E0 RID: 108768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8E0")]
		[Address(RVA = "0x13B2AA0", Offset = "0x13B16A0", VA = "0x1813B2AA0")]
		public void OnConfirmDifficultyLevel()
		{
		}

		// Token: 0x0601A8E1 RID: 108769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8E1")]
		[Address(RVA = "0x13B2C00", Offset = "0x13B1800", VA = "0x1813B2C00")]
		public void OnLeftArrowClicked()
		{
		}

		// Token: 0x0601A8E2 RID: 108770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8E2")]
		[Address(RVA = "0x13B2D30", Offset = "0x13B1930", VA = "0x1813B2D30")]
		public void OnRightArrowClicked()
		{
		}

		// Token: 0x0601A8E3 RID: 108771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8E3")]
		[Address(RVA = "0x13B2A00", Offset = "0x13B1600", VA = "0x1813B2A00")]
		public void OnCloseState()
		{
		}

		// Token: 0x0601A8E4 RID: 108772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8E4")]
		[Address(RVA = "0x13B3B70", Offset = "0x13B2770", VA = "0x1813B3B70")]
		public SandboxV2RiftDifficultySelectView()
		{
		}

		// Token: 0x04021CD0 RID: 138448
		[Token(Token = "0x4021CD0")]
		[FieldOffset(Offset = "0x0")]
		private static readonly SandboxV2ItemCard.Option REWARD_ITEM_CARD_OPTION;

		// Token: 0x04021CD1 RID: 138449
		[Token(Token = "0x4021CD1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SandboxV2RiftDifficultyItem _prefab;

		// Token: 0x04021CD2 RID: 138450
		[Token(Token = "0x4021CD2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _difficultyItemWidthMin;

		// Token: 0x04021CD3 RID: 138451
		[Token(Token = "0x4021CD3")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _difficultyItemWidthMax;

		// Token: 0x04021CD4 RID: 138452
		[Token(Token = "0x4021CD4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _difficultyDescPanel;

		// Token: 0x04021CD5 RID: 138453
		[Token(Token = "0x4021CD5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _difficultyDesc;

		// Token: 0x04021CD6 RID: 138454
		[Token(Token = "0x4021CD6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TwoStateToggle _confirmToggle;

		// Token: 0x04021CD7 RID: 138455
		[Token(Token = "0x4021CD7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleLayoutContent _rewardContent;

		// Token: 0x04021CD8 RID: 138456
		[Token(Token = "0x4021CD8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _leftArrow;

		// Token: 0x04021CD9 RID: 138457
		[Token(Token = "0x4021CD9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _rightArrow;

		// Token: 0x04021CDA RID: 138458
		[Token(Token = "0x4021CDA")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private InertiaScrollViewPager _scrollViewPager;

		// Token: 0x04021CDB RID: 138459
		[Token(Token = "0x4021CDB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIRecycleLayoutGroup _difficultyContent;

		// Token: 0x04021CDC RID: 138460
		[Token(Token = "0x4021CDC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _scrollPagerUpdatingAnim;

		// Token: 0x04021CDD RID: 138461
		[Token(Token = "0x4021CDD")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _backPressArea;

		// Token: 0x04021CDE RID: 138462
		[Token(Token = "0x4021CDE")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private ScrollRect _rewardRect;

		// Token: 0x04021CDF RID: 138463
		[Token(Token = "0x4021CDF")]
		[FieldOffset(Offset = "0x90")]
		private bool m_hasInited;

		// Token: 0x04021CE0 RID: 138464
		[Token(Token = "0x4021CE0")]
		[FieldOffset(Offset = "0x98")]
		private SandboxV2RiftDifficultySelectView.DifficultyAdapter m_adapter;

		// Token: 0x04021CE1 RID: 138465
		[Token(Token = "0x4021CE1")]
		[FieldOffset(Offset = "0xA0")]
		private SandboxV2RiftDifficultySelectView.RewardAdapter m_rewardAdapter;

		// Token: 0x04021CE2 RID: 138466
		[Token(Token = "0x4021CE2")]
		[FieldOffset(Offset = "0xA8")]
		private List<UIItemViewModel> m_cachedRewards;

		// Token: 0x04021CE3 RID: 138467
		[Token(Token = "0x4021CE3")]
		[FieldOffset(Offset = "0xB0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04021CE4 RID: 138468
		[Token(Token = "0x4021CE4")]
		[FieldOffset(Offset = "0xC0")]
		private SandboxV2RiftDifficultySelectViewModel m_viewModel;

		// Token: 0x04021CE5 RID: 138469
		[Token(Token = "0x4021CE5")]
		[FieldOffset(Offset = "0xC8")]
		private UISwitchTween m_updatingTween;

		// Token: 0x04021CE6 RID: 138470
		[Token(Token = "0x4021CE6")]
		[FieldOffset(Offset = "0xD0")]
		private int m_cachedSequenceNum;

		// Token: 0x04021CE7 RID: 138471
		[Token(Token = "0x4021CE7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04021CE8 RID: 138472
		[Token(Token = "0x4021CE8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04021CE9 RID: 138473
		[Token(Token = "0x4021CE9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderByPagerIndexWhenStable;

		// Token: 0x04021CEA RID: 138474
		[Token(Token = "0x4021CEA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderByPagerIndexWhenChanged;

		// Token: 0x04021CEB RID: 138475
		[Token(Token = "0x4021CEB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04021CEC RID: 138476
		[Token(Token = "0x4021CEC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnDifficultyItemClicked;

		// Token: 0x04021CED RID: 138477
		[Token(Token = "0x4021CED")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnScrollPagerStateChanged;

		// Token: 0x04021CEE RID: 138478
		[Token(Token = "0x4021CEE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnConfirmDifficultyLevel;

		// Token: 0x04021CEF RID: 138479
		[Token(Token = "0x4021CEF")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnLeftArrowClicked;

		// Token: 0x04021CF0 RID: 138480
		[Token(Token = "0x4021CF0")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnRightArrowClicked;

		// Token: 0x04021CF1 RID: 138481
		[Token(Token = "0x4021CF1")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnCloseState;

		// Token: 0x04021CF2 RID: 138482
		[Token(Token = "0x4021CF2")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200438E RID: 17294
		[Token(Token = "0x200438E")]
		private class DifficultyAdapter : UIRecycleLayoutAdapter
		{
			// Token: 0x0601A8E6 RID: 108774 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A8E6")]
			[Address(RVA = "0x13A7000", Offset = "0x13A5C00", VA = "0x1813A7000")]
			public DifficultyAdapter(SandboxV2RiftDifficultySelectView closure)
			{
			}

			// Token: 0x0601A8E7 RID: 108775 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A8E7")]
			[Address(RVA = "0x13A6A50", Offset = "0x13A5650", VA = "0x1813A6A50", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x0601A8E8 RID: 108776 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A8E8")]
			[Address(RVA = "0x13A6CF0", Offset = "0x13A58F0", VA = "0x1813A6CF0")]
			public void RebuildList(SandboxV2RiftDifficultySelectViewModel model)
			{
			}

			// Token: 0x0601A8E9 RID: 108777 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A8E9")]
			[Address(RVA = "0x13A6B80", Offset = "0x13A5780", VA = "0x1813A6B80")]
			public void NotifyFocusPage(float focusPageIndex)
			{
			}

			// Token: 0x04021CF3 RID: 138483
			[Token(Token = "0x4021CF3")]
			[FieldOffset(Offset = "0x18")]
			private SandboxV2RiftDifficultySelectView m_closure;

			// Token: 0x04021CF4 RID: 138484
			[Token(Token = "0x4021CF4")]
			[FieldOffset(Offset = "0x20")]
			private float m_focusPageIndex;

			// Token: 0x04021CF5 RID: 138485
			[Token(Token = "0x4021CF5")]
			[FieldOffset(Offset = "0x28")]
			private List<SandboxV2RiftDifficultyItem.VirtualView> m_cells;

			// Token: 0x04021CF6 RID: 138486
			[Token(Token = "0x4021CF6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04021CF7 RID: 138487
			[Token(Token = "0x4021CF7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

			// Token: 0x04021CF8 RID: 138488
			[Token(Token = "0x4021CF8")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RebuildList;

			// Token: 0x04021CF9 RID: 138489
			[Token(Token = "0x4021CF9")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_NotifyFocusPage;
		}

		// Token: 0x0200438F RID: 17295
		[Token(Token = "0x200438F")]
		private class RewardAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601A8EA RID: 108778 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A8EA")]
			[Address(RVA = "0x13A7D70", Offset = "0x13A6970", VA = "0x1813A7D70")]
			public RewardAdapter(SandboxV2RiftDifficultySelectView closure)
			{
			}

			// Token: 0x17003EF8 RID: 16120
			// (get) Token: 0x0601A8EB RID: 108779 RVA: 0x000A2588 File Offset: 0x000A0788
			[Token(Token = "0x17003EF8")]
			public override int count
			{
				[Token(Token = "0x601A8EB")]
				[Address(RVA = "0x13A7E70", Offset = "0x13A6A70", VA = "0x1813A7E70", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601A8EC RID: 108780 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A8EC")]
			[Address(RVA = "0x13A7570", Offset = "0x13A6170", VA = "0x1813A7570", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601A8ED RID: 108781 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A8ED")]
			[Address(RVA = "0x13A7AB0", Offset = "0x13A66B0", VA = "0x1813A7AB0")]
			private void _OnItemClick(int index)
			{
			}

			// Token: 0x04021CFA RID: 138490
			[Token(Token = "0x4021CFA")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2RiftDifficultySelectView m_closure;

			// Token: 0x04021CFB RID: 138491
			[Token(Token = "0x4021CFB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04021CFC RID: 138492
			[Token(Token = "0x4021CFC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04021CFD RID: 138493
			[Token(Token = "0x4021CFD")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04021CFE RID: 138494
			[Token(Token = "0x4021CFE")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__OnItemClick;
		}
	}
}
