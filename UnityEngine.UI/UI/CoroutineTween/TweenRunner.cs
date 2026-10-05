using System;
using System.Collections;
using Il2CppDummyDll;

namespace UnityEngine.UI.CoroutineTween
{
	// Token: 0x020000A1 RID: 161
	[Token(Token = "0x20000A1")]
	internal class TweenRunner<T> where T : struct, ITweenValue
	{
		// Token: 0x060005F7 RID: 1527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F7")]
		private static IEnumerator Start(T tweenInfo)
		{
			return null;
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005F8")]
		public void Init(MonoBehaviour coroutineContainer)
		{
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005F9")]
		public void StartTween(T info)
		{
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005FA")]
		public void StopTween()
		{
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005FB")]
		public TweenRunner()
		{
		}

		// Token: 0x040002E0 RID: 736
		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0x0")]
		protected MonoBehaviour m_CoroutineContainer;

		// Token: 0x040002E1 RID: 737
		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0x0")]
		protected IEnumerator m_Tween;
	}
}
