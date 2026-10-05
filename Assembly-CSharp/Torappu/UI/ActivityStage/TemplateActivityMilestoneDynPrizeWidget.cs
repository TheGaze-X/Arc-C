using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CC6 RID: 27846
	[Token(Token = "0x2006CC6")]
	public abstract class TemplateActivityMilestoneDynPrizeWidget : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027BA4 RID: 162724
		[Token(Token = "0x6027BA4")]
		public abstract void Render(TemplateActivityMilestoneGroupViewModel model);

		// Token: 0x06027BA5 RID: 162725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BA5")]
		[Address(RVA = "0x22E27C0", Offset = "0x22E13C0", VA = "0x1822E27C0")]
		protected TemplateActivityMilestoneDynPrizeWidget()
		{
		}

		// Token: 0x0403854D RID: 230733
		[Token(Token = "0x403854D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
