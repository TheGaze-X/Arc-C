using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x0200581A RID: 22554
	[Token(Token = "0x200581A")]
	public class RL03ClassicEndingStatsTotemView : RoguelikeClassicEndingStatsViewComponent<RL03ClassicEndingStatsTotemViewModel>
	{
		// Token: 0x06020F54 RID: 134996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020F54")]
		[Address(RVA = "0x1B46B00", Offset = "0x1B45700", VA = "0x181B46B00", Slot = "5")]
		public override UIRecycleLayoutAdapter.IVirtualView CreateVirtualView(RoguelikeClassicEndingStatsViewComponentBase compPrefab, RoguelikeClassicEndingStatsViewComponentModel model, UIPage page)
		{
			return null;
		}

		// Token: 0x06020F55 RID: 134997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F55")]
		[Address(RVA = "0x1B46C40", Offset = "0x1B45840", VA = "0x181B46C40", Slot = "7")]
		protected override void Render(RL03ClassicEndingStatsTotemViewModel viewModel)
		{
		}

		// Token: 0x06020F56 RID: 134998 RVA: 0x000B7F48 File Offset: 0x000B6148
		[Token(Token = "0x6020F56")]
		[Address(RVA = "0x1B46E70", Offset = "0x1B45A70", VA = "0x181B46E70")]
		private static float _CalcPrefabHeight(RL03ClassicEndingStatsTotemView prefab, RL03ClassicEndingStatsTotemViewModel viewModel)
		{
			return 0f;
		}

		// Token: 0x06020F57 RID: 134999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F57")]
		[Address(RVA = "0x1B46FE0", Offset = "0x1B45BE0", VA = "0x181B46FE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020F58 RID: 135000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F58")]
		[Address(RVA = "0x1B47100", Offset = "0x1B45D00", VA = "0x181B47100")]
		public RL03ClassicEndingStatsTotemView()
		{
		}

		// Token: 0x0402CD05 RID: 183557
		[Token(Token = "0x402CD05")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textTotemNum;

		// Token: 0x0402CD06 RID: 183558
		[Token(Token = "0x402CD06")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _totemLayoutContent;

		// Token: 0x0402CD07 RID: 183559
		[Token(Token = "0x402CD07")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GridLayoutGroup _totemLayout;

		// Token: 0x0402CD08 RID: 183560
		[Token(Token = "0x402CD08")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _minHeight;

		// Token: 0x0402CD09 RID: 183561
		[Token(Token = "0x402CD09")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _totemScale;

		// Token: 0x0402CD0A RID: 183562
		[Token(Token = "0x402CD0A")]
		[FieldOffset(Offset = "0x40")]
		private RL03ClassicEndingStatsTotemView.EndingTotemAdapter m_adapter;

		// Token: 0x0402CD0B RID: 183563
		[Token(Token = "0x402CD0B")]
		[FieldOffset(Offset = "0x48")]
		private RL03ClassicEndingStatsTotemViewModel m_cachedModel;

		// Token: 0x0402CD0C RID: 183564
		[Token(Token = "0x402CD0C")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x0402CD0D RID: 183565
		[Token(Token = "0x402CD0D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateVirtualView;

		// Token: 0x0402CD0E RID: 183566
		[Token(Token = "0x402CD0E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402CD0F RID: 183567
		[Token(Token = "0x402CD0F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CalcPrefabHeight;

		// Token: 0x0402CD10 RID: 183568
		[Token(Token = "0x402CD10")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402CD11 RID: 183569
		[Token(Token = "0x402CD11")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200581B RID: 22555
		[Token(Token = "0x200581B")]
		public class VirtualView : RoguelikeClassicEndingStatsCompVirtualView<RL03ClassicEndingStatsTotemView, RL03ClassicEndingStatsTotemViewModel>
		{
			// Token: 0x06020F59 RID: 135001 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020F59")]
			[Address(RVA = "0x1B5A870", Offset = "0x1B59470", VA = "0x181B5A870")]
			public VirtualView(RoguelikeClassicEndingStatsViewComponentBase prefab, RoguelikeClassicEndingStatsViewComponentModel viewModel, UIPage page)
			{
			}

			// Token: 0x06020F5A RID: 135002 RVA: 0x000B7F60 File Offset: 0x000B6160
			[Token(Token = "0x6020F5A")]
			[Address(RVA = "0x1B59A40", Offset = "0x1B58640", VA = "0x181B59A40", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0402CD12 RID: 183570
			[Token(Token = "0x402CD12")]
			[FieldOffset(Offset = "0x38")]
			private float m_cachedHeight;

			// Token: 0x0402CD13 RID: 183571
			[Token(Token = "0x402CD13")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402CD14 RID: 183572
			[Token(Token = "0x402CD14")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPreferSize;
		}

		// Token: 0x0200581C RID: 22556
		[Token(Token = "0x200581C")]
		private class EndingTotemAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06020F5B RID: 135003 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020F5B")]
			[Address(RVA = "0x1B44DB0", Offset = "0x1B439B0", VA = "0x181B44DB0")]
			public EndingTotemAdapter(RL03ClassicEndingStatsTotemView closure)
			{
			}

			// Token: 0x17004D5C RID: 19804
			// (get) Token: 0x06020F5C RID: 135004 RVA: 0x000B7F78 File Offset: 0x000B6178
			[Token(Token = "0x17004D5C")]
			public override int count
			{
				[Token(Token = "0x6020F5C")]
				[Address(RVA = "0x1B44E30", Offset = "0x1B43A30", VA = "0x181B44E30", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06020F5D RID: 135005 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020F5D")]
			[Address(RVA = "0x1B44BC0", Offset = "0x1B437C0", VA = "0x181B44BC0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402CD15 RID: 183573
			[Token(Token = "0x402CD15")]
			[FieldOffset(Offset = "0x20")]
			private RL03ClassicEndingStatsTotemView m_closure;

			// Token: 0x0402CD16 RID: 183574
			[Token(Token = "0x402CD16")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402CD17 RID: 183575
			[Token(Token = "0x402CD17")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402CD18 RID: 183576
			[Token(Token = "0x402CD18")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
