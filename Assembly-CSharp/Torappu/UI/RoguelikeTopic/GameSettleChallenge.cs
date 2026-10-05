using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004550 RID: 17744
	[Token(Token = "0x2004550")]
	public class GameSettleChallenge
	{
		// Token: 0x0601B0A8 RID: 110760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B0A8")]
		[Address(RVA = "0x142F3D0", Offset = "0x142DFD0", VA = "0x18142F3D0")]
		public GameSettleChallenge()
		{
		}

		// Token: 0x04022BDA RID: 142298
		[Token(Token = "0x4022BDA")]
		[FieldOffset(Offset = "0x10")]
		public List<ItemBundle> items;

		// Token: 0x04022BDB RID: 142299
		[Token(Token = "0x4022BDB")]
		[FieldOffset(Offset = "0x18")]
		public bool before;

		// Token: 0x04022BDC RID: 142300
		[Token(Token = "0x4022BDC")]
		[FieldOffset(Offset = "0x19")]
		public bool complete;

		// Token: 0x04022BDD RID: 142301
		[Token(Token = "0x4022BDD")]
		[FieldOffset(Offset = "0x20")]
		public List<GameSettleChallengeTaskStatus> tasks;

		// Token: 0x04022BDE RID: 142302
		[Token(Token = "0x4022BDE")]
		[FieldOffset(Offset = "0x28")]
		public int score;

		// Token: 0x04022BDF RID: 142303
		[Token(Token = "0x4022BDF")]
		[FieldOffset(Offset = "0x2C")]
		public bool isHighScore;
	}
}
