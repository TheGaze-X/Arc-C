using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x0200049B RID: 1179
	[Token(Token = "0x200049B")]
	public class BattleMiscConfigs
	{
		// Token: 0x06004CE3 RID: 19683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CE3")]
		[Address(RVA = "0x1786860", Offset = "0x1785460", VA = "0x181786860")]
		public BattleMiscConfigs()
		{
		}

		// Token: 0x040010D0 RID: 4304
		[Token(Token = "0x40010D0")]
		[FieldOffset(Offset = "0x10")]
		public int palsyLimitedStackCnt;

		// Token: 0x040010D1 RID: 4305
		[Token(Token = "0x40010D1")]
		[FieldOffset(Offset = "0x18")]
		public string palsyOverflowEffect;

		// Token: 0x040010D2 RID: 4306
		[Token(Token = "0x40010D2")]
		[FieldOffset(Offset = "0x20")]
		public float defaultDozeAnimPlaybackSpeed;

		// Token: 0x040010D3 RID: 4307
		[Token(Token = "0x40010D3")]
		[FieldOffset(Offset = "0x28")]
		public string defaultDozeAnim;

		// Token: 0x040010D4 RID: 4308
		[Token(Token = "0x40010D4")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty("AUTOCHESS")]
		public Dictionary<string, AutoChessBattleMiscConfig> autoChessMiscConfigs;

		// Token: 0x040010D5 RID: 4309
		[Token(Token = "0x40010D5")]
		[FieldOffset(Offset = "0x38")]
		public List<float> prdBaseProbs;
	}
}
