using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005738 RID: 22328
	[Token(Token = "0x2005738")]
	public class RL02ClassicEndingStatsMutationAndVirtueView : RoguelikeClassicEndingStatsViewComponent<RL02ClassicEndingStatsMutationAndVirtueViewModel>
	{
		// Token: 0x06020B8F RID: 134031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B8F")]
		[Address(RVA = "0x1B069F0", Offset = "0x1B055F0", VA = "0x181B069F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020B90 RID: 134032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020B90")]
		[Address(RVA = "0x1B06530", Offset = "0x1B05130", VA = "0x181B06530", Slot = "5")]
		public override UIRecycleLayoutAdapter.IVirtualView CreateVirtualView(RoguelikeClassicEndingStatsViewComponentBase compPrefab, RoguelikeClassicEndingStatsViewComponentModel model, UIPage page)
		{
			return null;
		}

		// Token: 0x06020B91 RID: 134033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B91")]
		[Address(RVA = "0x1B06670", Offset = "0x1B05270", VA = "0x181B06670", Slot = "7")]
		protected override void Render(RL02ClassicEndingStatsMutationAndVirtueViewModel viewModel)
		{
		}

		// Token: 0x06020B92 RID: 134034 RVA: 0x000B6F70 File Offset: 0x000B5170
		[Token(Token = "0x6020B92")]
		[Address(RVA = "0x1B06890", Offset = "0x1B05490", VA = "0x181B06890")]
		private static float _CalcPrefabHeight(RL02ClassicEndingStatsMutationAndVirtueView prefab, RL02ClassicEndingStatsMutationAndVirtueViewModel viewModel)
		{
			return 0f;
		}

		// Token: 0x06020B93 RID: 134035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B93")]
		[Address(RVA = "0x1B06B10", Offset = "0x1B05710", VA = "0x181B06B10")]
		public RL02ClassicEndingStatsMutationAndVirtueView()
		{
		}

		// Token: 0x0402C6B6 RID: 181942
		[Token(Token = "0x402C6B6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textNum;

		// Token: 0x0402C6B7 RID: 181943
		[Token(Token = "0x402C6B7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _buffLayoutContent;

		// Token: 0x0402C6B8 RID: 181944
		[Token(Token = "0x402C6B8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GridLayoutGroup _buffLayout;

		// Token: 0x0402C6B9 RID: 181945
		[Token(Token = "0x402C6B9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _minHeight;

		// Token: 0x0402C6BA RID: 181946
		[Token(Token = "0x402C6BA")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_isInited;

		// Token: 0x0402C6BB RID: 181947
		[Token(Token = "0x402C6BB")]
		[FieldOffset(Offset = "0x40")]
		private RL02ClassicEndingStatsMutationAndVirtueViewModel m_cachedModel;

		// Token: 0x0402C6BC RID: 181948
		[Token(Token = "0x402C6BC")]
		[FieldOffset(Offset = "0x48")]
		private RL02ClassicEndingStatsMutationAndVirtueView.Adapter m_adapter;

		// Token: 0x0402C6BD RID: 181949
		[Token(Token = "0x402C6BD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402C6BE RID: 181950
		[Token(Token = "0x402C6BE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreateVirtualView;

		// Token: 0x0402C6BF RID: 181951
		[Token(Token = "0x402C6BF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C6C0 RID: 181952
		[Token(Token = "0x402C6C0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CalcPrefabHeight;

		// Token: 0x0402C6C1 RID: 181953
		[Token(Token = "0x402C6C1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005739 RID: 22329
		[Token(Token = "0x2005739")]
		public class VirtualView : RoguelikeClassicEndingStatsCompVirtualView<RL02ClassicEndingStatsMutationAndVirtueView, RL02ClassicEndingStatsMutationAndVirtueViewModel>
		{
			// Token: 0x06020B94 RID: 134036 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020B94")]
			[Address(RVA = "0x1B17CD0", Offset = "0x1B168D0", VA = "0x181B17CD0")]
			public VirtualView(RoguelikeClassicEndingStatsViewComponentBase prefab, RoguelikeClassicEndingStatsViewComponentModel viewModel, UIPage page)
			{
			}

			// Token: 0x06020B95 RID: 134037 RVA: 0x000B6F88 File Offset: 0x000B5188
			[Token(Token = "0x6020B95")]
			[Address(RVA = "0x1B17AE0", Offset = "0x1B166E0", VA = "0x181B17AE0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0402C6C2 RID: 181954
			[Token(Token = "0x402C6C2")]
			[FieldOffset(Offset = "0x38")]
			private float m_cachedHeight;

			// Token: 0x0402C6C3 RID: 181955
			[Token(Token = "0x402C6C3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402C6C4 RID: 181956
			[Token(Token = "0x402C6C4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPreferSize;
		}

		// Token: 0x0200573A RID: 22330
		[Token(Token = "0x200573A")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06020B96 RID: 134038 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020B96")]
			[Address(RVA = "0x1B03D10", Offset = "0x1B02910", VA = "0x181B03D10")]
			public Adapter(RL02ClassicEndingStatsMutationAndVirtueView closure)
			{
			}

			// Token: 0x17004CB8 RID: 19640
			// (get) Token: 0x06020B97 RID: 134039 RVA: 0x000B6FA0 File Offset: 0x000B51A0
			[Token(Token = "0x17004CB8")]
			public override int count
			{
				[Token(Token = "0x6020B97")]
				[Address(RVA = "0x1B03E10", Offset = "0x1B02A10", VA = "0x181B03E10", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06020B98 RID: 134040 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020B98")]
			[Address(RVA = "0x1B03900", Offset = "0x1B02500", VA = "0x181B03900", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402C6C5 RID: 181957
			[Token(Token = "0x402C6C5")]
			[FieldOffset(Offset = "0x20")]
			private RL02ClassicEndingStatsMutationAndVirtueView m_closure;

			// Token: 0x0402C6C6 RID: 181958
			[Token(Token = "0x402C6C6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402C6C7 RID: 181959
			[Token(Token = "0x402C6C7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402C6C8 RID: 181960
			[Token(Token = "0x402C6C8")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
