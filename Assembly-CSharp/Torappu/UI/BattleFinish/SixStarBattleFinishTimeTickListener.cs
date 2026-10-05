using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x02006220 RID: 25120
	[Token(Token = "0x2006220")]
	public abstract class SixStarBattleFinishTimeTickListener : MonoBehaviour, IHotfixable
	{
		// Token: 0x060243DB RID: 148443
		[Token(Token = "0x60243DB")]
		public abstract void OnSetData(SixStarBattleFinishViewModel viewModel);

		// Token: 0x060243DC RID: 148444
		[Token(Token = "0x60243DC")]
		public abstract void OnTriggerTick();

		// Token: 0x060243DD RID: 148445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243DD")]
		[Address(RVA = "0x1F1C600", Offset = "0x1F1B200", VA = "0x181F1C600")]
		protected SixStarBattleFinishTimeTickListener()
		{
		}

		// Token: 0x04032644 RID: 206404
		[Token(Token = "0x4032644")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
