using System;
using Il2CppDummyDll;
using Torappu.UI.AutoChess.Server;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062E4 RID: 25316
	[Token(Token = "0x20062E4")]
	public class AutoChessRoomPlayerCardViewModel
	{
		// Token: 0x060247DB RID: 149467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247DB")]
		[Address(RVA = "0x1F51210", Offset = "0x1F4FE10", VA = "0x181F51210")]
		public void LoadEmpty(AutoChessRoomPlayerCardViewModel.LoadParam param)
		{
		}

		// Token: 0x060247DC RID: 149468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247DC")]
		[Address(RVA = "0x1F50D70", Offset = "0x1F4F970", VA = "0x181F50D70")]
		public void LoadData(AutoChessRoomPlayerCardViewModel.LoadParam param)
		{
		}

		// Token: 0x060247DD RID: 149469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247DD")]
		[Address(RVA = "0x1F51470", Offset = "0x1F50070", VA = "0x181F51470")]
		public AutoChessRoomPlayerCardViewModel()
		{
		}

		// Token: 0x04032D6D RID: 208237
		[Token(Token = "0x4032D6D")]
		[FieldOffset(Offset = "0x10")]
		public string uid;

		// Token: 0x04032D6E RID: 208238
		[Token(Token = "0x4032D6E")]
		[FieldOffset(Offset = "0x18")]
		public CharUISkinStruct illustSkin;

		// Token: 0x04032D6F RID: 208239
		[Token(Token = "0x4032D6F")]
		[FieldOffset(Offset = "0x30")]
		public int position;

		// Token: 0x04032D70 RID: 208240
		[Token(Token = "0x4032D70")]
		[FieldOffset(Offset = "0x34")]
		public bool isUpdated;

		// Token: 0x04032D71 RID: 208241
		[Token(Token = "0x4032D71")]
		[FieldOffset(Offset = "0x35")]
		public bool isEmpty;

		// Token: 0x04032D72 RID: 208242
		[Token(Token = "0x4032D72")]
		[FieldOffset(Offset = "0x36")]
		public bool isSelf;

		// Token: 0x04032D73 RID: 208243
		[Token(Token = "0x4032D73")]
		[FieldOffset(Offset = "0x37")]
		public bool isHost;

		// Token: 0x04032D74 RID: 208244
		[Token(Token = "0x4032D74")]
		[FieldOffset(Offset = "0x38")]
		public bool isReady;

		// Token: 0x04032D75 RID: 208245
		[Token(Token = "0x4032D75")]
		[FieldOffset(Offset = "0x39")]
		public bool showDisconnect;

		// Token: 0x04032D76 RID: 208246
		[Token(Token = "0x4032D76")]
		[FieldOffset(Offset = "0x3A")]
		public bool showKickOption;

		// Token: 0x04032D77 RID: 208247
		[Token(Token = "0x4032D77")]
		[FieldOffset(Offset = "0x3B")]
		public bool showInviteOption;

		// Token: 0x04032D78 RID: 208248
		[Token(Token = "0x4032D78")]
		[FieldOffset(Offset = "0x3C")]
		public bool showNameCardOption;

		// Token: 0x04032D79 RID: 208249
		[Token(Token = "0x4032D79")]
		[FieldOffset(Offset = "0x3D")]
		public bool showFoldMenu;

		// Token: 0x04032D7A RID: 208250
		[Token(Token = "0x4032D7A")]
		[FieldOffset(Offset = "0x3E")]
		public bool isFirstEmptyCard;

		// Token: 0x04032D7B RID: 208251
		[Token(Token = "0x4032D7B")]
		[FieldOffset(Offset = "0x40")]
		public AutoChessPlayerInfo playerInfo;

		// Token: 0x04032D7C RID: 208252
		[Token(Token = "0x4032D7C")]
		[FieldOffset(Offset = "0x90")]
		public FriendState friendState;

		// Token: 0x04032D7D RID: 208253
		[Token(Token = "0x4032D7D")]
		[FieldOffset(Offset = "0x94")]
		public int medalCnt;

		// Token: 0x020062E5 RID: 25317
		[Token(Token = "0x20062E5")]
		public struct LoadParam
		{
			// Token: 0x04032D7E RID: 208254
			[Token(Token = "0x4032D7E")]
			[FieldOffset(Offset = "0x0")]
			public AutoChessPrepareModel prepareModel;

			// Token: 0x04032D7F RID: 208255
			[Token(Token = "0x4032D7F")]
			[FieldOffset(Offset = "0x8")]
			public AutoChessRoomViewModel roomViewModel;

			// Token: 0x04032D80 RID: 208256
			[Token(Token = "0x4032D80")]
			[FieldOffset(Offset = "0x10")]
			public AutoChessTeamStatus teamStatus;

			// Token: 0x04032D81 RID: 208257
			[Token(Token = "0x4032D81")]
			[FieldOffset(Offset = "0x90")]
			public MsgAutoChessPlayerStatus playerStatus;

			// Token: 0x04032D82 RID: 208258
			[Token(Token = "0x4032D82")]
			[FieldOffset(Offset = "0x98")]
			public int position;

			// Token: 0x04032D83 RID: 208259
			[Token(Token = "0x4032D83")]
			[FieldOffset(Offset = "0x9C")]
			public bool isFirstEmpty;
		}
	}
}
