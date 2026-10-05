using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x0200007B RID: 123
	[Token(Token = "0x200007B")]
	public class PersistentSingleton<T> : SingletonMonoBehaviour<T> where T : MonoBehaviour
	{
		// Token: 0x06000196 RID: 406 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000196")]
		public void DestroyMe(bool immediately = false)
		{
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000197")]
		protected override void OnInit()
		{
		}

		// Token: 0x06000198 RID: 408 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000198")]
		protected override void OnDuplicated()
		{
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000199")]
		public PersistentSingleton()
		{
		}
	}
}
