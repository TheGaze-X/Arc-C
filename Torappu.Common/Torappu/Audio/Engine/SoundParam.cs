using System;
using Il2CppDummyDll;

namespace Torappu.Audio.Engine
{
	// Token: 0x0200026B RID: 619
	[Token(Token = "0x200026B")]
	public struct SoundParam : IPlayAudioParam
	{
		// Token: 0x06000E14 RID: 3604 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E14")]
		[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550", Slot = "4")]
		public string GetSignal()
		{
			return null;
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E15")]
		[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60", Slot = "5")]
		public IAudioInfo GetInfo()
		{
			return null;
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E16")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "6")]
		public string GetPersistTag()
		{
			return null;
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x00008FB4 File Offset: 0x000071B4
		[Token(Token = "0x6000E17")]
		[Address(RVA = "0x16AE5D0", Offset = "0x16AD1D0", VA = "0x1816AE5D0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x04000EB0 RID: 3760
		[Token(Token = "0x4000EB0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SoundParam EMPTY;

		// Token: 0x04000EB1 RID: 3761
		[Token(Token = "0x4000EB1")]
		[FieldOffset(Offset = "0x0")]
		public string signal;

		// Token: 0x04000EB2 RID: 3762
		[Token(Token = "0x4000EB2")]
		[FieldOffset(Offset = "0x8")]
		public ISoundInfo info;

		// Token: 0x04000EB3 RID: 3763
		[Token(Token = "0x4000EB3")]
		[FieldOffset(Offset = "0x10")]
		public string persistTag;
	}
}
