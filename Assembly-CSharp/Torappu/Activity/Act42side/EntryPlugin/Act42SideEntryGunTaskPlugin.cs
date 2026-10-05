using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42side.EntryPlugin
{
	// Token: 0x0200732E RID: 29486
	[Token(Token = "0x200732E")]
	public class Act42SideEntryGunTaskPlugin : TemplateActivityCommonPlugin, IHotfixable
	{
		// Token: 0x06029B24 RID: 170788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B24")]
		[Address(RVA = "0x250AA20", Offset = "0x2509620", VA = "0x18250AA20", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x06029B25 RID: 170789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B25")]
		[Address(RVA = "0x250A710", Offset = "0x2509310", VA = "0x18250A710")]
		public void EventOnGunTaskBtnClicked()
		{
		}

		// Token: 0x06029B26 RID: 170790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B26")]
		[Address(RVA = "0x250AC60", Offset = "0x2509860", VA = "0x18250AC60")]
		private void _OpenGunTaskPage()
		{
		}

		// Token: 0x06029B27 RID: 170791 RVA: 0x000D63B0 File Offset: 0x000D45B0
		[Token(Token = "0x6029B27")]
		[Address(RVA = "0x250ABE0", Offset = "0x25097E0", VA = "0x18250ABE0")]
		private bool _CheckCanGetTrustToken()
		{
			return default(bool);
		}

		// Token: 0x06029B28 RID: 170792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B28")]
		[Address(RVA = "0x250ADA0", Offset = "0x25099A0", VA = "0x18250ADA0")]
		public Act42SideEntryGunTaskPlugin()
		{
		}

		// Token: 0x0403BAE8 RID: 244456
		[Token(Token = "0x403BAE8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0403BAE9 RID: 244457
		[Token(Token = "0x403BAE9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelUnlock;

		// Token: 0x0403BAEA RID: 244458
		[Token(Token = "0x403BAEA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelClosed;

		// Token: 0x0403BAEB RID: 244459
		[Token(Token = "0x403BAEB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textUnlockDesc;

		// Token: 0x0403BAEC RID: 244460
		[Token(Token = "0x403BAEC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelNew;

		// Token: 0x0403BAED RID: 244461
		[Token(Token = "0x403BAED")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelTrack;

		// Token: 0x0403BAEE RID: 244462
		[Token(Token = "0x403BAEE")]
		[FieldOffset(Offset = "0x58")]
		private string m_cachedActId;

		// Token: 0x0403BAEF RID: 244463
		[Token(Token = "0x403BAEF")]
		[FieldOffset(Offset = "0x60")]
		private string m_cachedLockToast;

		// Token: 0x0403BAF0 RID: 244464
		[Token(Token = "0x403BAF0")]
		[FieldOffset(Offset = "0x68")]
		private Act42SideEntryGunTaskViewModel.Status m_cachedStatus;

		// Token: 0x0403BAF1 RID: 244465
		[Token(Token = "0x403BAF1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403BAF2 RID: 244466
		[Token(Token = "0x403BAF2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnGunTaskBtnClicked;

		// Token: 0x0403BAF3 RID: 244467
		[Token(Token = "0x403BAF3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OpenGunTaskPage;

		// Token: 0x0403BAF4 RID: 244468
		[Token(Token = "0x403BAF4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckCanGetTrustToken;

		// Token: 0x0403BAF5 RID: 244469
		[Token(Token = "0x403BAF5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
