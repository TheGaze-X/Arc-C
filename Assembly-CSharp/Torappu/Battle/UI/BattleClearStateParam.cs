using System;
using Il2CppDummyDll;

namespace Torappu.Battle.UI
{
	// Token: 0x020032E5 RID: 13029
	[Token(Token = "0x20032E5")]
	public struct BattleClearStateParam
	{
		// Token: 0x04018997 RID: 100759
		[Token(Token = "0x4018997")]
		[FieldOffset(Offset = "0x0")]
		public bool isServiceSucceed;

		// Token: 0x04018998 RID: 100760
		[Token(Token = "0x4018998")]
		[FieldOffset(Offset = "0x1")]
		public bool isGiveUp;

		// Token: 0x04018999 RID: 100761
		[Token(Token = "0x4018999")]
		[FieldOffset(Offset = "0x2")]
		public bool isMultipleBattle;

		// Token: 0x0401899A RID: 100762
		[Token(Token = "0x401899A")]
		[FieldOffset(Offset = "0x4")]
		public PlayerBattleRank battleRank;

		// Token: 0x0401899B RID: 100763
		[Token(Token = "0x401899B")]
		[FieldOffset(Offset = "0x8")]
		public CommonFinishBattleResponse finishResponse;
	}
}
