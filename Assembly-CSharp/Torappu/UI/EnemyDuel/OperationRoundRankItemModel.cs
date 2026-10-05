using System;
using Il2CppDummyDll;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x0200500D RID: 20493
	[Token(Token = "0x200500D")]
	public struct OperationRoundRankItemModel
	{
		// Token: 0x04028AEE RID: 166638
		[Token(Token = "0x4028AEE")]
		[FieldOffset(Offset = "0x0")]
		public string actId;

		// Token: 0x04028AEF RID: 166639
		[Token(Token = "0x4028AEF")]
		[FieldOffset(Offset = "0x8")]
		public int rank;

		// Token: 0x04028AF0 RID: 166640
		[Token(Token = "0x4028AF0")]
		[FieldOffset(Offset = "0xC")]
		public bool isPlayer;

		// Token: 0x04028AF1 RID: 166641
		[Token(Token = "0x4028AF1")]
		[FieldOffset(Offset = "0xD")]
		public bool isNPC;

		// Token: 0x04028AF2 RID: 166642
		[Token(Token = "0x4028AF2")]
		[FieldOffset(Offset = "0xE")]
		public bool isOut;

		// Token: 0x04028AF3 RID: 166643
		[Token(Token = "0x4028AF3")]
		[FieldOffset(Offset = "0x10")]
		public string nickName;

		// Token: 0x04028AF4 RID: 166644
		[Token(Token = "0x4028AF4")]
		[FieldOffset(Offset = "0x18")]
		public int currMoney;

		// Token: 0x04028AF5 RID: 166645
		[Token(Token = "0x4028AF5")]
		[FieldOffset(Offset = "0x1C")]
		public int prevMoney;

		// Token: 0x04028AF6 RID: 166646
		[Token(Token = "0x4028AF6")]
		[FieldOffset(Offset = "0x20")]
		public bool showWinCnt;

		// Token: 0x04028AF7 RID: 166647
		[Token(Token = "0x4028AF7")]
		[FieldOffset(Offset = "0x24")]
		public int winCnt;

		// Token: 0x04028AF8 RID: 166648
		[Token(Token = "0x4028AF8")]
		[FieldOffset(Offset = "0x28")]
		public PlayerAvatarQuery avatarQuery;

		// Token: 0x04028AF9 RID: 166649
		[Token(Token = "0x4028AF9")]
		[FieldOffset(Offset = "0x40")]
		public string npcAvatarId;
	}
}
