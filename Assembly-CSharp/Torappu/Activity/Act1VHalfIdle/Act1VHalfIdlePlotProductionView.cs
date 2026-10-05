using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007762 RID: 30562
	[Token(Token = "0x2007762")]
	public class Act1VHalfIdlePlotProductionView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602AEC6 RID: 175814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEC6")]
		[Address(RVA = "0x26B4890", Offset = "0x26B3490", VA = "0x1826B4890")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AEC7 RID: 175815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEC7")]
		[Address(RVA = "0x26B4650", Offset = "0x26B3250", VA = "0x1826B4650")]
		public void Render(Act1VHalfidlePlotViewModel viewModel)
		{
		}

		// Token: 0x0602AEC8 RID: 175816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEC8")]
		[Address(RVA = "0x26B49B0", Offset = "0x26B35B0", VA = "0x1826B49B0")]
		public Act1VHalfIdlePlotProductionView()
		{
		}

		// Token: 0x0403DEB8 RID: 253624
		[Token(Token = "0x403DEB8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _emptyObj;

		// Token: 0x0403DEB9 RID: 253625
		[Token(Token = "0x403DEB9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _normalObj;

		// Token: 0x0403DEBA RID: 253626
		[Token(Token = "0x403DEBA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _layoutProduction;

		// Token: 0x0403DEBB RID: 253627
		[Token(Token = "0x403DEBB")]
		[FieldOffset(Offset = "0x30")]
		private string m_cachedPlotId;

		// Token: 0x0403DEBC RID: 253628
		[Token(Token = "0x403DEBC")]
		[FieldOffset(Offset = "0x38")]
		private Act1VHalfIdlePlotProductionView.Adapter m_adapter;

		// Token: 0x0403DEBD RID: 253629
		[Token(Token = "0x403DEBD")]
		[FieldOffset(Offset = "0x40")]
		private bool m_inited;

		// Token: 0x0403DEBE RID: 253630
		[Token(Token = "0x403DEBE")]
		[FieldOffset(Offset = "0x48")]
		private List<Act1VHalfIdlePlotData.ItemDropData> m_cachedItemDropData;

		// Token: 0x0403DEBF RID: 253631
		[Token(Token = "0x403DEBF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403DEC0 RID: 253632
		[Token(Token = "0x403DEC0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403DEC1 RID: 253633
		[Token(Token = "0x403DEC1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007763 RID: 30563
		[Token(Token = "0x2007763")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0602AEC9 RID: 175817 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AEC9")]
			[Address(RVA = "0x26C2070", Offset = "0x26C0C70", VA = "0x1826C2070")]
			public Adapter(Act1VHalfIdlePlotProductionView closure)
			{
			}

			// Token: 0x170064A7 RID: 25767
			// (get) Token: 0x0602AECA RID: 175818 RVA: 0x000DA6B8 File Offset: 0x000D88B8
			[Token(Token = "0x170064A7")]
			public override int count
			{
				[Token(Token = "0x602AECA")]
				[Address(RVA = "0x26C20F0", Offset = "0x26C0CF0", VA = "0x1826C20F0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602AECB RID: 175819 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602AECB")]
			[Address(RVA = "0x26C1C10", Offset = "0x26C0810", VA = "0x1826C1C10", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403DEC2 RID: 253634
			[Token(Token = "0x403DEC2")]
			[FieldOffset(Offset = "0x20")]
			private Act1VHalfIdlePlotProductionView m_closure;

			// Token: 0x0403DEC3 RID: 253635
			[Token(Token = "0x403DEC3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403DEC4 RID: 253636
			[Token(Token = "0x403DEC4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403DEC5 RID: 253637
			[Token(Token = "0x403DEC5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
