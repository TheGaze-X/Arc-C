using System;
using Il2CppDummyDll;

namespace Torappu.Audio.Engine
{
	// Token: 0x0200026A RID: 618
	[Token(Token = "0x200026A")]
	public interface IPlayAudioParam
	{
		// Token: 0x06000E11 RID: 3601
		[Token(Token = "0x6000E11")]
		string GetSignal();

		// Token: 0x06000E12 RID: 3602
		[Token(Token = "0x6000E12")]
		IAudioInfo GetInfo();

		// Token: 0x06000E13 RID: 3603
		[Token(Token = "0x6000E13")]
		string GetPersistTag();
	}
}
