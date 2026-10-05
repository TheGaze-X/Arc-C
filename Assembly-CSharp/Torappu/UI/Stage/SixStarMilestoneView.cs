using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006829 RID: 26665
	[Token(Token = "0x2006829")]
	public class SixStarMilestoneView : DataBinder<SixStarMilestoneProperty>, IHotfixable
	{
		// Token: 0x0602631D RID: 156445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602631D")]
		[Address(RVA = "0x213B940", Offset = "0x213A540", VA = "0x18213B940", Slot = "7")]
		public override void OnValueChanged(SixStarMilestoneProperty property)
		{
		}

		// Token: 0x0602631E RID: 156446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602631E")]
		[Address(RVA = "0x213B830", Offset = "0x213A430", VA = "0x18213B830")]
		public void EventOnBackClicked()
		{
		}

		// Token: 0x0602631F RID: 156447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602631F")]
		[Address(RVA = "0x213B8B0", Offset = "0x213A4B0", VA = "0x18213B8B0")]
		public void EventOnClaimAllClicked()
		{
		}

		// Token: 0x06026320 RID: 156448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026320")]
		[Address(RVA = "0x213BA80", Offset = "0x213A680", VA = "0x18213BA80")]
		public SixStarMilestoneView()
		{
		}

		// Token: 0x04035D19 RID: 220441
		[Token(Token = "0x4035D19")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SixStarMilestoneAdapter _adapter;

		// Token: 0x04035D1A RID: 220442
		[Token(Token = "0x4035D1A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textCurrPoint;

		// Token: 0x04035D1B RID: 220443
		[Token(Token = "0x4035D1B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelClaimAll;

		// Token: 0x04035D1C RID: 220444
		[Token(Token = "0x4035D1C")]
		[FieldOffset(Offset = "0x38")]
		private UICompDialogFinder m_finder;

		// Token: 0x04035D1D RID: 220445
		[Token(Token = "0x4035D1D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04035D1E RID: 220446
		[Token(Token = "0x4035D1E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnBackClicked;

		// Token: 0x04035D1F RID: 220447
		[Token(Token = "0x4035D1F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnClaimAllClicked;

		// Token: 0x04035D20 RID: 220448
		[Token(Token = "0x4035D20")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
