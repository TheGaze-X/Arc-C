using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace YoStar.SDK
{
	// Token: 0x02000089 RID: 137
	[Token(Token = "0x2000089")]
	public static class UIAnimator
	{
		// Token: 0x06000373 RID: 883 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x5C1AF10", Offset = "0x5C19B10", VA = "0x185C1AF10")]
		public static void Animate(MonoBehaviour caller, float duration, UnityAction<float> animation, [Optional] UnityAction completion)
		{
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x5C1AE70", Offset = "0x5C19A70", VA = "0x185C1AE70")]
		private static IEnumerator AnimateCoroutine(float duration, UnityAction<float> animation, UnityAction completion)
		{
			return null;
		}
	}
}
