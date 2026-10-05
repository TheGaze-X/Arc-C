using System;
using Il2CppDummyDll;

namespace Torappu.Audio.Engine
{
	// Token: 0x02000268 RID: 616
	[Token(Token = "0x2000268")]
	public interface ISoundInfo : IAudioInfo
	{
		// Token: 0x06000E0B RID: 3595
		[Token(Token = "0x6000E0B")]
		string GetAsset();

		// Token: 0x06000E0C RID: 3596
		[Token(Token = "0x6000E0C")]
		MixerDesc GetMixer();

		// Token: 0x06000E0D RID: 3597
		[Token(Token = "0x6000E0D")]
		bool Loop();

		// Token: 0x06000E0E RID: 3598
		[Token(Token = "0x6000E0E")]
		float SpatialBlend();
	}
}
