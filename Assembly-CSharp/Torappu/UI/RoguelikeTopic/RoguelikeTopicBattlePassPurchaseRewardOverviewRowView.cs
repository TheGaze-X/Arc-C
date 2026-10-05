using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x0200448D RID: 17549
	[Token(Token = "0x200448D")]
	public class RoguelikeTopicBattlePassPurchaseRewardOverviewRowView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601ACEB RID: 109803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACEB")]
		[Address(RVA = "0x13F6A50", Offset = "0x13F5650", VA = "0x1813F6A50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601ACEC RID: 109804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACEC")]
		[Address(RVA = "0x13F6740", Offset = "0x13F5340", VA = "0x1813F6740")]
		public void Render(RoguelikeTopicBattlePassPurchaseRewardOverviewRowView.Param param)
		{
		}

		// Token: 0x0601ACED RID: 109805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACED")]
		[Address(RVA = "0x13F6B70", Offset = "0x13F5770", VA = "0x1813F6B70")]
		public RoguelikeTopicBattlePassPurchaseRewardOverviewRowView()
		{
		}

		// Token: 0x040224EB RID: 140523
		[Token(Token = "0x40224EB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelGrandPrize;

		// Token: 0x040224EC RID: 140524
		[Token(Token = "0x40224EC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelNormalPrize;

		// Token: 0x040224ED RID: 140525
		[Token(Token = "0x40224ED")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _itemGroup;

		// Token: 0x040224EE RID: 140526
		[Token(Token = "0x40224EE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _imgGrand;

		// Token: 0x040224EF RID: 140527
		[Token(Token = "0x40224EF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _itemCardScale;

		// Token: 0x040224F0 RID: 140528
		[Token(Token = "0x40224F0")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_inited;

		// Token: 0x040224F1 RID: 140529
		[Token(Token = "0x40224F1")]
		[FieldOffset(Offset = "0x40")]
		private RoguelikeTopicBattlePassPurchaseRewardOverviewRowView.Adapter m_adapter;

		// Token: 0x040224F2 RID: 140530
		[Token(Token = "0x40224F2")]
		[FieldOffset(Offset = "0x48")]
		private List<UIItemViewModel> m_cachedItemList;

		// Token: 0x040224F3 RID: 140531
		[Token(Token = "0x40224F3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040224F4 RID: 140532
		[Token(Token = "0x40224F4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040224F5 RID: 140533
		[Token(Token = "0x40224F5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200448E RID: 17550
		[Token(Token = "0x200448E")]
		public struct Param
		{
			// Token: 0x040224F6 RID: 140534
			[Token(Token = "0x40224F6")]
			[FieldOffset(Offset = "0x0")]
			public int preferredSize;

			// Token: 0x040224F7 RID: 140535
			[Token(Token = "0x40224F7")]
			[FieldOffset(Offset = "0x4")]
			public bool isGrandPrize;

			// Token: 0x040224F8 RID: 140536
			[Token(Token = "0x40224F8")]
			[FieldOffset(Offset = "0x8")]
			public int rowIndex;

			// Token: 0x040224F9 RID: 140537
			[Token(Token = "0x40224F9")]
			[FieldOffset(Offset = "0x10")]
			public List<UIItemViewModel> items;

			// Token: 0x040224FA RID: 140538
			[Token(Token = "0x40224FA")]
			[FieldOffset(Offset = "0x18")]
			public RoguelikeTopicBattlePassPurchaseRewardOverviewRowView prefab;

			// Token: 0x040224FB RID: 140539
			[Token(Token = "0x40224FB")]
			[FieldOffset(Offset = "0x20")]
			public RoguelikeTopicBattlePassStyle style;
		}

		// Token: 0x0200448F RID: 17551
		[Token(Token = "0x200448F")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<RoguelikeTopicBattlePassPurchaseRewardOverviewRowView>
		{
			// Token: 0x0601ACEE RID: 109806 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601ACEE")]
			[Address(RVA = "0x1400B70", Offset = "0x13FF770", VA = "0x181400B70")]
			public VirtualView(RoguelikeTopicBattlePassPurchaseRewardOverviewRowView.Param param)
			{
			}

			// Token: 0x0601ACEF RID: 109807 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601ACEF")]
			[Address(RVA = "0x1400960", Offset = "0x13FF560", VA = "0x181400960", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x0601ACF0 RID: 109808 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601ACF0")]
			[Address(RVA = "0x1400B10", Offset = "0x13FF710", VA = "0x181400B10", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x0601ACF1 RID: 109809 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601ACF1")]
			[Address(RVA = "0x1400820", Offset = "0x13FF420", VA = "0x181400820", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x0601ACF2 RID: 109810 RVA: 0x000A3638 File Offset: 0x000A1838
			[Token(Token = "0x601ACF2")]
			[Address(RVA = "0x1400890", Offset = "0x13FF490", VA = "0x181400890", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x040224FC RID: 140540
			[Token(Token = "0x40224FC")]
			[FieldOffset(Offset = "0x20")]
			private RoguelikeTopicBattlePassPurchaseRewardOverviewRowView.Param m_param;

			// Token: 0x040224FD RID: 140541
			[Token(Token = "0x40224FD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040224FE RID: 140542
			[Token(Token = "0x40224FE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x040224FF RID: 140543
			[Token(Token = "0x40224FF")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x04022500 RID: 140544
			[Token(Token = "0x4022500")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x04022501 RID: 140545
			[Token(Token = "0x4022501")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetPreferSize;
		}

		// Token: 0x02004490 RID: 17552
		[Token(Token = "0x2004490")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17003FAE RID: 16302
			// (get) Token: 0x0601ACF3 RID: 109811 RVA: 0x000A3650 File Offset: 0x000A1850
			[Token(Token = "0x17003FAE")]
			public override int count
			{
				[Token(Token = "0x601ACF3")]
				[Address(RVA = "0x13ED520", Offset = "0x13EC120", VA = "0x1813ED520", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601ACF4 RID: 109812 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601ACF4")]
			[Address(RVA = "0x13ED2F0", Offset = "0x13EBEF0", VA = "0x1813ED2F0")]
			public Adapter(RoguelikeTopicBattlePassPurchaseRewardOverviewRowView closure)
			{
			}

			// Token: 0x0601ACF5 RID: 109813 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601ACF5")]
			[Address(RVA = "0x13ECE80", Offset = "0x13EBA80", VA = "0x1813ECE80", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04022502 RID: 140546
			[Token(Token = "0x4022502")]
			[FieldOffset(Offset = "0x20")]
			private RoguelikeTopicBattlePassPurchaseRewardOverviewRowView m_closure;

			// Token: 0x04022503 RID: 140547
			[Token(Token = "0x4022503")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04022504 RID: 140548
			[Token(Token = "0x4022504")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04022505 RID: 140549
			[Token(Token = "0x4022505")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
