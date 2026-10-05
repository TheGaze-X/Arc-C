using System;
using Il2CppDummyDll;

namespace Torappu.Audio.Engine.FMOD
{
	// Token: 0x02000273 RID: 627
	[Token(Token = "0x2000273")]
	public class SoundData
	{
		// Token: 0x06000E44 RID: 3652 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000E44")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SoundData()
		{
		}

		// Token: 0x04000ECF RID: 3791
		[Token(Token = "0x4000ECF")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04000ED0 RID: 3792
		[Token(Token = "0x4000ED0")]
		[FieldOffset(Offset = "0x18")]
		public float length;

		// Token: 0x04000ED1 RID: 3793
		[Token(Token = "0x4000ED1")]
		[FieldOffset(Offset = "0x20")]
		public SoundMeta[] meta;
	}
}
