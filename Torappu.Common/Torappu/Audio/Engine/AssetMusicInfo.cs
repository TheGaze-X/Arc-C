using System;
using Il2CppDummyDll;

namespace Torappu.Audio.Engine
{
	// Token: 0x0200026D RID: 621
	[Token(Token = "0x200026D")]
	public class AssetMusicInfo : IMusicInfo, IAudioInfo
	{
		// Token: 0x06000E1E RID: 3614 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E1E")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
		public string GetIntroAsset()
		{
			return null;
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E1F")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
		public string GetLoopAsset()
		{
			return null;
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x00008FE4 File Offset: 0x000071E4
		[Token(Token = "0x6000E20")]
		[Address(RVA = "0x557CB10", Offset = "0x557B710", VA = "0x18557CB10", Slot = "6")]
		public bool IsSameAudio(IAudioInfo other)
		{
			return default(bool);
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E21")]
		[Address(RVA = "0x557CA80", Offset = "0x557B680", VA = "0x18557CA80")]
		public static AssetMusicInfo EngineOnly_Create(string intro, string loop)
		{
			return null;
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000E22")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private AssetMusicInfo()
		{
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x00008FFC File Offset: 0x000071FC
		[Token(Token = "0x6000E23")]
		[Address(RVA = "0x557CC40", Offset = "0x557B840", VA = "0x18557CC40")]
		public static bool IsSameMusic(string intro, string loop, IAudioInfo other)
		{
			return default(bool);
		}

		// Token: 0x04000EB8 RID: 3768
		[Token(Token = "0x4000EB8")]
		[FieldOffset(Offset = "0x10")]
		public string intro;

		// Token: 0x04000EB9 RID: 3769
		[Token(Token = "0x4000EB9")]
		[FieldOffset(Offset = "0x18")]
		public string loop;
	}
}
