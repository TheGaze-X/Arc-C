using System;
using Il2CppDummyDll;
using Torappu.Battle.EnemyDuel;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x0200501C RID: 20508
	[Token(Token = "0x200501C")]
	public class EnemyDuelRoundEndViewModel
	{
		// Token: 0x0601E6CB RID: 124619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6CB")]
		[Address(RVA = "0x18356E0", Offset = "0x18342E0", VA = "0x1818356E0")]
		public void LoadData()
		{
		}

		// Token: 0x0601E6CC RID: 124620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6CC")]
		[Address(RVA = "0x18358C0", Offset = "0x18344C0", VA = "0x1818358C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E6CD RID: 124621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6CD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EnemyDuelRoundEndViewModel()
		{
		}

		// Token: 0x04028B74 RID: 166772
		[Token(Token = "0x4028B74")]
		[FieldOffset(Offset = "0x10")]
		public EnemyDuelModeType duelMode;

		// Token: 0x04028B75 RID: 166773
		[Token(Token = "0x4028B75")]
		[FieldOffset(Offset = "0x14")]
		public EnemyDuelRoundResult roundResult;

		// Token: 0x04028B76 RID: 166774
		[Token(Token = "0x4028B76")]
		[FieldOffset(Offset = "0x18")]
		public EnemyDuelChoiceSide playerSide;

		// Token: 0x04028B77 RID: 166775
		[Token(Token = "0x4028B77")]
		[FieldOffset(Offset = "0x1C")]
		public EnemyDuelChoiceType playerChoiceType;

		// Token: 0x04028B78 RID: 166776
		[Token(Token = "0x4028B78")]
		[FieldOffset(Offset = "0x20")]
		public EnemyDuelRoundEndViewModel.PlayerInfo playerInfo;

		// Token: 0x04028B79 RID: 166777
		[Token(Token = "0x4028B79")]
		[FieldOffset(Offset = "0x48")]
		public bool isPlayerWin;

		// Token: 0x04028B7A RID: 166778
		[Token(Token = "0x4028B7A")]
		[FieldOffset(Offset = "0x49")]
		public bool isPlayerOut;

		// Token: 0x04028B7B RID: 166779
		[Token(Token = "0x4028B7B")]
		[FieldOffset(Offset = "0x4A")]
		public bool useSheild;

		// Token: 0x04028B7C RID: 166780
		[Token(Token = "0x4028B7C")]
		[FieldOffset(Offset = "0x4C")]
		public int prevMoney;

		// Token: 0x04028B7D RID: 166781
		[Token(Token = "0x4028B7D")]
		[FieldOffset(Offset = "0x50")]
		public int currMoney;

		// Token: 0x04028B7E RID: 166782
		[Token(Token = "0x4028B7E")]
		[FieldOffset(Offset = "0x54")]
		private bool m_inited;

		// Token: 0x0200501D RID: 20509
		[Token(Token = "0x200501D")]
		public struct PlayerInfo
		{
			// Token: 0x04028B7F RID: 166783
			[Token(Token = "0x4028B7F")]
			[FieldOffset(Offset = "0x0")]
			public string nickName;

			// Token: 0x04028B80 RID: 166784
			[Token(Token = "0x4028B80")]
			[FieldOffset(Offset = "0x8")]
			public string nickId;

			// Token: 0x04028B81 RID: 166785
			[Token(Token = "0x4028B81")]
			[FieldOffset(Offset = "0x10")]
			public PlayerAvatarQuery avatarQuery;
		}
	}
}
