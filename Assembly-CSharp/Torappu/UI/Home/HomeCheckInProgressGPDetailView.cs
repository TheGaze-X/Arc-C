using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BEB RID: 19435
	[Token(Token = "0x2004BEB")]
	public class HomeCheckInProgressGPDetailView : DataBinder<HomeCheckInProperty>, IHotfixable
	{
		// Token: 0x0601D348 RID: 119624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D348")]
		[Address(RVA = "0x16C3D60", Offset = "0x16C2960", VA = "0x1816C3D60", Slot = "7")]
		public override void OnValueChanged(HomeCheckInProperty property)
		{
		}

		// Token: 0x0601D349 RID: 119625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D349")]
		[Address(RVA = "0x16C3CD0", Offset = "0x16C28D0", VA = "0x1816C3CD0")]
		public void OnClick()
		{
		}

		// Token: 0x0601D34A RID: 119626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D34A")]
		[Address(RVA = "0x16C4090", Offset = "0x16C2C90", VA = "0x1816C4090")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D34B RID: 119627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D34B")]
		[Address(RVA = "0x16C4250", Offset = "0x16C2E50", VA = "0x1816C4250")]
		public HomeCheckInProgressGPDetailView()
		{
		}

		// Token: 0x040265B3 RID: 157107
		[Token(Token = "0x40265B3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x040265B4 RID: 157108
		[Token(Token = "0x40265B4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x040265B5 RID: 157109
		[Token(Token = "0x40265B5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textRemainTime;

		// Token: 0x040265B6 RID: 157110
		[Token(Token = "0x40265B6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x040265B7 RID: 157111
		[Token(Token = "0x40265B7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIFadeFloatPanel _floatPanel;

		// Token: 0x040265B8 RID: 157112
		[Token(Token = "0x40265B8")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasInited;

		// Token: 0x040265B9 RID: 157113
		[Token(Token = "0x40265B9")]
		[FieldOffset(Offset = "0x50")]
		private HomeCheckInProgressGPDetailView.Adapter m_adapter;

		// Token: 0x040265BA RID: 157114
		[Token(Token = "0x40265BA")]
		[FieldOffset(Offset = "0x58")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040265BB RID: 157115
		[Token(Token = "0x40265BB")]
		[FieldOffset(Offset = "0x68")]
		private ProgressCheckInViewModel m_cachedModel;

		// Token: 0x040265BC RID: 157116
		[Token(Token = "0x40265BC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040265BD RID: 157117
		[Token(Token = "0x40265BD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x040265BE RID: 157118
		[Token(Token = "0x40265BE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040265BF RID: 157119
		[Token(Token = "0x40265BF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004BEC RID: 19436
		[Token(Token = "0x2004BEC")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x0601D34C RID: 119628 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D34C")]
			[Address(RVA = "0x16B7320", Offset = "0x16B5F20", VA = "0x1816B7320")]
			public Adapter(HomeCheckInProgressGPDetailView closure)
			{
			}

			// Token: 0x170044B0 RID: 17584
			// (get) Token: 0x0601D34D RID: 119629 RVA: 0x000AAE20 File Offset: 0x000A9020
			[Token(Token = "0x170044B0")]
			public override int count
			{
				[Token(Token = "0x601D34D")]
				[Address(RVA = "0x16B7510", Offset = "0x16B6110", VA = "0x1816B7510", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601D34E RID: 119630 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D34E")]
			[Address(RVA = "0x16B6C10", Offset = "0x16B5810", VA = "0x1816B6C10", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040265C0 RID: 157120
			[Token(Token = "0x40265C0")]
			[FieldOffset(Offset = "0x20")]
			private HomeCheckInProgressGPDetailView m_closure;

			// Token: 0x040265C1 RID: 157121
			[Token(Token = "0x40265C1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040265C2 RID: 157122
			[Token(Token = "0x40265C2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040265C3 RID: 157123
			[Token(Token = "0x40265C3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
