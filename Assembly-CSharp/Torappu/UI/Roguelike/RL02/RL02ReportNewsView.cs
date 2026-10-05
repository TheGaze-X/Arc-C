using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Atlas;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x0200575A RID: 22362
	[Token(Token = "0x200575A")]
	public class RL02ReportNewsView : RL02CommonReportView<RL02EndingFrameNewsReportViewModel>
	{
		// Token: 0x06020C1F RID: 134175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C1F")]
		[Address(RVA = "0x1B25A30", Offset = "0x1B24630", VA = "0x181B25A30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020C20 RID: 134176 RVA: 0x000B70D8 File Offset: 0x000B52D8
		[Token(Token = "0x6020C20")]
		[Address(RVA = "0x1B258A0", Offset = "0x1B244A0", VA = "0x181B258A0", Slot = "4")]
		public override RL02ReportController.ReportViewType GetViewType()
		{
			return RL02ReportController.ReportViewType.NONE;
		}

		// Token: 0x06020C21 RID: 134177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020C21")]
		[Address(RVA = "0x1B25830", Offset = "0x1B24430", VA = "0x181B25830", Slot = "7")]
		protected override string GetShowAnimName()
		{
			return null;
		}

		// Token: 0x06020C22 RID: 134178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C22")]
		[Address(RVA = "0x1B25900", Offset = "0x1B24500", VA = "0x181B25900", Slot = "8")]
		protected override void Render(RL02EndingFrameNewsReportViewModel viewModel)
		{
		}

		// Token: 0x06020C23 RID: 134179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C23")]
		[Address(RVA = "0x1B25C20", Offset = "0x1B24820", VA = "0x181B25C20")]
		public RL02ReportNewsView()
		{
		}

		// Token: 0x0402C794 RID: 182164
		[Token(Token = "0x402C794")]
		private const string ENTER_ANIM_NAME = "report_news";

		// Token: 0x0402C795 RID: 182165
		[Token(Token = "0x402C795")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RL02ReportNewsView.NewsItemView[] _newsItemViews;

		// Token: 0x0402C796 RID: 182166
		[Token(Token = "0x402C796")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAtlasObject _atlasObject;

		// Token: 0x0402C797 RID: 182167
		[Token(Token = "0x402C797")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RL02ReportNewsView.NewsAtlasConfig[] _atlasConfigs;

		// Token: 0x0402C798 RID: 182168
		[Token(Token = "0x402C798")]
		[FieldOffset(Offset = "0x70")]
		private bool m_inited;

		// Token: 0x0402C799 RID: 182169
		[Token(Token = "0x402C799")]
		[FieldOffset(Offset = "0x78")]
		private RL02EndingText m_cachedTextConfig;

		// Token: 0x0402C79A RID: 182170
		[Token(Token = "0x402C79A")]
		[FieldOffset(Offset = "0x80")]
		private Dictionary<RL02EndingFrameNewsReportViewModel.NewsType, RL02ReportNewsView.NewsAtlasConfig> m_newsImageConfigs;

		// Token: 0x0402C79B RID: 182171
		[Token(Token = "0x402C79B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402C79C RID: 182172
		[Token(Token = "0x402C79C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0402C79D RID: 182173
		[Token(Token = "0x402C79D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetShowAnimName;

		// Token: 0x0402C79E RID: 182174
		[Token(Token = "0x402C79E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C79F RID: 182175
		[Token(Token = "0x402C79F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200575B RID: 22363
		[Token(Token = "0x200575B")]
		[Serializable]
		private class NewsItemView : IHotfixable
		{
			// Token: 0x06020C24 RID: 134180 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C24")]
			[Address(RVA = "0x1B199B0", Offset = "0x1B185B0", VA = "0x181B199B0")]
			public void Init(RL02ReportNewsView closure)
			{
			}

			// Token: 0x06020C25 RID: 134181 RVA: 0x000B70F0 File Offset: 0x000B52F0
			[Token(Token = "0x6020C25")]
			[Address(RVA = "0x1B19C60", Offset = "0x1B18860", VA = "0x181B19C60")]
			private SpriteRenderData _GetNewsImage(RL02EndingFrameNewsReportViewModel.NewsType newsType)
			{
				return default(SpriteRenderData);
			}

			// Token: 0x06020C26 RID: 134182 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C26")]
			[Address(RVA = "0x1B19D90", Offset = "0x1B18990", VA = "0x181B19D90")]
			private void _RenderItemView(RL02EndingFrameNewsReportViewModel.NewsItemModel itemModel)
			{
			}

			// Token: 0x06020C27 RID: 134183 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C27")]
			[Address(RVA = "0x1B19A30", Offset = "0x1B18630", VA = "0x181B19A30")]
			public void Render(RL02EndingFrameNewsReportViewModel.NewsItemModel itemModel)
			{
			}

			// Token: 0x06020C28 RID: 134184 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C28")]
			[Address(RVA = "0x1B19FC0", Offset = "0x1B18BC0", VA = "0x181B19FC0")]
			public NewsItemView()
			{
			}

			// Token: 0x0402C7A0 RID: 182176
			[Token(Token = "0x402C7A0")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _root;

			// Token: 0x0402C7A1 RID: 182177
			[Token(Token = "0x402C7A1")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private UIAtlasImage _newsImage;

			// Token: 0x0402C7A2 RID: 182178
			[Token(Token = "0x402C7A2")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private RectTransform _itemViewHolder;

			// Token: 0x0402C7A3 RID: 182179
			[Token(Token = "0x402C7A3")]
			[FieldOffset(Offset = "0x28")]
			private RL02ReportNewsView m_closure;

			// Token: 0x0402C7A4 RID: 182180
			[Token(Token = "0x402C7A4")]
			[FieldOffset(Offset = "0x30")]
			private RL02ReportNewsItemViewBase m_itemView;

			// Token: 0x0402C7A5 RID: 182181
			[Token(Token = "0x402C7A5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x0402C7A6 RID: 182182
			[Token(Token = "0x402C7A6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__GetNewsImage;

			// Token: 0x0402C7A7 RID: 182183
			[Token(Token = "0x402C7A7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__RenderItemView;

			// Token: 0x0402C7A8 RID: 182184
			[Token(Token = "0x402C7A8")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0402C7A9 RID: 182185
			[Token(Token = "0x402C7A9")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200575C RID: 22364
		[Token(Token = "0x200575C")]
		[Serializable]
		private struct NewsAtlasConfig
		{
			// Token: 0x0402C7AA RID: 182186
			[Token(Token = "0x402C7AA")]
			[FieldOffset(Offset = "0x0")]
			public RL02EndingFrameNewsReportViewModel.NewsType newsType;

			// Token: 0x0402C7AB RID: 182187
			[Token(Token = "0x402C7AB")]
			[FieldOffset(Offset = "0x8")]
			public string newsImageName;

			// Token: 0x0402C7AC RID: 182188
			[Token(Token = "0x402C7AC")]
			[FieldOffset(Offset = "0x10")]
			public RL02ReportNewsItemViewBase newsItemPrefab;
		}
	}
}
