using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace YoStar.SDK.UIWidgets
{
	// Token: 0x020000E7 RID: 231
	[Token(Token = "0x20000E7")]
	public class TweenRunner<T> where T : struct, ITweenValue
	{
		// Token: 0x06000636 RID: 1590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000636")]
		private static IEnumerator Start(T tweenInfo)
		{
			return null;
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000637")]
		public void Init(MonoBehaviour coroutineContainer)
		{
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000638")]
		public void StartTween(T info)
		{
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000639")]
		public void StopTween()
		{
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600063A")]
		public TweenRunner()
		{
		}

		// Token: 0x04000370 RID: 880
		[Token(Token = "0x4000370")]
		[FieldOffset(Offset = "0x0")]
		protected MonoBehaviour m_CoroutineContainer;

		// Token: 0x04000371 RID: 881
		[Token(Token = "0x4000371")]
		[FieldOffset(Offset = "0x0")]
		protected IEnumerator m_Tween;
	}
}
