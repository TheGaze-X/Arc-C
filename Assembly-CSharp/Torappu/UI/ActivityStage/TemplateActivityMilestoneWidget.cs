using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CC8 RID: 27848
	[Token(Token = "0x2006CC8")]
	public abstract class TemplateActivityMilestoneWidget : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027BAD RID: 162733
		[Token(Token = "0x6027BAD")]
		public abstract void Render(TemplateActivityMilestoneGroupViewModel milestoneViewModel);

		// Token: 0x06027BAE RID: 162734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BAE")]
		[Address(RVA = "0x22E4380", Offset = "0x22E2F80", VA = "0x1822E4380")]
		protected TemplateActivityMilestoneWidget()
		{
		}

		// Token: 0x0403855F RID: 230751
		[Token(Token = "0x403855F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
