using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.Init.Style
{
	// Token: 0x020057F3 RID: 22515
	[Token(Token = "0x20057F3")]
	public class RoguelikeInitStyleApplier : UIStylerApplier<RoguelikeInitStyle>
	{
		// Token: 0x06020EAC RID: 134828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020EAC")]
		[Address(RVA = "0x1B41DF0", Offset = "0x1B409F0", VA = "0x181B41DF0", Slot = "18")]
		protected override void OnApplyStyle(RoguelikeInitStyle style)
		{
		}

		// Token: 0x06020EAD RID: 134829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020EAD")]
		[Address(RVA = "0x1B42280", Offset = "0x1B40E80", VA = "0x181B42280")]
		public RoguelikeInitStyleApplier()
		{
		}

		// Token: 0x0402CBF2 RID: 183282
		[Token(Token = "0x402CBF2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _bg;

		// Token: 0x0402CBF3 RID: 183283
		[Token(Token = "0x402CBF3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _backColor;

		// Token: 0x0402CBF4 RID: 183284
		[Token(Token = "0x402CBF4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _prgBar;

		// Token: 0x0402CBF5 RID: 183285
		[Token(Token = "0x402CBF5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _stepTitleLabel;

		// Token: 0x0402CBF6 RID: 183286
		[Token(Token = "0x402CBF6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _supportHint;

		// Token: 0x0402CBF7 RID: 183287
		[Token(Token = "0x402CBF7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasImage _checkIcon;

		// Token: 0x0402CBF8 RID: 183288
		[Token(Token = "0x402CBF8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RoguelikeInitRecruitPanel _recruitPanel;

		// Token: 0x0402CBF9 RID: 183289
		[Token(Token = "0x402CBF9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnApplyStyle;

		// Token: 0x0402CBFA RID: 183290
		[Token(Token = "0x402CBFA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
