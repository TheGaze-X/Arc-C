using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006C8A RID: 27786
	[Token(Token = "0x2006C8A")]
	public class TemplateActivityEntryZonePlugin : TemplateActivityCommonPlugin
	{
		// Token: 0x06027A4E RID: 162382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A4E")]
		[Address(RVA = "0x22DC7F0", Offset = "0x22DB3F0", VA = "0x1822DC7F0")]
		public void EventOnZoneAllTimeoutClicked()
		{
		}

		// Token: 0x06027A4F RID: 162383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A4F")]
		[Address(RVA = "0x22DC8A0", Offset = "0x22DB4A0", VA = "0x1822DC8A0", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x06027A50 RID: 162384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A50")]
		[Address(RVA = "0x22DCBB0", Offset = "0x22DB7B0", VA = "0x1822DCBB0")]
		public TemplateActivityEntryZonePlugin()
		{
		}

		// Token: 0x040383B3 RID: 230323
		[Token(Token = "0x40383B3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<TemplateActivityEntryZoneButtonView> _buttonView;

		// Token: 0x040383B4 RID: 230324
		[Token(Token = "0x40383B4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelAllTimeOut;

		// Token: 0x040383B5 RID: 230325
		[Token(Token = "0x40383B5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EventOnZoneAllTimeoutClicked;

		// Token: 0x040383B6 RID: 230326
		[Token(Token = "0x40383B6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x040383B7 RID: 230327
		[Token(Token = "0x40383B7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
