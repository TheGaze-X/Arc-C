using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x0200585F RID: 22623
	[Token(Token = "0x200585F")]
	public class RL03TotemBuffListView : DataBinder<RL03TotemListViewProperty>
	{
		// Token: 0x17004D86 RID: 19846
		// (get) Token: 0x060210B2 RID: 135346 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060210B1 RID: 135345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004D86")]
		public Action<string, string> onItemClick
		{
			[Token(Token = "0x60210B2")]
			[Address(RVA = "0x1B62DD0", Offset = "0x1B619D0", VA = "0x181B62DD0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60210B1")]
			[Address(RVA = "0x1B62E30", Offset = "0x1B61A30", VA = "0x181B62E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060210B3 RID: 135347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210B3")]
		[Address(RVA = "0x1B62970", Offset = "0x1B61570", VA = "0x181B62970", Slot = "7")]
		public override void OnValueChanged(RL03TotemListViewProperty property)
		{
		}

		// Token: 0x060210B4 RID: 135348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210B4")]
		[Address(RVA = "0x1B62BF0", Offset = "0x1B617F0", VA = "0x181B62BF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060210B5 RID: 135349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210B5")]
		[Address(RVA = "0x1B62D60", Offset = "0x1B61960", VA = "0x181B62D60")]
		public RL03TotemBuffListView()
		{
		}

		// Token: 0x0402CF43 RID: 184131
		[Token(Token = "0x402CF43")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RL03TotemListTitleItemView _titleItemPrefab;

		// Token: 0x0402CF44 RID: 184132
		[Token(Token = "0x402CF44")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RL03TotemListItemView _itemPrefab;

		// Token: 0x0402CF45 RID: 184133
		[Token(Token = "0x402CF45")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIRecycleVerticalLayoutGroup _recycleList;

		// Token: 0x0402CF46 RID: 184134
		[Token(Token = "0x402CF46")]
		[FieldOffset(Offset = "0x38")]
		private RL03TotemBuffListView.RL03TotemListAdapter m_adapter;

		// Token: 0x0402CF47 RID: 184135
		[Token(Token = "0x402CF47")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x0402CF48 RID: 184136
		[Token(Token = "0x402CF48")]
		[FieldOffset(Offset = "0x44")]
		private int m_cachedSequenceNum;

		// Token: 0x0402CF4A RID: 184138
		[Token(Token = "0x402CF4A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_onItemClick;

		// Token: 0x0402CF4B RID: 184139
		[Token(Token = "0x402CF4B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onItemClick;

		// Token: 0x0402CF4C RID: 184140
		[Token(Token = "0x402CF4C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402CF4D RID: 184141
		[Token(Token = "0x402CF4D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402CF4E RID: 184142
		[Token(Token = "0x402CF4E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005860 RID: 22624
		[Token(Token = "0x2005860")]
		private class RL03TotemListAdapter : UIRecycleLayoutAdapter
		{
			// Token: 0x060210B6 RID: 135350 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60210B6")]
			[Address(RVA = "0x1B6A3E0", Offset = "0x1B68FE0", VA = "0x181B6A3E0")]
			public RL03TotemListAdapter(RL03TotemBuffListView closure)
			{
			}

			// Token: 0x060210B7 RID: 135351 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60210B7")]
			[Address(RVA = "0x1B69BC0", Offset = "0x1B687C0", VA = "0x181B69BC0", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x060210B8 RID: 135352 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60210B8")]
			[Address(RVA = "0x1B69CF0", Offset = "0x1B688F0", VA = "0x181B69CF0")]
			public void RebuildList(RL03TotemListViewModel viewModel)
			{
			}

			// Token: 0x060210B9 RID: 135353 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60210B9")]
			[Address(RVA = "0x1B6A180", Offset = "0x1B68D80", VA = "0x181B6A180")]
			public void UpdateSelectStatus(RL03TotemListViewModel viewModel)
			{
			}

			// Token: 0x0402CF4F RID: 184143
			[Token(Token = "0x402CF4F")]
			[FieldOffset(Offset = "0x18")]
			private RL03TotemBuffListView m_closure;

			// Token: 0x0402CF50 RID: 184144
			[Token(Token = "0x402CF50")]
			[FieldOffset(Offset = "0x20")]
			private List<UIRecycleLayoutAdapter.IVirtualView> m_views;

			// Token: 0x0402CF51 RID: 184145
			[Token(Token = "0x402CF51")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402CF52 RID: 184146
			[Token(Token = "0x402CF52")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

			// Token: 0x0402CF53 RID: 184147
			[Token(Token = "0x402CF53")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RebuildList;

			// Token: 0x0402CF54 RID: 184148
			[Token(Token = "0x402CF54")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_UpdateSelectStatus;
		}
	}
}
