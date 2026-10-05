using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1BossRush
{
	// Token: 0x020070BF RID: 28863
	[Token(Token = "0x20070BF")]
	public abstract class Act1BossRushMileStoneRewardInfoPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029057 RID: 168023
		[Token(Token = "0x6029057")]
		public abstract void Render(Act1BossRushMileStoneViewModel model);

		// Token: 0x06029058 RID: 168024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029058")]
		[Address(RVA = "0x24681D0", Offset = "0x2466DD0", VA = "0x1824681D0")]
		protected Act1BossRushMileStoneRewardInfoPlugin()
		{
		}

		// Token: 0x0403A8E7 RID: 239847
		[Token(Token = "0x403A8E7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
