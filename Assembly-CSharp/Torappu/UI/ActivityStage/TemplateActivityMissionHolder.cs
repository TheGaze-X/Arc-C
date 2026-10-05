using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CCA RID: 27850
	[Token(Token = "0x2006CCA")]
	public class TemplateActivityMissionHolder : MonoBehaviour, IBaseActViewBinder, IHotfixable
	{
		// Token: 0x06027BB1 RID: 162737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BB1")]
		[Address(RVA = "0x22E4AD0", Offset = "0x22E36D0", VA = "0x1822E4AD0", Slot = "4")]
		public void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x06027BB2 RID: 162738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BB2")]
		[Address(RVA = "0x22E4BF0", Offset = "0x22E37F0", VA = "0x1822E4BF0")]
		public TemplateActivityMissionHolder()
		{
		}

		// Token: 0x04038565 RID: 230757
		[Token(Token = "0x4038565")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TemplateMissionAdapter _adapter;

		// Token: 0x04038566 RID: 230758
		[Token(Token = "0x4038566")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public UIStringEvent onMissionGetRewardClick;

		// Token: 0x04038567 RID: 230759
		[Token(Token = "0x4038567")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x04038568 RID: 230760
		[Token(Token = "0x4038568")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
