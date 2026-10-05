using System;
using Il2CppDummyDll;

namespace UnityEngine.Pool
{
	// Token: 0x02000232 RID: 562
	[Token(Token = "0x2000232")]
	public struct PooledObject<T> : IDisposable where T : class
	{
		// Token: 0x06000D42 RID: 3394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D42")]
		internal PooledObject(T value, IObjectPool<T> pool)
		{
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D43")]
		private void Dispose()
		{
		}

		// Token: 0x04000609 RID: 1545
		[Token(Token = "0x4000609")]
		[FieldOffset(Offset = "0x0")]
		private readonly T m_ToReturn;

		// Token: 0x0400060A RID: 1546
		[Token(Token = "0x400060A")]
		[FieldOffset(Offset = "0x0")]
		private readonly IObjectPool<T> m_Pool;
	}
}
