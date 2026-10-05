using System;
using Il2CppDummyDll;

namespace Torappu.Audio.Middleware.Data
{
	// Token: 0x02001FC9 RID: 8137
	[Token(Token = "0x2001FC9")]
	public class FadeStyleData
	{
		// Token: 0x0600CA01 RID: 51713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA01")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FadeStyleData()
		{
		}

		// Token: 0x0400D28E RID: 53902
		[Token(Token = "0x400D28E")]
		[FieldOffset(Offset = "0x10")]
		public string styleName;

		// Token: 0x0400D28F RID: 53903
		[Token(Token = "0x400D28F")]
		[FieldOffset(Offset = "0x18")]
		public float fadeinTime;

		// Token: 0x0400D290 RID: 53904
		[Token(Token = "0x400D290")]
		[FieldOffset(Offset = "0x1C")]
		public float fadeoutTime;

		// Token: 0x0400D291 RID: 53905
		[Token(Token = "0x400D291")]
		[FieldOffset(Offset = "0x20")]
		public AudioFadeType fadeinType;

		// Token: 0x0400D292 RID: 53906
		[Token(Token = "0x400D292")]
		[FieldOffset(Offset = "0x24")]
		public AudioFadeType fadeoutType;
	}
}
