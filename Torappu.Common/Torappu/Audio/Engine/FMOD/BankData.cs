using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Audio.Engine.FMOD
{
	// Token: 0x02000275 RID: 629
	[Token(Token = "0x2000275")]
	public class BankData
	{
		// Token: 0x06000E46 RID: 3654 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000E46")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BankData()
		{
		}

		// Token: 0x04000ED5 RID: 3797
		[Token(Token = "0x4000ED5")]
		[FieldOffset(Offset = "0x10")]
		public string meta;

		// Token: 0x04000ED6 RID: 3798
		[Token(Token = "0x4000ED6")]
		[FieldOffset(Offset = "0x18")]
		public string asset;

		// Token: 0x04000ED7 RID: 3799
		[Token(Token = "0x4000ED7")]
		[FieldOffset(Offset = "0x20")]
		public List<MusicData> musics;

		// Token: 0x04000ED8 RID: 3800
		[Token(Token = "0x4000ED8")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, SoundData> sounds;
	}
}
