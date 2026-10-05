using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000499 RID: 1177
	[Token(Token = "0x2000499")]
	[Serializable]
	public class BattleMiscData
	{
		// Token: 0x06004CE1 RID: 19681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CE1")]
		[Address(RVA = "0x1786990", Offset = "0x1785590", VA = "0x181786990")]
		public BattleMiscData()
		{
		}

		// Token: 0x040010CA RID: 4298
		[Token(Token = "0x40010CA")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, LevelScenePair> levelScenePairs;

		// Token: 0x040010CB RID: 4299
		[Token(Token = "0x40010CB")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, List<string>> effectBlacklist;

		// Token: 0x040010CC RID: 4300
		[Token(Token = "0x40010CC")]
		[FieldOffset(Offset = "0x20")]
		public BattleMiscConfigs miscConfig;

		// Token: 0x040010CD RID: 4301
		[Token(Token = "0x40010CD")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, ParticleEffectManagerConfig> particleEffectManagerConfigs;

		// Token: 0x040010CE RID: 4302
		[Token(Token = "0x40010CE")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, List<string>> tileTypeDict;
	}
}
