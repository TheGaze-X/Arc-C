using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL02
{
	// Token: 0x0200461C RID: 17948
	[Token(Token = "0x200461C")]
	public class RL02OuterBuffSummaryMergedGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004103 RID: 16643
		// (get) Token: 0x0601B47D RID: 111741 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B47E RID: 111742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004103")]
		public UIPage page
		{
			[Token(Token = "0x601B47D")]
			[Address(RVA = "0x14A0C00", Offset = "0x149F800", VA = "0x1814A0C00")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x601B47E")]
			[Address(RVA = "0x14A0C60", Offset = "0x149F860", VA = "0x1814A0C60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601B47F RID: 111743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B47F")]
		[Address(RVA = "0x14A08B0", Offset = "0x149F4B0", VA = "0x1814A08B0")]
		public void Render(RL02OuterBuffListModel viewModel)
		{
		}

		// Token: 0x0601B480 RID: 111744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B480")]
		[Address(RVA = "0x14A0A80", Offset = "0x149F680", VA = "0x1814A0A80")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B481 RID: 111745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B481")]
		[Address(RVA = "0x14A0BA0", Offset = "0x149F7A0", VA = "0x1814A0BA0")]
		public RL02OuterBuffSummaryMergedGroupView()
		{
		}

		// Token: 0x04023359 RID: 144217
		[Token(Token = "0x4023359")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _itemContent;

		// Token: 0x0402335B RID: 144219
		[Token(Token = "0x402335B")]
		[FieldOffset(Offset = "0x28")]
		private List<RL02OuterBuffListMergedItemModel> m_cachedModel;

		// Token: 0x0402335C RID: 144220
		[Token(Token = "0x402335C")]
		[FieldOffset(Offset = "0x30")]
		private string m_topicId;

		// Token: 0x0402335D RID: 144221
		[Token(Token = "0x402335D")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x0402335E RID: 144222
		[Token(Token = "0x402335E")]
		[FieldOffset(Offset = "0x40")]
		private RL02OuterBuffSummaryMergedGroupView.Adapter m_adapter;

		// Token: 0x0402335F RID: 144223
		[Token(Token = "0x402335F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x04023360 RID: 144224
		[Token(Token = "0x4023360")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x04023361 RID: 144225
		[Token(Token = "0x4023361")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023362 RID: 144226
		[Token(Token = "0x4023362")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04023363 RID: 144227
		[Token(Token = "0x4023363")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200461D RID: 17949
		[Token(Token = "0x200461D")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x0601B482 RID: 111746 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B482")]
			[Address(RVA = "0x14959E0", Offset = "0x14945E0", VA = "0x1814959E0")]
			public Adapter(RL02OuterBuffSummaryMergedGroupView closure)
			{
			}

			// Token: 0x17004104 RID: 16644
			// (get) Token: 0x0601B483 RID: 111747 RVA: 0x000A4CB8 File Offset: 0x000A2EB8
			[Token(Token = "0x17004104")]
			public override int count
			{
				[Token(Token = "0x601B483")]
				[Address(RVA = "0x1495CD0", Offset = "0x14948D0", VA = "0x181495CD0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601B484 RID: 111748 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B484")]
			[Address(RVA = "0x1495480", Offset = "0x1494080", VA = "0x181495480", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04023364 RID: 144228
			[Token(Token = "0x4023364")]
			[FieldOffset(Offset = "0x20")]
			private RL02OuterBuffSummaryMergedGroupView m_closure;

			// Token: 0x04023365 RID: 144229
			[Token(Token = "0x4023365")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04023366 RID: 144230
			[Token(Token = "0x4023366")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04023367 RID: 144231
			[Token(Token = "0x4023367")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
