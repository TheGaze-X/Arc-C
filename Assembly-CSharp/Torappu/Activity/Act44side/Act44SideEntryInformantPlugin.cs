using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act44side
{
	// Token: 0x020072EA RID: 29418
	[Token(Token = "0x20072EA")]
	public class Act44SideEntryInformantPlugin : TemplateActivityCommonPlugin, IHotfixable
	{
		// Token: 0x06029A0C RID: 170508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A0C")]
		[Address(RVA = "0x24ECA10", Offset = "0x24EB610", VA = "0x1824ECA10", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x06029A0D RID: 170509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A0D")]
		[Address(RVA = "0x24EC8C0", Offset = "0x24EB4C0", VA = "0x1824EC8C0")]
		public void EventOnClicked()
		{
		}

		// Token: 0x06029A0E RID: 170510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A0E")]
		[Address(RVA = "0x24ECC20", Offset = "0x24EB820", VA = "0x1824ECC20")]
		public Act44SideEntryInformantPlugin()
		{
		}

		// Token: 0x0403B8AE RID: 243886
		[Token(Token = "0x403B8AE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textUnlockDesc;

		// Token: 0x0403B8AF RID: 243887
		[Token(Token = "0x403B8AF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0403B8B0 RID: 243888
		[Token(Token = "0x403B8B0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelItemEnough;

		// Token: 0x0403B8B1 RID: 243889
		[Token(Token = "0x403B8B1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelPlaying;

		// Token: 0x0403B8B2 RID: 243890
		[Token(Token = "0x403B8B2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelTimeOut;

		// Token: 0x0403B8B3 RID: 243891
		[Token(Token = "0x403B8B3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelMilestoneTrackPoint;

		// Token: 0x0403B8B4 RID: 243892
		[Token(Token = "0x403B8B4")]
		[FieldOffset(Offset = "0x58")]
		private string m_actId;

		// Token: 0x0403B8B5 RID: 243893
		[Token(Token = "0x403B8B5")]
		[FieldOffset(Offset = "0x60")]
		private string m_toastDesc;

		// Token: 0x0403B8B6 RID: 243894
		[Token(Token = "0x403B8B6")]
		[FieldOffset(Offset = "0x68")]
		private Act44SideEntryInformantViewModel.Status m_cachedCurrStatus;

		// Token: 0x0403B8B7 RID: 243895
		[Token(Token = "0x403B8B7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403B8B8 RID: 243896
		[Token(Token = "0x403B8B8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x0403B8B9 RID: 243897
		[Token(Token = "0x403B8B9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
