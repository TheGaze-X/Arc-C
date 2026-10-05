using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SocialCardAlbum
{
	// Token: 0x02003EBF RID: 16063
	[Token(Token = "0x2003EBF")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class SocialCardAlbumUtil
	{
		// Token: 0x06018EEB RID: 102123 RVA: 0x0009C6C0 File Offset: 0x0009A8C0
		[Token(Token = "0x6018EEB")]
		[Address(RVA = "0x11A9350", Offset = "0x11A7F50", VA = "0x1811A9350")]
		public static bool CheckSelfAlbumValid()
		{
			return default(bool);
		}

		// Token: 0x06018EEC RID: 102124 RVA: 0x0009C6D8 File Offset: 0x0009A8D8
		[Token(Token = "0x6018EEC")]
		[Address(RVA = "0x11A92A0", Offset = "0x11A7EA0", VA = "0x1811A92A0")]
		public static bool CheckFriendAlbumValid(FriendDataWithNameCard friendData)
		{
			return default(bool);
		}

		// Token: 0x0401EC4A RID: 126026
		[Token(Token = "0x401EC4A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckSelfAlbumValid;

		// Token: 0x0401EC4B RID: 126027
		[Token(Token = "0x401EC4B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckFriendAlbumValid;
	}
}
