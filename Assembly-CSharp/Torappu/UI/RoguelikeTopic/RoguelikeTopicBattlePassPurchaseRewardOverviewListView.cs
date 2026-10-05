using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x0200448B RID: 17547
	[Token(Token = "0x200448B")]
	public class RoguelikeTopicBattlePassPurchaseRewardOverviewListView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601ACE4 RID: 109796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACE4")]
		[Address(RVA = "0x13F65B0", Offset = "0x13F51B0", VA = "0x1813F65B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601ACE5 RID: 109797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACE5")]
		[Address(RVA = "0x13F62B0", Offset = "0x13F4EB0", VA = "0x1813F62B0")]
		public void Init(RoguelikeTopicBattlePassStyle style)
		{
		}

		// Token: 0x0601ACE6 RID: 109798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACE6")]
		[Address(RVA = "0x13F6330", Offset = "0x13F4F30", VA = "0x1813F6330")]
		public void Render(RoguelikeTopicBattlePassPurchaseOverviewViewModel viewModel)
		{
		}

		// Token: 0x0601ACE7 RID: 109799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACE7")]
		[Address(RVA = "0x13F66D0", Offset = "0x13F52D0", VA = "0x1813F66D0")]
		public RoguelikeTopicBattlePassPurchaseRewardOverviewListView()
		{
		}

		// Token: 0x040224DA RID: 140506
		[Token(Token = "0x40224DA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int _columnCount;

		// Token: 0x040224DB RID: 140507
		[Token(Token = "0x40224DB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIRecycleLayoutGroup _itemGroup;

		// Token: 0x040224DC RID: 140508
		[Token(Token = "0x40224DC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RoguelikeTopicBattlePassPurchaseRewardOverviewRowView _rowPrefab;

		// Token: 0x040224DD RID: 140509
		[Token(Token = "0x40224DD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _rowHeightEnd;

		// Token: 0x040224DE RID: 140510
		[Token(Token = "0x40224DE")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int _rowHeightNormal;

		// Token: 0x040224DF RID: 140511
		[Token(Token = "0x40224DF")]
		[FieldOffset(Offset = "0x38")]
		private RoguelikeTopicBattlePassPurchaseOverviewViewModel m_cachedModel;

		// Token: 0x040224E0 RID: 140512
		[Token(Token = "0x40224E0")]
		[FieldOffset(Offset = "0x40")]
		private RoguelikeTopicBattlePassStyle m_style;

		// Token: 0x040224E1 RID: 140513
		[Token(Token = "0x40224E1")]
		[FieldOffset(Offset = "0x48")]
		private RoguelikeTopicBattlePassPurchaseRewardOverviewListView.Adapter m_adapter;

		// Token: 0x040224E2 RID: 140514
		[Token(Token = "0x40224E2")]
		[FieldOffset(Offset = "0x50")]
		private bool m_inited;

		// Token: 0x040224E3 RID: 140515
		[Token(Token = "0x40224E3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040224E4 RID: 140516
		[Token(Token = "0x40224E4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040224E5 RID: 140517
		[Token(Token = "0x40224E5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040224E6 RID: 140518
		[Token(Token = "0x40224E6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200448C RID: 17548
		[Token(Token = "0x200448C")]
		private class Adapter : UIRecycleLayoutAdapter
		{
			// Token: 0x0601ACE8 RID: 109800 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601ACE8")]
			[Address(RVA = "0x13ED270", Offset = "0x13EBE70", VA = "0x1813ED270")]
			public Adapter(RoguelikeTopicBattlePassPurchaseRewardOverviewListView closure)
			{
			}

			// Token: 0x0601ACE9 RID: 109801 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601ACE9")]
			[Address(RVA = "0x13EC9A0", Offset = "0x13EB5A0", VA = "0x1813EC9A0")]
			public void RebuildList()
			{
			}

			// Token: 0x0601ACEA RID: 109802 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601ACEA")]
			[Address(RVA = "0x13EC0B0", Offset = "0x13EACB0", VA = "0x1813EC0B0", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x040224E7 RID: 140519
			[Token(Token = "0x40224E7")]
			[FieldOffset(Offset = "0x18")]
			private RoguelikeTopicBattlePassPurchaseRewardOverviewListView m_closure;

			// Token: 0x040224E8 RID: 140520
			[Token(Token = "0x40224E8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040224E9 RID: 140521
			[Token(Token = "0x40224E9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RebuildList;

			// Token: 0x040224EA RID: 140522
			[Token(Token = "0x40224EA")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;
		}
	}
}
