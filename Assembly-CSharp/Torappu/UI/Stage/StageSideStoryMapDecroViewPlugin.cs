using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006818 RID: 26648
	[Token(Token = "0x2006818")]
	public abstract class StageSideStoryMapDecroViewPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x060262E0 RID: 156384
		[Token(Token = "0x60262E0")]
		public abstract void OnRefresh(StageSideStoryMapDecroViewPluginParams param);

		// Token: 0x060262E1 RID: 156385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262E1")]
		[Address(RVA = "0x213CF50", Offset = "0x213BB50", VA = "0x18213CF50")]
		protected StageSideStoryMapDecroViewPlugin()
		{
		}

		// Token: 0x04035C98 RID: 220312
		[Token(Token = "0x4035C98")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
