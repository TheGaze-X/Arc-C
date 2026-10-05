using System;
using Il2CppDummyDll;

namespace Torappu.Audio.Engine
{
	// Token: 0x0200025E RID: 606
	[Token(Token = "0x200025E")]
	public struct LoadAssetOptions
	{
		// Token: 0x04000E84 RID: 3716
		[Token(Token = "0x4000E84")]
		[FieldOffset(Offset = "0x0")]
		public static readonly LoadAssetOptions DEFAULT;

		// Token: 0x04000E85 RID: 3717
		[Token(Token = "0x4000E85")]
		[FieldOffset(Offset = "0x0")]
		public string persistTag;

		// Token: 0x04000E86 RID: 3718
		[Token(Token = "0x4000E86")]
		[FieldOffset(Offset = "0x8")]
		public bool loadSampleData;
	}
}
