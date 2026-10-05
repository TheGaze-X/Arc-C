using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using Torappu.UI.Firework;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act38side
{
	// Token: 0x0200742F RID: 29743
	[Token(Token = "0x200742F")]
	public class Act38sideEntryFireworkPuzzlePlugin : TemplateActivityCommonPlugin, IHotfixable
	{
		// Token: 0x06029FB2 RID: 171954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FB2")]
		[Address(RVA = "0x25827F0", Offset = "0x25813F0", VA = "0x1825827F0", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x06029FB3 RID: 171955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FB3")]
		[Address(RVA = "0x2582540", Offset = "0x2581140", VA = "0x182582540")]
		public void EventOnPuzzleClicked()
		{
		}

		// Token: 0x06029FB4 RID: 171956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FB4")]
		[Address(RVA = "0x25829D0", Offset = "0x25815D0", VA = "0x1825829D0")]
		private void _OnGetInfoProceed(FireworkPuzzleGetInfoResponse response)
		{
		}

		// Token: 0x06029FB5 RID: 171957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FB5")]
		[Address(RVA = "0x2582B30", Offset = "0x2581730", VA = "0x182582B30")]
		public Act38sideEntryFireworkPuzzlePlugin()
		{
		}

		// Token: 0x0403C302 RID: 246530
		[Token(Token = "0x403C302")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0403C303 RID: 246531
		[Token(Token = "0x403C303")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelUnlock;

		// Token: 0x0403C304 RID: 246532
		[Token(Token = "0x403C304")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelClosed;

		// Token: 0x0403C305 RID: 246533
		[Token(Token = "0x403C305")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textUnlockDesc;

		// Token: 0x0403C306 RID: 246534
		[Token(Token = "0x403C306")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelNew;

		// Token: 0x0403C307 RID: 246535
		[Token(Token = "0x403C307")]
		[FieldOffset(Offset = "0x50")]
		private Act38sideEntryFireworkPuzzleViewModel.Status m_cachedCurrStatus;

		// Token: 0x0403C308 RID: 246536
		[Token(Token = "0x403C308")]
		[FieldOffset(Offset = "0x58")]
		private string m_cachedLockedToast;

		// Token: 0x0403C309 RID: 246537
		[Token(Token = "0x403C309")]
		[FieldOffset(Offset = "0x60")]
		private string m_cachedClosedToast;

		// Token: 0x0403C30A RID: 246538
		[Token(Token = "0x403C30A")]
		[FieldOffset(Offset = "0x68")]
		private string m_cachedActId;

		// Token: 0x0403C30B RID: 246539
		[Token(Token = "0x403C30B")]
		[FieldOffset(Offset = "0x70")]
		private string m_cachedCrossDayTrackId;

		// Token: 0x0403C30C RID: 246540
		[Token(Token = "0x403C30C")]
		[FieldOffset(Offset = "0x78")]
		private bool m_hasDailyTrack;

		// Token: 0x0403C30D RID: 246541
		[Token(Token = "0x403C30D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403C30E RID: 246542
		[Token(Token = "0x403C30E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnPuzzleClicked;

		// Token: 0x0403C30F RID: 246543
		[Token(Token = "0x403C30F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnGetInfoProceed;

		// Token: 0x0403C310 RID: 246544
		[Token(Token = "0x403C310")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
