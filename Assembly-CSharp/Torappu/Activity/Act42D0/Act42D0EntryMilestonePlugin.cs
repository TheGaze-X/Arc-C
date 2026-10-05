using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x0200738A RID: 29578
	[Token(Token = "0x200738A")]
	public class Act42D0EntryMilestonePlugin : AbstractTemplateActivityEntryMilestonePlugin
	{
		// Token: 0x06029D02 RID: 171266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D02")]
		[Address(RVA = "0x255EF60", Offset = "0x255DB60", VA = "0x18255EF60", Slot = "6")]
		protected override void OnViewModelRefresh(TemplateActivityMilestoneGroupViewModel viewModel)
		{
		}

		// Token: 0x06029D03 RID: 171267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D03")]
		[Address(RVA = "0x255F040", Offset = "0x255DC40", VA = "0x18255F040")]
		public Act42D0EntryMilestonePlugin()
		{
		}

		// Token: 0x0403BE04 RID: 245252
		[Token(Token = "0x403BE04")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _imgMilestoneIcon;

		// Token: 0x0403BE05 RID: 245253
		[Token(Token = "0x403BE05")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403BE06 RID: 245254
		[Token(Token = "0x403BE06")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
