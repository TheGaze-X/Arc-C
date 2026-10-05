using System;
using Il2CppDummyDll;
using Torappu.UI.AutoChess.Server;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200629B RID: 25243
	[Token(Token = "0x200629B")]
	public class AutoChessBandChoosePlayerModel
	{
		// Token: 0x06024655 RID: 149077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024655")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AutoChessBandChoosePlayerModel()
		{
		}

		// Token: 0x04032A35 RID: 207413
		[Token(Token = "0x4032A35")]
		[FieldOffset(Offset = "0x10")]
		public AutoChessBandChoosePlayerStatus status;

		// Token: 0x04032A36 RID: 207414
		[Token(Token = "0x4032A36")]
		[FieldOffset(Offset = "0x18")]
		public string nickName;

		// Token: 0x04032A37 RID: 207415
		[Token(Token = "0x4032A37")]
		[FieldOffset(Offset = "0x20")]
		public string nickNumber;

		// Token: 0x04032A38 RID: 207416
		[Token(Token = "0x4032A38")]
		[FieldOffset(Offset = "0x28")]
		public string alias;

		// Token: 0x04032A39 RID: 207417
		[Token(Token = "0x4032A39")]
		[FieldOffset(Offset = "0x30")]
		public PlayerAvatarQuery avatar;

		// Token: 0x04032A3A RID: 207418
		[Token(Token = "0x4032A3A")]
		[FieldOffset(Offset = "0x48")]
		public AutoChessBandChooseBandItemModel selectedBand;

		// Token: 0x04032A3B RID: 207419
		[Token(Token = "0x4032A3B")]
		[FieldOffset(Offset = "0x50")]
		public string nameCardSkinId;

		// Token: 0x04032A3C RID: 207420
		[Token(Token = "0x4032A3C")]
		[FieldOffset(Offset = "0x58")]
		public int nameCardSkinTmpl;

		// Token: 0x04032A3D RID: 207421
		[Token(Token = "0x4032A3D")]
		[FieldOffset(Offset = "0x60")]
		public string medalIconId;

		// Token: 0x04032A3E RID: 207422
		[Token(Token = "0x4032A3E")]
		[FieldOffset(Offset = "0x68")]
		public bool isSelf;

		// Token: 0x04032A3F RID: 207423
		[Token(Token = "0x4032A3F")]
		[FieldOffset(Offset = "0x69")]
		public bool isShowSnapshotVictorIcon;

		// Token: 0x04032A40 RID: 207424
		[Token(Token = "0x4032A40")]
		[FieldOffset(Offset = "0x6C")]
		public AutoChessPlayerConnectState connState;
	}
}
