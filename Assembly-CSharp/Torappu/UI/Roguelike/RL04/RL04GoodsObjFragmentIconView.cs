using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005711 RID: 22289
	[Token(Token = "0x2005711")]
	public class RL04GoodsObjFragmentIconView : RoguelikeGoodsObjIconView
	{
		// Token: 0x06020ACE RID: 133838 RVA: 0x000B6C88 File Offset: 0x000B4E88
		[Token(Token = "0x6020ACE")]
		[Address(RVA = "0x1B12A60", Offset = "0x1B11660", VA = "0x181B12A60", Slot = "5")]
		public override bool NeedShowPlugin(RoguelikeGoodsViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x06020ACF RID: 133839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020ACF")]
		[Address(RVA = "0x1B12AE0", Offset = "0x1B116E0", VA = "0x181B12AE0", Slot = "6")]
		public override void Render(RoguelikeGoodsViewModel viewModel)
		{
		}

		// Token: 0x06020AD0 RID: 133840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020AD0")]
		[Address(RVA = "0x1B13100", Offset = "0x1B11D00", VA = "0x181B13100")]
		private void _RenderAsBuy(RoguelikeFragmentData fragmentData)
		{
		}

		// Token: 0x06020AD1 RID: 133841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020AD1")]
		[Address(RVA = "0x1B131E0", Offset = "0x1B11DE0", VA = "0x181B131E0")]
		private void _RenderAsSell(RoguelikeGoodsViewModel viewModel)
		{
		}

		// Token: 0x06020AD2 RID: 133842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020AD2")]
		[Address(RVA = "0x1B13320", Offset = "0x1B11F20", VA = "0x181B13320")]
		private void _UpdateValue(int value)
		{
		}

		// Token: 0x06020AD3 RID: 133843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020AD3")]
		[Address(RVA = "0x1B12FE0", Offset = "0x1B11BE0", VA = "0x181B12FE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020AD4 RID: 133844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020AD4")]
		[Address(RVA = "0x1B133C0", Offset = "0x1B11FC0", VA = "0x181B133C0")]
		public RL04GoodsObjFragmentIconView()
		{
		}

		// Token: 0x0402C57E RID: 181630
		[Token(Token = "0x402C57E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _iconImage;

		// Token: 0x0402C57F RID: 181631
		[Token(Token = "0x402C57F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _weightText;

		// Token: 0x0402C580 RID: 181632
		[Token(Token = "0x402C580")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _valueContent;

		// Token: 0x0402C581 RID: 181633
		[Token(Token = "0x402C581")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<RL04GoodsObjFragmentIconView.FragmentTypePanel> _typePanels;

		// Token: 0x0402C582 RID: 181634
		[Token(Token = "0x402C582")]
		[FieldOffset(Offset = "0x38")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402C583 RID: 181635
		[Token(Token = "0x402C583")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x0402C584 RID: 181636
		[Token(Token = "0x402C584")]
		[FieldOffset(Offset = "0x50")]
		private RL04GoodsObjFragmentIconView.Adapter m_adapter;

		// Token: 0x0402C585 RID: 181637
		[Token(Token = "0x402C585")]
		[FieldOffset(Offset = "0x58")]
		private int m_cachedValue;

		// Token: 0x0402C586 RID: 181638
		[Token(Token = "0x402C586")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_NeedShowPlugin;

		// Token: 0x0402C587 RID: 181639
		[Token(Token = "0x402C587")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C588 RID: 181640
		[Token(Token = "0x402C588")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderAsBuy;

		// Token: 0x0402C589 RID: 181641
		[Token(Token = "0x402C589")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderAsSell;

		// Token: 0x0402C58A RID: 181642
		[Token(Token = "0x402C58A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateValue;

		// Token: 0x0402C58B RID: 181643
		[Token(Token = "0x402C58B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402C58C RID: 181644
		[Token(Token = "0x402C58C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005712 RID: 22290
		[Token(Token = "0x2005712")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06020AD5 RID: 133845 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020AD5")]
			[Address(RVA = "0x1B03D90", Offset = "0x1B02990", VA = "0x181B03D90")]
			public Adapter(RL04GoodsObjFragmentIconView closure)
			{
			}

			// Token: 0x17004CA1 RID: 19617
			// (get) Token: 0x06020AD6 RID: 133846 RVA: 0x000B6CA0 File Offset: 0x000B4EA0
			[Token(Token = "0x17004CA1")]
			public override int count
			{
				[Token(Token = "0x6020AD6")]
				[Address(RVA = "0x1B03FB0", Offset = "0x1B02BB0", VA = "0x181B03FB0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06020AD7 RID: 133847 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020AD7")]
			[Address(RVA = "0x1B03800", Offset = "0x1B02400", VA = "0x181B03800", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402C58D RID: 181645
			[Token(Token = "0x402C58D")]
			[FieldOffset(Offset = "0x20")]
			private RL04GoodsObjFragmentIconView m_closure;

			// Token: 0x0402C58E RID: 181646
			[Token(Token = "0x402C58E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402C58F RID: 181647
			[Token(Token = "0x402C58F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402C590 RID: 181648
			[Token(Token = "0x402C590")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02005713 RID: 22291
		[Token(Token = "0x2005713")]
		[Serializable]
		private struct FragmentTypePanel
		{
			// Token: 0x0402C591 RID: 181649
			[Token(Token = "0x402C591")]
			[FieldOffset(Offset = "0x0")]
			public RoguelikeFragmentType type;

			// Token: 0x0402C592 RID: 181650
			[Token(Token = "0x402C592")]
			[FieldOffset(Offset = "0x8")]
			public GameObject panel;
		}
	}
}
