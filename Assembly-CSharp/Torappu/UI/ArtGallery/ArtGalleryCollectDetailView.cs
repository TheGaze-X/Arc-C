using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.EventTrack;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x020065E7 RID: 26087
	[Token(Token = "0x20065E7")]
	public class ArtGalleryCollectDetailView : DataBinder<ArtGalleryCollectDetailProperty>, IHotfixable
	{
		// Token: 0x060257EA RID: 153578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257EA")]
		[Address(RVA = "0x20751E0", Offset = "0x2073DE0", VA = "0x1820751E0", Slot = "7")]
		public override void OnValueChanged(ArtGalleryCollectDetailProperty property)
		{
		}

		// Token: 0x060257EB RID: 153579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257EB")]
		[Address(RVA = "0x20774A0", Offset = "0x20760A0", VA = "0x1820774A0")]
		private void _RenderProgressPart(ArtGalleryCollectDetailViewModel model)
		{
		}

		// Token: 0x060257EC RID: 153580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257EC")]
		[Address(RVA = "0x2077110", Offset = "0x2075D10", VA = "0x182077110")]
		private void _RebuildEntryViews(ArtGalleryCollectDetailViewModel model)
		{
		}

		// Token: 0x060257ED RID: 153581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257ED")]
		[Address(RVA = "0x20769E0", Offset = "0x20755E0", VA = "0x1820769E0")]
		private void _AddItemToAdapter(ItemType itemType, ArtGalleryCollectItemModelBase viewModel, ArtGalleryCollectItemAdapter adapter, List<ItemType> itemTypesList)
		{
		}

		// Token: 0x060257EE RID: 153582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257EE")]
		[Address(RVA = "0x2076E80", Offset = "0x2075A80", VA = "0x182076E80")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060257EF RID: 153583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257EF")]
		[Address(RVA = "0x2076FF0", Offset = "0x2075BF0", VA = "0x182076FF0")]
		private void _OnPostLayout()
		{
		}

		// Token: 0x060257F0 RID: 153584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257F0")]
		[Address(RVA = "0x2075960", Offset = "0x2074560", VA = "0x182075960")]
		private void Update()
		{
		}

		// Token: 0x060257F1 RID: 153585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257F1")]
		[Address(RVA = "0x2076380", Offset = "0x2074F80", VA = "0x182076380")]
		private void _AddHomeBgItem(ArtGalleryCollectItemModelBase viewModel, ArtGalleryCollectItemAdapter adapter, bool isFirstItemBySameType)
		{
		}

		// Token: 0x060257F2 RID: 153586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257F2")]
		[Address(RVA = "0x20766B0", Offset = "0x20752B0", VA = "0x1820766B0")]
		private void _AddHomeThemeItem(ArtGalleryCollectItemModelBase viewModel, ArtGalleryCollectItemAdapter adapter, bool isFirstItemBySameType)
		{
		}

		// Token: 0x060257F3 RID: 153587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257F3")]
		[Address(RVA = "0x2075A50", Offset = "0x2074650", VA = "0x182075A50")]
		private void _AddAvatarItem(ArtGalleryCollectItemModelBase viewModel, ArtGalleryCollectItemAdapter adapter, bool isFirstItemBySameType)
		{
		}

		// Token: 0x060257F4 RID: 153588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257F4")]
		[Address(RVA = "0x2075D80", Offset = "0x2074980", VA = "0x182075D80")]
		private void _AddCharSkinItem(ArtGalleryCollectItemModelBase viewModel, ArtGalleryCollectItemAdapter adapter, bool isFirstItemBySameType)
		{
		}

		// Token: 0x060257F5 RID: 153589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257F5")]
		[Address(RVA = "0x2076B50", Offset = "0x2075750", VA = "0x182076B50")]
		private void _AddNcSkinItem(ArtGalleryCollectItemModelBase viewModel, ArtGalleryCollectItemAdapter adapter, bool isFirstItemBySameType)
		{
		}

		// Token: 0x060257F6 RID: 153590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257F6")]
		[Address(RVA = "0x20760B0", Offset = "0x2074CB0", VA = "0x1820760B0")]
		private void _AddExpandingItem(ArtGalleryCollectItemAdapter adapter)
		{
		}

		// Token: 0x060257F7 RID: 153591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257F7")]
		[Address(RVA = "0x2075880", Offset = "0x2074480", VA = "0x182075880")]
		public void OpenRewardClaimPreview()
		{
		}

		// Token: 0x060257F8 RID: 153592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60257F8")]
		[Address(RVA = "0x20777F0", Offset = "0x20763F0", VA = "0x1820777F0")]
		public ArtGalleryCollectDetailView()
		{
		}

		// Token: 0x04034A20 RID: 215584
		[Token(Token = "0x4034A20")]
		private const string AVATAR_PREFAB = "item_avatar";

		// Token: 0x04034A21 RID: 215585
		[Token(Token = "0x4034A21")]
		private const string SKIN_PREFAB = "item_skin";

		// Token: 0x04034A22 RID: 215586
		[Token(Token = "0x4034A22")]
		private const string BG_PREFAB = "item_bg";

		// Token: 0x04034A23 RID: 215587
		[Token(Token = "0x4034A23")]
		private const string THEME_PREFAB = "item_theme";

		// Token: 0x04034A24 RID: 215588
		[Token(Token = "0x4034A24")]
		private const string NC_SKIN_PREFAB = "item_nc";

		// Token: 0x04034A25 RID: 215589
		[Token(Token = "0x4034A25")]
		private const string IN_EXPAND_PREFAB = "item_expanding";

		// Token: 0x04034A26 RID: 215590
		[Token(Token = "0x4034A26")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIRecycleHorizonLayoutGroup _layout;

		// Token: 0x04034A27 RID: 215591
		[Token(Token = "0x4034A27")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _typeName;

		// Token: 0x04034A28 RID: 215592
		[Token(Token = "0x4034A28")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _setName;

		// Token: 0x04034A29 RID: 215593
		[Token(Token = "0x4034A29")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _objProgressWithoutRewards;

		// Token: 0x04034A2A RID: 215594
		[Token(Token = "0x4034A2A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _progressWithoutRewards;

		// Token: 0x04034A2B RID: 215595
		[Token(Token = "0x4034A2B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _objProgressWithRewards;

		// Token: 0x04034A2C RID: 215596
		[Token(Token = "0x4034A2C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _progressWithRewards;

		// Token: 0x04034A2D RID: 215597
		[Token(Token = "0x4034A2D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _objCanClaimRewardDesc;

		// Token: 0x04034A2E RID: 215598
		[Token(Token = "0x4034A2E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _objClaimedRewardDesc;

		// Token: 0x04034A2F RID: 215599
		[Token(Token = "0x4034A2F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _objCantClaimRewardDesc;

		// Token: 0x04034A30 RID: 215600
		[Token(Token = "0x4034A30")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _typeEngName;

		// Token: 0x04034A31 RID: 215601
		[Token(Token = "0x4034A31")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Slider _slider;

		// Token: 0x04034A32 RID: 215602
		[Token(Token = "0x4034A32")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _viewport;

		// Token: 0x04034A33 RID: 215603
		[Token(Token = "0x4034A33")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _titleLayout;

		// Token: 0x04034A34 RID: 215604
		[Token(Token = "0x4034A34")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _trackPointHasRewardsHolder;

		// Token: 0x04034A35 RID: 215605
		[Token(Token = "0x4034A35")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _trackPointHasRewardsPrefab;

		// Token: 0x04034A36 RID: 215606
		[Token(Token = "0x4034A36")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x04034A37 RID: 215607
		[Token(Token = "0x4034A37")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_hasInited;

		// Token: 0x04034A38 RID: 215608
		[Token(Token = "0x4034A38")]
		[FieldOffset(Offset = "0xB0")]
		private string m_cachedSetId;

		// Token: 0x04034A39 RID: 215609
		[Token(Token = "0x4034A39")]
		[FieldOffset(Offset = "0xB8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04034A3A RID: 215610
		[Token(Token = "0x4034A3A")]
		[FieldOffset(Offset = "0xC8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04034A3B RID: 215611
		[Token(Token = "0x4034A3B")]
		[FieldOffset(Offset = "0xD8")]
		private ILoadAsset m_assetLoader;

		// Token: 0x04034A3C RID: 215612
		[Token(Token = "0x4034A3C")]
		[FieldOffset(Offset = "0xE0")]
		private ArtGalleryCollectItemAdapter m_adapter;

		// Token: 0x04034A3D RID: 215613
		[Token(Token = "0x4034A3D")]
		[FieldOffset(Offset = "0xE8")]
		private UILayoutDimensionListener m_dimensionListener;

		// Token: 0x04034A3E RID: 215614
		[Token(Token = "0x4034A3E")]
		[FieldOffset(Offset = "0xF0")]
		private ArtGalleryUtils.CollectSetMissionRewardsState m_missionRewardsState;

		// Token: 0x04034A3F RID: 215615
		[Token(Token = "0x4034A3F")]
		[FieldOffset(Offset = "0xF8")]
		private GameObject m_trackPointHasRewards;

		// Token: 0x04034A40 RID: 215616
		[Token(Token = "0x4034A40")]
		[FieldOffset(Offset = "0x100")]
		private List<ItemType> m_cachedItemTypeList;

		// Token: 0x04034A41 RID: 215617
		[Token(Token = "0x4034A41")]
		[FieldOffset(Offset = "0x108")]
		private List<EventLogTrace.EventLogArtGalleryContext.CollectionRewardStatus> m_cacheMissionStatus;

		// Token: 0x04034A42 RID: 215618
		[Token(Token = "0x4034A42")]
		[FieldOffset(Offset = "0x110")]
		private float m_sliderLength;

		// Token: 0x04034A43 RID: 215619
		[Token(Token = "0x4034A43")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04034A44 RID: 215620
		[Token(Token = "0x4034A44")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderProgressPart;

		// Token: 0x04034A45 RID: 215621
		[Token(Token = "0x4034A45")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RebuildEntryViews;

		// Token: 0x04034A46 RID: 215622
		[Token(Token = "0x4034A46")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__AddItemToAdapter;

		// Token: 0x04034A47 RID: 215623
		[Token(Token = "0x4034A47")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04034A48 RID: 215624
		[Token(Token = "0x4034A48")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnPostLayout;

		// Token: 0x04034A49 RID: 215625
		[Token(Token = "0x4034A49")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04034A4A RID: 215626
		[Token(Token = "0x4034A4A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__AddHomeBgItem;

		// Token: 0x04034A4B RID: 215627
		[Token(Token = "0x4034A4B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__AddHomeThemeItem;

		// Token: 0x04034A4C RID: 215628
		[Token(Token = "0x4034A4C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__AddAvatarItem;

		// Token: 0x04034A4D RID: 215629
		[Token(Token = "0x4034A4D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__AddCharSkinItem;

		// Token: 0x04034A4E RID: 215630
		[Token(Token = "0x4034A4E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__AddNcSkinItem;

		// Token: 0x04034A4F RID: 215631
		[Token(Token = "0x4034A4F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__AddExpandingItem;

		// Token: 0x04034A50 RID: 215632
		[Token(Token = "0x4034A50")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OpenRewardClaimPreview;

		// Token: 0x04034A51 RID: 215633
		[Token(Token = "0x4034A51")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020065E8 RID: 26088
		[Token(Token = "0x20065E8")]
		private class OnPostLayoutAction : UILayoutDimensionListener.IAction
		{
			// Token: 0x060257F9 RID: 153593 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60257F9")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public OnPostLayoutAction(ArtGalleryCollectDetailView closure)
			{
			}

			// Token: 0x060257FA RID: 153594 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60257FA")]
			[Address(RVA = "0x20877B0", Offset = "0x20863B0", VA = "0x1820877B0", Slot = "4")]
			public void DoAction()
			{
			}

			// Token: 0x04034A52 RID: 215634
			[Token(Token = "0x4034A52")]
			[FieldOffset(Offset = "0x10")]
			private ArtGalleryCollectDetailView m_closure;
		}
	}
}
