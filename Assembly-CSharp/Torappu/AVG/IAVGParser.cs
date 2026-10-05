using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.AVG
{
	// Token: 0x02001EE4 RID: 7908
	[Token(Token = "0x2001EE4")]
	public interface IAVGParser
	{
		// Token: 0x0600C441 RID: 50241
		[Token(Token = "0x600C441")]
		string GetErrorMessage();

		// Token: 0x0600C442 RID: 50242
		[Token(Token = "0x600C442")]
		bool TryParse(string content, out List<Command> commands);

		// Token: 0x0600C443 RID: 50243
		[Token(Token = "0x600C443")]
		bool TryParse(string content, Story.StoryParam param, out Story story);
	}
}
