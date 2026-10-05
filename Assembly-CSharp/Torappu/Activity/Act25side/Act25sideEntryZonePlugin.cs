using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074D8 RID: 29912
	[Token(Token = "0x20074D8")]
	public class Act25sideEntryZonePlugin : TemplateActivityCommonPlugin
	{
		// Token: 0x0602A2B7 RID: 172727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2B7")]
		[Address(RVA = "0x25C9540", Offset = "0x25C8140", VA = "0x1825C9540")]
		public void EventOnZoneAllTimeoutClicked()
		{
		}

		// Token: 0x0602A2B8 RID: 172728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2B8")]
		[Address(RVA = "0x25C95F0", Offset = "0x25C81F0", VA = "0x1825C95F0", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x0602A2B9 RID: 172729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2B9")]
		[Address(RVA = "0x25C9940", Offset = "0x25C8540", VA = "0x1825C9940")]
		public Act25sideEntryZonePlugin()
		{
		}

		// Token: 0x0403C93F RID: 248127
		[Token(Token = "0x403C93F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Act25sideEntryZoneButtonView> _buttonView;

		// Token: 0x0403C940 RID: 248128
		[Token(Token = "0x403C940")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelAllTimeOut;

		// Token: 0x0403C941 RID: 248129
		[Token(Token = "0x403C941")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EventOnZoneAllTimeoutClicked;

		// Token: 0x0403C942 RID: 248130
		[Token(Token = "0x403C942")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403C943 RID: 248131
		[Token(Token = "0x403C943")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
