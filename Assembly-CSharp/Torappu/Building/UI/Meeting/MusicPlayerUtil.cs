using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D50 RID: 7504
	[Token(Token = "0x2001D50")]
	public static class MusicPlayerUtil
	{
		// Token: 0x0600B941 RID: 47425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B941")]
		[Address(RVA = "0x3366B70", Offset = "0x3365770", VA = "0x183366B70")]
		public static string LoadBuildingMusicId()
		{
			return null;
		}

		// Token: 0x0600B942 RID: 47426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B942")]
		[Address(RVA = "0x3366A20", Offset = "0x3365620", VA = "0x183366A20")]
		public static string LoadBuildingMusicIdVisitMode()
		{
			return null;
		}

		// Token: 0x0600B943 RID: 47427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B943")]
		[Address(RVA = "0x3366D00", Offset = "0x3365900", VA = "0x183366D00")]
		public static string LoadGameMusicId(string buildingBgmId)
		{
			return null;
		}

		// Token: 0x0600B944 RID: 47428 RVA: 0x00045948 File Offset: 0x00043B48
		[Token(Token = "0x600B944")]
		[Address(RVA = "0x3366540", Offset = "0x3365140", VA = "0x183366540")]
		public static bool CheckMusicPlayerInUse()
		{
			return default(bool);
		}

		// Token: 0x0600B945 RID: 47429 RVA: 0x00045960 File Offset: 0x00043B60
		[Token(Token = "0x600B945")]
		[Address(RVA = "0x3366640", Offset = "0x3365240", VA = "0x183366640")]
		public static MusicPlayerUtil.MusicUnlockInfo GetCurrMusicUnlockInfo()
		{
			return default(MusicPlayerUtil.MusicUnlockInfo);
		}

		// Token: 0x0400B79A RID: 47002
		[Token(Token = "0x400B79A")]
		public const string MUSIC_PLAYER_TRACK_ID = "music_player_open";

		// Token: 0x02001D51 RID: 7505
		[Token(Token = "0x2001D51")]
		public struct MusicUnlockInfo
		{
			// Token: 0x0400B79B RID: 47003
			[Token(Token = "0x400B79B")]
			[FieldOffset(Offset = "0x0")]
			public int unlockCnt;

			// Token: 0x0400B79C RID: 47004
			[Token(Token = "0x400B79C")]
			[FieldOffset(Offset = "0x8")]
			public string firstName;
		}
	}
}
