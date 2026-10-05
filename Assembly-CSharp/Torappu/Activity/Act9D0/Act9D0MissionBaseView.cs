using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x0200716C RID: 29036
	[Token(Token = "0x200716C")]
	public abstract class Act9D0MissionBaseView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029394 RID: 168852
		[Token(Token = "0x6029394")]
		public abstract void Render(Act9D0MissionStateBean stateBean);

		// Token: 0x06029395 RID: 168853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029395")]
		[Address(RVA = "0x2498180", Offset = "0x2496D80", VA = "0x182498180")]
		protected Act9D0MissionBaseView()
		{
		}

		// Token: 0x0403ADD4 RID: 241108
		[Token(Token = "0x403ADD4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
