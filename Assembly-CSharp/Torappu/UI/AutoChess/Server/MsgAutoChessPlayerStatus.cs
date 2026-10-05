using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x02006464 RID: 25700
	[Token(Token = "0x2006464")]
	public class MsgAutoChessPlayerStatus : IStreamDeserialize, IPlayerStatus, IHotfixable
	{
		// Token: 0x06024F27 RID: 151335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F27")]
		[Address(RVA = "0x1FDA080", Offset = "0x1FD8C80", VA = "0x181FDA080", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024F28 RID: 151336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F28")]
		[Address(RVA = "0x1FD9DC0", Offset = "0x1FD89C0", VA = "0x181FD9DC0")]
		public void Copy(MsgAutoChessPlayerStatus from)
		{
		}

		// Token: 0x06024F29 RID: 151337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024F29")]
		[Address(RVA = "0x1FD9F10", Offset = "0x1FD8B10", VA = "0x181FD9F10", Slot = "5")]
		public AvatarInfo GetAvatarInfo()
		{
			return null;
		}

		// Token: 0x06024F2A RID: 151338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024F2A")]
		[Address(RVA = "0x1FD9FC0", Offset = "0x1FD8BC0", VA = "0x181FD9FC0", Slot = "6")]
		public string GetSecretarySkinId()
		{
			return null;
		}

		// Token: 0x06024F2B RID: 151339 RVA: 0x000C5C58 File Offset: 0x000C3E58
		[Token(Token = "0x6024F2B")]
		[Address(RVA = "0x1FDA020", Offset = "0x1FD8C20", VA = "0x181FDA020", Slot = "7")]
		public bool GetSecretarySkinSp()
		{
			return default(bool);
		}

		// Token: 0x06024F2C RID: 151340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F2C")]
		[Address(RVA = "0x1FDA330", Offset = "0x1FD8F30", VA = "0x181FDA330")]
		public MsgAutoChessPlayerStatus()
		{
		}

		// Token: 0x04033B32 RID: 211762
		[Token(Token = "0x4033B32")]
		[FieldOffset(Offset = "0x10")]
		public string uid;

		// Token: 0x04033B33 RID: 211763
		[Token(Token = "0x4033B33")]
		[FieldOffset(Offset = "0x18")]
		public string nickName;

		// Token: 0x04033B34 RID: 211764
		[Token(Token = "0x4033B34")]
		[FieldOffset(Offset = "0x20")]
		public string nickNumber;

		// Token: 0x04033B35 RID: 211765
		[Token(Token = "0x4033B35")]
		[FieldOffset(Offset = "0x28")]
		public PlayerAvatarType avatarType;

		// Token: 0x04033B36 RID: 211766
		[Token(Token = "0x4033B36")]
		[FieldOffset(Offset = "0x30")]
		public string avatarId;

		// Token: 0x04033B37 RID: 211767
		[Token(Token = "0x4033B37")]
		[FieldOffset(Offset = "0x38")]
		public string secretary;

		// Token: 0x04033B38 RID: 211768
		[Token(Token = "0x4033B38")]
		[FieldOffset(Offset = "0x40")]
		public string secretarySkinId;

		// Token: 0x04033B39 RID: 211769
		[Token(Token = "0x4033B39")]
		[FieldOffset(Offset = "0x48")]
		public bool secretarySkinSp;

		// Token: 0x04033B3A RID: 211770
		[Token(Token = "0x4033B3A")]
		[FieldOffset(Offset = "0x50")]
		public string nameCardSkinId;

		// Token: 0x04033B3B RID: 211771
		[Token(Token = "0x4033B3B")]
		[FieldOffset(Offset = "0x58")]
		public int nameCardSkinTmpl;

		// Token: 0x04033B3C RID: 211772
		[Token(Token = "0x4033B3C")]
		[FieldOffset(Offset = "0x60")]
		public List<string> title;

		// Token: 0x04033B3D RID: 211773
		[Token(Token = "0x4033B3D")]
		[FieldOffset(Offset = "0x68")]
		public string strategy;

		// Token: 0x04033B3E RID: 211774
		[Token(Token = "0x4033B3E")]
		[FieldOffset(Offset = "0x70")]
		public int level;

		// Token: 0x04033B3F RID: 211775
		[Token(Token = "0x4033B3F")]
		[FieldOffset(Offset = "0x74")]
		public AutoChessPlayerState state;

		// Token: 0x04033B40 RID: 211776
		[Token(Token = "0x4033B40")]
		[FieldOffset(Offset = "0x78")]
		public AutoChessPlayerConnectState connState;

		// Token: 0x04033B41 RID: 211777
		[Token(Token = "0x4033B41")]
		[FieldOffset(Offset = "0x7C")]
		public int jointTs;

		// Token: 0x04033B42 RID: 211778
		[Token(Token = "0x4033B42")]
		[FieldOffset(Offset = "0x80")]
		public int medalCount;

		// Token: 0x04033B43 RID: 211779
		[Token(Token = "0x4033B43")]
		[FieldOffset(Offset = "0x84")]
		public int gsChannel;

		// Token: 0x04033B44 RID: 211780
		[Token(Token = "0x4033B44")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x04033B45 RID: 211781
		[Token(Token = "0x4033B45")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Copy;

		// Token: 0x04033B46 RID: 211782
		[Token(Token = "0x4033B46")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetAvatarInfo;

		// Token: 0x04033B47 RID: 211783
		[Token(Token = "0x4033B47")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSecretarySkinId;

		// Token: 0x04033B48 RID: 211784
		[Token(Token = "0x4033B48")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetSecretarySkinSp;

		// Token: 0x04033B49 RID: 211785
		[Token(Token = "0x4033B49")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
