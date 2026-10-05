using System;
using Il2CppDummyDll;

namespace Torappu.ObjectPool
{
	// Token: 0x02001482 RID: 5250
	[Token(Token = "0x2001482")]
	public class BattleEffectReleasePolicy : IPoolReleasePolicy
	{
		// Token: 0x06007986 RID: 31110 RVA: 0x00036978 File Offset: 0x00034B78
		[Token(Token = "0x6007986")]
		[Address(RVA = "0xB62660", Offset = "0xB61260", VA = "0x180B62660", Slot = "4")]
		public float GetCheckIntervalSeconds()
		{
			return 0f;
		}

		// Token: 0x06007987 RID: 31111 RVA: 0x00036990 File Offset: 0x00034B90
		[Token(Token = "0x6007987")]
		[Address(RVA = "0x2636690", Offset = "0x2635290", VA = "0x182636690", Slot = "5")]
		public int EvaluateReleaseCount(GameObjectPoolStats stats, float now)
		{
			return 0;
		}

		// Token: 0x06007988 RID: 31112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007988")]
		[Address(RVA = "0x26367E0", Offset = "0x26353E0", VA = "0x1826367E0")]
		public BattleEffectReleasePolicy()
		{
		}

		// Token: 0x040077B6 RID: 30646
		[Token(Token = "0x40077B6")]
		[FieldOffset(Offset = "0x10")]
		public float cooldownSeconds;

		// Token: 0x040077B7 RID: 30647
		[Token(Token = "0x40077B7")]
		[FieldOffset(Offset = "0x14")]
		public float idleSeconds;

		// Token: 0x040077B8 RID: 30648
		[Token(Token = "0x40077B8")]
		[FieldOffset(Offset = "0x18")]
		public int maxReleasePerCheck;

		// Token: 0x040077B9 RID: 30649
		[Token(Token = "0x40077B9")]
		[FieldOffset(Offset = "0x1C")]
		public float checkIntervalSeconds;
	}
}
