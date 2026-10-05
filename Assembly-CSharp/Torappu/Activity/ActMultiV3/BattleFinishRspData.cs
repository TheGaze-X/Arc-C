using System;
using Il2CppDummyDll;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006ECB RID: 28363
	[Token(Token = "0x2006ECB")]
	public class BattleFinishRspData
	{
		// Token: 0x06028542 RID: 165186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028542")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BattleFinishRspData()
		{
		}

		// Token: 0x0403951E RID: 234782
		[Token(Token = "0x403951E")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		// Token: 0x0403951F RID: 234783
		[Token(Token = "0x403951F")]
		[FieldOffset(Offset = "0x14")]
		public bool mateQuit;

		// Token: 0x04039520 RID: 234784
		[Token(Token = "0x4039520")]
		[FieldOffset(Offset = "0x18")]
		public BattleFinishNormalModeRspData normal;

		// Token: 0x04039521 RID: 234785
		[Token(Token = "0x4039521")]
		[FieldOffset(Offset = "0x20")]
		public BattleFinishFootballModeRspData football;

		// Token: 0x04039522 RID: 234786
		[Token(Token = "0x4039522")]
		[FieldOffset(Offset = "0x28")]
		public BattleFinishDefenceModeRspData defence;

		// Token: 0x04039523 RID: 234787
		[Token(Token = "0x4039523")]
		[FieldOffset(Offset = "0x30")]
		public BattleFinishRaftModeRspData raft;

		// Token: 0x04039524 RID: 234788
		[Token(Token = "0x4039524")]
		[FieldOffset(Offset = "0x38")]
		public int star;

		// Token: 0x04039525 RID: 234789
		[Token(Token = "0x4039525")]
		[FieldOffset(Offset = "0x40")]
		public BattleFinishRewardRspData reward;

		// Token: 0x04039526 RID: 234790
		[Token(Token = "0x4039526")]
		[FieldOffset(Offset = "0x48")]
		public bool sameChannel;

		// Token: 0x04039527 RID: 234791
		[Token(Token = "0x4039527")]
		[FieldOffset(Offset = "0x49")]
		public bool isFriend;

		// Token: 0x04039528 RID: 234792
		[Token(Token = "0x4039528")]
		[FieldOffset(Offset = "0x4C")]
		public int reverse;

		// Token: 0x04039529 RID: 234793
		[Token(Token = "0x4039529")]
		[FieldOffset(Offset = "0x50")]
		public long ts;

		// Token: 0x0403952A RID: 234794
		[Token(Token = "0x403952A")]
		[FieldOffset(Offset = "0x58")]
		public bool newPhoto;

		// Token: 0x0403952B RID: 234795
		[Token(Token = "0x403952B")]
		[FieldOffset(Offset = "0x60")]
		public string newPhotoId;
	}
}
