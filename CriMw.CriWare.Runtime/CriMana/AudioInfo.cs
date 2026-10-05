using System;
using Il2CppDummyDll;

namespace CriWare.CriMana
{
	// Token: 0x0200012E RID: 302
	[Token(Token = "0x200012E")]
	public struct AudioInfo
	{
		// Token: 0x0400058B RID: 1419
		[Token(Token = "0x400058B")]
		[FieldOffset(Offset = "0x0")]
		public uint samplingRate;

		// Token: 0x0400058C RID: 1420
		[Token(Token = "0x400058C")]
		[FieldOffset(Offset = "0x4")]
		public uint numChannels;

		// Token: 0x0400058D RID: 1421
		[Token(Token = "0x400058D")]
		[FieldOffset(Offset = "0x8")]
		public uint totalSamples;
	}
}
