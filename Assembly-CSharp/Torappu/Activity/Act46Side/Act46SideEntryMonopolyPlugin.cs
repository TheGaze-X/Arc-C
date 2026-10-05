using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act46Side
{
	// Token: 0x020072A1 RID: 29345
	[Token(Token = "0x20072A1")]
	public class Act46SideEntryMonopolyPlugin : TemplateActivityCommonPlugin
	{
		// Token: 0x060298D2 RID: 170194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298D2")]
		[Address(RVA = "0x24FDF50", Offset = "0x24FCB50", VA = "0x1824FDF50", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x060298D3 RID: 170195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298D3")]
		[Address(RVA = "0x24FDD90", Offset = "0x24FC990", VA = "0x1824FDD90")]
		public void EventOnClick()
		{
		}

		// Token: 0x060298D4 RID: 170196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298D4")]
		[Address(RVA = "0x24FE110", Offset = "0x24FCD10", VA = "0x1824FE110")]
		public Act46SideEntryMonopolyPlugin()
		{
		}

		// Token: 0x0403B663 RID: 243299
		[Token(Token = "0x403B663")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelLock;

		// Token: 0x0403B664 RID: 243300
		[Token(Token = "0x403B664")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelNormal;

		// Token: 0x0403B665 RID: 243301
		[Token(Token = "0x403B665")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelEnd;

		// Token: 0x0403B666 RID: 243302
		[Token(Token = "0x403B666")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _newTrackPoint;

		// Token: 0x0403B667 RID: 243303
		[Token(Token = "0x403B667")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _lockedDesc;

		// Token: 0x0403B668 RID: 243304
		[Token(Token = "0x403B668")]
		[FieldOffset(Offset = "0x50")]
		private string m_actId;

		// Token: 0x0403B669 RID: 243305
		[Token(Token = "0x403B669")]
		[FieldOffset(Offset = "0x58")]
		private string m_lockToast;

		// Token: 0x0403B66A RID: 243306
		[Token(Token = "0x403B66A")]
		[FieldOffset(Offset = "0x60")]
		private Act46SideEntryMonopolyViewModel.Status m_status;

		// Token: 0x0403B66B RID: 243307
		[Token(Token = "0x403B66B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403B66C RID: 243308
		[Token(Token = "0x403B66C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0403B66D RID: 243309
		[Token(Token = "0x403B66D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
