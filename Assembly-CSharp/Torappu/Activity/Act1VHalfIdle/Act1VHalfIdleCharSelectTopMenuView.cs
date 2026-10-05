using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.TemplateCharSelect;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007708 RID: 30472
	[Token(Token = "0x2007708")]
	public class Act1VHalfIdleCharSelectTopMenuView : TemplateCharSelectTopMenuView<Act1VHalfIdleCharSelectTopMenuViewModel>
	{
		// Token: 0x0602ACF7 RID: 175351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACF7")]
		[Address(RVA = "0x269AEA0", Offset = "0x2699AA0", VA = "0x18269AEA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602ACF8 RID: 175352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACF8")]
		[Address(RVA = "0x269AC50", Offset = "0x2699850", VA = "0x18269AC50", Slot = "10")]
		protected override void OnRenderViewModel(TemplateCharSelectMainViewModel mainViewModel)
		{
		}

		// Token: 0x0602ACF9 RID: 175353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACF9")]
		[Address(RVA = "0x269AE10", Offset = "0x2699A10", VA = "0x18269AE10")]
		private void _EventOnClickBack()
		{
		}

		// Token: 0x0602ACFA RID: 175354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACFA")]
		[Address(RVA = "0x269B010", Offset = "0x2699C10", VA = "0x18269B010")]
		public Act1VHalfIdleCharSelectTopMenuView()
		{
		}

		// Token: 0x0403DB11 RID: 252689
		[Token(Token = "0x403DB11")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Act1VHalfIdleCommonTopMenu _halfIdleTopMenuAsset;

		// Token: 0x0403DB12 RID: 252690
		[Token(Token = "0x403DB12")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _halfIdleTopMenuRoot;

		// Token: 0x0403DB13 RID: 252691
		[Token(Token = "0x403DB13")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x0403DB14 RID: 252692
		[Token(Token = "0x403DB14")]
		[FieldOffset(Offset = "0x48")]
		private Act1VHalfIdleCommonTopMenu m_halfIdleCommonTopMenu;

		// Token: 0x0403DB15 RID: 252693
		[Token(Token = "0x403DB15")]
		[FieldOffset(Offset = "0x50")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403DB16 RID: 252694
		[Token(Token = "0x403DB16")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403DB17 RID: 252695
		[Token(Token = "0x403DB17")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRenderViewModel;

		// Token: 0x0403DB18 RID: 252696
		[Token(Token = "0x403DB18")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EventOnClickBack;

		// Token: 0x0403DB19 RID: 252697
		[Token(Token = "0x403DB19")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
