using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x020059E9 RID: 23017
	[Token(Token = "0x20059E9")]
	public class CrisisV2SlotDetailMapView : CrisisV2DetailMapViewBase
	{
		// Token: 0x060218AA RID: 137386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60218AA")]
		[Address(RVA = "0x1BE0AF0", Offset = "0x1BDF6F0", VA = "0x181BE0AF0", Slot = "10")]
		protected override void UpdateDictPool(CrisisV2MapModel mapModel)
		{
		}

		// Token: 0x060218AB RID: 137387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60218AB")]
		[Address(RVA = "0x1BE0260", Offset = "0x1BDEE60", VA = "0x181BE0260", Slot = "12")]
		protected override void ForceRecycleDictPool()
		{
		}

		// Token: 0x060218AC RID: 137388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60218AC")]
		[Address(RVA = "0x1BE04F0", Offset = "0x1BDF0F0", VA = "0x181BE04F0", Slot = "9")]
		protected override void InitDictPool()
		{
		}

		// Token: 0x060218AD RID: 137389 RVA: 0x000BAB28 File Offset: 0x000B8D28
		[Token(Token = "0x60218AD")]
		[Address(RVA = "0x1BE0490", Offset = "0x1BDF090", VA = "0x181BE0490", Slot = "8")]
		protected override CrisisV2MapModel.ViewType GetViewType()
		{
			return CrisisV2MapModel.ViewType.NONE;
		}

		// Token: 0x060218AE RID: 137390 RVA: 0x000BAB40 File Offset: 0x000B8D40
		[Token(Token = "0x60218AE")]
		[Address(RVA = "0x1BE03B0", Offset = "0x1BDEFB0", VA = "0x181BE03B0", Slot = "11")]
		protected override Vector2 GetMapSize(CrisisV2MapModel mapModel)
		{
			return default(Vector2);
		}

		// Token: 0x060218AF RID: 137391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60218AF")]
		[Address(RVA = "0x1BE01D0", Offset = "0x1BDEDD0", VA = "0x181BE01D0")]
		public void ClosePreviewViewIfOpen()
		{
		}

		// Token: 0x060218B0 RID: 137392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60218B0")]
		[Address(RVA = "0x1BE0D30", Offset = "0x1BDF930", VA = "0x181BE0D30")]
		public CrisisV2SlotDetailMapView()
		{
		}

		// Token: 0x0402DD6E RID: 187758
		[Token(Token = "0x402DD6E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private CrisisV2MapRoadView _roadPrefab;

		// Token: 0x0402DD6F RID: 187759
		[Token(Token = "0x402DD6F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private CrisisV2MapRoadPointView _roadPointPrefab;

		// Token: 0x0402DD70 RID: 187760
		[Token(Token = "0x402DD70")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RectTransform _unselectRoadContainer;

		// Token: 0x0402DD71 RID: 187761
		[Token(Token = "0x402DD71")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private RectTransform _selectRoadContainer;

		// Token: 0x0402DD72 RID: 187762
		[Token(Token = "0x402DD72")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private RectTransform _unselectPointContainer;

		// Token: 0x0402DD73 RID: 187763
		[Token(Token = "0x402DD73")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private RectTransform _selectPointContainer;

		// Token: 0x0402DD74 RID: 187764
		[Token(Token = "0x402DD74")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private CrisisV2MapNodeViewHolder _nodeHolderPrefab;

		// Token: 0x0402DD75 RID: 187765
		[Token(Token = "0x402DD75")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private RectTransform _nodeUpperContainer;

		// Token: 0x0402DD76 RID: 187766
		[Token(Token = "0x402DD76")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private RectTransform _nodeLowerContainer;

		// Token: 0x0402DD77 RID: 187767
		[Token(Token = "0x402DD77")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private CrisisV2MapBagTitleView _bagTitlePrefab;

		// Token: 0x0402DD78 RID: 187768
		[Token(Token = "0x402DD78")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private RectTransform _bagTitleContainer;

		// Token: 0x0402DD79 RID: 187769
		[Token(Token = "0x402DD79")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private CrisisV2MapBagBgView _bagBgPrefab;

		// Token: 0x0402DD7A RID: 187770
		[Token(Token = "0x402DD7A")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private RectTransform _bagBgContainer;

		// Token: 0x0402DD7B RID: 187771
		[Token(Token = "0x402DD7B")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private CrisisV2MapExclusionGroupView _exclusionGroupPrefab;

		// Token: 0x0402DD7C RID: 187772
		[Token(Token = "0x402DD7C")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private RectTransform _exclusionGroupContainer;

		// Token: 0x0402DD7D RID: 187773
		[Token(Token = "0x402DD7D")]
		[FieldOffset(Offset = "0x100")]
		private CrisisV2SlotDetailMapView.CrisisV2MapBagTitleDictPool m_bagTitlePool;

		// Token: 0x0402DD7E RID: 187774
		[Token(Token = "0x402DD7E")]
		[FieldOffset(Offset = "0x108")]
		private CrisisV2SlotDetailMapView.CrisisV2MapBagBgDictPool m_bagBgPool;

		// Token: 0x0402DD7F RID: 187775
		[Token(Token = "0x402DD7F")]
		[FieldOffset(Offset = "0x110")]
		private CrisisV2SlotDetailMapView.CrisisV2MapExclusionDictPool m_exclusionPool;

		// Token: 0x0402DD80 RID: 187776
		[Token(Token = "0x402DD80")]
		[FieldOffset(Offset = "0x118")]
		private CrisisV2MapRoadDictPool m_roadDictPool;

		// Token: 0x0402DD81 RID: 187777
		[Token(Token = "0x402DD81")]
		[FieldOffset(Offset = "0x120")]
		private CrisisV2MapRoadPointDictPool m_roadPointDictPool;

		// Token: 0x0402DD82 RID: 187778
		[Token(Token = "0x402DD82")]
		[FieldOffset(Offset = "0x128")]
		private CrisisV2SlotDetailMapView.CrisisV2MapNodeDictPool m_lowerNodeDictPool;

		// Token: 0x0402DD83 RID: 187779
		[Token(Token = "0x402DD83")]
		[FieldOffset(Offset = "0x130")]
		private CrisisV2SlotDetailMapView.CrisisV2MapNodeDictPool m_upperNodeDictPool;

		// Token: 0x0402DD84 RID: 187780
		[Token(Token = "0x402DD84")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateDictPool;

		// Token: 0x0402DD85 RID: 187781
		[Token(Token = "0x402DD85")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ForceRecycleDictPool;

		// Token: 0x0402DD86 RID: 187782
		[Token(Token = "0x402DD86")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitDictPool;

		// Token: 0x0402DD87 RID: 187783
		[Token(Token = "0x402DD87")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0402DD88 RID: 187784
		[Token(Token = "0x402DD88")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetMapSize;

		// Token: 0x0402DD89 RID: 187785
		[Token(Token = "0x402DD89")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ClosePreviewViewIfOpen;

		// Token: 0x0402DD8A RID: 187786
		[Token(Token = "0x402DD8A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020059EA RID: 23018
		[Token(Token = "0x20059EA")]
		private class CrisisV2MapExclusionDictPool : GameObjectDictPool<CrisisV2MapExclusionGroupView>
		{
			// Token: 0x060218B1 RID: 137393 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60218B1")]
			[Address(RVA = "0x1BD1A70", Offset = "0x1BD0670", VA = "0x181BD1A70")]
			public CrisisV2MapExclusionDictPool(CrisisV2SlotDetailMapView closure)
			{
			}

			// Token: 0x060218B2 RID: 137394 RVA: 0x000BAB58 File Offset: 0x000B8D58
			[Token(Token = "0x60218B2")]
			[Address(RVA = "0x1BD14E0", Offset = "0x1BD00E0", VA = "0x181BD14E0", Slot = "5")]
			protected override bool ContainsKey(string key)
			{
				return default(bool);
			}

			// Token: 0x060218B3 RID: 137395 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60218B3")]
			[Address(RVA = "0x1BD15D0", Offset = "0x1BD01D0", VA = "0x181BD15D0", Slot = "7")]
			protected override CrisisV2MapExclusionGroupView GetPrefab(string key)
			{
				return null;
			}

			// Token: 0x060218B4 RID: 137396 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60218B4")]
			[Address(RVA = "0x1BD1650", Offset = "0x1BD0250", VA = "0x181BD1650", Slot = "8")]
			protected override CrisisV2MapExclusionGroupView Instantiate(string key, CrisisV2MapExclusionGroupView prefab)
			{
				return null;
			}

			// Token: 0x060218B5 RID: 137397 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60218B5")]
			[Address(RVA = "0x1BD1730", Offset = "0x1BD0330", VA = "0x181BD1730", Slot = "6")]
			protected override IEnumerable<string> IterKeys()
			{
				return null;
			}

			// Token: 0x060218B6 RID: 137398 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60218B6")]
			[Address(RVA = "0x1BD17E0", Offset = "0x1BD03E0", VA = "0x181BD17E0", Slot = "10")]
			protected override void OnAllocate(string key, CrisisV2MapExclusionGroupView obj)
			{
			}

			// Token: 0x060218B7 RID: 137399 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60218B7")]
			[Address(RVA = "0x1BD19F0", Offset = "0x1BD05F0", VA = "0x181BD19F0", Slot = "9")]
			protected override void Render(string key, CrisisV2MapExclusionGroupView obj)
			{
			}

			// Token: 0x0402DD8B RID: 187787
			[Token(Token = "0x402DD8B")]
			[FieldOffset(Offset = "0x20")]
			private CrisisV2SlotDetailMapView m_closure;

			// Token: 0x0402DD8C RID: 187788
			[Token(Token = "0x402DD8C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402DD8D RID: 187789
			[Token(Token = "0x402DD8D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ContainsKey;

			// Token: 0x0402DD8E RID: 187790
			[Token(Token = "0x402DD8E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0402DD8F RID: 187791
			[Token(Token = "0x402DD8F")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_Instantiate;

			// Token: 0x0402DD90 RID: 187792
			[Token(Token = "0x402DD90")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_IterKeys;

			// Token: 0x0402DD91 RID: 187793
			[Token(Token = "0x402DD91")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OnAllocate;

			// Token: 0x0402DD92 RID: 187794
			[Token(Token = "0x402DD92")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_Render;
		}

		// Token: 0x020059EC RID: 23020
		[Token(Token = "0x20059EC")]
		private class CrisisV2MapBagBgDictPool : GameObjectDictPool<CrisisV2MapBagBgView>
		{
			// Token: 0x060218C1 RID: 137409 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60218C1")]
			[Address(RVA = "0x1C0CDC0", Offset = "0x1C0B9C0", VA = "0x181C0CDC0")]
			public CrisisV2MapBagBgDictPool(CrisisV2SlotDetailMapView closure)
			{
			}

			// Token: 0x060218C2 RID: 137410 RVA: 0x000BAB88 File Offset: 0x000B8D88
			[Token(Token = "0x60218C2")]
			[Address(RVA = "0x1C0C720", Offset = "0x1C0B320", VA = "0x181C0C720", Slot = "5")]
			protected override bool ContainsKey(string key)
			{
				return default(bool);
			}

			// Token: 0x060218C3 RID: 137411 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60218C3")]
			[Address(RVA = "0x1C0C810", Offset = "0x1C0B410", VA = "0x181C0C810", Slot = "7")]
			protected override CrisisV2MapBagBgView GetPrefab(string key)
			{
				return null;
			}

			// Token: 0x060218C4 RID: 137412 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60218C4")]
			[Address(RVA = "0x1C0C890", Offset = "0x1C0B490", VA = "0x181C0C890", Slot = "8")]
			protected override CrisisV2MapBagBgView Instantiate(string key, CrisisV2MapBagBgView prefab)
			{
				return null;
			}

			// Token: 0x060218C5 RID: 137413 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60218C5")]
			[Address(RVA = "0x1C0C970", Offset = "0x1C0B570", VA = "0x181C0C970", Slot = "6")]
			protected override IEnumerable<string> IterKeys()
			{
				return null;
			}

			// Token: 0x060218C6 RID: 137414 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60218C6")]
			[Address(RVA = "0x1C0CA20", Offset = "0x1C0B620", VA = "0x181C0CA20", Slot = "10")]
			protected override void OnAllocate(string key, CrisisV2MapBagBgView obj)
			{
			}

			// Token: 0x060218C7 RID: 137415 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60218C7")]
			[Address(RVA = "0x1C0CC30", Offset = "0x1C0B830", VA = "0x181C0CC30", Slot = "9")]
			protected override void Render(string key, CrisisV2MapBagBgView obj)
			{
			}

			// Token: 0x0402DD98 RID: 187800
			[Token(Token = "0x402DD98")]
			[FieldOffset(Offset = "0x20")]
			private CrisisV2SlotDetailMapView m_closure;

			// Token: 0x0402DD99 RID: 187801
			[Token(Token = "0x402DD99")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402DD9A RID: 187802
			[Token(Token = "0x402DD9A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ContainsKey;

			// Token: 0x0402DD9B RID: 187803
			[Token(Token = "0x402DD9B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0402DD9C RID: 187804
			[Token(Token = "0x402DD9C")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_Instantiate;

			// Token: 0x0402DD9D RID: 187805
			[Token(Token = "0x402DD9D")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_IterKeys;

			// Token: 0x0402DD9E RID: 187806
			[Token(Token = "0x402DD9E")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OnAllocate;

			// Token: 0x0402DD9F RID: 187807
			[Token(Token = "0x402DD9F")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_Render;
		}

		// Token: 0x020059EE RID: 23022
		[Token(Token = "0x20059EE")]
		private class CrisisV2MapBagTitleDictPool : GameObjectDictPool<CrisisV2MapBagTitleView>
		{
			// Token: 0x060218D1 RID: 137425 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60218D1")]
			[Address(RVA = "0x1C0D530", Offset = "0x1C0C130", VA = "0x181C0D530")]
			public CrisisV2MapBagTitleDictPool(CrisisV2SlotDetailMapView closure)
			{
			}

			// Token: 0x060218D2 RID: 137426 RVA: 0x000BABB8 File Offset: 0x000B8DB8
			[Token(Token = "0x60218D2")]
			[Address(RVA = "0x1C0CE50", Offset = "0x1C0BA50", VA = "0x181C0CE50", Slot = "5")]
			protected override bool ContainsKey(string key)
			{
				return default(bool);
			}

			// Token: 0x060218D3 RID: 137427 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60218D3")]
			[Address(RVA = "0x1C0CF40", Offset = "0x1C0BB40", VA = "0x181C0CF40", Slot = "7")]
			protected override CrisisV2MapBagTitleView GetPrefab(string key)
			{
				return null;
			}

			// Token: 0x060218D4 RID: 137428 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60218D4")]
			[Address(RVA = "0x1C0CFC0", Offset = "0x1C0BBC0", VA = "0x181C0CFC0", Slot = "8")]
			protected override CrisisV2MapBagTitleView Instantiate(string key, CrisisV2MapBagTitleView prefab)
			{
				return null;
			}

			// Token: 0x060218D5 RID: 137429 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60218D5")]
			[Address(RVA = "0x1C0D0A0", Offset = "0x1C0BCA0", VA = "0x181C0D0A0", Slot = "6")]
			protected override IEnumerable<string> IterKeys()
			{
				return null;
			}

			// Token: 0x060218D6 RID: 137430 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60218D6")]
			[Address(RVA = "0x1C0D150", Offset = "0x1C0BD50", VA = "0x181C0D150", Slot = "10")]
			protected override void OnAllocate(string key, CrisisV2MapBagTitleView obj)
			{
			}

			// Token: 0x060218D7 RID: 137431 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60218D7")]
			[Address(RVA = "0x1C0D360", Offset = "0x1C0BF60", VA = "0x181C0D360", Slot = "9")]
			protected override void Render(string key, CrisisV2MapBagTitleView obj)
			{
			}

			// Token: 0x0402DDA5 RID: 187813
			[Token(Token = "0x402DDA5")]
			[FieldOffset(Offset = "0x20")]
			private CrisisV2SlotDetailMapView m_closure;

			// Token: 0x0402DDA6 RID: 187814
			[Token(Token = "0x402DDA6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402DDA7 RID: 187815
			[Token(Token = "0x402DDA7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ContainsKey;

			// Token: 0x0402DDA8 RID: 187816
			[Token(Token = "0x402DDA8")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0402DDA9 RID: 187817
			[Token(Token = "0x402DDA9")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_Instantiate;

			// Token: 0x0402DDAA RID: 187818
			[Token(Token = "0x402DDAA")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_IterKeys;

			// Token: 0x0402DDAB RID: 187819
			[Token(Token = "0x402DDAB")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OnAllocate;

			// Token: 0x0402DDAC RID: 187820
			[Token(Token = "0x402DDAC")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_Render;
		}

		// Token: 0x020059F0 RID: 23024
		[Token(Token = "0x20059F0")]
		private class CrisisV2MapNodeDictPool : GameObjectDictPool<CrisisV2MapNodeViewHolder>
		{
			// Token: 0x060218E1 RID: 137441 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60218E1")]
			[Address(RVA = "0x1C0DD20", Offset = "0x1C0C920", VA = "0x181C0DD20")]
			public CrisisV2MapNodeDictPool(CrisisV2SlotDetailMapView closure, RectTransform container, bool canCoverRoad)
			{
			}

			// Token: 0x060218E2 RID: 137442 RVA: 0x000BABE8 File Offset: 0x000B8DE8
			[Token(Token = "0x60218E2")]
			[Address(RVA = "0x1C0D5C0", Offset = "0x1C0C1C0", VA = "0x181C0D5C0", Slot = "5")]
			protected override bool ContainsKey(string key)
			{
				return default(bool);
			}

			// Token: 0x060218E3 RID: 137443 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60218E3")]
			[Address(RVA = "0x1C0D6B0", Offset = "0x1C0C2B0", VA = "0x181C0D6B0", Slot = "7")]
			protected override CrisisV2MapNodeViewHolder GetPrefab(string key)
			{
				return null;
			}

			// Token: 0x060218E4 RID: 137444 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60218E4")]
			[Address(RVA = "0x1C0D730", Offset = "0x1C0C330", VA = "0x181C0D730", Slot = "8")]
			protected override CrisisV2MapNodeViewHolder Instantiate(string key, CrisisV2MapNodeViewHolder prefab)
			{
				return null;
			}

			// Token: 0x060218E5 RID: 137445 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60218E5")]
			[Address(RVA = "0x1C0D800", Offset = "0x1C0C400", VA = "0x181C0D800", Slot = "6")]
			protected override IEnumerable<string> IterKeys()
			{
				return null;
			}

			// Token: 0x060218E6 RID: 137446 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60218E6")]
			[Address(RVA = "0x1C0D8B0", Offset = "0x1C0C4B0", VA = "0x181C0D8B0", Slot = "10")]
			protected override void OnAllocate(string key, CrisisV2MapNodeViewHolder obj)
			{
			}

			// Token: 0x060218E7 RID: 137447 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60218E7")]
			[Address(RVA = "0x1C0DA80", Offset = "0x1C0C680", VA = "0x181C0DA80", Slot = "9")]
			protected override void Render(string key, CrisisV2MapNodeViewHolder obj)
			{
			}

			// Token: 0x0402DDB2 RID: 187826
			[Token(Token = "0x402DDB2")]
			[FieldOffset(Offset = "0x20")]
			private CrisisV2SlotDetailMapView m_closure;

			// Token: 0x0402DDB3 RID: 187827
			[Token(Token = "0x402DDB3")]
			[FieldOffset(Offset = "0x28")]
			private RectTransform m_container;

			// Token: 0x0402DDB4 RID: 187828
			[Token(Token = "0x402DDB4")]
			[FieldOffset(Offset = "0x30")]
			private bool m_canCoverRoad;

			// Token: 0x0402DDB5 RID: 187829
			[Token(Token = "0x402DDB5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402DDB6 RID: 187830
			[Token(Token = "0x402DDB6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ContainsKey;

			// Token: 0x0402DDB7 RID: 187831
			[Token(Token = "0x402DDB7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0402DDB8 RID: 187832
			[Token(Token = "0x402DDB8")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_Instantiate;

			// Token: 0x0402DDB9 RID: 187833
			[Token(Token = "0x402DDB9")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_IterKeys;

			// Token: 0x0402DDBA RID: 187834
			[Token(Token = "0x402DDBA")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OnAllocate;

			// Token: 0x0402DDBB RID: 187835
			[Token(Token = "0x402DDBB")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_Render;
		}
	}
}
