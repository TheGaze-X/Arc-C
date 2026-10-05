using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act35side
{
	// Token: 0x02007475 RID: 29813
	[Token(Token = "0x2007475")]
	public class Act35sideEntryMilestonePlugin : AbstractTemplateActivityEntryMilestonePlugin, IHotfixable
	{
		// Token: 0x0602A0D9 RID: 172249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0D9")]
		[Address(RVA = "0x2598050", Offset = "0x2596C50", VA = "0x182598050", Slot = "6")]
		protected override void OnViewModelRefresh(TemplateActivityMilestoneGroupViewModel templateViewModel)
		{
		}

		// Token: 0x0602A0DA RID: 172250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0DA")]
		[Address(RVA = "0x2598350", Offset = "0x2596F50", VA = "0x182598350")]
		public Act35sideEntryMilestonePlugin()
		{
		}

		// Token: 0x0403C578 RID: 247160
		[Token(Token = "0x403C578")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text[] _textLevel;

		// Token: 0x0403C579 RID: 247161
		[Token(Token = "0x403C579")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403C57A RID: 247162
		[Token(Token = "0x403C57A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
