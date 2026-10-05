using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.DB
{
	// Token: 0x02001694 RID: 5780
	[Token(Token = "0x2001694")]
	public abstract class DBComponent<T> : MonoBehaviour, IHotfixable where T : class
	{
		// Token: 0x17000F8E RID: 3982
		// (get) Token: 0x06009279 RID: 37497
		[Token(Token = "0x17000F8E")]
		protected abstract string dataURL { [Token(Token = "0x6009279")] get; }

		// Token: 0x0600927A RID: 37498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600927A")]
		public T GetData()
		{
			return null;
		}

		// Token: 0x0600927B RID: 37499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600927B")]
		private T _InitData()
		{
			return null;
		}

		// Token: 0x0600927C RID: 37500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600927C")]
		protected DBComponent()
		{
		}

		// Token: 0x0400882F RID: 34863
		[Token(Token = "0x400882F")]
		[FieldOffset(Offset = "0x0")]
		private T cacheData;

		// Token: 0x04008830 RID: 34864
		[Token(Token = "0x4008830")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetData;

		// Token: 0x04008831 RID: 34865
		[Token(Token = "0x4008831")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitData;

		// Token: 0x04008832 RID: 34866
		[Token(Token = "0x4008832")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
