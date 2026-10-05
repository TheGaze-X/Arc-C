using System;
using EaseFunctions;
using Il2CppDummyDll;
using Torappu.Audio.Middleware.Data;
using XLua;

namespace Torappu
{
	// Token: 0x02001418 RID: 5144
	[Token(Token = "0x2001418")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class MusicDataUtil
	{
		// Token: 0x060076CE RID: 30414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076CE")]
		[Address(RVA = "0x241F240", Offset = "0x241DE40", VA = "0x18241F240")]
		public static MusicData GetMusicByEventName(string eventName)
		{
			return null;
		}

		// Token: 0x060076CF RID: 30415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076CF")]
		[Address(RVA = "0x241F2D0", Offset = "0x241DED0", VA = "0x18241F2D0")]
		public static MusicData GetMusicById(string musicId)
		{
			return null;
		}

		// Token: 0x060076D0 RID: 30416 RVA: 0x00035160 File Offset: 0x00033360
		[Token(Token = "0x60076D0")]
		[Address(RVA = "0x241F1D0", Offset = "0x241DDD0", VA = "0x18241F1D0")]
		public static Interpolator.EaseType GetEaseTypeByFadeType(AudioFadeType audioFadeType)
		{
			return Interpolator.EaseType.unset;
		}

		// Token: 0x04007416 RID: 29718
		[Token(Token = "0x4007416")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetMusicByEventName;

		// Token: 0x04007417 RID: 29719
		[Token(Token = "0x4007417")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetMusicById;

		// Token: 0x04007418 RID: 29720
		[Token(Token = "0x4007418")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetEaseTypeByFadeType;
	}
}
