using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.PlayerAvatar
{
	// Token: 0x020047CB RID: 18379
	[Token(Token = "0x20047CB")]
	public class PlayerAvatarDisplayModel : IHotfixable
	{
		// Token: 0x0601BD25 RID: 113957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD25")]
		[Address(RVA = "0x1527250", Offset = "0x1525E50", VA = "0x181527250")]
		public void FillDataByItem(UIItemViewModel model)
		{
		}

		// Token: 0x0601BD26 RID: 113958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD26")]
		[Address(RVA = "0x1527380", Offset = "0x1525F80", VA = "0x181527380")]
		public PlayerAvatarDisplayModel()
		{
		}

		// Token: 0x0402432D RID: 148269
		[Token(Token = "0x402432D")]
		[FieldOffset(Offset = "0x10")]
		public AvatarInfo avatarInfo;

		// Token: 0x0402432E RID: 148270
		[Token(Token = "0x402432E")]
		[FieldOffset(Offset = "0x18")]
		public int level;

		// Token: 0x0402432F RID: 148271
		[Token(Token = "0x402432F")]
		[FieldOffset(Offset = "0x20")]
		public string avatarName;

		// Token: 0x04024330 RID: 148272
		[Token(Token = "0x4024330")]
		[FieldOffset(Offset = "0x28")]
		public string avatarDes;

		// Token: 0x04024331 RID: 148273
		[Token(Token = "0x4024331")]
		[FieldOffset(Offset = "0x30")]
		public string avatarObtain;

		// Token: 0x04024332 RID: 148274
		[Token(Token = "0x4024332")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_FillDataByItem;

		// Token: 0x04024333 RID: 148275
		[Token(Token = "0x4024333")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
