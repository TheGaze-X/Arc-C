using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E71 RID: 28273
	[Token(Token = "0x2006E71")]
	public class ActVecBreakV2SquadBuffSelectView : DataBinder<ActVecBreakV2SquadBuffSelectProperty>
	{
		// Token: 0x060283B7 RID: 164791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283B7")]
		[Address(RVA = "0x2385E30", Offset = "0x2384A30", VA = "0x182385E30", Slot = "7")]
		public override void OnValueChanged(ActVecBreakV2SquadBuffSelectProperty property)
		{
		}

		// Token: 0x060283B8 RID: 164792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283B8")]
		[Address(RVA = "0x2386140", Offset = "0x2384D40", VA = "0x182386140")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060283B9 RID: 164793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283B9")]
		[Address(RVA = "0x2386050", Offset = "0x2384C50", VA = "0x182386050")]
		private void _EventOnBuffItemClick(string stageId)
		{
		}

		// Token: 0x060283BA RID: 164794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283BA")]
		[Address(RVA = "0x2385C00", Offset = "0x2384800", VA = "0x182385C00")]
		public void EventOnCloseBtnClick()
		{
		}

		// Token: 0x060283BB RID: 164795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283BB")]
		[Address(RVA = "0x2385DA0", Offset = "0x23849A0", VA = "0x182385DA0")]
		public void EventOnUnselectAllClick()
		{
		}

		// Token: 0x060283BC RID: 164796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283BC")]
		[Address(RVA = "0x2385D10", Offset = "0x2384910", VA = "0x182385D10")]
		public void EventOnSaveClick()
		{
		}

		// Token: 0x060283BD RID: 164797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283BD")]
		[Address(RVA = "0x2385C80", Offset = "0x2384880", VA = "0x182385C80")]
		public void EventOnJumpToDefense()
		{
		}

		// Token: 0x060283BE RID: 164798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283BE")]
		[Address(RVA = "0x23863C0", Offset = "0x2384FC0", VA = "0x1823863C0")]
		public ActVecBreakV2SquadBuffSelectView()
		{
		}

		// Token: 0x040392DC RID: 234204
		[Token(Token = "0x40392DC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _buffListContent;

		// Token: 0x040392DD RID: 234205
		[Token(Token = "0x40392DD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _buffDetailContent;

		// Token: 0x040392DE RID: 234206
		[Token(Token = "0x40392DE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _selectedBuffNum;

		// Token: 0x040392DF RID: 234207
		[Token(Token = "0x40392DF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _buffMaxNum;

		// Token: 0x040392E0 RID: 234208
		[Token(Token = "0x40392E0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _buffEmpty;

		// Token: 0x040392E1 RID: 234209
		[Token(Token = "0x40392E1")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasInited;

		// Token: 0x040392E2 RID: 234210
		[Token(Token = "0x40392E2")]
		[FieldOffset(Offset = "0x50")]
		private List<ActVecBreakV2DefenseBuffListItemModel> m_cacheListItemModels;

		// Token: 0x040392E3 RID: 234211
		[Token(Token = "0x40392E3")]
		[FieldOffset(Offset = "0x58")]
		private List<string> m_cacheSelectedBuffIds;

		// Token: 0x040392E4 RID: 234212
		[Token(Token = "0x40392E4")]
		[FieldOffset(Offset = "0x60")]
		private List<ActVecBreakV2DefenseStageBuffItemModel> m_cacheSelectedBuffModels;

		// Token: 0x040392E5 RID: 234213
		[Token(Token = "0x40392E5")]
		[FieldOffset(Offset = "0x68")]
		private ActVecBreakV2SquadBuffSelectView.BuffListAdapter m_buffListAdapter;

		// Token: 0x040392E6 RID: 234214
		[Token(Token = "0x40392E6")]
		[FieldOffset(Offset = "0x70")]
		private ActVecBreakV2SquadBuffSelectView.BuffDetailAdapter m_buffDetailAdapter;

		// Token: 0x040392E7 RID: 234215
		[Token(Token = "0x40392E7")]
		[FieldOffset(Offset = "0x78")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040392E8 RID: 234216
		[Token(Token = "0x40392E8")]
		[FieldOffset(Offset = "0x88")]
		private ActVecBreakV2SquadBuffSelectViewModel m_cacheModel;

		// Token: 0x040392E9 RID: 234217
		[Token(Token = "0x40392E9")]
		[FieldOffset(Offset = "0x90")]
		private int m_selectedBuffNum;

		// Token: 0x040392EA RID: 234218
		[Token(Token = "0x40392EA")]
		[FieldOffset(Offset = "0x94")]
		private int m_maxBuffNum;

		// Token: 0x040392EB RID: 234219
		[Token(Token = "0x40392EB")]
		[FieldOffset(Offset = "0x98")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040392EC RID: 234220
		[Token(Token = "0x40392EC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040392ED RID: 234221
		[Token(Token = "0x40392ED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040392EE RID: 234222
		[Token(Token = "0x40392EE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EventOnBuffItemClick;

		// Token: 0x040392EF RID: 234223
		[Token(Token = "0x40392EF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnCloseBtnClick;

		// Token: 0x040392F0 RID: 234224
		[Token(Token = "0x40392F0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnUnselectAllClick;

		// Token: 0x040392F1 RID: 234225
		[Token(Token = "0x40392F1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnSaveClick;

		// Token: 0x040392F2 RID: 234226
		[Token(Token = "0x40392F2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnJumpToDefense;

		// Token: 0x040392F3 RID: 234227
		[Token(Token = "0x40392F3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006E72 RID: 28274
		[Token(Token = "0x2006E72")]
		private class BuffListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x060283BF RID: 164799 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60283BF")]
			[Address(RVA = "0x2386B20", Offset = "0x2385720", VA = "0x182386B20")]
			public BuffListAdapter(ActVecBreakV2SquadBuffSelectView closure)
			{
			}

			// Token: 0x17005F06 RID: 24326
			// (get) Token: 0x060283C0 RID: 164800 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060283C1 RID: 164801 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005F06")]
			public Action<string> onItemClick
			{
				[Token(Token = "0x60283C0")]
				[Address(RVA = "0x2386C20", Offset = "0x2385820", VA = "0x182386C20")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x60283C1")]
				[Address(RVA = "0x2386C80", Offset = "0x2385880", VA = "0x182386C80")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17005F07 RID: 24327
			// (get) Token: 0x060283C2 RID: 164802 RVA: 0x000D0F38 File Offset: 0x000CF138
			[Token(Token = "0x17005F07")]
			public override int count
			{
				[Token(Token = "0x60283C2")]
				[Address(RVA = "0x2386BA0", Offset = "0x23857A0", VA = "0x182386BA0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060283C3 RID: 164803 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60283C3")]
			[Address(RVA = "0x23867E0", Offset = "0x23853E0", VA = "0x1823867E0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x060283C4 RID: 164804 RVA: 0x000D0F50 File Offset: 0x000CF150
			[Token(Token = "0x60283C4")]
			[Address(RVA = "0x2386A70", Offset = "0x2385670", VA = "0x182386A70")]
			private bool _CheckCanSelectByStageId(string stageId)
			{
				return default(bool);
			}

			// Token: 0x040392F4 RID: 234228
			[Token(Token = "0x40392F4")]
			[FieldOffset(Offset = "0x20")]
			private ActVecBreakV2SquadBuffSelectView m_closure;

			// Token: 0x040392F6 RID: 234230
			[Token(Token = "0x40392F6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040392F7 RID: 234231
			[Token(Token = "0x40392F7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_onItemClick;

			// Token: 0x040392F8 RID: 234232
			[Token(Token = "0x40392F8")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_set_onItemClick;

			// Token: 0x040392F9 RID: 234233
			[Token(Token = "0x40392F9")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040392FA RID: 234234
			[Token(Token = "0x40392FA")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040392FB RID: 234235
			[Token(Token = "0x40392FB")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__CheckCanSelectByStageId;
		}

		// Token: 0x02006E73 RID: 28275
		[Token(Token = "0x2006E73")]
		private class BuffDetailAdapter : SimpleLayoutAdapter
		{
			// Token: 0x060283C5 RID: 164805 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60283C5")]
			[Address(RVA = "0x23866E0", Offset = "0x23852E0", VA = "0x1823866E0")]
			public BuffDetailAdapter(ActVecBreakV2SquadBuffSelectView closure)
			{
			}

			// Token: 0x17005F08 RID: 24328
			// (get) Token: 0x060283C6 RID: 164806 RVA: 0x000D0F68 File Offset: 0x000CF168
			[Token(Token = "0x17005F08")]
			public override int count
			{
				[Token(Token = "0x60283C6")]
				[Address(RVA = "0x2386760", Offset = "0x2385360", VA = "0x182386760", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060283C7 RID: 164807 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60283C7")]
			[Address(RVA = "0x2386430", Offset = "0x2385030", VA = "0x182386430", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040392FC RID: 234236
			[Token(Token = "0x40392FC")]
			[FieldOffset(Offset = "0x20")]
			private ActVecBreakV2SquadBuffSelectView m_closure;

			// Token: 0x040392FD RID: 234237
			[Token(Token = "0x40392FD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040392FE RID: 234238
			[Token(Token = "0x40392FE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040392FF RID: 234239
			[Token(Token = "0x40392FF")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
