using System;
using Il2CppDummyDll;
using Torappu.Battle;

namespace Torappu.Multiplayer
{
	// Token: 0x02001543 RID: 5443
	[Token(Token = "0x2001543")]
	public class GameSettleParam
	{
		// Token: 0x06007CAB RID: 31915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CAB")]
		[Address(RVA = "0x2841A30", Offset = "0x2840630", VA = "0x182841A30")]
		public GameSettleParam()
		{
		}

		// Token: 0x04007D0B RID: 32011
		[Token(Token = "0x4007D0B")]
		[FieldOffset(Offset = "0x10")]
		public BattleController.GameResult result;

		// Token: 0x04007D0C RID: 32012
		[Token(Token = "0x4007D0C")]
		[FieldOffset(Offset = "0x14")]
		public int hp;

		// Token: 0x04007D0D RID: 32013
		[Token(Token = "0x4007D0D")]
		[FieldOffset(Offset = "0x18")]
		public int killCnt;

		// Token: 0x04007D0E RID: 32014
		[Token(Token = "0x4007D0E")]
		[FieldOffset(Offset = "0x1C")]
		public uint checkSum;

		// Token: 0x04007D0F RID: 32015
		[Token(Token = "0x4007D0F")]
		[FieldOffset(Offset = "0x20")]
		public string resultInfo;

		// Token: 0x04007D10 RID: 32016
		[Token(Token = "0x4007D10")]
		[FieldOffset(Offset = "0x28")]
		public string battleStats;
	}
}
