using System;
using Il2CppDummyDll;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F56 RID: 20310
	[Token(Token = "0x2004F56")]
	public struct SettlementRankItemModel
	{
		// Token: 0x0402853A RID: 165178
		[Token(Token = "0x402853A")]
		[FieldOffset(Offset = "0x0")]
		public string actId;

		// Token: 0x0402853B RID: 165179
		[Token(Token = "0x402853B")]
		[FieldOffset(Offset = "0x8")]
		public EnemyDuelModeType duelMode;

		// Token: 0x0402853C RID: 165180
		[Token(Token = "0x402853C")]
		[FieldOffset(Offset = "0xC")]
		public bool isEmpty;

		// Token: 0x0402853D RID: 165181
		[Token(Token = "0x402853D")]
		[FieldOffset(Offset = "0xD")]
		public bool isSelf;

		// Token: 0x0402853E RID: 165182
		[Token(Token = "0x402853E")]
		[FieldOffset(Offset = "0xE")]
		public bool isNPC;

		// Token: 0x0402853F RID: 165183
		[Token(Token = "0x402853F")]
		[FieldOffset(Offset = "0x10")]
		public int rank;

		// Token: 0x04028540 RID: 165184
		[Token(Token = "0x4028540")]
		[FieldOffset(Offset = "0x18")]
		public string nickName;

		// Token: 0x04028541 RID: 165185
		[Token(Token = "0x4028541")]
		[FieldOffset(Offset = "0x20")]
		public string nickNumber;

		// Token: 0x04028542 RID: 165186
		[Token(Token = "0x4028542")]
		[FieldOffset(Offset = "0x28")]
		public int score;

		// Token: 0x04028543 RID: 165187
		[Token(Token = "0x4028543")]
		[FieldOffset(Offset = "0x30")]
		public PlayerAvatarQuery avatarQuery;

		// Token: 0x04028544 RID: 165188
		[Token(Token = "0x4028544")]
		[FieldOffset(Offset = "0x48")]
		public string npcAvatarId;

		// Token: 0x04028545 RID: 165189
		[Token(Token = "0x4028545")]
		[FieldOffset(Offset = "0x50")]
		public string nameCardSkinId;

		// Token: 0x04028546 RID: 165190
		[Token(Token = "0x4028546")]
		[FieldOffset(Offset = "0x58")]
		public int nameCardSkinTmpl;
	}
}
