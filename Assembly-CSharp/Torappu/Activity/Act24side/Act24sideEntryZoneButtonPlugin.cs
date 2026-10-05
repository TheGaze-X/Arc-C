using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007590 RID: 30096
	[Token(Token = "0x2007590")]
	public class Act24sideEntryZoneButtonPlugin : TemplateActivityCommonPlugin
	{
		// Token: 0x0602A5D5 RID: 173525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5D5")]
		[Address(RVA = "0x26011A0", Offset = "0x25FFDA0", VA = "0x1826011A0", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x0602A5D6 RID: 173526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5D6")]
		[Address(RVA = "0x2601490", Offset = "0x2600090", VA = "0x182601490")]
		public Act24sideEntryZoneButtonPlugin()
		{
		}

		// Token: 0x0403CF18 RID: 249624
		[Token(Token = "0x403CF18")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Act24sideEntryZoneButtonView> _buttonView;

		// Token: 0x0403CF19 RID: 249625
		[Token(Token = "0x403CF19")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403CF1A RID: 249626
		[Token(Token = "0x403CF1A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
