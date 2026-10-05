using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act36side
{
	// Token: 0x0200744A RID: 29770
	[Token(Token = "0x200744A")]
	public class Act36sideEntryZonePlugin : TemplateActivityCommonPlugin
	{
		// Token: 0x0602A029 RID: 172073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A029")]
		[Address(RVA = "0x259B4A0", Offset = "0x259A0A0", VA = "0x18259B4A0", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x0602A02A RID: 172074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A02A")]
		[Address(RVA = "0x259B790", Offset = "0x259A390", VA = "0x18259B790")]
		public Act36sideEntryZonePlugin()
		{
		}

		// Token: 0x0403C3FD RID: 246781
		[Token(Token = "0x403C3FD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Act36sideEntryZoneButtonView> _buttonView;

		// Token: 0x0403C3FE RID: 246782
		[Token(Token = "0x403C3FE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403C3FF RID: 246783
		[Token(Token = "0x403C3FF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
