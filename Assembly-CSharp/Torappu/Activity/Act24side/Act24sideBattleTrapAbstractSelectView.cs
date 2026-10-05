using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007570 RID: 30064
	[Token(Token = "0x2007570")]
	public abstract class Act24sideBattleTrapAbstractSelectView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A536 RID: 173366
		[Token(Token = "0x602A536")]
		public abstract void Render(Act24sideBattleTrapViewModel model);

		// Token: 0x0602A537 RID: 173367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A537")]
		[Address(RVA = "0x25F61D0", Offset = "0x25F4DD0", VA = "0x1825F61D0")]
		protected Act24sideBattleTrapAbstractSelectView()
		{
		}

		// Token: 0x0403CDE9 RID: 249321
		[Token(Token = "0x403CDE9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
