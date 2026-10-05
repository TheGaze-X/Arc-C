using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200528F RID: 21135
	[Token(Token = "0x200528F")]
	public class RoguelikeClassicEndingMonthEndInfoTaskView : RoguelikeClassicEndingMonthEndInfoBaseView
	{
		// Token: 0x0601F2F8 RID: 127736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2F8")]
		[Address(RVA = "0x18E10E0", Offset = "0x18DFCE0", VA = "0x1818E10E0", Slot = "4")]
		public override void Render(RoguelikeClassicEndingMonthViewModel viewModel)
		{
		}

		// Token: 0x0601F2F9 RID: 127737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2F9")]
		[Address(RVA = "0x18E13A0", Offset = "0x18DFFA0", VA = "0x1818E13A0")]
		public RoguelikeClassicEndingMonthEndInfoTaskView()
		{
		}

		// Token: 0x04029DA0 RID: 171424
		[Token(Token = "0x4029DA0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color _colorBlack;

		// Token: 0x04029DA1 RID: 171425
		[Token(Token = "0x4029DA1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _colorComplete;

		// Token: 0x04029DA2 RID: 171426
		[Token(Token = "0x4029DA2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _themeColor;

		// Token: 0x04029DA3 RID: 171427
		[Token(Token = "0x4029DA3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelUncomplete;

		// Token: 0x04029DA4 RID: 171428
		[Token(Token = "0x4029DA4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelComplete;

		// Token: 0x04029DA5 RID: 171429
		[Token(Token = "0x4029DA5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelInfo;

		// Token: 0x04029DA6 RID: 171430
		[Token(Token = "0x4029DA6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelNoInfo;

		// Token: 0x04029DA7 RID: 171431
		[Token(Token = "0x4029DA7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _taskDesc;

		// Token: 0x04029DA8 RID: 171432
		[Token(Token = "0x4029DA8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _progress;

		// Token: 0x04029DA9 RID: 171433
		[Token(Token = "0x4029DA9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _total;

		// Token: 0x04029DAA RID: 171434
		[Token(Token = "0x4029DAA")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAtlasImage _progressBar;

		// Token: 0x04029DAB RID: 171435
		[Token(Token = "0x4029DAB")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAtlasImage _bkg;

		// Token: 0x04029DAC RID: 171436
		[Token(Token = "0x4029DAC")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Slider _progressSlider;

		// Token: 0x04029DAD RID: 171437
		[Token(Token = "0x4029DAD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04029DAE RID: 171438
		[Token(Token = "0x4029DAE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
