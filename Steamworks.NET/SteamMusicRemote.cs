using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	public static class SteamMusicRemote
	{
		// Token: 0x06000301 RID: 769 RVA: 0x000058DC File Offset: 0x00003ADC
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x4EC99B0", Offset = "0x4EC85B0", VA = "0x184EC99B0")]
		public static bool RegisterSteamMusicRemote(string pchName)
		{
			return default(bool);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x000058F4 File Offset: 0x00003AF4
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x4EC95E0", Offset = "0x4EC81E0", VA = "0x184EC95E0")]
		public static bool DeregisterSteamMusicRemote()
		{
			return default(bool);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0000590C File Offset: 0x00003B0C
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x4EC9490", Offset = "0x4EC8090", VA = "0x184EC9490")]
		public static bool BIsCurrentMusicRemote()
		{
			return default(bool);
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00005924 File Offset: 0x00003B24
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x4EC9430", Offset = "0x4EC8030", VA = "0x184EC9430")]
		public static bool BActivationSuccess(bool bValue)
		{
			return default(bool);
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0000593C File Offset: 0x00003B3C
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x4EC9C10", Offset = "0x4EC8810", VA = "0x184EC9C10")]
		public static bool SetDisplayName(string pchDisplayName)
		{
			return default(bool);
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00005954 File Offset: 0x00003B54
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x4EC9D30", Offset = "0x4EC8930", VA = "0x184EC9D30")]
		public static bool SetPNGIcon_64x64(byte[] pvBuffer, uint cbBufferLength)
		{
			return default(bool);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0000596C File Offset: 0x00003B6C
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x4EC96F0", Offset = "0x4EC82F0", VA = "0x184EC96F0")]
		public static bool EnablePlayPrevious(bool bValue)
		{
			return default(bool);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00005984 File Offset: 0x00003B84
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x4EC9690", Offset = "0x4EC8290", VA = "0x184EC9690")]
		public static bool EnablePlayNext(bool bValue)
		{
			return default(bool);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0000599C File Offset: 0x00003B9C
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x4EC9810", Offset = "0x4EC8410", VA = "0x184EC9810")]
		public static bool EnableShuffled(bool bValue)
		{
			return default(bool);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x000059B4 File Offset: 0x00003BB4
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x4EC9630", Offset = "0x4EC8230", VA = "0x184EC9630")]
		public static bool EnableLooped(bool bValue)
		{
			return default(bool);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x000059CC File Offset: 0x00003BCC
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x4EC97B0", Offset = "0x4EC83B0", VA = "0x184EC97B0")]
		public static bool EnableQueue(bool bValue)
		{
			return default(bool);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x000059E4 File Offset: 0x00003BE4
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x4EC9750", Offset = "0x4EC8350", VA = "0x184EC9750")]
		public static bool EnablePlaylists(bool bValue)
		{
			return default(bool);
		}

		// Token: 0x0600030D RID: 781 RVA: 0x000059FC File Offset: 0x00003BFC
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x4ECA240", Offset = "0x4EC8E40", VA = "0x184ECA240")]
		public static bool UpdatePlaybackStatus(AudioPlayback_Status nStatus)
		{
			return default(bool);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00005A14 File Offset: 0x00003C14
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x4ECA290", Offset = "0x4EC8E90", VA = "0x184ECA290")]
		public static bool UpdateShuffled(bool bValue)
		{
			return default(bool);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00005A2C File Offset: 0x00003C2C
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x4ECA1E0", Offset = "0x4EC8DE0", VA = "0x184ECA1E0")]
		public static bool UpdateLooped(bool bValue)
		{
			return default(bool);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00005A44 File Offset: 0x00003C44
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x4ECA2F0", Offset = "0x4EC8EF0", VA = "0x184ECA2F0")]
		public static bool UpdateVolume(float flValue)
		{
			return default(bool);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00005A5C File Offset: 0x00003C5C
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x4EC9590", Offset = "0x4EC8190", VA = "0x184EC9590")]
		public static bool CurrentEntryWillChange()
		{
			return default(bool);
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00005A74 File Offset: 0x00003C74
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x4EC9530", Offset = "0x4EC8130", VA = "0x184EC9530")]
		public static bool CurrentEntryIsAvailable(bool bAvailable)
		{
			return default(bool);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00005A8C File Offset: 0x00003C8C
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x4ECA0C0", Offset = "0x4EC8CC0", VA = "0x184ECA0C0")]
		public static bool UpdateCurrentEntryText(string pchText)
		{
			return default(bool);
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00005AA4 File Offset: 0x00003CA4
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x4ECA070", Offset = "0x4EC8C70", VA = "0x184ECA070")]
		public static bool UpdateCurrentEntryElapsedSeconds(int nValue)
		{
			return default(bool);
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00005ABC File Offset: 0x00003CBC
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x4ECA010", Offset = "0x4EC8C10", VA = "0x184ECA010")]
		public static bool UpdateCurrentEntryCoverArt(byte[] pvBuffer, uint cbBufferLength)
		{
			return default(bool);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00005AD4 File Offset: 0x00003CD4
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x4EC94E0", Offset = "0x4EC80E0", VA = "0x184EC94E0")]
		public static bool CurrentEntryDidChange()
		{
			return default(bool);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00005AEC File Offset: 0x00003CEC
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x4EC9960", Offset = "0x4EC8560", VA = "0x184EC9960")]
		public static bool QueueWillChange()
		{
			return default(bool);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00005B04 File Offset: 0x00003D04
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x4EC9B20", Offset = "0x4EC8720", VA = "0x184EC9B20")]
		public static bool ResetQueueEntries()
		{
			return default(bool);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00005B1C File Offset: 0x00003D1C
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x4EC9ED0", Offset = "0x4EC8AD0", VA = "0x184EC9ED0")]
		public static bool SetQueueEntry(int nID, int nPosition, string pchEntryText)
		{
			return default(bool);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00005B34 File Offset: 0x00003D34
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x4EC9BC0", Offset = "0x4EC87C0", VA = "0x184EC9BC0")]
		public static bool SetCurrentQueueEntry(int nID)
		{
			return default(bool);
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00005B4C File Offset: 0x00003D4C
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x4EC9910", Offset = "0x4EC8510", VA = "0x184EC9910")]
		public static bool QueueDidChange()
		{
			return default(bool);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00005B64 File Offset: 0x00003D64
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x4EC98C0", Offset = "0x4EC84C0", VA = "0x184EC98C0")]
		public static bool PlaylistWillChange()
		{
			return default(bool);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00005B7C File Offset: 0x00003D7C
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x4EC9AD0", Offset = "0x4EC86D0", VA = "0x184EC9AD0")]
		public static bool ResetPlaylistEntries()
		{
			return default(bool);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00005B94 File Offset: 0x00003D94
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x4EC9D90", Offset = "0x4EC8990", VA = "0x184EC9D90")]
		public static bool SetPlaylistEntry(int nID, int nPosition, string pchEntryText)
		{
			return default(bool);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00005BAC File Offset: 0x00003DAC
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x4EC9B70", Offset = "0x4EC8770", VA = "0x184EC9B70")]
		public static bool SetCurrentPlaylistEntry(int nID)
		{
			return default(bool);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00005BC4 File Offset: 0x00003DC4
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x4EC9870", Offset = "0x4EC8470", VA = "0x184EC9870")]
		public static bool PlaylistDidChange()
		{
			return default(bool);
		}
	}
}
