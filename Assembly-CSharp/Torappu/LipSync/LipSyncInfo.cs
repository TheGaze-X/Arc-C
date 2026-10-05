using System;
using Il2CppDummyDll;

namespace Torappu.LipSync
{
	// Token: 0x0200145C RID: 5212
	[Token(Token = "0x200145C")]
	public struct LipSyncInfo
	{
		// Token: 0x040076B5 RID: 30389
		[Token(Token = "0x40076B5")]
		[FieldOffset(Offset = "0x0")]
		public string phoneme;

		// Token: 0x040076B6 RID: 30390
		[Token(Token = "0x40076B6")]
		[FieldOffset(Offset = "0x8")]
		public float volume;

		// Token: 0x040076B7 RID: 30391
		[Token(Token = "0x40076B7")]
		[FieldOffset(Offset = "0xC")]
		public float rawVolume;

		// Token: 0x040076B8 RID: 30392
		[Token(Token = "0x40076B8")]
		[FieldOffset(Offset = "0x10")]
		public float meanWeight;
	}
}
