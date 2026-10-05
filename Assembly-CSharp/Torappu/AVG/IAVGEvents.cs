using System;
using Il2CppDummyDll;

namespace Torappu.AVG
{
	// Token: 0x02001E31 RID: 7729
	[Token(Token = "0x2001E31")]
	public interface IAVGEvents
	{
		// Token: 0x0600BEE7 RID: 48871
		[Token(Token = "0x600BEE7")]
		void OnCommandExecute(Command cmd);

		// Token: 0x0600BEE8 RID: 48872
		[Token(Token = "0x600BEE8")]
		void OnCommandFinished(Command cmd);

		// Token: 0x0600BEE9 RID: 48873
		[Token(Token = "0x600BEE9")]
		void PreprocessStory(ref Story story);
	}
}
