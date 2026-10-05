using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006EFD RID: 28413
	[Token(Token = "0x2006EFD")]
	public class ActMultiV3NameCardParam : IPlayerStatus, IHotfixable
	{
		// Token: 0x060285DC RID: 165340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60285DC")]
		[Address(RVA = "0x23BA920", Offset = "0x23B9520", VA = "0x1823BA920", Slot = "4")]
		public AvatarInfo GetAvatarInfo()
		{
			return null;
		}

		// Token: 0x060285DD RID: 165341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60285DD")]
		[Address(RVA = "0x23BA980", Offset = "0x23B9580", VA = "0x1823BA980", Slot = "5")]
		public string GetSecretarySkinId()
		{
			return null;
		}

		// Token: 0x060285DE RID: 165342 RVA: 0x000D1A90 File Offset: 0x000CFC90
		[Token(Token = "0x60285DE")]
		[Address(RVA = "0x23BA9E0", Offset = "0x23B95E0", VA = "0x1823BA9E0", Slot = "6")]
		public bool GetSecretarySkinSp()
		{
			return default(bool);
		}

		// Token: 0x060285DF RID: 165343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285DF")]
		[Address(RVA = "0x23BAA40", Offset = "0x23B9640", VA = "0x1823BAA40")]
		public ActMultiV3NameCardParam()
		{
		}

		// Token: 0x04039639 RID: 235065
		[Token(Token = "0x4039639")]
		[FieldOffset(Offset = "0x10")]
		public bool isMentor;

		// Token: 0x0403963A RID: 235066
		[Token(Token = "0x403963A")]
		[FieldOffset(Offset = "0x18")]
		public string title;

		// Token: 0x0403963B RID: 235067
		[Token(Token = "0x403963B")]
		[FieldOffset(Offset = "0x20")]
		public int level;

		// Token: 0x0403963C RID: 235068
		[Token(Token = "0x403963C")]
		[FieldOffset(Offset = "0x28")]
		public string nickName;

		// Token: 0x0403963D RID: 235069
		[Token(Token = "0x403963D")]
		[FieldOffset(Offset = "0x30")]
		public string uid;

		// Token: 0x0403963E RID: 235070
		[Token(Token = "0x403963E")]
		[FieldOffset(Offset = "0x38")]
		public AvatarInfo avatarInfo;

		// Token: 0x0403963F RID: 235071
		[Token(Token = "0x403963F")]
		[FieldOffset(Offset = "0x40")]
		public string secretary;

		// Token: 0x04039640 RID: 235072
		[Token(Token = "0x4039640")]
		[FieldOffset(Offset = "0x48")]
		public string secretarySkinId;

		// Token: 0x04039641 RID: 235073
		[Token(Token = "0x4039641")]
		[FieldOffset(Offset = "0x50")]
		public bool secretarySkinSp;

		// Token: 0x04039642 RID: 235074
		[Token(Token = "0x4039642")]
		[FieldOffset(Offset = "0x54")]
		public PlayerAvatarType avatarType;

		// Token: 0x04039643 RID: 235075
		[Token(Token = "0x4039643")]
		[FieldOffset(Offset = "0x58")]
		public string nameCardSkinId;

		// Token: 0x04039644 RID: 235076
		[Token(Token = "0x4039644")]
		[FieldOffset(Offset = "0x60")]
		public int nameCardSkinTmpl;

		// Token: 0x04039645 RID: 235077
		[Token(Token = "0x4039645")]
		[FieldOffset(Offset = "0x64")]
		public bool isEarlyQuit;

		// Token: 0x04039646 RID: 235078
		[Token(Token = "0x4039646")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAvatarInfo;

		// Token: 0x04039647 RID: 235079
		[Token(Token = "0x4039647")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetSecretarySkinId;

		// Token: 0x04039648 RID: 235080
		[Token(Token = "0x4039648")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetSecretarySkinSp;

		// Token: 0x04039649 RID: 235081
		[Token(Token = "0x4039649")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
