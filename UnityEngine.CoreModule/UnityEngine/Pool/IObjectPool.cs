using System;
using Il2CppDummyDll;

namespace UnityEngine.Pool
{
	// Token: 0x02000230 RID: 560
	[Token(Token = "0x2000230")]
	public interface IObjectPool<T> where T : class
	{
		// Token: 0x06000D38 RID: 3384
		[Token(Token = "0x6000D38")]
		void Release(T element);
	}
}
