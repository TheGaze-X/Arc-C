using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x02006463 RID: 25699
	[Token(Token = "0x2006463")]
	public struct AutoChessTeamStatus : IStreamDeserialize
	{
		// Token: 0x06024F26 RID: 151334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F26")]
		[Address(RVA = "0x1FD9330", Offset = "0x1FD7F30", VA = "0x181FD9330", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x04033B26 RID: 211750
		[Token(Token = "0x4033B26")]
		[FieldOffset(Offset = "0x0")]
		public long teamStateEndTs;

		// Token: 0x04033B27 RID: 211751
		[Token(Token = "0x4033B27")]
		[FieldOffset(Offset = "0x8")]
		public AutoChessTeamState state;

		// Token: 0x04033B28 RID: 211752
		[Token(Token = "0x4033B28")]
		[FieldOffset(Offset = "0xC")]
		public AutoChessMatchModeRange modeRange;

		// Token: 0x04033B29 RID: 211753
		[Token(Token = "0x4033B29")]
		[FieldOffset(Offset = "0x10")]
		public string modeId;

		// Token: 0x04033B2A RID: 211754
		[Token(Token = "0x4033B2A")]
		[FieldOffset(Offset = "0x18")]
		public string ownerUid;

		// Token: 0x04033B2B RID: 211755
		[Token(Token = "0x4033B2B")]
		[FieldOffset(Offset = "0x20")]
		public List<string> bannedBond;

		// Token: 0x04033B2C RID: 211756
		[Token(Token = "0x4033B2C")]
		[FieldOffset(Offset = "0x28")]
		public List<string> monsterKeys;

		// Token: 0x04033B2D RID: 211757
		[Token(Token = "0x4033B2D")]
		[FieldOffset(Offset = "0x30")]
		public string bossId;

		// Token: 0x04033B2E RID: 211758
		[Token(Token = "0x4033B2E")]
		[FieldOffset(Offset = "0x38")]
		public List<MsgAutoChessPlayerStatus> players;

		// Token: 0x04033B2F RID: 211759
		[Token(Token = "0x4033B2F")]
		[FieldOffset(Offset = "0x40")]
		public STSceneInfo scene;

		// Token: 0x04033B30 RID: 211760
		[Token(Token = "0x4033B30")]
		[FieldOffset(Offset = "0x58")]
		public StrategyDecisionBrief strategyDecisionBrief;

		// Token: 0x04033B31 RID: 211761
		[Token(Token = "0x4033B31")]
		[FieldOffset(Offset = "0x78")]
		public bool matchFlag;
	}
}
