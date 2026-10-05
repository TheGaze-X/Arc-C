using System;
using Il2CppDummyDll;

namespace Torappu.Audio.Engine
{
	// Token: 0x02000269 RID: 617
	[Token(Token = "0x2000269")]
	public interface IMusicInfo : IAudioInfo
	{
		// Token: 0x06000E0F RID: 3599
		[Token(Token = "0x6000E0F")]
		string GetIntroAsset();

		// Token: 0x06000E10 RID: 3600
		[Token(Token = "0x6000E10")]
		string GetLoopAsset();
	}
}
