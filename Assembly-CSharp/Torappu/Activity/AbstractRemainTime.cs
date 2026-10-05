using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D72 RID: 28018
	[Token(Token = "0x2006D72")]
	public abstract class AbstractRemainTime : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027ECD RID: 163533
		[Token(Token = "0x6027ECD")]
		public abstract void SetRemainTime(TimeSpan time);

		// Token: 0x06027ECE RID: 163534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027ECE")]
		[Address(RVA = "0x232CA40", Offset = "0x232B640", VA = "0x18232CA40")]
		protected AbstractRemainTime()
		{
		}

		// Token: 0x04038963 RID: 231779
		[Token(Token = "0x4038963")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
