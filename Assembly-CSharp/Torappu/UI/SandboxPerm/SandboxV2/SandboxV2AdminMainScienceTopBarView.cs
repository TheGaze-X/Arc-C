using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040D4 RID: 16596
	[Token(Token = "0x20040D4")]
	public class SandboxV2AdminMainScienceTopBarView : DataBinder<SandboxV2AdminMainSciencePanelModelProperty>, IHotfixable
	{
		// Token: 0x06019ACB RID: 105163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019ACB")]
		[Address(RVA = "0x127FEF0", Offset = "0x127EAF0", VA = "0x18127FEF0", Slot = "7")]
		public override void OnValueChanged(SandboxV2AdminMainSciencePanelModelProperty property)
		{
		}

		// Token: 0x06019ACC RID: 105164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019ACC")]
		[Address(RVA = "0x127FF90", Offset = "0x127EB90", VA = "0x18127FF90")]
		private void _RefreshView(SandboxV2AdminMainSciencePanelModel viewModel)
		{
		}

		// Token: 0x06019ACD RID: 105165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019ACD")]
		[Address(RVA = "0x12802B0", Offset = "0x127EEB0", VA = "0x1812802B0")]
		public SandboxV2AdminMainScienceTopBarView()
		{
		}

		// Token: 0x0402019E RID: 131486
		[Token(Token = "0x402019E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _pointsTxt;

		// Token: 0x0402019F RID: 131487
		[Token(Token = "0x402019F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _progressTxt;

		// Token: 0x040201A0 RID: 131488
		[Token(Token = "0x40201A0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _progressTotalTxt;

		// Token: 0x040201A1 RID: 131489
		[Token(Token = "0x40201A1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _typeText;

		// Token: 0x040201A2 RID: 131490
		[Token(Token = "0x40201A2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040201A3 RID: 131491
		[Token(Token = "0x40201A3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RefreshView;

		// Token: 0x040201A4 RID: 131492
		[Token(Token = "0x40201A4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
