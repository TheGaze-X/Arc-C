using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BE5 RID: 19429
	[Token(Token = "0x2004BE5")]
	public class HomeCheckInGridView : DataBinder<HomeCheckInProperty>, IHotfixable
	{
		// Token: 0x0601D334 RID: 119604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D334")]
		[Address(RVA = "0x16C2F00", Offset = "0x16C1B00", VA = "0x1816C2F00", Slot = "7")]
		public override void OnValueChanged(HomeCheckInProperty property)
		{
		}

		// Token: 0x0601D335 RID: 119605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D335")]
		[Address(RVA = "0x16C3170", Offset = "0x16C1D70", VA = "0x1816C3170")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D336 RID: 119606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D336")]
		[Address(RVA = "0x16C3290", Offset = "0x16C1E90", VA = "0x1816C3290")]
		public HomeCheckInGridView()
		{
		}

		// Token: 0x0402657D RID: 157053
		[Token(Token = "0x402657D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0402657E RID: 157054
		[Token(Token = "0x402657E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x0402657F RID: 157055
		[Token(Token = "0x402657F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04026580 RID: 157056
		[Token(Token = "0x4026580")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x04026581 RID: 157057
		[Token(Token = "0x4026581")]
		[FieldOffset(Offset = "0x40")]
		private HomeCheckInGridView.Adapter m_adapter;

		// Token: 0x04026582 RID: 157058
		[Token(Token = "0x4026582")]
		[FieldOffset(Offset = "0x48")]
		private List<MonthlySignInData> m_cachedItemList;

		// Token: 0x04026583 RID: 157059
		[Token(Token = "0x4026583")]
		[FieldOffset(Offset = "0x50")]
		private int m_cachedCurrCheckInIndex;

		// Token: 0x04026584 RID: 157060
		[Token(Token = "0x4026584")]
		[FieldOffset(Offset = "0x54")]
		private bool m_cachedCanCheckIn;

		// Token: 0x04026585 RID: 157061
		[Token(Token = "0x4026585")]
		[FieldOffset(Offset = "0x55")]
		private bool m_cachedIsJustCheckIn;

		// Token: 0x04026586 RID: 157062
		[Token(Token = "0x4026586")]
		[FieldOffset(Offset = "0x58")]
		private int m_cachedFocusIndex;

		// Token: 0x04026587 RID: 157063
		[Token(Token = "0x4026587")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04026588 RID: 157064
		[Token(Token = "0x4026588")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04026589 RID: 157065
		[Token(Token = "0x4026589")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004BE6 RID: 19430
		[Token(Token = "0x2004BE6")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x0601D337 RID: 119607 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D337")]
			[Address(RVA = "0x16B7220", Offset = "0x16B5E20", VA = "0x1816B7220")]
			public Adapter(HomeCheckInGridView closure)
			{
			}

			// Token: 0x170044AD RID: 17581
			// (get) Token: 0x0601D338 RID: 119608 RVA: 0x000AADD8 File Offset: 0x000A8FD8
			[Token(Token = "0x170044AD")]
			public override int count
			{
				[Token(Token = "0x601D338")]
				[Address(RVA = "0x16B73A0", Offset = "0x16B5FA0", VA = "0x1816B73A0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601D339 RID: 119609 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D339")]
			[Address(RVA = "0x16B60C0", Offset = "0x16B4CC0", VA = "0x1816B60C0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402658A RID: 157066
			[Token(Token = "0x402658A")]
			[FieldOffset(Offset = "0x20")]
			private HomeCheckInGridView m_closure;

			// Token: 0x0402658B RID: 157067
			[Token(Token = "0x402658B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402658C RID: 157068
			[Token(Token = "0x402658C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402658D RID: 157069
			[Token(Token = "0x402658D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
