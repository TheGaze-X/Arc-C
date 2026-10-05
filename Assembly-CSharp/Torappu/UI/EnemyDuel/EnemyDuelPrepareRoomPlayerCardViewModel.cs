using System;
using Il2CppDummyDll;
using Torappu.UI.EnemyDuel.Service;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02005042 RID: 20546
	[Token(Token = "0x2005042")]
	public class EnemyDuelPrepareRoomPlayerCardViewModel
	{
		// Token: 0x0601E777 RID: 124791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E777")]
		[Address(RVA = "0x1828540", Offset = "0x1827140", VA = "0x181828540")]
		public void LoadData(EnemyDuelPrepareRoomPlayerCardViewModel.LoadParam param)
		{
		}

		// Token: 0x0601E778 RID: 124792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E778")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EnemyDuelPrepareRoomPlayerCardViewModel()
		{
		}

		// Token: 0x04028CA8 RID: 167080
		[Token(Token = "0x4028CA8")]
		[FieldOffset(Offset = "0x10")]
		public int idx;

		// Token: 0x04028CA9 RID: 167081
		[Token(Token = "0x4028CA9")]
		[FieldOffset(Offset = "0x14")]
		public EnemyDuelPrepareRoomPlayerCardViewModel.State state;

		// Token: 0x04028CAA RID: 167082
		[Token(Token = "0x4028CAA")]
		[FieldOffset(Offset = "0x18")]
		public EnemyDuelPrepareRoomPlayerCardViewModel.FriendState friendState;

		// Token: 0x04028CAB RID: 167083
		[Token(Token = "0x4028CAB")]
		[FieldOffset(Offset = "0x1C")]
		public bool isFirstEmpty;

		// Token: 0x04028CAC RID: 167084
		[Token(Token = "0x4028CAC")]
		[FieldOffset(Offset = "0x1D")]
		public bool isHost;

		// Token: 0x04028CAD RID: 167085
		[Token(Token = "0x4028CAD")]
		[FieldOffset(Offset = "0x1E")]
		public bool isSelf;

		// Token: 0x04028CAE RID: 167086
		[Token(Token = "0x4028CAE")]
		[FieldOffset(Offset = "0x20")]
		public PlayerAvatarQuery avatarQuery;

		// Token: 0x04028CAF RID: 167087
		[Token(Token = "0x4028CAF")]
		[FieldOffset(Offset = "0x38")]
		public string nickName;

		// Token: 0x04028CB0 RID: 167088
		[Token(Token = "0x4028CB0")]
		[FieldOffset(Offset = "0x40")]
		public string uid;

		// Token: 0x02005043 RID: 20547
		[Token(Token = "0x2005043")]
		public struct LoadParam
		{
			// Token: 0x04028CB1 RID: 167089
			[Token(Token = "0x4028CB1")]
			[FieldOffset(Offset = "0x0")]
			public int idx;

			// Token: 0x04028CB2 RID: 167090
			[Token(Token = "0x4028CB2")]
			[FieldOffset(Offset = "0x8")]
			public EnemyDuelServiceTeamInfo teamInfo;

			// Token: 0x04028CB3 RID: 167091
			[Token(Token = "0x4028CB3")]
			[FieldOffset(Offset = "0x10")]
			public STDuelPlayerStatus playerStatus;

			// Token: 0x04028CB4 RID: 167092
			[Token(Token = "0x4028CB4")]
			[FieldOffset(Offset = "0x18")]
			public bool isFirstEmpty;

			// Token: 0x04028CB5 RID: 167093
			[Token(Token = "0x4028CB5")]
			[FieldOffset(Offset = "0x1C")]
			public EnemyDuelPrepareRoomPlayerCardViewModel.FriendState friendState;
		}

		// Token: 0x02005044 RID: 20548
		[Token(Token = "0x2005044")]
		public enum State
		{
			// Token: 0x04028CB7 RID: 167095
			[Token(Token = "0x4028CB7")]
			EMPTY,
			// Token: 0x04028CB8 RID: 167096
			[Token(Token = "0x4028CB8")]
			READY,
			// Token: 0x04028CB9 RID: 167097
			[Token(Token = "0x4028CB9")]
			BATTLE_FINISHING,
			// Token: 0x04028CBA RID: 167098
			[Token(Token = "0x4028CBA")]
			OFFLINE
		}

		// Token: 0x02005045 RID: 20549
		[Token(Token = "0x2005045")]
		public enum FriendState
		{
			// Token: 0x04028CBC RID: 167100
			[Token(Token = "0x4028CBC")]
			NOT_FRIEND,
			// Token: 0x04028CBD RID: 167101
			[Token(Token = "0x4028CBD")]
			SENT_REQUEST,
			// Token: 0x04028CBE RID: 167102
			[Token(Token = "0x4028CBE")]
			FRIEND
		}
	}
}
