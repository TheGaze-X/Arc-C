using System;
using Il2CppDummyDll;

namespace Torappu.AVG
{
	// Token: 0x02001F11 RID: 7953
	[Token(Token = "0x2001F11")]
	public class StorySceneParam : ISceneParam
	{
		// Token: 0x0600C54F RID: 50511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C54F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StorySceneParam()
		{
		}

		// Token: 0x0400CA00 RID: 51712
		[Token(Token = "0x400CA00")]
		[FieldOffset(Offset = "0x10")]
		public StoryData storyData;

		// Token: 0x0400CA01 RID: 51713
		[Token(Token = "0x400CA01")]
		[FieldOffset(Offset = "0x18")]
		public string nextScene;

		// Token: 0x0400CA02 RID: 51714
		[Token(Token = "0x400CA02")]
		[FieldOffset(Offset = "0x20")]
		public GameFlowController.Options originOptions;
	}
}
