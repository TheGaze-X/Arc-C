using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle.BattleFinish
{
	// Token: 0x02007833 RID: 30771
	[Token(Token = "0x2007833")]
	public abstract class Act1VHalfIdleBattleFinishSubViewBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B27B RID: 176763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B27B")]
		[Address(RVA = "0x26F5C80", Offset = "0x26F4880", VA = "0x1826F5C80", Slot = "4")]
		public virtual IEnumerator ShowEnterEffectCoroutine()
		{
			return null;
		}

		// Token: 0x0602B27C RID: 176764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B27C")]
		[Address(RVA = "0x26F5D10", Offset = "0x26F4910", VA = "0x1826F5D10")]
		protected Act1VHalfIdleBattleFinishSubViewBase()
		{
		}

		// Token: 0x0403E631 RID: 255537
		[Token(Token = "0x403E631")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowEnterEffectCoroutine;

		// Token: 0x0403E632 RID: 255538
		[Token(Token = "0x403E632")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
