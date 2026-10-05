using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006C8D RID: 27789
	[Token(Token = "0x2006C8D")]
	public class TemplateActivityMapDecorZonePlugin : TemplateActivityCommonPlugin
	{
		// Token: 0x06027A5A RID: 162394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A5A")]
		[Address(RVA = "0x22DFC70", Offset = "0x22DE870", VA = "0x1822DFC70", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x06027A5B RID: 162395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A5B")]
		[Address(RVA = "0x22DFED0", Offset = "0x22DEAD0", VA = "0x1822DFED0")]
		public TemplateActivityMapDecorZonePlugin()
		{
		}

		// Token: 0x040383D7 RID: 230359
		[Token(Token = "0x40383D7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<TemplateActivityMapDecorZoneItem> _zoneViewList;

		// Token: 0x040383D8 RID: 230360
		[Token(Token = "0x40383D8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x040383D9 RID: 230361
		[Token(Token = "0x40383D9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
