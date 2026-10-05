using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002710 RID: 10000
	[Token(Token = "0x2002710")]
	public class SceneStateData
	{
		// Token: 0x0601046A RID: 66666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601046A")]
		[Address(RVA = "0x80B1C0", Offset = "0x809DC0", VA = "0x18080B1C0")]
		public SceneStateData()
		{
		}

		// Token: 0x040122E2 RID: 74466
		[Token(Token = "0x40122E2")]
		[FieldOffset(Offset = "0x10")]
		[JsonConverter(typeof(StringEnumConverter))]
		public AutoChessGameStateType state;

		// Token: 0x040122E3 RID: 74467
		[Token(Token = "0x40122E3")]
		[FieldOffset(Offset = "0x14")]
		public int round;

		// Token: 0x040122E4 RID: 74468
		[Token(Token = "0x40122E4")]
		[FieldOffset(Offset = "0x18")]
		public long forceEndTime;

		// Token: 0x040122E5 RID: 74469
		[Token(Token = "0x40122E5")]
		[FieldOffset(Offset = "0x20")]
		public int obIndex;

		// Token: 0x040122E6 RID: 74470
		[Token(Token = "0x40122E6")]
		[FieldOffset(Offset = "0x28")]
		public List<BattleSpecialEffect> battleSpecialEffects;

		// Token: 0x040122E7 RID: 74471
		[Token(Token = "0x40122E7")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<int, int> lastBattleResult;
	}
}
