using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act45Side
{
	// Token: 0x020072B8 RID: 29368
	[Token(Token = "0x20072B8")]
	public class Act45SideEntryLivePagePlugin : TemplateActivityCommonPlugin, IHotfixable
	{
		// Token: 0x0602991E RID: 170270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602991E")]
		[Address(RVA = "0x24F3200", Offset = "0x24F1E00", VA = "0x1824F3200", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x0602991F RID: 170271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602991F")]
		[Address(RVA = "0x24F3030", Offset = "0x24F1C30", VA = "0x1824F3030")]
		public void EventOnLivePageBtnClicked()
		{
		}

		// Token: 0x06029920 RID: 170272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029920")]
		[Address(RVA = "0x24F33F0", Offset = "0x24F1FF0", VA = "0x1824F33F0")]
		public Act45SideEntryLivePagePlugin()
		{
		}

		// Token: 0x0403B707 RID: 243463
		[Token(Token = "0x403B707")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0403B708 RID: 243464
		[Token(Token = "0x403B708")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelUnlock;

		// Token: 0x0403B709 RID: 243465
		[Token(Token = "0x403B709")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelClosed;

		// Token: 0x0403B70A RID: 243466
		[Token(Token = "0x403B70A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textUnlockDesc;

		// Token: 0x0403B70B RID: 243467
		[Token(Token = "0x403B70B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _mailTimeText;

		// Token: 0x0403B70C RID: 243468
		[Token(Token = "0x403B70C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TwoStateToggle _mailToggle;

		// Token: 0x0403B70D RID: 243469
		[Token(Token = "0x403B70D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TwoStateToggle _newCharToggle;

		// Token: 0x0403B70E RID: 243470
		[Token(Token = "0x403B70E")]
		[FieldOffset(Offset = "0x60")]
		private string m_cachedActId;

		// Token: 0x0403B70F RID: 243471
		[Token(Token = "0x403B70F")]
		[FieldOffset(Offset = "0x68")]
		private string m_cachedLockToast;

		// Token: 0x0403B710 RID: 243472
		[Token(Token = "0x403B710")]
		[FieldOffset(Offset = "0x70")]
		private Act45SideEntryLivePageViewModel.Status m_cachedStatus;

		// Token: 0x0403B711 RID: 243473
		[Token(Token = "0x403B711")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403B712 RID: 243474
		[Token(Token = "0x403B712")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnLivePageBtnClicked;

		// Token: 0x0403B713 RID: 243475
		[Token(Token = "0x403B713")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
