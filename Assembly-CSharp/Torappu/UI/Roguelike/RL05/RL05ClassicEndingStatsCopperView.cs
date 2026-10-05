using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005579 RID: 21881
	[Token(Token = "0x2005579")]
	public class RL05ClassicEndingStatsCopperView : RoguelikeClassicEndingStatsViewComponent<RL05ClassicEndingStatsCopperViewModel>
	{
		// Token: 0x0602027A RID: 131706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602027A")]
		[Address(RVA = "0x1A347C0", Offset = "0x1A333C0", VA = "0x181A347C0", Slot = "5")]
		public override UIRecycleLayoutAdapter.IVirtualView CreateVirtualView(RoguelikeClassicEndingStatsViewComponentBase compPrefab, RoguelikeClassicEndingStatsViewComponentModel viewModel, UIPage page)
		{
			return null;
		}

		// Token: 0x0602027B RID: 131707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602027B")]
		[Address(RVA = "0x1A34900", Offset = "0x1A33500", VA = "0x181A34900", Slot = "7")]
		protected override void Render(RL05ClassicEndingStatsCopperViewModel viewModel)
		{
		}

		// Token: 0x0602027C RID: 131708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602027C")]
		[Address(RVA = "0x1A34C80", Offset = "0x1A33880", VA = "0x181A34C80")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602027D RID: 131709 RVA: 0x000B4D38 File Offset: 0x000B2F38
		[Token(Token = "0x602027D")]
		[Address(RVA = "0x1A34B10", Offset = "0x1A33710", VA = "0x181A34B10")]
		private static float _CalcPrefabHeight(RL05ClassicEndingStatsCopperView prefab, RL05ClassicEndingStatsCopperViewModel viewModel)
		{
			return 0f;
		}

		// Token: 0x0602027E RID: 131710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602027E")]
		[Address(RVA = "0x1A34DA0", Offset = "0x1A339A0", VA = "0x181A34DA0")]
		public RL05ClassicEndingStatsCopperView()
		{
		}

		// Token: 0x0402B6F6 RID: 177910
		[Token(Token = "0x402B6F6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GridLayoutGroup _layoutGroup;

		// Token: 0x0402B6F7 RID: 177911
		[Token(Token = "0x402B6F7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0402B6F8 RID: 177912
		[Token(Token = "0x402B6F8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _copperCntTxt;

		// Token: 0x0402B6F9 RID: 177913
		[Token(Token = "0x402B6F9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _minHeight;

		// Token: 0x0402B6FA RID: 177914
		[Token(Token = "0x402B6FA")]
		[FieldOffset(Offset = "0x40")]
		private List<RL05ClassicEndingStatsCopperItemModel> m_copperItemModelList;

		// Token: 0x0402B6FB RID: 177915
		[Token(Token = "0x402B6FB")]
		[FieldOffset(Offset = "0x48")]
		private RL05ClassicEndingStatsCopperView.EndingFragmentAdapter m_adapter;

		// Token: 0x0402B6FC RID: 177916
		[Token(Token = "0x402B6FC")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x0402B6FD RID: 177917
		[Token(Token = "0x402B6FD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateVirtualView;

		// Token: 0x0402B6FE RID: 177918
		[Token(Token = "0x402B6FE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B6FF RID: 177919
		[Token(Token = "0x402B6FF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402B700 RID: 177920
		[Token(Token = "0x402B700")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CalcPrefabHeight;

		// Token: 0x0402B701 RID: 177921
		[Token(Token = "0x402B701")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200557A RID: 21882
		[Token(Token = "0x200557A")]
		public class VirtualView : RoguelikeClassicEndingStatsCompVirtualView<RL05ClassicEndingStatsCopperView, RL05ClassicEndingStatsCopperViewModel>
		{
			// Token: 0x0602027F RID: 131711 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602027F")]
			[Address(RVA = "0x1A47290", Offset = "0x1A45E90", VA = "0x181A47290")]
			public VirtualView(RoguelikeClassicEndingStatsViewComponentBase prefab, RoguelikeClassicEndingStatsViewComponentModel viewModel, UIPage page)
			{
			}

			// Token: 0x06020280 RID: 131712 RVA: 0x000B4D50 File Offset: 0x000B2F50
			[Token(Token = "0x6020280")]
			[Address(RVA = "0x1A47090", Offset = "0x1A45C90", VA = "0x181A47090", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0402B702 RID: 177922
			[Token(Token = "0x402B702")]
			[FieldOffset(Offset = "0x38")]
			private float m_cachedHeight;

			// Token: 0x0402B703 RID: 177923
			[Token(Token = "0x402B703")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402B704 RID: 177924
			[Token(Token = "0x402B704")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPreferSize;
		}

		// Token: 0x0200557B RID: 21883
		[Token(Token = "0x200557B")]
		private class EndingFragmentAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06020281 RID: 131713 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020281")]
			[Address(RVA = "0x1A30E40", Offset = "0x1A2FA40", VA = "0x181A30E40")]
			public EndingFragmentAdapter(RL05ClassicEndingStatsCopperView closure)
			{
			}

			// Token: 0x17004B73 RID: 19315
			// (get) Token: 0x06020282 RID: 131714 RVA: 0x000B4D68 File Offset: 0x000B2F68
			[Token(Token = "0x17004B73")]
			public override int count
			{
				[Token(Token = "0x6020282")]
				[Address(RVA = "0x1A30EC0", Offset = "0x1A2FAC0", VA = "0x181A30EC0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06020283 RID: 131715 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020283")]
			[Address(RVA = "0x1A30C40", Offset = "0x1A2F840", VA = "0x181A30C40", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402B705 RID: 177925
			[Token(Token = "0x402B705")]
			[FieldOffset(Offset = "0x20")]
			private RL05ClassicEndingStatsCopperView m_closure;

			// Token: 0x0402B706 RID: 177926
			[Token(Token = "0x402B706")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402B707 RID: 177927
			[Token(Token = "0x402B707")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402B708 RID: 177928
			[Token(Token = "0x402B708")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
