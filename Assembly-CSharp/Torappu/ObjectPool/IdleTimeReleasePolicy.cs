using System;
using Il2CppDummyDll;

namespace Torappu.ObjectPool
{
	// Token: 0x02001483 RID: 5251
	[Token(Token = "0x2001483")]
	[Serializable]
	public class IdleTimeReleasePolicy : IPoolReleasePolicy
	{
		// Token: 0x06007989 RID: 31113 RVA: 0x000369A8 File Offset: 0x00034BA8
		[Token(Token = "0x6007989")]
		[Address(RVA = "0x738E30", Offset = "0x737A30", VA = "0x180738E30", Slot = "4")]
		public float GetCheckIntervalSeconds()
		{
			return 0f;
		}

		// Token: 0x0600798A RID: 31114 RVA: 0x000369C0 File Offset: 0x00034BC0
		[Token(Token = "0x600798A")]
		[Address(RVA = "0x2638F70", Offset = "0x2637B70", VA = "0x182638F70", Slot = "5")]
		public int EvaluateReleaseCount(GameObjectPoolStats stats, float now)
		{
			return 0;
		}

		// Token: 0x0600798B RID: 31115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600798B")]
		[Address(RVA = "0x2638FE0", Offset = "0x2637BE0", VA = "0x182638FE0")]
		public IdleTimeReleasePolicy()
		{
		}

		// Token: 0x040077BA RID: 30650
		[Token(Token = "0x40077BA")]
		[FieldOffset(Offset = "0x10")]
		public float idleSeconds;

		// Token: 0x040077BB RID: 30651
		[Token(Token = "0x40077BB")]
		[FieldOffset(Offset = "0x14")]
		public int minReserve;
	}
}
