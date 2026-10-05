using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CCF RID: 27855
	[Token(Token = "0x2006CCF")]
	public class TemplateActivityMissionView : MonoBehaviour, IBaseActViewBinder, IHotfixable
	{
		// Token: 0x06027BC6 RID: 162758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BC6")]
		[Address(RVA = "0x22E79D0", Offset = "0x22E65D0", VA = "0x1822E79D0", Slot = "4")]
		public void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x06027BC7 RID: 162759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BC7")]
		[Address(RVA = "0x22E7B80", Offset = "0x22E6780", VA = "0x1822E7B80")]
		public TemplateActivityMissionView()
		{
		}

		// Token: 0x0403859B RID: 230811
		[Token(Token = "0x403859B")]
		private const string FORMAT_PROGRESS_COUNT = "{0}/{1}";

		// Token: 0x0403859C RID: 230812
		[Token(Token = "0x403859C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _txtProgressCount;

		// Token: 0x0403859D RID: 230813
		[Token(Token = "0x403859D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _claimAllStateToggle;

		// Token: 0x0403859E RID: 230814
		[Token(Token = "0x403859E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403859F RID: 230815
		[Token(Token = "0x403859F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
