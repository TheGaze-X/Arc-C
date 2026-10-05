using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020004A3 RID: 1187
	[Token(Token = "0x20004A3")]
	[Serializable]
	public class ParticleEffectManagerConfig
	{
		// Token: 0x06004CEA RID: 19690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CEA")]
		[Address(RVA = "0x17930F0", Offset = "0x1791CF0", VA = "0x1817930F0")]
		public ParticleEffectManagerConfig()
		{
		}

		// Token: 0x040010E5 RID: 4325
		[Token(Token = "0x40010E5")]
		[FieldOffset(Offset = "0x10")]
		public bool forceUseLowDetailFx;

		// Token: 0x040010E6 RID: 4326
		[Token(Token = "0x40010E6")]
		[FieldOffset(Offset = "0x14")]
		public float effectPositionThreshold;

		// Token: 0x040010E7 RID: 4327
		[Token(Token = "0x40010E7")]
		[FieldOffset(Offset = "0x18")]
		public int effectPositionMaxCount;

		// Token: 0x040010E8 RID: 4328
		[Token(Token = "0x40010E8")]
		private const float EFFECT_POSITION_THRESHOLD = 1f;

		// Token: 0x040010E9 RID: 4329
		[Token(Token = "0x40010E9")]
		private const int EFFECT_POSITION_MAX_COUNT = 3;
	}
}
