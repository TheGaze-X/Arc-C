using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YoStar.SDK.View.Dates
{
	// Token: 0x0200010A RID: 266
	[Token(Token = "0x200010A")]
	public class DatePickerTimerComponent : MonoBehaviour
	{
		// Token: 0x0600073B RID: 1851 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600073B")]
		[Address(RVA = "0x5C45FB0", Offset = "0x5C44BB0", VA = "0x185C45FB0")]
		public void DelayedCall(float delay, Action action, MonoBehaviour target, bool forceEvenIfTargetIsInactive)
		{
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600073C")]
		[Address(RVA = "0x5C460A0", Offset = "0x5C44CA0", VA = "0x185C460A0")]
		private void Update()
		{
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600073D")]
		[Address(RVA = "0x5C464D0", Offset = "0x5C450D0", VA = "0x185C464D0")]
		public DatePickerTimerComponent()
		{
		}

		// Token: 0x04000402 RID: 1026
		[Token(Token = "0x4000402")]
		[FieldOffset(Offset = "0x18")]
		public List<DelayedAction> delayedActions;
	}
}
