using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D4D RID: 19789
	[Token(Token = "0x2004D4D")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class FriendUtil
	{
		// Token: 0x0601D9D7 RID: 121303 RVA: 0x000AC218 File Offset: 0x000AA418
		[Token(Token = "0x601D9D7")]
		[Address(RVA = "0x172E7C0", Offset = "0x172D3C0", VA = "0x18172E7C0")]
		public static bool CheckFriendStarEditTrack()
		{
			return default(bool);
		}

		// Token: 0x0601D9D8 RID: 121304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D9D8")]
		[Address(RVA = "0x172E8C0", Offset = "0x172D4C0", VA = "0x18172E8C0")]
		public static void ConsumeFriendStarEditTrack()
		{
		}

		// Token: 0x0601D9D9 RID: 121305 RVA: 0x000AC230 File Offset: 0x000AA430
		[Token(Token = "0x601D9D9")]
		[Address(RVA = "0x172E460", Offset = "0x172D060", VA = "0x18172E460")]
		public static FriendUtil.OnlineStatus CalcFriendLastOnlineStatus(in FriendUtil.LastOnlineInput input)
		{
			return default(FriendUtil.OnlineStatus);
		}

		// Token: 0x040271E2 RID: 160226
		[Token(Token = "0x40271E2")]
		public const string FRIEND_STAR_EDIT_TRACK_ID = "FRIEND_STAR_EDIT_TRACK";

		// Token: 0x040271E3 RID: 160227
		[Token(Token = "0x40271E3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckFriendStarEditTrack;

		// Token: 0x040271E4 RID: 160228
		[Token(Token = "0x40271E4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ConsumeFriendStarEditTrack;

		// Token: 0x040271E5 RID: 160229
		[Token(Token = "0x40271E5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CalcFriendLastOnlineStatus;

		// Token: 0x02004D4E RID: 19790
		[Token(Token = "0x2004D4E")]
		public struct OnlineStatus
		{
			// Token: 0x040271E6 RID: 160230
			[Token(Token = "0x40271E6")]
			[FieldOffset(Offset = "0x0")]
			public bool isOnline;

			// Token: 0x040271E7 RID: 160231
			[Token(Token = "0x40271E7")]
			[FieldOffset(Offset = "0x4")]
			public int offlineDays;

			// Token: 0x040271E8 RID: 160232
			[Token(Token = "0x40271E8")]
			[FieldOffset(Offset = "0x8")]
			public string timeStr;
		}

		// Token: 0x02004D4F RID: 19791
		[Token(Token = "0x2004D4F")]
		public struct LastOnlineInput
		{
			// Token: 0x040271E9 RID: 160233
			[Token(Token = "0x40271E9")]
			[FieldOffset(Offset = "0x0")]
			public DateTime currentTime;

			// Token: 0x040271EA RID: 160234
			[Token(Token = "0x40271EA")]
			[FieldOffset(Offset = "0x8")]
			public DateTime lastOnlineTime;

			// Token: 0x040271EB RID: 160235
			[Token(Token = "0x40271EB")]
			[FieldOffset(Offset = "0x10")]
			public bool bGenTimeStr;
		}
	}
}
