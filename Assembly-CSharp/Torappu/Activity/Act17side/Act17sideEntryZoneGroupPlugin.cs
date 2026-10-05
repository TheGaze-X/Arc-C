using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act17side
{
	// Token: 0x020079B2 RID: 31154
	[Token(Token = "0x20079B2")]
	public class Act17sideEntryZoneGroupPlugin : TemplateActivityCommonPlugin
	{
		// Token: 0x0602BB2B RID: 178987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB2B")]
		[Address(RVA = "0x27A5280", Offset = "0x27A3E80", VA = "0x1827A5280", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x0602BB2C RID: 178988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB2C")]
		[Address(RVA = "0x27A5020", Offset = "0x27A3C20", VA = "0x1827A5020")]
		public void OnBtnZoneClick(string zoneId)
		{
		}

		// Token: 0x0602BB2D RID: 178989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB2D")]
		[Address(RVA = "0x27A55D0", Offset = "0x27A41D0", VA = "0x1827A55D0")]
		public Act17sideEntryZoneGroupPlugin()
		{
		}

		// Token: 0x0403F394 RID: 258964
		[Token(Token = "0x403F394")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Act17sideEntryZoneButtonView> _buttonView;

		// Token: 0x0403F395 RID: 258965
		[Token(Token = "0x403F395")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403F396 RID: 258966
		[Token(Token = "0x403F396")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnBtnZoneClick;

		// Token: 0x0403F397 RID: 258967
		[Token(Token = "0x403F397")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
