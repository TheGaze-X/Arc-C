using System;
using Il2CppDummyDll;

namespace Torappu.ObjectPool
{
	// Token: 0x02001486 RID: 5254
	[Token(Token = "0x2001486")]
	public abstract class ReleasePolicyAssigner
	{
		// Token: 0x0600798E RID: 31118
		[Token(Token = "0x600798E")]
		public abstract void Assign(ref GameObjectPool.Options option);

		// Token: 0x0600798F RID: 31119
		[Token(Token = "0x600798F")]
		public abstract bool TryMatch(string poolName);

		// Token: 0x06007990 RID: 31120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007990")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected ReleasePolicyAssigner()
		{
		}
	}
}
