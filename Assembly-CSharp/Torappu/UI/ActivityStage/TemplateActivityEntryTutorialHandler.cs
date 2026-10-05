using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CB2 RID: 27826
	[Token(Token = "0x2006CB2")]
	public abstract class TemplateActivityEntryTutorialHandler : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027B3F RID: 162623
		[Token(Token = "0x6027B3F")]
		public abstract void RegisterTutorialGO();

		// Token: 0x06027B40 RID: 162624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B40")]
		[Address(RVA = "0x22DC5B0", Offset = "0x22DB1B0", VA = "0x1822DC5B0")]
		protected TemplateActivityEntryTutorialHandler()
		{
		}

		// Token: 0x040384BD RID: 230589
		[Token(Token = "0x40384BD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
