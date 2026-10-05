using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004205 RID: 16901
	[Token(Token = "0x2004205")]
	public class SandboxV2DungeonLogisticsEffectView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A141 RID: 106817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A141")]
		[Address(RVA = "0x12EB730", Offset = "0x12EA330", VA = "0x1812EB730")]
		public void Render(SandboxV2DungeonMiscLogisticsEffectViewModel viewModel)
		{
		}

		// Token: 0x0601A142 RID: 106818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A142")]
		[Address(RVA = "0x12EBAB0", Offset = "0x12EA6B0", VA = "0x1812EBAB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A143 RID: 106819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A143")]
		[Address(RVA = "0x12EB690", Offset = "0x12EA290", VA = "0x1812EB690")]
		public void OnAddDrinkClick()
		{
		}

		// Token: 0x0601A144 RID: 106820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A144")]
		[Address(RVA = "0x12EBBD0", Offset = "0x12EA7D0", VA = "0x1812EBBD0")]
		public SandboxV2DungeonLogisticsEffectView()
		{
		}

		// Token: 0x04020DBB RID: 134587
		[Token(Token = "0x4020DBB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x04020DBC RID: 134588
		[Token(Token = "0x4020DBC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _title;

		// Token: 0x04020DBD RID: 134589
		[Token(Token = "0x4020DBD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _charCount;

		// Token: 0x04020DBE RID: 134590
		[Token(Token = "0x4020DBE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _drinkCost;

		// Token: 0x04020DBF RID: 134591
		[Token(Token = "0x4020DBF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _drinkObtained;

		// Token: 0x04020DC0 RID: 134592
		[Token(Token = "0x4020DC0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _noDrink;

		// Token: 0x04020DC1 RID: 134593
		[Token(Token = "0x4020DC1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _enoughDrink;

		// Token: 0x04020DC2 RID: 134594
		[Token(Token = "0x4020DC2")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isInited;

		// Token: 0x04020DC3 RID: 134595
		[Token(Token = "0x4020DC3")]
		[FieldOffset(Offset = "0x68")]
		private SandboxV2DungeonLogisticsEffectView.Adapter m_adapter;

		// Token: 0x04020DC4 RID: 134596
		[Token(Token = "0x4020DC4")]
		[FieldOffset(Offset = "0x70")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04020DC5 RID: 134597
		[Token(Token = "0x4020DC5")]
		[FieldOffset(Offset = "0x80")]
		private SandboxV2DungeonMiscLogisticsEffectViewModel m_cachedViewModel;

		// Token: 0x04020DC6 RID: 134598
		[Token(Token = "0x4020DC6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020DC7 RID: 134599
		[Token(Token = "0x4020DC7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020DC8 RID: 134600
		[Token(Token = "0x4020DC8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnAddDrinkClick;

		// Token: 0x04020DC9 RID: 134601
		[Token(Token = "0x4020DC9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004206 RID: 16902
		[Token(Token = "0x2004206")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601A145 RID: 106821 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A145")]
			[Address(RVA = "0x12E6800", Offset = "0x12E5400", VA = "0x1812E6800")]
			public Adapter(SandboxV2DungeonLogisticsEffectView closure)
			{
			}

			// Token: 0x17003E14 RID: 15892
			// (get) Token: 0x0601A146 RID: 106822 RVA: 0x000A03C8 File Offset: 0x0009E5C8
			[Token(Token = "0x17003E14")]
			public override int count
			{
				[Token(Token = "0x601A146")]
				[Address(RVA = "0x12E6910", Offset = "0x12E5510", VA = "0x1812E6910", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601A147 RID: 106823 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A147")]
			[Address(RVA = "0x12E6380", Offset = "0x12E4F80", VA = "0x1812E6380", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04020DCA RID: 134602
			[Token(Token = "0x4020DCA")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2DungeonLogisticsEffectView m_closure;

			// Token: 0x04020DCB RID: 134603
			[Token(Token = "0x4020DCB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04020DCC RID: 134604
			[Token(Token = "0x4020DCC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04020DCD RID: 134605
			[Token(Token = "0x4020DCD")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
