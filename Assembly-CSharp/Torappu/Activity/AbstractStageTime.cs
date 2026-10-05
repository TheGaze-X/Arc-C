using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D73 RID: 28019
	[Token(Token = "0x2006D73")]
	public abstract class AbstractStageTime : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027ECF RID: 163535
		[Token(Token = "0x6027ECF")]
		public abstract void SetStageTimeActive(bool isActive);

		// Token: 0x06027ED0 RID: 163536
		[Token(Token = "0x6027ED0")]
		public abstract void SetRewardTimeActive(bool isActive);

		// Token: 0x06027ED1 RID: 163537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027ED1")]
		[Address(RVA = "0x232CAA0", Offset = "0x232B6A0", VA = "0x18232CAA0")]
		protected AbstractStageTime()
		{
		}

		// Token: 0x04038964 RID: 231780
		[Token(Token = "0x4038964")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
