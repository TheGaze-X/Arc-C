using System;
using Il2CppDummyDll;

namespace Vuplex.WebView
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	public interface IWithKeyDownAndUp
	{
		// Token: 0x0600015A RID: 346
		[Token(Token = "0x600015A")]
		void KeyDown(string key, KeyModifier modifiers);

		// Token: 0x0600015B RID: 347
		[Token(Token = "0x600015B")]
		void KeyUp(string key, KeyModifier modifiers);
	}
}
