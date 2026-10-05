using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005694 RID: 22164
	[Token(Token = "0x2005694")]
	public class RL04ClassicEndingStatsFragmentView : RoguelikeClassicEndingStatsViewComponent<RL04ClassicEndingStatsFragmentViewModel>
	{
		// Token: 0x06020836 RID: 133174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020836")]
		[Address(RVA = "0x1AA5620", Offset = "0x1AA4220", VA = "0x181AA5620", Slot = "5")]
		public override UIRecycleLayoutAdapter.IVirtualView CreateVirtualView(RoguelikeClassicEndingStatsViewComponentBase compPrefab, RoguelikeClassicEndingStatsViewComponentModel viewModel, UIPage page)
		{
			return null;
		}

		// Token: 0x06020837 RID: 133175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020837")]
		[Address(RVA = "0x1AA5760", Offset = "0x1AA4360", VA = "0x181AA5760", Slot = "7")]
		protected override void Render(RL04ClassicEndingStatsFragmentViewModel viewModel)
		{
		}

		// Token: 0x06020838 RID: 133176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020838")]
		[Address(RVA = "0x1AA5AE0", Offset = "0x1AA46E0", VA = "0x181AA5AE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020839 RID: 133177 RVA: 0x000B63D0 File Offset: 0x000B45D0
		[Token(Token = "0x6020839")]
		[Address(RVA = "0x1AA5970", Offset = "0x1AA4570", VA = "0x181AA5970")]
		private static float _CalcPrefabHeight(RL04ClassicEndingStatsFragmentView prefab, RL04ClassicEndingStatsFragmentViewModel viewModel)
		{
			return 0f;
		}

		// Token: 0x0602083A RID: 133178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602083A")]
		[Address(RVA = "0x1AA5C00", Offset = "0x1AA4800", VA = "0x181AA5C00")]
		public RL04ClassicEndingStatsFragmentView()
		{
		}

		// Token: 0x0402C0F3 RID: 180467
		[Token(Token = "0x402C0F3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GridLayoutGroup _layoutGroup;

		// Token: 0x0402C0F4 RID: 180468
		[Token(Token = "0x402C0F4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0402C0F5 RID: 180469
		[Token(Token = "0x402C0F5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _fragmentCntTxt;

		// Token: 0x0402C0F6 RID: 180470
		[Token(Token = "0x402C0F6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _minHeight;

		// Token: 0x0402C0F7 RID: 180471
		[Token(Token = "0x402C0F7")]
		[FieldOffset(Offset = "0x40")]
		private ListDict<string, RL04ClassicEndingStatsFragmentItemModel> m_cachedFragmentItemModelList;

		// Token: 0x0402C0F8 RID: 180472
		[Token(Token = "0x402C0F8")]
		[FieldOffset(Offset = "0x48")]
		private RL04ClassicEndingStatsFragmentView.EndingFragmentAdapter m_adapter;

		// Token: 0x0402C0F9 RID: 180473
		[Token(Token = "0x402C0F9")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x0402C0FA RID: 180474
		[Token(Token = "0x402C0FA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateVirtualView;

		// Token: 0x0402C0FB RID: 180475
		[Token(Token = "0x402C0FB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C0FC RID: 180476
		[Token(Token = "0x402C0FC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402C0FD RID: 180477
		[Token(Token = "0x402C0FD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CalcPrefabHeight;

		// Token: 0x0402C0FE RID: 180478
		[Token(Token = "0x402C0FE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005695 RID: 22165
		[Token(Token = "0x2005695")]
		public class VirtualView : RoguelikeClassicEndingStatsCompVirtualView<RL04ClassicEndingStatsFragmentView, RL04ClassicEndingStatsFragmentViewModel>
		{
			// Token: 0x0602083B RID: 133179 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602083B")]
			[Address(RVA = "0x1AB9D10", Offset = "0x1AB8910", VA = "0x181AB9D10")]
			public VirtualView(RoguelikeClassicEndingStatsViewComponentBase prefab, RoguelikeClassicEndingStatsViewComponentModel viewModel, UIPage page)
			{
			}

			// Token: 0x0602083C RID: 133180 RVA: 0x000B63E8 File Offset: 0x000B45E8
			[Token(Token = "0x602083C")]
			[Address(RVA = "0x1AB95B0", Offset = "0x1AB81B0", VA = "0x181AB95B0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0402C0FF RID: 180479
			[Token(Token = "0x402C0FF")]
			[FieldOffset(Offset = "0x38")]
			private float m_cachedHeight;

			// Token: 0x0402C100 RID: 180480
			[Token(Token = "0x402C100")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402C101 RID: 180481
			[Token(Token = "0x402C101")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPreferSize;
		}

		// Token: 0x02005696 RID: 22166
		[Token(Token = "0x2005696")]
		private class EndingFragmentAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602083D RID: 133181 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602083D")]
			[Address(RVA = "0x1AA3C40", Offset = "0x1AA2840", VA = "0x181AA3C40")]
			public EndingFragmentAdapter(RL04ClassicEndingStatsFragmentView closure)
			{
			}

			// Token: 0x17004C2E RID: 19502
			// (get) Token: 0x0602083E RID: 133182 RVA: 0x000B6400 File Offset: 0x000B4600
			[Token(Token = "0x17004C2E")]
			public override int count
			{
				[Token(Token = "0x602083E")]
				[Address(RVA = "0x1AA3CC0", Offset = "0x1AA28C0", VA = "0x181AA3CC0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602083F RID: 133183 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602083F")]
			[Address(RVA = "0x1AA39A0", Offset = "0x1AA25A0", VA = "0x181AA39A0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402C102 RID: 180482
			[Token(Token = "0x402C102")]
			[FieldOffset(Offset = "0x20")]
			private RL04ClassicEndingStatsFragmentView m_closure;

			// Token: 0x0402C103 RID: 180483
			[Token(Token = "0x402C103")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402C104 RID: 180484
			[Token(Token = "0x402C104")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402C105 RID: 180485
			[Token(Token = "0x402C105")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
