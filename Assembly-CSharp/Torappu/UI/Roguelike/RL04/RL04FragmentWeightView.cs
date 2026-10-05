using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.Roguelike.Fragment;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056DE RID: 22238
	[Token(Token = "0x20056DE")]
	public class RL04FragmentWeightView : DataBinder<RL04FragmentProperty>, IHotfixable
	{
		// Token: 0x17004C72 RID: 19570
		// (get) Token: 0x060209CF RID: 133583 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060209D0 RID: 133584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C72")]
		public Action<int> onCharCardClicked
		{
			[Token(Token = "0x60209CF")]
			[Address(RVA = "0x1AC1000", Offset = "0x1ABFC00", VA = "0x181AC1000")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60209D0")]
			[Address(RVA = "0x1AC1060", Offset = "0x1ABFC60", VA = "0x181AC1060")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060209D1 RID: 133585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209D1")]
		[Address(RVA = "0x1AC0890", Offset = "0x1ABF490", VA = "0x181AC0890", Slot = "7")]
		public override void OnValueChanged(RL04FragmentProperty property)
		{
		}

		// Token: 0x060209D2 RID: 133586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209D2")]
		[Address(RVA = "0x1AC0E50", Offset = "0x1ABFA50", VA = "0x181AC0E50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060209D3 RID: 133587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209D3")]
		[Address(RVA = "0x1AC0F90", Offset = "0x1ABFB90", VA = "0x181AC0F90")]
		public RL04FragmentWeightView()
		{
		}

		// Token: 0x0402C387 RID: 181127
		[Token(Token = "0x402C387")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LayoutElement _elementLimitWeight;

		// Token: 0x0402C388 RID: 181128
		[Token(Token = "0x402C388")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textLimitWeight;

		// Token: 0x0402C389 RID: 181129
		[Token(Token = "0x402C389")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LayoutElement _elementOverWeight;

		// Token: 0x0402C38A RID: 181130
		[Token(Token = "0x402C38A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textOverWeight;

		// Token: 0x0402C38B RID: 181131
		[Token(Token = "0x402C38B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Slider _sliderWeight;

		// Token: 0x0402C38C RID: 181132
		[Token(Token = "0x402C38C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text[] _textCurrWeight;

		// Token: 0x0402C38D RID: 181133
		[Token(Token = "0x402C38D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject[] _panelNormal;

		// Token: 0x0402C38E RID: 181134
		[Token(Token = "0x402C38E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject[] _panelLimitWeight;

		// Token: 0x0402C38F RID: 181135
		[Token(Token = "0x402C38F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject[] _panelOverWeight;

		// Token: 0x0402C390 RID: 181136
		[Token(Token = "0x402C390")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject[] _panelLimitOrOverWeight;

		// Token: 0x0402C391 RID: 181137
		[Token(Token = "0x402C391")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textWeightDesc;

		// Token: 0x0402C392 RID: 181138
		[Token(Token = "0x402C392")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _betterTips;

		// Token: 0x0402C393 RID: 181139
		[Token(Token = "0x402C393")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0402C395 RID: 181141
		[Token(Token = "0x402C395")]
		[FieldOffset(Offset = "0x90")]
		private RL04FragmentWeightView.Adapter m_adapter;

		// Token: 0x0402C396 RID: 181142
		[Token(Token = "0x402C396")]
		[FieldOffset(Offset = "0x98")]
		private bool m_hasInited;

		// Token: 0x0402C397 RID: 181143
		[Token(Token = "0x402C397")]
		[FieldOffset(Offset = "0xA0")]
		private List<RL04FragmentCharCardViewModel> m_cachedCharCardList;

		// Token: 0x0402C398 RID: 181144
		[Token(Token = "0x402C398")]
		[FieldOffset(Offset = "0xA8")]
		private RoguelikeFragmentDialogMode m_cachedMode;

		// Token: 0x0402C399 RID: 181145
		[Token(Token = "0x402C399")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onCharCardClicked;

		// Token: 0x0402C39A RID: 181146
		[Token(Token = "0x402C39A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onCharCardClicked;

		// Token: 0x0402C39B RID: 181147
		[Token(Token = "0x402C39B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402C39C RID: 181148
		[Token(Token = "0x402C39C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402C39D RID: 181149
		[Token(Token = "0x402C39D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020056DF RID: 22239
		[Token(Token = "0x20056DF")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x060209D4 RID: 133588 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60209D4")]
			[Address(RVA = "0x1ABA400", Offset = "0x1AB9000", VA = "0x181ABA400")]
			public Adapter(RL04FragmentWeightView closure)
			{
			}

			// Token: 0x17004C73 RID: 19571
			// (get) Token: 0x060209D5 RID: 133589 RVA: 0x000B6820 File Offset: 0x000B4A20
			[Token(Token = "0x17004C73")]
			public override int count
			{
				[Token(Token = "0x60209D5")]
				[Address(RVA = "0x1ABA500", Offset = "0x1AB9100", VA = "0x181ABA500", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060209D6 RID: 133590 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60209D6")]
			[Address(RVA = "0x1AB9EB0", Offset = "0x1AB8AB0", VA = "0x181AB9EB0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402C39E RID: 181150
			[Token(Token = "0x402C39E")]
			[FieldOffset(Offset = "0x20")]
			private RL04FragmentWeightView m_closure;

			// Token: 0x0402C39F RID: 181151
			[Token(Token = "0x402C39F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402C3A0 RID: 181152
			[Token(Token = "0x402C3A0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402C3A1 RID: 181153
			[Token(Token = "0x402C3A1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
