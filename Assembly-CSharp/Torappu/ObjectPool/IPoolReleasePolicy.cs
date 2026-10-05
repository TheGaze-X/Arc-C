using System;
using Il2CppDummyDll;

namespace Torappu.ObjectPool
{
	// Token: 0x02001485 RID: 5253
	[Token(Token = "0x2001485")]
	public interface IPoolReleasePolicy
	{
		// Token: 0x0600798C RID: 31116
		[Token(Token = "0x600798C")]
		float GetCheckIntervalSeconds();

		// Token: 0x0600798D RID: 31117
		[Token(Token = "0x600798D")]
		int EvaluateReleaseCount(GameObjectPoolStats stats, float now);
	}
}
