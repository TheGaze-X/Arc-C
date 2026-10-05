using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200681B RID: 26651
	[Token(Token = "0x200681B")]
	public abstract class StageSideStoryZoneTabViewPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x060262E6 RID: 156390
		[Token(Token = "0x60262E6")]
		public abstract void Show(StageSideStoryZoneTabPluginShowParams showParams);

		// Token: 0x060262E7 RID: 156391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262E7")]
		[Address(RVA = "0x213D690", Offset = "0x213C290", VA = "0x18213D690")]
		protected StageSideStoryZoneTabViewPlugin()
		{
		}

		// Token: 0x04035CA9 RID: 220329
		[Token(Token = "0x4035CA9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
