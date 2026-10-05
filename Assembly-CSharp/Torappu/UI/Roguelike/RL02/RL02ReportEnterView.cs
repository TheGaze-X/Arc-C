using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x0200574F RID: 22351
	[Token(Token = "0x200574F")]
	public class RL02ReportEnterView : RL02CommonReportView<RL02EndingFrameEnterReportViewModel>
	{
		// Token: 0x06020BFF RID: 134143 RVA: 0x000B7078 File Offset: 0x000B5278
		[Token(Token = "0x6020BFF")]
		[Address(RVA = "0x1B0AB40", Offset = "0x1B09740", VA = "0x181B0AB40", Slot = "4")]
		public override RL02ReportController.ReportViewType GetViewType()
		{
			return RL02ReportController.ReportViewType.NONE;
		}

		// Token: 0x06020C00 RID: 134144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020C00")]
		[Address(RVA = "0x1B0AAD0", Offset = "0x1B096D0", VA = "0x181B0AAD0", Slot = "7")]
		protected override string GetShowAnimName()
		{
			return null;
		}

		// Token: 0x06020C01 RID: 134145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C01")]
		[Address(RVA = "0x1B0ABA0", Offset = "0x1B097A0", VA = "0x181B0ABA0", Slot = "8")]
		protected override void Render(RL02EndingFrameEnterReportViewModel viewModel)
		{
		}

		// Token: 0x06020C02 RID: 134146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C02")]
		[Address(RVA = "0x1B0ACE0", Offset = "0x1B098E0", VA = "0x181B0ACE0")]
		public RL02ReportEnterView()
		{
		}

		// Token: 0x0402C761 RID: 182113
		[Token(Token = "0x402C761")]
		private const string ENTER_ANIM_NAME = "report_enter";

		// Token: 0x0402C762 RID: 182114
		[Token(Token = "0x402C762")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _txtName;

		// Token: 0x0402C763 RID: 182115
		[Token(Token = "0x402C763")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _txtEnding;

		// Token: 0x0402C764 RID: 182116
		[Token(Token = "0x402C764")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0402C765 RID: 182117
		[Token(Token = "0x402C765")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetShowAnimName;

		// Token: 0x0402C766 RID: 182118
		[Token(Token = "0x402C766")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C767 RID: 182119
		[Token(Token = "0x402C767")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
