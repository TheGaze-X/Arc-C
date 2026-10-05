using System;
using Il2CppDummyDll;

namespace Torappu.Audio.Engine
{
	// Token: 0x0200026C RID: 620
	[Token(Token = "0x200026C")]
	public struct MusicParam : IPlayAudioParam
	{
		// Token: 0x06000E19 RID: 3609 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E19")]
		[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550", Slot = "4")]
		public string GetSignal()
		{
			return null;
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E1A")]
		[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60", Slot = "5")]
		public IAudioInfo GetInfo()
		{
			return null;
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E1B")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "6")]
		public string GetPersistTag()
		{
			return null;
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x00008FCC File Offset: 0x000071CC
		[Token(Token = "0x6000E1C")]
		[Address(RVA = "0x16AE5D0", Offset = "0x16AD1D0", VA = "0x1816AE5D0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x04000EB4 RID: 3764
		[Token(Token = "0x4000EB4")]
		[FieldOffset(Offset = "0x0")]
		public static readonly MusicParam EMPTY;

		// Token: 0x04000EB5 RID: 3765
		[Token(Token = "0x4000EB5")]
		[FieldOffset(Offset = "0x0")]
		public string signal;

		// Token: 0x04000EB6 RID: 3766
		[Token(Token = "0x4000EB6")]
		[FieldOffset(Offset = "0x8")]
		public IMusicInfo info;

		// Token: 0x04000EB7 RID: 3767
		[Token(Token = "0x4000EB7")]
		[FieldOffset(Offset = "0x10")]
		public string persistTag;
	}
}
