using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x0200271B RID: 10011
	[Token(Token = "0x200271B")]
	public class PlayerBattleData
	{
		// Token: 0x06010475 RID: 66677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010475")]
		[Address(RVA = "0x80A440", Offset = "0x809040", VA = "0x18080A440")]
		public PlayerBattleData()
		{
		}

		// Token: 0x0401230E RID: 74510
		[Token(Token = "0x401230E")]
		[FieldOffset(Offset = "0x10")]
		public List<CharChess> charChesses;

		// Token: 0x0401230F RID: 74511
		[Token(Token = "0x401230F")]
		[FieldOffset(Offset = "0x18")]
		public List<EquipChess> equipChesses;

		// Token: 0x04012310 RID: 74512
		[Token(Token = "0x4012310")]
		[FieldOffset(Offset = "0x20")]
		public List<EquipChess> magicChesses;

		// Token: 0x04012311 RID: 74513
		[Token(Token = "0x4012311")]
		[FieldOffset(Offset = "0x28")]
		public List<ChessPositionInfo> chessPositionInfos;

		// Token: 0x04012312 RID: 74514
		[Token(Token = "0x4012312")]
		[FieldOffset(Offset = "0x30")]
		public List<GarrisonBond> playerBondStatus;
	}
}
