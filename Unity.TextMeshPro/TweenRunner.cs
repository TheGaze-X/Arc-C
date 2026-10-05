using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	internal class TweenRunner<T> where T : struct, ITweenValue
	{
		// Token: 0x06000168 RID: 360 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000168")]
		private static IEnumerator Start(T tweenInfo)
		{
			return null;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000169")]
		public void Init(MonoBehaviour coroutineContainer)
		{
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016A")]
		public void StartTween(T info)
		{
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016B")]
		public void StopTween()
		{
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016C")]
		public TweenRunner()
		{
		}

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x0")]
		protected MonoBehaviour m_CoroutineContainer;

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x0")]
		protected IEnumerator m_Tween;
	}
}
