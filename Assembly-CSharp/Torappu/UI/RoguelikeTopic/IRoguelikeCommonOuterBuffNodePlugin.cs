using System;
using Il2CppDummyDll;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044F2 RID: 17650
	[Token(Token = "0x20044F2")]
	public interface IRoguelikeCommonOuterBuffNodePlugin
	{
		// Token: 0x0601AF19 RID: 110361
		[Token(Token = "0x601AF19")]
		void Init(RoguelikeCommonOuterBuffNodeBaseViewModel model);

		// Token: 0x0601AF1A RID: 110362
		[Token(Token = "0x601AF1A")]
		void Render(string selectedBuffId, RoguelikeCommonOuterBuffNodeBaseViewModel model);
	}
}
