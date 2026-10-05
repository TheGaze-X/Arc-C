using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x02002228 RID: 8744
	[Token(Token = "0x2002228")]
	public interface ISpecialAudioSignalSource
	{
		// Token: 0x0600DC07 RID: 56327
		[Token(Token = "0x600DC07")]
		void PreloadSpecialAudioSignals(string id, string tmplId, Action<string, string> preloader);
	}
}
