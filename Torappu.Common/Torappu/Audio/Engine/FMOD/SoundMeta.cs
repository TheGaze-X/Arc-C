using System;
using Il2CppDummyDll;

namespace Torappu.Audio.Engine.FMOD
{
	// Token: 0x02000274 RID: 628
	[Token(Token = "0x2000274")]
	public class SoundMeta
	{
		// Token: 0x06000E45 RID: 3653 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000E45")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SoundMeta()
		{
		}

		// Token: 0x04000ED2 RID: 3794
		[Token(Token = "0x4000ED2")]
		[FieldOffset(Offset = "0x10")]
		public bool loop;

		// Token: 0x04000ED3 RID: 3795
		[Token(Token = "0x4000ED3")]
		[FieldOffset(Offset = "0x18")]
		public MixerDesc mixer;

		// Token: 0x04000ED4 RID: 3796
		[Token(Token = "0x4000ED4")]
		[FieldOffset(Offset = "0x30")]
		public int eventIdx;
	}
}
