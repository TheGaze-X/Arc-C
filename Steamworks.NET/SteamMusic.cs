using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	public static class SteamMusic
	{
		// Token: 0x060002F8 RID: 760 RVA: 0x0000587C File Offset: 0x00003A7C
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x4ECA350", Offset = "0x4EC8F50", VA = "0x184ECA350")]
		public static bool BIsEnabled()
		{
			return default(bool);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00005894 File Offset: 0x00003A94
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x4ECA3A0", Offset = "0x4EC8FA0", VA = "0x184ECA3A0")]
		public static bool BIsPlaying()
		{
			return default(bool);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x000058AC File Offset: 0x00003AAC
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x4ECA3F0", Offset = "0x4EC8FF0", VA = "0x184ECA3F0")]
		public static AudioPlayback_Status GetPlaybackStatus()
		{
			return AudioPlayback_Status.AudioPlayback_Undefined;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x4ECA580", Offset = "0x4EC9180", VA = "0x184ECA580")]
		public static void Play()
		{
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x4ECA490", Offset = "0x4EC9090", VA = "0x184ECA490")]
		public static void Pause()
		{
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x4ECA530", Offset = "0x4EC9130", VA = "0x184ECA530")]
		public static void PlayPrevious()
		{
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x4ECA4E0", Offset = "0x4EC90E0", VA = "0x184ECA4E0")]
		public static void PlayNext()
		{
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x4ECA5D0", Offset = "0x4EC91D0", VA = "0x184ECA5D0")]
		public static void SetVolume(float flVolume)
		{
		}

		// Token: 0x06000300 RID: 768 RVA: 0x000058C4 File Offset: 0x00003AC4
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x4ECA440", Offset = "0x4EC9040", VA = "0x184ECA440")]
		public static float GetVolume()
		{
			return 0f;
		}
	}
}
