using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F79 RID: 20345
	[Token(Token = "0x2004F79")]
	public class PlayerInfo : IPlayerStatus, IHotfixable
	{
		// Token: 0x0601E414 RID: 123924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E414")]
		[Address(RVA = "0x180C290", Offset = "0x180AE90", VA = "0x18180C290", Slot = "4")]
		public AvatarInfo GetAvatarInfo()
		{
			return null;
		}

		// Token: 0x0601E415 RID: 123925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E415")]
		[Address(RVA = "0x180C2F0", Offset = "0x180AEF0", VA = "0x18180C2F0", Slot = "5")]
		public string GetSecretarySkinId()
		{
			return null;
		}

		// Token: 0x0601E416 RID: 123926 RVA: 0x000AE078 File Offset: 0x000AC278
		[Token(Token = "0x601E416")]
		[Address(RVA = "0x180C350", Offset = "0x180AF50", VA = "0x18180C350", Slot = "6")]
		public bool GetSecretarySkinSp()
		{
			return default(bool);
		}

		// Token: 0x0601E417 RID: 123927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E417")]
		[Address(RVA = "0x180C3B0", Offset = "0x180AFB0", VA = "0x18180C3B0")]
		public PlayerInfo()
		{
		}

		// Token: 0x040285E3 RID: 165347
		[Token(Token = "0x40285E3")]
		[FieldOffset(Offset = "0x10")]
		public string nickName;

		// Token: 0x040285E4 RID: 165348
		[Token(Token = "0x40285E4")]
		[FieldOffset(Offset = "0x18")]
		public string nickNumber;

		// Token: 0x040285E5 RID: 165349
		[Token(Token = "0x40285E5")]
		[FieldOffset(Offset = "0x20")]
		public string uid;

		// Token: 0x040285E6 RID: 165350
		[Token(Token = "0x40285E6")]
		[FieldOffset(Offset = "0x28")]
		public AvatarInfo avatar;

		// Token: 0x040285E7 RID: 165351
		[Token(Token = "0x40285E7")]
		[FieldOffset(Offset = "0x30")]
		public string secretary;

		// Token: 0x040285E8 RID: 165352
		[Token(Token = "0x40285E8")]
		[FieldOffset(Offset = "0x38")]
		public string secretarySkinId;

		// Token: 0x040285E9 RID: 165353
		[Token(Token = "0x40285E9")]
		[FieldOffset(Offset = "0x40")]
		public bool secretarySkinSp;

		// Token: 0x040285EA RID: 165354
		[Token(Token = "0x40285EA")]
		[FieldOffset(Offset = "0x48")]
		public PlayerNameCardStyle nameCardStyle;

		// Token: 0x040285EB RID: 165355
		[Token(Token = "0x40285EB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAvatarInfo;

		// Token: 0x040285EC RID: 165356
		[Token(Token = "0x40285EC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetSecretarySkinId;

		// Token: 0x040285ED RID: 165357
		[Token(Token = "0x40285ED")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetSecretarySkinSp;

		// Token: 0x040285EE RID: 165358
		[Token(Token = "0x40285EE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
