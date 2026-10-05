using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMainSS
{
	// Token: 0x020070A6 RID: 28838
	[Token(Token = "0x20070A6")]
	public class ActMainSSEntryZonePlugin : TemplateActivityCommonPlugin, IHotfixable
	{
		// Token: 0x06029003 RID: 167939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029003")]
		[Address(RVA = "0x24717E0", Offset = "0x24703E0", VA = "0x1824717E0", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x06029004 RID: 167940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029004")]
		[Address(RVA = "0x24716A0", Offset = "0x24702A0", VA = "0x1824716A0")]
		public void EventOnClicked()
		{
		}

		// Token: 0x06029005 RID: 167941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029005")]
		[Address(RVA = "0x24719E0", Offset = "0x24705E0", VA = "0x1824719E0")]
		public ActMainSSEntryZonePlugin()
		{
		}

		// Token: 0x0403A855 RID: 239701
		[Token(Token = "0x403A855")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelActive;

		// Token: 0x0403A856 RID: 239702
		[Token(Token = "0x403A856")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelRetro;

		// Token: 0x0403A857 RID: 239703
		[Token(Token = "0x403A857")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelLockedTip;

		// Token: 0x0403A858 RID: 239704
		[Token(Token = "0x403A858")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textPoint;

		// Token: 0x0403A859 RID: 239705
		[Token(Token = "0x403A859")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textLockedTip;

		// Token: 0x0403A85A RID: 239706
		[Token(Token = "0x403A85A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIStringEvent _eventOnJumpToZone;

		// Token: 0x0403A85B RID: 239707
		[Token(Token = "0x403A85B")]
		[FieldOffset(Offset = "0x58")]
		private ActMainSSEntryZoneViewModel m_cachedModel;

		// Token: 0x0403A85C RID: 239708
		[Token(Token = "0x403A85C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403A85D RID: 239709
		[Token(Token = "0x403A85D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x0403A85E RID: 239710
		[Token(Token = "0x403A85E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
