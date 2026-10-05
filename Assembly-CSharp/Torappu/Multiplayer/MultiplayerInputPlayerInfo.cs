using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Multiplayer
{
	// Token: 0x02001550 RID: 5456
	[Token(Token = "0x2001550")]
	public class MultiplayerInputPlayerInfo : IPlayerStatus, IHotfixable
	{
		// Token: 0x06007CB2 RID: 31922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007CB2")]
		[Address(RVA = "0x2844670", Offset = "0x2843270", VA = "0x182844670", Slot = "4")]
		public AvatarInfo GetAvatarInfo()
		{
			return null;
		}

		// Token: 0x06007CB3 RID: 31923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007CB3")]
		[Address(RVA = "0x28446D0", Offset = "0x28432D0", VA = "0x1828446D0", Slot = "5")]
		public string GetSecretarySkinId()
		{
			return null;
		}

		// Token: 0x06007CB4 RID: 31924 RVA: 0x000375F0 File Offset: 0x000357F0
		[Token(Token = "0x6007CB4")]
		[Address(RVA = "0x2844730", Offset = "0x2843330", VA = "0x182844730", Slot = "6")]
		public bool GetSecretarySkinSp()
		{
			return default(bool);
		}

		// Token: 0x06007CB5 RID: 31925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CB5")]
		[Address(RVA = "0x2844790", Offset = "0x2843390", VA = "0x182844790")]
		public MultiplayerInputPlayerInfo()
		{
		}

		// Token: 0x04007D51 RID: 32081
		[Token(Token = "0x4007D51")]
		[FieldOffset(Offset = "0x10")]
		public bool isMentor;

		// Token: 0x04007D52 RID: 32082
		[Token(Token = "0x4007D52")]
		[FieldOffset(Offset = "0x18")]
		public List<string> titleList;

		// Token: 0x04007D53 RID: 32083
		[Token(Token = "0x4007D53")]
		[FieldOffset(Offset = "0x20")]
		public string nickName;

		// Token: 0x04007D54 RID: 32084
		[Token(Token = "0x4007D54")]
		[FieldOffset(Offset = "0x28")]
		public string uid;

		// Token: 0x04007D55 RID: 32085
		[Token(Token = "0x4007D55")]
		[FieldOffset(Offset = "0x30")]
		public int level;

		// Token: 0x04007D56 RID: 32086
		[Token(Token = "0x4007D56")]
		[FieldOffset(Offset = "0x38")]
		public AvatarInfo avatarInfo;

		// Token: 0x04007D57 RID: 32087
		[Token(Token = "0x4007D57")]
		[FieldOffset(Offset = "0x40")]
		public string secretary;

		// Token: 0x04007D58 RID: 32088
		[Token(Token = "0x4007D58")]
		[FieldOffset(Offset = "0x48")]
		public string secretarySkinId;

		// Token: 0x04007D59 RID: 32089
		[Token(Token = "0x4007D59")]
		[FieldOffset(Offset = "0x50")]
		public bool secretarySkinSp;

		// Token: 0x04007D5A RID: 32090
		[Token(Token = "0x4007D5A")]
		[FieldOffset(Offset = "0x58")]
		public string nameCardSkinId;

		// Token: 0x04007D5B RID: 32091
		[Token(Token = "0x4007D5B")]
		[FieldOffset(Offset = "0x60")]
		public int nameCardSkinTmpl;

		// Token: 0x04007D5C RID: 32092
		[Token(Token = "0x4007D5C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAvatarInfo;

		// Token: 0x04007D5D RID: 32093
		[Token(Token = "0x4007D5D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetSecretarySkinId;

		// Token: 0x04007D5E RID: 32094
		[Token(Token = "0x4007D5E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetSecretarySkinSp;

		// Token: 0x04007D5F RID: 32095
		[Token(Token = "0x4007D5F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
